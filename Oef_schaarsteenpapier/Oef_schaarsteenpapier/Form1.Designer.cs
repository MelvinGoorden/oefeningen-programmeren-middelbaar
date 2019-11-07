namespace Oef_schaarsteenpapier
{
    partial class Form1
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
            this.Btn_Enter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Cb_keuze = new System.Windows.Forms.ComboBox();
            this.lbl_resultaat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Enter
            // 
            this.Btn_Enter.Location = new System.Drawing.Point(228, 63);
            this.Btn_Enter.Name = "Btn_Enter";
            this.Btn_Enter.Size = new System.Drawing.Size(145, 46);
            this.Btn_Enter.TabIndex = 0;
            this.Btn_Enter.Text = "ENTER";
            this.Btn_Enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Schaar, Steen of Papier?";
            // 
            // Cb_keuze
            // 
            this.Cb_keuze.FormattingEnabled = true;
            this.Cb_keuze.Items.AddRange(new object[] {
            "Schaar",
            "Steen",
            "Papier"});
            this.Cb_keuze.Location = new System.Drawing.Point(28, 75);
            this.Cb_keuze.Name = "Cb_keuze";
            this.Cb_keuze.Size = new System.Drawing.Size(121, 24);
            this.Cb_keuze.TabIndex = 2;
            // 
            // lbl_resultaat
            // 
            this.lbl_resultaat.AutoSize = true;
            this.lbl_resultaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultaat.Location = new System.Drawing.Point(25, 164);
            this.lbl_resultaat.Name = "lbl_resultaat";
            this.lbl_resultaat.Size = new System.Drawing.Size(0, 29);
            this.lbl_resultaat.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 403);
            this.Controls.Add(this.lbl_resultaat);
            this.Controls.Add(this.Cb_keuze);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Enter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cb_keuze;
        private System.Windows.Forms.Label lbl_resultaat;
    }
}

