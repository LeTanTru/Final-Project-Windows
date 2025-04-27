namespace Find_Job_Management.Utils {
    partial class DialogBox {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pblButtonGroup = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbState = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbState)).BeginInit();
            this.SuspendLayout();
            // 
            // pblButtonGroup
            // 
            this.pblButtonGroup.Location = new System.Drawing.Point(1, 186);
            this.pblButtonGroup.Name = "pblButtonGroup";
            this.pblButtonGroup.Size = new System.Drawing.Size(223, 48);
            this.pblButtonGroup.TabIndex = 7;
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMessage.Location = new System.Drawing.Point(6, 132);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(218, 51);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "label1";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(1, 103);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(223, 29);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "label1";
            // 
            // pbState
            // 
            this.pbState.Location = new System.Drawing.Point(1, 0);
            this.pbState.Name = "pbState";
            this.pbState.Size = new System.Drawing.Size(223, 100);
            this.pbState.TabIndex = 4;
            this.pbState.TabStop = false;
            // 
            // DialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 234);
            this.Controls.Add(this.pblButtonGroup);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbState);
            this.Name = "DialogBox";
            this.Text = "DialogBox";
            ((System.ComponentModel.ISupportInitialize)(this.pbState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pblButtonGroup;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbState;
    }
}