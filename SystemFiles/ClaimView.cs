using System;
using System.Windows.Forms;
using static MarshDatabase.Program;
using System.Data;
using System.Data.SqlClient;

namespace MarshDatabase {

    public interface IClaimView {
        void ShowClaimData(object sender, EventArgs e);
    }

    internal class ClaimView : TabPage, IClaimView {
        public ClaimView(DataGridView ClaimSlectPass, TabControl ViewSelectorPass, string swapIndex) {
            this.ViewSwapper = ViewSelectorPass;
            this.ClaimSelect = ClaimSlectPass;
            this.swapToPlayerName = swapIndex;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.ClaimNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClaimOwnerLabel = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.ClaimContentsLabel = new System.Windows.Forms.Label();
            this.ClaimDatesLabel = new System.Windows.Forms.Label();
            this.MainClaimLabel = new System.Windows.Forms.Label();
            this.ClaimSizeLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.CordsDisplayLabel = new System.Windows.Forms.Label();
            this.ClaimCenterLabel = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(893, 586);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.ClaimNameLabel);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.ClaimOwnerLabel);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.ClaimContentsLabel);
            this.flowLayoutPanel1.Controls.Add(this.ClaimDatesLabel);
            this.flowLayoutPanel1.Controls.Add(this.MainClaimLabel);
            this.flowLayoutPanel1.Controls.Add(this.ClaimSizeLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(440, 580);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ClaimNameLabel
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "ClaimNameLabel";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Claim Name:";
            // 
            // label2
            // 
            this.ClaimNameLabel.AutoSize = true;
            this.ClaimNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaimNameLabel.Location = new System.Drawing.Point(3, 22);
            this.ClaimNameLabel.Name = "label2";
            this.ClaimNameLabel.Size = new System.Drawing.Size(206, 38);
            this.ClaimNameLabel.TabIndex = 1;
            this.ClaimNameLabel.Text = "PlaceHolder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "\r\nClaim Owner: ";
            // 
            // ClaimOwnerLabel
            // 
            this.ClaimOwnerLabel.AutoSize = true;
            this.ClaimOwnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaimOwnerLabel.Location = new System.Drawing.Point(3, 104);
            this.ClaimOwnerLabel.Name = "ClaimOwnerLabel";
            this.ClaimOwnerLabel.Size = new System.Drawing.Size(206, 38);
            this.ClaimOwnerLabel.TabIndex = 3;
            this.ClaimOwnerLabel.Text = "PlaceHolder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 44);
            this.label4.TabIndex = 4;
            this.label4.Text = "\r\nContents: ";
            // 
            // ClaimContentsLabel
            // 
            this.ClaimContentsLabel.AutoSize = true;
            this.ClaimContentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaimContentsLabel.Location = new System.Drawing.Point(3, 186);
            this.ClaimContentsLabel.Name = "ClaimContentsLabel";
            this.ClaimContentsLabel.Size = new System.Drawing.Size(162, 29);
            this.ClaimContentsLabel.TabIndex = 5;
            this.ClaimContentsLabel.Text = "PlaceHolder";
            // 
            // ClaimDatesLabel
            // 
            this.ClaimDatesLabel.AutoSize = true;
            this.ClaimDatesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaimDatesLabel.Location = new System.Drawing.Point(3, 215);
            this.ClaimDatesLabel.Name = "ClaimDatesLabel";
            this.ClaimDatesLabel.Size = new System.Drawing.Size(190, 174);
            this.ClaimDatesLabel.TabIndex = 6;
            this.ClaimDatesLabel.Text = "\r\nDate Created: \r\n99/99/999 \r\n\r\nDate Deleted: \r\n99/99/999";
            // 
            // MainClaimLabel
            // 
            this.MainClaimLabel.AutoSize = true;
            this.MainClaimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainClaimLabel.Location = new System.Drawing.Point(3, 389);
            this.MainClaimLabel.Name = "MainClaimLabel";
            this.MainClaimLabel.Size = new System.Drawing.Size(204, 87);
            this.MainClaimLabel.TabIndex = 7;
            this.MainClaimLabel.Text = "\r\nIn Main Claim? \r\nYes\r\n";
            // 
            // label3
            // 
            this.ClaimSizeLabel.AutoSize = true;
            this.ClaimSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaimSizeLabel.Location = new System.Drawing.Point(3, 476);
            this.ClaimSizeLabel.Name = "label3";
            this.ClaimSizeLabel.Size = new System.Drawing.Size(111, 87);
            this.ClaimSizeLabel.TabIndex = 8;
            this.ClaimSizeLabel.Text = "\r\nSize: \r\n999,999\r\n";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.CordsDisplayLabel);
            this.flowLayoutPanel2.Controls.Add(this.ClaimCenterLabel);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(449, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(441, 580);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // CordsDisplayLabel
            // 
            this.CordsDisplayLabel.AutoSize = true;
            this.CordsDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CordsDisplayLabel.Location = new System.Drawing.Point(3, 0);
            this.CordsDisplayLabel.Name = "CordsDisplayLabel";
            this.CordsDisplayLabel.Size = new System.Drawing.Size(432, 195);
            this.CordsDisplayLabel.TabIndex = 2;
            this.CordsDisplayLabel.Text = "Claim Corners: \r\nNW: -9999, -999, -9999 NE: -9999, -999, -9999\r\nSW: -9999, -999, " +
    "-9999 SE: -9999, -999, -9999";
            // 
            // ClaimCenterLabel
            // 
            this.ClaimCenterLabel.AutoSize = true;
            this.ClaimCenterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaimCenterLabel.Location = new System.Drawing.Point(3, 195);
            this.ClaimCenterLabel.Name = "ClaimCenterLabel";
            this.ClaimCenterLabel.Size = new System.Drawing.Size(277, 117);
            this.ClaimCenterLabel.TabIndex = 3;
            this.ClaimCenterLabel.Text = "\r\nClaim Center: \r\n-9999,-999,-9999\r\n";

            this.ClientSize = new System.Drawing.Size(893, 586);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
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

        private string swapToPlayerName;
        private DataGridView ClaimSelect;
        private TabControl ViewSwapper;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ClaimNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel ClaimOwnerLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ClaimContentsLabel;
        private System.Windows.Forms.Label ClaimDatesLabel;
        private System.Windows.Forms.Label MainClaimLabel;
        private System.Windows.Forms.Label ClaimSizeLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label CordsDisplayLabel;
        private System.Windows.Forms.Label ClaimCenterLabel;

        void IClaimView.ShowClaimData(object sender, EventArgs e) {
            if (ClaimSelect.SelectedCells.Count > 0) {

                int selectedRowIndex = ClaimSelect.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = ClaimSelect.Rows[selectedRowIndex];
                string claimNameSelected = Convert.ToString(selectedRow.Cells["ClaimName"].Value);



                string claimQuery = $"SELECT InGameName, ClaimName, Size, Contents, DateCreated, DateDeleted, SECornerX, SECornerY, SECornerZ, NWCornerX, NWCornerY, NWCornerZ FROM dbo.Claim INNER JOIN [Member] ON OwnerMemberKey=[Member].[MemberKey] WHERE ClaimName = '{claimNameSelected}'";
                SqlCommand claimCmd = new SqlCommand(claimQuery, sqlConnection);
                SqlDataAdapter claimDataAdapter = new SqlDataAdapter(claimCmd);

                DataTable ClaimOutputTable = new DataTable();

                try {
                    sqlConnection.Open();
                    claimDataAdapter.Fill(ClaimOutputTable);
                } catch (Exception ex) {
                    ClaimContentsLabel.Text = "An error happened :P, Please contact CataclysmicCPU and give gim this message, " + ex.Message;
                } finally { sqlConnection.Close(); }

                ClaimNameLabel.Text = claimNameSelected;
                ClaimContentsLabel.Text = "Contents: " + ClaimOutputTable.Rows[0].Field<string>("Contents");
                ClaimOwnerLabel.Text = ClaimOutputTable.Rows[0].Field<string>("InGameName");
                ClaimSizeLabel.Text = "\nSize: " + ClaimOutputTable.Rows[0].Field<int>("Size") + " blocks";
                if (ClaimOutputTable.Rows[0].Field<DateTime?>("DateDeleted") == null) {
                    ClaimDatesLabel.Text = "\nDate Created: " + ClaimOutputTable.Rows[0].Field<DateTime>("DateCreated").ToString("M/d/yyyy");
                } else {
                    ClaimDatesLabel.Text = "Date Created: " + ClaimOutputTable.Rows[0].Field<DateTime>("DateCreated").ToString("M/d/yyyy") +
                                         "\nDate Deleted: " + ClaimOutputTable.Rows[0].Field<DateTime>("DateDeleted").ToString("M/d/yyyy");
                }
                if (ClaimOutputTable.Rows[0].Field<int?>("SECornerY") == null) {
                    CordsDisplayLabel.Text =
                        "Claim Corners: \nNW: " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerX") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerZ") + " NE: " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerX") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("SECornerZ") + "\n SW: " +
                        ClaimOutputTable.Rows[0].Field<int>("SECornerX") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerZ") + " SE: " +
                        ClaimOutputTable.Rows[0].Field<int>("SECornerX") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerZ");
                } else {
                    CordsDisplayLabel.Text =
                        "Claim Corners: \nNW: " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerX") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerY") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerZ") + " NE: " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerX") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerY") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("SECornerZ") + "\n SW: " +
                        ClaimOutputTable.Rows[0].Field<int>("SECornerX") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("SECornerY") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerY") + " SE: " +
                        ClaimOutputTable.Rows[0].Field<int>("SECornerX") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("SECornerY") + ", " +
                        ClaimOutputTable.Rows[0].Field<int>("NWCornerZ") + "";
                }
                if (ClaimOutputTable.Rows[0].Field<int?>("SECornerY") == null) {
                   ClaimCenterLabel.Text = "\nClaim Center: " +
                   (ClaimOutputTable.Rows[0].Field<int>("SECornerX") + ClaimOutputTable.Rows[0].Field<int>("NWCornerX")) / 2 + ", " +
                   (ClaimOutputTable.Rows[0].Field<int>("SECornerZ") + ClaimOutputTable.Rows[0].Field<int>("NWCornerZ")) / 2;
                } else {
                    ClaimCenterLabel.Text = "\nClaim Center: " +
                    (ClaimOutputTable.Rows[0].Field<int>("SECornerX") + ClaimOutputTable.Rows[0].Field<int>("NWCornerX")) / 2 + ", " +
                    (ClaimOutputTable.Rows[0].Field<int>("SECornerY") + ClaimOutputTable.Rows[0].Field<int>("NWCornerY")) / 2 + ", " +
                    (ClaimOutputTable.Rows[0].Field<int>("SECornerZ") + ClaimOutputTable.Rows[0].Field<int>("NWCornerZ")) / 2;
                }
                ViewSwapper.SelectedIndex = 1;
            }
        }
        void swapToPlayer(object sender, EventArgs e) {
            swapToPlayerName = ClaimOwnerLabel.Text;
        }
    }
}
