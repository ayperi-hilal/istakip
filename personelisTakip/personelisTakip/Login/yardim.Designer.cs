
namespace personelisTakip.Login
{
    partial class yardim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yardim));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.hlk_sifremiUnuttum = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.hyperlinkLabelControl3 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.hlk_webPanel = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(695, 52);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = resources.GetString("labelControl1.Text");
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(163, 164);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(65, 13);
            this.hyperlinkLabelControl1.TabIndex = 1;
            this.hyperlinkLabelControl1.Text = "Program Girişi";
            this.hyperlinkLabelControl1.Click += new System.EventHandler(this.hyperlinkLabelControl1_Click);
            // 
            // hlk_sifremiUnuttum
            // 
            this.hlk_sifremiUnuttum.Location = new System.Drawing.Point(163, 234);
            this.hlk_sifremiUnuttum.Name = "hlk_sifremiUnuttum";
            this.hlk_sifremiUnuttum.Size = new System.Drawing.Size(66, 13);
            this.hlk_sifremiUnuttum.TabIndex = 1;
            this.hlk_sifremiUnuttum.Text = "Şifre Unuttum";
            this.hlk_sifremiUnuttum.Click += new System.EventHandler(this.hlk_sifremiUnuttum_Click);
            // 
            // hyperlinkLabelControl3
            // 
            this.hyperlinkLabelControl3.Location = new System.Drawing.Point(163, 277);
            this.hyperlinkLabelControl3.Name = "hyperlinkLabelControl3";
            this.hyperlinkLabelControl3.Size = new System.Drawing.Size(21, 13);
            this.hyperlinkLabelControl3.TabIndex = 1;
            this.hyperlinkLabelControl3.Text = "Çıkış";
            this.hyperlinkLabelControl3.Click += new System.EventHandler(this.hyperlinkLabelControl3_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(276, 425);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(128, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "V 2022 Tüm Hakları Saklıdır";
            // 
            // hlk_webPanel
            // 
            this.hlk_webPanel.Location = new System.Drawing.Point(163, 200);
            this.hlk_webPanel.Name = "hlk_webPanel";
            this.hlk_webPanel.Size = new System.Drawing.Size(51, 13);
            this.hlk_webPanel.TabIndex = 15;
            this.hlk_webPanel.Text = "Web Panel";
            this.hlk_webPanel.Click += new System.EventHandler(this.hlk_webPanel_Click);
            // 
            // yardim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.hlk_webPanel);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.hyperlinkLabelControl3);
            this.Controls.Add(this.hlk_sifremiUnuttum);
            this.Controls.Add(this.hyperlinkLabelControl1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "yardim";
            this.Text = "yardim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl hlk_sifremiUnuttum;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.HyperlinkLabelControl hlk_webPanel;
    }
}