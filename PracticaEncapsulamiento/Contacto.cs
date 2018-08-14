using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEncapsulamiento
{
    class Contacto
    {
        //auto-properties
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string TelefonoCasa { get; set; }
        public string CorreoElectronico { get; set; }

        //properties
        private string _telefonoCelular;
        public string TelefonoCelular
        {
            get
            {
                return _telefonoCelular;
            }
            set
            {
                if (value.Length == 10)
                {
                    _telefonoCelular = value;
                }
                else if (value.Length == 7)
                {
                    _telefonoCelular = "644" + value;
                }
                else
                {
                    Console.WriteLine("Introduce un numero de calular válido");
                }
            }
        }
    }
}
