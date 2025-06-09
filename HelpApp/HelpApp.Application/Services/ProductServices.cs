using HelpApp.Application.Interface;
using HelpApp.Domain.Interfaces;
using AutoMapper;
using HelpApp.Application.DTOs;
using HelpApp.Domain.Entities;

namespace HelpApp.Application.Services
{
    public class ProductServices : IProductServices
    {



        public Task<Product> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Create(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Update(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Remove(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDTO>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> GetBtId(int? id)
        {
            throw new NotImplementedException();
        }

        public Task Add(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }

        public Task Update(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }

        public Task Remove(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
