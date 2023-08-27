
namespace QRCODETESTAPP
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.headbutton = new System.Windows.Forms.Button();
            this.bodybutton = new System.Windows.Forms.Button();
            this.kaydet = new System.Windows.Forms.Button();
            this.headmevcut = new System.Windows.Forms.Button();
            this.bodymevcut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(477, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(537, 533);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // headbutton
            // 
            this.headbutton.Location = new System.Drawing.Point(12, 85);
            this.headbutton.Name = "headbutton";
            this.headbutton.Size = new System.Drawing.Size(108, 24);
            this.headbutton.TabIndex = 2;
            this.headbutton.Text = "HEAD GUNCEL";
            this.headbutton.UseVisualStyleBackColor = true;
            this.headbutton.Click += new System.EventHandler(this.headbutton_Click);
            // 
            // bodybutton
            // 
            this.bodybutton.Location = new System.Drawing.Point(126, 85);
            this.bodybutton.Name = "bodybutton";
            this.bodybutton.Size = new System.Drawing.Size(108, 24);
            this.bodybutton.TabIndex = 3;
            this.bodybutton.Text = "BODY GUNCEL";
            this.bodybutton.UseVisualStyleBackColor = true;
            this.bodybutton.Click += new System.EventHandler(this.bodybutton_Click);
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(126, 488);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(153, 40);
            this.kaydet.TabIndex = 4;
            this.kaydet.Text = "Değişiklikleri Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // headmevcut
            // 
            this.headmevcut.Location = new System.Drawing.Point(12, 55);
            this.headmevcut.Name = "headmevcut";
            this.headmevcut.Size = new System.Drawing.Size(108, 24);
            this.headmevcut.TabIndex = 5;
            this.headmevcut.Text = "HEAD MEVCUT";
            this.headmevcut.UseVisualStyleBackColor = true;
            this.headmevcut.Click += new System.EventHandler(this.headmevcut_Click);
            // 
            // bodymevcut
            // 
            this.bodymevcut.Location = new System.Drawing.Point(126, 55);
            this.bodymevcut.Name = "bodymevcut";
            this.bodymevcut.Size = new System.Drawing.Size(108, 24);
            this.bodymevcut.TabIndex = 6;
            this.bodymevcut.Text = "BODY MEVCUT";
            this.bodymevcut.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1016, 549);
            this.Controls.Add(this.bodymevcut);
            this.Controls.Add(this.headmevcut);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.bodybutton);
            this.Controls.Add(this.headbutton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "XSLT EDITOR QR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button headbutton;
        private System.Windows.Forms.Button bodybutton;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Button headmevcut;
        private System.Windows.Forms.Button bodymevcut;
    }
}

