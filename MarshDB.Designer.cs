using static MarshDatabase.PlayerView;
using static MarshDatabase.ClaimView;

namespace MarshDatabase {
    partial class MarshDB {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

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
            this.ClaimsSearchBox = new System.Windows.Forms.TextBox();
            this.PlayerViewSeperator = new System.Windows.Forms.SplitContainer();
            this.ViewSwapper = new System.Windows.Forms.TabControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ClaimSelect = new System.Windows.Forms.DataGridView();
            this.PlayerView = new PlayerView(NameSelect, ViewSwapper);
            this.ClaimView = new ClaimView(ClaimSelect, ViewSwapper);

            this.MainDataTabSelect.SuspendLayout();
            this.SearchMembersSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameSelect)).BeginInit();
            this.SearchClaimsSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerViewSeperator)).BeginInit();
            this.PlayerViewSeperator.Panel1.SuspendLayout();
            this.PlayerViewSeperator.Panel2.SuspendLayout();
            this.PlayerViewSeperator.SuspendLayout();
            this.ViewSwapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClaimSelect)).BeginInit();
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
            this.NameSelect.SelectionChanged += PlayerView.ShowPlayerData;
            // 
            // SearchClaimsSelect
            // 
            this.SearchClaimsSelect.Controls.Add(this.splitContainer1);
            this.SearchClaimsSelect.Location = new System.Drawing.Point(4, 25);
            this.SearchClaimsSelect.Name = "SearchClaimsSelect";
            this.SearchClaimsSelect.Padding = new System.Windows.Forms.Padding(3);
            this.SearchClaimsSelect.Size = new System.Drawing.Size(123, 551);
            this.SearchClaimsSelect.TabIndex = 1;
            this.SearchClaimsSelect.Text = "Claims";
            this.SearchClaimsSelect.UseVisualStyleBackColor = true;
            // 
            // ClaimsSearchBox
            // 
            this.ClaimsSearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClaimsSearchBox.Location = new System.Drawing.Point(0, 0);
            this.ClaimsSearchBox.Name = "ClaimsSearchBox";
            this.ClaimsSearchBox.Size = new System.Drawing.Size(26, 22);
            this.ClaimsSearchBox.TabIndex = 2;
            this.ClaimsSearchBox.TextChanged += new System.EventHandler(this.ClaimSearchChanged);
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
            this.ViewSwapper.Controls.Add((System.Windows.Forms.Control)this.PlayerView);
            this.ViewSwapper.Controls.Add((System.Windows.Forms.Control)this.ClaimView);
            this.ViewSwapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewSwapper.Location = new System.Drawing.Point(0, 0);
            this.ViewSwapper.Name = "ViewSwapper";
            this.ViewSwapper.SelectedIndex = 0;
            this.ViewSwapper.Size = new System.Drawing.Size(742, 580);
            this.ViewSwapper.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ClaimsSearchBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ClaimSelect);
            this.splitContainer1.Size = new System.Drawing.Size(117, 545);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 22);
            this.textBox1.TabIndex = 0;
            // 
            // ClaimSelect
            // 
            this.ClaimSelect.AllowUserToAddRows = false;
            this.ClaimSelect.AllowUserToDeleteRows = false;
            this.ClaimSelect.AllowUserToResizeColumns = false;
            this.ClaimSelect.AllowUserToResizeRows = false;
            this.ClaimSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClaimSelect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClaimSelect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ClaimSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClaimSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClaimSelect.DefaultCellStyle = dataGridViewCellStyle5;
            this.ClaimSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClaimSelect.Location = new System.Drawing.Point(0, 0);
            this.ClaimSelect.MultiSelect = false;
            this.ClaimSelect.Name = "ClaimSelect";
            this.ClaimSelect.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClaimSelect.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ClaimSelect.RowHeadersVisible = false;
            this.ClaimSelect.RowHeadersWidth = 65;
            this.ClaimSelect.RowTemplate.Height = 24;
            this.ClaimSelect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ClaimSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClaimSelect.ShowEditingIcon = false;
            this.ClaimSelect.Size = new System.Drawing.Size(117, 516);
            this.ClaimSelect.TabIndex = 1;
            this.ClaimSelect.SelectionChanged += ClaimView.ShowClaimData;
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
            this.PlayerViewSeperator.Panel1.ResumeLayout(false);
            this.PlayerViewSeperator.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerViewSeperator)).EndInit();
            this.PlayerViewSeperator.ResumeLayout(false);
            this.ViewSwapper.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClaimSelect)).EndInit();
            this.ResumeLayout(false);

        }

        private void ClaimSlect(object sender, System.EventArgs e) {
            throw new System.NotImplementedException();
        }

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
        private System.Windows.Forms.TextBox ClaimsSearchBox;
        private System.Windows.Forms.SplitContainer PlayerViewSeperator;
        private System.Windows.Forms.TabControl ViewSwapper;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView ClaimSelect;
        private IPlayerView PlayerView;
        private IClaimView ClaimView;
    }
}