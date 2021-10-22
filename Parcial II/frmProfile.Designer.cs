
namespace Parcial_II
{
    partial class frmProfile
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
            this.lblUsname = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.UserEmail = new MetroFramework.Controls.MetroLabel();
            this.lblUserRegisterDate = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsname
            // 
            this.lblUsname.AutoSize = true;
            this.lblUsname.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblUsname.Location = new System.Drawing.Point(307, 63);
            this.lblUsname.Name = "lblUsname";
            this.lblUsname.Size = new System.Drawing.Size(93, 25);
            this.lblUsname.TabIndex = 1;
            this.lblUsname.Text = "Username:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Parcial_II.Properties.Resources.avatardefault_92824;
            this.pictureBox1.Location = new System.Drawing.Point(23, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(307, 126);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Full Name:";
            // 
            // UserEmail
            // 
            this.UserEmail.AutoSize = true;
            this.UserEmail.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.UserEmail.Location = new System.Drawing.Point(307, 185);
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.Size = new System.Drawing.Size(53, 25);
            this.UserEmail.TabIndex = 3;
            this.UserEmail.Text = "Emal:";
            // 
            // lblUserRegisterDate
            // 
            this.lblUserRegisterDate.AutoSize = true;
            this.lblUserRegisterDate.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblUserRegisterDate.Location = new System.Drawing.Point(307, 241);
            this.lblUserRegisterDate.Name = "lblUserRegisterDate";
            this.lblUserRegisterDate.Size = new System.Drawing.Size(116, 25);
            this.lblUserRegisterDate.TabIndex = 4;
            this.lblUserRegisterDate.Text = "Register Date:";
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 367);
            this.Controls.Add(this.lblUserRegisterDate);
            this.Controls.Add(this.UserEmail);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblUsname);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmProfile";
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lblUsname;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel UserEmail;
        private MetroFramework.Controls.MetroLabel lblUserRegisterDate;
    }
}