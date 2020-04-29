namespace PhanQuyen
{
    partial class QuanLyLoaiNguoiDung
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
            this.dataGridViewLoaiNguoiDung = new System.Windows.Forms.DataGridView();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMota = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLoaiNguoiDung
            // 
            this.dataGridViewLoaiNguoiDung.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewLoaiNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoaiNguoiDung.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewLoaiNguoiDung.Name = "dataGridViewLoaiNguoiDung";
            this.dataGridViewLoaiNguoiDung.RowHeadersWidth = 51;
            this.dataGridViewLoaiNguoiDung.RowTemplate.Height = 24;
            this.dataGridViewLoaiNguoiDung.Size = new System.Drawing.Size(617, 392);
            this.dataGridViewLoaiNguoiDung.TabIndex = 0;
            this.dataGridViewLoaiNguoiDung.DoubleClick += new System.EventHandler(this.dataGridViewLoaiNguoiDung_DoubleClick);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(786, 45);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(204, 33);
            this.textBoxID.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(786, 106);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(204, 33);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxMota
            // 
            this.textBoxMota.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMota.Location = new System.Drawing.Point(786, 163);
            this.textBoxMota.Name = "textBoxMota";
            this.textBoxMota.Size = new System.Drawing.Size(204, 33);
            this.textBoxMota.TabIndex = 3;
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.Azure;
            this.buttonInsert.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(644, 251);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(129, 41);
            this.buttonInsert.TabIndex = 4;
            this.buttonInsert.Text = "Add";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(661, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(661, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(661, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Azure;
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(779, 251);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(122, 41);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Azure;
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(907, 251);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(118, 41);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // QuanLyLoaiNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1037, 425);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxMota);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.dataGridViewLoaiNguoiDung);
            this.Name = "QuanLyLoaiNguoiDung";
            this.Text = "LoaiNguoiDung";
            this.Load += new System.EventHandler(this.QuanLyLoaiNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiNguoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLoaiNguoiDung;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMota;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
    }
}