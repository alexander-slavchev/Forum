using MyAudiA4B7Forum.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyAudiA4B7Forum.Data.Models
{
    public class News : BaseDeletableModel<int>
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }


        public DateTime Date { get; set; }

    }
}
