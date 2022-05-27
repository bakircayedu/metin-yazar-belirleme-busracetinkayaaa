
namespace VeriYapilariÖdev
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
            this.btnMetinYukle = new System.Windows.Forms.Button();
            this.btnStackOku = new System.Windows.Forms.Button();
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.richTxtBox = new System.Windows.Forms.RichTextBox();
            this.richTxtBoxStack = new System.Windows.Forms.RichTextBox();
            this.btnSay = new System.Windows.Forms.Button();
            this.lstViewOzellik = new System.Windows.Forms.ListView();
            this.lblMetin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMetinYukle
            // 
            this.btnMetinYukle.Location = new System.Drawing.Point(50, 88);
            this.btnMetinYukle.Name = "btnMetinYukle";
            this.btnMetinYukle.Size = new System.Drawing.Size(90, 33);
            this.btnMetinYukle.TabIndex = 0;
            this.btnMetinYukle.Text = "Metin Yükle";
            this.btnMetinYukle.UseVisualStyleBackColor = true;
            this.btnMetinYukle.Click += new System.EventHandler(this.btnMetinYukle_Click);
            // 
            // btnStackOku
            // 
            this.btnStackOku.Location = new System.Drawing.Point(50, 291);
            this.btnStackOku.Name = "btnStackOku";
            this.btnStackOku.Size = new System.Drawing.Size(145, 33);
            this.btnStackOku.TabIndex = 1;
            this.btnStackOku.Text = "Stack\'e Oku";
            this.btnStackOku.UseVisualStyleBackColor = true;
            this.btnStackOku.Click += new System.EventHandler(this.btnStackOku_Click);
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Location = new System.Drawing.Point(50, 50);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.Size = new System.Drawing.Size(298, 22);
            this.txtBoxPath.TabIndex = 2;
            // 
            // richTxtBox
            // 
            this.richTxtBox.Location = new System.Drawing.Point(50, 137);
            this.richTxtBox.Name = "richTxtBox";
            this.richTxtBox.Size = new System.Drawing.Size(298, 108);
            this.richTxtBox.TabIndex = 3;
            this.richTxtBox.Text = "Dosya Okuma";
            // 
            // richTxtBoxStack
            // 
            this.richTxtBoxStack.Location = new System.Drawing.Point(50, 342);
            this.richTxtBoxStack.Name = "richTxtBoxStack";
            this.richTxtBoxStack.Size = new System.Drawing.Size(298, 108);
            this.richTxtBoxStack.TabIndex = 4;
            this.richTxtBoxStack.Text = "";
            // 
            // btnSay
            // 
            this.btnSay.Location = new System.Drawing.Point(453, 88);
            this.btnSay.Name = "btnSay";
            this.btnSay.Size = new System.Drawing.Size(113, 33);
            this.btnSay.TabIndex = 5;
            this.btnSay.Text = "Özellik Göster";
            this.btnSay.UseVisualStyleBackColor = true;
            this.btnSay.Click += new System.EventHandler(this.btnSay_Click);
            // 
            // lstViewOzellik
            // 
            this.lstViewOzellik.HideSelection = false;
            this.lstViewOzellik.Location = new System.Drawing.Point(453, 137);
            this.lstViewOzellik.Name = "lstViewOzellik";
            this.lstViewOzellik.Size = new System.Drawing.Size(421, 313);
            this.lstViewOzellik.TabIndex = 8;
            this.lstViewOzellik.UseCompatibleStateImageBehavior = false;
            // 
            // lblMetin
            // 
            this.lblMetin.AutoSize = true;
            this.lblMetin.Location = new System.Drawing.Point(129, 30);
            this.lblMetin.Name = "lblMetin";
            this.lblMetin.Size = new System.Drawing.Size(118, 17);
            this.lblMetin.TabIndex = 10;
            this.lblMetin.Text = "Metin Dosya Yolu";
            this.lblMetin.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 531);
            this.Controls.Add(this.lblMetin);
            this.Controls.Add(this.lstViewOzellik);
            this.Controls.Add(this.btnSay);
            this.Controls.Add(this.richTxtBoxStack);
            this.Controls.Add(this.richTxtBox);
            this.Controls.Add(this.txtBoxPath);
            this.Controls.Add(this.btnStackOku);
            this.Controls.Add(this.btnMetinYukle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMetinYukle;
        private System.Windows.Forms.Button btnStackOku;
        private System.Windows.Forms.TextBox txtBoxPath;
        private System.Windows.Forms.RichTextBox richTxtBox;
        private System.Windows.Forms.RichTextBox richTxtBoxStack;
        private System.Windows.Forms.Button btnSay;
        private System.Windows.Forms.ListView lstViewOzellik;
        private System.Windows.Forms.Label lblMetin;
    }
}

