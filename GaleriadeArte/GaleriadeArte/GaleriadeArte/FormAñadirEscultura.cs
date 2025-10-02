using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleriadeArte
{
    public partial class FormAñadirEscultura : Form
    {
        public FormAñadirEscultura()
        {
            InitializeComponent();
            comboBox1.Items.Add("Activo");
            comboBox1.Items.Add("Inactivo");
            btnAñadir.MouseEnter += btnAñadir_MouseEnter;
            btnAñadir.MouseLeave += btnAñadir_MouseLeave;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadir_MouseEnter(object sender, EventArgs e)
        {
            // Cambia el fondo del formulario al pasar el mouse
            this.BackgroundImage = Image.FromFile(@"Imagenes\Agregar.png");
            this.BackgroundImageLayout = ImageLayout.Zoom; // para que se ajuste al tamaño
        }

        private void btnAñadir_MouseLeave(object sender, EventArgs e)
        {
            // Restaura el fondo original cuando sale el mouse
            this.BackgroundImage = Image.FromFile(@"Imagenes\background.png");
            // O si quieres otra imagen:
            // this.BackgroundImage = Image.FromFile(@"Imagenes\fondo_normal.jpg");
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void txtIdEscultura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textTecnica_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTextura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
