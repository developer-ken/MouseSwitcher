
namespace MouseSwitch
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
            this.ModiKeyBox = new System.Windows.Forms.TextBox();
            this.PrevKeyBox = new System.Windows.Forms.TextBox();
            this.NextKeyBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // ModiKeyBox
            // 
            this.ModiKeyBox.Location = new System.Drawing.Point(59, 6);
            this.ModiKeyBox.Name = "ModiKeyBox";
            this.ModiKeyBox.ReadOnly = true;
            this.ModiKeyBox.Size = new System.Drawing.Size(210, 21);
            this.ModiKeyBox.TabIndex = 1;
            this.ModiKeyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModiKeyBox_KeyDown);
            // 
            // PrevKeyBox
            // 
            this.PrevKeyBox.Location = new System.Drawing.Point(59, 33);
            this.PrevKeyBox.Name = "PrevKeyBox";
            this.PrevKeyBox.ReadOnly = true;
            this.PrevKeyBox.Size = new System.Drawing.Size(210, 21);
            this.PrevKeyBox.TabIndex = 2;
            this.PrevKeyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrevKeyBox_KeyDown);
            // 
            // NextKeyBox
            // 
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
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "受限于系统，并非所有快捷键都能全局触发，\r\n设置后请自行实验。";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 119);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NextKeyBox);
            this.Controls.Add(this.PrevKeyBox);
            this.Controls.Add(this.ModiKeyBox);
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
        private System.Windows.Forms.TextBox ModiKeyBox;
        private System.Windows.Forms.TextBox PrevKeyBox;
        private System.Windows.Forms.TextBox NextKeyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}