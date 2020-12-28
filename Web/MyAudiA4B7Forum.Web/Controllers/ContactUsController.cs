namespace MyAudiA4B7Forum.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity.UI.Services;
    using Microsoft.AspNetCore.Mvc;
    using MyAudiA4B7Forum.Common;
    using MyAudiA4B7Forum.Services.Data;
    using MyAudiA4B7Forum.Web.ViewModels;

    public class ContactUsController : BaseController
    {
        private readonly IContactUsService contactFormService;
        private readonly IEmailSender emailSender;

        public ContactUsController(IContactUsService contactFormService, IEmailSender emailSender)
        {
            this.contactFormService = contactFormService;
            this.emailSender = emailSender;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(ContactFormViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            var result = await this.contactFormService.AddAsync(input);

            if (result)
            {
                    await this.emailSender.SendEmailAsync(
                    input.Email,
                    input.Name,
                    input.Subject ?? GlobalConstants.ConstSubject
                    );

                this.TempData["InfoMessage"] = "Thank you for your email!";
            }

            return this.Redirect("/Home/Index");
        }
    }
}
