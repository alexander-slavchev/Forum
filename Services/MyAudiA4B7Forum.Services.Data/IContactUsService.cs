using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using MyAudiA4B7Forum.Web.ViewModels;
using MyAudiA4B7Forum.Web.ViewModels.Administration.Emails;

namespace MyAudiA4B7Forum.Services.Data
{
    public interface IContactUsService
    {
        Task<bool> AddAsync(ContactFormViewModel input);

        Task<bool> MarkAsAnsweredAsync(int emailId);

        Task<NotAnsweredEmailsOutputViewModel> GetByIdAsync(int emailId);

        IEnumerable<NotAnsweredEmailsOutputViewModel> GetAllNotAnswered();

        Task<CountEmailsOutputViewModel> GetAllCountAsync();

        IDictionary<DateTime, int> GetNotAnsweredLast10Days();
    }
}
