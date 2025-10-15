namespace Labka5_1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            groupBoxStudentData = new GroupBox();
            dtpDateOfBirth = new DateTimePicker();
            txtAverageGrade = new TextBox();
            txtCourse = new TextBox();
            txtFaculty = new TextBox();
            txtStudentID = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            labelAverageGrade = new Label();
            labelDateOfBirth = new Label();
            labelCourse = new Label();
            labelFaculty = new Label();
            labelStudentID = new Label();
            labelLastName = new Label();
            labelFirstName = new Label();
            groupBoxActions = new GroupBox();
            btnShowStatus = new Button();
            btnCalculateAge = new Button();
            btnShowFullName = new Button();
            btnSaveToFile = new Button();
            groupBoxStudentData.SuspendLayout();
            groupBoxActions.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxStudentData
            // 
            groupBoxStudentData.Controls.Add(dtpDateOfBirth);
            groupBoxStudentData.Controls.Add(txtAverageGrade);
            groupBoxStudentData.Controls.Add(txtCourse);
            groupBoxStudentData.Controls.Add(txtFaculty);
            groupBoxStudentData.Controls.Add(txtStudentID);
            groupBoxStudentData.Controls.Add(txtLastName);
            groupBoxStudentData.Controls.Add(txtFirstName);
            groupBoxStudentData.Controls.Add(labelAverageGrade);
            groupBoxStudentData.Controls.Add(labelDateOfBirth);
            groupBoxStudentData.Controls.Add(labelCourse);
            groupBoxStudentData.Controls.Add(labelFaculty);
            groupBoxStudentData.Controls.Add(labelStudentID);
            groupBoxStudentData.Controls.Add(labelLastName);
            groupBoxStudentData.Controls.Add(labelFirstName);
            groupBoxStudentData.Location = new Point(22, 21);
            groupBoxStudentData.Name = "groupBoxStudentData";
            groupBoxStudentData.Size = new Size(431, 350);
            groupBoxStudentData.TabIndex = 0;
            groupBoxStudentData.TabStop = false;
            groupBoxStudentData.Text = "Дані студента";
            groupBoxStudentData.Enter += groupBoxStudentData_Enter;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(188, 260);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(221, 23);
            dtpDateOfBirth.TabIndex = 6;
            // 
            // txtAverageGrade
            // 
            txtAverageGrade.Location = new Point(188, 300);
            txtAverageGrade.Name = "txtAverageGrade";
            txtAverageGrade.Size = new Size(221, 23);
            txtAverageGrade.TabIndex = 7;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(188, 220);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(221, 23);
            txtCourse.TabIndex = 5;
            // 
            // txtFaculty
            // 
            txtFaculty.Location = new Point(188, 180);
            txtFaculty.Name = "txtFaculty";
            txtFaculty.Size = new Size(221, 23);
            txtFaculty.TabIndex = 4;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(188, 140);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(221, 23);
            txtStudentID.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(188, 100);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(221, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(188, 60);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(221, 23);
            txtFirstName.TabIndex = 1;
            // 
            // labelAverageGrade
            // 
            labelAverageGrade.AutoSize = true;
            labelAverageGrade.Location = new Point(20, 303);
            labelAverageGrade.Name = "labelAverageGrade";
            labelAverageGrade.Size = new Size(83, 15);
            labelAverageGrade.TabIndex = 0;
            labelAverageGrade.Text = "Середній бал:";
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Location = new Point(20, 265);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(106, 15);
            labelDateOfBirth.TabIndex = 0;
            labelDateOfBirth.Text = "Дата народження:";
            // 
            // labelCourse
            // 
            labelCourse.AutoSize = true;
            labelCourse.Location = new Point(20, 223);
            labelCourse.Name = "labelCourse";
            labelCourse.Size = new Size(36, 15);
            labelCourse.TabIndex = 0;
            labelCourse.Text = "Курс:";
            // 
            // labelFaculty
            // 
            labelFaculty.AutoSize = true;
            labelFaculty.Location = new Point(20, 183);
            labelFaculty.Name = "labelFaculty";
            labelFaculty.Size = new Size(66, 15);
            labelFaculty.TabIndex = 0;
            labelFaculty.Text = "Факультет:";
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.Location = new Point(20, 143);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new Size(109, 15);
            labelStudentID.TabIndex = 0;
            labelStudentID.Text = "№ студент. квитка:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(20, 103);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(64, 15);
            labelLastName.TabIndex = 0;
            labelLastName.Text = "Прізвище:";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(20, 63);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(31, 15);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "Ім'я:";
            // 
            // groupBoxActions
            // 
            groupBoxActions.Controls.Add(btnShowStatus);
            groupBoxActions.Controls.Add(btnCalculateAge);
            groupBoxActions.Controls.Add(btnShowFullName);
            groupBoxActions.Location = new Point(472, 21);
            groupBoxActions.Name = "groupBoxActions";
            groupBoxActions.Size = new Size(248, 258);
            groupBoxActions.TabIndex = 1;
            groupBoxActions.TabStop = false;
            groupBoxActions.Text = "Демонстрація методів";
            // 
            // btnShowStatus
            // 
            btnShowStatus.Location = new Point(25, 180);
            btnShowStatus.Name = "btnShowStatus";
            btnShowStatus.Size = new Size(200, 50);
            btnShowStatus.TabIndex = 10;
            btnShowStatus.Text = "Визначити успішність";
            btnShowStatus.UseVisualStyleBackColor = true;
            btnShowStatus.Click += btnShowStatus_Click;
            // 
            // btnCalculateAge
            // 
            btnCalculateAge.Location = new Point(25, 110);
            btnCalculateAge.Name = "btnCalculateAge";
            btnCalculateAge.Size = new Size(200, 50);
            btnCalculateAge.TabIndex = 9;
            btnCalculateAge.Text = "Розрахувати вік";
            btnCalculateAge.UseVisualStyleBackColor = true;
            btnCalculateAge.Click += btnCalculateAge_Click;
            // 
            // btnShowFullName
            // 
            btnShowFullName.Location = new Point(25, 40);
            btnShowFullName.Name = "btnShowFullName";
            btnShowFullName.Size = new Size(200, 50);
            btnShowFullName.TabIndex = 8;
            btnShowFullName.Text = "Показати повне ім'я";
            btnShowFullName.UseVisualStyleBackColor = true;
            btnShowFullName.Click += btnShowFullName_Click;
            // 
            // btnSaveToFile
            // 
            btnSaveToFile.BackColor = Color.PaleGreen;
            btnSaveToFile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSaveToFile.Location = new Point(472, 301);
            btnSaveToFile.Name = "btnSaveToFile";
            btnSaveToFile.Size = new Size(248, 70);
            btnSaveToFile.TabIndex = 11;
            btnSaveToFile.Text = "Зберегти у файл";
            btnSaveToFile.UseVisualStyleBackColor = false;
            btnSaveToFile.Click += btnSaveToFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 393);
            Controls.Add(btnSaveToFile);
            Controls.Add(groupBoxActions);
            Controls.Add(groupBoxStudentData);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ЛР5 Завдання 1.1 - Студент";
            groupBoxStudentData.ResumeLayout(false);
            groupBoxStudentData.PerformLayout();
            groupBoxActions.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStudentData;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtAverageGrade;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label labelAverageGrade;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Label labelFaculty;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button btnShowStatus;
        private System.Windows.Forms.Button btnCalculateAge;
        private System.Windows.Forms.Button btnShowFullName;
        private System.Windows.Forms.Button btnSaveToFile;
    }
}