﻿using System;
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
    public partial class MedewerkersPasAanpassen : Form
    {
        OleDbConnection conn;
        private string naamMedewerkerDB;
        private string achternaamMedewerkerDB;
        private string functieDB;
        private string adresDB;
        private int telefoonnummerDB;
        private string kamernummerDB;

        public MedewerkersPasAanpassen()
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

        private void MedewerkersPasAanpassen_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_Aanpassen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Medewerkerspas is aangepast ", "Medewerkerspas aanpassen", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                //TODO: medewerkersgegevens aanpassen en dit na de database schrijven
                HoofdmenuBeveiligingIT hoofdmenuBeveiligingIT = new HoofdmenuBeveiligingIT();
                hoofdmenuBeveiligingIT.Show();
                this.Close();
            }
        }

        private void btn_Annuleren_Click(object sender, EventArgs e)
        {
            //Bij annuleren wordt het menu voor het aanpassen van een pas weergegeven.
            MenuPasAanpassen menuPasAanpassen = new MenuPasAanpassen();
            menuPasAanpassen.Show();
            this.Close();
        }

        private void btn_NaamZoeken_Click(object sender, EventArgs e)
        {
            // de naam van de medewerker opzoeken in de database en gegevens weergeven
            // TODO: barcode ophalen en weergeven
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

                if (naamMedewerker[0] == naamMedewerkerDB && naamMedewerker[1] == achternaamMedewerkerDB)
                {
                    string ophalen = "SELECT Functie, Adres, Telefoonnummer, Kamernummer FROM Gebruiker WHERE @Naam AND Achternaam = @Achternaam";
                    OleDbCommand gegevens = new OleDbCommand(ophalen, conn);
                    gegevens.Parameters.AddWithValue("@naamMedewerker", naamMedewerker[0]);
                    gegevens.Parameters.AddWithValue("@Achternaam", naamMedewerker[1]);
                    conn.Open();
                    OleDbDataReader readerGegevens = gegevens.ExecuteReader();
                    while (readerGegevens.Read()) 
                    {
                        functieDB = readerGegevens.GetString(0);
                        adresDB = readerGegevens.GetString(1);
                        telefoonnummerDB = readerGegevens.GetInt32(2);
                        kamernummerDB = readerGegevens.GetString(3);
                    }
                    conn.Close();
                }
                else MessageBox.Show("Medewerker bestaat niet");

                tb_NaamMedewerker.Text = naamMedewerkerDB + " " + achternaamMedewerkerDB;
                tb_Functie.Text = functieDB;
                tb_Adres.Text = adresDB;
                tb_Telefoonnummer.Text = telefoonnummerDB.ToString();
                tb_Kamernummers.Text = kamernummerDB;
            }
        }

        private void btn_KamerToevoegen_Click(object sender, EventArgs e)
        {
            //TODO: mogelijk maken meerdere kamers aan een medewerker te koppelen
        }

        private void btn_ScanBarcode_Click(object sender, EventArgs e)
        {
            //scannen barcode van de pas
        }
    }
}
