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
    public partial class MedewerkerAanpassen : Form
    {
        private TextBox tb_Wachtwoord;
        private Label lb_Wachtwoord;
        private Button btn_Annuleren;
        private Button btn_Aanpassen;
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
        private Label lb_MedewerkerAanpassen;
        private Button btn_Zoeken;

        public MedewerkerAanpassen()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.tb_Wachtwoord = new System.Windows.Forms.TextBox();
            this.lb_Wachtwoord = new System.Windows.Forms.Label();
            this.btn_Annuleren = new System.Windows.Forms.Button();
            this.btn_Aanpassen = new System.Windows.Forms.Button();
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
            this.lb_MedewerkerAanpassen = new System.Windows.Forms.Label();
            this.btn_Zoeken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Wachtwoord
            // 
            this.tb_Wachtwoord.Location = new System.Drawing.Point(172, 265);
            this.tb_Wachtwoord.Name = "tb_Wachtwoord";
            this.tb_Wachtwoord.Size = new System.Drawing.Size(118, 20);
            this.tb_Wachtwoord.TabIndex = 56;
            // 
            // lb_Wachtwoord
            // 
            this.lb_Wachtwoord.AutoSize = true;
            this.lb_Wachtwoord.Location = new System.Drawing.Point(43, 268);
            this.lb_Wachtwoord.Name = "lb_Wachtwoord";
            this.lb_Wachtwoord.Size = new System.Drawing.Size(71, 13);
            this.lb_Wachtwoord.TabIndex = 55;
            this.lb_Wachtwoord.Text = "Wachtwoord:";
            // 
            // btn_Annuleren
            // 
            this.btn_Annuleren.Location = new System.Drawing.Point(240, 313);
            this.btn_Annuleren.Name = "btn_Annuleren";
            this.btn_Annuleren.Size = new System.Drawing.Size(75, 23);
            this.btn_Annuleren.TabIndex = 54;
            this.btn_Annuleren.Text = "Annuleren";
            this.btn_Annuleren.UseVisualStyleBackColor = true;
            // 
            // btn_Aanpassen
            // 
            this.btn_Aanpassen.Location = new System.Drawing.Point(130, 313);
            this.btn_Aanpassen.Name = "btn_Aanpassen";
            this.btn_Aanpassen.Size = new System.Drawing.Size(75, 23);
            this.btn_Aanpassen.TabIndex = 53;
            this.btn_Aanpassen.Text = "Toevoegen";
            this.btn_Aanpassen.UseVisualStyleBackColor = true;
            // 
            // tb_Telefoonnummer
            // 
            this.tb_Telefoonnummer.Location = new System.Drawing.Point(172, 187);
            this.tb_Telefoonnummer.Name = "tb_Telefoonnummer";
            this.tb_Telefoonnummer.Size = new System.Drawing.Size(118, 20);
            this.tb_Telefoonnummer.TabIndex = 52;
            // 
            // tb_Functie
            // 
            this.tb_Functie.Location = new System.Drawing.Point(172, 111);
            this.tb_Functie.Name = "tb_Functie";
            this.tb_Functie.Size = new System.Drawing.Size(118, 20);
            this.tb_Functie.TabIndex = 51;
            // 
            // tb_Adres
            // 
            this.tb_Adres.Location = new System.Drawing.Point(172, 151);
            this.tb_Adres.Name = "tb_Adres";
            this.tb_Adres.Size = new System.Drawing.Size(118, 20);
            this.tb_Adres.TabIndex = 50;
            // 
            // tb_Gebruikersnaam
            // 
            this.tb_Gebruikersnaam.Location = new System.Drawing.Point(172, 228);
            this.tb_Gebruikersnaam.Name = "tb_Gebruikersnaam";
            this.tb_Gebruikersnaam.Size = new System.Drawing.Size(118, 20);
            this.tb_Gebruikersnaam.TabIndex = 49;
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Location = new System.Drawing.Point(382, 19);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(75, 23);
            this.btn_Uitloggen.TabIndex = 48;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            // 
            // tb_NaamMedewerker
            // 
            this.tb_NaamMedewerker.Location = new System.Drawing.Point(172, 78);
            this.tb_NaamMedewerker.Name = "tb_NaamMedewerker";
            this.tb_NaamMedewerker.Size = new System.Drawing.Size(118, 20);
            this.tb_NaamMedewerker.TabIndex = 47;
            // 
            // lb_Gebruikersnaam
            // 
            this.lb_Gebruikersnaam.AutoSize = true;
            this.lb_Gebruikersnaam.Location = new System.Drawing.Point(41, 231);
            this.lb_Gebruikersnaam.Name = "lb_Gebruikersnaam";
            this.lb_Gebruikersnaam.Size = new System.Drawing.Size(87, 13);
            this.lb_Gebruikersnaam.TabIndex = 46;
            this.lb_Gebruikersnaam.Text = "Gebruikersnaam:";
            // 
            // lb_Telefoonnummer
            // 
            this.lb_Telefoonnummer.AutoSize = true;
            this.lb_Telefoonnummer.Location = new System.Drawing.Point(41, 194);
            this.lb_Telefoonnummer.Name = "lb_Telefoonnummer";
            this.lb_Telefoonnummer.Size = new System.Drawing.Size(89, 13);
            this.lb_Telefoonnummer.TabIndex = 45;
            this.lb_Telefoonnummer.Text = "Telefoonnummer:";
            // 
            // lb_Adres
            // 
            this.lb_Adres.AutoSize = true;
            this.lb_Adres.Location = new System.Drawing.Point(41, 151);
            this.lb_Adres.Name = "lb_Adres";
            this.lb_Adres.Size = new System.Drawing.Size(37, 13);
            this.lb_Adres.TabIndex = 44;
            this.lb_Adres.Text = "Adres:";
            // 
            // lb_Functie
            // 
            this.lb_Functie.AutoSize = true;
            this.lb_Functie.Location = new System.Drawing.Point(41, 114);
            this.lb_Functie.Name = "lb_Functie";
            this.lb_Functie.Size = new System.Drawing.Size(45, 13);
            this.lb_Functie.TabIndex = 43;
            this.lb_Functie.Text = "Functie:";
            // 
            // lb_NaamMedewerker
            // 
            this.lb_NaamMedewerker.AutoSize = true;
            this.lb_NaamMedewerker.Location = new System.Drawing.Point(41, 78);
            this.lb_NaamMedewerker.Name = "lb_NaamMedewerker";
            this.lb_NaamMedewerker.Size = new System.Drawing.Size(99, 13);
            this.lb_NaamMedewerker.TabIndex = 42;
            this.lb_NaamMedewerker.Text = "Naam medewerker:";
            // 
            // lb_MedewerkerAanpassen
            // 
            this.lb_MedewerkerAanpassen.AutoSize = true;
            this.lb_MedewerkerAanpassen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MedewerkerAanpassen.Location = new System.Drawing.Point(36, 19);
            this.lb_MedewerkerAanpassen.Name = "lb_MedewerkerAanpassen";
            this.lb_MedewerkerAanpassen.Size = new System.Drawing.Size(242, 25);
            this.lb_MedewerkerAanpassen.TabIndex = 41;
            this.lb_MedewerkerAanpassen.Text = "Medewerker aanpassen";
            // 
            // btn_Zoeken
            // 
            this.btn_Zoeken.Location = new System.Drawing.Point(310, 78);
            this.btn_Zoeken.Name = "btn_Zoeken";
            this.btn_Zoeken.Size = new System.Drawing.Size(75, 23);
            this.btn_Zoeken.TabIndex = 57;
            this.btn_Zoeken.Text = "Zoeken";
            this.btn_Zoeken.UseVisualStyleBackColor = true;
            // 
            // MedewerkerAanpassen
            // 
            this.ClientSize = new System.Drawing.Size(482, 472);
            this.Controls.Add(this.btn_Zoeken);
            this.Controls.Add(this.tb_Wachtwoord);
            this.Controls.Add(this.lb_Wachtwoord);
            this.Controls.Add(this.btn_Annuleren);
            this.Controls.Add(this.btn_Aanpassen);
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
            this.Controls.Add(this.lb_MedewerkerAanpassen);
            this.Name = "MedewerkerAanpassen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
