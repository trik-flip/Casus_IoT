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
    public partial class MedewerkersPasMaken : Form
    {
        private Label lb_PasMaken;
        private Label lb_NaamMedewerker;
        private Label lb_Functie;
        private Label lb_Adres;
        private Label lb_Telefoonnummer;
        private Label lb_Kamernummers;
        private Label lb_ScanBarcode;
        private TextBox tb_NaamMedewerker;
        private Button btn_Uitloggen;
        private TextBox tb_Kamernummers;
        private TextBox tb_Adres;
        private TextBox tb_Functie;
        private TextBox tb_Telefoonnummer;
        private Button btn_NaamZoeken;
        private Button btn_KamerToevoegen;
        private Button btn_ScanBarcode;
        private Button btn_Aanmaken;
        private Button btn_Annuleren;
        private PictureBox pb_Barcode;

        public MedewerkersPasMaken()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lb_PasMaken = new System.Windows.Forms.Label();
            this.lb_NaamMedewerker = new System.Windows.Forms.Label();
            this.lb_Functie = new System.Windows.Forms.Label();
            this.lb_Adres = new System.Windows.Forms.Label();
            this.lb_Telefoonnummer = new System.Windows.Forms.Label();
            this.lb_Kamernummers = new System.Windows.Forms.Label();
            this.lb_ScanBarcode = new System.Windows.Forms.Label();
            this.tb_NaamMedewerker = new System.Windows.Forms.TextBox();
            this.btn_Uitloggen = new System.Windows.Forms.Button();
            this.tb_Kamernummers = new System.Windows.Forms.TextBox();
            this.tb_Adres = new System.Windows.Forms.TextBox();
            this.tb_Functie = new System.Windows.Forms.TextBox();
            this.tb_Telefoonnummer = new System.Windows.Forms.TextBox();
            this.btn_NaamZoeken = new System.Windows.Forms.Button();
            this.btn_KamerToevoegen = new System.Windows.Forms.Button();
            this.btn_ScanBarcode = new System.Windows.Forms.Button();
            this.btn_Aanmaken = new System.Windows.Forms.Button();
            this.btn_Annuleren = new System.Windows.Forms.Button();
            this.pb_Barcode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Barcode)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_PasMaken
            // 
            this.lb_PasMaken.AutoSize = true;
            this.lb_PasMaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PasMaken.Location = new System.Drawing.Point(80, 25);
            this.lb_PasMaken.Name = "lb_PasMaken";
            this.lb_PasMaken.Size = new System.Drawing.Size(246, 25);
            this.lb_PasMaken.TabIndex = 1;
            this.lb_PasMaken.Text = "Medewerkerspas maken";
            // 
            // lb_NaamMedewerker
            // 
            this.lb_NaamMedewerker.AutoSize = true;
            this.lb_NaamMedewerker.Location = new System.Drawing.Point(85, 84);
            this.lb_NaamMedewerker.Name = "lb_NaamMedewerker";
            this.lb_NaamMedewerker.Size = new System.Drawing.Size(99, 13);
            this.lb_NaamMedewerker.TabIndex = 2;
            this.lb_NaamMedewerker.Text = "Naam medewerker:";
            // 
            // lb_Functie
            // 
            this.lb_Functie.AutoSize = true;
            this.lb_Functie.Location = new System.Drawing.Point(85, 120);
            this.lb_Functie.Name = "lb_Functie";
            this.lb_Functie.Size = new System.Drawing.Size(45, 13);
            this.lb_Functie.TabIndex = 3;
            this.lb_Functie.Text = "Functie:";
            // 
            // lb_Adres
            // 
            this.lb_Adres.AutoSize = true;
            this.lb_Adres.Location = new System.Drawing.Point(85, 157);
            this.lb_Adres.Name = "lb_Adres";
            this.lb_Adres.Size = new System.Drawing.Size(37, 13);
            this.lb_Adres.TabIndex = 4;
            this.lb_Adres.Text = "Adres:";
            // 
            // lb_Telefoonnummer
            // 
            this.lb_Telefoonnummer.AutoSize = true;
            this.lb_Telefoonnummer.Location = new System.Drawing.Point(85, 200);
            this.lb_Telefoonnummer.Name = "lb_Telefoonnummer";
            this.lb_Telefoonnummer.Size = new System.Drawing.Size(89, 13);
            this.lb_Telefoonnummer.TabIndex = 5;
            this.lb_Telefoonnummer.Text = "Telefoonnummer:";
            // 
            // lb_Kamernummers
            // 
            this.lb_Kamernummers.AutoSize = true;
            this.lb_Kamernummers.Location = new System.Drawing.Point(85, 237);
            this.lb_Kamernummers.Name = "lb_Kamernummers";
            this.lb_Kamernummers.Size = new System.Drawing.Size(82, 13);
            this.lb_Kamernummers.TabIndex = 6;
            this.lb_Kamernummers.Text = "Kamernummers:";
            // 
            // lb_ScanBarcode
            // 
            this.lb_ScanBarcode.AutoSize = true;
            this.lb_ScanBarcode.Location = new System.Drawing.Point(85, 275);
            this.lb_ScanBarcode.Name = "lb_ScanBarcode";
            this.lb_ScanBarcode.Size = new System.Drawing.Size(77, 13);
            this.lb_ScanBarcode.TabIndex = 7;
            this.lb_ScanBarcode.Text = "Scan barcode:";
            // 
            // tb_NaamMedewerker
            // 
            this.tb_NaamMedewerker.Location = new System.Drawing.Point(216, 84);
            this.tb_NaamMedewerker.Name = "tb_NaamMedewerker";
            this.tb_NaamMedewerker.Size = new System.Drawing.Size(118, 20);
            this.tb_NaamMedewerker.TabIndex = 8;
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Location = new System.Drawing.Point(426, 25);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(75, 23);
            this.btn_Uitloggen.TabIndex = 9;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            // 
            // tb_Kamernummers
            // 
            this.tb_Kamernummers.Location = new System.Drawing.Point(216, 234);
            this.tb_Kamernummers.Name = "tb_Kamernummers";
            this.tb_Kamernummers.Size = new System.Drawing.Size(118, 20);
            this.tb_Kamernummers.TabIndex = 10;
            // 
            // tb_Adres
            // 
            this.tb_Adres.Location = new System.Drawing.Point(216, 157);
            this.tb_Adres.Name = "tb_Adres";
            this.tb_Adres.Size = new System.Drawing.Size(118, 20);
            this.tb_Adres.TabIndex = 12;
            // 
            // tb_Functie
            // 
            this.tb_Functie.Location = new System.Drawing.Point(216, 117);
            this.tb_Functie.Name = "tb_Functie";
            this.tb_Functie.Size = new System.Drawing.Size(118, 20);
            this.tb_Functie.TabIndex = 13;
            // 
            // tb_Telefoonnummer
            // 
            this.tb_Telefoonnummer.Location = new System.Drawing.Point(216, 193);
            this.tb_Telefoonnummer.Name = "tb_Telefoonnummer";
            this.tb_Telefoonnummer.Size = new System.Drawing.Size(118, 20);
            this.tb_Telefoonnummer.TabIndex = 14;
            // 
            // btn_NaamZoeken
            // 
            this.btn_NaamZoeken.Location = new System.Drawing.Point(357, 84);
            this.btn_NaamZoeken.Name = "btn_NaamZoeken";
            this.btn_NaamZoeken.Size = new System.Drawing.Size(75, 23);
            this.btn_NaamZoeken.TabIndex = 15;
            this.btn_NaamZoeken.Text = "Zoeken";
            this.btn_NaamZoeken.UseVisualStyleBackColor = true;
            // 
            // btn_KamerToevoegen
            // 
            this.btn_KamerToevoegen.Location = new System.Drawing.Point(357, 232);
            this.btn_KamerToevoegen.Name = "btn_KamerToevoegen";
            this.btn_KamerToevoegen.Size = new System.Drawing.Size(127, 23);
            this.btn_KamerToevoegen.TabIndex = 16;
            this.btn_KamerToevoegen.Text = "Nog een toevoegen";
            this.btn_KamerToevoegen.UseVisualStyleBackColor = true;
            // 
            // btn_ScanBarcode
            // 
            this.btn_ScanBarcode.Location = new System.Drawing.Point(357, 275);
            this.btn_ScanBarcode.Name = "btn_ScanBarcode";
            this.btn_ScanBarcode.Size = new System.Drawing.Size(75, 23);
            this.btn_ScanBarcode.TabIndex = 17;
            this.btn_ScanBarcode.Text = "Scan";
            this.btn_ScanBarcode.UseVisualStyleBackColor = true;
            // 
            // btn_Aanmaken
            // 
            this.btn_Aanmaken.Location = new System.Drawing.Point(185, 346);
            this.btn_Aanmaken.Name = "btn_Aanmaken";
            this.btn_Aanmaken.Size = new System.Drawing.Size(75, 23);
            this.btn_Aanmaken.TabIndex = 18;
            this.btn_Aanmaken.Text = "Aanmaken";
            this.btn_Aanmaken.UseVisualStyleBackColor = true;
            // 
            // btn_Annuleren
            // 
            this.btn_Annuleren.Location = new System.Drawing.Point(300, 346);
            this.btn_Annuleren.Name = "btn_Annuleren";
            this.btn_Annuleren.Size = new System.Drawing.Size(75, 23);
            this.btn_Annuleren.TabIndex = 19;
            this.btn_Annuleren.Text = "Annuleren";
            this.btn_Annuleren.UseVisualStyleBackColor = true;
            // 
            // pb_Barcode
            // 
            this.pb_Barcode.Location = new System.Drawing.Point(216, 275);
            this.pb_Barcode.Name = "pb_Barcode";
            this.pb_Barcode.Size = new System.Drawing.Size(118, 50);
            this.pb_Barcode.TabIndex = 20;
            this.pb_Barcode.TabStop = false;
            // 
            // MedewerkersPasMaken
            // 
            this.ClientSize = new System.Drawing.Size(518, 459);
            this.Controls.Add(this.pb_Barcode);
            this.Controls.Add(this.btn_Annuleren);
            this.Controls.Add(this.btn_Aanmaken);
            this.Controls.Add(this.btn_ScanBarcode);
            this.Controls.Add(this.btn_KamerToevoegen);
            this.Controls.Add(this.btn_NaamZoeken);
            this.Controls.Add(this.tb_Telefoonnummer);
            this.Controls.Add(this.tb_Functie);
            this.Controls.Add(this.tb_Adres);
            this.Controls.Add(this.tb_Kamernummers);
            this.Controls.Add(this.btn_Uitloggen);
            this.Controls.Add(this.tb_NaamMedewerker);
            this.Controls.Add(this.lb_ScanBarcode);
            this.Controls.Add(this.lb_Kamernummers);
            this.Controls.Add(this.lb_Telefoonnummer);
            this.Controls.Add(this.lb_Adres);
            this.Controls.Add(this.lb_Functie);
            this.Controls.Add(this.lb_NaamMedewerker);
            this.Controls.Add(this.lb_PasMaken);
            this.Name = "MedewerkersPasMaken";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Barcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
