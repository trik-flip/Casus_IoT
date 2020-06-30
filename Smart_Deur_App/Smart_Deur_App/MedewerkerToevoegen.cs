using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Deur_App
{
    public partial class MedewerkerToevoegen : Form
    {
        OleDbConnection conn; 
        public MedewerkerToevoegen()
        {
            InitializeComponent();
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ZiekenhuisDB.accdb");
        }

        private void btn_Uitloggen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("U bent uitgelogd", "Uitloggen", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Inloggen inloggen = new Inloggen();
                inloggen.Show();
                this.Hide();
            };
        }

        private void btn_Toevoegen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Medewerker is toegevoegd", "Medewerker toevoegen", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                //insert into
                int medewerkernr = 55555;
                string naam = tb_NaamMedewerker.Text;
                string functie = tb_Functie.Text;
                string adres = tb_Adres.Text;
                //int telefoonnummer = tb_Telefoonnummer.ToInt;
                string gebruikersnaam = tb_Gebruikersnaam.Text;
                string wachtwoord = tb_Wachtwoord.Text;
                string achternaam = "Potter";
                string kind = "Albus";
                int telefoonnummer = 515616;
                int pasid = 9999;
                string kamernummmer = "KAW10";
                
                string query = "INSERT INTO Gebruiker (RegistratieNR, Naam, Achternaam, Adres, Telefoonnummer, Kind, Kamernummer, PasID, Functie, Gebruikersnaam, Wachtwoord) " +
                    "VALUES (@medewerkernr,@naam, @achternaam, @@adres, @telefoonnummer, @kind, @kamernummer, @pasid,@functie, @gebruikersnaam, @wachtwoord)";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                //cmd.Parameters.AddWithValue("@ID", 20);
                cmd.Parameters.AddWithValue("@medewerkernr", medewerkernr);
                cmd.Parameters.AddWithValue("@naam", naam);
                cmd.Parameters.AddWithValue("@achternaam", achternaam); 
                cmd.Parameters.AddWithValue("@adres", adres);
                cmd.Parameters.AddWithValue("@telefoonnummer", telefoonnummer);
                cmd.Parameters.AddWithValue("@kind", kind);
                cmd.Parameters.AddWithValue("@kamernummer", kamernummmer);
                cmd.Parameters.AddWithValue("@pasid", pasid);
                cmd.Parameters.AddWithValue("@functie", functie);
                cmd.Parameters.AddWithValue("@gebruikersnaam", gebruikersnaam);
                cmd.Parameters.AddWithValue("@wachtwoord", wachtwoord);
                conn.Open();
                //cmd.ExecuteReaderAsync();
                cmd.ExecuteNonQuery();
                conn.Close();
                         


                HoofdmenuBeveiligingIT hoofdmenuBeveiligingIT = new HoofdmenuBeveiligingIT();
                hoofdmenuBeveiligingIT.Show();
                this.Close();
            }
        }

        private void btn_Annuleren_Click(object sender, EventArgs e)
        {
            HoofdmenuBeveiligingIT hoofdmenuBeveiligingIT = new HoofdmenuBeveiligingIT();
            hoofdmenuBeveiligingIT.Show();
            this.Close();
        }

        private void MedewerkerToevoegen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing)
           // {
            //    if (MessageBox.Show("Weet u het zeker?", "Afsluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            //    {
            //        this.Close();
            //    }
            //}
        }
    }
}
