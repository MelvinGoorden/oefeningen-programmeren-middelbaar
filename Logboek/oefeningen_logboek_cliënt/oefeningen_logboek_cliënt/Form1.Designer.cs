namespace oefeningen_logboek_cliënt
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
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Tb_uren = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_Port = new System.Windows.Forms.TextBox();
            this.Tb_IP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_uren = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "uren : ";
            // 
            // Tb_uren
            // 
            this.Tb_uren.Location = new System.Drawing.Point(96, 146);
            this.Tb_uren.Name = "Tb_uren";
            this.Tb_uren.Size = new System.Drawing.Size(107, 22);
            this.Tb_uren.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 36);
            this.label3.TabIndex = 15;
            this.label3.Text = "Logboek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Server Port :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Server IP :";
            // 
            // Tb_Port
            // 
            this.Tb_Port.Location = new System.Drawing.Point(97, 92);
            this.Tb_Port.Name = "Tb_Port";
            this.Tb_Port.Size = new System.Drawing.Size(135, 22);
            this.Tb_Port.TabIndex = 11;
            // 
            // Tb_IP
            // 
            this.Tb_IP.Location = new System.Drawing.Point(97, 64);
            this.Tb_IP.Name = "Tb_IP";
            this.Tb_IP.Size = new System.Drawing.Size(135, 22);
            this.Tb_IP.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Totaal aantal uur:";
            // 
            // Lbl_uren
            // 
            this.Lbl_uren.AutoSize = true;
            this.Lbl_uren.Location = new System.Drawing.Point(129, 191);
            this.Lbl_uren.Name = "Lbl_uren";
            this.Lbl_uren.Size = new System.Drawing.Size(32, 17);
            this.Lbl_uren.TabIndex = 21;
            this.Lbl_uren.Text = "000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 366);
            this.Controls.Add(this.Lbl_uren);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tb_uren);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_Port);
            this.Controls.Add(this.Tb_IP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tb_uren;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_Port;
        private System.Windows.Forms.TextBox Tb_IP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_uren;
    }
}

