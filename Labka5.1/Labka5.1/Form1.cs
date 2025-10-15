using System;
using System.IO;
using System.Windows.Forms;

namespace Labka5_1
{
    public partial class Form1 : Form
    {
        // ��������� ��������� ������ ����� �� ��� �����
        private Student _currentStudent;

        public Form1()
        {
            InitializeComponent();
            // ���������� ��'��� ��� ������� �����
            _currentStudent = new Student();
        }

        // ��������� ����� ��� ����� ����� � ���� �����
        private bool UpdateStudentFromUI()
        {
            try
            {
                _currentStudent.FirstName = txtFirstName.Text;
                _currentStudent.LastName = txtLastName.Text;
                _currentStudent.StudentID = txtStudentID.Text;
                _currentStudent.Faculty = txtFaculty.Text;
                _currentStudent.DateOfBirth = dtpDateOfBirth.Value;

                // �������� ���������� ����� �������� �����
                if (!int.TryParse(txtCourse.Text, out int course))
                {
                    MessageBox.Show("���� �����, ������ ��������� ����� ����� (���� �����).", "������� �����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                _currentStudent.Course = course;

                if (!double.TryParse(txtAverageGrade.Text, out double grade))
                {
                    MessageBox.Show("���� �����, ������ ��������� ������� ��� (�����).", "������� �����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                _currentStudent.AverageGrade = grade;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������� ������� ��� �������� �����: {ex.Message}", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // �������� ������ "�������� � ����"
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if (UpdateStudentFromUI()) // ��������� ��� ����� �����������
            {
                try
                {
                    string filePath = "student_info.txt";
                    string studentData = $"��'�: {_currentStudent.FirstName}\n" +
                                         $"�������: {_currentStudent.LastName}\n" +
                                         $"����� ����. ������: {_currentStudent.StudentID}\n" +
                                         $"���������: {_currentStudent.Faculty}\n" +
                                         $"����: {_currentStudent.Course}\n" +
                                         $"���� ����������: {_currentStudent.DateOfBirth:dd.MM.yyyy}\n" +
                                         $"������� ���: {_currentStudent.AverageGrade}";

                    File.WriteAllText(filePath, studentData);
                    MessageBox.Show($"��� ������ ��������� � ���� '{filePath}'", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"�� ������� �������� ����: {ex.Message}", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ������������ ������ GetFullName()
        private void btnShowFullName_Click(object sender, EventArgs e)
        {
            if (UpdateStudentFromUI())
            {
                string fullName = _currentStudent.GetFullName();
                MessageBox.Show($"����� ��'� ��������: {fullName}", "��������� ������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ������������ ������ CalculateAge()
        private void btnCalculateAge_Click(object sender, EventArgs e)
        {
            if (UpdateStudentFromUI())
            {
                int age = _currentStudent.CalculateAge();
                MessageBox.Show($"������ �� ��������: {age} ����", "��������� ������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ������������ ������ GetAcademicStatus()
        private void btnShowStatus_Click(object sender, EventArgs e)
        {
            if (UpdateStudentFromUI())
            {
                string status = _currentStudent.GetAcademicStatus();
                MessageBox.Show($"���������� ������: {status}", "��������� ������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void groupBoxStudentData_Enter(object sender, EventArgs e)
        {

        }
    }
}