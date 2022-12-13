using System;
using System.ComponentModel.DataAnnotations;

namespace BrisaWebApiSample.Models.ORM
{
    public class WebUser : BaseEntity
    {
        [MaxLength(20)]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}

