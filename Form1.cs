using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
            ventas = new List<Venta>();

            // Crear objetos de la clase Cliente, Ruta y Venta
            Cliente cliente1 = new Cliente { TipoCliente = "Promoción de colegios", Edad = 18 };
            Ruta ruta1 = new Ruta { NombreRuta = "Sacsayhuaman, Puka Pukara, Tambomachay", Precio = 100 };
            Venta venta1 = new Venta { Cliente = cliente1, Ruta = ruta1, Cantidad = 5, Descuento = 0.08m, ImportePago = 450 };

            Cliente cliente2 = new Cliente { TipoCliente = "Adultos mayores de 60 años", Edad = 65 };
            Ruta ruta2 = new Ruta { NombreRuta = "Tipon, Lucre, Piquillaqta", Precio = 120 };
            Venta venta2 = new Venta { Cliente = cliente2, Ruta = ruta2, Cantidad = 3, Descuento = 0.13m, ImportePago = 312.60m };

            // Agregar las ventas a la lista
            ventas.Add(venta1);
            ventas.Add(venta2);

            // Asignar la lista como origen de datos del DataGridView
            dataGridView1.DataSource = ventas;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = double.Parse(txtTotal.Text);
            double personas =double.Parse(txtPersonas.Text);
            double precio = 0;
            string ruta1 = cbRuta.SelectedItem.ToString();

            switch (ruta1)
            {
                case "Sacsayhuaman, Puka Pukara, Tambomachay":
                    precio = 100;
                    break;
                case "Tipon, Lucre, Piquillaqta":
                    precio = 120;
                    break;
                case "Ollantaytambo, Machupicchu":
                    precio = 150;
                    break;
                default:
                    // Manejar el caso en el que no se selecciona una ruta válida
                    break;
            }
            MessageBox.Show($"El precio de la ruta seleccionada es: {precio.ToString("C")}");
            txtTotal.Text = precio.ToString();

            double descuento = 0;
            double mt = 0;

            string tipoDescuento = cbDescuento.SelectedItem.ToString();

            // Verifica el tipo de descuento seleccionado y asigna el valor correspondiente
            switch (tipoDescuento)
            {
                case "0%":
                    descuento = 0;
                    break;
                case "8%":
                    descuento = 0.08;
                    break;
                case "13%":
                    descuento = 0.13;
                    break;
                case "15%":
                    descuento = 0.15;
                    break;
                default:
                    // Manejar el caso en el que no se selecciona un tipo de descuento válido
                    break;
            }

            mt = total - (total * descuento);
            total = total * personas;

            txtMT.Text = mt.ToString();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
