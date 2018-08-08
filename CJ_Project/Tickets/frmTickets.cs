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
                oClient.Connect(oServer);
                MailInfo[] infos = oClient.GetMailInfos();
                for (int i = 0; i < infos.Length; i++)
                {
                    MailInfo info = infos[i];
                    Mail oMail = oClient.GetMail(info);
                    if (!info.Read)
                    {
                        dgvSolicitudes.Rows[dgvSolicitudes.Rows.Add()].Cells[0].Value = oMail.TextBody;
                        dgvSolicitudes.Rows[i].Cells[1].Value = oMail.ReceivedDate;
                        string json = oMail.TextBody;
                        MessageBox.Show(json);
                        Formu jsonObj = new Formu();
                        jsonObj = JsonConvert.DeserializeObject<Formu>(json);
                        MessageBox.Show(jsonObj.NombreCompleto);
                    }
                    // Download email from GMail IMAP4 server
                    //string json = oMail.TextBody;
                    //MessageBox.Show(json);
                    //InfoForm JsonObj = new InfoForm();
                    //JsonObj = JsonConvert.DeserializeObject<InfoForm>(json);
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
    }
}
