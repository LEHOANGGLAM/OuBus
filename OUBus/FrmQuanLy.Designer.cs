
namespace OUBus
{
    partial class FrmQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLy));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLCD = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLBV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDSVX = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Pacifico", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThongKe,
            this.menuQLNV,
            this.menuQLCD,
            this.menuQLBV,
            this.menuDSVX});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1252, 45);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuThongKe
            // 
            this.menuThongKe.Name = "menuThongKe";
            this.menuThongKe.Size = new System.Drawing.Size(207, 41);
            this.menuThongKe.Text = "Thống kê và doanh thu";
            this.menuThongKe.Click += new System.EventHandler(this.menuThongKe_Click);
            // 
            // menuQLNV
            // 
            this.menuQLNV.Name = "menuQLNV";
            this.menuQLNV.Size = new System.Drawing.Size(174, 41);
            this.menuQLNV.Text = "Quản lý nhân viên ";
            this.menuQLNV.Click += new System.EventHandler(this.menuQLNV_Click);
            // 
            // menuQLCD
            // 
            this.menuQLCD.Name = "menuQLCD";
            this.menuQLCD.Size = new System.Drawing.Size(171, 41);
            this.menuQLCD.Text = "Quản lý chuyến đi ";
            this.menuQLCD.Click += new System.EventHandler(this.menuQLCD_Click_1);
            // 
            // menuQLBV
            // 
            this.menuQLBV.Name = "menuQLBV";
            this.menuQLBV.Size = new System.Drawing.Size(146, 41);
            this.menuQLBV.Text = "Quản lý bán vé";
            this.menuQLBV.Click += new System.EventHandler(this.menuQLBV_Click);
            // 
            // menuDSVX
            // 
            this.menuDSVX.Name = "menuDSVX";
            this.menuDSVX.Size = new System.Drawing.Size(160, 41);
            this.menuDSVX.Text = "Danh sách vé xe ";
            this.menuDSVX.Click += new System.EventHandler(this.menuDSVX_Click);
            // 
            // FrmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OUBus.Properties.Resources.main;
            this.ClientSize = new System.Drawing.Size(1252, 749);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmQuanLy";
            this.Text = "Quản lý";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuThongKe;
        private System.Windows.Forms.ToolStripMenuItem menuQLNV;
        private System.Windows.Forms.ToolStripMenuItem menuQLCD;
        private System.Windows.Forms.ToolStripMenuItem menuQLBV;
        private System.Windows.Forms.ToolStripMenuItem menuDSVX;
    }
}