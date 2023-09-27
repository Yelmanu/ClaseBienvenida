using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBienvenida.Servicios
{
    /// <summary>
    /// Interfaz que corresponde a la funcionalidad de menú
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Muestra el mensaje de bienvenida
        /// 200923 - mdn
        /// </summary>
        public void mensajeBienvenida();

        public int mostrarMenu();
    }
}
