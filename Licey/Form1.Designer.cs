namespace Licey
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
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonGetAllStudents = new System.Windows.Forms.Button();
            this.buttonDeleteChosenStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxAge = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonAddNewStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewStudents.MultiSelect = false;
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.Size = new System.Drawing.Size(717, 196);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "FirstName";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "LastName";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sex";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Age";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Description";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // buttonGetAllStudents
            // 
            this.buttonGetAllStudents.Location = new System.Drawing.Point(12, 11);
            this.buttonGetAllStudents.Name = "buttonGetAllStudents";
            this.buttonGetAllStudents.Size = new System.Drawing.Size(717, 23);
            this.buttonGetAllStudents.TabIndex = 1;
            this.buttonGetAllStudents.Text = "Получить всех студентов";
            this.buttonGetAllStudents.UseVisualStyleBackColor = true;
            this.buttonGetAllStudents.Click += new System.EventHandler(this.buttonGetAllStudents_Click);
            // 
            // buttonDeleteChosenStudent
            // 
            this.buttonDeleteChosenStudent.Location = new System.Drawing.Point(12, 242);
            this.buttonDeleteChosenStudent.Name = "buttonDeleteChosenStudent";
            this.buttonDeleteChosenStudent.Size = new System.Drawing.Size(717, 23);
            this.buttonDeleteChosenStudent.TabIndex = 2;
            this.buttonDeleteChosenStudent.Text = "Удалить выбранного студента";
            this.buttonDeleteChosenStudent.UseVisualStyleBackColor = true;
            this.buttonDeleteChosenStudent.Click += new System.EventHandler(this.buttonDeleteChosenStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FirstName";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(16, 289);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "LastName";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(122, 289);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sex";
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Женский",
            "Мужской"});
            this.comboBoxSex.Location = new System.Drawing.Point(228, 287);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSex.TabIndex = 5;
            // 
            // maskedTextBoxAge
            // 
            this.maskedTextBoxAge.Location = new System.Drawing.Point(356, 289);
            this.maskedTextBoxAge.Mask = "00000";
            this.maskedTextBoxAge.Name = "maskedTextBoxAge";
            this.maskedTextBoxAge.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxAge.TabIndex = 6;
            this.maskedTextBoxAge.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(462, 287);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(267, 20);
            this.textBoxDescription.TabIndex = 4;
            // 
            // buttonAddNewStudent
            // 
            this.buttonAddNewStudent.Location = new System.Drawing.Point(16, 316);
            this.buttonAddNewStudent.Name = "buttonAddNewStudent";
            this.buttonAddNewStudent.Size = new System.Drawing.Size(713, 23);
            this.buttonAddNewStudent.TabIndex = 7;
            this.buttonAddNewStudent.Text = "Добавить студента";
            this.buttonAddNewStudent.UseVisualStyleBackColor = true;
            this.buttonAddNewStudent.Click += new System.EventHandler(this.buttonAddNewStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 459);
            this.Controls.Add(this.buttonAddNewStudent);
            this.Controls.Add(this.maskedTextBoxAge);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeleteChosenStudent);
            this.Controls.Add(this.buttonGetAllStudents);
            this.Controls.Add(this.dataGridViewStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Button buttonGetAllStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button buttonDeleteChosenStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonAddNewStudent;
    }
}

