using HelpApp.Domain.Entities;
using MediatR;

namespace HelpApp.Application.Products.Commands
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
