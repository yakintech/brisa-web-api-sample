using System;
namespace BrisaWebApiSample.Models.Dto.WebUser
{
    public class CreateWebUserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int CategoryId { get; set; }
    }
}

