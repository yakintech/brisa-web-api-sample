using System;
namespace BrisaWebApiSample.Models
{
    public class ProductManager : IProductManager
    {
        public void Add()
        {
          
        }
    }


    public interface IProductManager
    {
        void Add();
    }
}

