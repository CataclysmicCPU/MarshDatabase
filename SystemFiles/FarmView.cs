using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static MarshDatabase.Program;

namespace MarshDatabase {
    public interface IFarmView {
        void ShowFarmData(object sender, EventArgs e);
        string getClaimSwapName();
        string getPlayerSwapName();
        void setPlayerSwapName(string s);
        void setClaimSwapName(string s);
    }
    internal class FarmView : TabPage, IFarmView {
        public FarmView(DataGridView FarmSelectPass, TabControl ViewSwapperPass) {
            FarmSelect = FarmSelectPass;
            ViewSwapper = ViewSwapperPass;
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
            this.FarmLocationTextBox = new System.Windows.Forms.TextBox();
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
            splitContainer1.SplitterDistance = 378;
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
            splitContainer2.SplitterDistance = 372;
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
            this.AutomatedItemTextBox.Font = new System.Drawing.Font(font.Families[0], 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutomatedItemTextBox.Location = new System.Drawing.Point(3, 0);
            this.AutomatedItemTextBox.Name = "AutomatedItemTextBox";
            this.AutomatedItemTextBox.Size = new System.Drawing.Size(500, 64);
            this.AutomatedItemTextBox.ReadOnly = true;
            this.AutomatedItemTextBox.Multiline = true;
            this.AutomatedItemTextBox.WordWrap = true;
            this.AutomatedItemTextBox.Text = "PlaceHolder";
            // 
            // InputItemsTextBox
            // 
            this.InputItemsTextBox.AutoSize = true;
            this.InputItemsTextBox.Font = new System.Drawing.Font(font.Families[0], 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputItemsTextBox.Location = new System.Drawing.Point(3, 32);
            this.InputItemsTextBox.Name = "InputItemsTextBox";
            this.InputItemsTextBox.Size = new System.Drawing.Size(300, 128);
            this.InputItemsTextBox.TabIndex = 1;
            this.InputItemsTextBox.Multiline = true;
            this.InputItemsTextBox.WordWrap= true;
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
            splitContainer3.SplitterDistance = 407;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(TextBox1);
            flowLayoutPanel2.Controls.Add(this.ShellClaimTextBox);
            flowLayoutPanel2.Controls.Add(TextBox2);
            flowLayoutPanel2.Controls.Add(this.CreatorNameTextBox);
            flowLayoutPanel2.Controls.Add(this.FarmLocationTextBox);
            flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(307, 664);
            // 
            // TextBox1
            // 
            TextBox1.AutoSize = true;
            TextBox1.Font = new System.Drawing.Font(font.Families[0], 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TextBox1.Location = new System.Drawing.Point(3, 0);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new System.Drawing.Size(179, 25);
            TextBox1.ReadOnly = true;
            TextBox1.Text = "Shell Claim Name: ";
            // 
            // ShellClaimTextBox
            // 
            this.ShellClaimTextBox.AutoSize = true;
            this.ShellClaimTextBox.Font = new System.Drawing.Font(font.Families[0], 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShellClaimTextBox.Location = new System.Drawing.Point(3, 25);
            this.ShellClaimTextBox.Name = "ShellClaimTextBox";
            this.ShellClaimTextBox.Size = new System.Drawing.Size(300, 38);
            this.ShellClaimTextBox.TabIndex = 1;
            this.ShellClaimTextBox.TabStop = true;
            this.ShellClaimTextBox.Text = "PlaceHolder\r\n";
            this.ShellClaimTextBox.BackColor = this.BackColor;
            this.ShellClaimTextBox.LinkClicked += SwapToClaim;
            // 
            // TextBox2
            // 
            TextBox2.AutoSize = true;
            TextBox2.Font = new System.Drawing.Font(font.Families[0], 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TextBox2.Location = new System.Drawing.Point(3, 63);
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new System.Drawing.Size(300, 25);
            TextBox2.TabIndex = 2;
            TextBox2.Text = "Creator Name: ";
            // 
            // CreatorNameTextBox
            // 
            this.CreatorNameTextBox.AutoSize = true;
            this.CreatorNameTextBox.Font = new System.Drawing.Font(font.Families[0], 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatorNameTextBox.Location = new System.Drawing.Point(3, 88);
            this.CreatorNameTextBox.Name = "CreatorNameTextBox";
            this.CreatorNameTextBox.Size = new System.Drawing.Size(300, 75);
            this.CreatorNameTextBox.TabIndex = 3;
            this.CreatorNameTextBox.TabStop = true;
            this.CreatorNameTextBox.Text = "PlaceHolder\r\n";
            this.CreatorNameTextBox.BackColor = this.BackColor;
            this.CreatorNameTextBox.LinkClicked += this.SwapToPlayer;
            // 
            // DatesDisplayTextBox
            // 
            this.DatesDisplayTextBox.AutoSize = true;
            this.DatesDisplayTextBox.Font = new System.Drawing.Font(font.Families[0], 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatesDisplayTextBox.Location = new System.Drawing.Point(2, 0);
            this.DatesDisplayTextBox.Name = "DatesDisplayTextBox";
            this.DatesDisplayTextBox.Size = new System.Drawing.Size(350, 190);
            this.DatesDisplayTextBox.ReadOnly = true;
            this.DatesDisplayTextBox.Multiline = true;
            this.DatesDisplayTextBox.WordWrap = true;
            this.DatesDisplayTextBox.Text = "DateCreated: \r\nPlaceHolder\r\n\r\nDate Deleted:\r\nPlaceHolder";
            //
            //FarmLocationTextBox
            //
            this.FarmLocationTextBox.AutoSize = true;
            this.FarmLocationTextBox.Font = new System.Drawing.Font(font.Families[0], 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FarmLocationTextBox.Location = new System.Drawing.Point(2, 0);
            this.FarmLocationTextBox.Name = "FarmLocationTextBox";
            this.FarmLocationTextBox.Size = new System.Drawing.Size(500, 190);
            this.FarmLocationTextBox.ReadOnly = true;
            this.FarmLocationTextBox.Text = "\nFarm Location: \nPlaceHolder";
            //
            // 
            // Form1
            // 
            this.Controls.Add(splitContainer1);
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

            Location = new System.Drawing.Point(4, 5);
            Name = "FarmView";
            Padding = new System.Windows.Forms.Padding(3);
            Size = new System.Drawing.Size(734, 571);
            TabIndex = 0;
            Text = "FarmView";
            UseVisualStyleBackColor = true;
        }
        public string claimSwapName;
        public string playerSwapName;
        private System.Windows.Forms.DataGridView FarmSelect;
        private System.Windows.Forms.TabControl ViewSwapper;
        private System.Windows.Forms.PictureBox FarmImage;
        private System.Windows.Forms.TextBox AutomatedItemTextBox;
        private System.Windows.Forms.TextBox InputItemsTextBox;
        private System.Windows.Forms.LinkLabel ShellClaimTextBox;
        private System.Windows.Forms.LinkLabel CreatorNameTextBox;
        private System.Windows.Forms.TextBox DatesDisplayTextBox;
        private System.Windows.Forms.TextBox FarmLocationTextBox;

        void IFarmView.ShowFarmData(object sender, EventArgs e) {
            if (FarmSelect.SelectedCells.Count > 0) {

                int selectedRowIndex = FarmSelect.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = FarmSelect.Rows[FarmSelect.SelectedCells[0].RowIndex];
                string farmNameSelected = Convert.ToString(selectedRow.Cells["AutomatedItem"].Value);

                string farmQuery = $"SELECT AutomatedItem, AutomatedItemRate, RequiredInputItem1, RequiredInputItem3, RequiredInputItem3, RequiredInputRate1, RequiredInputRate2, RequiredInputRate3, SECornerX, SECornerY, SECornerZ, NWCornerX, NWCornerY, NWCornerZ, ClaimName, InGameName, Farm.DateCreated, Farm.DateRemoved, Picture FROM dbo.Farm INNER JOIN dbo.Claim ON ShellClaimKey=ClaimKey INNER JOIN dbo.Member ON CreatorMemberKey=MemberKey WHERE AutomatedItem = '{farmNameSelected}'";

                SqlCommand sqlCommand = new SqlCommand(farmQuery, sqlConnection);

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                DataTable farmTable = new DataTable();

                try {
                    sqlConnection.Open();
                    adapter.Fill(farmTable);
                } catch (Exception ex) {
                    AutomatedItemTextBox.Text = "An error occured, please contact CataclysmicCPU and give him this error message: " + ex.Message;
                } finally { sqlConnection.Close(); }

                AutomatedItemTextBox.Text = "Automated Item: \r\n" + farmTable.Rows[0][0] + " " + farmTable.Rows[0][1] + "/h";
                ShellClaimTextBox.Text = farmTable.Rows[0].Field<string>("ClaimName");
                CreatorNameTextBox.Text = farmTable.Rows[0].Field<string>("InGameName");
                DatesDisplayTextBox.Text = "Date Created:\r\n " + farmTable.Rows[0].Field<DateTime>("DateCreated").ToString("M/d/yyyy");

                if (farmTable.Rows[0].Field<DateTime?>("DateRemoved") != null) {
                    DatesDisplayTextBox.Text += "\r\nDate Removed: \r\n" + farmTable.Rows[0].Field<DateTime>("DateRemoved").ToString("M/d/yyyy");
                }

                if (farmTable.Rows[0].Field<string>("RequiredInputItem1") != null) {
                    InputItemsTextBox.Text = "\r\nRequired Input Items:\r\n" + farmTable.Rows[0].Field<string>("RequiredInputRate1") + " " + farmTable.Rows[0].Field<string>("RequiredInputItem1") + "/h";
                } else {
                    InputItemsTextBox.Text = "\r\nRequired Input Items:\r\nNone";
                }
                if (farmTable.Rows[0].Field<string>("RequiredInputRate2") != null) {
                    InputItemsTextBox.Text = "\r\n" + farmTable.Rows[0].Field<string>("RequiredInputRate2") + " " + farmTable.Rows[0].Field<string>("RequiredInputItem2") + "/h";
                }
                if (farmTable.Rows[0].Field<string>("RequiredInputRate3") != null) {
                    InputItemsTextBox.Text = "\r\n" + farmTable.Rows[0].Field<string>("RequiredInputRate3") + " " + farmTable.Rows[0].Field<string>("RequiredInputItem3") + "/h";
                }

                if (farmTable.Rows[0].Field<int?>("SECornerY") == null) {
                    FarmLocationTextBox.Text = "\r\nClaim Center:\r\n" +
                    (farmTable.Rows[0].Field<int>("SECornerX") + farmTable.Rows[0].Field<int>("NWCornerX")) / 2 + ", " +
                    (farmTable.Rows[0].Field<int>("SECornerZ") + farmTable.Rows[0].Field<int>("NWCornerZ")) / 2;
                } else {
                    FarmLocationTextBox.Text = "\r\nClaim Center:\r\n" +
                    (farmTable.Rows[0].Field<int>("SECornerX") + farmTable.Rows[0].Field<int>("NWCornerX")) / 2 + ", " +
                    (farmTable.Rows[0].Field<int>("SECornerY") + farmTable.Rows[0].Field<int>("NWCornerY")) / 2 + ", " +
                    (farmTable.Rows[0].Field<int>("SECornerZ") + farmTable.Rows[0].Field<int>("NWCornerZ")) / 2;
                }

                try {
                    var imageData = farmTable.Rows[0].Field<byte[]>("Picture");
                    if (imageData != null) {
                        using (var ms = new MemoryStream(imageData, 0, imageData.Length)) {
                            ms.Write(imageData, 0, imageData.Length);
                            FarmImage.Image = Image.FromStream(ms);
                        }
                    } else {
                        throw new Exception();
                    }
                } catch {
                    FarmImage.Image = Properties.Resources.MarshLogo;
                }

                ViewSwapper.SelectedIndex = 2;
            }
        }
        string IFarmView.getPlayerSwapName() {
            return playerSwapName;
        }
        string IFarmView.getClaimSwapName() {
            return claimSwapName;
        }
        void IFarmView.setPlayerSwapName(string s) {
            playerSwapName = s;
        }
        void IFarmView.setClaimSwapName(string s) {
            claimSwapName = s;
        }
        void SwapToPlayer(object sender, EventArgs e) {
            playerSwapName = CreatorNameTextBox.Text;
        }
        void SwapToClaim(object sender, EventArgs e) {
            claimSwapName = ShellClaimTextBox.Text;
        }
    }
}
