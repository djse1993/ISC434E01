using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ISC434E01
{
    class Figuras
    {
        #region
            String nombre;
            int posX;
            int posY;
            int alto, ancho;
        #endregion
        public Figuras(String nombre, int posX, int posY, int alto, int ancho)
        {
            this.nombre = nombre;
            this.posX = posX;
            this.posY = posY;
            this.alto = alto;
            this.ancho = ancho;
        }
        public void dibujarimagen()
        {
            //Dibujara la figura dentro de la imagen 
        }
    }
}
