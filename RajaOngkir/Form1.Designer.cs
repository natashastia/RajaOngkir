namespace RajaOngkir
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAsal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbPos = new System.Windows.Forms.RadioButton();
            this.rbJne = new System.Windows.Forms.RadioButton();
            this.rbTiki = new System.Windows.Forms.RadioButton();
            this.tbBerat = new System.Windows.Forms.TextBox();
            this.tbTujuan = new System.Windows.Forms.TextBox();
            this.btnCheckHarga = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cek Harga Ongkir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kota / Kabupaten Asal";
            // 
            // tbAsal
            // 
            this.tbAsal.Location = new System.Drawing.Point(16, 79);
            this.tbAsal.Name = "tbAsal";
            this.tbAsal.Size = new System.Drawing.Size(190, 23);
            this.tbAsal.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kota / Kabupaten Tujuan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Berat (gram)";
            // 
            // rbPos
            // 
            this.rbPos.AutoSize = true;
            this.rbPos.Location = new System.Drawing.Point(33, 247);
            this.rbPos.Name = "rbPos";
            this.rbPos.Size = new System.Drawing.Size(47, 19);
            this.rbPos.TabIndex = 5;
            this.rbPos.TabStop = true;
            this.rbPos.Text = "POS";
            this.rbPos.UseVisualStyleBackColor = true;
            // 
            // rbJne
            // 
            this.rbJne.AutoSize = true;
            this.rbJne.Location = new System.Drawing.Point(86, 247);
            this.rbJne.Name = "rbJne";
            this.rbJne.Size = new System.Drawing.Size(44, 19);
            this.rbJne.TabIndex = 6;
            this.rbJne.TabStop = true;
            this.rbJne.Text = "JNE";
            this.rbJne.UseVisualStyleBackColor = true;
            // 
            // rbTiki
            // 
            this.rbTiki.AutoSize = true;
            this.rbTiki.Location = new System.Drawing.Point(136, 247);
            this.rbTiki.Name = "rbTiki";
            this.rbTiki.Size = new System.Drawing.Size(44, 19);
            this.rbTiki.TabIndex = 7;
            this.rbTiki.TabStop = true;
            this.rbTiki.Text = "TIKI";
            this.rbTiki.UseVisualStyleBackColor = true;
            // 
            // tbBerat
            // 
            this.tbBerat.Location = new System.Drawing.Point(16, 207);
            this.tbBerat.Name = "tbBerat";
            this.tbBerat.Size = new System.Drawing.Size(190, 23);
            this.tbBerat.TabIndex = 8;
            // 
            // tbTujuan
            // 
            this.tbTujuan.Location = new System.Drawing.Point(16, 143);
            this.tbTujuan.Name = "tbTujuan";
            this.tbTujuan.Size = new System.Drawing.Size(190, 23);
            this.tbTujuan.TabIndex = 9;
            // 
            // btnCheckHarga
            // 
            this.btnCheckHarga.Location = new System.Drawing.Point(33, 285);
            this.btnCheckHarga.Name = "btnCheckHarga";
            this.btnCheckHarga.Size = new System.Drawing.Size(141, 23);
            this.btnCheckHarga.TabIndex = 10;
            this.btnCheckHarga.Text = "Cek Harga Layanan";
            this.btnCheckHarga.UseVisualStyleBackColor = true;
            this.btnCheckHarga.Click += new System.EventHandler(this.btnCheckHarga_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(262, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 223);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Layanan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 327);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCheckHarga);
            this.Controls.Add(this.tbTujuan);
            this.Controls.Add(this.tbBerat);
            this.Controls.Add(this.rbTiki);
            this.Controls.Add(this.rbJne);
            this.Controls.Add(this.rbPos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAsal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbAsal;
        private Label label3;
        private Label label4;
        private RadioButton rbPos;
        private RadioButton rbJne;
        private RadioButton rbTiki;
        private TextBox tbBerat;
        private TextBox tbTujuan;
        private Button btnCheckHarga;
        private GroupBox groupBox1;
    }
}