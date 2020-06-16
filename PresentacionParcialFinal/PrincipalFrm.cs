using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BLL;
using Entity;

namespace PresentacionParcialFinal
{
    public partial class PrincipalFrm : Form
    {
        private RecaudoServiceFile serviceFile;
        private RecaudoServiceDB serviceDB;
        private IList<Recaudo> recaudos = new List<Recaudo>();
        public PrincipalFrm()
        {
            InitializeComponent();
            serviceFile = new RecaudoServiceFile();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            serviceDB = new RecaudoServiceDB(connectionString);

            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string ruta = string.Empty;

            openFileDialog.ShowDialog();

            if (openFileDialog.FileName.Equals("") == false)
                ruta = openFileDialog.FileName;

            RespuestaGetRecaudos respuesta = serviceFile.GetRecaudos(ruta);
            

            if (!respuesta.Error)
            {
                recaudos = respuesta.GetRecaudos;
                if (recaudos.Count != 0)
                {
                    foreach (var item in recaudos)
                    {
                        DgvTableRecaudo.Rows.Add(item.NitAgente,item.MesReporte, item.VigenciaReporte,item.TipoEstampilla,
                                                 item.ValorImpuesto,item.Contratista.Identificacion,item.Contratista.Nombre);
                    }
                }
            }
            MessageBox.Show(respuesta.Message);
        }

        private void BtnImportar_Click(object sender, EventArgs e)
        {
            string message = "";
            foreach (var item in recaudos)
            {
                message = serviceDB.Guardar(item);
            }

            MessageBox.Show(message);
            
        }
    }
}
