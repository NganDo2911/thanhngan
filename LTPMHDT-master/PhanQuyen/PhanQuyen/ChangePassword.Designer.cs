namespace PhanQuyen
{
    partial class ChangePassword
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
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.TextBoxOldPassword = new System.Windows.Forms.MaskedTextBox();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPassword.Location = new System.Drawing.Point(279, 116);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(266, 33);
            this.textBoxNewPassword.TabIndex = 0;
            // 
            // TextBoxOldPassword
            // 
            this.TextBoxOldPassword.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxOldPassword.Location = new System.Drawing.Point(279, 61);
            this.TextBoxOldPassword.Name = "TextBoxOldPassword";
            this.TextBoxOldPassword.Size = new System.Drawing.Size(266, 33);
            this.TextBoxOldPassword.TabIndex = 1;
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(279, 174);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(266, 33);
            this.textBoxConfirmPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Old password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "New password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm new password";
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonChangePassword.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePassword.Location = new System.Drawing.Point(158, 233);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(266, 70);
            this.buttonChangePassword.TabIndex = 6;
            this.buttonChangePassword.Text = "Change password";
            this.buttonChangePassword.UseVisualStyleBackColor = false;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(601, 333);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.TextBoxOldPassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.MaskedTextBox TextBoxOldPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonChangePassword;
    }
}