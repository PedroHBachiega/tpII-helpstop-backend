using HelpApp.Application.Interface;
using HelpApp.Domain.Interfaces;
using AutoMapper;
using HelpApp.Application.DTOs;
using HelpApp.Domain.Entities;

namespace HelpApp.Application.Services
{
    public class ProductServices : IProductRepository
    {
        private IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductServices(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var productsEntity = await _productRepository.GetProducts();
            return _mapper.Map<IEnumerable<Product>>(productsEntity);
        }

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
    }
}
