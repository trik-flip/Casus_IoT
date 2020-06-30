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
    public partial class Logboek : Form
    {
        OleDbConnection conn;
        private string kamernummerDB;

        public Logboek()
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

        private void btn_Annuleren_Click(object sender, EventArgs e)
        {
            HoofdmenuBeveiligingIT hoofdmenuBeveiligingIT = new HoofdmenuBeveiligingIT();
            hoofdmenuBeveiligingIT.Show();
            this.Hide();
        }

        private void Logboek_FormClosing(object sender, FormClosingEventArgs e)
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

            string query = "SELECT Kamernummer FROM Kamer WHERE Kamernummer = @Kamernummer";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@Kamernummer", tb_Zoeken.Text);
            conn.Open();           
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                kamernummerDB = reader.GetString(0);
            } 
            
            conn.Close();
            if (tb_Zoeken.Text == kamernummerDB)
            {
                string weergeven = "SELECT * FROM Kamer WHERE Kamernummer =@Kamernummer";
                OleDbCommand oleDb = new OleDbCommand(weergeven, conn);
                oleDb.Parameters.AddWithValue("@Kamernummer", tb_Zoeken.Text);
                conn.Open();
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDb);
                DataSet ds = new DataSet();
                oleDbDataAdapter.Fill(ds);
                dg_Logboek.DataSource = ds.Tables[0];
                conn.Close();
                
            }
            else MessageBox.Show("Geen record gvonden van de kamer ", tb_Zoeken.Text);
        }   
    }
}
