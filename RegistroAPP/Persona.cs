using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAPP
{
    internal class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public string CI { get; set; }
        public string  NroCelular { get; set; }


        public Persona(int id, string nombre, string aPaterno, string aMaterno, string ci, string nroCelular)
        {
            Id = id;
            Nombre = nombre;
            APaterno = aPaterno;
            AMaterno = aMaterno;
            CI = ci;
            NroCelular = nroCelular;
        }
    }
}
