using HelpApp.Application.DTOs;

namespace HelpApp.Application.Interface
{
    public interface IProductServices
    {
        Task<IEnumerable<ProductDTO>> GetProducts();
        Task<ProductDTO> GetBtId(int? id);

        Task Add(ProductDTO productDTO);
        Task Update(ProductDTO productDTO);
        Task Remove(int? id);

    }
}
