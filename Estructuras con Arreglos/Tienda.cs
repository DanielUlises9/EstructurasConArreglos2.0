using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace Estructuras_con_Arreglos
{
    class Tienda
    {
        private Producto[] _productos;
        private int _lentgh;
        private int crese=0;

        public Tienda(int cantidadP)
        {
            _productos = new Producto[cantidadP];
            _lentgh = cantidadP-1;
        }

        public void Agregar (Producto prod)
        {
            controlCrece();
            if (_productos[crese] == null)
            {
                _productos[crese] = prod;
                crese++;
            }
            else
                throw new System.Exception("Tienda llena!!!");
            
        }

        public Producto Buscar(string codigo)
        {
            for(int i=0;i<=_lentgh;i++)
            {
                if (_productos[i] !=null)
                 if (_productos[i].codigo == codigo)
                    return _productos[i];
            }
            return null;
        }

        public void Eliminar (string codigo)
        {
            int i=0;
            while (codigo!=_productos[i].codigo||i==14)
            {
                i++;
            }

            if (i == 14 && codigo != _productos[14].codigo)
                throw new System.Exception("No encontrado");
            
            for (int j =i;j<_lentgh;j++)
            {
                _productos[j] = _productos[j + 1];
            }
            _productos[_lentgh] = null;
            crese--;
            controlCrece();
        }

        public void Insertar(Producto pro,int pocision)
        {
            if (pocision < 0 || pocision > _lentgh)
                throw new System.Exception("Sobrepasa los valores del vector");

            _productos[pocision] = pro;
        }

        public string Listar()
        {
			
            string resultado = "";
            for(int i=0;i<=_lentgh;i++)
            {
				if (_productos[i] != null)
					resultado += "["+i+"]"+ _productos[i].ToString()+ NewLine;
            }

            return resultado;
        }
        private void controlCrece()
        {
            if (crese < 0)
                crese = 0;
            else if (crese > 14)
                crese = 14;
        }
    }
}
