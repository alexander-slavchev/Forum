﻿using Ganss.XSS;
using MyAudiA4B7Forum.Services.Mapping;
using MyAudiA4Forum.Data.Models;
using System;

namespace MyAudiA4B7Forum.Web.ViewModels.Posts
{
    public class PostCommentViewModel : IMapFrom<Comment>
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Content { get; set; }

        public string SanitizedContent => new HtmlSanitizer().Sanitize(this.Content);

        public string UserUsername { get; set; }
    }
}
