using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REPAREMOS.Entities
{
    public class DataOutputDto
    {

        public string Ciudad { set; get; }
        public string Departamento { set; get; }
        public string Pa_s { set; get; }
        public string Categoria_residuo { set; get; }
        public string Tipo_residuo { set; get; }
        public string Ubicacion { set; get; }
        public string Horario { set; get; }
        public int Cantidad_residuo { set; get; }
        public DateTime Date_generacion { set; get; }

    }
}
