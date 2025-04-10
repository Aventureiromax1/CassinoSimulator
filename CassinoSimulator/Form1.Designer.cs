namespace CassinoSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrSpin = new System.Windows.Forms.Timer(this.components);
            this.BtnSpin = new System.Windows.Forms.Button();
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.rtbLastests = new System.Windows.Forms.RichTextBox();
            this.cbWins = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tmrSpin
            // 
            this.tmrSpin.Tick += new System.EventHandler(this.tmrSpin_Tick);
            // 
            // BtnSpin
            // 
            this.BtnSpin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSpin.Location = new System.Drawing.Point(12, 259);
            this.BtnSpin.Name = "BtnSpin";
            this.BtnSpin.Size = new System.Drawing.Size(312, 87);
            this.BtnSpin.TabIndex = 0;
            this.BtnSpin.Text = "Girar";
            this.BtnSpin.UseVisualStyleBackColor = true;
            this.BtnSpin.Click += new System.EventHandler(this.BtnSpin_Click);
            // 
            // lblN1
            // 
            this.lblN1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN1.ForeColor = System.Drawing.Color.Black;
            this.lblN1.Location = new System.Drawing.Point(12, 84);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(100, 100);
            this.lblN1.TabIndex = 3;
            this.lblN1.Text = "0";
            this.lblN1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblN2
            // 
            this.lblN2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN2.ForeColor = System.Drawing.Color.Black;
            this.lblN2.Location = new System.Drawing.Point(118, 84);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(100, 100);
            this.lblN2.TabIndex = 4;
            this.lblN2.Text = "0";
            this.lblN2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblN3
            // 
            this.lblN3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN3.ForeColor = System.Drawing.Color.Black;
            this.lblN3.Location = new System.Drawing.Point(224, 84);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(100, 100);
            this.lblN3.TabIndex = 5;
            this.lblN3.Text = "0";
            this.lblN3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbLastests
            // 
            this.rtbLastests.Location = new System.Drawing.Point(118, 352);
            this.rtbLastests.Name = "rtbLastests";
            this.rtbLastests.Size = new System.Drawing.Size(100, 96);
            this.rtbLastests.TabIndex = 6;
            this.rtbLastests.Text = "";
            this.rtbLastests.TextChanged += new System.EventHandler(this.rtbLastests_TextChanged);
            // 
            // cbWins
            // 
            this.cbWins.AutoSize = true;
            this.cbWins.Location = new System.Drawing.Point(12, 377);
            this.cbWins.Name = "cbWins";
            this.cbWins.Size = new System.Drawing.Size(80, 17);
            this.cbWins.TabIndex = 7;
            this.cbWins.Text = "checkBox1";
            this.cbWins.UseVisualStyleBackColor = true;
            this.cbWins.CheckedChanged += new System.EventHandler(this.cbWins_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(336, 555);
            this.Controls.Add(this.cbWins);
            this.Controls.Add(this.rtbLastests);
            this.Controls.Add(this.lblN3);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.BtnSpin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrSpin;
        private System.Windows.Forms.Button BtnSpin;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.RichTextBox rtbLastests;
        private System.Windows.Forms.CheckBox cbWins;
    }
}

