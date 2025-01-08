using System.Drawing;
using static MarshDatabase.Program;

namespace MarshDatabase.WriteForms {
    partial class Player {
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
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.playerInfoTextBox = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DeletePlayerButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AdminCheckBox = new System.Windows.Forms.CheckBox();
            this.MogModCheckBox = new System.Windows.Forms.CheckBox();
            this.BoosterCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.MemberPlayerTypeRadio = new System.Windows.Forms.RadioButton();
            this.AssocPlayerTypeRadio = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.JavaGameRadio = new System.Windows.Forms.RadioButton();
            this.BedrockGameRadio = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.CouncilTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IGNTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DiscordTextBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.JoinDatePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.QuitDatePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.QuitReasonTextBox = new System.Windows.Forms.TextBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 0);
            tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.playerInfoTextBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ErrorLabel, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.splitContainer1, 0, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // playerInfoTextBox
            // 
            resources.ApplyResources(this.playerInfoTextBox, "playerInfoTextBox");
            this.playerInfoTextBox.Name = "playerInfoTextBox";
            // 
            // ErrorLabel
            // 
            resources.ApplyResources(this.ErrorLabel, "ErrorLabel");
            this.ErrorLabel.Name = "ErrorLabel";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DeletePlayerButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ConfirmButton);
            // 
            // DeletePlayerButton
            // 
            resources.ApplyResources(this.DeletePlayerButton, "DeletePlayerButton");
            this.DeletePlayerButton.Name = "DeletePlayerButton";
            this.DeletePlayerButton.UseVisualStyleBackColor = true;
            this.DeletePlayerButton.Click += new System.EventHandler(this.DeletePlayer_Click);
            // 
            // ConfirmButton
            // 
            resources.ApplyResources(this.ConfirmButton, "ConfirmButton");
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.AdminCheckBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MogModCheckBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BoosterCheckBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // AdminCheckBox
            // 
            resources.ApplyResources(this.AdminCheckBox, "AdminCheckBox");
            this.AdminCheckBox.Name = "AdminCheckBox";
            this.AdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // MogModCheckBox
            // 
            resources.ApplyResources(this.MogModCheckBox, "MogModCheckBox");
            this.MogModCheckBox.Name = "MogModCheckBox";
            this.MogModCheckBox.UseVisualStyleBackColor = true;
            // 
            // BoosterCheckBox
            // 
            resources.ApplyResources(this.BoosterCheckBox, "BoosterCheckBox");
            this.BoosterCheckBox.Name = "BoosterCheckBox";
            this.BoosterCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel4, 0, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.textBox6);
            this.flowLayoutPanel2.Controls.Add(this.MemberPlayerTypeRadio);
            this.flowLayoutPanel2.Controls.Add(this.AssocPlayerTypeRadio);
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            // 
            // MemberPlayerTypeRadio
            // 
            resources.ApplyResources(this.MemberPlayerTypeRadio, "MemberPlayerTypeRadio");
            this.MemberPlayerTypeRadio.Name = "MemberPlayerTypeRadio";
            this.MemberPlayerTypeRadio.TabStop = true;
            this.MemberPlayerTypeRadio.UseVisualStyleBackColor = true;
            // 
            // AssocPlayerTypeRadio
            // 
            resources.ApplyResources(this.AssocPlayerTypeRadio, "AssocPlayerTypeRadio");
            this.AssocPlayerTypeRadio.Name = "AssocPlayerTypeRadio";
            this.AssocPlayerTypeRadio.TabStop = true;
            this.AssocPlayerTypeRadio.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.textBox3);
            this.flowLayoutPanel3.Controls.Add(this.JavaGameRadio);
            this.flowLayoutPanel3.Controls.Add(this.BedrockGameRadio);
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // JavaGameRadio
            // 
            resources.ApplyResources(this.JavaGameRadio, "JavaGameRadio");
            this.JavaGameRadio.Name = "JavaGameRadio";
            this.JavaGameRadio.TabStop = true;
            this.JavaGameRadio.UseVisualStyleBackColor = true;
            // 
            // BedrockGameRadio
            // 
            resources.ApplyResources(this.BedrockGameRadio, "BedrockGameRadio");
            this.BedrockGameRadio.Name = "BedrockGameRadio";
            this.BedrockGameRadio.TabStop = true;
            this.BedrockGameRadio.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.textBox5);
            this.flowLayoutPanel4.Controls.Add(this.CouncilTextBox);
            resources.ApplyResources(this.flowLayoutPanel4, "flowLayoutPanel4");
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            // 
            // CouncilTextBox
            // 
            resources.ApplyResources(this.CouncilTextBox, "CouncilTextBox");
            this.CouncilTextBox.Name = "CouncilTextBox";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(flowLayoutPanel1);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(this.textBox1);
            flowLayoutPanel1.Controls.Add(this.IGNTextBox);
            flowLayoutPanel1.Controls.Add(this.textBox2);
            flowLayoutPanel1.Controls.Add(this.DiscordTextBox);
            flowLayoutPanel1.Controls.Add(this.textBox4);
            flowLayoutPanel1.Controls.Add(this.JoinDatePicker);
            flowLayoutPanel1.Controls.Add(this.textBox7);
            flowLayoutPanel1.Controls.Add(this.QuitDatePicker);
            flowLayoutPanel1.Controls.Add(this.textBox8);
            flowLayoutPanel1.Controls.Add(this.QuitReasonTextBox);
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // textBox1
            // 
            this.textBox1.CausesValidation = false;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // IGNTextBox
            // 
            resources.ApplyResources(this.IGNTextBox, "IGNTextBox");
            this.IGNTextBox.Name = "IGNTextBox";
            // 
            // textBox2
            // 
            this.textBox2.CausesValidation = false;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // DiscordTextBox
            // 
            resources.ApplyResources(this.DiscordTextBox, "DiscordTextBox");
            this.DiscordTextBox.Name = "DiscordTextBox";
            // 
            // textBox4
            // 
            this.textBox4.CausesValidation = false;
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // JoinDatePicker
            // 
            this.JoinDatePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.JoinDatePicker, "JoinDatePicker");
            this.JoinDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.JoinDatePicker.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.JoinDatePicker.Name = "JoinDatePicker";
            this.JoinDatePicker.Value = new System.DateTime(2024, 11, 22, 0, 0, 0, 0);
            // 
            // textBox7
            // 
            this.textBox7.CausesValidation = false;
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.Name = "textBox7";
            // 
            // QuitDatePicker
            // 
            this.QuitDatePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.QuitDatePicker, "QuitDatePicker");
            this.QuitDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.QuitDatePicker.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.QuitDatePicker.Name = "QuitDatePicker";
            this.QuitDatePicker.Value = new System.DateTime(2024, 11, 22, 0, 0, 0, 0);
            this.QuitDatePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.QuitDatePicker_MouseDown);
            // 
            // textBox8
            // 
            this.textBox8.CausesValidation = false;
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.Name = "textBox8";
            // 
            // QuitReasonTextBox
            // 
            resources.ApplyResources(this.QuitReasonTextBox, "QuitReasonTextBox");
            this.QuitReasonTextBox.Name = "QuitReasonTextBox";
            // 
            // Player
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(tableLayoutPanel1);
            this.Name = "Player";
            tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox IGNTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox DiscordTextBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker JoinDatePicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox AdminCheckBox;
        private System.Windows.Forms.CheckBox MogModCheckBox;
        private System.Windows.Forms.CheckBox BoosterCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.RadioButton MemberPlayerTypeRadio;
        private System.Windows.Forms.RadioButton AssocPlayerTypeRadio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.RadioButton JavaGameRadio;
        private System.Windows.Forms.RadioButton BedrockGameRadio;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox CouncilTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox playerInfoTextBox;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DateTimePicker QuitDatePicker;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox QuitReasonTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button DeletePlayerButton;
    }
}