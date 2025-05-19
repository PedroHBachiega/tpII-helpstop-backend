using HelpApp.Domain.Entities;
using MediatR;

namespace HelpApp.Application.Mapping.Products.Commands
{
    public class ProductRemoveCommand : IRequest<Product>
    {
        public int id { get; set; }
        public ProductRemoveCommand(int id)
        {
            id = id;
        }
    }
}
