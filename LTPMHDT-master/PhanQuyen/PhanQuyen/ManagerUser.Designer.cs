namespace PhanQuyen
{
    partial class ManagerUser
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
            this.dataGridViewNguoiDung = new System.Windows.Forms.DataGridView();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.comboBoxLoaiNguoiDung = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNguoiDung
            // 
            this.dataGridViewNguoiDung.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNguoiDung.Location = new System.Drawing.Point(12, 21);
            this.dataGridViewNguoiDung.Name = "dataGridViewNguoiDung";
            this.dataGridViewNguoiDung.RowHeadersWidth = 51;
            this.dataGridViewNguoiDung.RowTemplate.Height = 24;
            this.dataGridViewNguoiDung.Size = new System.Drawing.Size(828, 380);
            this.dataGridViewNguoiDung.TabIndex = 0;
            this.dataGridViewNguoiDung.DoubleClick += new System.EventHandler(this.dataGridViewNguoiDung_DoubleClick);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(1055, 21);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(153, 33);
            this.textBoxID.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(1055, 65);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(153, 33);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.Location = new System.Drawing.Point(1055, 113);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(153, 33);
            this.textBoxUser.TabIndex = 3;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(1055, 173);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(153, 33);
            this.textBoxPass.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(878, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(878, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(878, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(878, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pass";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(878, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "LoaiNguoiDung";
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.Azure;
            this.buttonInsert.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(858, 309);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(107, 44);
            this.buttonInsert.TabIndex = 13;
            this.buttonInsert.Text = "Add";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // comboBoxLoaiNguoiDung
            // 
            this.comboBoxLoaiNguoiDung.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLoaiNguoiDung.FormattingEnabled = true;
            this.comboBoxLoaiNguoiDung.Location = new System.Drawing.Point(1055, 239);
            this.comboBoxLoaiNguoiDung.Name = "comboBoxLoaiNguoiDung";
            this.comboBoxLoaiNguoiDung.Size = new System.Drawing.Size(153, 33);
            this.comboBoxLoaiNguoiDung.TabIndex = 14;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Azure;
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(980, 309);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(119, 44);
            this.buttonUpdate.TabIndex = 15;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Azure;
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(1114, 309);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 44);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ManagerUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1252, 429);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBoxLoaiNguoiDung);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.dataGridViewNguoiDung);
            this.Name = "ManagerUser";
            this.Text = "ManagerUser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNguoiDung;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.ComboBox comboBoxLoaiNguoiDung;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
    }
}