namespace Find_Job_Management.GUI {
    partial class UCTopCompany {
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
            this.pnlListCompany = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnlListCompany
            // 
            this.pnlListCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListCompany.AutoScroll = true;
            this.pnlListCompany.Location = new System.Drawing.Point(2, 68);
            this.pnlListCompany.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlListCompany.Name = "pnlListCompany";
            this.pnlListCompany.Size = new System.Drawing.Size(1027, 471);
            this.pnlListCompany.TabIndex = 45;
            // 
            // UCTopCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlListCompany);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCTopCompany";
            this.Size = new System.Drawing.Size(1031, 540);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlListCompany;
    }
}
