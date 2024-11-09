namespace MarshDatabase {
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
            System.Windows.Forms.TextBox TextBox1;
            System.Windows.Forms.TextBox TextBox2;
            this.FarmImage = new System.Windows.Forms.PictureBox();
            this.AutomatedItemTextBox = new System.Windows.Forms.TextBox();
            this.InputItemsTextBox = new System.Windows.Forms.TextBox();
            this.ShellClaimTextBox = new System.Windows.Forms.LinkLabel();
            this.CreatorNameTextBox = new System.Windows.Forms.LinkLabel();
            this.DatesDisplayTextBox = new System.Windows.Forms.TextBox();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            splitContainer3 = new System.Windows.Forms.SplitContainer();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            TextBox1 = new System.Windows.Forms.TextBox();
            TextBox2 = new System.Windows.Forms.TextBox();
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
            this.FarmImage.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(this.AutomatedItemTextBox);
            flowLayoutPanel1.Controls.Add(this.InputItemsTextBox);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(278, 382);
            // 
            // AutomatedItemTextBox
            // 
            this.AutomatedItemTextBox.AutoSize = true;
            this.AutomatedItemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutomatedItemTextBox.Location = new System.Drawing.Point(3, 0);
            this.AutomatedItemTextBox.Name = "AutomatedItemTextBox";
            this.AutomatedItemTextBox.Size = new System.Drawing.Size(181, 32);
            this.AutomatedItemTextBox.ReadOnly = true;
            this.AutomatedItemTextBox.Text = "PlaceHolder";
            // 
            // InputItemsTextBox
            // 
            this.InputItemsTextBox.AutoSize = true;
            this.InputItemsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputItemsTextBox.Location = new System.Drawing.Point(3, 32);
            this.InputItemsTextBox.Name = "InputItemsTextBox";
            this.InputItemsTextBox.Size = new System.Drawing.Size(181, 128);
            this.InputItemsTextBox.TabIndex = 1;
            this.InputItemsTextBox.Text = "\r\nPlaceHolder\r\nPlaceHolder\r\nPlaceHolder";
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
            splitContainer3.Panel2.Controls.Add(this.DatesDisplayTextBox);
            splitContainer3.Size = new System.Drawing.Size(839, 664);
            splitContainer3.SplitterDistance = 307;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(TextBox1);
            flowLayoutPanel2.Controls.Add(this.ShellClaimTextBox);
            flowLayoutPanel2.Controls.Add(TextBox2);
            flowLayoutPanel2.Controls.Add(this.CreatorNameTextBox);
            flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(307, 664);
            // 
            // TextBox1
            // 
            TextBox1.AutoSize = true;
            TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TextBox1.Location = new System.Drawing.Point(3, 0);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new System.Drawing.Size(179, 25);
            TextBox1.ReadOnly = true;
            TextBox1.Text = "Shell Claim Name: ";
            // 
            // ShellClaimTextBox
            // 
            this.ShellClaimTextBox.AutoSize = true;
            this.ShellClaimTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShellClaimTextBox.Location = new System.Drawing.Point(3, 25);
            this.ShellClaimTextBox.Name = "ShellClaimTextBox";
            this.ShellClaimTextBox.Size = new System.Drawing.Size(195, 38);
            this.ShellClaimTextBox.TabIndex = 1;
            this.ShellClaimTextBox.TabStop = true;
            this.ShellClaimTextBox.Text = "PlaceHolder\r\n";
            // 
            // TextBox2
            // 
            TextBox2.AutoSize = true;
            TextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TextBox2.Location = new System.Drawing.Point(3, 63);
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new System.Drawing.Size(145, 25);
            TextBox2.TabIndex = 2;
            TextBox2.Text = "Creator Name: ";
            // 
            // CreatorNameTextBox
            // 
            this.CreatorNameTextBox.AutoSize = true;
            this.CreatorNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatorNameTextBox.Location = new System.Drawing.Point(3, 88);
            this.CreatorNameTextBox.Name = "CreatorNameTextBox";
            this.CreatorNameTextBox.Size = new System.Drawing.Size(195, 38);
            this.CreatorNameTextBox.TabIndex = 3;
            this.CreatorNameTextBox.TabStop = true;
            this.CreatorNameTextBox.Text = "PlaceHolder\r\n";
            // 
            // DatesDisplayTextBox
            // 
            this.DatesDisplayTextBox.AutoSize = true;
            this.DatesDisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatesDisplayTextBox.Location = new System.Drawing.Point(2, 0);
            this.DatesDisplayTextBox.Name = "DatesDisplayTextBox";
            this.DatesDisplayTextBox.Size = new System.Drawing.Size(220, 190);
            this.DatesDisplayTextBox.ReadOnly = true;
            this.DatesDisplayTextBox.Text = "DateCreated: \r\nPlaceHolder\r\n\r\nDate Deleted:\r\nPlaceHolder";
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
        private System.Windows.Forms.TextBox AutomatedItemTextBox;
        private System.Windows.Forms.TextBox InputItemsTextBox;
        private System.Windows.Forms.LinkLabel ShellClaimTextBox;
        private System.Windows.Forms.LinkLabel CreatorNameTextBox;
        private System.Windows.Forms.TextBox DatesDisplayTextBox;
    }
}