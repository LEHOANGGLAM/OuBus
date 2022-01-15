
namespace OUBus
{
    partial class FormDN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDN));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblChon = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtDangNhap = new System.Windows.Forms.TextBox();
            this.cbChon = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDN = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(389, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập";
            // 
            // lblChon
            // 
            this.lblChon.AutoSize = true;
            this.lblChon.BackColor = System.Drawing.Color.Transparent;
            this.lblChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChon.Location = new System.Drawing.Point(251, 158);
            this.lblChon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChon.Name = "lblChon";
            this.lblChon.Size = new System.Drawing.Size(80, 29);
            this.lblChon.TabIndex = 0;
            this.lblChon.Text = "Bạn là";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(375, 267);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(317, 22);
            this.txtMatKhau.TabIndex = 3;
            // 
            // txtDangNhap
            // 
            this.txtDangNhap.Location = new System.Drawing.Point(375, 220);
            this.txtDangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.Size = new System.Drawing.Size(317, 22);
            this.txtDangNhap.TabIndex = 2;
            this.txtDangNhap.Tag = "";
            // 
            // cbChon
            // 
            this.cbChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChon.FormattingEnabled = true;
            this.cbChon.Items.AddRange(new object[] {
            "Quản Lý",
            "Nhân Viên"});
            this.cbChon.Location = new System.Drawing.Point(375, 158);
            this.cbChon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbChon.Name = "cbChon";
            this.cbChon.Size = new System.Drawing.Size(317, 33);
            this.cbChon.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(820, 389);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(220, 62);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDN
            // 
            this.btnDN.BackColor = System.Drawing.Color.Transparent;
            this.btnDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.ForeColor = System.Drawing.Color.Black;
            this.btnDN.Location = new System.Drawing.Point(567, 389);
            this.btnDN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(220, 62);
            this.btnDN.TabIndex = 4;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = false;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(329, 334);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(387, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Nếu bạn chưa có tài khoản hãy nhấp vào đây để đăng kí !!!!!!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::OUBus.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1056, 466);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cbChon);
            this.Controls.Add(this.txtDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lblChon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.FormDN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtDangNhap;
        private System.Windows.Forms.ComboBox cbChon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

