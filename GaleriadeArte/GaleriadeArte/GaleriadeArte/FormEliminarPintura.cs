using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaleriadeArte;

namespace GaleriadeArte
{
    public partial class FormEliminarPintura : Form
    {

        private readonly ApiService api;

        public FormEliminarPintura()
        {
            InitializeComponent();
            btnEliminar.MouseEnter += btnEliminar_MouseEnter;
            btnEliminar.MouseLeave += btnEliminar_MouseLeave;
            api = new ApiService();
        }

        private void FormEliminarPintura_Load(object sender, EventArgs e)
        {

        }

        private void labelTextura_Click(object sender, EventArgs e)
        {

        }

        private void textTecnica_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTecnica_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelFechaIngreso_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelEstado_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPrecio_Click(object sender, EventArgs e)
        {

        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void txtTextura_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelId_Click(object sender, EventArgs e)
        {

        }

        private void txtIdPintura_TextChanged(object sender, EventArgs e)
        {

        }

      
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdPintura.Text, out int id))
            {
                try
                {
                    await api.EliminarPinturaAsync(id);
                    MessageBox.Show("✅ Pintura eliminada correctamente.");
                    txtIdPintura.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error eliminando pintura: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("⚠️ Ingresa un ID válido.");
            }
        }

        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
            // Cambia el fondo del formulario al pasar el mouse
            this.BackgroundImage = Image.FromFile(@"Imagenes\Eliminar.png");
            this.BackgroundImageLayout = ImageLayout.Zoom; // para que se ajuste al tamaño
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            // Restaura el fondo original cuando sale el mouse
            this.BackgroundImage = Image.FromFile(@"Imagenes\background.png");
            // O si quieres otra imagen:
            // this.BackgroundImage = Image.FromFile(@"Imagenes\fondo_normal.jpg");
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
