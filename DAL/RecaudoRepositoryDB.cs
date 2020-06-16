using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
using System.Data;

namespace DAL
{
    public class RecaudoRepositoryDB
    {
        private readonly SqlConnection sqlConnection;

        public RecaudoRepositoryDB(ConnectionManager connectionManager)
        {
            sqlConnection = connectionManager.SqlConnection;
        }

        public void Guardar(Recaudo recaudo)
        {
            using (var command = sqlConnection.CreateCommand())
            {
                command.CommandText = "insertRecaudo";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@NitAgente", recaudo.NitAgente);
                command.Parameters.AddWithValue("@MesReporte", recaudo.MesReporte);
                command.Parameters.AddWithValue("@VigenciaReporte", recaudo.VigenciaReporte);
                command.Parameters.AddWithValue("@TipoEstampilla", recaudo.TipoEstampilla);
                command.Parameters.AddWithValue("@ValorImpuesto", recaudo.ValorImpuesto);
                command.Parameters.AddWithValue("@IDContratista", recaudo.Contratista.Identificacion);
                command.Parameters.AddWithValue("@NombreContratista", recaudo.Contratista.Nombre);

                command.ExecuteNonQuery();
            }
        }

        public IList<Recaudo> GetRecaudos()
        {
            SqlDataReader sqlDataReader;
            IList<Recaudo> recaudos = new List<Recaudo>();

            using (var command = sqlConnection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Recaudos";

                sqlDataReader = command.ExecuteReader();
                if(sqlDataReader.HasRows)
                {
                    while(sqlDataReader.Read())
                    {
                        Recaudo r = MapRecaudo(sqlDataReader);
                        recaudos.Add(r);
                    }
                }
             
            }

            return recaudos;
        }

        public Recaudo MapRecaudo(SqlDataReader sqlDataReader)
        {
            Contratista contratista = new Contratista();

            contratista.Identificacion = sqlDataReader.GetString(5);
            contratista.Nombre = sqlDataReader.GetString(6);

            Recaudo recaudo = new Recaudo();

            recaudo.NitAgente = sqlDataReader.GetString(0);
            recaudo.MesReporte = sqlDataReader.GetInt32(1);
            recaudo.VigenciaReporte = sqlDataReader.GetInt32(2);
            recaudo.TipoEstampilla = sqlDataReader.GetString(3);
            recaudo.ValorImpuesto = sqlDataReader.GetDecimal(4);

            recaudo.Contratista = contratista;


            return recaudo;
                
        }
    }
}
