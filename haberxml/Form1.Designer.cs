﻿
namespace haberxml
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnXmlOku = new System.Windows.Forms.Button();
            this.btnXmlYaz = new System.Windows.Forms.Button();
            this.dgvSnc = new System.Windows.Forms.DataGridView();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSnc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXmlOku
            // 
            this.btnXmlOku.Location = new System.Drawing.Point(165, 375);
            this.btnXmlOku.Name = "btnXmlOku";
            this.btnXmlOku.Size = new System.Drawing.Size(132, 52);
            this.btnXmlOku.TabIndex = 0;
            this.btnXmlOku.Text = "XmlOku";
            this.btnXmlOku.UseVisualStyleBackColor = true;
            this.btnXmlOku.Click += new System.EventHandler(this.btnXmlOku_Click);
            // 
            // btnXmlYaz
            // 
            this.btnXmlYaz.Enabled = false;
            this.btnXmlYaz.Location = new System.Drawing.Point(355, 375);
            this.btnXmlYaz.Name = "btnXmlYaz";
            this.btnXmlYaz.Size = new System.Drawing.Size(134, 52);
            this.btnXmlYaz.TabIndex = 1;
            this.btnXmlYaz.Text = "XmlYaz";
            this.btnXmlYaz.UseVisualStyleBackColor = true;
            this.btnXmlYaz.Click += new System.EventHandler(this.btnXmlYaz_Click);
            // 
            // dgvSnc
            // 
            this.dgvSnc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSnc.Location = new System.Drawing.Point(-1, 0);
            this.dgvSnc.Name = "dgvSnc";
            this.dgvSnc.Size = new System.Drawing.Size(654, 369);
            this.dgvSnc.TabIndex = 2;
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 434);
            this.Controls.Add(this.dgvSnc);
            this.Controls.Add(this.btnXmlYaz);
            this.Controls.Add(this.btnXmlOku);
            this.Name = "Form1";
            this.Text = "XmlOkumaYazmaFormu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSnc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXmlOku;
        private System.Windows.Forms.Button btnXmlYaz;
        private System.Windows.Forms.DataGridView dgvSnc;
        private System.Windows.Forms.Timer tmr;
    }
}

