using System;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Security.Claims;

namespace BrisaWebApiSample.Models
{
    public class TokenHandler
    {


        public Token CreateAccessToken()
        {
        
            Token token = new Token();

            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ironmaidenpentagramslipknotironmaidenpentagramslipknot"));

            //Token şifreleme algoritması
            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);


            token.ExpireDate = DateTime.Now.AddMinutes(1);

            //Oluşturduğum token özellikleri
            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(
                issuer: "cagatay@mail.com",
                audience: "cagatay1@mail.com",
                expires: token.ExpireDate,
                signingCredentials: signingCredentials
       
                );


            //Token create ediyorum
            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            token.AccessToken = jwtSecurityTokenHandler.WriteToken(jwtSecurityToken);



            return token;
        }



    }
}

