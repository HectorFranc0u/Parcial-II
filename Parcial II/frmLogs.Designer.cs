
namespace Parcial_II
{
    partial class frmLogs
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
            this.gtdLogs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gtdLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // gtdLogs
            // 
            this.gtdLogs.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gtdLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gtdLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gtdLogs.Location = new System.Drawing.Point(9, 88);
            this.gtdLogs.Name = "gtdLogs";
            this.gtdLogs.Size = new System.Drawing.Size(768, 339);
            this.gtdLogs.TabIndex = 0;
            // 
            // frmLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gtdLogs);
            this.Name = "frmLogs";
            this.Text = "Logs";
            ((System.ComponentModel.ISupportInitialize)(this.gtdLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gtdLogs;
    }
}