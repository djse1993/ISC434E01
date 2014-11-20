using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISC434E01
{
    class Capa
    {
        #region 
        List<Capa> subcapas = new List<Capa>();
        List<Figuras> figuras = new List<Figuras>();
        static int indice=0; //Numero de orden de la capa
        String nombre="Layer ";
        #endregion

        public Capa()
        {
            ++indice;
            this.nombre = (nombre+indice).ToString();
            
        }
        public void AgregarSubCapa(Capa capaActual)
        {
            subcapas.Add(capaActual);

        }
        public void AgregarFigura(Figuras FiguraActual)
        {
            figuras.Add(FiguraActual);
        }
    }
}
