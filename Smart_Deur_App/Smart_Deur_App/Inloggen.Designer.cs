namespace Smart_Deur_App
{
    partial class Inloggen
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
            if(disposing && (components != null))
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
            this.btn_Inloggen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Inloggen
            // 
            this.btn_Inloggen.Location = new System.Drawing.Point(211, 203);
            this.btn_Inloggen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Inloggen.Name = "btn_Inloggen";
            this.btn_Inloggen.Size = new System.Drawing.Size(95, 24);
            this.btn_Inloggen.TabIndex = 0;
            this.btn_Inloggen.Text = "Inloggen";
            this.btn_Inloggen.UseVisualStyleBackColor = true;
            // 
            // Inloggen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_Inloggen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inloggen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inloggen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Inloggen;
    }
}

