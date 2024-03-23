using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diseño
{
    public partial class ArticulosGestion : Form
    {
        private CategoriaNegocio NegocioCategoria;
        private MarcaNegocio MarcaNegocio;
        private articuloNegocio articuloNegocio;
        private Articulos articulo = null;
        private List<TextBox> listaTextBox;
        private bool botonAceptarPresionado=false;
        public ArticulosGestion()
        {
            InitializeComponent();
        }
        public ArticulosGestion(Articulos modificado)
        {
            InitializeComponent();
            Text = "MODIFICAR ARTICULO";
            articulo = modificado;
        }
        public bool BotonAceptarPresionado
        {
            get { return botonAceptarPresionado; }
        }

        private void ArticulosGestion_Load(object sender, EventArgs e)
        {
            NegocioCategoria = new CategoriaNegocio();
            MarcaNegocio = new MarcaNegocio();
            try
            {
                if ( articulo != null)
                {
                    cbxCategoria.DataSource = NegocioCategoria.listar();
                    definirValueDisplayComboBox(cbxCategoria);
                    cbxMarca.DataSource = MarcaNegocio.listar();
                    definirValueDisplayComboBox(cbxMarca);
                    cargarFomularioModificar(articulo);
                }
                else
                {
                    cbxCategoria.DataSource= MarcaNegocio.listar();
                    cbxMarca.DataSource= MarcaNegocio.listar();
                }
                
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUrlImagen_Validating(object sender, CancelEventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }
        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulos nuevo = new Articulos();
            articuloNegocio = new articuloNegocio();
            try
            {
                if (validarTextBoxVacio())
                {
                    MessageBox.Show("Todos los campos son obligatorios. Por favor, llene todos los campos.", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                    
                if (articulo.id != 0)
                {
                    articuloNegocio.Modificar(cargarObjeto(articulo));
                    MessageBox.Show("modificado exitosamente");
                    botonAceptarPresionado = true;
                }
                else
                {
                    articuloNegocio.Agregar(cargarObjeto(nuevo));
                    MessageBox.Show("agregado exitosamente");
                    botonAceptarPresionado=true;
                }
               
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(),"Hubo un error");
            }
        }

                
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticuloAlta.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticuloAlta.Load("https://editorial.unc.edu.ar/wp-content/uploads/sites/33/2022/09/placeholder.png");
            }
        }
        private Articulos cargarObjeto(Articulos articulo)
        {
            articulo.descripcion=txtDescripcion.Text;
            articulo.precio=decimal.Parse(txtPrecio.Text);
            articulo.nombre=txtNombre.Text;
            articulo.imagenUrl = txtUrlImagen.Text;
            articulo.codigo=txtCodigo.Text;
            articulo.categoria=(Categoria)cbxCategoria.SelectedItem;
            articulo.marca=(Marca)cbxMarca.SelectedItem;
            return articulo;
        }
        private void cargarFomularioModificar(Articulos articulo)
        {
            txtNombre.Text=articulo.nombre;
            txtCodigo.Text=articulo.codigo;
            txtDescripcion.Text=articulo.descripcion;
            txtUrlImagen.Text=articulo.imagenUrl;
            txtPrecio.Text=articulo.precio.ToString("0.00");
            cbxCategoria.SelectedValue = articulo.categoria.id;
            cbxMarca.SelectedValue = articulo.marca.id;
            cargarImagen(articulo.imagenUrl);

        }
        private void definirValueDisplayComboBox(ComboBox cbx)
        {
            cbx.ValueMember = "id";
            cbx.DisplayMember = "descripcion";
        }
        private bool validarTextBoxVacio()
        {
            listaTextBox = new List<TextBox>();
            listaTextBox.Add(txtCodigo);
            listaTextBox.Add(txtDescripcion);
            listaTextBox.Add(txtNombre);
            listaTextBox.Add(txtPrecio);
            listaTextBox.Add(txtUrlImagen);
            foreach (TextBox tb in listaTextBox)
            {
                if (tb == null || tb.Text=="") 
                {
                    return true;
                }

            }
            return false;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control (por ejemplo, retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la pulsación si no es un número ni una tecla de control
                MessageBox.Show("Por favor, ingrese solo números.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

