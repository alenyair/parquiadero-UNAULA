using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parquiadero_UNAULA
{
    class celda
    {
        int numerocelda;
        string placa;
        string estado;

        public int lacelda
        {
            set { numerocelda = value; }
            get { return numerocelda; }//recuperar el valor de ese atributo
        }
        public string laplaca
        {
            set { placa = value; }
            get { return placa; }
        }
        public string elestado
        {
            set {  estado =value; }
            get { return estado; }

        }
        public void liberarcelda()
        {
            estado = "vacia";
            placa = "";
        }
        public void ocuparcelda(string placaleida)
        {
            estado = "ocupada";
            placa = placaleida;
        }
        public celda()

        {
            estado = "vacia";
        }









    }
}
