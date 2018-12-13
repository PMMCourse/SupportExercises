namespace ExerciseF
{
    partial class Form1
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
            this.bt_1 = new System.Windows.Forms.Button();
            this.List1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bt_1
            // 
            this.bt_1.Location = new System.Drawing.Point(36, 158);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(75, 23);
            this.bt_1.TabIndex = 0;
            this.bt_1.Text = "Añadir";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // List1
            // 
            this.List1.FormattingEnabled = true;
            this.List1.Location = new System.Drawing.Point(12, 34);
            this.List1.Name = "List1";
            this.List1.Size = new System.Drawing.Size(120, 95);
            this.List1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 228);
            this.Controls.Add(this.List1);
            this.Controls.Add(this.bt_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.ListBox List1;
    }
}

