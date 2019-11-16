namespace RandomString
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
            this.printer = new System.Windows.Forms.TextBox();
            this.gen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printer
            // 
            this.printer.Location = new System.Drawing.Point(174, 102);
            this.printer.Name = "printer";
            this.printer.Size = new System.Drawing.Size(245, 20);
            this.printer.TabIndex = 0;
            // 
            // gen
            // 
            this.gen.Location = new System.Drawing.Point(252, 140);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(75, 23);
            this.gen.TabIndex = 1;
            this.gen.Text = "generate";
            this.gen.UseVisualStyleBackColor = true;
            this.gen.Click += new System.EventHandler(this.gen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 281);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.printer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox printer;
        private System.Windows.Forms.Button gen;
    }
}

