namespace PhanQuyen
{
    partial class MainForm
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
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.dataGridViewQuyenLoaiNguoiDung = new System.Windows.Forms.DataGridView();
            this.dataGridViewQuyenNguoiDung = new System.Windows.Forms.DataGridView();
            this.buttonTypeUser = new System.Windows.Forms.Button();
            this.buttonManageUser = new System.Windows.Forms.Button();
            this.buttonQuyen = new System.Windows.Forms.Button();
            this.buttonPhanQuyen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuyenLoaiNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuyenNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.BackColor = System.Drawing.Color.Azure;
            this.buttonChangePassword.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePassword.Location = new System.Drawing.Point(971, 28);
            this.buttonChangePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(190, 51);
            this.buttonChangePassword.TabIndex = 0;
            this.buttonChangePassword.Text = "Change Password";
            this.buttonChangePassword.UseVisualStyleBackColor = false;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // dataGridViewQuyenLoaiNguoiDung
            // 
            this.dataGridViewQuyenLoaiNguoiDung.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewQuyenLoaiNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuyenLoaiNguoiDung.Location = new System.Drawing.Point(49, 111);
            this.dataGridViewQuyenLoaiNguoiDung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewQuyenLoaiNguoiDung.Name = "dataGridViewQuyenLoaiNguoiDung";
            this.dataGridViewQuyenLoaiNguoiDung.RowHeadersWidth = 51;
            this.dataGridViewQuyenLoaiNguoiDung.RowTemplate.Height = 24;
            this.dataGridViewQuyenLoaiNguoiDung.Size = new System.Drawing.Size(1112, 228);
            this.dataGridViewQuyenLoaiNguoiDung.TabIndex = 1;
            // 
            // dataGridViewQuyenNguoiDung
            // 
            this.dataGridViewQuyenNguoiDung.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewQuyenNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuyenNguoiDung.Location = new System.Drawing.Point(49, 364);
            this.dataGridViewQuyenNguoiDung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewQuyenNguoiDung.Name = "dataGridViewQuyenNguoiDung";
            this.dataGridViewQuyenNguoiDung.RowHeadersWidth = 51;
            this.dataGridViewQuyenNguoiDung.RowTemplate.Height = 24;
            this.dataGridViewQuyenNguoiDung.Size = new System.Drawing.Size(1112, 280);
            this.dataGridViewQuyenNguoiDung.TabIndex = 2;
            // 
            // buttonTypeUser
            // 
            this.buttonTypeUser.BackColor = System.Drawing.Color.Azure;
            this.buttonTypeUser.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTypeUser.Location = new System.Drawing.Point(240, 28);
            this.buttonTypeUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTypeUser.Name = "buttonTypeUser";
            this.buttonTypeUser.Size = new System.Drawing.Size(226, 51);
            this.buttonTypeUser.TabIndex = 3;
            this.buttonTypeUser.Text = "Manage Type User";
            this.buttonTypeUser.UseVisualStyleBackColor = false;
            this.buttonTypeUser.Click += new System.EventHandler(this.buttonTypeUser_Click);
            // 
            // buttonManageUser
            // 
            this.buttonManageUser.BackColor = System.Drawing.Color.Azure;
            this.buttonManageUser.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageUser.Location = new System.Drawing.Point(49, 28);
            this.buttonManageUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonManageUser.Name = "buttonManageUser";
            this.buttonManageUser.Size = new System.Drawing.Size(183, 51);
            this.buttonManageUser.TabIndex = 4;
            this.buttonManageUser.Text = "Manage user";
            this.buttonManageUser.UseVisualStyleBackColor = false;
            this.buttonManageUser.Click += new System.EventHandler(this.buttonManageUser_Click);
            // 
            // buttonQuyen
            // 
            this.buttonQuyen.BackColor = System.Drawing.Color.Azure;
            this.buttonQuyen.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuyen.Location = new System.Drawing.Point(474, 28);
            this.buttonQuyen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonQuyen.Name = "buttonQuyen";
            this.buttonQuyen.Size = new System.Drawing.Size(212, 51);
            this.buttonQuyen.TabIndex = 5;
            this.buttonQuyen.Text = "Privilege";
            this.buttonQuyen.UseVisualStyleBackColor = false;
            this.buttonQuyen.Click += new System.EventHandler(this.buttonQuyen_Click);
            // 
            // buttonPhanQuyen
            // 
            this.buttonPhanQuyen.BackColor = System.Drawing.Color.Azure;
            this.buttonPhanQuyen.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPhanQuyen.Location = new System.Drawing.Point(694, 28);
            this.buttonPhanQuyen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPhanQuyen.Name = "buttonPhanQuyen";
            this.buttonPhanQuyen.Size = new System.Drawing.Size(269, 51);
            this.buttonPhanQuyen.TabIndex = 6;
            this.buttonPhanQuyen.Text = "Decentralized User";
            this.buttonPhanQuyen.UseVisualStyleBackColor = false;
            this.buttonPhanQuyen.Click += new System.EventHandler(this.buttonPhanQuyen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1197, 686);
            this.Controls.Add(this.buttonPhanQuyen);
            this.Controls.Add(this.buttonQuyen);
            this.Controls.Add(this.buttonManageUser);
            this.Controls.Add(this.buttonTypeUser);
            this.Controls.Add(this.dataGridViewQuyenNguoiDung);
            this.Controls.Add(this.dataGridViewQuyenLoaiNguoiDung);
            this.Controls.Add(this.buttonChangePassword);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuyenLoaiNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuyenNguoiDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.DataGridView dataGridViewQuyenLoaiNguoiDung;
        private System.Windows.Forms.DataGridView dataGridViewQuyenNguoiDung;
        private System.Windows.Forms.Button buttonTypeUser;
        private System.Windows.Forms.Button buttonManageUser;
        private System.Windows.Forms.Button buttonQuyen;
        private System.Windows.Forms.Button buttonPhanQuyen;
    }
}