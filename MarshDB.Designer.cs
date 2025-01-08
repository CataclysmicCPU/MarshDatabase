using System;
using System.Drawing;
using System.Windows.Forms;
using static MarshDatabase.Program;

namespace MarshDatabase {
    partial class MarshDB {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.TabPage Players;
        private System.Windows.Forms.TabPage Claims;
        private System.Windows.Forms.TabPage Farms;
        private System.Windows.Forms.SplitContainer SearchSeperator;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.TabControl MainDataTabSelect;
        private System.Windows.Forms.TabPage SearchMembersSelect;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox PlayerSearch;
        private System.Windows.Forms.DataGridView PlayerSelect;
        private System.Windows.Forms.TabPage SearchClaimsSelect;
        private System.Windows.Forms.TextBox ClaimsSearchBox;
        private System.Windows.Forms.SplitContainer PlayerViewSeperator;
        private System.Windows.Forms.TabControl ViewSwapper;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView ClaimSelect;
        private System.Windows.Forms.TabPage SearchFarmsSelect;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox FarmSearchBox;
        private System.Windows.Forms.DataGridView FarmSelect;
        private Button CreatePlayerButton;
        private Button EditPlayerButton;
        private SplitContainer splitContainer4;
        private SplitContainer splitContainer5;
        private IFarmView FarmView;
        private IPlayerView PlayerView;
        private IClaimView ClaimView;

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarshDB));
            this.MainDataTabSelect = new System.Windows.Forms.TabControl();
            this.SearchMembersSelect = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.PlayerSearch = new System.Windows.Forms.TextBox();
            this.PlayerSelect = new System.Windows.Forms.DataGridView();
            this.SearchClaimsSelect = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ClaimsSearchBox = new System.Windows.Forms.TextBox();
            this.ClaimSelect = new System.Windows.Forms.DataGridView();
            this.PlayerViewSeperator = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchFarmsSelect = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.FarmSearchBox = new System.Windows.Forms.TextBox();
            this.FarmSelect = new System.Windows.Forms.DataGridView();
            this.ViewSwapper = new System.Windows.Forms.TabControl();
            this.CreatePlayerButton = new System.Windows.Forms.Button();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.EditPlayerButton = new System.Windows.Forms.Button();
            this.FarmView = new FarmView(FarmSelect, ViewSwapper);
            this.ClaimView = new ClaimView(ClaimSelect, ViewSwapper);
            this.PlayerView = new PlayerView(PlayerSelect, ViewSwapper);

            this.MainDataTabSelect.SuspendLayout();
            this.SearchMembersSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSelect)).BeginInit();
            this.SearchClaimsSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClaimSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerViewSeperator)).BeginInit();
            this.PlayerViewSeperator.Panel1.SuspendLayout();
            this.PlayerViewSeperator.Panel2.SuspendLayout();
            this.PlayerViewSeperator.SuspendLayout();
            this.ViewSwapper.SuspendLayout();
            this.SearchFarmsSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FarmSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // MainDataTabSelect
            // 
            this.MainDataTabSelect.Controls.Add(this.SearchMembersSelect);
            this.MainDataTabSelect.Controls.Add(this.SearchClaimsSelect);
            this.MainDataTabSelect.Controls.Add(this.SearchFarmsSelect);
            this.MainDataTabSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDataTabSelect.Location = new System.Drawing.Point(0, 0);
            this.MainDataTabSelect.Name = "MainDataTabSelect";
            this.MainDataTabSelect.SelectedIndex = 0;
            this.MainDataTabSelect.Size = new System.Drawing.Size(131, 580);
            this.MainDataTabSelect.Font = new System.Drawing.Font(font.Families[0], 6.8F);
            this.MainDataTabSelect.Selected += ClearSelction;
            // 
            // SearchMembersSelect
            // 
            this.SearchMembersSelect.Controls.Add(this.splitContainer2);
            this.SearchMembersSelect.Location = new System.Drawing.Point(4, 25);
            this.SearchMembersSelect.Name = "SearchMembersSelect";
            this.SearchMembersSelect.Padding = new System.Windows.Forms.Padding(3);
            this.SearchMembersSelect.Size = new System.Drawing.Size(123, 551);
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
            this.splitContainer2.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); 
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.PlayerSearch);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
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
            this.PlayerSearch.TabIndex = 999;
            this.PlayerSearch.BorderStyle = BorderStyle.FixedSingle;
            this.PlayerSearch.Font = new System.Drawing.Font(font.Families[0], 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerSearch.TextChanged += new System.EventHandler(this.PlayerSearchChanged);
            //
            //CreatePlayerButton
            //
            this.CreatePlayerButton.Dock = DockStyle.Fill;
            this.CreatePlayerButton.AutoSize = true;
            this.CreatePlayerButton.Name = "CreatePlayerButton";
            this.CreatePlayerButton.Size = new Size(150, 23);
            this.CreatePlayerButton.Padding = new Padding(4);
            this.CreatePlayerButton.Font = new Font(font.Families[0], 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePlayerButton.Text = "Create Player";
            this.CreatePlayerButton.Click += Login;
            //
            //EditPlayerButton
            //
            this.EditPlayerButton.Dock = DockStyle.Fill;
            this.EditPlayerButton.AutoSize = true;
            this.EditPlayerButton.Name = "EditPlayerButton";
            this.EditPlayerButton.Size = new Size(150, 23);
            this.EditPlayerButton.Padding = new Padding(4);
            this.EditPlayerButton.Font = new Font(font.Families[0], 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPlayerButton.Text = "Edit Selected Player";
            this.EditPlayerButton.Click += Login;
            //
            //splitContainer4
            //
            this.splitContainer4.Dock = DockStyle.Fill;
            this.splitContainer4.Orientation = Orientation.Horizontal;
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);

            this.splitContainer4.Panel1.Controls.Add(this.PlayerSelect);
            this.splitContainer4.Panel2MinSize = 0;
            this.splitContainer4.SplitterDistance = 200;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Panel2.Size = new Size(150, 21);
            //
            //splitContainer5
            //
            this.splitContainer5.Dock = DockStyle.Fill;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.SplitterDistance = splitContainer5.Width/2;
            this.splitContainer5.Panel1.Controls.Add(this.CreatePlayerButton);
            this.splitContainer5.Panel2.Controls.Add(this.EditPlayerButton);
            // 
            // NameSelect
            // 
            this.PlayerSelect.AllowUserToAddRows = false;
            this.PlayerSelect.AllowUserToDeleteRows = false;
            this.PlayerSelect.AllowUserToResizeColumns = false;
            this.PlayerSelect.AllowUserToResizeRows = false;
            this.PlayerSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PlayerSelect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font(font.Families[0], 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PlayerSelect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PlayerSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font(font.Families[0], 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PlayerSelect.DefaultCellStyle = dataGridViewCellStyle2;
            this.PlayerSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayerSelect.Location = new System.Drawing.Point(0, 0);
            this.PlayerSelect.MultiSelect = false;
            this.PlayerSelect.Name = "NameSelect";
            this.PlayerSelect.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font(font.Families[0], 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PlayerSelect.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PlayerSelect.RowHeadersVisible = false;
            this.PlayerSelect.RowHeadersWidth = 65;
            this.PlayerSelect.RowTemplate.Height = 24;
            this.PlayerSelect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PlayerSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PlayerSelect.ShowEditingIcon = false;
            this.PlayerSelect.Size = new System.Drawing.Size(117, 999);
            this.PlayerSelect.ReadOnly = true;
            this.PlayerSelect.SelectionChanged += PlayerView.ShowPlayerData;
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
            this.splitContainer1.SplitterDistance = 20;
            // 
            // ClaimsSearchBox
            // 
            this.ClaimsSearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClaimsSearchBox.Location = new System.Drawing.Point(0, 0);
            this.ClaimsSearchBox.Name = "ClaimsSearchBox";
            this.ClaimsSearchBox.Size = new System.Drawing.Size(117, 20);
            this.ClaimsSearchBox.TabIndex = 999;
            this.ClaimsSearchBox.BorderStyle = BorderStyle.FixedSingle;
            this.ClaimsSearchBox.Font = new Font(font.Families[0], 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaimsSearchBox.TextChanged += new System.EventHandler(this.ClaimSearchChanged);
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
            dataGridViewCellStyle4.Font = new System.Drawing.Font(font.Families[0], 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClaimSelect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ClaimSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClaimSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font(font.Families[0], 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle6.Font = new System.Drawing.Font(font.Families[0], 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.PlayerViewSeperator.SplitterDistance = 180;
            this.PlayerViewSeperator.TabIndex = 2;
            // 
            // ViewSwapper
            // 
            this.ViewSwapper.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.ViewSwapper.Controls.Add((System.Windows.Forms.Control)this.PlayerView);
            this.ViewSwapper.Controls.Add((System.Windows.Forms.Control)this.ClaimView);
            this.ViewSwapper.Controls.Add((System.Windows.Forms.Control)this.FarmView);
            this.ViewSwapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewSwapper.ItemSize = new System.Drawing.Size(0, 1);
            this.ViewSwapper.Location = new System.Drawing.Point(0, 0);
            this.ViewSwapper.Name = "ViewSwapper";
            this.ViewSwapper.SelectedIndex = 0;
            this.ViewSwapper.Size = new System.Drawing.Size(742, 580);
            this.ViewSwapper.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 22);
            this.textBox1.ReadOnly = true;
            this.textBox1.BorderStyle = 0;
            // 
            // tabPage1
            // 
            this.SearchFarmsSelect.Controls.Add(this.splitContainer3);
            this.SearchFarmsSelect.Location = new System.Drawing.Point(4, 25);
            this.SearchFarmsSelect.Name = "SearchFarmsSelect";
            this.SearchFarmsSelect.Padding = new System.Windows.Forms.Padding(3);
            this.SearchFarmsSelect.Size = new System.Drawing.Size(123, 551);
            this.SearchFarmsSelect.TabIndex = 2;
            this.SearchFarmsSelect.Text = "Farms";
            this.SearchFarmsSelect.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.FarmSearchBox);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.FarmSelect);
            this.splitContainer3.Size = new System.Drawing.Size(117, 545);
            this.splitContainer3.SplitterDistance = 25;
            this.splitContainer3.TabIndex = 1;
            // 
            // FarmSearchBox
            // 
            this.FarmSearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FarmSearchBox.Location = new System.Drawing.Point(0, 0);
            this.FarmSearchBox.Name = "FarmSearchBox";
            this.FarmSearchBox.Size = new System.Drawing.Size(117, 22);
            this.FarmSearchBox.TabIndex = 999;
            this.FarmSearchBox.BorderStyle = BorderStyle.FixedSingle;
            this.FarmSearchBox.Font = new System.Drawing.Font(font.Families[0], 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FarmSearchBox.TextChanged += new EventHandler(this.FarmSearchChanged);
            // 
            // FarmSelect
            // 
            this.FarmSelect.AllowUserToAddRows = false;
            this.FarmSelect.AllowUserToDeleteRows = false;
            this.FarmSelect.AllowUserToResizeColumns = false;
            this.FarmSelect.AllowUserToResizeRows = false;
            this.FarmSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FarmSelect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font(font.Families[0], 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FarmSelect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.FarmSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FarmSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font(font.Families[0], 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FarmSelect.DefaultCellStyle = dataGridViewCellStyle8;
            this.FarmSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FarmSelect.Location = new System.Drawing.Point(0, 0);
            this.FarmSelect.MultiSelect = false;
            this.FarmSelect.Name = "FarmSelect";
            this.FarmSelect.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font(font.Families[0], 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FarmSelect.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.FarmSelect.RowHeadersVisible = false;
            this.FarmSelect.RowHeadersWidth = 65;
            this.FarmSelect.RowTemplate.Height = 24;
            this.FarmSelect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FarmSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FarmSelect.ShowEditingIcon = false;
            this.FarmSelect.Size = new System.Drawing.Size(117, 516);
            this.FarmSelect.TabIndex = 1;
            this.FarmSelect.SelectionChanged += FarmView.ShowFarmData;
            // 
            // MarshDB
            // 
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque, true);
            this.ClientSize = new System.Drawing.Size(877, 580);
            this.Controls.Add(this.PlayerViewSeperator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MarshDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marsh Database";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.MainDataTabSelect.ResumeLayout(false);
            this.SearchMembersSelect.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSelect)).EndInit();
            this.SearchClaimsSelect.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClaimSelect)).EndInit();
            this.PlayerViewSeperator.Panel1.ResumeLayout(false);
            this.PlayerViewSeperator.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerViewSeperator)).EndInit();
            this.PlayerViewSeperator.ResumeLayout(false);
            this.ViewSwapper.ResumeLayout(false);
            this.SearchFarmsSelect.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FarmSelect)).EndInit();
            Application.Idle += ApplicationIdle;
            this.ResumeLayout(false);
        }

        private void ApplicationIdle(object sender, EventArgs e) {
            if (FarmView.getPlayerSwapName() != null || ClaimView.getPlayerSwapName() != null) {
                SwapToPlayer();
            }
            if (FarmView.getClaimSwapName() != null || PlayerView.GetClaimSwapName() != null) {
                SwapToClaim();
            }
            if (PlayerView.GetFarmNameSwap() != null) {
                SwapToFarm();
            }
            if (GlobalEvents == "RefreshSelectionTables") { 
                RefreshSelectionTables();
                GlobalEvents = "";
            }
        }

        private void SwapToPlayer() {
            foreach (DataGridViewRow row in PlayerSelect.Rows) {
                if (row.Cells[0].Value.ToString() == FarmView.getPlayerSwapName() || row.Cells[0].Value.ToString() == ClaimView.getPlayerSwapName()) { 
                    PlayerSelect.Rows[row.Index].Selected = true; 
                }
            }
            ViewSwapper.SelectedIndex = 0;
            FarmView.setPlayerSwapName(null);
            ClaimView.setPlayerSwapName(null);
        }

        private void SwapToClaim() {
            foreach (DataGridViewRow row in ClaimSelect.Rows) {
                if (row.Cells[0].Value.ToString() == FarmView.getClaimSwapName() || row.Cells[0].Value.ToString() == PlayerView.GetClaimSwapName()) {
                    ClaimSelect.Rows[row.Index].Selected = true;
                }
            }
            ViewSwapper.SelectedIndex = 1;
            FarmView.setClaimSwapName(null);
            PlayerView.SetClaimNameSwap(null);
        }

        private void SwapToFarm() {
            foreach (DataGridViewRow row in FarmSelect.Rows) {
                if (row.Cells[0].Value.ToString() == PlayerView.GetFarmNameSwap()) {
                    FarmSelect.Rows[row.Index].Selected = true;
                }
            }
            ViewSwapper.SelectedIndex = 2;
            this.PlayerView.SetFarmNameSwap(null);
        }
    }
}