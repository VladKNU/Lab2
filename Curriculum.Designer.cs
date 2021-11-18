
namespace XML
{
    partial class Curriculum
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Curriculum));
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.URLlabel = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SectionCheckBox = new System.Windows.Forms.CheckBox();
            this.DepartmentCheckBox = new System.Windows.Forms.CheckBox();
            this.FaculityComboBox = new System.Windows.Forms.ComboBox();
            this.SectionComboBox = new System.Windows.Forms.ComboBox();
            this.CurriculumComboBox = new System.Windows.Forms.ComboBox();
            this.AudienceComboBox = new System.Windows.Forms.ComboBox();
            this.CathedraComboBox = new System.Windows.Forms.ComboBox();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameComboBox = new System.Windows.Forms.ComboBox();
            this.CurriculumCheckBox = new System.Windows.Forms.CheckBox();
            this.AudienceCheckBox = new System.Windows.Forms.CheckBox();
            this.CathedraCheckBox = new System.Windows.Forms.CheckBox();
            this.FacultyCheckBox = new System.Windows.Forms.CheckBox();
            this.OpenHtmlButton = new System.Windows.Forms.Button();
            this.CleanButton = new System.Windows.Forms.Button();
            this.ToHtmlButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.LINQRadioButton = new System.Windows.Forms.RadioButton();
            this.DOMRadioButton = new System.Windows.Forms.RadioButton();
            this.SAXRadioButton = new System.Windows.Forms.RadioButton();
            this.wind = new System.Windows.Forms.RichTextBox();
            this.NameCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OpenPartButton = new System.Windows.Forms.Button();
            this.ConvertPartButton = new System.Windows.Forms.Button();
            this.MyDataGridView = new System.Windows.Forms.DataGridView();
            this.FacultyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CathedraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AudienceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurriculumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // URLlabel
            // 
            this.URLlabel.AutoSize = true;
            this.URLlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.URLlabel.Location = new System.Drawing.Point(268, 41);
            this.URLlabel.Name = "URLlabel";
            this.URLlabel.Size = new System.Drawing.Size(50, 15);
            this.URLlabel.TabIndex = 48;
            this.URLlabel.Text = "File URL";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // SectionCheckBox
            // 
            this.SectionCheckBox.AutoSize = true;
            this.SectionCheckBox.ForeColor = System.Drawing.Color.Gold;
            this.SectionCheckBox.Location = new System.Drawing.Point(16, 122);
            this.SectionCheckBox.Name = "SectionCheckBox";
            this.SectionCheckBox.Size = new System.Drawing.Size(62, 17);
            this.SectionCheckBox.TabIndex = 47;
            this.SectionCheckBox.Text = "Section";
            this.SectionCheckBox.UseVisualStyleBackColor = true;
            this.SectionCheckBox.CheckedChanged += new System.EventHandler(this.SectionCheckBox_CheckedChanged);
            // 
            // DepartmentCheckBox
            // 
            this.DepartmentCheckBox.AutoSize = true;
            this.DepartmentCheckBox.ForeColor = System.Drawing.Color.Gold;
            this.DepartmentCheckBox.Location = new System.Drawing.Point(16, 95);
            this.DepartmentCheckBox.Name = "DepartmentCheckBox";
            this.DepartmentCheckBox.Size = new System.Drawing.Size(81, 17);
            this.DepartmentCheckBox.TabIndex = 46;
            this.DepartmentCheckBox.Text = "Department";
            this.DepartmentCheckBox.UseVisualStyleBackColor = true;
            this.DepartmentCheckBox.CheckedChanged += new System.EventHandler(this.DepartmentCheckBox_CheckedChanged);
            // 
            // FaculityComboBox
            // 
            this.FaculityComboBox.BackColor = System.Drawing.Color.Gold;
            this.FaculityComboBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FaculityComboBox.FormattingEnabled = true;
            this.FaculityComboBox.Location = new System.Drawing.Point(130, 66);
            this.FaculityComboBox.Name = "FaculityComboBox";
            this.FaculityComboBox.Size = new System.Drawing.Size(121, 21);
            this.FaculityComboBox.TabIndex = 45;
            // 
            // SectionComboBox
            // 
            this.SectionComboBox.BackColor = System.Drawing.Color.Gold;
            this.SectionComboBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.SectionComboBox.FormattingEnabled = true;
            this.SectionComboBox.Location = new System.Drawing.Point(130, 120);
            this.SectionComboBox.Name = "SectionComboBox";
            this.SectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.SectionComboBox.TabIndex = 44;
            // 
            // CurriculumComboBox
            // 
            this.CurriculumComboBox.BackColor = System.Drawing.Color.Gold;
            this.CurriculumComboBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CurriculumComboBox.FormattingEnabled = true;
            this.CurriculumComboBox.Location = new System.Drawing.Point(130, 201);
            this.CurriculumComboBox.Name = "CurriculumComboBox";
            this.CurriculumComboBox.Size = new System.Drawing.Size(121, 21);
            this.CurriculumComboBox.TabIndex = 43;
            // 
            // AudienceComboBox
            // 
            this.AudienceComboBox.BackColor = System.Drawing.Color.Gold;
            this.AudienceComboBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.AudienceComboBox.FormattingEnabled = true;
            this.AudienceComboBox.Location = new System.Drawing.Point(130, 174);
            this.AudienceComboBox.Name = "AudienceComboBox";
            this.AudienceComboBox.Size = new System.Drawing.Size(121, 21);
            this.AudienceComboBox.TabIndex = 42;
            // 
            // CathedraComboBox
            // 
            this.CathedraComboBox.BackColor = System.Drawing.Color.Gold;
            this.CathedraComboBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CathedraComboBox.FormattingEnabled = true;
            this.CathedraComboBox.Location = new System.Drawing.Point(130, 147);
            this.CathedraComboBox.Name = "CathedraComboBox";
            this.CathedraComboBox.Size = new System.Drawing.Size(121, 21);
            this.CathedraComboBox.TabIndex = 41;
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.BackColor = System.Drawing.Color.Gold;
            this.DepartmentComboBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(130, 93);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(121, 21);
            this.DepartmentComboBox.TabIndex = 40;
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.HelpToolStripMenuItem.Text = "Help!";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // NameComboBox
            // 
            this.NameComboBox.BackColor = System.Drawing.Color.Gold;
            this.NameComboBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.NameComboBox.FormattingEnabled = true;
            this.NameComboBox.Location = new System.Drawing.Point(130, 39);
            this.NameComboBox.Name = "NameComboBox";
            this.NameComboBox.Size = new System.Drawing.Size(121, 21);
            this.NameComboBox.TabIndex = 39;
            // 
            // CurriculumCheckBox
            // 
            this.CurriculumCheckBox.AutoSize = true;
            this.CurriculumCheckBox.ForeColor = System.Drawing.Color.Gold;
            this.CurriculumCheckBox.Location = new System.Drawing.Point(16, 203);
            this.CurriculumCheckBox.Name = "CurriculumCheckBox";
            this.CurriculumCheckBox.Size = new System.Drawing.Size(75, 17);
            this.CurriculumCheckBox.TabIndex = 38;
            this.CurriculumCheckBox.Text = "Curriculum";
            this.CurriculumCheckBox.UseVisualStyleBackColor = true;
            this.CurriculumCheckBox.CheckedChanged += new System.EventHandler(this.CurriculumCheckBox_CheckedChanged);
            // 
            // AudienceCheckBox
            // 
            this.AudienceCheckBox.AutoSize = true;
            this.AudienceCheckBox.ForeColor = System.Drawing.Color.Gold;
            this.AudienceCheckBox.Location = new System.Drawing.Point(16, 176);
            this.AudienceCheckBox.Name = "AudienceCheckBox";
            this.AudienceCheckBox.Size = new System.Drawing.Size(71, 17);
            this.AudienceCheckBox.TabIndex = 37;
            this.AudienceCheckBox.Text = "Audience";
            this.AudienceCheckBox.UseVisualStyleBackColor = true;
            this.AudienceCheckBox.CheckedChanged += new System.EventHandler(this.AudienceCheckBox_CheckedChanged);
            // 
            // CathedraCheckBox
            // 
            this.CathedraCheckBox.AutoSize = true;
            this.CathedraCheckBox.ForeColor = System.Drawing.Color.Gold;
            this.CathedraCheckBox.Location = new System.Drawing.Point(16, 149);
            this.CathedraCheckBox.Name = "CathedraCheckBox";
            this.CathedraCheckBox.Size = new System.Drawing.Size(69, 17);
            this.CathedraCheckBox.TabIndex = 36;
            this.CathedraCheckBox.Text = "Cathedra";
            this.CathedraCheckBox.UseVisualStyleBackColor = true;
            this.CathedraCheckBox.CheckedChanged += new System.EventHandler(this.CathedraCheckBox_CheckedChanged);
            // 
            // FacultyCheckBox
            // 
            this.FacultyCheckBox.AutoSize = true;
            this.FacultyCheckBox.ForeColor = System.Drawing.Color.Gold;
            this.FacultyCheckBox.Location = new System.Drawing.Point(16, 68);
            this.FacultyCheckBox.Name = "FacultyCheckBox";
            this.FacultyCheckBox.Size = new System.Drawing.Size(60, 17);
            this.FacultyCheckBox.TabIndex = 35;
            this.FacultyCheckBox.Text = "Faculty";
            this.FacultyCheckBox.UseVisualStyleBackColor = true;
            this.FacultyCheckBox.CheckedChanged += new System.EventHandler(this.FacultyCheckBox_CheckedChanged);
            // 
            // OpenHtmlButton
            // 
            this.OpenHtmlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.OpenHtmlButton.Location = new System.Drawing.Point(12, 309);
            this.OpenHtmlButton.Name = "OpenHtmlButton";
            this.OpenHtmlButton.Size = new System.Drawing.Size(58, 84);
            this.OpenHtmlButton.TabIndex = 34;
            this.OpenHtmlButton.Text = "Open HTML";
            this.OpenHtmlButton.UseVisualStyleBackColor = false;
            this.OpenHtmlButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.CleanButton.Location = new System.Drawing.Point(12, 399);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(250, 45);
            this.CleanButton.TabIndex = 33;
            this.CleanButton.Text = "Clean";
            this.CleanButton.UseVisualStyleBackColor = false;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // ToHtmlButton
            // 
            this.ToHtmlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.ToHtmlButton.Location = new System.Drawing.Point(76, 309);
            this.ToHtmlButton.Name = "ToHtmlButton";
            this.ToHtmlButton.Size = new System.Drawing.Size(58, 84);
            this.ToHtmlButton.TabIndex = 32;
            this.ToHtmlButton.Text = "Convert to HTML";
            this.ToHtmlButton.UseVisualStyleBackColor = false;
            this.ToHtmlButton.Click += new System.EventHandler(this.ToHtmlButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(12, 258);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(250, 45);
            this.SearchButton.TabIndex = 31;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // LINQRadioButton
            // 
            this.LINQRadioButton.AutoSize = true;
            this.LINQRadioButton.ForeColor = System.Drawing.Color.Gold;
            this.LINQRadioButton.Location = new System.Drawing.Point(160, 235);
            this.LINQRadioButton.Name = "LINQRadioButton";
            this.LINQRadioButton.Size = new System.Drawing.Size(50, 17);
            this.LINQRadioButton.TabIndex = 30;
            this.LINQRadioButton.TabStop = true;
            this.LINQRadioButton.Text = "LINQ";
            this.LINQRadioButton.UseVisualStyleBackColor = true;
            // 
            // DOMRadioButton
            // 
            this.DOMRadioButton.AutoSize = true;
            this.DOMRadioButton.ForeColor = System.Drawing.Color.Gold;
            this.DOMRadioButton.Location = new System.Drawing.Point(104, 235);
            this.DOMRadioButton.Name = "DOMRadioButton";
            this.DOMRadioButton.Size = new System.Drawing.Size(50, 17);
            this.DOMRadioButton.TabIndex = 29;
            this.DOMRadioButton.TabStop = true;
            this.DOMRadioButton.Text = "DOM";
            this.DOMRadioButton.UseVisualStyleBackColor = true;
            // 
            // SAXRadioButton
            // 
            this.SAXRadioButton.AutoSize = true;
            this.SAXRadioButton.ForeColor = System.Drawing.Color.Gold;
            this.SAXRadioButton.Location = new System.Drawing.Point(52, 235);
            this.SAXRadioButton.Name = "SAXRadioButton";
            this.SAXRadioButton.Size = new System.Drawing.Size(46, 17);
            this.SAXRadioButton.TabIndex = 28;
            this.SAXRadioButton.TabStop = true;
            this.SAXRadioButton.Text = "SAX";
            this.SAXRadioButton.UseVisualStyleBackColor = true;
            // 
            // wind
            // 
            this.wind.BackColor = System.Drawing.Color.Black;
            this.wind.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wind.ForeColor = System.Drawing.Color.Gold;
            this.wind.Location = new System.Drawing.Point(268, 399);
            this.wind.Name = "wind";
            this.wind.Size = new System.Drawing.Size(520, 45);
            this.wind.TabIndex = 27;
            this.wind.Text = "";
            // 
            // NameCheckBox
            // 
            this.NameCheckBox.AutoSize = true;
            this.NameCheckBox.ForeColor = System.Drawing.Color.Gold;
            this.NameCheckBox.Location = new System.Drawing.Point(16, 41);
            this.NameCheckBox.Name = "NameCheckBox";
            this.NameCheckBox.Size = new System.Drawing.Size(54, 17);
            this.NameCheckBox.TabIndex = 26;
            this.NameCheckBox.Text = "Name";
            this.NameCheckBox.UseVisualStyleBackColor = true;
            this.NameCheckBox.CheckedChanged += new System.EventHandler(this.NameCheckBox_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.HelpToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1089, 24);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OpenPartButton
            // 
            this.OpenPartButton.Location = new System.Drawing.Point(140, 309);
            this.OpenPartButton.Name = "OpenPartButton";
            this.OpenPartButton.Size = new System.Drawing.Size(58, 83);
            this.OpenPartButton.TabIndex = 50;
            this.OpenPartButton.Text = "Open Part HTML";
            this.OpenPartButton.UseVisualStyleBackColor = true;
            this.OpenPartButton.Click += new System.EventHandler(this.OpenPartButton_Click);
            // 
            // ConvertPartButton
            // 
            this.ConvertPartButton.Location = new System.Drawing.Point(204, 309);
            this.ConvertPartButton.Name = "ConvertPartButton";
            this.ConvertPartButton.Size = new System.Drawing.Size(58, 83);
            this.ConvertPartButton.TabIndex = 51;
            this.ConvertPartButton.Text = "Convert Part to HTML";
            this.ConvertPartButton.UseVisualStyleBackColor = true;
            this.ConvertPartButton.Click += new System.EventHandler(this.ConvertPartButton_Click);
            // 
            // MyDataGridView
            // 
            this.MyDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MyDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FacultyColumn,
            this.DepartmentColumn,
            this.SectionColumn,
            this.NameColumn,
            this.CathedraColumn,
            this.AudienceColumn,
            this.CurriculumColumn,
            this.StudentsColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MyDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.MyDataGridView.Location = new System.Drawing.Point(268, 59);
            this.MyDataGridView.Name = "MyDataGridView";
            this.MyDataGridView.RowHeadersVisible = false;
            this.MyDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.MyDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyDataGridView.RowTemplate.Height = 70;
            this.MyDataGridView.Size = new System.Drawing.Size(814, 334);
            this.MyDataGridView.TabIndex = 52;
            // 
            // FacultyColumn
            // 
            this.FacultyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FacultyColumn.FillWeight = 65F;
            this.FacultyColumn.HeaderText = "Faculty";
            this.FacultyColumn.Name = "FacultyColumn";
            this.FacultyColumn.ReadOnly = true;
            // 
            // DepartmentColumn
            // 
            this.DepartmentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DepartmentColumn.HeaderText = "Department";
            this.DepartmentColumn.Name = "DepartmentColumn";
            this.DepartmentColumn.ReadOnly = true;
            // 
            // SectionColumn
            // 
            this.SectionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SectionColumn.HeaderText = "Section";
            this.SectionColumn.Name = "SectionColumn";
            this.SectionColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // CathedraColumn
            // 
            this.CathedraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CathedraColumn.HeaderText = "Cathedra";
            this.CathedraColumn.Name = "CathedraColumn";
            this.CathedraColumn.ReadOnly = true;
            // 
            // AudienceColumn
            // 
            this.AudienceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AudienceColumn.FillWeight = 55F;
            this.AudienceColumn.HeaderText = "Audience";
            this.AudienceColumn.Name = "AudienceColumn";
            this.AudienceColumn.ReadOnly = true;
            // 
            // CurriculumColumn
            // 
            this.CurriculumColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CurriculumColumn.HeaderText = "Curriculum";
            this.CurriculumColumn.Name = "CurriculumColumn";
            this.CurriculumColumn.ReadOnly = true;
            // 
            // StudentsColumn
            // 
            this.StudentsColumn.HeaderText = "Students";
            this.StudentsColumn.Name = "StudentsColumn";
            this.StudentsColumn.ReadOnly = true;
            this.StudentsColumn.Width = 140;
            // 
            // Curriculum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.MyDataGridView);
            this.Controls.Add(this.ConvertPartButton);
            this.Controls.Add(this.OpenPartButton);
            this.Controls.Add(this.URLlabel);
            this.Controls.Add(this.SectionCheckBox);
            this.Controls.Add(this.DepartmentCheckBox);
            this.Controls.Add(this.FaculityComboBox);
            this.Controls.Add(this.SectionComboBox);
            this.Controls.Add(this.CurriculumComboBox);
            this.Controls.Add(this.AudienceComboBox);
            this.Controls.Add(this.CathedraComboBox);
            this.Controls.Add(this.DepartmentComboBox);
            this.Controls.Add(this.NameComboBox);
            this.Controls.Add(this.CurriculumCheckBox);
            this.Controls.Add(this.AudienceCheckBox);
            this.Controls.Add(this.CathedraCheckBox);
            this.Controls.Add(this.FacultyCheckBox);
            this.Controls.Add(this.OpenHtmlButton);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.ToHtmlButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LINQRadioButton);
            this.Controls.Add(this.DOMRadioButton);
            this.Controls.Add(this.SAXRadioButton);
            this.Controls.Add(this.wind);
            this.Controls.Add(this.NameCheckBox);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Curriculum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curriculum";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyTimeTable_FormClosing);
            this.Load += new System.EventHandler(this.MyTimeTable_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.Label URLlabel;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.CheckBox SectionCheckBox;
        private System.Windows.Forms.CheckBox DepartmentCheckBox;
        private System.Windows.Forms.ComboBox FaculityComboBox;
        private System.Windows.Forms.ComboBox SectionComboBox;
        private System.Windows.Forms.ComboBox CurriculumComboBox;
        private System.Windows.Forms.ComboBox AudienceComboBox;
        private System.Windows.Forms.ComboBox CathedraComboBox;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ComboBox NameComboBox;
        private System.Windows.Forms.CheckBox CurriculumCheckBox;
        private System.Windows.Forms.CheckBox AudienceCheckBox;
        private System.Windows.Forms.CheckBox CathedraCheckBox;
        private System.Windows.Forms.CheckBox FacultyCheckBox;
        private System.Windows.Forms.Button OpenHtmlButton;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.Button ToHtmlButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.RadioButton LINQRadioButton;
        private System.Windows.Forms.RadioButton DOMRadioButton;
        private System.Windows.Forms.RadioButton SAXRadioButton;
        private System.Windows.Forms.RichTextBox wind;
        private System.Windows.Forms.CheckBox NameCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button OpenPartButton;
        private System.Windows.Forms.Button ConvertPartButton;
        private System.Windows.Forms.DataGridView MyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CathedraColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AudienceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurriculumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentsColumn;
    }
}

