
namespace MouseSwitch
{
    partial class ErrorReport
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
            this.texts = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // texts
            // 
            this.texts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.texts.Location = new System.Drawing.Point(0, 0);
            this.texts.Multiline = true;
            this.texts.Name = "texts";
            this.texts.Size = new System.Drawing.Size(477, 307);
            this.texts.TabIndex = 0;
            // 
            // ErrorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 307);
            this.Controls.Add(this.texts);
            this.Name = "ErrorReport";
            this.Text = "错误信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox texts;
    }
}