using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REPAREMOS.Entities
{
    public class DataErrorDto
    {
        public string Error { get; set; }
        public string Valor { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
