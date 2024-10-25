using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static MarshDatabase.Program;

namespace MarshDatabase {

    public interface IPlayerView {
        void ShowPlayerData(object sender, EventArgs e);
    }

    internal class PlayerView : TabPage, IPlayerView {
        public PlayerView(DataGridView NameSelectPass, TabControl viewSelectorPass) {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NameSelect = NameSelectPass;
            this.ViewSelector = viewSelectorPass;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.QuitReasonLabel = new System.Windows.Forms.Label();
            this.JoinDateLabel = new System.Windows.Forms.Label();
            this.PlayerInfoLabel = new System.Windows.Forms.Label();
            this.QuitDateLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.DiscordNameDisplay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FlatnetNameDisplay = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ClaimsSelect = new System.Windows.Forms.DataGridView();
            this.Claim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FarmSelect = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolesTable = new System.Windows.Forms.DataGridView();
            this.RolesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClaimsSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FarmSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(921, 652);
            this.splitContainer1.SplitterDistance = 360;
            this.splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.89041F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.10959F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(921, 360);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.QuitReasonLabel, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.JoinDateLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.PlayerInfoLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.QuitDateLabel, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(425, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(493, 354);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // QuitReasonLabel
            // 
            this.QuitReasonLabel.AutoSize = true;
            this.QuitReasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitReasonLabel.Location = new System.Drawing.Point(3, 169);
            this.QuitReasonLabel.Name = "QuitReasonLabel";
            this.QuitReasonLabel.Size = new System.Drawing.Size(138, 25);
            this.QuitReasonLabel.TabIndex = 8;
            this.QuitReasonLabel.Text = "Quit Reason:";
            this.QuitReasonLabel.UseWaitCursor = true;
            // 
            // JoinDateLabel
            // 
            this.JoinDateLabel.AutoSize = true;
            this.JoinDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinDateLabel.Location = new System.Drawing.Point(3, 110);
            this.JoinDateLabel.Name = "JoinDateLabel";
            this.JoinDateLabel.Size = new System.Drawing.Size(111, 25);
            this.JoinDateLabel.TabIndex = 7;
            this.JoinDateLabel.Text = "Join Date:";
            this.JoinDateLabel.UseWaitCursor = true;
            // 
            // PlayerInfoLabel
            // 
            this.PlayerInfoLabel.AutoSize = true;
            this.PlayerInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerInfoLabel.Location = new System.Drawing.Point(3, 0);
            this.PlayerInfoLabel.Name = "PlayerInfoLabel";
            this.PlayerInfoLabel.Size = new System.Drawing.Size(179, 25);
            this.PlayerInfoLabel.TabIndex = 0;
            this.PlayerInfoLabel.Text = "Player Info: None";
            // 
            // QuitDateLabel
            // 
            this.QuitDateLabel.AutoSize = true;
            this.QuitDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitDateLabel.Location = new System.Drawing.Point(3, 136);
            this.QuitDateLabel.Name = "QuitDateLabel";
            this.QuitDateLabel.Size = new System.Drawing.Size(110, 25);
            this.QuitDateLabel.TabIndex = 2;
            this.QuitDateLabel.Text = "Quit Date:";
            this.QuitDateLabel.UseWaitCursor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.DiscordNameDisplay, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.FlatnetNameDisplay, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(416, 354);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // DiscordNameDisplay
            // 
            this.DiscordNameDisplay.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscordNameDisplay.Location = new System.Drawing.Point(3, 90);
            this.DiscordNameDisplay.Name = "DiscordNameDisplay";
            this.DiscordNameDisplay.Size = new System.Drawing.Size(535, 50);
            this.DiscordNameDisplay.TabIndex = 3;
            this.DiscordNameDisplay.Text = "PlaceHolder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Discord Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flatnet Name: ";
            // 
            // FlatnetNameDisplay
            // 
            this.FlatnetNameDisplay.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlatnetNameDisplay.Location = new System.Drawing.Point(3, 20);
            this.FlatnetNameDisplay.Name = "FlatnetNameDisplay";
            this.FlatnetNameDisplay.Size = new System.Drawing.Size(535, 50);
            this.FlatnetNameDisplay.TabIndex = 1;
            this.FlatnetNameDisplay.Text = "PlaceHolder";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.ClaimsSelect, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FarmSelect, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RolesTable, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(40, 15, 40, 15);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(921, 288);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ClaimsSelect
            // 
            this.ClaimsSelect.AllowUserToAddRows = false;
            this.ClaimsSelect.AllowUserToDeleteRows = false;
            this.ClaimsSelect.AllowUserToResizeColumns = false;
            this.ClaimsSelect.AllowUserToResizeRows = false;
            this.ClaimsSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClaimsSelect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ClaimsSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClaimsSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Claim});
            this.ClaimsSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClaimsSelect.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClaimsSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClaimsSelect.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ClaimsSelect.Location = new System.Drawing.Point(80, 15);
            this.ClaimsSelect.Margin = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.ClaimsSelect.MultiSelect = false;
            this.ClaimsSelect.Name = "ClaimsSelect";
            this.ClaimsSelect.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClaimsSelect.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ClaimsSelect.RowHeadersVisible = false;
            this.ClaimsSelect.RowHeadersWidth = 51;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClaimsSelect.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ClaimsSelect.RowTemplate.Height = 24;
            this.ClaimsSelect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ClaimsSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClaimsSelect.ShowEditingIcon = false;
            this.ClaimsSelect.Size = new System.Drawing.Size(200, 258);
            this.ClaimsSelect.TabIndex = 0;
            // 
            // Claim
            // 
            this.Claim.HeaderText = "Claims";
            this.Claim.MinimumWidth = 6;
            this.Claim.Name = "Claim";
            this.Claim.ReadOnly = true;
            // 
            // FarmSelect
            // 
            this.FarmSelect.AllowUserToAddRows = false;
            this.FarmSelect.AllowUserToDeleteRows = false;
            this.FarmSelect.AllowUserToResizeColumns = false;
            this.FarmSelect.AllowUserToResizeRows = false;
            this.FarmSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FarmSelect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.FarmSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FarmSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.FarmSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FarmSelect.DefaultCellStyle = dataGridViewCellStyle6;
            this.FarmSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FarmSelect.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.FarmSelect.Location = new System.Drawing.Point(360, 15);
            this.FarmSelect.Margin = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.FarmSelect.MultiSelect = false;
            this.FarmSelect.Name = "FarmSelect";
            this.FarmSelect.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FarmSelect.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.FarmSelect.RowHeadersVisible = false;
            this.FarmSelect.RowHeadersWidth = 51;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FarmSelect.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.FarmSelect.RowTemplate.Height = 24;
            this.FarmSelect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FarmSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FarmSelect.ShowEditingIcon = false;
            this.FarmSelect.Size = new System.Drawing.Size(200, 258);
            this.FarmSelect.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Farms";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // RolesTable
            // 
            this.RolesTable.AllowUserToAddRows = false;
            this.RolesTable.AllowUserToDeleteRows = false;
            this.RolesTable.AllowUserToResizeColumns = false;
            this.RolesTable.AllowUserToResizeRows = false;
            this.RolesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RolesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.RolesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RolesColumn});
            this.RolesTable.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RolesTable.DefaultCellStyle = dataGridViewCellStyle10;
            this.RolesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RolesTable.Enabled = false;
            this.RolesTable.Location = new System.Drawing.Point(640, 15);
            this.RolesTable.Margin = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.RolesTable.MultiSelect = false;
            this.RolesTable.Name = "RolesTable";
            this.RolesTable.ReadOnly = true;
            this.RolesTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RolesTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.RolesTable.RowHeadersVisible = false;
            this.RolesTable.RowHeadersWidth = 51;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RolesTable.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.RolesTable.RowTemplate.Height = 24;
            this.RolesTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RolesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.RolesTable.ShowEditingIcon = false;
            this.RolesTable.Size = new System.Drawing.Size(201, 258);
            this.RolesTable.TabIndex = 2;
            // 
            // RolesColumn
            // 
            this.RolesColumn.HeaderText = "Roles";
            this.RolesColumn.MinimumWidth = 6;
            this.RolesColumn.Name = "RolesColumn";
            this.RolesColumn.ReadOnly = true;


            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClaimsSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FarmSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolesTable)).EndInit();
            this.ResumeLayout(false);

            Controls.Add(this.splitContainer1);
            Location = new System.Drawing.Point(4, 5);
            Name = "PlayerView";
            Padding = new System.Windows.Forms.Padding(3);
            Size = new System.Drawing.Size(734, 571);
            TabIndex = 0;
            Text = "PlayerView";
            UseVisualStyleBackColor = true;

        }

        private DataGridView NameSelect;
        private TabControl ViewSelector;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label QuitReasonLabel;
        private System.Windows.Forms.Label JoinDateLabel;
        private System.Windows.Forms.Label PlayerInfoLabel;
        private System.Windows.Forms.Label QuitDateLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label DiscordNameDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FlatnetNameDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView ClaimsSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Claim;
        private System.Windows.Forms.DataGridView FarmSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView RolesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolesColumn;
        public string inGameNameSelected;

        void IPlayerView.ShowPlayerData(object sender, EventArgs e) {
            if (NameSelect.SelectedCells.Count > 0) {
                RolesTable.Rows.Clear();
                ClaimsSelect.Rows.Clear();
                FarmSelect.Rows.Clear();

                QuitReasonLabel.Text = "";
                QuitDateLabel.Text = "";
                PlayerInfoLabel.Text = "Player Info: None";

                int selectedRowIndex = NameSelect.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = NameSelect.Rows[selectedRowIndex];
                inGameNameSelected = Convert.ToString(selectedRow.Cells["Flatnet Name"].Value);

                string PlayerQuery = $"SELECT InGameName, DiscordName, JoinDate, QuitDate, QuitReason, AdditionalInfo FROM dbo.Member WHERE InGameName='{inGameNameSelected}'";
                string RoleQuery = $"SELECT Mayor, ViceMayor AS [Vice Mayor], CouncilRole, ServerBooster AS [Server Booster], Admin, MogswampMod AS [Mogswamp Mod], MarshPeep AS [Marsh Peep], MarshAssociate AS [Marsh Associate], Java, Bedrock FROM dbo.Member WHERE InGameName = '{inGameNameSelected}'";
                string ClaimQuery = $"SELECT ClaimName, SECornerX, SECornerY, SECornerZ, NWCornerX, NWCornerY, NWCornerZ FROM [Claim] AS c INNER JOIN [Member] ON OwnerMemberKey=[Member].[MemberKey] WHERE [InGameName]='{inGameNameSelected}'";
                string FarmQuery = $"SELECT AutomatedItem, SECornerX, SECornerY, SECornerZ, NWCornerX, NWCornerY, NWCornerZ FROM [Farm] AS f INNER JOIN [Member] ON CreatorMemberKey=[Member].[MemberKey] INNER JOIN [Claim] ON ShellClaimKey=[Claim].[ClaimKey] WHERE [InGameName]='{inGameNameSelected}'";

                SqlCommand getPlayerCmd = new SqlCommand(PlayerQuery, sqlConnection);
                SqlCommand getRolesCmd = new SqlCommand(RoleQuery, sqlConnection);
                SqlCommand getClaimCmd = new SqlCommand(ClaimQuery, sqlConnection);
                SqlCommand getFarmCmd = new SqlCommand(FarmQuery, sqlConnection);

                SqlDataAdapter playerAdapter = new SqlDataAdapter(getPlayerCmd);
                SqlDataAdapter rolesAdapater = new SqlDataAdapter(getRolesCmd);
                SqlDataAdapter claimAdapter = new SqlDataAdapter(getClaimCmd);
                SqlDataAdapter farmAdapter = new SqlDataAdapter(getFarmCmd);

                DataTable playerOutputTable = new DataTable();
                DataTable rolesOutputTable = new DataTable();
                DataTable claimOutputTable = new DataTable();
                DataTable farmOutputTable = new DataTable();

                try {
                    sqlConnection.Open();
                    playerAdapter.Fill(playerOutputTable);
                    rolesAdapater.Fill(rolesOutputTable);
                    claimAdapter.Fill(claimOutputTable);
                    farmAdapter.Fill(farmOutputTable);
                } catch (Exception ex) {
                    PlayerInfoLabel.Text = "An error occured: " + ex.Message;
                    FlatnetNameDisplay.Text = "An error occured.";
                    DiscordNameDisplay.Text = "An error occured";
                } finally { sqlConnection.Close(); }

                if (playerOutputTable != null) {
                    FlatnetNameDisplay.Text = playerOutputTable.Rows[0].Field<string>("InGameName");
                    DiscordNameDisplay.Text = playerOutputTable.Rows[0].Field<string>("DiscordName");

                    PlayerInfoLabel.Text = "Player Info: \n" + playerOutputTable.Rows[0].Field<string>("AdditionalInfo");
                    JoinDateLabel.Text = "Join Date: " + playerOutputTable.Rows[0].Field<DateTime>("JoinDate").ToString("M/d/yyyy");
                    if (!(playerOutputTable.Rows[0].Field<string>("AdditionalInfo") == null)) {
                        PlayerInfoLabel.Text = "Player Info: \n" + playerOutputTable.Rows[0].Field<string>("AdditionalInfo");
                    }
                    if (!(playerOutputTable.Rows[0].Field<DateTime?>("QuitDate") == null)) {
                        QuitDateLabel.Text = "Quit Date: " + playerOutputTable.Rows[0].Field<DateTime>("QuitDate").ToString("M/d/yyyy");
                        QuitReasonLabel.Text = "Quit Reason: \n" + playerOutputTable.Rows[0].Field<string>("QuitReason");
                    }
                }

                for (int i = 0; i < rolesOutputTable.Columns.Count; i++) {
                    if (!(rolesOutputTable.Rows[0][i] == null)) {
                        if (rolesOutputTable.Columns[i].ColumnName == "CouncilRole") {
                            RolesTable.Rows.Add("Council Role: " + rolesOutputTable.Rows[0].Field<string>("CouncilRole").ToString());
                        } else if (rolesOutputTable.Rows[0][i].ToString() == "True") {
                            RolesTable.Rows.Add(rolesOutputTable.Columns[i].ColumnName);
                        }
                    }
                }
                RolesTable.ClearSelection();

                for (int i = 0; i < claimOutputTable.Rows.Count; i++) {
                    if (claimOutputTable.Rows[i].Field<int?>("SECornerY") == null) {
                        ClaimsSelect.Rows.Add(claimOutputTable.Rows[i].Field<string>("ClaimName") + " at " +
                       (claimOutputTable.Rows[i].Field<int>("SECornerX") + claimOutputTable.Rows[i].Field<int>("NWCornerX")) / 2 + ", " +
                       (claimOutputTable.Rows[i].Field<int>("SECornerZ") + claimOutputTable.Rows[i].Field<int>("NWCornerZ")) / 2
                       );
                    } else {
                        ClaimsSelect.Rows.Add(claimOutputTable.Rows[i].Field<string>("ClaimName") + " at " +
                        (claimOutputTable.Rows[i].Field<int>("SECornerX") + claimOutputTable.Rows[i].Field<int>("NWCornerX")) / 2 + ", " +
                        (claimOutputTable.Rows[i].Field<int>("SECornerY") + claimOutputTable.Rows[i].Field<int>("NWCornerY")) / 2 + ", " +
                        (claimOutputTable.Rows[i].Field<int>("SECornerZ") + claimOutputTable.Rows[i].Field<int>("NWCornerZ")) / 2
                        );
                    }
                }
                ClaimsSelect.ClearSelection();

                for (int i = 0; i < farmOutputTable.Rows.Count; i++) {
                    if (farmOutputTable.Rows[i].Field<int?>("SECornerY") == null) {
                        FarmSelect.Rows.Add(farmOutputTable.Rows[i].Field<string>("AutomatedItem") + " farm at " +
                            (farmOutputTable.Rows[i].Field<int>("SECornerX") + farmOutputTable.Rows[i].Field<int>("NWCornerX")) / 2 + ", " +
                            (farmOutputTable.Rows[i].Field<int>("SECornerZ") + farmOutputTable.Rows[i].Field<int>("NWCornerZ")) / 2
                        );
                    } else {
                        FarmSelect.Rows.Add(farmOutputTable.Rows[i].Field<string>("AutomatedItem") + " farm at " +
                            (farmOutputTable.Rows[i].Field<int>("SECornerX") + farmOutputTable.Rows[i].Field<int>("NWCornerX")) / 2 + ", " +
                            (farmOutputTable.Rows[i].Field<int>("SECornerY") + farmOutputTable.Rows[i].Field<int>("NWCornerY")) / 2 + ", " +
                            (farmOutputTable.Rows[i].Field<int>("SECornerZ") + farmOutputTable.Rows[i].Field<int>("NWCornerZ")) / 2
                        );
                    }
                }
                ViewSelector.SelectedIndex = 0;

                FarmSelect.ClearSelection();
            }
        }
    }
}

