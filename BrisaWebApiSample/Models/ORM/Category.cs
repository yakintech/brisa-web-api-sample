using System;
namespace BrisaWebApiSample.Models.ORM
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}

