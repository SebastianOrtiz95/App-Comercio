using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio
    {
		private AccesoDatos datos;
		private MarcaNegocio negocio;

		// metodo que devuelve una lista de categorias de la base de datos 
        public List<Categoria> listar()
        {
			datos = new AccesoDatos();
			negocio = new MarcaNegocio();
			List<Categoria> lista = new List<Categoria>();
			try
			{
				datos.setearConsulta("select id,Descripcion from CATEGORIAS");
				datos.ejecutarConsulta();
				while (datos.Lector.Read())
				{
				    Categoria aux = new Categoria();
					aux.id = (int)datos.Lector["id"];
					aux.descripcion = (string)datos.Lector["descripcion"];
					lista.Add(aux);
				}
			}
			catch (Exception ex)
			{

				throw ex;
			}
			return lista;
        }
    }
}
