namespace Oefeningen_04._22_Pythagoras
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tb_uitkomst = new System.Windows.Forms.TextBox();
            this.Tb_GetalA = new System.Windows.Forms.TextBox();
            this.Tb_GetalB = new System.Windows.Forms.TextBox();
            this.Btn_Berekenen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welkom bij de stelling van pythagoras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "a = ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "b = ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "berekening:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Tb_uitkomst
            // 
            this.Tb_uitkomst.Location = new System.Drawing.Point(73, 250);
            this.Tb_uitkomst.Multiline = true;
            this.Tb_uitkomst.Name = "Tb_uitkomst";
            this.Tb_uitkomst.Size = new System.Drawing.Size(257, 91);
            this.Tb_uitkomst.TabIndex = 4;
            this.Tb_uitkomst.TextChanged += new System.EventHandler(this.Tb_uitkomst_TextChanged);
            // 
            // Tb_GetalA
            // 
            this.Tb_GetalA.Location = new System.Drawing.Point(110, 137);
            this.Tb_GetalA.Name = "Tb_GetalA";
            this.Tb_GetalA.Size = new System.Drawing.Size(100, 22);
            this.Tb_GetalA.TabIndex = 5;
            this.Tb_GetalA.TextChanged += new System.EventHandler(this.Tb_GetalA_TextChanged);
            // 
            // Tb_GetalB
            // 
            this.Tb_GetalB.Location = new System.Drawing.Point(110, 170);
            this.Tb_GetalB.Name = "Tb_GetalB";
            this.Tb_GetalB.Size = new System.Drawing.Size(100, 22);
            this.Tb_GetalB.TabIndex = 6;
            this.Tb_GetalB.TextChanged += new System.EventHandler(this.Tb_GetalB_TextChanged);
            // 
            // Btn_Berekenen
            // 
            this.Btn_Berekenen.Location = new System.Drawing.Point(257, 137);
            this.Btn_Berekenen.Name = "Btn_Berekenen";
            this.Btn_Berekenen.Size = new System.Drawing.Size(75, 23);
            this.Btn_Berekenen.TabIndex = 7;
            this.Btn_Berekenen.Text = "Berekenen";
            this.Btn_Berekenen.UseVisualStyleBackColor = true;
            this.Btn_Berekenen.Click += new System.EventHandler(this.Btn_Berekenen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 404);
            this.Controls.Add(this.Btn_Berekenen);
            this.Controls.Add(this.Tb_GetalB);
            this.Controls.Add(this.Tb_GetalA);
            this.Controls.Add(this.Tb_uitkomst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tb_uitkomst;
        private System.Windows.Forms.TextBox Tb_GetalA;
        private System.Windows.Forms.TextBox Tb_GetalB;
        private System.Windows.Forms.Button Btn_Berekenen;
    }
}

