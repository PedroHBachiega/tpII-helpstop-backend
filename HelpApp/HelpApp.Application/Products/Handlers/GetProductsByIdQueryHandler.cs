using HelpApp.Application.Products.Queries;
using HelpApp.Domain.Entities;
using HelpApp.Domain.Interfaces;
using MediatR;

namespace HelpApp.Application.Products.Handlers;

public class GetProductsByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
{
    private readonly IProductRepository _productRepository;
    public GetProductsByIdQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public async Task<Product>Handle(GetProductByIdQuery request,CancellationToken cancellationToken)
    {
        return await _productRepository.GetById(request.Id);
    }
}
