namespace MarshDatabase
{
    partial class ReadData
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadData));
            this.ReadSelector = new System.Windows.Forms.TabControl();
            this.Players_Tab = new System.Windows.Forms.TabPage();
            this.PlayersSeperator = new System.Windows.Forms.SplitContainer();
            this.PlayersSearchBox = new System.Windows.Forms.TextBox();
            this.PlayerViewSeperator = new System.Windows.Forms.SplitContainer();
            this.Claims_Tab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.marshDataSet = new MarshDatabase.MarshDataSet();
            this.marshDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReadSelector.SuspendLayout();
            this.Players_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersSeperator)).BeginInit();
            this.PlayersSeperator.Panel1.SuspendLayout();
            this.PlayersSeperator.Panel2.SuspendLayout();
            this.PlayersSeperator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerViewSeperator)).BeginInit();
            this.PlayerViewSeperator.Panel1.SuspendLayout();
            this.PlayerViewSeperator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marshDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marshDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadSelector
            // 
            this.ReadSelector.Controls.Add(this.Players_Tab);
            this.ReadSelector.Controls.Add(this.Claims_Tab);
            this.ReadSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReadSelector.Location = new System.Drawing.Point(0, 0);
            this.ReadSelector.Name = "ReadSelector";
            this.ReadSelector.SelectedIndex = 0;
            this.ReadSelector.Size = new System.Drawing.Size(877, 580);
            this.ReadSelector.TabIndex = 0;
            // 
            // Players_Tab
            // 
            this.Players_Tab.Controls.Add(this.PlayersSeperator);
            this.Players_Tab.Location = new System.Drawing.Point(4, 25);
            this.Players_Tab.Name = "Players_Tab";
            this.Players_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Players_Tab.Size = new System.Drawing.Size(869, 551);
            this.Players_Tab.TabIndex = 0;
            this.Players_Tab.Text = "Players";
            this.Players_Tab.UseVisualStyleBackColor = true;
            // 
            // PlayersSeperator
            // 
            this.PlayersSeperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayersSeperator.Location = new System.Drawing.Point(3, 3);
            this.PlayersSeperator.Name = "PlayersSeperator";
            this.PlayersSeperator.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // PlayersSeperator.Panel1
            // 
            this.PlayersSeperator.Panel1.Controls.Add(this.PlayersSearchBox);
            // 
            // PlayersSeperator.Panel2
            // 
            this.PlayersSeperator.Panel2.Controls.Add(this.PlayerViewSeperator);
            this.PlayersSeperator.Size = new System.Drawing.Size(863, 545);
            this.PlayersSeperator.SplitterDistance = 25;
            this.PlayersSeperator.TabIndex = 0;
            // 
            // PlayersSearchBox
            // 
            this.PlayersSearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayersSearchBox.Location = new System.Drawing.Point(0, 0);
            this.PlayersSearchBox.Name = "PlayersSearchBox";
            this.PlayersSearchBox.Size = new System.Drawing.Size(863, 22);
            this.PlayersSearchBox.TabIndex = 0;
            // 
            // PlayerViewSeperator
            // 
            this.PlayerViewSeperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayerViewSeperator.IsSplitterFixed = true;
            this.PlayerViewSeperator.Location = new System.Drawing.Point(0, 0);
            this.PlayerViewSeperator.Name = "PlayerViewSeperator";
            // 
            // PlayerViewSeperator.Panel1
            // 
            this.PlayerViewSeperator.Panel1.AutoScroll = true;
            this.PlayerViewSeperator.Panel1.Controls.Add(this.dataGridView1);
            this.PlayerViewSeperator.Size = new System.Drawing.Size(863, 516);
            this.PlayerViewSeperator.SplitterDistance = 129;
            this.PlayerViewSeperator.TabIndex = 0;
            // 
            // Claims_Tab
            // 
            this.Claims_Tab.Location = new System.Drawing.Point(4, 25);
            this.Claims_Tab.Name = "Claims_Tab";
            this.Claims_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Claims_Tab.Size = new System.Drawing.Size(869, 551);
            this.Claims_Tab.TabIndex = 1;
            this.Claims_Tab.Text = "Claims";
            this.Claims_Tab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.marshDataSetBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(129, 516);
            this.dataGridView1.TabIndex = 0;
            // 
            // marshDataSet
            // 
            this.marshDataSet.DataSetName = "MarshDataSet";
            this.marshDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marshDataSetBindingSource
            // 
            this.marshDataSetBindingSource.DataSource = this.marshDataSet;
            this.marshDataSetBindingSource.Position = 0;
            // 
            // ReadData
            // 
            this.ClientSize = new System.Drawing.Size(877, 580);
            this.Controls.Add(this.ReadSelector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ReadData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marsh Database - Read Data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReadData_Load);
            this.ReadSelector.ResumeLayout(false);
            this.Players_Tab.ResumeLayout(false);
            this.PlayersSeperator.Panel1.ResumeLayout(false);
            this.PlayersSeperator.Panel1.PerformLayout();
            this.PlayersSeperator.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayersSeperator)).EndInit();
            this.PlayersSeperator.ResumeLayout(false);
            this.PlayerViewSeperator.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerViewSeperator)).EndInit();
            this.PlayerViewSeperator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marshDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marshDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Players;
        private System.Windows.Forms.TabPage Claims;
        private System.Windows.Forms.TabPage Farms;
        private System.Windows.Forms.SplitContainer SearchSeperator;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.TabControl ReadSelector;
        private System.Windows.Forms.TabPage Players_Tab;
        private System.Windows.Forms.TabPage Claims_Tab;
        private System.Windows.Forms.SplitContainer PlayersSeperator;
        private System.Windows.Forms.TextBox PlayersSearchBox;
        private System.Windows.Forms.SplitContainer PlayerViewSeperator;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource marshDataSetBindingSource;
        private MarshDataSet marshDataSet;
    }
}