﻿namespace Find_Job_Management.GUI {
    partial class UCMailRow {
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
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pbSeeDetail = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeeDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.BorderRadius = 10;
            this.guna2CustomGradientPanel2.Controls.Add(this.pbSeeDetail);
            this.guna2CustomGradientPanel2.Controls.Add(this.lblTime);
            this.guna2CustomGradientPanel2.Controls.Add(this.lblTitle);
            this.guna2CustomGradientPanel2.Controls.Add(this.lblFrom);
            this.guna2CustomGradientPanel2.Controls.Add(this.lblID);
            this.guna2CustomGradientPanel2.CustomBorderThickness = new System.Windows.Forms.Padding(10);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(3, 6);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(1140, 50);
            this.guna2CustomGradientPanel2.TabIndex = 51;
            // 
            // pbSeeDetail
            // 
            this.pbSeeDetail.BackColor = System.Drawing.Color.White;
            this.pbSeeDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSeeDetail.ErrorImage = null;
            this.pbSeeDetail.Image = global::Find_Job_Management.Properties.Resources.eyeDetail;
            this.pbSeeDetail.Location = new System.Drawing.Point(1074, 9);
            this.pbSeeDetail.Margin = new System.Windows.Forms.Padding(2);
            this.pbSeeDetail.Name = "pbSeeDetail";
            this.pbSeeDetail.Size = new System.Drawing.Size(30, 30);
            this.pbSeeDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSeeDetail.TabIndex = 19;
            this.pbSeeDetail.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(820, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(143, 25);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Recived Time";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(420, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(53, 25);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(150, 13);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(61, 25);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "From";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(21, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 25);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "1";
            // 
            // UCMailRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCMailRow";
            this.Size = new System.Drawing.Size(1146, 63);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeeDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.PictureBox pbSeeDetail;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblID;
    }
}
