using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BrisaWebApiSample.Models
{
    public class Supplier
    {
        //[Required(ErrorMessage = "Company Name nerede??")]
        //[MaxLength(30, ErrorMessage = "30 karakterden uzun olamaz!")]
        public string CompanyName { get; set; }

        [JsonPropertyName("iletisim")]
        public string ContactName { get; set; }


        public string ContactTitle { get; set; }
    }
}

