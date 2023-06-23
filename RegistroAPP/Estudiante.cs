using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAPP
{
    internal class Estudiante: Persona,IUserEscuela
    {
        

        public string Matricula { get; set; }
        public bool Activo { get; set; }

        public Estudiante(int id, string nombre, string aPaterno, string aMaterno, string ci, string nroCelular , string matricula, bool activo)
            :base(id,nombre,aPaterno,aMaterno,ci,nroCelular)
        {
            Matricula = matricula;
            Activo = activo;
        }

        public string getPassword()
        {
            // Lógica para obtener la contraseña del estudiante
            //NOmbre, apellido paterno, materno, matricula

            string password = $"{Nombre[0]}{APaterno[0]}{AMaterno[0]}{Matricula}";
            return password;
        }


    }
}
