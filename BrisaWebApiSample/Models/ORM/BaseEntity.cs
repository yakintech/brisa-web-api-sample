using System;
namespace BrisaWebApiSample.Models.ORM
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime AddDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public bool IsDeleted { get; set; }
    }
}

