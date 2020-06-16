using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;

namespace DAL
{
    public class RecaudoRepositoryFile
    {
        
        public IList<Recaudo> GetRecaudos(string ruta)
        {
            IList<Recaudo> recaudos = new List<Recaudo>();

            FileStream fileStream = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader streamReader = new StreamReader(fileStream);

            string linea = string.Empty;

            while((linea = streamReader.ReadLine()) != null)
            {
                Recaudo r = MapRecaudo(linea);
                recaudos.Add(r);
            }
            streamReader.Close();
            fileStream.Close();
            return recaudos;
        }

        private  Recaudo MapRecaudo(string linea)
        {
            Contratista contratista = new Contratista();
            string[] datos = linea.Split(';');

            contratista.Identificacion = datos[5];
            contratista.Nombre = datos[6];

            Recaudo recaudo = new Recaudo();

            recaudo.NitAgente = datos[0];
            recaudo.MesReporte = int.Parse(datos[1]);
            recaudo.VigenciaReporte = int.Parse(datos[2]);
            recaudo.TipoEstampilla = datos[3];
            recaudo.ValorImpuesto = decimal.Parse(datos[4]);
            recaudo.Contratista = contratista;

            return recaudo;
        }
    }
}
