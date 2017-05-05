using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licey
{
    public partial class Form1 : Form
    {
        #region work with ServApi
        List<Student> students = null;
        private void GetAllStudents()
        {
            dataGridViewStudents.Rows.Clear();
            students = ServAPI.StudentsSelectAll();

            foreach (Student student in students)
            {
                dataGridViewStudents.Rows.Add
                    (
                    student.Id, student.FirstName, student.LastName,
                    student.Sex==1?"Мужской":"Женский", student.Age, student.Description
                    );
            }
        }

        private void DeleteChosenStudent()
        {
            if (dataGridViewStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Ошибка. Выберите студента");
                return;
            }

            string id = dataGridViewStudents.SelectedRows[0].Cells[0].Value.ToString();

            ServAPI.StudentsDeleteById(id);

            GetAllStudents();
        }
        private void ClearAddNewStudentFields()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxDescription.Clear();
            maskedTextBoxAge.Clear();
            comboBoxSex.SelectedIndex = -1;
            textBoxId.Clear();
        }
        private void AddNewStudent()
        {
            if (textBoxFirstName.Text == String.Empty ||
                textBoxLastName.Text == String.Empty ||
                textBoxDescription.Text == String.Empty ||
                maskedTextBoxAge.Text == String.Empty ||
                comboBoxSex.SelectedIndex == -1)
            {
                MessageBox.Show("Ошибка. Заполнены не все поля");
                return;
            }

            Student student = new Student()
            {
                Id = 0,
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Sex = comboBoxSex.SelectedIndex,
                Age = int.Parse(maskedTextBoxAge.Text),
                Description = textBoxDescription.Text
            };

            ServAPI.StudentsInsertNewStudent(student);
            ClearAddNewStudentFields();

            GetAllStudents();
        }

        private void FillAddNewStudentFields()
        {
            if (dataGridViewStudents.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow selectStudent = dataGridViewStudents.SelectedRows[0];

            textBoxId.Text = selectStudent.Cells[0].Value.ToString();

            textBoxFirstName.Text = selectStudent.Cells[1].Value.ToString();
            textBoxLastName.Text = selectStudent.Cells[2].Value.ToString();

            comboBoxSex.SelectedIndex = selectStudent.Cells[3].Value.ToString() == "женский" ? 0 : 1;

            maskedTextBoxAge.Text = selectStudent.Cells[4].Value.ToString();

            textBoxDescription.Text = selectStudent.Cells[5].Value.ToString();
        }

        private void UpdateStudent()
        {
            if (textBoxFirstName.Text == String.Empty ||
                textBoxLastName.Text == String.Empty ||
                textBoxDescription.Text == String.Empty ||
                maskedTextBoxAge.Text == String.Empty ||
                comboBoxSex.SelectedIndex == -1)
            {
                MessageBox.Show("Ошибка. Заполнены не все поля");
                return;
            }

            Student student = new Student()
            {
                Id = int.Parse(textBoxId.Text),
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Sex = comboBoxSex.SelectedIndex,
                Age = int.Parse(maskedTextBoxAge.Text),
                Description = textBoxDescription.Text
            };

            ServAPI.StudentsUpdateById(student);
            ClearAddNewStudentFields();

            GetAllStudents();
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetAllStudents_Click(object sender, EventArgs e)
        {
            GetAllStudents();
        }

        private void buttonDeleteChosenStudent_Click(object sender, EventArgs e)
        {
            DeleteChosenStudent();
        }

        private void buttonAddNewStudent_Click(object sender, EventArgs e)
        {
            AddNewStudent();
        }

        private void buttonClearAddNewStudentFields_Click(object sender, EventArgs e)
        {
            ClearAddNewStudentFields();
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillAddNewStudentFields();
        }

        private void buttonUpdateStudent_Click(object sender, EventArgs e)
        {
            UpdateStudent();
        }
    }
}
