using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrisaWebApiSample.Models.ORM
{
    public class WebUser : BaseEntity, ISort
    {
        [MaxLength(20)]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

       
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public int Sort { get; set; }
    }
}

