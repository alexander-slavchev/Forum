namespace MyAudiA4B7Forum.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using MyAudiA4B7Forum.Common;
    using MyAudiA4B7Forum.Data.Common.Repositories;
    using MyAudiA4B7Forum.Data.Models;
    using MyAudiA4B7Forum.Web.ViewModels;
    using MyAudiA4B7Forum.Web.ViewModels.Administration.Emails;

    public class ContactUsService : IContactUsService
    {
        private readonly IRepository<ContactUs> contactRepository;

        public ContactUsService(IRepository<ContactUs> contactRepository)
        {
            this.contactRepository = contactRepository;
        }

        public async Task<bool> AddAsync(ContactFormViewModel input)
        {
            var contactFormEntry = new ContactUs
            {
                Name = input.Name,
                Email = input.Email,
                Subject = input.Subject ?? GlobalConstants.ConstSubject,
                Content = input.Content,
            };

            await this.contactRepository.AddAsync(contactFormEntry);
            var result = await this.contactRepository.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> MarkAsAnsweredAsync(int emailId)
        {
            var contactFormEntry = await this.contactRepository
                .All()
                .FirstOrDefaultAsync(c => c.Id == emailId);

            if (contactFormEntry == null)
            {
                // If Hangfire cleaned the database this might be null
                return false;
            }

            contactFormEntry.Answered = true;

            this.contactRepository.Update(contactFormEntry);
            var result = await this.contactRepository.SaveChangesAsync();

            return result > 0;
        }

        public async Task<NotAnsweredEmailsOutputViewModel> GetByIdAsync(int emailId)
        {
            var contactFormEntry = await this.contactRepository
                .All()
                .Where(c => c.Id == emailId)
                .Select(c => new NotAnsweredEmailsOutputViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Email = c.Email,
                    Subject = c.Subject,
                    Content = c.Content,
                    Answered = c.Answered,
                })
                .FirstOrDefaultAsync();

            return contactFormEntry;
        }

        public IEnumerable<NotAnsweredEmailsOutputViewModel> GetAllNotAnswered()
        {
            return this.contactRepository
                .All()
                .Where(c => c.Answered == false)
                .Select(c => new NotAnsweredEmailsOutputViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Email = c.Email,
                    Subject = c.Subject,
                    Content = c.Content,
                    CreatedOn = c.CreatedOn,
                    Answered = c.Answered,
                })
                .ToList();
        }

        public async Task<CountEmailsOutputViewModel> GetAllCountAsync()
        {
            var countAnswered = await this.contactRepository
                .All()
                .CountAsync(c => c.Answered == true);

            var countNotAnswered = await this.contactRepository
                .All()
                .CountAsync(c => c.Answered == false);

            return new CountEmailsOutputViewModel
            {
                CountAnswered = countAnswered,
                CountNotAnswered = countNotAnswered,
            };
        }

        public IDictionary<DateTime, int> GetNotAnsweredLast10Days()
        {
            var result = this.CreateEmptyResult10Days();

            var emails = this.contactRepository
                .All()
                .Where(c => c.Answered == false && c.CreatedOn > DateTime.Now.Date.AddDays(-10))
                .GroupBy(c => c.CreatedOn.Date)
                .Select(c => new
                {
                    Day = (DateTime)c.Key,
                    Value = c.Count(),
                });

            foreach (var email in emails)
            {
                if (result.ContainsKey(email.Day.Date))
                {
                    result[email.Day.Date] = email.Value;
                }
            }

            return result;
        }

        private IDictionary<DateTime, int> CreateEmptyResult10Days()
        {
            var result = new Dictionary<DateTime, int>();

            var startDate = DateTime.UtcNow.Date.AddDays(-9);

            for (DateTime i = startDate; i <= DateTime.UtcNow.Date; i = i.AddDays(1))
            {
                result.Add(i.Date, 0);
            }

            return result;
        }
    }
}
