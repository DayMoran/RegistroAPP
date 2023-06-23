using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAPP
{
    internal class Docente:Persona,IUserEscuela
    {
        public string RDA { get; set; }
        public bool Disponible { get; set; }
        public decimal Sueldo { get; set; }
        public int Categoria { get; set; }

        public Docente(int id, string nombre, string aPaterno, string aMaterno, string ci, string nroCelular, string rDA, bool disponible, decimal sueldo, int categoria)
            :base(id, nombre, aPaterno, aMaterno, ci, nroCelular)
        {
            RDA = rDA;
            Disponible = disponible;
            Sueldo = sueldo;
            Categoria = categoria;
        }

        public string getPassword()
        {
            string password = $"{Nombre[0]}{APaterno[0]}{AMaterno[0]}{RDA}{Categoria}";
            return password;
        }
    }
}
