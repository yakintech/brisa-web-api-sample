using System;
namespace BrisaWebApiSample.Models
{
    public class Token
    {
        public string AccessToken { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}

