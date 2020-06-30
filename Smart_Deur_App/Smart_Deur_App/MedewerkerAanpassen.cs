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
    public partial class MedewerkerAanpassen : Form
    {
        OleDbConnection conn;
        private string naamMedewerkerDB;
        private string achternaamMedewerkerDB;
        private string functieDB;
        private string adresDB;
        private int telefoonnummerDB;
        private string gebruikersnaamDB;
        private string wachtwoordDB;

        public MedewerkerAanpassen()
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

        private void btn_Aanpassen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Medewerker is aangepast ", "Medewerker aanpassen", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                var naamMedewerker = tb_NaamMedewerker.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string query = "UPDATE Gebruiker SET Naam = @Naam, Achternaam = @Achternaam, Adres = @Adres, Telefoonnummer = @Telefoonnummer, Functie = @Functie, Gebruikersnaam = @Gebruikersnaam, Wachtwoord = @Wachtwoord WHERE Naam = @Naam AND Achternaam = @Achternaam  ";                   
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@Naam", naamMedewerker[0]);
                cmd.Parameters.AddWithValue("@Achternaam", naamMedewerker[1]);
                cmd.Parameters.AddWithValue("@Adres", tb_Adres.Text);
                cmd.Parameters.AddWithValue("@Telefoonnummer", tb_Telefoonnummer.Text);
                cmd.Parameters.AddWithValue("@Functie", tb_Functie.Text);
                cmd.Parameters.AddWithValue("@Gebruikersnaam", tb_Gebruikersnaam.Text);
                cmd.Parameters.AddWithValue("@Wachtwoord", tb_Wachtwoord.Text);
                conn.Open();
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

        private void MedewerkerAanpassen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Weet u het zeker?", "Afsluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void btn_Zoeken_Click(object sender, EventArgs e)
        {
            var naamMedewerker = tb_NaamMedewerker.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if(naamMedewerker.Length > 0) { 
            string query = "SELECT Naam, Achternaam FROM Gebruiker WHERE Naam = @Naam AND Achternaam = @Achternaam";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@Naam", naamMedewerker[0]);
            cmd.Parameters.AddWithValue("@Achternaam", naamMedewerker[1]);
            conn.Open(); //openeen connecet             
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) //database lezen
            {
                naamMedewerkerDB = reader.GetString(0);
                achternaamMedewerkerDB = reader.GetString(1);
            }
            conn.Close();

            if (naamMedewerker[0] == naamMedewerkerDB && naamMedewerker[1] == achternaamMedewerkerDB)
            {
                string ophalen = "SELECT Functie, Adres, Telefoonnummer, Gebruikersnaam, Wachtwoord FROM Gebruiker WHERE @Naam AND Achternaam = @Achternaam";
                OleDbCommand gegevens = new OleDbCommand(ophalen, conn);
                gegevens.Parameters.AddWithValue("@naamMedewerker", naamMedewerker[0]);
                gegevens.Parameters.AddWithValue("@Achternaam", naamMedewerker[1]);
                conn.Open();
                OleDbDataReader readerGegevens = gegevens.ExecuteReader();
                while (readerGegevens.Read()) //database lezen
                {
                    functieDB = readerGegevens.GetString(0);
                    adresDB = readerGegevens.GetString(1);
                    telefoonnummerDB = readerGegevens.GetInt32(2);
                    gebruikersnaamDB = readerGegevens.GetString(3);
                    wachtwoordDB = readerGegevens.GetString(4);
                }
                conn.Close();
            }
            else MessageBox.Show("Medewerker bestaat niet");

            tb_NaamMedewerker.Text = naamMedewerkerDB+ " " + achternaamMedewerkerDB;
            tb_Functie.Text = functieDB;
            tb_Adres.Text = adresDB;
            tb_Telefoonnummer.Text = telefoonnummerDB.ToString();
            tb_Gebruikersnaam.Text = gebruikersnaamDB;
            tb_Wachtwoord.Text = wachtwoordDB;
            }
        }
    }
}
