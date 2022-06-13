using API_REPAREMOS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REPAREMOS.Common.Interface
{
    public interface ManejoResiduosServicesInt
    {
        Task<List<DataInputDto>> ObtenerResiduos();
        Task<List<DataInputDto>> ObtenerResiduosXCiudad(string ciudad);

    }
}
