using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using MyAudiA4B7Forum;
using MyAudiA4B7Forum.Common;

namespace MyAudiA4B7Forum.Web.ViewModels.Administration.Emails
{
    public class SendReplayViewModel
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        public string Content { get; set; }

        public bool Answered { get; set; }

        [Required]
        [StringLength(10000, ErrorMessage = GlobalConstants.TextError, MinimumLength = 20)]
        [Display(Name = "Answer")]
        public string Answer { get; set; }
    }
}
