﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vIT_System.SQL;
using vIT_System.Förskott;
using System.Net.Mail;
namespace vIT_System.GUI
{
    public partial class frmPreShooting : Form
    {
        public frmPreShooting()
        {
            InitializeComponent();
        }
        private void frmPreShooting_Load(object sender, EventArgs e)
        {
            //Hämtar alla bossar och fyller upp combobox med alla chefer som finns
            var lista = DataPreShooting.FillCbBoss();
            foreach (var chef in lista)
            {
                cbBoss.Items.Add(chef);
            }

            //Fhämtar alla uppdrag som finns i databasen och fyller comboboxen
            //denna fungerar inte förrän det finns en uppdtagstabell i databasen
            //var uppdraglista = DataPreShooting.FillCbChooseUppdrag();
            //foreach (var uppd in uppdraglista)
            //{
            //    cbChooseUppdrag.Items.Add(uppd);
            //}
        }

        //Posta innehållet i formuläret till databasen
        private void btnSendPre_Click(object sender, EventArgs e)
        {
            SmtpClient client = new SmtpClient();

            string from = "sergio.saxofonguden@gmail.com";
            string to = "painblom@gmail.com"; 
            string subject = "Ny vits ansökan";
            string meddelande = "Du har en ny ansökan från någon utav dina anställda konsulter";

            MailMessage mail = new MailMessage(from, to, subject, meddelande);
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("sergio.saxofonguden@gmail.com", "Sergio1977");

            try
            {
                client.Send(mail);
                MessageBox.Show("Mail skickat!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            var motiv = tbMotivation.Text;
            var sum = 0;

            if (Validation.IsEmpty(motiv) || Validation.IsEmpty(tbSum.Text))
            {
                MessageBox.Show("Fyll i alla fält!");
            }
            else
            {
                var bossID = DataPreShooting.getBoss(cbBoss.SelectedItem.ToString());
                DataPreShooting.savePreShooting(sum, motiv, bossID);
                tbMotivation.Text = "";
                tbSum.Text = "";
            }

            //var uppd = cbChooseUppdrag.SelectedItem.ToString();
        }
    }
}
