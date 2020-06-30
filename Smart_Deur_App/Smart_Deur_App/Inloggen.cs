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
    public partial class Inloggen : Form
    {

        OleDbConnection conn;
        private string gebruikersnaamDB;
        private string wachtwoordDB;
        private string functieDB;
        public Inloggen()
        {
            InitializeComponent();
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ZiekenhuisDB.accdb.accdb");
        }

        private void btn_Inloggen_Click(object sender, EventArgs e)
        {


            string gebruikersnaam = tb_Gebruikersnaam.Text;
            string wachtwoord = tb_Wachtwoord.Text;
            string query = "SELECT Gebruikersnaam, Wachtwoord FROM Gebruiker WHERE Gebruikersnaam = @gebruikersnaam AND Wachtwoord = @wachtwoord";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@gebruikersnaam", gebruikersnaam);
            cmd.Parameters.AddWithValue("@wachtwoord", wachtwoord);
            conn.Open(); //openeen connecet             
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) //database lezen
            {
                gebruikersnaamDB = reader.GetString(0);
                wachtwoordDB = reader.GetString(1);
            }
            conn.Close();


            if (gebruikersnaam == gebruikersnaamDB && wachtwoord == wachtwoordDB) //contorleren combinatie gebruikersnaam en wachtwoord
            {
                string controleer = "SELECT Functie FROM Gebruiker WHERE Gebruikersnaam = @gebruikersnaam";
                OleDbCommand controleren = new OleDbCommand(controleer, conn);
                controleren.Parameters.AddWithValue("@gebruikersnaam", gebruikersnaam);
                conn.Open();
                OleDbDataReader reader1 = controleren.ExecuteReader();
                while (reader1.Read())
                {
                    functieDB = reader1.GetString(0);

                }
                conn.Close();

                if (functieDB == "Verpleger")
                {
                    HoofdmenuVerpleger hoofdmenuVerpleger = new HoofdmenuVerpleger();
                    hoofdmenuVerpleger.Show();
                    this.Hide();
                }
                else if (functieDB == "Dokter")
                {

                    HoofdmenuDokter hoofdmenuDokter = new HoofdmenuDokter();
                    hoofdmenuDokter.Show();
                    this.Hide();

                }
                else if (functieDB == "Beveiliger")
                {


                    HoofdmenuBeveiligingIT hoofdmenuBeveiliging = new HoofdmenuBeveiligingIT();
                    hoofdmenuBeveiliging.Show();
                    this.Hide();

                }
                else if (functieDB == "Iter")
                {

                    HoofdmenuBeveiligingIT hoofdmenuIt = new HoofdmenuBeveiligingIT();
                    hoofdmenuIt.Show();
                    this.Hide();

                }
                else MessageBox.Show("Gebruiker heeft geen functie");

            }
            else MessageBox.Show("Onjuist gebruikersnaam/wachtwoord ");

        }



        private void Inloggen_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Weet u het zeker?", "Afsluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    Application.ExitThread();
                }
            }

        }
    }
    
}
