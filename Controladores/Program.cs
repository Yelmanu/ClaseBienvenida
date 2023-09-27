using ClaseBienvenida.Servicios;

namespace ClaseBienvenida 
{
    /// <summary>
    /// Clase que controla el flujo de procedimientos de la aplicación
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada a la aplicación
        /// contiene el procedimiento o flujo de nuestra aplicación
        /// 200920 - mdn
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) 
        { 
            //Llamada al método que imprime el mensaje por consola
            MenuInterfaz menuInterfaz = new MenuImplementacion();

            menuInterfaz.mensajeBienvenida();
            //Creamos una variable bool y una variable int para el menu (bool para el control
            //de flujo while e int para capturar la opcion introducida por el usuario)
            bool cerrarMenu=false;
            int opcionSeleccionada;

            while(!cerrarMenu)
            {
                opcionSeleccionada = menuInterfaz.mostrarMenu();
                Console.WriteLine("[INFO] Has seleccionado la opcion {0}", opcionSeleccionada);

                switch(opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] Se cerrará la sesión");
                        cerrarMenu = true;                       
                        break;
                    case 1:
                        Console.WriteLine("[INFO] Se ejecutará caso 1");
                        break;
                    case 2:
                        Console.WriteLine("[INFO] Se ejecutará caso 2");
                        break;
                    case 3:
                        Console.WriteLine("[INFO] Se ejecutará caso 3");
                        break;
                    case 4:
                        Console.WriteLine("[INFO] Se ejecutará caso 4");
                        break;
                    case 5:
                        Console.WriteLine("[INFO] Se ejecutará caso 5");
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna.");
                        break;
                }
            }
        }
    }
}


