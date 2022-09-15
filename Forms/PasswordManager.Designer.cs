namespace DataBaseStudents
{
    partial class PasswordManager
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
            this.saveBut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createUser = new System.Windows.Forms.Button();
            this.deleteUser = new System.Windows.Forms.Button();
            this.getInfoUserName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveBut
            // 
            this.saveBut.BackColor = System.Drawing.SystemColors.Control;
            this.saveBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.saveBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saveBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBut.Location = new System.Drawing.Point(105, 3);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(81, 34);
            this.saveBut.TabIndex = 0;
            this.saveBut.Text = "Сохранить";
            this.saveBut.UseVisualStyleBackColor = false;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.saveBut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 40);
            this.panel1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 112);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 147);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Это окно редактирует пароли, \r\nкоторое будет использована для входа в программу";
            // 
            // createUser
            // 
            this.createUser.BackColor = System.Drawing.Color.Green;
            this.createUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.createUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createUser.Location = new System.Drawing.Point(213, 76);
            this.createUser.Name = "createUser";
            this.createUser.Size = new System.Drawing.Size(30, 30);
            this.createUser.TabIndex = 0;
            this.createUser.Text = "+";
            this.createUser.UseVisualStyleBackColor = false;
            this.createUser.Click += new System.EventHandler(this.createUser_Click);
            // 
            // deleteUser
            // 
            this.deleteUser.BackColor = System.Drawing.Color.Red;
            this.deleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.deleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteUser.Location = new System.Drawing.Point(242, 76);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(30, 30);
            this.deleteUser.TabIndex = 0;
            this.deleteUser.Text = "-";
            this.deleteUser.UseVisualStyleBackColor = false;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // getInfoUserName
            // 
            this.getInfoUserName.Location = new System.Drawing.Point(12, 76);
            this.getInfoUserName.Name = "getInfoUserName";
            this.getInfoUserName.Size = new System.Drawing.Size(195, 30);
            this.getInfoUserName.TabIndex = 4;
            this.getInfoUserName.Text = "{user select}";
            this.getInfoUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswordManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 305);
            this.Controls.Add(this.getInfoUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createUser);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменение паролей";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createUser;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Label getInfoUserName;
    }
}