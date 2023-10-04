using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class CitaDto
    {
        public int Id { get; set; }
        public int ServicioId { get; set; }
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }


    }
}