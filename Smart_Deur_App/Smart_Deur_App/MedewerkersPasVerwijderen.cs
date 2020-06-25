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
    public partial class MedewerkersPasVerwijderen : Form
    {
        private PictureBox pb_Barcode;
        private Button btn_Annuleren;
        private Button btn_Verwijderen;
        private Button btn_ScanBarcode;
        private Button btn_NaamZoeken;
        private Button btn_Uitloggen;
        private TextBox tb_NaamMedewerker;
        private Label lb_ScanBarcode;
        private Label lb_NaamMedewerker;
        private Label lb_PasVerwijderen;

        public MedewerkersPasVerwijderen()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pb_Barcode = new System.Windows.Forms.PictureBox();
            this.btn_Annuleren = new System.Windows.Forms.Button();
            this.btn_Verwijderen = new System.Windows.Forms.Button();
            this.btn_ScanBarcode = new System.Windows.Forms.Button();
            this.btn_NaamZoeken = new System.Windows.Forms.Button();
            this.btn_Uitloggen = new System.Windows.Forms.Button();
            this.tb_NaamMedewerker = new System.Windows.Forms.TextBox();
            this.lb_ScanBarcode = new System.Windows.Forms.Label();
            this.lb_NaamMedewerker = new System.Windows.Forms.Label();
            this.lb_PasVerwijderen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Barcode)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Barcode
            // 
            this.pb_Barcode.Location = new System.Drawing.Point(175, 144);
            this.pb_Barcode.Name = "pb_Barcode";
            this.pb_Barcode.Size = new System.Drawing.Size(118, 50);
            this.pb_Barcode.TabIndex = 58;
            this.pb_Barcode.TabStop = false;
            // 
            // btn_Annuleren
            // 
            this.btn_Annuleren.Location = new System.Drawing.Point(256, 222);
            this.btn_Annuleren.Name = "btn_Annuleren";
            this.btn_Annuleren.Size = new System.Drawing.Size(75, 23);
            this.btn_Annuleren.TabIndex = 57;
            this.btn_Annuleren.Text = "Annuleren";
            this.btn_Annuleren.UseVisualStyleBackColor = true;
            // 
            // btn_Verwijderen
            // 
            this.btn_Verwijderen.Location = new System.Drawing.Point(126, 222);
            this.btn_Verwijderen.Name = "btn_Verwijderen";
            this.btn_Verwijderen.Size = new System.Drawing.Size(75, 23);
            this.btn_Verwijderen.TabIndex = 56;
            this.btn_Verwijderen.Text = "Verwijderen";
            this.btn_Verwijderen.UseVisualStyleBackColor = true;
            // 
            // btn_ScanBarcode
            // 
            this.btn_ScanBarcode.Location = new System.Drawing.Point(316, 144);
            this.btn_ScanBarcode.Name = "btn_ScanBarcode";
            this.btn_ScanBarcode.Size = new System.Drawing.Size(75, 23);
            this.btn_ScanBarcode.TabIndex = 55;
            this.btn_ScanBarcode.Text = "Scan";
            this.btn_ScanBarcode.UseVisualStyleBackColor = true;
            // 
            // btn_NaamZoeken
            // 
            this.btn_NaamZoeken.Location = new System.Drawing.Point(316, 89);
            this.btn_NaamZoeken.Name = "btn_NaamZoeken";
            this.btn_NaamZoeken.Size = new System.Drawing.Size(75, 23);
            this.btn_NaamZoeken.TabIndex = 53;
            this.btn_NaamZoeken.Text = "Zoeken";
            this.btn_NaamZoeken.UseVisualStyleBackColor = true;
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Location = new System.Drawing.Point(385, 30);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(75, 23);
            this.btn_Uitloggen.TabIndex = 48;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            // 
            // tb_NaamMedewerker
            // 
            this.tb_NaamMedewerker.Location = new System.Drawing.Point(175, 89);
            this.tb_NaamMedewerker.Name = "tb_NaamMedewerker";
            this.tb_NaamMedewerker.Size = new System.Drawing.Size(118, 20);
            this.tb_NaamMedewerker.TabIndex = 47;
            // 
            // lb_ScanBarcode
            // 
            this.lb_ScanBarcode.AutoSize = true;
            this.lb_ScanBarcode.Location = new System.Drawing.Point(44, 144);
            this.lb_ScanBarcode.Name = "lb_ScanBarcode";
            this.lb_ScanBarcode.Size = new System.Drawing.Size(77, 13);
            this.lb_ScanBarcode.TabIndex = 46;
            this.lb_ScanBarcode.Text = "Scan barcode:";
            // 
            // lb_NaamMedewerker
            // 
            this.lb_NaamMedewerker.AutoSize = true;
            this.lb_NaamMedewerker.Location = new System.Drawing.Point(44, 89);
            this.lb_NaamMedewerker.Name = "lb_NaamMedewerker";
            this.lb_NaamMedewerker.Size = new System.Drawing.Size(99, 13);
            this.lb_NaamMedewerker.TabIndex = 41;
            this.lb_NaamMedewerker.Text = "Naam medewerker:";
            // 
            // lb_PasVerwijderen
            // 
            this.lb_PasVerwijderen.AutoSize = true;
            this.lb_PasVerwijderen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PasVerwijderen.Location = new System.Drawing.Point(39, 30);
            this.lb_PasVerwijderen.Name = "lb_PasVerwijderen";
            this.lb_PasVerwijderen.Size = new System.Drawing.Size(292, 25);
            this.lb_PasVerwijderen.TabIndex = 40;
            this.lb_PasVerwijderen.Text = "Medewerkerspas verwijderen";
            // 
            // MedewerkersPasVerwijderen
            // 
            this.ClientSize = new System.Drawing.Size(567, 532);
            this.Controls.Add(this.pb_Barcode);
            this.Controls.Add(this.btn_Annuleren);
            this.Controls.Add(this.btn_Verwijderen);
            this.Controls.Add(this.btn_ScanBarcode);
            this.Controls.Add(this.btn_NaamZoeken);
            this.Controls.Add(this.btn_Uitloggen);
            this.Controls.Add(this.tb_NaamMedewerker);
            this.Controls.Add(this.lb_ScanBarcode);
            this.Controls.Add(this.lb_NaamMedewerker);
            this.Controls.Add(this.lb_PasVerwijderen);
            this.Name = "MedewerkersPasVerwijderen";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Barcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
