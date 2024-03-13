using BLL.DTOModels.Request;
using BLL.DTOModels.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IProductsBLL
    {
        public List<ProductResponseDTO> get(
            ProductSortingEntityDTO sortingEntityDTO = ProductSortingEntityDTO.NULL, 
            SortingTypeDTO sortingType = SortingTypeDTO.ASC, 
            ProductFilteringDTO productFilteringDTO = ProductFilteringDTO.NULL, 
            string filterinfContent = null, 
            bool activeOnly = true);

        public ProductResponseDTO add(ProductRequestDTO productRequestDTO);
        public ProductResponseDTO delete(int id);
        public ProductResponseDTO update(ProductRequestDTO productRequestDTO);
        public ProductResponseDTO activate(int id);

    }
}
