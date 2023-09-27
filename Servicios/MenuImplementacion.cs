using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBienvenida.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mensajeBienvenida()
        {
            string mensaje = "Bienvenido al cajero de CSI1";

            Console.WriteLine(mensaje);
        }
        public int mostrarMenu()
        {
            int opcionIntroducida;
            Console.Write("Elige una opción: ");
            Console.WriteLine("\n0.- Salir.");
            Console.WriteLine("1.- Darse de alta.");
            Console.WriteLine("2.- Ingresar dinero.");
            Console.WriteLine("3.- Retirar dinero.");
            Console.WriteLine("4.- Transferir dinero a otro usuario del banco.");
            Console.WriteLine("5.- Historial de aplicaciones.");

            opcionIntroducida = Console.ReadKey(true).KeyChar-('0');
            return opcionIntroducida;
        }
    }
}
