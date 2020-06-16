using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;


namespace BLL
{
    public class RecaudoServiceFile
    {
        private RecaudoRepositoryFile repositoryFile;

        public RecaudoServiceFile()
        {
            repositoryFile = new RecaudoRepositoryFile();
        }

        public RespuestaGetRecaudos GetRecaudos(string ruta)
        {
            RespuestaGetRecaudos respuesta = new RespuestaGetRecaudos();
            try
            {
                respuesta.Error = false;
                respuesta.GetRecaudos = repositoryFile.GetRecaudos(ruta);
                respuesta.Message = respuesta.GetRecaudos.Count != 0 ? "Se consultaron los datos correctamente" : "No se encuentraron datos";

                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Message = $"Error de aplicacion {e.Message}";
                respuesta.GetRecaudos = null;

                return respuesta;

            }
        }


            
    }

    public class RespuestaGetRecaudos
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public IList<Recaudo> GetRecaudos { get; set; }
    }
}
