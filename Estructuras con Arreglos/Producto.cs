using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_con_Arreglos
{
    class Producto
    {
        public readonly string codigo  = null; 
        public string _nombre;
        public string _descripcion;
        public int _cantidad;
        public int _costo;

        private Random _ran = new Random(DateTime.Now.Millisecond);

        public Producto(string nombre, string descripcion, int cantidad, int costo) {
            codigo = BarCode();
            _nombre = nombre;
            _descripcion = descripcion;
            _cantidad = cantidad;
            _costo = costo;
        }

        
        public override string ToString()
        {
			return "Codigo|_["+codigo+"]_|"+" Nombre:|_"+_nombre+ "_| Descripcion:|_" + _descripcion + "_| Cantidad|_" + _cantidad + "_| Costo|_$" + _costo+"_|";
        }
        

        private string BarCode()
        {
            return _ran.Next(10000000, 100000000).ToString();
        }

    }
}
