using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaleriadeArte;

namespace GaleriadeArte
{
    public partial class FormBuscarPintura : Form
    {
        private readonly ApiService api;

        public FormBuscarPintura()
        {
            InitializeComponent();

            btnBuscar.MouseEnter += btnBuscar_MouseEnter;
            btnBuscar.MouseLeave += btnBuscar_MouseLeave;

            // Usa el constructor correcto (ya tiene el puerto 8090 configurado dentro de ApiService)
            api = new ApiService();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string autor = txtAutor.Text;

                if (string.IsNullOrWhiteSpace(autor))
                {
                    MessageBox.Show("Ingresa un autor para buscar.");
                    return;
                }

                // Buscar pinturas del autor
                List<Pintura> resultados = await api.BuscarPinturasAsync(autor);

                if (resultados == null || resultados.Count == 0)
                {
                    MessageBox.Show("No se encontraron pinturas.");
                    return;
                }

                // Tomamos la primera pintura encontrada
                Pintura pintura = resultados[0];

                // Rellenamos los campos de la GUI
                txtIdPintura.Text = pintura.Id.ToString();
                txtTitulo.Text = pintura.Titulo;
                txtAutor.Text = pintura.Autor;
                txtPrecio.Text = pintura.Precio.ToString();
                comboBox1.Text = pintura.Estado;
                dateTimePicker1.Value = pintura.FechaIngreso;
                textTecnica.Text = pintura.Tecnica;
                txtTextura.Text = pintura.Textura;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar pinturas: " + ex.Message);
            }
        }


        private void btnBuscar_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"Imagenes\Buscar.png");
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"Imagenes\background.png");
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
