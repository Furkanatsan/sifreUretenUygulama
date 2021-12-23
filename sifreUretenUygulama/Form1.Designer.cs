
namespace sifreUretenUygulama
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUret = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSifreUzunlugu = new System.Windows.Forms.NumericUpDown();
            this.nudSifreSayisi = new System.Windows.Forms.NumericUpDown();
            this.chkOzelKarakter = new System.Windows.Forms.CheckBox();
            this.chkRakam = new System.Windows.Forms.CheckBox();
            this.chkBuyukHarf = new System.Windows.Forms.CheckBox();
            this.chkKucukHarf = new System.Windows.Forms.CheckBox();
            this.txtSifreler = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunlugu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUret);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudSifreUzunlugu);
            this.groupBox1.Controls.Add(this.nudSifreSayisi);
            this.groupBox1.Controls.Add(this.chkOzelKarakter);
            this.groupBox1.Controls.Add(this.chkRakam);
            this.groupBox1.Controls.Add(this.chkBuyukHarf);
            this.groupBox1.Controls.Add(this.chkKucukHarf);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 526);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametreler";
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(242, 427);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(130, 45);
            this.btnUret.TabIndex = 3;
            this.btnUret.Text = "Üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre Uzunluğu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Şifre Sayısı";
            // 
            // nudSifreUzunlugu
            // 
            this.nudSifreUzunlugu.Location = new System.Drawing.Point(252, 361);
            this.nudSifreUzunlugu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSifreUzunlugu.Name = "nudSifreUzunlugu";
            this.nudSifreUzunlugu.Size = new System.Drawing.Size(120, 41);
            this.nudSifreUzunlugu.TabIndex = 1;
            this.nudSifreUzunlugu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudSifreSayisi
            // 
            this.nudSifreSayisi.Location = new System.Drawing.Point(252, 307);
            this.nudSifreSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSifreSayisi.Name = "nudSifreSayisi";
            this.nudSifreSayisi.Size = new System.Drawing.Size(120, 41);
            this.nudSifreSayisi.TabIndex = 1;
            this.nudSifreSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkOzelKarakter
            // 
            this.chkOzelKarakter.AutoSize = true;
            this.chkOzelKarakter.Location = new System.Drawing.Point(47, 247);
            this.chkOzelKarakter.Name = "chkOzelKarakter";
            this.chkOzelKarakter.Size = new System.Drawing.Size(216, 40);
            this.chkOzelKarakter.TabIndex = 0;
            this.chkOzelKarakter.Text = "Özel Karakter";
            this.chkOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // chkRakam
            // 
            this.chkRakam.AutoSize = true;
            this.chkRakam.Location = new System.Drawing.Point(47, 191);
            this.chkRakam.Name = "chkRakam";
            this.chkRakam.Size = new System.Drawing.Size(129, 40);
            this.chkRakam.TabIndex = 0;
            this.chkRakam.Text = "Rakam";
            this.chkRakam.UseVisualStyleBackColor = true;
            // 
            // chkBuyukHarf
            // 
            this.chkBuyukHarf.AutoSize = true;
            this.chkBuyukHarf.Location = new System.Drawing.Point(47, 123);
            this.chkBuyukHarf.Name = "chkBuyukHarf";
            this.chkBuyukHarf.Size = new System.Drawing.Size(176, 40);
            this.chkBuyukHarf.TabIndex = 0;
            this.chkBuyukHarf.Text = "BüyükHarf";
            this.chkBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // chkKucukHarf
            // 
            this.chkKucukHarf.AutoSize = true;
            this.chkKucukHarf.Location = new System.Drawing.Point(47, 60);
            this.chkKucukHarf.Name = "chkKucukHarf";
            this.chkKucukHarf.Size = new System.Drawing.Size(176, 40);
            this.chkKucukHarf.TabIndex = 0;
            this.chkKucukHarf.Text = "KüçükHarf";
            this.chkKucukHarf.UseVisualStyleBackColor = true;
            // 
            // txtSifreler
            // 
            this.txtSifreler.Location = new System.Drawing.Point(465, 12);
            this.txtSifreler.Multiline = true;
            this.txtSifreler.Name = "txtSifreler";
            this.txtSifreler.ReadOnly = true;
            this.txtSifreler.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSifreler.Size = new System.Drawing.Size(437, 526);
            this.txtSifreler.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 550);
            this.Controls.Add(this.txtSifreler);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunlugu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSifreUzunlugu;
        private System.Windows.Forms.NumericUpDown nudSifreSayisi;
        private System.Windows.Forms.CheckBox chkOzelKarakter;
        private System.Windows.Forms.CheckBox chkRakam;
        private System.Windows.Forms.CheckBox chkBuyukHarf;
        private System.Windows.Forms.CheckBox chkKucukHarf;
        private System.Windows.Forms.TextBox txtSifreler;
    }
}

