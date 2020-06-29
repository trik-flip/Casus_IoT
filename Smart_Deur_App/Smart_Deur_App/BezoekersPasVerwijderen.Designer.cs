namespace Smart_Deur_App
{
    partial class BezoekersPasVerwijderen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            this.lb_NaamOuder = new System.Windows.Forms.Label();
            this.lb_PasVerwijderen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Barcode)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Barcode
            // 
            this.pb_Barcode.Location = new System.Drawing.Point(148, 123);
            this.pb_Barcode.Name = "pb_Barcode";
            this.pb_Barcode.Size = new System.Drawing.Size(118, 50);
            this.pb_Barcode.TabIndex = 78;
            this.pb_Barcode.TabStop = false;
            // 
            // btn_Annuleren
            // 
            this.btn_Annuleren.Location = new System.Drawing.Point(229, 201);
            this.btn_Annuleren.Name = "btn_Annuleren";
            this.btn_Annuleren.Size = new System.Drawing.Size(75, 23);
            this.btn_Annuleren.TabIndex = 77;
            this.btn_Annuleren.Text = "Annuleren";
            this.btn_Annuleren.UseVisualStyleBackColor = true;
            this.btn_Annuleren.Click += new System.EventHandler(this.btn_Annuleren_Click);
            // 
            // btn_Verwijderen
            // 
            this.btn_Verwijderen.Location = new System.Drawing.Point(99, 201);
            this.btn_Verwijderen.Name = "btn_Verwijderen";
            this.btn_Verwijderen.Size = new System.Drawing.Size(75, 23);
            this.btn_Verwijderen.TabIndex = 76;
            this.btn_Verwijderen.Text = "Verwijderen";
            this.btn_Verwijderen.UseVisualStyleBackColor = true;
            this.btn_Verwijderen.Click += new System.EventHandler(this.btn_Verwijderen_Click);
            // 
            // btn_ScanBarcode
            // 
            this.btn_ScanBarcode.Location = new System.Drawing.Point(289, 123);
            this.btn_ScanBarcode.Name = "btn_ScanBarcode";
            this.btn_ScanBarcode.Size = new System.Drawing.Size(75, 23);
            this.btn_ScanBarcode.TabIndex = 75;
            this.btn_ScanBarcode.Text = "Scan";
            this.btn_ScanBarcode.UseVisualStyleBackColor = true;
            this.btn_ScanBarcode.Click += new System.EventHandler(this.btn_ScanBarcode_Click);
            // 
            // btn_NaamZoeken
            // 
            this.btn_NaamZoeken.Location = new System.Drawing.Point(289, 68);
            this.btn_NaamZoeken.Name = "btn_NaamZoeken";
            this.btn_NaamZoeken.Size = new System.Drawing.Size(75, 23);
            this.btn_NaamZoeken.TabIndex = 74;
            this.btn_NaamZoeken.Text = "Zoeken";
            this.btn_NaamZoeken.UseVisualStyleBackColor = true;
            this.btn_NaamZoeken.Click += new System.EventHandler(this.btn_NaamZoeken_Click);
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Location = new System.Drawing.Point(358, 9);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(75, 23);
            this.btn_Uitloggen.TabIndex = 73;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            this.btn_Uitloggen.Click += new System.EventHandler(this.btn_Uitloggen_Click);
            // 
            // tb_NaamMedewerker
            // 
            this.tb_NaamMedewerker.Location = new System.Drawing.Point(148, 68);
            this.tb_NaamMedewerker.Name = "tb_NaamMedewerker";
            this.tb_NaamMedewerker.Size = new System.Drawing.Size(118, 20);
            this.tb_NaamMedewerker.TabIndex = 72;
            // 
            // lb_ScanBarcode
            // 
            this.lb_ScanBarcode.AutoSize = true;
            this.lb_ScanBarcode.Location = new System.Drawing.Point(17, 123);
            this.lb_ScanBarcode.Name = "lb_ScanBarcode";
            this.lb_ScanBarcode.Size = new System.Drawing.Size(77, 13);
            this.lb_ScanBarcode.TabIndex = 71;
            this.lb_ScanBarcode.Text = "Scan barcode:";
            // 
            // lb_NaamOuder
            // 
            this.lb_NaamOuder.AutoSize = true;
            this.lb_NaamOuder.Location = new System.Drawing.Point(17, 68);
            this.lb_NaamOuder.Name = "lb_NaamOuder";
            this.lb_NaamOuder.Size = new System.Drawing.Size(71, 13);
            this.lb_NaamOuder.TabIndex = 70;
            this.lb_NaamOuder.Text = "Naam ouderr:";
            // 
            // lb_PasVerwijderen
            // 
            this.lb_PasVerwijderen.AutoSize = true;
            this.lb_PasVerwijderen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PasVerwijderen.Location = new System.Drawing.Point(12, 9);
            this.lb_PasVerwijderen.Name = "lb_PasVerwijderen";
            this.lb_PasVerwijderen.Size = new System.Drawing.Size(276, 25);
            this.lb_PasVerwijderen.TabIndex = 69;
            this.lb_PasVerwijderen.Text = "Bezoekersspas verwijderen";
            // 
            // BezoekersPasVerwijderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 443);
            this.Controls.Add(this.pb_Barcode);
            this.Controls.Add(this.btn_Annuleren);
            this.Controls.Add(this.btn_Verwijderen);
            this.Controls.Add(this.btn_ScanBarcode);
            this.Controls.Add(this.btn_NaamZoeken);
            this.Controls.Add(this.btn_Uitloggen);
            this.Controls.Add(this.tb_NaamMedewerker);
            this.Controls.Add(this.lb_ScanBarcode);
            this.Controls.Add(this.lb_NaamOuder);
            this.Controls.Add(this.lb_PasVerwijderen);
            this.Name = "BezoekersPasVerwijderen";
            this.Text = "BezoekersPasVerwijderen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BezoekersPasVerwijderen_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Barcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Barcode;
        private System.Windows.Forms.Button btn_Annuleren;
        private System.Windows.Forms.Button btn_Verwijderen;
        private System.Windows.Forms.Button btn_ScanBarcode;
        private System.Windows.Forms.Button btn_NaamZoeken;
        private System.Windows.Forms.Button btn_Uitloggen;
        private System.Windows.Forms.TextBox tb_NaamMedewerker;
        private System.Windows.Forms.Label lb_ScanBarcode;
        private System.Windows.Forms.Label lb_NaamOuder;
        private System.Windows.Forms.Label lb_PasVerwijderen;
    }
}