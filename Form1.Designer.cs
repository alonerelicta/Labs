using System.Collections.Generic;

using System;


namespace LabaInformationTechologics
{
    partial class Form1
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDateBirth = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.TitleAddData = new System.Windows.Forms.Label();
            this.dateTimeDateBirth = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateTimeDate = new System.Windows.Forms.DateTimePicker();
            this.TextNumber = new System.Windows.Forms.TextBox();
            this.TextFio = new System.Windows.Forms.TextBox();
            this.dateTimeFiltrDateAfter = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelAgeEnd = new System.Windows.Forms.Label();
            this.LabelAgeStart = new System.Windows.Forms.Label();
            this.LabelDateBefore = new System.Windows.Forms.Label();
            this.LabelDateAfter = new System.Windows.Forms.Label();
            this.TitleFilter = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonFiltr = new System.Windows.Forms.Button();
            this.AgeEnd = new System.Windows.Forms.NumericUpDown();
            this.AgeStart = new System.Windows.Forms.NumericUpDown();
            this.dateTimeFiltrDateBefore = new System.Windows.Forms.DateTimePicker();
            this.buttonDeleteFiltr = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textIdForDelete = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBirthDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buisnesModelUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.entityModelUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeStart)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buisnesModelUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityModelUserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.labelDateBirth);
            this.panel1.Controls.Add(this.labelNumber);
            this.panel1.Controls.Add(this.labelFIO);
            this.panel1.Controls.Add(this.TitleAddData);
            this.panel1.Controls.Add(this.dateTimeDateBirth);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.dateTimeDate);
            this.panel1.Controls.Add(this.TextNumber);
            this.panel1.Controls.Add(this.TextFio);
            this.panel1.Location = new System.Drawing.Point(33, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 328);
            this.panel1.TabIndex = 1;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(72, 246);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(127, 16);
            this.labelDate.TabIndex = 17;
            this.labelDate.Text = "Дата поступления";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDateBirth
            // 
            this.labelDateBirth.AutoSize = true;
            this.labelDateBirth.Location = new System.Drawing.Point(72, 195);
            this.labelDateBirth.Name = "labelDateBirth";
            this.labelDateBirth.Size = new System.Drawing.Size(106, 16);
            this.labelDateBirth.TabIndex = 16;
            this.labelDateBirth.Text = "Дата рождения";
            this.labelDateBirth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(72, 142);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(75, 16);
            this.labelNumber.TabIndex = 15;
            this.labelNumber.Text = "Номер з.ч.";
            this.labelNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(72, 89);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(38, 16);
            this.labelFIO.TabIndex = 14;
            this.labelFIO.Text = "ФИО";
            this.labelFIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleAddData
            // 
            this.TitleAddData.AutoSize = true;
            this.TitleAddData.Location = new System.Drawing.Point(202, 12);
            this.TitleAddData.Name = "TitleAddData";
            this.TitleAddData.Size = new System.Drawing.Size(138, 16);
            this.TitleAddData.TabIndex = 13;
            this.TitleAddData.Text = "Добавление данных";
            this.TitleAddData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleAddData.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimeDateBirth
            // 
            this.dateTimeDateBirth.Location = new System.Drawing.Point(205, 190);
            this.dateTimeDateBirth.MaxDate = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            this.dateTimeDateBirth.Name = "dateTimeDateBirth";
            this.dateTimeDateBirth.Size = new System.Drawing.Size(200, 22);
            this.dateTimeDateBirth.TabIndex = 10;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAdd.Location = new System.Drawing.Point(225, 286);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(105, 39);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dateTimeDate
            // 
            this.dateTimeDate.Location = new System.Drawing.Point(205, 246);
            this.dateTimeDate.MaxDate = new System.DateTime(2024, 10, 18, 0, 0, 0, 0);
            this.dateTimeDate.Name = "dateTimeDate";
            this.dateTimeDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimeDate.TabIndex = 12;
            this.dateTimeDate.Value = new System.DateTime(2024, 10, 18, 0, 0, 0, 0);
            // 
            // TextNumber
            // 
            this.TextNumber.Location = new System.Drawing.Point(205, 136);
            this.TextNumber.Multiline = true;
            this.TextNumber.Name = "TextNumber";
            this.TextNumber.Size = new System.Drawing.Size(200, 22);
            this.TextNumber.TabIndex = 6;
            this.TextNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextFio
            // 
            this.TextFio.Location = new System.Drawing.Point(205, 83);
            this.TextFio.Multiline = true;
            this.TextFio.Name = "TextFio";
            this.TextFio.Size = new System.Drawing.Size(200, 22);
            this.TextFio.TabIndex = 5;
            this.TextFio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextFio.TextChanged += new System.EventHandler(this.textBox1_TextChanged_4);
            // 
            // dateTimeFiltrDateAfter
            // 
            this.dateTimeFiltrDateAfter.Location = new System.Drawing.Point(196, 137);
            this.dateTimeFiltrDateAfter.Name = "dateTimeFiltrDateAfter";
            this.dateTimeFiltrDateAfter.Size = new System.Drawing.Size(200, 22);
            this.dateTimeFiltrDateAfter.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.LabelAgeEnd);
            this.panel2.Controls.Add(this.LabelAgeStart);
            this.panel2.Controls.Add(this.LabelDateBefore);
            this.panel2.Controls.Add(this.LabelDateAfter);
            this.panel2.Controls.Add(this.TitleFilter);
            this.panel2.Controls.Add(this.labelId);
            this.panel2.Controls.Add(this.buttonFiltr);
            this.panel2.Controls.Add(this.AgeEnd);
            this.panel2.Controls.Add(this.AgeStart);
            this.panel2.Controls.Add(this.dateTimeFiltrDateBefore);
            this.panel2.Controls.Add(this.dateTimeFiltrDateAfter);
            this.panel2.Controls.Add(this.buttonDeleteFiltr);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.textIdForDelete);
            this.panel2.Location = new System.Drawing.Point(641, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 329);
            this.panel2.TabIndex = 2;
            // 
            // LabelAgeEnd
            // 
            this.LabelAgeEnd.AutoSize = true;
            this.LabelAgeEnd.Location = new System.Drawing.Point(247, 252);
            this.LabelAgeEnd.Name = "LabelAgeEnd";
            this.LabelAgeEnd.Size = new System.Drawing.Size(23, 16);
            this.LabelAgeEnd.TabIndex = 23;
            this.LabelAgeEnd.Text = "до";
            this.LabelAgeEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelAgeStart
            // 
            this.LabelAgeStart.AutoSize = true;
            this.LabelAgeStart.Location = new System.Drawing.Point(38, 255);
            this.LabelAgeStart.Name = "LabelAgeStart";
            this.LabelAgeStart.Size = new System.Drawing.Size(72, 16);
            this.LabelAgeStart.TabIndex = 22;
            this.LabelAgeStart.Text = "Возраст с";
            this.LabelAgeStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelDateBefore
            // 
            this.LabelDateBefore.AutoSize = true;
            this.LabelDateBefore.Location = new System.Drawing.Point(38, 190);
            this.LabelDateBefore.Name = "LabelDateBefore";
            this.LabelDateBefore.Size = new System.Drawing.Size(115, 16);
            this.LabelDateBefore.TabIndex = 21;
            this.LabelDateBefore.Text = "Поступившие до";
            this.LabelDateBefore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelDateAfter
            // 
            this.LabelDateAfter.AutoSize = true;
            this.LabelDateAfter.Location = new System.Drawing.Point(38, 142);
            this.LabelDateAfter.Name = "LabelDateAfter";
            this.LabelDateAfter.Size = new System.Drawing.Size(138, 16);
            this.LabelDateAfter.TabIndex = 20;
            this.LabelDateAfter.Text = "Поступившие после";
            this.LabelDateAfter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleFilter
            // 
            this.TitleFilter.AutoSize = true;
            this.TitleFilter.Location = new System.Drawing.Point(38, 89);
            this.TitleFilter.Name = "TitleFilter";
            this.TitleFilter.Size = new System.Drawing.Size(137, 16);
            this.TitleFilter.TabIndex = 19;
            this.TitleFilter.Text = "Фильтрация данных";
            this.TitleFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.Location = new System.Drawing.Point(99, 20);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(28, 25);
            this.labelId.TabIndex = 18;
            this.labelId.Text = "Id";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelId.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonFiltr
            // 
            this.buttonFiltr.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonFiltr.Location = new System.Drawing.Point(524, 240);
            this.buttonFiltr.Name = "buttonFiltr";
            this.buttonFiltr.Size = new System.Drawing.Size(123, 39);
            this.buttonFiltr.TabIndex = 13;
            this.buttonFiltr.Text = "Фильтровать";
            this.buttonFiltr.UseVisualStyleBackColor = false;
            this.buttonFiltr.Click += new System.EventHandler(this.buttonFiltr_Click);
            // 
            // AgeEnd
            // 
            this.AgeEnd.Location = new System.Drawing.Point(276, 249);
            this.AgeEnd.Name = "AgeEnd";
            this.AgeEnd.Size = new System.Drawing.Size(120, 22);
            this.AgeEnd.TabIndex = 16;
            this.AgeEnd.ValueChanged += new System.EventHandler(this.AgeEnd_ValueChanged);
            // 
            // AgeStart
            // 
            this.AgeStart.Location = new System.Drawing.Point(118, 250);
            this.AgeStart.Name = "AgeStart";
            this.AgeStart.Size = new System.Drawing.Size(120, 22);
            this.AgeStart.TabIndex = 15;
            this.AgeStart.ValueChanged += new System.EventHandler(this.AgeStart_ValueChanged);
            // 
            // dateTimeFiltrDateBefore
            // 
            this.dateTimeFiltrDateBefore.Location = new System.Drawing.Point(196, 185);
            this.dateTimeFiltrDateBefore.MaxDate = new System.DateTime(2024, 10, 18, 0, 0, 0, 0);
            this.dateTimeFiltrDateBefore.Name = "dateTimeFiltrDateBefore";
            this.dateTimeFiltrDateBefore.Size = new System.Drawing.Size(200, 22);
            this.dateTimeFiltrDateBefore.TabIndex = 13;
            this.dateTimeFiltrDateBefore.Value = new System.DateTime(2024, 10, 17, 0, 0, 0, 0);
            this.dateTimeFiltrDateBefore.ValueChanged += new System.EventHandler(this.dateTimeFiltrDateBefore_ValueChanged);
            // 
            // buttonDeleteFiltr
            // 
            this.buttonDeleteFiltr.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDeleteFiltr.Location = new System.Drawing.Point(495, 12);
            this.buttonDeleteFiltr.Name = "buttonDeleteFiltr";
            this.buttonDeleteFiltr.Size = new System.Drawing.Size(152, 39);
            this.buttonDeleteFiltr.TabIndex = 12;
            this.buttonDeleteFiltr.Text = "Сброс фильтров";
            this.buttonDeleteFiltr.UseVisualStyleBackColor = false;
            this.buttonDeleteFiltr.Click += new System.EventHandler(this.buttonDeleteFiltr_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDelete.Location = new System.Drawing.Point(354, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(105, 39);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textIdForDelete
            // 
            this.textIdForDelete.Location = new System.Drawing.Point(161, 20);
            this.textIdForDelete.Multiline = true;
            this.textIdForDelete.Name = "textIdForDelete";
            this.textIdForDelete.Size = new System.Drawing.Size(160, 27);
            this.textIdForDelete.TabIndex = 1;
            this.textIdForDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textIdForDelete.TextChanged += new System.EventHandler(this.textBox4_TextChanged_2);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.dataGridUsers);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1324, 218);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(983, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Forward";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Forward_click);
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AutoGenerateColumns = false;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.dateBirthDayDataGridViewTextBoxColumn,
            this.dateStartDataGridViewTextBoxColumn});
            this.dataGridUsers.DataSource = this.buisnesModelUserBindingSource;
            this.dataGridUsers.Location = new System.Drawing.Point(21, 3);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.RowHeadersWidth = 51;
            this.dataGridUsers.RowTemplate.Height = 24;
            this.dataGridUsers.Size = new System.Drawing.Size(851, 215);
            this.dataGridUsers.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.Width = 125;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер зачетной книжки";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateBirthDayDataGridViewTextBoxColumn
            // 
            this.dateBirthDayDataGridViewTextBoxColumn.DataPropertyName = "DateBirthDay";
            this.dateBirthDayDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.dateBirthDayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateBirthDayDataGridViewTextBoxColumn.Name = "dateBirthDayDataGridViewTextBoxColumn";
            this.dateBirthDayDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateStartDataGridViewTextBoxColumn
            // 
            this.dateStartDataGridViewTextBoxColumn.DataPropertyName = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.HeaderText = "Дата поступления";
            this.dateStartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateStartDataGridViewTextBoxColumn.Name = "dateStartDataGridViewTextBoxColumn";
            this.dateStartDataGridViewTextBoxColumn.Width = 125;
            // 
            // buisnesModelUserBindingSource
            // 
            this.buisnesModelUserBindingSource.DataSource = typeof(LabaInformationTechologics.BuisnesModels.BuisnesModelUser);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(LabaInformationTechologics.Form1);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(LabaInformationTechologics.Program);
            // 
            // form1BindingSource1
            // 
            this.form1BindingSource1.DataSource = typeof(LabaInformationTechologics.Form1);
            // 
            // form1BindingSource2
            // 
            this.form1BindingSource2.DataSource = typeof(LabaInformationTechologics.Form1);
            // 
            // entityModelUserBindingSource
            // 
            this.entityModelUserBindingSource.DataSource = typeof(LabaInformationTechologics.EntityModel.EntityModelUser);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 609);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Админка";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeStart)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buisnesModelUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityModelUserBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextNumber;
        private System.Windows.Forms.TextBox TextFio;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimeFiltrDateAfter;
        private System.Windows.Forms.DateTimePicker dateTimeDateBirth;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textIdForDelete;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonDeleteFiltr;
        private System.Windows.Forms.DateTimePicker dateTimeDate;
        private System.Windows.Forms.DateTimePicker dateTimeFiltrDateBefore;
        private System.Windows.Forms.NumericUpDown AgeEnd;
        private System.Windows.Forms.NumericUpDown AgeStart;
        private System.Windows.Forms.Button buttonFiltr;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource form1BindingSource2;
        private System.Windows.Forms.Label TitleAddData;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelDateBirth;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label TitleFilter;
        private System.Windows.Forms.Label LabelDateAfter;
        private System.Windows.Forms.Label LabelDateBefore;
        private System.Windows.Forms.Label LabelAgeStart;
        private System.Windows.Forms.Label LabelAgeEnd;
        private System.Windows.Forms.BindingSource buisnesModelUserBindingSource;
        private System.Windows.Forms.BindingSource entityModelUserBindingSource;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBirthDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

