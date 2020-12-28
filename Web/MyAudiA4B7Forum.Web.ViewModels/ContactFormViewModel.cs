namespace MyAudiA4B7Forum.Web.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    using MyAudiA4B7Forum.Common;
    using MyAudiA4B7Forum.Data.Models;
    using MyAudiA4B7Forum.Services.Mapping;

    public class ContactFormViewModel : IMapFrom<ContactUs>, IMapTo<ContactUs>
    {
        [Required]
        [StringLength(20, ErrorMessage = GlobalConstants.TextError, MinimumLength = 3)]
        [Display(Name = "Full name")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [StringLength(20, ErrorMessage = GlobalConstants.ShortTextError)]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required]
        [StringLength(10000, ErrorMessage = GlobalConstants.TextError, MinimumLength = 20)]
        [Display(Name = "Content")]
        public string Content { get; set; }
    }
}
