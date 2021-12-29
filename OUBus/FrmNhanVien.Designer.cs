
namespace OUBus
{
    partial class FrmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuQLBV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDSVX = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Pacifico", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQLBV,
            this.menuDSVX});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1236, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuQLBV
            // 
            this.menuQLBV.Name = "menuQLBV";
            this.menuQLBV.Size = new System.Drawing.Size(146, 41);
            this.menuQLBV.Text = "Quản lý bán vé";
            this.menuQLBV.Click += new System.EventHandler(this.quảnLýBánVéToolStripMenuItem_Click);
            // 
            // menuDSVX
            // 
            this.menuDSVX.Name = "menuDSVX";
            this.menuDSVX.Size = new System.Drawing.Size(160, 41);
            this.menuDSVX.Text = "Danh sách vé xe ";
            this.menuDSVX.Click += new System.EventHandler(this.quảnLýVéXeToolStripMenuItem_Click);
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OUBus.Properties.Resources.main;
            this.ClientSize = new System.Drawing.Size(1236, 749);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmNhanVien";
            this.Text = "Nhân viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuQLBV;
        private System.Windows.Forms.ToolStripMenuItem menuDSVX;
    }
}