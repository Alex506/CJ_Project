using EAGetMail;
using Formulario;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickets
{
    public partial class frmTickets : Form
    {
        public frmTickets()
        {
            InitializeComponent();
        }

        private void frmTickets_Load(object sender, EventArgs e)
        {
            //dgvSolicitudes.Rows[dgvSolicitudes.Rows.Add()].Cells[0].Value = "Juan Perez";
            //dgvSolicitudes.Rows[0].Cells[1].Value = "02/07/2018";
            //dgvSolicitudes.Rows[dgvSolicitudes.Rows.Add()].Cells[0].Value = "Diana Gomez";
            //dgvSolicitudes.Rows[1].Cells[1].Value = "15/07/2018";
            //dgvSolicitudes.Rows[dgvSolicitudes.Rows.Add()].Cells[0].Value = "Raquel Garcia";
            //dgvSolicitudes.Rows[2].Cells[1].Value = "30/08/2018";
            //dgvSolicitudes.Rows[dgvSolicitudes.Rows.Add()].Cells[0].Value = "Pedro Alfaro";
            //dgvSolicitudes.Rows[3].Cells[1].Value = "05/08/2018";
            //dgvSolicitudes.Rows[dgvSolicitudes.Rows.Add()].Cells[0].Value = "Valeria Salas";
            //dgvSolicitudes.Rows[4].Cells[1].Value = "09/08/2018";


            leerCorreos();
        }
        private void leerCorreos()
        {
            // Create a folder named "inbox" under current directory
            // to save the email retrieved.
            string curpath = Directory.GetCurrentDirectory();
            string mailbox = String.Format("{0}\\inbox", curpath);
            // If the folder is not existed, create it.
            if (!Directory.Exists(mailbox))
            {
                Directory.CreateDirectory(mailbox);
            }
            MailServer oServer = new MailServer("imap.gmail.com", "emailsmtp04@gmail.com", "correocs", ServerProtocol.Imap4);
            MailClient oClient = new MailClient("TryIt");
            oServer.SSLConnection = true;
            oServer.Port = 993;
            try
            {
                string json;

                oClient.Connect(oServer);
                MailInfo[] infos = oClient.GetMailInfos();
                for (int i = 0; i < infos.Length; i++)
                {
                    int contador = 0;
                    MailInfo info = infos[i];
                    Mail oMail = oClient.GetMail(info);
                    if (!info.Read)
                    {
                        json = oMail.TextBody;
                        Formu jsonO = new Formu();
                        jsonO = JsonConvert.DeserializeObject<Formu>(json);
                        MessageBox.Show(jsonO.NombreCompleto);
                        dgvSolicitudes.Rows[dgvSolicitudes.Rows.Add()].Cells[0].Value = jsonO.NombreCompleto;
                        dgvSolicitudes.Rows[contador].Cells[1].Value = oMail.ReceivedDate.ToShortDateString();
                        dgvSolicitudes.Rows[contador].Cells[3].Value = false;
                        contador++;
                    }                                                         
                }              
                oClient.Quit();
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.ToString());
            }
        }

        private void frmTickets_FormClosing(object sender, FormClosingEventArgs e)
        {            
           //DialogResult dr =  MessageBox.Show("¿Desea salir?", "Salir",MessageBoxButtons.YesNo);
           // if (DialogResult.No == dr)
           // {
           //     e.Cancel = true;
           // }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvSolicitudes.Rows.Clear();
            //leerCorreos();
        }

        private void dgvSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {     
        }
    }
}
