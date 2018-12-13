namespace ExerciseH
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
            this.txt_nume = new System.Windows.Forms.TextBox();
            this.txt_text = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nume
            // 
            this.txt_nume.Location = new System.Drawing.Point(12, 12);
            this.txt_nume.Name = "txt_nume";
            this.txt_nume.Size = new System.Drawing.Size(100, 20);
            this.txt_nume.TabIndex = 0;
            this.txt_nume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nume_KeyPress);
            // 
            // txt_text
            // 
            this.txt_text.Location = new System.Drawing.Point(144, 12);
            this.txt_text.Name = "txt_text";
            this.txt_text.Size = new System.Drawing.Size(100, 20);
            this.txt_text.TabIndex = 1;
            this.txt_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_text_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(313, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(27, 58);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 23);
            this.bt1.TabIndex = 3;
            this.bt1.Text = "Añadir";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(160, 58);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 23);
            this.bt2.TabIndex = 4;
            this.bt2.Text = "Añadir";
            this.bt2.UseVisualStyleBackColor = true;
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(324, 58);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(75, 23);
            this.bt3.TabIndex = 5;
            this.bt3.Text = "Guardar";
            this.bt3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 126);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_text);
            this.Controls.Add(this.txt_nume);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nume;
        private System.Windows.Forms.TextBox txt_text;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
    }
}

