using System;
using System.Collections.Generic;
using System.Text;

namespace MyAudiA4B7Forum.Web.ViewModels.Administration.Emails
{
    public class EmailsIndexPageViewModel
    {
        public IEnumerable<NotAnsweredEmailsOutputViewModel> NotAnsweredEmails { get; set; }

        public int CountAnsweredEmails { get; set; }

        public int CountNotAnsweredEmails { get; set; }

        public IDictionary<DateTime, int> NotAnsweredLast10Days { get; set; }
    }
}
