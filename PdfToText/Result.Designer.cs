namespace PdfToText
{
    partial class Result
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
            this.tbx_context = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbx_context
            // 
            this.tbx_context.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_context.Location = new System.Drawing.Point(0, 0);
            this.tbx_context.Multiline = true;
            this.tbx_context.Name = "tbx_context";
            this.tbx_context.Size = new System.Drawing.Size(800, 450);
            this.tbx_context.TabIndex = 0;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx_context);
            this.MaximizeBox = false;
            this.Name = "Result";
            this.Text = "Result";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_context;
    }
}