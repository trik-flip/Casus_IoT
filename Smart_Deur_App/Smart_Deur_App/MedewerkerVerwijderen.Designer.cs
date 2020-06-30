namespace Smart_Deur_App
{
    partial class MedewerkerVerwijderen
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
            this.tb_Functie = new System.Windows.Forms.TextBox();
            this.btn_Annuleren = new System.Windows.Forms.Button();
            this.btn_Verwijderen = new System.Windows.Forms.Button();
            this.btn_NaamZoeken = new System.Windows.Forms.Button();
            this.btn_Uitloggen = new System.Windows.Forms.Button();
            this.tb_NaamMedewerker = new System.Windows.Forms.TextBox();
            this.lb_Functie = new System.Windows.Forms.Label();
            this.lb_NaamMedewerker = new System.Windows.Forms.Label();
            this.lb_MedewerkerVerwijderen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Functie
            // 
            this.tb_Functie.Location = new System.Drawing.Point(148, 106);
            this.tb_Functie.Name = "tb_Functie";
            this.tb_Functie.Size = new System.Drawing.Size(118, 20);
            this.tb_Functie.TabIndex = 77;
            // 
            // btn_Annuleren
            // 
            this.btn_Annuleren.Location = new System.Drawing.Point(229, 201);
            this.btn_Annuleren.Name = "btn_Annuleren";
            this.btn_Annuleren.Size = new System.Drawing.Size(75, 23);
            this.btn_Annuleren.TabIndex = 76;
            this.btn_Annuleren.Text = "Annuleren";
            this.btn_Annuleren.UseVisualStyleBackColor = true;
            this.btn_Annuleren.Click += new System.EventHandler(this.btn_Annuleren_Click);
            // 
            // btn_Verwijderen
            // 
            this.btn_Verwijderen.Location = new System.Drawing.Point(99, 201);
            this.btn_Verwijderen.Name = "btn_Verwijderen";
            this.btn_Verwijderen.Size = new System.Drawing.Size(75, 23);
            this.btn_Verwijderen.TabIndex = 75;
            this.btn_Verwijderen.Text = "Verwijderen";
            this.btn_Verwijderen.UseVisualStyleBackColor = true;
            this.btn_Verwijderen.Click += new System.EventHandler(this.btn_Verwijderen_Click);
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
            // lb_Functie
            // 
            this.lb_Functie.AutoSize = true;
            this.lb_Functie.Location = new System.Drawing.Point(17, 109);
            this.lb_Functie.Name = "lb_Functie";
            this.lb_Functie.Size = new System.Drawing.Size(45, 13);
            this.lb_Functie.TabIndex = 71;
            this.lb_Functie.Text = "Functie:";
            // 
            // lb_NaamMedewerker
            // 
            this.lb_NaamMedewerker.AutoSize = true;
            this.lb_NaamMedewerker.Location = new System.Drawing.Point(17, 68);
            this.lb_NaamMedewerker.Name = "lb_NaamMedewerker";
            this.lb_NaamMedewerker.Size = new System.Drawing.Size(99, 13);
            this.lb_NaamMedewerker.TabIndex = 70;
            this.lb_NaamMedewerker.Text = "Naam medewerker:";
            // 
            // lb_MedewerkerVerwijderen
            // 
            this.lb_MedewerkerVerwijderen.AutoSize = true;
            this.lb_MedewerkerVerwijderen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MedewerkerVerwijderen.Location = new System.Drawing.Point(12, 9);
            this.lb_MedewerkerVerwijderen.Name = "lb_MedewerkerVerwijderen";
            this.lb_MedewerkerVerwijderen.Size = new System.Drawing.Size(246, 25);
            this.lb_MedewerkerVerwijderen.TabIndex = 69;
            this.lb_MedewerkerVerwijderen.Text = "Medewerker verwijderen";
            // 
            // MedewerkerVerwijderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 268);
            this.Controls.Add(this.tb_Functie);
            this.Controls.Add(this.btn_Annuleren);
            this.Controls.Add(this.btn_Verwijderen);
            this.Controls.Add(this.btn_NaamZoeken);
            this.Controls.Add(this.btn_Uitloggen);
            this.Controls.Add(this.tb_NaamMedewerker);
            this.Controls.Add(this.lb_Functie);
            this.Controls.Add(this.lb_NaamMedewerker);
            this.Controls.Add(this.lb_MedewerkerVerwijderen);
            this.Name = "MedewerkerVerwijderen";
            this.Text = "MedewerkerVerwijderen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MedewerkerVerwijderen_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Functie;
        private System.Windows.Forms.Button btn_Annuleren;
        private System.Windows.Forms.Button btn_Verwijderen;
        private System.Windows.Forms.Button btn_NaamZoeken;
        private System.Windows.Forms.Button btn_Uitloggen;
        private System.Windows.Forms.TextBox tb_NaamMedewerker;
        private System.Windows.Forms.Label lb_Functie;
        private System.Windows.Forms.Label lb_NaamMedewerker;
        private System.Windows.Forms.Label lb_MedewerkerVerwijderen;
    }
}