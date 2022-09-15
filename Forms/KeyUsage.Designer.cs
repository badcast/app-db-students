namespace DataBaseStudents
{
    partial class KeyUsage
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
            this.enter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.icn = new System.Windows.Forms.PictureBox();
            this.info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icn)).BeginInit();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(148, 96);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 23);
            this.enter.TabIndex = 0;
            this.enter.Text = "Войти";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Идентификационный ключ:\r\n(Потребуется для входа)";
            // 
            // icn
            // 
            this.icn.Image = global::DataBaseStudents.Properties.Resources.icon_warning;
            this.icn.Location = new System.Drawing.Point(12, 146);
            this.icn.Name = "icn";
            this.icn.Size = new System.Drawing.Size(25, 25);
            this.icn.TabIndex = 3;
            this.icn.TabStop = false;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(42, 151);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(47, 13);
            this.info.TabIndex = 4;
            this.info.Text = "(infotext)";
            // 
            // KeyUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 183);
            this.Controls.Add(this.info);
            this.Controls.Add(this.icn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.enter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "KeyUsage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyUsage";
            ((System.ComponentModel.ISupportInitialize)(this.icn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox icn;
        private System.Windows.Forms.Label info;
    }
}