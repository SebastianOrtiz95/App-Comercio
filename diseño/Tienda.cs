using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diseño
{
    public partial class Tienda : Form
    {
        private List<Articulos> lista;
        public Tienda()
        {
            InitializeComponent();
        }

        private void Tienda_Load(object sender, EventArgs e)
        {
            
            cargarGrilla();
            ocultarColumnas();
            mostrarColumnaPrecioDosDigitos();
            cbxCampo.Items.Add("CATEGORIA");
            //cbxCampo.Items.Add("DESCRIPCION");
            cbxCampo.Items.Add("NOMBRE");
            cbxCampo.Items.Add("MARCA");
            cbxCampo.Items.Add("PRECIO");
        }


        private void cargarGrilla()
        {
            lista = new List<Articulos>();
            articuloNegocio negocio = new articuloNegocio();
            try
            {
                lista = negocio.listar();
                dgvProductos.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error", ex.ToString());
            }

        }
        private void ocultarColumnas()
        {
            dgvProductos.Columns["id"].Visible = false;
            dgvProductos.Columns["imagenUrl"].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Articulos> listaFiltrada = new List<Articulos>();
            try
            {
                filtrarMostrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error", ex.ToString());
            }
        }

        private void txtFiltroRapido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    //  método filtrarMostrar para filtrar y mostrar los resultados
                    filtrarMostrar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error", ex.ToString());
                }
                // Evitar que se agregue un salto de línea al presionar Enter
                e.Handled = true;
            }
        }
        private void filtrarMostrar()
        {
            // Se obtiene el texto del filtro ingresado por el usuario desde el TextBox
            string filtro = txtFiltroRapido.Text;
            if (filtro != "")
            {
                // Si se ha ingresado un filtro, se filtra la lista de artículos y se establece como origen de datos del DataGridView
                cargarGrilla(filtrarLista(filtro));
            }
            else
            {
                // Si no se ha ingresado un filtro, se establece la lista original como origen de datos del DataGridView
                cargarGrilla(lista);
            }
        }
        private List<Articulos> filtrarLista(string filtro)
        {
            // Se filtra la lista de artículos basada en el filtro ingresado
            List<Articulos> listaFiltrada = new List<Articulos>();
            listaFiltrada = lista.FindAll(x => x.nombre.ToLower().Contains(filtro.ToLower()) || x.categoria.descripcion.ToLower().Contains(filtro.ToLower()));
            return listaFiltrada;
        }
        private void cargarGrilla(List<Articulos> lista)
        {
            dgvProductos.DataSource = lista;
        }

        //private void cargarImagen(string imagen)
        //{
        //    try
        //    {
        //        pbxArticulo.Load(imagen);
        //    }
        //    catch (Exception)
        //    {

        //        pbxArticulo.Load("https://editorial.unc.edu.ar/wp-content/uploads/sites/33/2022/09/placeholder.png");
        //    }
        //}

        //private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        //{
        //    Articulos seleccionado = (Articulos)dgvProductos.CurrentRow.DataBoundItem;
        //    cargarImagen(seleccionado.imagenUrl);
        //}

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticulosGestion alta = new ArticulosGestion();
            DialogResult resultado = alta.ShowDialog();
            if (resultado==DialogResult.OK)
            {
                cargarGrilla();
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validarSeleccionado()) return;
            Articulos seleccionado = (Articulos)dgvProductos.CurrentRow.DataBoundItem;
            ArticulosGestion modificar = new ArticulosGestion(seleccionado);
            modificar.ShowDialog();
            if (modificar.BotonAceptarPresionado==true)
            {
                cargarGrilla();
            }
            
        }
        private void mostrarColumnaPrecioDosDigitos()
        {
            dgvProductos.Columns["precio"].DefaultCellStyle.Format = "0.00";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (validarSeleccionado()) return;
            articuloNegocio negocio = new articuloNegocio();
            // selecciono el elemento de la grilla a eliminar
            Articulos eliminar = (Articulos)dgvProductos.CurrentRow.DataBoundItem;
            try
            {
                DialogResult resultado = ConfirmarEliminacion(eliminar);
                if (resultado == DialogResult.Yes)
                {
                    negocio.Eliminar(eliminar);
                    MessageBox.Show("Producto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private DialogResult ConfirmarEliminacion(Articulos articulo)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result;
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCampo.SelectedItem.ToString() == "PRECIO")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("MAYOR A");
                cbxCriterio.Items.Add("IGUAL A");
                cbxCriterio.Items.Add("MENOR A");
            }
            else
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("CONTIENE");
                cbxCriterio.Items.Add("EMPIEZA CON");
                cbxCriterio.Items.Add("TERMINA CON");
            }
        }

        private void btnFiltroAvanzado_Click(object sender, EventArgs e)
        {
            articuloNegocio negocio = new articuloNegocio();
            List<Articulos> listaFiltroAvanzado = new List<Articulos>();
            try
            {
                if (cbxCampo.Text=="PRECIO")
                {
                    if (!ValidarSoloNumeros(txtFiltroAvanzado.Text))
                    {
                        MessageBox.Show("Por favor, ingrese solo números en este campo.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                   
                }
                listaFiltroAvanzado = negocio.listar(cbxCampo.Text, cbxCriterio.Text, txtFiltroAvanzado.Text);
                cargarGrilla(listaFiltroAvanzado);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Hubo un error");
            }
        }
               
                
                    
               

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (validarSeleccionado()) return;
            Articulos seleccionado = (Articulos)dgvProductos.CurrentRow.DataBoundItem;
            Detalle detalle = new Detalle(seleccionado);
            detalle.ShowDialog();
        }
        private bool ValidarSoloNumeros(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsDigit(c))
                {
                    return false; // Si encuentra un carácter que no es un dígito, devuelve falso
                }
            }
            return true; // Si todos los caracteres son dígitos, devuelve verdadero
        }
        private bool validarSeleccionado()
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("no hay nada seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
    
}






                    

                    
