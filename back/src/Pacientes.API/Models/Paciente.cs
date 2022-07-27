using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pacientes.API.Models
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public string? Nome { get; set; }
        public int Telefone { get; set; }
        public int DataNasc { get; set; }
    }
}