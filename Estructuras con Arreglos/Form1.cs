using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras_con_Arreglos
{
    public partial class Form1 : Form
    {
        Tienda _tienda = new Tienda(15);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtListar.ScrollBars = ScrollBars.Both;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PassNotPass(out Producto prod);
                _tienda.Agregar(prod);
            }
            catch(Exception)
            {
                MessageBox.Show("Tienda llena");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Producto prod = _tienda.Buscar(txtCodigo.Text);
            if(prod!=null)
            {
                txtListar.Text = prod.ToString();  
            }
            else
            {
                MessageBox.Show("Error, el objeto no existe");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                _tienda.Eliminar(txtCodigo.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                PassNotPass(out Producto pro);
                _tienda.Insertar(pro, Convert.ToInt32(txtPocision.Text));
            }
            catch(Exception)
            {
                MessageBox.Show("error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtListar.Text = _tienda.Listar();
        }

        private void PassNotPass(out Producto prod)
        {
            string[] CadenasPro = { txtNombre.Text, txtDescripcion.Text };

            int[] EnterosPro = { Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtPrecio.Text) };

            prod = new Producto(CadenasPro[0], CadenasPro[1], EnterosPro[0], EnterosPro[1]);
        }

    }
}
