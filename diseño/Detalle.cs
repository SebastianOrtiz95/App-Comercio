using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diseño
{
    public partial class Detalle : Form
    {
        private Articulos articulo;
        public Detalle()
        {
            InitializeComponent();
        }

        public Detalle(Articulos articulo)
        {
            InitializeComponent();
            Text = "DETALLE PRODUCTO";
            this.articulo = articulo;
            
        }
        private void Detalle_Load(object sender, EventArgs e)
        {
            cargarVentanaDetalle(articulo);
            //cargarImagen(articulo.imagenUrl);
            cargarImagenAsync(articulo.imagenUrl);
        }
        private void cargarVentanaDetalle(Articulos articulo)
        {
            //articulo=new Articulos();
            txtDescripcionDetalle.Text = articulo.descripcion;
            //articulo.marca= new Marca();
            txtMarcaDetalle.Text = articulo.marca.descripcion;
            txtNombreDetalle.Text = articulo.nombre;
            //articulo.categoria = new Categoria();
            txtCategoriaDetalle.Text = articulo.categoria.descripcion;
            txtPrecioDetalle.Text = articulo.precio.ToString("0.00");
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxDetalleArticulo.Load(imagen);
            }
            catch (Exception)
            {

                pbxDetalleArticulo.Load("https://editorial.unc.edu.ar/wp-content/uploads/sites/33/2022/09/placeholder.png");
            }
        }
        private async void cargarImagenAsync(string imagenUrl)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    byte[] imageData = await webClient.DownloadDataTaskAsync(imagenUrl);
                    using (var ms = new System.IO.MemoryStream(imageData))
                    {
                        pbxDetalleArticulo.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
            catch (Exception)
            {
                // Manejar errores de carga de imagen
                pbxDetalleArticulo.Load("https://editorial.unc.edu.ar/wp-content/uploads/sites/33/2022/09/placeholder.png"); // Cargar una imagen predeterminada
            }
        }
    }
}
