﻿namespace MarshDatabase {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            System.Windows.Forms.SplitContainer splitContainer1;
            System.Windows.Forms.SplitContainer splitContainer2;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            System.Windows.Forms.SplitContainer splitContainer3;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.FarmImage = new System.Windows.Forms.PictureBox();
            this.AutomatedItemLabel = new System.Windows.Forms.Label();
            this.InputItemsLabel = new System.Windows.Forms.Label();
            this.ShellClaimLabel = new System.Windows.Forms.LinkLabel();
            this.CreatorNameLabel = new System.Windows.Forms.LinkLabel();
            this.DatesDisplayLabel = new System.Windows.Forms.Label();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            splitContainer3 = new System.Windows.Forms.SplitContainer();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainer2)).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FarmImage)).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainer3)).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer3);
            splitContainer1.Size = new System.Drawing.Size(1121, 664);
            splitContainer1.SplitterDistance = 278;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new System.Drawing.Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(this.FarmImage);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer2.Size = new System.Drawing.Size(278, 664);
            splitContainer2.SplitterDistance = 278;
            splitContainer2.TabIndex = 0;
            // 
            // FarmImage
            // 
            this.FarmImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FarmImage.ErrorImage = global::MarshDatabase.Properties.Resources.MarshLogo;
            this.FarmImage.Image = global::MarshDatabase.Properties.Resources.MarshLogo;
            this.FarmImage.Location = new System.Drawing.Point(0, 0);
            this.FarmImage.Name = "FarmImage";
            this.FarmImage.Size = new System.Drawing.Size(278, 278);
            this.FarmImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FarmImage.TabIndex = 0;
            this.FarmImage.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(this.AutomatedItemLabel);
            flowLayoutPanel1.Controls.Add(this.InputItemsLabel);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(278, 382);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // AutomatedItemLabel
            // 
            this.AutomatedItemLabel.AutoSize = true;
            this.AutomatedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutomatedItemLabel.Location = new System.Drawing.Point(3, 0);
            this.AutomatedItemLabel.Name = "AutomatedItemLabel";
            this.AutomatedItemLabel.Size = new System.Drawing.Size(181, 32);
            this.AutomatedItemLabel.TabIndex = 0;
            this.AutomatedItemLabel.Text = "PlaceHolder";
            // 
            // InputItemsLabel
            // 
            this.InputItemsLabel.AutoSize = true;
            this.InputItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputItemsLabel.Location = new System.Drawing.Point(3, 32);
            this.InputItemsLabel.Name = "InputItemsLabel";
            this.InputItemsLabel.Size = new System.Drawing.Size(181, 128);
            this.InputItemsLabel.TabIndex = 1;
            this.InputItemsLabel.Text = "\r\nPlaceHolder\r\nPlaceHolder\r\nPlaceHolder";
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer3.Location = new System.Drawing.Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(flowLayoutPanel2);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(this.DatesDisplayLabel);
            splitContainer3.Size = new System.Drawing.Size(839, 664);
            splitContainer3.SplitterDistance = 307;
            splitContainer3.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(this.ShellClaimLabel);
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(this.CreatorNameLabel);
            flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(307, 664);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(179, 25);
            label1.TabIndex = 0;
            label1.Text = "Shell Claim Name: ";
            // 
            // ShellClaimLabel
            // 
            this.ShellClaimLabel.AutoSize = true;
            this.ShellClaimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShellClaimLabel.Location = new System.Drawing.Point(3, 25);
            this.ShellClaimLabel.Name = "ShellClaimLabel";
            this.ShellClaimLabel.Size = new System.Drawing.Size(195, 38);
            this.ShellClaimLabel.TabIndex = 1;
            this.ShellClaimLabel.TabStop = true;
            this.ShellClaimLabel.Text = "PlaceHolder\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(3, 63);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(145, 25);
            label2.TabIndex = 2;
            label2.Text = "Creator Name: ";
            // 
            // CreatorNameLabel
            // 
            this.CreatorNameLabel.AutoSize = true;
            this.CreatorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatorNameLabel.Location = new System.Drawing.Point(3, 88);
            this.CreatorNameLabel.Name = "CreatorNameLabel";
            this.CreatorNameLabel.Size = new System.Drawing.Size(195, 38);
            this.CreatorNameLabel.TabIndex = 3;
            this.CreatorNameLabel.TabStop = true;
            this.CreatorNameLabel.Text = "PlaceHolder\r\n";
            // 
            // DatesDisplayLabel
            // 
            this.DatesDisplayLabel.AutoSize = true;
            this.DatesDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatesDisplayLabel.Location = new System.Drawing.Point(2, 0);
            this.DatesDisplayLabel.Name = "DatesDisplayLabel";
            this.DatesDisplayLabel.Size = new System.Drawing.Size(220, 190);
            this.DatesDisplayLabel.TabIndex = 0;
            this.DatesDisplayLabel.Text = "DateCreated: \r\nPlaceHolder\r\n\r\nDate Deleted:\r\nPlaceHolder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 664);
            this.Controls.Add(splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer2)).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FarmImage)).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainer3)).EndInit();
            splitContainer3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FarmImage;
        private System.Windows.Forms.Label AutomatedItemLabel;
        private System.Windows.Forms.Label InputItemsLabel;
        private System.Windows.Forms.LinkLabel ShellClaimLabel;
        private System.Windows.Forms.LinkLabel CreatorNameLabel;
        private System.Windows.Forms.Label DatesDisplayLabel;
    }
}