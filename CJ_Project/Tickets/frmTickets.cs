using EAGetMail;
using Formulario;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Tickets
{
    public partial class frmTickets : Form
    {
        MailInfo[] infos;
        int contador = 0;
        List<String> lista = new List<String>();
        public frmTickets()
        {
            InitializeComponent();
        }

        private void frmTickets_Load(object sender, EventArgs e)
        {
        
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
                infos = oClient.GetMailInfos();
                for (int i = 0; i < infos.Length; i++)
                {
                    MailInfo info = infos[i];
                    Mail oMail = oClient.GetMail(info);
                    
                    if (!info.Read)
                    {
                        json = oMail.TextBody;
                        Formu jsonObj = new Formu();
                        jsonObj = JsonConvert.DeserializeObject<Formu>(json);
                        dgvSolicitudes.Rows[dgvSolicitudes.Rows.Add()].Cells[0].Value = (contador + 1).ToString(); 
                        dgvSolicitudes.Rows[contador].Cells[1].Value = jsonObj.NombreCompleto;
                        dgvSolicitudes.Rows[contador].Cells[2].Value = oMail.ReceivedDate.ToShortDateString();
                        lista.Add(json);
                        contador++;
                    }
                    
                }
                // Quit and purge emails marked as deleted from Gmail IMAP4 server.
                oClient.Quit();
                Console.Read();
            }
            catch (Exception ep)
            {
                Console.WriteLine(ep.Message);
                Console.Read();
            }
        }

        private void frmTickets_FormClosing(object sender, FormClosingEventArgs e)
        {        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvSolicitudes.Rows.Clear();
            leerCorreos();
        }

        private void dgvSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var numCliente=0;
            
            if(e.ColumnIndex == 3)
            {
                numCliente = e.RowIndex;
                MessageBox.Show(lista[numCliente]);

            }                   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
