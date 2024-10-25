using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MarshDatabase.Program;

namespace MarshDatabase {
    public interface IFarmView {
        void ShowFarmData(object sender, EventArgs e);
    }
    internal class FarmView : TabPage, IFarmView {
        public FarmView(DataGridView FarmSelectPass, TabControl ViewSwapperPass, string playerSwapName) {
            this.playerSwapName = playerSwapName;
            FarmSelect = FarmSelectPass;
            ViewSwapper = ViewSwapperPass;
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
            this.FarmLocationLabel = new System.Windows.Forms.Label();
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
            flowLayoutPanel2.Controls.Add(this.FarmLocationLabel);
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
            //FarmLocationLabel
            this.FarmLocationLabel.AutoSize = true;
            this.FarmLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FarmLocationLabel.Location = new System.Drawing.Point(2, 0);
            this.FarmLocationLabel.Name = "FarmLocationLabel";
            this.FarmLocationLabel.Size = new System.Drawing.Size(220,190);
            this.FarmLocationLabel.TabIndex = 0;
            this.FarmLocationLabel.Text = "\nFarm Location: \nPlaceHolder";
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
        private string playerSwapName;
        private System.Windows.Forms.DataGridView FarmSelect;
        private System.Windows.Forms.TabControl ViewSwapper;
        private System.Windows.Forms.PictureBox FarmImage;
        private System.Windows.Forms.Label AutomatedItemLabel;
        private System.Windows.Forms.Label InputItemsLabel;
        private System.Windows.Forms.LinkLabel ShellClaimLabel;
        private System.Windows.Forms.LinkLabel CreatorNameLabel;
        private System.Windows.Forms.Label DatesDisplayLabel;
        private System.Windows.Forms.Label FarmLocationLabel;

        void IFarmView.ShowFarmData(object sender, EventArgs e) {
            if (FarmSelect.SelectedCells.Count > 0) {



                int selectedRowIndex = FarmSelect.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = FarmSelect.Rows[selectedRowIndex];
                string farmNameSelected = Convert.ToString(selectedRow.Cells["AutomatedItem"].Value);

                string farmQuery = $"SELECT AutomatedItem, AutomatedItemRate, RequiredInputItem1, RequiredInputItem3, RequiredInputItem3, RequiredInputRate1, RequiredInputRate2, RequiredInputRate3, SECornerX, SECornerY, SECornerZ, NWCornerX, NWCornerY, NWCornerZ, ClaimName, InGameName, Farm.DateCreated, Farm.DateRemoved FROM dbo.Farm INNER JOIN dbo.Claim ON ShellClaimKey=ClaimKey INNER JOIN dbo.Member ON CreatorMemberKey=MemberKey WHERE AutomatedItem = '{farmNameSelected}'";

                SqlCommand sqlCommand = new SqlCommand(farmQuery, sqlConnection);

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                DataTable farmTable = new DataTable();

                try {
                    sqlConnection.Open();
                    adapter.Fill(farmTable);
                } catch (Exception ex) {
                    AutomatedItemLabel.Text = "An error occured, please contact CataclysmicCPU and give him this error message: " + ex.Message;
                } finally { sqlConnection.Close(); }

                AutomatedItemLabel.Text = "Automated Item: \n" + farmTable.Rows[0][0] + " " + farmTable.Rows[0][1] + "/h";
                ShellClaimLabel.Text = farmTable.Rows[0].Field<string>("ClaimName");
                CreatorNameLabel.Text = farmTable.Rows[0].Field<string>("InGameName");
                DatesDisplayLabel.Text = "Date Created:\n " + farmTable.Rows[0].Field<DateTime>("DateCreated").ToString("M/d/yyyy");
                
                if (farmTable.Rows[0].Field<DateTime?>("DateRemoved") != null) {
                    DatesDisplayLabel.Text += "\nDate Removed: \n" + farmTable.Rows[0].Field<DateTime>("DateRemoved").ToString("M/d/yyyy");
                }

                if (farmTable.Rows[0].Field<string>("RequiredInputItem1") != null) {
                    InputItemsLabel.Text = "\nRequired Input Items:\n" + farmTable.Rows[0].Field<string>("RequiredInputRate1") + " " + farmTable.Rows[0].Field<string>("RequiredInputItem1") + "/h";
                } else {
                    InputItemsLabel.Text = "\nRequired Input Items:\nNone";
                }
                if (farmTable.Rows[0].Field<string>("RequiredInputRate2") != null) {
                    InputItemsLabel.Text = "\n" + farmTable.Rows[0].Field<string>("RequiredInputRate2") + " " + farmTable.Rows[0].Field<string>("RequiredInputItem2") + "/h";
                }
                if (farmTable.Rows[0].Field<string>("RequiredInputRate3") != null) {
                    InputItemsLabel.Text = "\n" + farmTable.Rows[0].Field<string>("RequiredInputRate3") + " " + farmTable.Rows[0].Field<string>("RequiredInputItem3") + "/h";
                }

                if (farmTable.Rows[0].Field<int?>("SECornerY") == null) {

                    FarmLocationLabel.Text = "\nClaim Center:\n" +
                    (farmTable.Rows[0].Field<int>("SECornerX") + farmTable.Rows[0].Field<int>("NWCornerX")) / 2 + ", " +
                    (farmTable.Rows[0].Field<int>("SECornerZ") + farmTable.Rows[0].Field<int>("NWCornerZ")) / 2;
                } else {
                    FarmLocationLabel.Text = "\nClaim Center:\n" +
                    (farmTable.Rows[0].Field<int>("SECornerX") + farmTable.Rows[0].Field<int>("NWCornerX")) / 2 + ", " +
                    (farmTable.Rows[0].Field<int>("SECornerY") + farmTable.Rows[0].Field<int>("NWCornerY")) / 2 + ", " +
                    (farmTable.Rows[0].Field<int>("SECornerZ") + farmTable.Rows[0].Field<int>("NWCornerZ")) / 2;
                }

                ViewSwapper.SelectedIndex = 2;
            }
        }
    }
}
