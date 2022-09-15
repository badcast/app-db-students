namespace DataBaseStudents
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортироватьИзФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортироватьИСохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.последниеВыбранныеФорматыToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.wordDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordRTFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picturePDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.абитуриентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьАбитуриентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьАбитуриентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.плагиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.системаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менеджерПаролейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеБазойДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синхронизацияБазыОбновлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверитьОбновлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.оАвторахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.dcNumbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcSpcialities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._mouseMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.@__edit = new System.Windows.Forms.ToolStripMenuItem();
            this.@__add = new System.Windows.Forms.ToolStripMenuItem();
            this.@__delete = new System.Windows.Forms.ToolStripMenuItem();
            this.bottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this._mouseMenu.SuspendLayout();
            this.bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Silver;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menu.GripMargin = new System.Windows.Forms.Padding(0);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.абитуриентToolStripMenuItem,
            this.настройкаToolStripMenuItem,
            this.системаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(0);
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu.Size = new System.Drawing.Size(691, 24);
            this.menu.TabIndex = 0;
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.импортToolStripMenuItem,
            this.экспортToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // импортToolStripMenuItem
            // 
            this.импортToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.импортироватьИзФайлаToolStripMenuItem});
            this.импортToolStripMenuItem.Name = "импортToolStripMenuItem";
            this.импортToolStripMenuItem.ShowShortcutKeys = false;
            this.импортToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.импортToolStripMenuItem.Text = "Импорт";
            // 
            // импортироватьИзФайлаToolStripMenuItem
            // 
            this.импортироватьИзФайлаToolStripMenuItem.Name = "импортироватьИзФайлаToolStripMenuItem";
            this.импортироватьИзФайлаToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.импортироватьИзФайлаToolStripMenuItem.Text = "Импортировать из файла";
            this.импортироватьИзФайлаToolStripMenuItem.Click += new System.EventHandler(this.импортироватьИзФайлаToolStripMenuItem_Click);
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.экспортироватьИСохранитьToolStripMenuItem,
            this.последниеВыбранныеФорматыToolStripMenuItem,
            this.wordDocToolStripMenuItem,
            this.wordRTFToolStripMenuItem,
            this.excelToolStripMenuItem,
            this.picturePDFToolStripMenuItem});
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.экспортToolStripMenuItem.Text = "Экспорт";
            // 
            // экспортироватьИСохранитьToolStripMenuItem
            // 
            this.экспортироватьИСохранитьToolStripMenuItem.Name = "экспортироватьИСохранитьToolStripMenuItem";
            this.экспортироватьИСохранитьToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
            this.экспортироватьИСохранитьToolStripMenuItem.Text = "Экспортировать в другой формат";
            this.экспортироватьИСохранитьToolStripMenuItem.Click += new System.EventHandler(this.экспортироватьИСохранитьToolStripMenuItem_Click);
            // 
            // последниеВыбранныеФорматыToolStripMenuItem
            // 
            this.последниеВыбранныеФорматыToolStripMenuItem.Name = "последниеВыбранныеФорматыToolStripMenuItem";
            this.последниеВыбранныеФорматыToolStripMenuItem.Size = new System.Drawing.Size(290, 6);
            // 
            // wordDocToolStripMenuItem
            // 
            this.wordDocToolStripMenuItem.Name = "wordDocToolStripMenuItem";
            this.wordDocToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
            this.wordDocToolStripMenuItem.Text = "Word DOC";
            this.wordDocToolStripMenuItem.Click += new System.EventHandler(this.wordDocToolStripMenuItem_Click);
            // 
            // wordRTFToolStripMenuItem
            // 
            this.wordRTFToolStripMenuItem.Name = "wordRTFToolStripMenuItem";
            this.wordRTFToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
            this.wordRTFToolStripMenuItem.Text = "Word RTF";
            this.wordRTFToolStripMenuItem.Click += new System.EventHandler(this.wordRTFToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
            this.excelToolStripMenuItem.Text = "Excel XLSX";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // picturePDFToolStripMenuItem
            // 
            this.picturePDFToolStripMenuItem.Name = "picturePDFToolStripMenuItem";
            this.picturePDFToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
            this.picturePDFToolStripMenuItem.Text = "Picture PDF";
            this.picturePDFToolStripMenuItem.Click += new System.EventHandler(this.picturePDFToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // абитуриентToolStripMenuItem
            // 
            this.абитуриентToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключитьToolStripMenuItem,
            this.удалитьАбитуриентаToolStripMenuItem,
            this.изменитьАбитуриентаToolStripMenuItem});
            this.абитуриентToolStripMenuItem.Name = "абитуриентToolStripMenuItem";
            this.абитуриентToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.абитуриентToolStripMenuItem.Text = "Действия";
            // 
            // подключитьToolStripMenuItem
            // 
            this.подключитьToolStripMenuItem.Name = "подключитьToolStripMenuItem";
            this.подключитьToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.подключитьToolStripMenuItem.Text = "Добавить абитуриента";
            this.подключитьToolStripMenuItem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // удалитьАбитуриентаToolStripMenuItem
            // 
            this.удалитьАбитуриентаToolStripMenuItem.Name = "удалитьАбитуриентаToolStripMenuItem";
            this.удалитьАбитуриентаToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.удалитьАбитуриентаToolStripMenuItem.Text = "Удалить абитуриента";
            this.удалитьАбитуриентаToolStripMenuItem.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // изменитьАбитуриентаToolStripMenuItem
            // 
            this.изменитьАбитуриентаToolStripMenuItem.Name = "изменитьАбитуриентаToolStripMenuItem";
            this.изменитьАбитуриентаToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.изменитьАбитуриентаToolStripMenuItem.Text = "Изменить абитуриента";
            this.изменитьАбитуриентаToolStripMenuItem.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.плагиныToolStripMenuItem});
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.настройкаToolStripMenuItem.Text = "Настройки";
            // 
            // плагиныToolStripMenuItem
            // 
            this.плагиныToolStripMenuItem.Enabled = false;
            this.плагиныToolStripMenuItem.Name = "плагиныToolStripMenuItem";
            this.плагиныToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.плагиныToolStripMenuItem.Text = "Плагины";
            // 
            // системаToolStripMenuItem
            // 
            this.системаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менеджерПаролейToolStripMenuItem,
            this.управлениеБазойДанныхToolStripMenuItem,
            this.синхронизацияБазыОбновлениеToolStripMenuItem});
            this.системаToolStripMenuItem.Name = "системаToolStripMenuItem";
            this.системаToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.системаToolStripMenuItem.Text = "Система";
            // 
            // менеджерПаролейToolStripMenuItem
            // 
            this.менеджерПаролейToolStripMenuItem.Name = "менеджерПаролейToolStripMenuItem";
            this.менеджерПаролейToolStripMenuItem.Size = new System.Drawing.Size(303, 24);
            this.менеджерПаролейToolStripMenuItem.Text = "Менеджер паролей";
            this.менеджерПаролейToolStripMenuItem.Click += new System.EventHandler(this.менеджерПаролейToolStripMenuItem_Click);
            // 
            // управлениеБазойДанныхToolStripMenuItem
            // 
            this.управлениеБазойДанныхToolStripMenuItem.Enabled = false;
            this.управлениеБазойДанныхToolStripMenuItem.Name = "управлениеБазойДанныхToolStripMenuItem";
            this.управлениеБазойДанныхToolStripMenuItem.Size = new System.Drawing.Size(303, 24);
            this.управлениеБазойДанныхToolStripMenuItem.Text = "Управление базой данных";
            // 
            // синхронизацияБазыОбновлениеToolStripMenuItem
            // 
            this.синхронизацияБазыОбновлениеToolStripMenuItem.Enabled = false;
            this.синхронизацияБазыОбновлениеToolStripMenuItem.Name = "синхронизацияБазыОбновлениеToolStripMenuItem";
            this.синхронизацияБазыОбновлениеToolStripMenuItem.Size = new System.Drawing.Size(303, 24);
            this.синхронизацияБазыОбновлениеToolStripMenuItem.Text = "Синхронизация базы (Обновление)";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проверитьОбновлениеToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.toolStripMenuItem2,
            this.оАвторахToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.оПрограммеToolStripMenuItem.Text = "Помощь";
            // 
            // проверитьОбновлениеToolStripMenuItem
            // 
            this.проверитьОбновлениеToolStripMenuItem.Enabled = false;
            this.проверитьОбновлениеToolStripMenuItem.Name = "проверитьОбновлениеToolStripMenuItem";
            this.проверитьОбновлениеToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.проверитьОбновлениеToolStripMenuItem.Text = "Проверить обновление";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Enabled = false;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 6);
            // 
            // оАвторахToolStripMenuItem
            // 
            this.оАвторахToolStripMenuItem.Enabled = false;
            this.оАвторахToolStripMenuItem.Name = "оАвторахToolStripMenuItem";
            this.оАвторахToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.оАвторахToolStripMenuItem.Text = "О программе";
            this.оАвторахToolStripMenuItem.Click += new System.EventHandler(this.оАвторахToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(691, 27);
            this.panel1.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::DataBaseStudents.Properties.Resources.bd_edit;
            this.btnEdit.Location = new System.Drawing.Point(51, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(25, 25);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::DataBaseStudents.Properties.Resources.bd_del;
            this.btnDelete.Location = new System.Drawing.Point(26, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(25, 25);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::DataBaseStudents.Properties.Resources.bd_add;
            this.btnAdd.Location = new System.Drawing.Point(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToResizeRows = false;
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.BackgroundColor = System.Drawing.Color.DimGray;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data.ColumnHeadersHeight = 30;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcNumbers,
            this.dcNames,
            this.dcDate,
            this.dcSpcialities});
            this.data.ContextMenuStrip = this._mouseMenu;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle1;
            this.data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data.Location = new System.Drawing.Point(0, 51);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.data.RowHeadersVisible = false;
            this.data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data.Size = new System.Drawing.Size(691, 284);
            this.data.TabIndex = 1;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            this.data.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.data_RowStateChanged);
            this.data.KeyDown += new System.Windows.Forms.KeyEventHandler(this.data_KeyDown);
            // 
            // dcNumbers
            // 
            this.dcNumbers.FillWeight = 33.92514F;
            this.dcNumbers.HeaderText = "№";
            this.dcNumbers.Name = "dcNumbers";
            this.dcNumbers.ReadOnly = true;
            // 
            // dcNames
            // 
            this.dcNames.FillWeight = 203.0457F;
            this.dcNames.HeaderText = "ФИО Абитуриента";
            this.dcNames.Name = "dcNames";
            this.dcNames.ReadOnly = true;
            // 
            // dcDate
            // 
            this.dcDate.FillWeight = 81.51458F;
            this.dcDate.HeaderText = "Дата рождения";
            this.dcDate.Name = "dcDate";
            this.dcDate.ReadOnly = true;
            // 
            // dcSpcialities
            // 
            this.dcSpcialities.FillWeight = 81.51458F;
            this.dcSpcialities.HeaderText = "Специальность";
            this.dcSpcialities.Name = "dcSpcialities";
            this.dcSpcialities.ReadOnly = true;
            // 
            // _mouseMenu
            // 
            this._mouseMenu.BackColor = System.Drawing.Color.DarkGray;
            this._mouseMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.@__edit,
            this.@__add,
            this.@__delete});
            this._mouseMenu.Name = "_mouseMenu";
            this._mouseMenu.Size = new System.Drawing.Size(155, 70);
            // 
            // __edit
            // 
            this.@__edit.Image = global::DataBaseStudents.Properties.Resources.bd_edit;
            this.@__edit.Name = "__edit";
            this.@__edit.Size = new System.Drawing.Size(154, 22);
            this.@__edit.Text = "&Редактировать";
            this.@__edit.Click += new System.EventHandler(this.@__edit_Click);
            // 
            // __add
            // 
            this.@__add.Image = global::DataBaseStudents.Properties.Resources.bd_add;
            this.@__add.Name = "__add";
            this.@__add.Size = new System.Drawing.Size(154, 22);
            this.@__add.Text = "Добавить";
            this.@__add.Click += new System.EventHandler(this.@__add_Click);
            // 
            // __delete
            // 
            this.@__delete.Image = global::DataBaseStudents.Properties.Resources.bd_del;
            this.@__delete.Name = "__delete";
            this.@__delete.Size = new System.Drawing.Size(154, 22);
            this.@__delete.Text = "Удалить";
            this.@__delete.Click += new System.EventHandler(this.@__delete_Click);
            // 
            // bottom
            // 
            this.bottom.Controls.Add(this.label1);
            this.bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom.Location = new System.Drawing.Point(0, 335);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(691, 49);
            this.bottom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "База данных абитуриентов. Это программа свободна в использований.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(691, 384);
            this.Controls.Add(this.data);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.bottom);
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Main";
            this.Text = "База данных Абитуриентов";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this._mouseMenu.ResumeLayout(false);
            this.bottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem абитуриентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оАвторахToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcNumbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcSpcialities;
        private System.Windows.Forms.ToolStripMenuItem удалитьАбитуриентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьАбитуриентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem системаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менеджерПаролейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеБазойДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синхронизацияБазыОбновлениеToolStripMenuItem;
        public System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem проверитьОбновлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортироватьИСохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортироватьИзФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator последниеВыбранныеФорматыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordDocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordRTFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem picturePDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Panel bottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem настройкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem плагиныToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip _mouseMenu;
        private System.Windows.Forms.ToolStripMenuItem __edit;
        private System.Windows.Forms.ToolStripMenuItem __add;
        private System.Windows.Forms.ToolStripMenuItem __delete;
    }
}

