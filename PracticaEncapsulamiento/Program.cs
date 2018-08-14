using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEncapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear una instancia de contacto
            Contacto contactoUno = new Contacto();

            contactoUno.Nombre = "José García";
            contactoUno.Direccion = "Veracruz S/N";
            contactoUno.CorreoElectronico = "josegarcia@outlok.com";
            contactoUno.TelefonoCasa = "1758642";
            contactoUno.TelefonoCelular = "589641";

            Console.WriteLine("Nombre: " + contactoUno.Nombre);
            Console.WriteLine("Direccion: " + contactoUno.Direccion);
            Console.WriteLine("Correo: " + contactoUno.CorreoElectronico);
            Console.WriteLine("Telefono de casa: " + contactoUno.TelefonoCasa);
            Console.WriteLine("Telefono celular: " + contactoUno.TelefonoCelular);

            Console.ReadLine();

        }
    }
}
