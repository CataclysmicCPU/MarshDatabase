using System;
using System.Windows.Forms;
using static MarshDatabase.Program;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace MarshDatabase {

    public interface IClaimView {
        void ShowClaimData(object sender, EventArgs e);
        string getPlayerSwapName();
        void setPlayerSwapName(string s);
    }

    internal class ClaimView : TabPage, IClaimView {
        public ClaimView(DataGridView ClaimSlectPass, TabControl ViewSelectorPass) {
            this.ViewSwapper = ViewSelectorPass;
            this.ClaimSelect = ClaimSlectPass;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.ClaimNameTextBox = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.ClaimOwnerTextBox = new System.Windows.Forms.LinkLabel();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.ClaimContentsTextBox = new System.Windows.Forms.TextBox();
            this.ClaimDatesTextBox = new System.Windows.Forms.TextBox();
            this.MainClaimTextBox = new System.Windows.Forms.TextBox();
            this.ClaimSizeTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.CordsDisplayTextBox = new System.Windows.Forms.TextBox();
            this.ClaimCenterTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font(font.Families[0], 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(893, 586);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.TextBox2);
            this.flowLayoutPanel1.Controls.Add(this.ClaimNameTextBox);
            this.flowLayoutPanel1.Controls.Add(this.TextBox1);
            this.flowLayoutPanel1.Controls.Add(this.ClaimOwnerTextBox);
            this.flowLayoutPanel1.Controls.Add(this.TextBox4);
            this.flowLayoutPanel1.Controls.Add(this.ClaimContentsTextBox);
            this.flowLayoutPanel1.Controls.Add(this.ClaimDatesTextBox);
            this.flowLayoutPanel1.Controls.Add(this.MainClaimTextBox);
            this.flowLayoutPanel1.Controls.Add(this.ClaimSizeTextBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(440, 580);
            // 
            // ClaimNameTextBox
            // 
            this.TextBox2.AutoSize = true;
            this.TextBox2.Font = new System.Drawing.Font(font.Families[0], 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox2.Location = new System.Drawing.Point(3, 0);
            this.TextBox2.Name = "ClaimNameTextBox";
            this.TextBox2.Size = new System.Drawing.Size(123, 22);
            this.TextBox2.ReadOnly = true;
            this.TextBox2.Text = "Claim Name:";
            // 
            // ClaimNameTextBox
            // 
            this.ClaimNameTextBox.AutoSize = true;
            this.ClaimNameTextBox.Font = new System.Drawing.Font(font.Families[0], 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaimNameTextBox.Location = new System.Drawing.Point(3, 22);
            this.ClaimNameTextBox.Name = "TextBox2";
            this.ClaimNameTextBox.Size = new System.Drawing.Size(300, 35);
            this.ClaimNameTextBox.TabIndex = 1;
            this.ClaimNameTextBox.Text = "PlaceHolder";
            // 
            // TextBox1
            // 
            this.TextBox1.AutoSize = true;
            this.TextBox1.Font = new System.Drawing.Font(font.Families[0], 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(3, 60);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(136, 25);
            this.TextBox1.TabIndex = 2;
            this.TextBox1.AcceptsReturn = true;
            this.TextBox1.Multiline = true;
            this.TextBox1.Text = "Claim Owner: ";
            // 
            // ClaimOwnerTextBox
            // 
            this.ClaimOwnerTextBox.AutoSize = true;
            this.ClaimOwnerTextBox.Font = new System.Drawing.Font(font.Families[0], 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaimOwnerTextBox.Location = new System.Drawing.Point(3, 0);
            this.ClaimOwnerTextBox.Name = "ClaimOwnerTextBox";
            this.ClaimOwnerTextBox.Size = new System.Drawing.Size(300, 25);
            this.ClaimOwnerTextBox.TabIndex = 3;
            this.ClaimOwnerTextBox.Text = "Placeholder";
            this.ClaimOwnerTextBox.LinkClicked += SwapToPlayer;
            // 
            // TextBox4
            // 
            this.TextBox4.AutoSize = true;
            this.TextBox4.Font = new System.Drawing.Font(font.Families[0], 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox4.Location = new System.Drawing.Point(3, 142);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(102, 24);
            this.TextBox4.TabIndex = 4;
            this.TextBox4.AcceptsReturn = true;
            this.TextBox4.Multiline = true;
            this.TextBox4.Text = "Contents:";
            // 
            // ClaimContentsTextBox
            // 
            this.ClaimContentsTextBox.AutoSize = true;
            this.ClaimContentsTextBox.Font = new System.Drawing.Font(font.Families[0], 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaimContentsTextBox.Location = new System.Drawing.Point(3, 186);
            this.ClaimContentsTextBox.Name = "ClaimContentsTextBox";
            this.ClaimContentsTextBox.Size = new System.Drawing.Size(500, 100);
            this.ClaimContentsTextBox.TabIndex = 5;
            this.ClaimContentsTextBox.Multiline = true;
            this.ClaimContentsTextBox.WordWrap = true;
            this.ClaimContentsTextBox.Text = "PlaceHolder";
            // 
            // ClaimDatesTextBox
            // 
            this.ClaimDatesTextBox.AutoSize = true;
            this.ClaimDatesTextBox.Font = new System.Drawing.Font(font.Families[0], 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaimDatesTextBox.Location = new System.Drawing.Point(3, 215);
            this.ClaimDatesTextBox.Name = "ClaimDatesTextBox";
            this.ClaimDatesTextBox.Size = new System.Drawing.Size(300, 30);
            this.ClaimDatesTextBox.TabIndex = 6;
            this.ClaimDatesTextBox.AcceptsReturn = true;
            this.ClaimDatesTextBox.Multiline = true;
            this.ClaimDatesTextBox.Text = "\nDate Created: 99/99/999 \nDate Deleted: 99/99/999";
            // 
            // MainClaimTextBox
            // 
            this.MainClaimTextBox.AutoSize = true;
            this.MainClaimTextBox.Font = new System.Drawing.Font(font.Families[0], 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainClaimTextBox.Location = new System.Drawing.Point(3, 389);
            this.MainClaimTextBox.Name = "MainClaimTextBox";
            this.MainClaimTextBox.Size = new System.Drawing.Size(204, 87);
            this.MainClaimTextBox.TabIndex = 7;
            this.MainClaimTextBox.AcceptsReturn = true;
            this.MainClaimTextBox.Multiline = true;
            this.MainClaimTextBox.Text = "\r\nIn Main Claim? \r\nYes";
            // 
            // TextBox3
            // 
            this.ClaimSizeTextBox.AutoSize = true;
            this.ClaimSizeTextBox.Font = new System.Drawing.Font(font.Families[0], 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaimSizeTextBox.Location = new System.Drawing.Point(3, 476);
            this.ClaimSizeTextBox.Name = "TextBox3";
            this.ClaimSizeTextBox.Size = new System.Drawing.Size(200, 87);
            this.ClaimSizeTextBox.TabIndex = 8;
            this.ClaimSizeTextBox.AcceptsReturn = true;
            this.ClaimSizeTextBox.Multiline = true;
            this.ClaimSizeTextBox.Text = "\nSize: \n999,999";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.CordsDisplayTextBox);
            this.flowLayoutPanel2.Controls.Add(this.ClaimCenterTextBox);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(449, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(441, 580);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // CordsDisplayTextBox
            // 
            this.CordsDisplayTextBox.AutoSize = true;
            this.CordsDisplayTextBox.Font = new System.Drawing.Font(font.Families[0], 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CordsDisplayTextBox.Location = new System.Drawing.Point(3, 0);
            this.CordsDisplayTextBox.Name = "CordsDisplayTextBox";
            this.CordsDisplayTextBox.Size = new System.Drawing.Size(500, 177);
            this.CordsDisplayTextBox.TabIndex = 2;
            this.CordsDisplayTextBox.AcceptsReturn = true;
            this.CordsDisplayTextBox.Multiline = true;
            this.CordsDisplayTextBox.Text = "Claim Corners: \r\nNW: -9999, -999, -9999 NE: -9999, -999, -9999\r\nSW: -9999, -999, " +
    "-9999 SE: -9999, -999, -9999";

            // 
            // ClaimCenterTextBox
            // 
            this.ClaimCenterTextBox.AutoSize = true;
            this.ClaimCenterTextBox.Font = new System.Drawing.Font(font.Families[0], 15.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaimCenterTextBox.Location = new System.Drawing.Point(3, 195);
            this.ClaimCenterTextBox.Name = "ClaimCenterTextBox";
            this.ClaimCenterTextBox.Size = new System.Drawing.Size(500, 117);
            this.ClaimCenterTextBox.TabIndex = 3;
            this.ClaimCenterTextBox.Multiline = true;
            this.ClaimCenterTextBox.AcceptsReturn = true;
            this.ClaimCenterTextBox.Text = "\r\nClaim Center: \r\n-9999,-999,-9999\r\n";;

            this.ClientSize = new System.Drawing.Size(893, 586);
            this.Controls.Add(this.tableLayoutPanel1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            Location = new System.Drawing.Point(4, 5);
            Name = "ClaimView";
            Padding = new System.Windows.Forms.Padding(3);
            Size = new System.Drawing.Size(734, 571);
            TabIndex = 0;
            Text = "ClaimView";
            UseVisualStyleBackColor = true;
        }

        public string playerSwapName;
        private DataGridView ClaimSelect;
        private TabControl ViewSwapper;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox ClaimNameTextBox;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.LinkLabel ClaimOwnerTextBox;
        private System.Windows.Forms.TextBox TextBox4;
        private System.Windows.Forms.TextBox ClaimContentsTextBox;
        private System.Windows.Forms.TextBox ClaimDatesTextBox;
        private System.Windows.Forms.TextBox MainClaimTextBox;
        private System.Windows.Forms.TextBox ClaimSizeTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox CordsDisplayTextBox;
        private System.Windows.Forms.TextBox ClaimCenterTextBox;

        void IClaimView.ShowClaimData(object sender, EventArgs e) {
            if (ClaimSelect.SelectedCells.Count > 0) {

                int selectedRowIndex = ClaimSelect.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = ClaimSelect.Rows[selectedRowIndex];
                string claimNameSelected = Convert.ToString(selectedRow.Cells["ClaimName"].Value);



                string claimQuery = $"SELECT InGameName, ClaimName, Size, Contents, DateCreated, DateDeleted, SECornerX, SECornerY, SECornerZ, NWCornerX, NWCornerY, NWCornerZ, InMainClaim FROM dbo.Claim INNER JOIN [Member] ON OwnerMemberKey=[Member].[MemberKey] WHERE ClaimName = '{claimNameSelected}'";
                SqlCommand claimCmd = new SqlCommand(claimQuery, sqlConnection);
                SqlDataAdapter claimDataAdapter = new SqlDataAdapter(claimCmd);

                DataTable ClaimOutputTable = new DataTable();

                try {
                    sqlConnection.Open();
                    claimDataAdapter.Fill(ClaimOutputTable);
                } catch (Exception ex) {
                    ClaimContentsTextBox.Text = "An error happened :P, Please contact CataclysmicCPU and give gim this message, " + ex.Message;
                } finally { sqlConnection.Close(); }

                ClaimNameTextBox.Text = claimNameSelected;
                ClaimContentsTextBox.Text = ClaimOutputTable.Rows[0].Field<string>("Contents");
                ClaimOwnerTextBox.Text = ClaimOutputTable.Rows[0].Field<string>("InGameName");
                ClaimSizeTextBox.Text = "\r\nSize: \r\n" + ClaimOutputTable.Rows[0].Field<int>("Size") + " blocks";
                MainClaimTextBox.Text =  "\r\nIn Main Claim? \r\n" + ClaimOutputTable.Rows[0].Field<bool>("InMainClaim");
                if (ClaimOutputTable.Rows[0].Field<DateTime?>("DateDeleted") == null) {
                    ClaimDatesTextBox.Text = "\nDate Created: " + ClaimOutputTable.Rows[0].Field<DateTime>("DateCreated").ToString("M/d/yyyy");
                } else {
                    ClaimDatesTextBox.Text = "Date Created: " + ClaimOutputTable.Rows[0].Field<DateTime>("DateCreated").ToString("M/d/yyyy") +
                                         "\r\nDate Deleted: " + ClaimOutputTable.Rows[0].Field<DateTime>("DateDeleted").ToString("M/d/yyyy");
                }
                if (ClaimOutputTable.Rows[0].Field<int?>("SECornerY") == null) {
                    CordsDisplayTextBox.Text =
                        "Claim Corners: \r\nNW: " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerX") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerZ") + " NE: " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerX") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("SECornerZ") + "\r\n SW: " +
                        ClaimOutputTable.Rows[0].Field<int>("SECornerX") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerZ") + " SE: " +
                        ClaimOutputTable.Rows[0].Field<int>("SECornerX") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerZ");
                } else {
                    CordsDisplayTextBox.Text =
                        "Claim Corners: \r\nNW: " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerX") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerY") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerZ") + " NE: " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerX") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerY") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("SECornerZ") + "\r\n SW: " +
                        ClaimOutputTable.Rows[0].Field<int>("SECornerX") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("SECornerY") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerY") + " SE: " +
                        ClaimOutputTable.Rows[0].Field<int>("SECornerX") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("SECornerY") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerZ") + "";
                }
                if (ClaimOutputTable.Rows[0].Field<int?>("SECornerY") == null) {
                    ClaimCenterTextBox.Text = "\nClaim Center: " +
                    (ClaimOutputTable.Rows[0].Field<int>("SECornerX") + ClaimOutputTable.Rows[0].Field<int>("NWCornerX")) / 2 + ", " +
                    (ClaimOutputTable.Rows[0].Field<int>("SECornerZ") + ClaimOutputTable.Rows[0].Field<int>("NWCornerZ")) / 2;
                } else {
                    ClaimCenterTextBox.Text = "\nClaim Center: " +
                    (ClaimOutputTable.Rows[0].Field<int>("SECornerX") + ClaimOutputTable.Rows[0].Field<int>("NWCornerX")) / 2 + ", " +
                    (ClaimOutputTable.Rows[0].Field<int>("SECornerY") + ClaimOutputTable.Rows[0].Field<int>("NWCornerY")) / 2 + ", " +
                    (ClaimOutputTable.Rows[0].Field<int>("SECornerZ") + ClaimOutputTable.Rows[0].Field<int>("NWCornerZ")) / 2;
                }
                ViewSwapper.SelectedIndex = 1;
            }
        }
        string IClaimView.getPlayerSwapName() {
            return playerSwapName;
        }
        void IClaimView.setPlayerSwapName(string s) {
            playerSwapName = s;
        }
        void SwapToPlayer(object sender, EventArgs e) {
            playerSwapName = ClaimOwnerTextBox.Text;
        }
        [DllImport("User32.dll")]
        static extern Boolean HideCaret(IntPtr hWnd);
    }
}
