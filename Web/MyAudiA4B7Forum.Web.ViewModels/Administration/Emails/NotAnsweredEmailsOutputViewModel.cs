using MyAudiA4B7Forum.Data.Models;
using MyAudiA4B7Forum.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAudiA4B7Forum.Web.ViewModels.Administration.Emails
{
    public class NotAnsweredEmailsOutputViewModel : IMapFrom<ContactUs>, IMapTo<ContactUs>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        public string Content { get; set; }

        public bool Answered { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
