namespace Smart_Deur_App
{
    partial class MenuPasMaken
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
            this.btn_Uitloggen = new System.Windows.Forms.Button();
            this.btn_Annuleren = new System.Windows.Forms.Button();
            this.btn_BezoekerPas = new System.Windows.Forms.Button();
            this.btn_MedewerkerPas = new System.Windows.Forms.Button();
            this.lb_PasMaken = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Location = new System.Drawing.Point(310, 6);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(124, 23);
            this.btn_Uitloggen.TabIndex = 9;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            // 
            // btn_Annuleren
            // 
            this.btn_Annuleren.Location = new System.Drawing.Point(103, 172);
            this.btn_Annuleren.Name = "btn_Annuleren";
            this.btn_Annuleren.Size = new System.Drawing.Size(124, 23);
            this.btn_Annuleren.TabIndex = 8;
            this.btn_Annuleren.Text = "Annuleren";
            this.btn_Annuleren.UseVisualStyleBackColor = true;
            // 
            // btn_BezoekerPas
            // 
            this.btn_BezoekerPas.Location = new System.Drawing.Point(183, 105);
            this.btn_BezoekerPas.Name = "btn_BezoekerPas";
            this.btn_BezoekerPas.Size = new System.Drawing.Size(124, 23);
            this.btn_BezoekerPas.TabIndex = 7;
            this.btn_BezoekerPas.Text = "Bezoeker";
            this.btn_BezoekerPas.UseVisualStyleBackColor = true;
            // 
            // btn_MedewerkerPas
            // 
            this.btn_MedewerkerPas.Location = new System.Drawing.Point(17, 105);
            this.btn_MedewerkerPas.Name = "btn_MedewerkerPas";
            this.btn_MedewerkerPas.Size = new System.Drawing.Size(124, 23);
            this.btn_MedewerkerPas.TabIndex = 6;
            this.btn_MedewerkerPas.Text = "Medewerker";
            this.btn_MedewerkerPas.UseVisualStyleBackColor = true;
            // 
            // lb_PasMaken
            // 
            this.lb_PasMaken.AutoSize = true;
            this.lb_PasMaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PasMaken.Location = new System.Drawing.Point(12, 24);
            this.lb_PasMaken.Name = "lb_PasMaken";
            this.lb_PasMaken.Size = new System.Drawing.Size(119, 25);
            this.lb_PasMaken.TabIndex = 5;
            this.lb_PasMaken.Text = "Pas maken";
            // 
            // MenuPasMaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 218);
            this.Controls.Add(this.btn_Uitloggen);
            this.Controls.Add(this.btn_Annuleren);
            this.Controls.Add(this.btn_BezoekerPas);
            this.Controls.Add(this.btn_MedewerkerPas);
            this.Controls.Add(this.lb_PasMaken);
            this.Name = "MenuPasMaken";
            this.Text = "MenuPasMaken";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Uitloggen;
        private System.Windows.Forms.Button btn_Annuleren;
        private System.Windows.Forms.Button btn_BezoekerPas;
        private System.Windows.Forms.Button btn_MedewerkerPas;
        private System.Windows.Forms.Label lb_PasMaken;
    }
}