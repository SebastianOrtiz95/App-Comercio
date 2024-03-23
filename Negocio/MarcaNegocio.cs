using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MarcaNegocio
    {
        private AccesoDatos datos;
        private MarcaNegocio negocio;

        // metodo que devuelve una lista de categorias de la base de datos 
        public List<Marca> listar()
        {
            datos = new AccesoDatos();
            negocio = new MarcaNegocio();
            List<Marca> lista = new List<Marca>();
            try
            {
                datos.setearConsulta("select id,Descripcion from MARCAS");
                datos.ejecutarConsulta();
                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
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
