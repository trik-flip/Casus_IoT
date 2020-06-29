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
        public Inloggen()
        {
            InitializeComponent();
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ZiekenhuisDB.accdb");
        }

        private void btn_Inloggen_Click(object sender, EventArgs e)
        {
           

            string gebruikersnaam = tb_Gebruikersnaam.Text;
            string wachtwoord = tb_Wachtwoord.Text;
            //Alle gebruikers moeten in 1 tabel komen met functie erbij
            //kolommen samenvoegen en dan vergelijken met elkaar. Dus gebruikersnaam, ww en functie
            //string voor opvragen data in db
            // eerst gebruikersnaam controleren of voorkomt in de db
            // ophalen gebruiker/wachtwoord
            // vergelijken met ingevoerde dus : gebruikersnaam hierboven en wachtwoord
            //als correct functie van gebruiker ophalen
            // met if en elif juiste menu openen.
            string query = "SELECT Gebruikersnaam FROM Verpleger WHERE Gebruikersnaam = @gebruikersnaam";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@gebruikersnaam", gebruikersnaam);
            cmd.Parameters.AddWithValue("@wachtwoord", wachtwoord);
            conn.Open(); //openeen connecet             
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) //database lezen
            {
                var gebruikersnaamDB = reader.GetString(0);
            }
            
        
            conn.Close();

            
            //@TODO Dit lijstje aanpassen naar functie van gebruiker
            if (tb_Gebruikersnaam.Text == "Verpleger01" && tb_Wachtwoord.Text == "Welkom123")
            {
                    
                    HoofdmenuVerpleger hoofdmenuVerpleger = new HoofdmenuVerpleger();
                    hoofdmenuVerpleger.Show();
                    this.Hide();

            }
            else if (tb_Gebruikersnaam.Text == "Dokter01")
            {
                if (tb_Wachtwoord.Text == "Welkom123")
                {
                    HoofdmenuDokter hoofdmenuDokter = new HoofdmenuDokter();
                    hoofdmenuDokter.Show();
                    this.Hide();
                }
            }
            else if (tb_Gebruikersnaam.Text == "Beveiliger01")
            {
                if (tb_Wachtwoord.Text == "Welkom123")
                {
                    HoofdmenuBeveiligingIT hoofdmenuBeveiliging = new HoofdmenuBeveiligingIT();
                    hoofdmenuBeveiliging.Show();
                    this.Hide();
                }
            }
            else if (tb_Gebruikersnaam.Text == "IT01")
            {
                if (tb_Wachtwoord.Text == "Welkom123")
                {
                    HoofdmenuBeveiligingIT hoofdmenuIt = new HoofdmenuBeveiligingIT();
                    hoofdmenuIt.Show();
                    this.Hide();        
                }
            }
            else MessageBox.Show("Ongeldige gebruikersnaam/wachtwoord");
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
