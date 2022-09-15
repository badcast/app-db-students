namespace DataBaseStudents
{
    partial class Importer
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
            this.rb_deleteAll = new System.Windows.Forms.RadioButton();
            this.@__radio_addType = new System.Windows.Forms.Panel();
            this.rb_addNewOnReplace = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.askPanel = new System.Windows.Forms.Panel();
            this.rb_askAutoDelete = new System.Windows.Forms.RadioButton();
            this.rb_askDetail = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bImport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.Label();
            this.l_ext = new System.Windows.Forms.Label();
            this.l_ver = new System.Windows.Forms.Label();
            this.@__radio_addType.SuspendLayout();
            this.askPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_deleteAll
            // 
            this.rb_deleteAll.AutoSize = true;
            this.rb_deleteAll.Checked = true;
            this.rb_deleteAll.Location = new System.Drawing.Point(12, 3);
            this.rb_deleteAll.Name = "rb_deleteAll";
            this.rb_deleteAll.Size = new System.Drawing.Size(191, 17);
            this.rb_deleteAll.TabIndex = 0;
            this.rb_deleteAll.TabStop = true;
            this.rb_deleteAll.Text = "Удалить все (не рекомендуется)";
            this.rb_deleteAll.UseVisualStyleBackColor = true;
            // 
            // __radio_addType
            // 
            this.@__radio_addType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.@__radio_addType.Controls.Add(this.rb_addNewOnReplace);
            this.@__radio_addType.Controls.Add(this.rb_deleteAll);
            this.@__radio_addType.Location = new System.Drawing.Point(12, 24);
            this.@__radio_addType.Name = "__radio_addType";
            this.@__radio_addType.Size = new System.Drawing.Size(321, 50);
            this.@__radio_addType.TabIndex = 1;
            // 
            // rb_addNewOnReplace
            // 
            this.rb_addNewOnReplace.AutoSize = true;
            this.rb_addNewOnReplace.Location = new System.Drawing.Point(12, 26);
            this.rb_addNewOnReplace.Name = "rb_addNewOnReplace";
            this.rb_addNewOnReplace.Size = new System.Drawing.Size(231, 17);
            this.rb_addNewOnReplace.TabIndex = 1;
            this.rb_addNewOnReplace.Text = "Добавлять новое, спрашивать о замене";
            this.rb_addNewOnReplace.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип импорта";
            // 
            // askPanel
            // 
            this.askPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.askPanel.Controls.Add(this.rb_askAutoDelete);
            this.askPanel.Controls.Add(this.rb_askDetail);
            this.askPanel.Enabled = false;
            this.askPanel.Location = new System.Drawing.Point(12, 99);
            this.askPanel.Name = "askPanel";
            this.askPanel.Size = new System.Drawing.Size(321, 50);
            this.askPanel.TabIndex = 2;
            // 
            // rb_askAutoDelete
            // 
            this.rb_askAutoDelete.AutoSize = true;
            this.rb_askAutoDelete.Location = new System.Drawing.Point(12, 26);
            this.rb_askAutoDelete.Name = "rb_askAutoDelete";
            this.rb_askAutoDelete.Size = new System.Drawing.Size(152, 17);
            this.rb_askAutoDelete.TabIndex = 1;
            this.rb_askAutoDelete.Text = "Автоматический удалить";
            this.rb_askAutoDelete.UseVisualStyleBackColor = true;
            // 
            // rb_askDetail
            // 
            this.rb_askDetail.AutoSize = true;
            this.rb_askDetail.Checked = true;
            this.rb_askDetail.Location = new System.Drawing.Point(12, 3);
            this.rb_askDetail.Name = "rb_askDetail";
            this.rb_askDetail.Size = new System.Drawing.Size(219, 17);
            this.rb_askDetail.TabIndex = 0;
            this.rb_askDetail.TabStop = true;
            this.rb_askDetail.Text = "Спрашивать подробными сведениями";
            this.rb_askDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип уведомления о замене";
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(258, 251);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bImport
            // 
            this.bImport.Location = new System.Drawing.Point(177, 251);
            this.bImport.Name = "bImport";
            this.bImport.Size = new System.Drawing.Size(75, 23);
            this.bImport.TabIndex = 5;
            this.bImport.Text = "Импорт";
            this.bImport.UseVisualStyleBackColor = true;
            this.bImport.Click += new System.EventHandler(this.bImport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Подробная информация:";
            // 
            // l_name
            // 
            this.l_name.Location = new System.Drawing.Point(12, 178);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(321, 13);
            this.l_name.TabIndex = 7;
            this.l_name.Text = "{plugin_name}";
            // 
            // l_ext
            // 
            this.l_ext.Location = new System.Drawing.Point(12, 191);
            this.l_ext.Name = "l_ext";
            this.l_ext.Size = new System.Drawing.Size(321, 13);
            this.l_ext.TabIndex = 8;
            this.l_ext.Text = "{plugin_ext}";
            // 
            // l_ver
            // 
            this.l_ver.Location = new System.Drawing.Point(12, 204);
            this.l_ver.Name = "l_ver";
            this.l_ver.Size = new System.Drawing.Size(321, 13);
            this.l_ver.TabIndex = 9;
            this.l_ver.Text = "{plugin_ver}";
            // 
            // Importer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 286);
            this.Controls.Add(this.l_ver);
            this.Controls.Add(this.l_ext);
            this.Controls.Add(this.l_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bImport);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.askPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.@__radio_addType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Importer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка импорта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Importer_FormClosing);
            this.Load += new System.EventHandler(this.Importer_Load);
            this.@__radio_addType.ResumeLayout(false);
            this.@__radio_addType.PerformLayout();
            this.askPanel.ResumeLayout(false);
            this.askPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_deleteAll;
        private System.Windows.Forms.Panel __radio_addType;
        private System.Windows.Forms.RadioButton rb_addNewOnReplace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel askPanel;
        private System.Windows.Forms.RadioButton rb_askAutoDelete;
        private System.Windows.Forms.RadioButton rb_askDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bImport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label l_ext;
        private System.Windows.Forms.Label l_ver;
    }
}