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
    public partial class MedewerkersPasVerwijderen : Form
    {
        OleDbConnection conn;
        private string naamMedewerkerDB;
        private string achternaamMedewerkerDB;

        public MedewerkersPasVerwijderen()
        {
            InitializeComponent();
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ZiekenhuisDB.accdb");
        }

        private void btn_Uitloggen_Click(object sender, EventArgs e)
        {
            //bij het uitloggen wordt gevraagd of de gebruiker het zeker weet, weet deze het zeker wordt het inlogscherm weergegeven.
            if (MessageBox.Show("U bent uitgelogd", "Uitloggen", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Inloggen inloggen = new Inloggen();
                inloggen.Show();
                this.Hide();
            };
        }

        private void btn_Verwijderen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Medewerkerspas is verwijdert", "Medewerkerspas verwijderen", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                HoofdmenuBeveiligingIT hoofdmenuBeveiligingIT = new HoofdmenuBeveiligingIT();
                hoofdmenuBeveiligingIT.Show();
                this.Close();
            }
        }

        private void btn_Annuleren_Click(object sender, EventArgs e)
        {
            //Bij annuleren wordt het menu voor het verwijderen van een pas weergegeven
            MenuPasVerwijderen menuPasVerwijderen = new MenuPasVerwijderen();
            menuPasVerwijderen.Show();
            this.Hide();
        }

        private void MedewerkersPasVerwijderen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //als de gebruiker op het kruisje klikt wordt het inlogscherm weergegeven
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Weet u het zeker?", "Afsluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    Inloggen inloggen = new Inloggen();
                    inloggen.Show();
                    this.Close();
                }
            }
        }

        private void btn_NaamZoeken_Click(object sender, EventArgs e)
        {
            //naam medewerker opzoeken in database
            var naamMedewerker = tb_NaamMedewerker.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (naamMedewerker.Length > 0)
            {
                string query = "SELECT Naam, Achternaam FROM Gebruiker WHERE Naam = @Naam AND Achternaam = @Achternaam";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@Naam", naamMedewerker[0]);
                cmd.Parameters.AddWithValue("@Achternaam", naamMedewerker[1]);
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    naamMedewerkerDB = reader.GetString(0);
                    achternaamMedewerkerDB = reader.GetString(1);
                }
                conn.Close();
            }

            if (naamMedewerker[0] == naamMedewerkerDB && naamMedewerker[1] == achternaamMedewerkerDB)
            {
                tb_NaamMedewerker.Text = naamMedewerkerDB + " " + achternaamMedewerkerDB;
            }
        }

        private void btn_ScanBarcode_Click(object sender, EventArgs e)
        {
            //scannen van de barcode van de pas indien dit mogelijk is, als verloren zoeken naar andere oplossing.
        }
    }
}
