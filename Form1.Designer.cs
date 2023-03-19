namespace hesapmakinesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtsayı1 = new System.Windows.Forms.TextBox();
            this.txtsayı2 = new System.Windows.Forms.TextBox();
            this.btnartı = new System.Windows.Forms.Button();
            this.btneksi = new System.Windows.Forms.Button();
            this.btnbölü = new System.Windows.Forms.Button();
            this.btnçarpma = new System.Windows.Forms.Button();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsayı1
            // 
            this.txtsayı1.Location = new System.Drawing.Point(54, 39);
            this.txtsayı1.Name = "txtsayı1";
            this.txtsayı1.Size = new System.Drawing.Size(453, 23);
            this.txtsayı1.TabIndex = 0;
            this.txtsayı1.TextChanged += new System.EventHandler(this.txtsayı1_TextChanged);
            // 
            // txtsayı2
            // 
            this.txtsayı2.Location = new System.Drawing.Point(54, 94);
            this.txtsayı2.Name = "txtsayı2";
            this.txtsayı2.Size = new System.Drawing.Size(453, 23);
            this.txtsayı2.TabIndex = 1;
            this.txtsayı2.TextChanged += new System.EventHandler(this.txtsayı2_TextChanged);
            // 
            // btnartı
            // 
            this.btnartı.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnartı.Location = new System.Drawing.Point(54, 172);
            this.btnartı.Name = "btnartı";
            this.btnartı.Size = new System.Drawing.Size(87, 35);
            this.btnartı.TabIndex = 2;
            this.btnartı.Text = "+";
            this.btnartı.UseVisualStyleBackColor = true;
            this.btnartı.Click += new System.EventHandler(this.btnartı_Click);
            // 
            // btneksi
            // 
            this.btneksi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btneksi.Location = new System.Drawing.Point(181, 172);
            this.btneksi.Name = "btneksi";
            this.btneksi.Size = new System.Drawing.Size(75, 35);
            this.btneksi.TabIndex = 3;
            this.btneksi.Text = "-";
            this.btneksi.UseVisualStyleBackColor = true;
            this.btneksi.Click += new System.EventHandler(this.btneksi_Click);
            // 
            // btnbölü
            // 
            this.btnbölü.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbölü.Location = new System.Drawing.Point(319, 172);
            this.btnbölü.Name = "btnbölü";
            this.btnbölü.Size = new System.Drawing.Size(76, 35);
            this.btnbölü.TabIndex = 4;
            this.btnbölü.Text = "/";
            this.btnbölü.UseVisualStyleBackColor = true;
            this.btnbölü.Click += new System.EventHandler(this.btnbölü_Click);
            // 
            // btnçarpma
            // 
            this.btnçarpma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnçarpma.Location = new System.Drawing.Point(432, 172);
            this.btnçarpma.Name = "btnçarpma";
            this.btnçarpma.Size = new System.Drawing.Size(75, 35);
            this.btnçarpma.TabIndex = 5;
            this.btnçarpma.Text = "*";
            this.btnçarpma.UseVisualStyleBackColor = true;
            this.btnçarpma.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblsonuc
            // 
            this.lblsonuc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsonuc.Location = new System.Drawing.Point(384, 257);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(123, 25);
            this.lblsonuc.TabIndex = 6;
            this.lblsonuc.Text = "0";
            this.lblsonuc.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblsonuc.Click += new System.EventHandler(this.lblsonuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.btnçarpma);
            this.Controls.Add(this.btnbölü);
            this.Controls.Add(this.btneksi);
            this.Controls.Add(this.btnartı);
            this.Controls.Add(this.txtsayı2);
            this.Controls.Add(this.txtsayı1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtsayı1;
        private TextBox txtsayı2;
        private Button btnartı;
        private Button btneksi;
        private Button btnbölü;
        private Button btnçarpma;
        private Label lblsonuc;
    }
}