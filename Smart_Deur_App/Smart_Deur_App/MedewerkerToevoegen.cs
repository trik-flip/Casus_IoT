using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Deur_App
{
    public partial class MedewerkerToevoegen : Form
    {
        private Button btn_Annuleren;
        private Button btn_Toevoegen;
        private TextBox tb_Telefoonnummer;
        private TextBox tb_Functie;
        private TextBox tb_Adres;
        private TextBox tb_Gebruikersnaam;
        private Button btn_Uitloggen;
        private TextBox tb_NaamMedewerker;
        private Label lb_Gebruikersnaam;
        private Label lb_Telefoonnummer;
        private Label lb_Adres;
        private Label lb_Functie;
        private Label lb_NaamMedewerker;
        private Label lb_MedewerkerToevoegen;
        private Label lb_Wachtwoord;
        private TextBox tb_Wachtwoord;

        public MedewerkerToevoegen()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btn_Annuleren = new System.Windows.Forms.Button();
            this.btn_Toevoegen = new System.Windows.Forms.Button();
            this.tb_Telefoonnummer = new System.Windows.Forms.TextBox();
            this.tb_Functie = new System.Windows.Forms.TextBox();
            this.tb_Adres = new System.Windows.Forms.TextBox();
            this.tb_Gebruikersnaam = new System.Windows.Forms.TextBox();
            this.btn_Uitloggen = new System.Windows.Forms.Button();
            this.tb_NaamMedewerker = new System.Windows.Forms.TextBox();
            this.lb_Gebruikersnaam = new System.Windows.Forms.Label();
            this.lb_Telefoonnummer = new System.Windows.Forms.Label();
            this.lb_Adres = new System.Windows.Forms.Label();
            this.lb_Functie = new System.Windows.Forms.Label();
            this.lb_NaamMedewerker = new System.Windows.Forms.Label();
            this.lb_MedewerkerToevoegen = new System.Windows.Forms.Label();
            this.lb_Wachtwoord = new System.Windows.Forms.Label();
            this.tb_Wachtwoord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Annuleren
            // 
            this.btn_Annuleren.Location = new System.Drawing.Point(258, 303);
            this.btn_Annuleren.Name = "btn_Annuleren";
            this.btn_Annuleren.Size = new System.Drawing.Size(75, 23);
            this.btn_Annuleren.TabIndex = 38;
            this.btn_Annuleren.Text = "Annuleren";
            this.btn_Annuleren.UseVisualStyleBackColor = true;
            // 
            // btn_Toevoegen
            // 
            this.btn_Toevoegen.Location = new System.Drawing.Point(148, 303);
            this.btn_Toevoegen.Name = "btn_Toevoegen";
            this.btn_Toevoegen.Size = new System.Drawing.Size(75, 23);
            this.btn_Toevoegen.TabIndex = 37;
            this.btn_Toevoegen.Text = "Toevoegen";
            this.btn_Toevoegen.UseVisualStyleBackColor = true;
            // 
            // tb_Telefoonnummer
            // 
            this.tb_Telefoonnummer.Location = new System.Drawing.Point(190, 177);
            this.tb_Telefoonnummer.Name = "tb_Telefoonnummer";
            this.tb_Telefoonnummer.Size = new System.Drawing.Size(118, 20);
            this.tb_Telefoonnummer.TabIndex = 33;
            // 
            // tb_Functie
            // 
            this.tb_Functie.Location = new System.Drawing.Point(190, 101);
            this.tb_Functie.Name = "tb_Functie";
            this.tb_Functie.Size = new System.Drawing.Size(118, 20);
            this.tb_Functie.TabIndex = 32;
            // 
            // tb_Adres
            // 
            this.tb_Adres.Location = new System.Drawing.Point(190, 141);
            this.tb_Adres.Name = "tb_Adres";
            this.tb_Adres.Size = new System.Drawing.Size(118, 20);
            this.tb_Adres.TabIndex = 31;
            // 
            // tb_Gebruikersnaam
            // 
            this.tb_Gebruikersnaam.Location = new System.Drawing.Point(190, 218);
            this.tb_Gebruikersnaam.Name = "tb_Gebruikersnaam";
            this.tb_Gebruikersnaam.Size = new System.Drawing.Size(118, 20);
            this.tb_Gebruikersnaam.TabIndex = 30;
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Location = new System.Drawing.Point(400, 9);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(75, 23);
            this.btn_Uitloggen.TabIndex = 29;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            // 
            // tb_NaamMedewerker
            // 
            this.tb_NaamMedewerker.Location = new System.Drawing.Point(190, 68);
            this.tb_NaamMedewerker.Name = "tb_NaamMedewerker";
            this.tb_NaamMedewerker.Size = new System.Drawing.Size(118, 20);
            this.tb_NaamMedewerker.TabIndex = 28;
            // 
            // lb_Gebruikersnaam
            // 
            this.lb_Gebruikersnaam.AutoSize = true;
            this.lb_Gebruikersnaam.Location = new System.Drawing.Point(59, 221);
            this.lb_Gebruikersnaam.Name = "lb_Gebruikersnaam";
            this.lb_Gebruikersnaam.Size = new System.Drawing.Size(87, 13);
            this.lb_Gebruikersnaam.TabIndex = 26;
            this.lb_Gebruikersnaam.Text = "Gebruikersnaam:";
            // 
            // lb_Telefoonnummer
            // 
            this.lb_Telefoonnummer.AutoSize = true;
            this.lb_Telefoonnummer.Location = new System.Drawing.Point(59, 184);
            this.lb_Telefoonnummer.Name = "lb_Telefoonnummer";
            this.lb_Telefoonnummer.Size = new System.Drawing.Size(89, 13);
            this.lb_Telefoonnummer.TabIndex = 25;
            this.lb_Telefoonnummer.Text = "Telefoonnummer:";
            // 
            // lb_Adres
            // 
            this.lb_Adres.AutoSize = true;
            this.lb_Adres.Location = new System.Drawing.Point(59, 141);
            this.lb_Adres.Name = "lb_Adres";
            this.lb_Adres.Size = new System.Drawing.Size(37, 13);
            this.lb_Adres.TabIndex = 24;
            this.lb_Adres.Text = "Adres:";
            // 
            // lb_Functie
            // 
            this.lb_Functie.AutoSize = true;
            this.lb_Functie.Location = new System.Drawing.Point(59, 104);
            this.lb_Functie.Name = "lb_Functie";
            this.lb_Functie.Size = new System.Drawing.Size(45, 13);
            this.lb_Functie.TabIndex = 23;
            this.lb_Functie.Text = "Functie:";
            // 
            // lb_NaamMedewerker
            // 
            this.lb_NaamMedewerker.AutoSize = true;
            this.lb_NaamMedewerker.Location = new System.Drawing.Point(59, 68);
            this.lb_NaamMedewerker.Name = "lb_NaamMedewerker";
            this.lb_NaamMedewerker.Size = new System.Drawing.Size(99, 13);
            this.lb_NaamMedewerker.TabIndex = 22;
            this.lb_NaamMedewerker.Text = "Naam medewerker:";
            // 
            // lb_MedewerkerToevoegen
            // 
            this.lb_MedewerkerToevoegen.AutoSize = true;
            this.lb_MedewerkerToevoegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MedewerkerToevoegen.Location = new System.Drawing.Point(54, 9);
            this.lb_MedewerkerToevoegen.Name = "lb_MedewerkerToevoegen";
            this.lb_MedewerkerToevoegen.Size = new System.Drawing.Size(237, 25);
            this.lb_MedewerkerToevoegen.TabIndex = 21;
            this.lb_MedewerkerToevoegen.Text = "Medewerker toevoegen";
            // 
            // lb_Wachtwoord
            // 
            this.lb_Wachtwoord.AutoSize = true;
            this.lb_Wachtwoord.Location = new System.Drawing.Point(61, 258);
            this.lb_Wachtwoord.Name = "lb_Wachtwoord";
            this.lb_Wachtwoord.Size = new System.Drawing.Size(71, 13);
            this.lb_Wachtwoord.TabIndex = 39;
            this.lb_Wachtwoord.Text = "Wachtwoord:";
            // 
            // tb_Wachtwoord
            // 
            this.tb_Wachtwoord.Location = new System.Drawing.Point(190, 255);
            this.tb_Wachtwoord.Name = "tb_Wachtwoord";
            this.tb_Wachtwoord.Size = new System.Drawing.Size(118, 20);
            this.tb_Wachtwoord.TabIndex = 40;
            // 
            // MedewerkerToevoegen
            // 
            this.ClientSize = new System.Drawing.Size(502, 385);
            this.Controls.Add(this.tb_Wachtwoord);
            this.Controls.Add(this.lb_Wachtwoord);
            this.Controls.Add(this.btn_Annuleren);
            this.Controls.Add(this.btn_Toevoegen);
            this.Controls.Add(this.tb_Telefoonnummer);
            this.Controls.Add(this.tb_Functie);
            this.Controls.Add(this.tb_Adres);
            this.Controls.Add(this.tb_Gebruikersnaam);
            this.Controls.Add(this.btn_Uitloggen);
            this.Controls.Add(this.tb_NaamMedewerker);
            this.Controls.Add(this.lb_Gebruikersnaam);
            this.Controls.Add(this.lb_Telefoonnummer);
            this.Controls.Add(this.lb_Adres);
            this.Controls.Add(this.lb_Functie);
            this.Controls.Add(this.lb_NaamMedewerker);
            this.Controls.Add(this.lb_MedewerkerToevoegen);
            this.Name = "MedewerkerToevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
