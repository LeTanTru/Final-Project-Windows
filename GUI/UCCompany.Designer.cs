namespace Find_Job_Management.GUI {
    partial class UCCompany {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.llblNameCompany = new Guna.UI.WinForms.GunaLinkLabel();
            this.pbCompany = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // llblNameCompany
            // 
            this.llblNameCompany.AutoSize = true;
            this.llblNameCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblNameCompany.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblNameCompany.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblNameCompany.Location = new System.Drawing.Point(154, 22);
            this.llblNameCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblNameCompany.Name = "llblNameCompany";
            this.llblNameCompany.Size = new System.Drawing.Size(68, 22);
            this.llblNameCompany.TabIndex = 3;
            this.llblNameCompany.TabStop = true;
            this.llblNameCompany.Text = "AXON";
            // 
            // pbCompany
            // 
            this.pbCompany.Image = global::Find_Job_Management.Properties.Resources.Company;
            this.pbCompany.Location = new System.Drawing.Point(28, 22);
            this.pbCompany.Margin = new System.Windows.Forms.Padding(2);
            this.pbCompany.Name = "pbCompany";
            this.pbCompany.Size = new System.Drawing.Size(98, 83);
            this.pbCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCompany.TabIndex = 2;
            this.pbCompany.TabStop = false;
            // 
            // UCCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.llblNameCompany);
            this.Controls.Add(this.pbCompany);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCCompany";
            this.Size = new System.Drawing.Size(834, 128);
            ((System.ComponentModel.ISupportInitialize)(this.pbCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLinkLabel llblNameCompany;
        private System.Windows.Forms.PictureBox pbCompany;
    }
}
