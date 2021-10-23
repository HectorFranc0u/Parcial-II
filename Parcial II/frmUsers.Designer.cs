
namespace Parcial_II
{
    partial class frmUsers
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
            this.dtgUser = new System.Windows.Forms.DataGridView();
            this.User = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUser
            // 
            this.dtgUser.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUser.Location = new System.Drawing.Point(31, 122);
            this.dtgUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgUser.Name = "dtgUser";
            this.dtgUser.RowHeadersWidth = 51;
            this.dtgUser.Size = new System.Drawing.Size(995, 385);
            this.dtgUser.TabIndex = 0;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(24, 38);
            this.User.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(91, 37);
            this.User.TabIndex = 1;
            this.User.Text = "Users";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.User);
            this.Controls.Add(this.dtgUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgUser;
        private System.Windows.Forms.Label User;
    }
}