using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class articuloNegocio
    {
		private List<Articulos> lista;
		private AccesoDatos datos;
        public List<Articulos> listar()
        {
			lista = new List<Articulos>();
			datos = new AccesoDatos();
			try
			{
				datos.setearConsulta("select A.id , codigo , nombre , A.descripcion , imagenUrl , precio,IdCategoria,IdMarca,C.Descripcion categoria,M.Descripcion marca from ARTICULOS A , MARCAS M, CATEGORIAS C where IdMarca=M.id and IdCategoria = C.Id");
				datos.ejecutarConsulta();
				while (datos.Lector.Read())
				{
					Articulos aux = new Articulos();
					aux.id = (int)datos.Lector["id"];
					aux.nombre = (string)datos.Lector["nombre"];
					aux.descripcion = (string)datos.Lector["descripcion"];
					aux.codigo = (string)datos.Lector["codigo"];

					if (!(datos.Lector["imagenUrl"] is DBNull)) 
					 aux.imagenUrl = (string)datos.Lector["imagenUrl"];

					aux.precio = (decimal)datos.Lector["precio"];
					aux.marca = new Marca();
					aux.marca.id = (int)datos.Lector["idMarca"];
					aux.marca.descripcion = (string)datos.Lector["marca"];
					aux.categoria = new Categoria();
					aux.categoria.id = (int)datos.Lector["idCategoria"];
					aux.categoria.descripcion = (string)datos.Lector["categoria"];
					lista.Add(aux);
				}
			}
			catch (Exception ex)
			{

				throw ex;
			}
			return lista;
        }
		public void Agregar(Articulos nuevo)
		{
			datos = new AccesoDatos();
			try
			{
				datos.setearConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion,idMarca,idCategoria,ImagenUrl,Precio)values(@codigo,@nombre,@descripcion,@idMarca,@idCategoria,@urlImagen,@precio)");
                datos.setearParametro("@codigo", nuevo.codigo);
                datos.setearParametro("@nombre", nuevo.nombre);
                datos.setearParametro("@descripcion", nuevo.descripcion);
                datos.setearParametro("@idMarca", nuevo.marca.id);
                datos.setearParametro("@idCategoria", nuevo.categoria.id);
                datos.setearParametro("@urlImagen", nuevo.imagenUrl);
                datos.setearParametro("@precio", nuevo.precio);
                datos.ejecutarAccion();
				
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				datos.cerrarConexion();
			}
		}
		public void Modificar(Articulos modificado)
		{
			datos = new AccesoDatos();
			try
			{
				datos.setearConsulta("update ARTICULOS set Codigo = @codigo ,Precio=@precio ,Nombre = @nombre,Descripcion= @descripcion,ImagenUrl=@imagenUrl,IdCategoria=@IdCategoria,IdMarca=@IdMarca where id = @id");
				datos.setearParametro("@codigo",modificado.codigo);
				datos.setearParametro("@precio",modificado.precio);
				datos.setearParametro("@nombre",modificado.nombre);
				datos.setearParametro("@descripcion",modificado.descripcion);
				datos.setearParametro("@imagenUrl",modificado.imagenUrl);
				datos.setearParametro("idCategoria",modificado.categoria.id);
                datos.setearParametro("idMarca", modificado.marca.id);
                datos.setearParametro("@id", modificado.id);
				datos.ejecutarAccion();
            }
            catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				datos.cerrarConexion();
			}
		}
		public void Eliminar(Articulos eliminado)
		{
			datos = new AccesoDatos();
			try
			{
				datos.setearConsulta("delete ARTICULOS where id = @id");
				datos.setearParametro("@id",eliminado.id);
				datos.ejecutarAccion();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Articulos> listar(string campo,string criterio,string filtro)
		{
            lista = new List<Articulos>();
            datos =new AccesoDatos();
			try
			{
				string consulta="select A.id , codigo , nombre , A.descripcion , imagenUrl , precio,IdCategoria,IdMarca,C.Descripcion categoria,M.Descripcion marca from ARTICULOS A , MARCAS M, CATEGORIAS C where IdMarca=M.id and IdCategoria = C.Id and ";
                if (campo == "PRECIO")
                {
                    if (criterio == "MAYOR A")
                    {
                        consulta += " Precio > " + filtro;
                    }
                    if (criterio == "IGUAL A")
                    {
                        consulta += " Precio = " + filtro;
                    }
                    if (criterio == "MENOR A")
                    {
                        consulta += " Precio < " + filtro;
                    }
                }
                if (campo == "NOMBRE")
                {
                    if (criterio == "EMPIEZA CON")
                    {
                        consulta += " Nombre like '" + filtro + "%'";
                    }
                    if (criterio == "CONTIENE")
                    {
                        consulta += " Nombre like '%" + filtro + "%'";
                    }
                    if (criterio == "TERMINA CON")
                    {
                        consulta += " Nombre like '%" + filtro + "'";
                    }
                }
                if (campo == "MARCA")
                {
                    if (criterio == "EMPIEZA CON")
                    {
                        consulta += " M.Descripcion like '" + filtro + "%'";
                    }
                    if (criterio == "CONTIENE")
                    {
                        consulta += " M.Descripcion like '" + filtro + "%'";

                    }
                    if (criterio == "TERMINA CON")
                    {
                        consulta += " M.Descripcion like '%" + filtro + "'";
                    }
                }
                if (campo == "CATEGORIA")
                {
                    if (criterio == "EMPIEZA CON")
                    {
                        consulta += " C.Descripcion like '" + filtro + "%'";
                    }
                    if (criterio == "CONTIENE")
                    {
                        consulta += " C.Descripcion like '" + filtro + "%'";

                    }
                    if (criterio == "TERMINA CON")
                    {
                        consulta += " C.Descripcion like '%" + filtro + "'";
                    }
                }
                datos.setearConsulta(consulta);
                datos.ejecutarConsulta();
                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.codigo = (string)datos.Lector["Codigo"];
                    aux.nombre = (string)datos.Lector["Nombre"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["imagenUrl"] is DBNull))
                    {
                        aux.imagenUrl = (string)datos.Lector["ImagenUrl"];
                    }

                    aux.precio = (decimal)datos.Lector["Precio"];
                    aux.id = (int)datos.Lector["Id"];
                    aux.marca = new Marca();
                    aux.marca.descripcion = (string)datos.Lector["Marca"];
                    aux.marca.id = (int)datos.Lector["idMarca"];
                    aux.categoria = new Categoria();
                    aux.categoria.id = (int)datos.Lector["idCategoria"];
                    aux.categoria.descripcion = (string)datos.Lector["Categoria"];
                    lista.Add(aux);
                }

                return lista;
            }
			catch (Exception ex)
			{

				throw ex;
			}
		}
        public List<Articulos> ProbarListaVacia()
        {
            lista = new List<Articulos>();
            datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT * FROM ARTICULOS WHERE 1=0;");
                datos.ejecutarConsulta();
                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.id = (int)datos.Lector["id"];
                    aux.nombre = (string)datos.Lector["nombre"];
                    aux.descripcion = (string)datos.Lector["descripcion"];
                    aux.codigo = (string)datos.Lector["codigo"];

                    if (!(datos.Lector["imagenUrl"] is DBNull))
                        aux.imagenUrl = (string)datos.Lector["imagenUrl"];

                    aux.precio = (decimal)datos.Lector["precio"];
                    aux.marca = new Marca();
                    aux.marca.id = (int)datos.Lector["idMarca"];
                    aux.marca.descripcion = (string)datos.Lector["marca"];
                    aux.categoria = new Categoria();
                    aux.categoria.id = (int)datos.Lector["idCategoria"];
                    aux.categoria.descripcion = (string)datos.Lector["categoria"];
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


