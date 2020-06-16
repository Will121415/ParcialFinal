using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using System.Data.SqlClient;

namespace BLL
{
    public class RecaudoServiceDB
    {
        private readonly ConnectionManager connectionManager;
        private readonly RecaudoRepositoryDB repositoryDB;

        public RecaudoServiceDB(string connectionString)
        {
            connectionManager = new ConnectionManager(connectionString);
            repositoryDB = new RecaudoRepositoryDB(connectionManager);
        }


        public string Guardar(Recaudo recaudo)
        {
            try
            {
                connectionManager.OpenConnection();
                repositoryDB.Guardar(recaudo);
                return "Se ha guardado el recaudo exitosamente!";
            }
            catch (Exception e)
            {
                return $"Error de aplicacion {e.Message}";
            }
            finally { connectionManager.CloseConnection(); }
        }

        public IList<Recaudo> GetRecaudos()
        {
            try
            {

            }
            catch (Exception e)
            {

                throw;
            }
        }




    }
}
