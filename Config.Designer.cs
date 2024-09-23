
namespace MouseSwitcher
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.label1 = new System.Windows.Forms.Label();
            this.PrevKeyBox = new System.Windows.Forms.TextBox();
            this.NextKeyBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ModiKeyBox = new System.Windows.Forms.ComboBox();
            this.shownotify = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CrosslockKeyBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "触发键";
            // 
            // PrevKeyBox
            // 
            this.PrevKeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrevKeyBox.Location = new System.Drawing.Point(59, 33);
            this.PrevKeyBox.Name = "PrevKeyBox";
            this.PrevKeyBox.ReadOnly = true;
            this.PrevKeyBox.Size = new System.Drawing.Size(210, 21);
            this.PrevKeyBox.TabIndex = 2;
            this.PrevKeyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrevKeyBox_KeyDown);
            // 
            // NextKeyBox
            // 
            this.NextKeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NextKeyBox.Location = new System.Drawing.Point(59, 60);
            this.NextKeyBox.Name = "NextKeyBox";
            this.NextKeyBox.ReadOnly = true;
            this.NextKeyBox.Size = new System.Drawing.Size(210, 21);
            this.NextKeyBox.TabIndex = 3;
            this.NextKeyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NextKeyBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "上一屏";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "下一屏";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "受限于系统，并非所有快捷键都能全局触发，\r\n设置后请自行实验。";
            // 
            // ModiKeyBox
            // 
            this.ModiKeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModiKeyBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ModiKeyBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ModiKeyBox.FormattingEnabled = true;
            this.ModiKeyBox.Items.AddRange(new object[] {
            "Ctrl",
            "Shift",
            "Alt",
            "Win"});
            this.ModiKeyBox.Location = new System.Drawing.Point(59, 6);
            this.ModiKeyBox.Name = "ModiKeyBox";
            this.ModiKeyBox.Size = new System.Drawing.Size(210, 20);
            this.ModiKeyBox.TabIndex = 7;
            this.ModiKeyBox.SelectedIndexChanged += new System.EventHandler(this.ModiKeyBox_SelectedIndexChanged);
            // 
            // shownotify
            // 
            this.shownotify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.shownotify.AutoSize = true;
            this.shownotify.Location = new System.Drawing.Point(12, 165);
            this.shownotify.Name = "shownotify";
            this.shownotify.Size = new System.Drawing.Size(96, 16);
            this.shownotify.TabIndex = 8;
            this.shownotify.Text = "允许弹出通知";
            this.shownotify.UseVisualStyleBackColor = true;
            this.shownotify.CheckedChanged += new System.EventHandler(this.shownotify_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(173, 165);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 16);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "阻止跨屏拖动";
            this.checkBox1.ThreeState = true;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "左上↖",
            "右上↗",
            "左下↙",
            "右下↘",
            "禁用×"});
            this.comboBox1.Location = new System.Drawing.Point(59, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 20);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "屏幕号";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "穿越锁";
            // 
            // CrosslockKeyBox
            // 
            this.CrosslockKeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CrosslockKeyBox.Location = new System.Drawing.Point(59, 87);
            this.CrosslockKeyBox.Name = "CrosslockKeyBox";
            this.CrosslockKeyBox.ReadOnly = true;
            this.CrosslockKeyBox.Size = new System.Drawing.Size(210, 21);
            this.CrosslockKeyBox.TabIndex = 12;
            this.CrosslockKeyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CrosslockKeyBox_KeyDown);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 184);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CrosslockKeyBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.shownotify);
            this.Controls.Add(this.ModiKeyBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NextKeyBox);
            this.Controls.Add(this.PrevKeyBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Config";
            this.Text = "屏幕切换程序 - 设置";
            this.Load += new System.EventHandler(this.Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrevKeyBox;
        private System.Windows.Forms.TextBox NextKeyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ModiKeyBox;
        private System.Windows.Forms.CheckBox shownotify;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CrosslockKeyBox;
    }
}