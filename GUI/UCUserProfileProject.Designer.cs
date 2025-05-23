﻿namespace Find_Job_Management.GUI {
    partial class UCUserProfileProject {
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
            this.lblSeeProject = new Guna.UI.WinForms.GunaLinkLabel();
            this.pbDeleteProject = new System.Windows.Forms.PictureBox();
            this.pbEditProject = new System.Windows.Forms.PictureBox();
            this.lblEndDay = new Guna.UI.WinForms.GunaLabel();
            this.lblStartDay = new Guna.UI.WinForms.GunaLabel();
            this.lblNameProject = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditProject)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeeProject
            // 
            this.lblSeeProject.AutoSize = true;
            this.lblSeeProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSeeProject.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeeProject.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblSeeProject.Location = new System.Drawing.Point(8, 47);
            this.lblSeeProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeeProject.Name = "lblSeeProject";
            this.lblSeeProject.Size = new System.Drawing.Size(87, 19);
            this.lblSeeProject.TabIndex = 18;
            this.lblSeeProject.TabStop = true;
            this.lblSeeProject.Text = "See project";
            // 
            // pbDeleteProject
            // 
            this.pbDeleteProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDeleteProject.Image = global::Find_Job_Management.Properties.Resources.delete;
            this.pbDeleteProject.Location = new System.Drawing.Point(514, 9);
            this.pbDeleteProject.Margin = new System.Windows.Forms.Padding(2);
            this.pbDeleteProject.Name = "pbDeleteProject";
            this.pbDeleteProject.Size = new System.Drawing.Size(36, 23);
            this.pbDeleteProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDeleteProject.TabIndex = 17;
            this.pbDeleteProject.TabStop = false;
            // 
            // pbEditProject
            // 
            this.pbEditProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditProject.Image = global::Find_Job_Management.Properties.Resources.edit1;
            this.pbEditProject.Location = new System.Drawing.Point(474, 9);
            this.pbEditProject.Margin = new System.Windows.Forms.Padding(2);
            this.pbEditProject.Name = "pbEditProject";
            this.pbEditProject.Size = new System.Drawing.Size(36, 23);
            this.pbEditProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditProject.TabIndex = 16;
            this.pbEditProject.TabStop = false;
            // 
            // lblEndDay
            // 
            this.lblEndDay.AutoSize = true;
            this.lblEndDay.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDay.Location = new System.Drawing.Point(91, 30);
            this.lblEndDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDay.Name = "lblEndDay";
            this.lblEndDay.Size = new System.Drawing.Size(38, 17);
            this.lblEndDay.TabIndex = 15;
            this.lblEndDay.Text = "Now";
            // 
            // lblStartDay
            // 
            this.lblStartDay.AutoSize = true;
            this.lblStartDay.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDay.Location = new System.Drawing.Point(5, 30);
            this.lblStartDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDay.Name = "lblStartDay";
            this.lblStartDay.Size = new System.Drawing.Size(54, 17);
            this.lblStartDay.TabIndex = 14;
            this.lblStartDay.Text = "9-2022";
            // 
            // lblNameProject
            // 
            this.lblNameProject.AutoSize = true;
            this.lblNameProject.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProject.Location = new System.Drawing.Point(5, 9);
            this.lblNameProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameProject.Name = "lblNameProject";
            this.lblNameProject.Size = new System.Drawing.Size(161, 17);
            this.lblNameProject.TabIndex = 13;
            this.lblNameProject.Text = "Video viewing website";
            // 
            // UCUserProfileProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSeeProject);
            this.Controls.Add(this.pbDeleteProject);
            this.Controls.Add(this.pbEditProject);
            this.Controls.Add(this.lblEndDay);
            this.Controls.Add(this.lblStartDay);
            this.Controls.Add(this.lblNameProject);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCUserProfileProject";
            this.Size = new System.Drawing.Size(557, 75);
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLinkLabel lblSeeProject;
        public System.Windows.Forms.PictureBox pbDeleteProject;
        public System.Windows.Forms.PictureBox pbEditProject;
        private Guna.UI.WinForms.GunaLabel lblEndDay;
        private Guna.UI.WinForms.GunaLabel lblStartDay;
        private Guna.UI.WinForms.GunaLabel lblNameProject;
    }
}
