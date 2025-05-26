using HelpApp.Application.Products.Queries;
using HelpApp.Domain.Entities;
using HelpApp.Domain.Interfaces;
using MediatR;

namespace HelpApp.Application.Products.Handlers;


public class GetProductsQueryHandlers : IRequest<IEnumerable<Product>>
{
    private readonly IProductRepository _productRepository;

    public GetProductsQueryHandlers (IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public async Task<IEnumerable<Product>> Handle(GetProductsQuery request,
        CancellationToken cancellationToken)
    {
        return await _productRepository.GetProducts();
    }
}
