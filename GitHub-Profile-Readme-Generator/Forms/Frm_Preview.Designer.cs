namespace GitHub_Profile_Readme_Generator.Forms
{
    partial class Frm_Preview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Preview));
            this.editorTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // editorTxt
            // 
            this.editorTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editorTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorTxt.Location = new System.Drawing.Point(0, 0);
            this.editorTxt.Multiline = true;
            this.editorTxt.Name = "editorTxt";
            this.editorTxt.Size = new System.Drawing.Size(800, 450);
            this.editorTxt.TabIndex = 0;
            // 
            // Frm_Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editorTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Readme Preview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Preview_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Preview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editorTxt;
    }
}