namespace PdfToText
{
    partial class Main
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
            this.btn_add = new System.Windows.Forms.Button();
            this.lable1 = new System.Windows.Forms.Label();
            this.tbx_file = new System.Windows.Forms.TextBox();
            this.btn_get_text = new System.Windows.Forms.Button();
            this.btn_save_word = new System.Windows.Forms.Button();
            this.label_drag_drop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(149, 39);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add New File";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lable1.Location = new System.Drawing.Point(12, 86);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(39, 15);
            this.lable1.TabIndex = 1;
            this.lable1.Text = "File :  ";
            // 
            // tbx_file
            // 
            this.tbx_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_file.Location = new System.Drawing.Point(53, 83);
            this.tbx_file.Name = "tbx_file";
            this.tbx_file.ReadOnly = true;
            this.tbx_file.Size = new System.Drawing.Size(285, 21);
            this.tbx_file.TabIndex = 2;
            // 
            // btn_get_text
            // 
            this.btn_get_text.Location = new System.Drawing.Point(12, 122);
            this.btn_get_text.Name = "btn_get_text";
            this.btn_get_text.Size = new System.Drawing.Size(149, 39);
            this.btn_get_text.TabIndex = 3;
            this.btn_get_text.Text = "Get Text";
            this.btn_get_text.UseVisualStyleBackColor = true;
            this.btn_get_text.Click += new System.EventHandler(this.btn_get_text_Click);
            // 
            // btn_save_word
            // 
            this.btn_save_word.Location = new System.Drawing.Point(189, 122);
            this.btn_save_word.Name = "btn_save_word";
            this.btn_save_word.Size = new System.Drawing.Size(149, 39);
            this.btn_save_word.TabIndex = 4;
            this.btn_save_word.Text = "Save as Word";
            this.btn_save_word.UseVisualStyleBackColor = true;
            this.btn_save_word.Click += new System.EventHandler(this.btn_save_word_Click);
            // 
            // label_drag_drop
            // 
            this.label_drag_drop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_drag_drop.Location = new System.Drawing.Point(189, 12);
            this.label_drag_drop.Name = "label_drag_drop";
            this.label_drag_drop.Size = new System.Drawing.Size(149, 39);
            this.label_drag_drop.TabIndex = 5;
            this.label_drag_drop.Text = "Drag Fİle Here";
            this.label_drag_drop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_drag_drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.label_DragDrop);
            this.label_drag_drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.label_drag_drop_DragEnter);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 173);
            this.Controls.Add(this.label_drag_drop);
            this.Controls.Add(this.btn_save_word);
            this.Controls.Add(this.btn_get_text);
            this.Controls.Add(this.tbx_file);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Pdf To Text";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.TextBox tbx_file;
        private System.Windows.Forms.Button btn_get_text;
        private System.Windows.Forms.Button btn_save_word;
        private System.Windows.Forms.Label label_drag_drop;
    }
}

