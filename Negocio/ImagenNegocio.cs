using Datos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ImagenNegocio
    {
        // Listar Imagenes por Artículo
        public List<Imagen> listarImagenesPorArticulo(int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Imagen> lista = new List<Imagen>();
            try
            {
                datos.setearConsulta("select Id, ImagenUrl from IMAGENES where IdArticulo = @id");
                datos.setearParametro("@id", idArticulo);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.IdArticulo = (int)datos.Lector["IdArticulo"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    lista.Add(aux);
                }
                return lista;
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

        // Agregar Imagen



        // Modificar Imagen


        // Eliminar Imagen

    }
}
