using BLL.DTOModels.Request;
using BLL.DTOModels.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IBasketPositionBLL
    {
        public BasketPositionResponseDTO update(BasketPositionRequestDTO basketPositionRequestDTO);
        public BasketPositionResponseDTO add(BasketPositionRequestDTO basketPositionRequestDTO);
        public BasketPositionResponseDTO delete(BasketPositionRequestDTO basketPositionRequestDTO);

    }
}
