using static MarshDatabase.PlayerView;

namespace MarshDatabase {
    partial class MarshDB {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarshDB));
            this.MainDataTabSelect = new System.Windows.Forms.TabControl();
            this.SearchMembersSelect = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.PlayerSearch = new System.Windows.Forms.TextBox();
            this.NameSelect = new System.Windows.Forms.DataGridView();
            this.SearchClaimsSelect = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.ClaimsSearchBox = new System.Windows.Forms.TextBox();
            this.ClaimsSearchSelect = new System.Windows.Forms.DataGridView();
            this.PlayerViewSeperator = new System.Windows.Forms.SplitContainer();
            this.ViewSwapper = new System.Windows.Forms.TabControl();
            this.ClaimsView = new System.Windows.Forms.TabPage();
            this.MainDataTabSelect.SuspendLayout();
            this.SearchMembersSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameSelect)).BeginInit();
            this.SearchClaimsSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClaimsSearchSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerViewSeperator)).BeginInit();
            this.PlayerViewSeperator.Panel1.SuspendLayout();
            this.PlayerViewSeperator.Panel2.SuspendLayout();
            this.PlayerViewSeperator.SuspendLayout();
            this.ViewSwapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainDataTabSelect
            // 
            this.MainDataTabSelect.Controls.Add(this.SearchMembersSelect);
            this.MainDataTabSelect.Controls.Add(this.SearchClaimsSelect);
            this.MainDataTabSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDataTabSelect.Location = new System.Drawing.Point(0, 0);
            this.MainDataTabSelect.Name = "MainDataTabSelect";
            this.MainDataTabSelect.SelectedIndex = 0;
            this.MainDataTabSelect.Size = new System.Drawing.Size(131, 580);
            this.MainDataTabSelect.TabIndex = 0;
            // 
            // SearchMembersSelect
            // 
            this.SearchMembersSelect.Controls.Add(this.splitContainer2);
            this.SearchMembersSelect.Location = new System.Drawing.Point(4, 25);
            this.SearchMembersSelect.Name = "SearchMembersSelect";
            this.SearchMembersSelect.Padding = new System.Windows.Forms.Padding(3);
            this.SearchMembersSelect.Size = new System.Drawing.Size(123, 551);
            this.SearchMembersSelect.TabIndex = 0;
            this.SearchMembersSelect.Text = "Players";
            this.SearchMembersSelect.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.PlayerSearch);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.NameSelect);
            this.splitContainer2.Size = new System.Drawing.Size(117, 545);
            this.splitContainer2.SplitterDistance = 26;
            this.splitContainer2.TabIndex = 1;
            // 
            // PlayerSearch
            // 
            this.PlayerSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayerSearch.Location = new System.Drawing.Point(0, 0);
            this.PlayerSearch.Name = "PlayerSearch";
            this.PlayerSearch.Size = new System.Drawing.Size(117, 22);
            this.PlayerSearch.TabIndex = 2;
            this.PlayerSearch.TextChanged += new System.EventHandler(this.ShowPlayerData);
            // 
            // NameSelect
            // 
            this.NameSelect.AllowUserToAddRows = false;
            this.NameSelect.AllowUserToDeleteRows = false;
            this.NameSelect.AllowUserToResizeColumns = false;
            this.NameSelect.AllowUserToResizeRows = false;
            this.NameSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NameSelect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NameSelect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.NameSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NameSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NameSelect.DefaultCellStyle = dataGridViewCellStyle2;
            this.NameSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameSelect.Location = new System.Drawing.Point(0, 0);
            this.NameSelect.MultiSelect = false;
            this.NameSelect.Name = "NameSelect";
            this.NameSelect.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NameSelect.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.NameSelect.RowHeadersVisible = false;
            this.NameSelect.RowHeadersWidth = 65;
            this.NameSelect.RowTemplate.Height = 24;
            this.NameSelect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NameSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NameSelect.ShowEditingIcon = false;
            this.NameSelect.Size = new System.Drawing.Size(117, 515);
            this.NameSelect.TabIndex = 0;
            // 
            // PlayerView
            // 
            this.PlayerView.Location = new System.Drawing.Point(4, 25);
            this.PlayerView.Name = "PlayerView";
            this.PlayerView.Padding = new System.Windows.Forms.Padding(3);
            this.PlayerView.Size = new System.Drawing.Size(734, 551);
            this.PlayerView.TabIndex = 0;
            this.PlayerView.Text = "PlayerView";
            this.PlayerView.UseVisualStyleBackColor = true;
            // 
            // SearchClaimsSelect
            // 
            this.SearchClaimsSelect.Controls.Add(this.splitContainer6);
            this.SearchClaimsSelect.Location = new System.Drawing.Point(4, 25);
            this.SearchClaimsSelect.Name = "SearchClaimsSelect";
            this.SearchClaimsSelect.Padding = new System.Windows.Forms.Padding(3);
            this.SearchClaimsSelect.Size = new System.Drawing.Size(123, 551);
            this.SearchClaimsSelect.TabIndex = 1;
            this.SearchClaimsSelect.Text = "Claims";
            this.SearchClaimsSelect.UseVisualStyleBackColor = true;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.IsSplitterFixed = true;
            this.splitContainer6.Location = new System.Drawing.Point(3, 3);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.ClaimsSearchBox);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.ClaimsSearchSelect);
            this.splitContainer6.Size = new System.Drawing.Size(117, 545);
            this.splitContainer6.SplitterDistance = 26;
            this.splitContainer6.TabIndex = 1;
            // 
            // ClaimsSearchBox
            // 
            this.ClaimsSearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClaimsSearchBox.Location = new System.Drawing.Point(0, 0);
            this.ClaimsSearchBox.Name = "ClaimsSearchBox";
            this.ClaimsSearchBox.Size = new System.Drawing.Size(117, 22);
            this.ClaimsSearchBox.TabIndex = 2;
            // 
            // ClaimsSearchSelect
            // 
            this.ClaimsSearchSelect.AllowUserToAddRows = false;
            this.ClaimsSearchSelect.AllowUserToDeleteRows = false;
            this.ClaimsSearchSelect.AllowUserToResizeColumns = false;
            this.ClaimsSearchSelect.AllowUserToResizeRows = false;
            this.ClaimsSearchSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClaimsSearchSelect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClaimsSearchSelect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ClaimsSearchSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClaimsSearchSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClaimsSearchSelect.DefaultCellStyle = dataGridViewCellStyle5;
            this.ClaimsSearchSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClaimsSearchSelect.Location = new System.Drawing.Point(0, 0);
            this.ClaimsSearchSelect.MultiSelect = false;
            this.ClaimsSearchSelect.Name = "ClaimsSearchSelect";
            this.ClaimsSearchSelect.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClaimsSearchSelect.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ClaimsSearchSelect.RowHeadersVisible = false;
            this.ClaimsSearchSelect.RowHeadersWidth = 65;
            this.ClaimsSearchSelect.RowTemplate.Height = 24;
            this.ClaimsSearchSelect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ClaimsSearchSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClaimsSearchSelect.ShowEditingIcon = false;
            this.ClaimsSearchSelect.Size = new System.Drawing.Size(117, 515);
            this.ClaimsSearchSelect.TabIndex = 0;
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
            this.PlayerViewSeperator.Panel1.Controls.Add(this.MainDataTabSelect);
            // 
            // PlayerViewSeperator.Panel2
            // 
            this.PlayerViewSeperator.Panel2.Controls.Add(this.ViewSwapper);
            this.PlayerViewSeperator.Size = new System.Drawing.Size(877, 580);
            this.PlayerViewSeperator.SplitterDistance = 131;
            this.PlayerViewSeperator.TabIndex = 2;
            // 
            // ViewSwapper
            // 
            this.ViewSwapper.Controls.Add(this.PlayerView);
            this.ViewSwapper.Controls.Add(this.ClaimsView);
            this.ViewSwapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewSwapper.Location = new System.Drawing.Point(0, 0);
            this.ViewSwapper.Name = "ViewSwapper";
            this.ViewSwapper.SelectedIndex = 0;
            this.ViewSwapper.Size = new System.Drawing.Size(742, 580);
            this.ViewSwapper.TabIndex = 0;
            // 
            // ClaimsView
            // 
            this.ClaimsView.Location = new System.Drawing.Point(4, 25);
            this.ClaimsView.Name = "ClaimsView";
            this.ClaimsView.Padding = new System.Windows.Forms.Padding(3);
            this.ClaimsView.Size = new System.Drawing.Size(734, 551);
            this.ClaimsView.TabIndex = 1;
            this.ClaimsView.Text = "ClaimsView";
            this.ClaimsView.UseVisualStyleBackColor = true;
            // 
            // MarshDB
            // 
            this.ClientSize = new System.Drawing.Size(877, 580);
            this.Controls.Add(this.PlayerViewSeperator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MarshDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marsh Database";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainDataTabSelect.ResumeLayout(false);
            this.SearchMembersSelect.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NameSelect)).EndInit();
            this.SearchClaimsSelect.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClaimsSearchSelect)).EndInit();
            this.PlayerViewSeperator.Panel1.ResumeLayout(false);
            this.PlayerViewSeperator.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerViewSeperator)).EndInit();
            this.PlayerViewSeperator.ResumeLayout(false);
            this.ViewSwapper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Players;
        private System.Windows.Forms.TabPage Claims;
        private System.Windows.Forms.TabPage Farms;
        private System.Windows.Forms.SplitContainer SearchSeperator;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.TabControl MainDataTabSelect;
        private System.Windows.Forms.TabPage SearchMembersSelect;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox PlayerSearch;
        private System.Windows.Forms.DataGridView NameSelect;
        private System.Windows.Forms.TabPage SearchClaimsSelect;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.TextBox ClaimsSearchBox;
        private System.Windows.Forms.DataGridView ClaimsSearchSelect;
        private System.Windows.Forms.SplitContainer PlayerViewSeperator;
        private System.Windows.Forms.TabControl ViewSwapper;
        private System.Windows.Forms.TabPage ClaimsView;
        private PlayerView PlayerView;
    }
}