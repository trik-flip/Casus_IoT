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
    public partial class MedewerkerVerwijderen : Form

    {
        OleDbConnection conn;
        private string naamMedewerkerDB;
        private string achternaamMedewerkerDB;
        private string functieDB;

        public MedewerkerVerwijderen()
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

        private void MedewerkerVerwijderen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Weet u het zeker?", "Afsluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void btn_Annuleren_Click(object sender, EventArgs e)
        {
            HoofdmenuBeveiligingIT hoofdmenuBeveiligingIT = new HoofdmenuBeveiligingIT();
            hoofdmenuBeveiligingIT.Show();
            this.Close();
        }

        private void btn_Verwijderen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Medewerker is verwijdert", "Medewerker verwijderen", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                var naamMedewerker = tb_NaamMedewerker.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (naamMedewerker.Length > 0)
                {
                    string query = "DELETE FROM Gebruiker WHERE Naam = @Naaam AND Achternaam = @Achternaam";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Naam", naamMedewerker[0]);
                    cmd.Parameters.AddWithValue("@Achternaam", naamMedewerker[1]);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    HoofdmenuBeveiligingIT hoofdmenuBeveiligingIT = new HoofdmenuBeveiligingIT();
                    hoofdmenuBeveiligingIT.Show();
                    this.Hide();
                }
            }
        }

        private void btn_NaamZoeken_Click(object sender, EventArgs e)
        {
            var naamMedewerker = tb_NaamMedewerker.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (naamMedewerker.Length > 0)
            {
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
            }
            if (naamMedewerker[0] == naamMedewerkerDB && naamMedewerker[1] == achternaamMedewerkerDB)
            {
                string queryFunctie = "SELECT Functie FROM Gebruiker WHERE Naam = @Naam AND Achternaam = @Achternaam";
                OleDbCommand functie = new OleDbCommand(queryFunctie, conn);
                functie.Parameters.AddWithValue("@Naam", naamMedewerker[0]);
                functie.Parameters.AddWithValue("@Achternaam", naamMedewerker[1]);
                conn.Open(); //openeen connecet             
                OleDbDataReader readerFunctie = functie.ExecuteReader();

                while (readerFunctie.Read()) //database lezen
                {
                    functieDB = readerFunctie.GetString(0);

                }
                conn.Close();



                tb_NaamMedewerker.Text = naamMedewerkerDB + " " + achternaamMedewerkerDB;
                tb_Functie.Text = functieDB;
            }
        }
    }
}
