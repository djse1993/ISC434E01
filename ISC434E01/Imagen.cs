using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISC434E01
{
    class Imagen
    {
        #region
        int ancho;
        int alto;
        String ruta;
        List<Capa> capas;
        #endregion

        public Imagen(int alto, int ancho, String ruta)
        {
            this.alto = alto;
            this.ancho = ancho;
            this.ruta = ruta;
            this.capas.Add(new Capa());
        }

        public void AgregarCapa(Capa capa)
        {
            this.capas.Add(capa);
        }

    }
}
