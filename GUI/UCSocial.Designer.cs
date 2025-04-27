namespace Find_Job_Management.GUI {
    partial class UCSocial {
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
            this.pnlSocial = new System.Windows.Forms.FlowLayoutPanel();
            this.pBAvatar = new System.Windows.Forms.PictureBox();
            this.txtUpSocial = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pBAvatar)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSocial
            // 
            this.pnlSocial.AutoScroll = true;
            this.pnlSocial.Location = new System.Drawing.Point(5, 109);
            this.pnlSocial.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSocial.Name = "pnlSocial";
            this.pnlSocial.Size = new System.Drawing.Size(1174, 813);
            this.pnlSocial.TabIndex = 4;
            // 
            // pBAvatar
            // 
            this.pBAvatar.Image = global::Find_Job_Management.Properties.Resources.man;
            this.pBAvatar.Location = new System.Drawing.Point(24, 15);
            this.pBAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.pBAvatar.Name = "pBAvatar";
            this.pBAvatar.Size = new System.Drawing.Size(50, 50);
            this.pBAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBAvatar.TabIndex = 1;
            this.pBAvatar.TabStop = false;
            // 
            // txtUpSocial
            // 
            this.txtUpSocial.BorderRadius = 20;
            this.txtUpSocial.BorderThickness = 0;
            this.txtUpSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpSocial.DefaultText = "";
            this.txtUpSocial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpSocial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpSocial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpSocial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpSocial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.txtUpSocial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtUpSocial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpSocial.Location = new System.Drawing.Point(96, 15);
            this.txtUpSocial.Margin = new System.Windows.Forms.Padding(7);
            this.txtUpSocial.Name = "txtUpSocial";
            this.txtUpSocial.PlaceholderText = "What\'s on your mind?";
            this.txtUpSocial.ReadOnly = true;
            this.txtUpSocial.SelectedText = "";
            this.txtUpSocial.Size = new System.Drawing.Size(1050, 50);
            this.txtUpSocial.TabIndex = 0;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 10;
            this.guna2CustomGradientPanel1.Controls.Add(this.pBAvatar);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtUpSocial);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(5, 14);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1174, 80);
            this.guna2CustomGradientPanel1.TabIndex = 5;
            // 
            // UCSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.pnlSocial);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCSocial";
            this.Size = new System.Drawing.Size(1184, 936);
            ((System.ComponentModel.ISupportInitialize)(this.pBAvatar)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlSocial;
        private System.Windows.Forms.PictureBox pBAvatar;
        private Guna.UI2.WinForms.Guna2TextBox txtUpSocial;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
    }
}
