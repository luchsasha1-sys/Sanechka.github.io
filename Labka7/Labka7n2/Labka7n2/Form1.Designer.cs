namespace Labka7n2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }
        #region Код, автоматически созданный конструктором форм Windows
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtExam3 = new System.Windows.Forms.TextBox();
            this.txtExam2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtExam1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtPassingScore = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtExam3);
            this.groupBox1.Controls.Add(this.txtExam2);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtExam1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSpec);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGender);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введення даних (Завдання 1)";
            // 
            // txtExam3
            // 
            this.txtExam3.Location = new System.Drawing.Point(368, 119);
            this.txtExam3.Name = "txtExam3";
            this.txtExam3.Size = new System.Drawing.Size(86, 20);
            this.txtExam3.TabIndex = 10;
            // 
            // txtExam2
            // 
            this.txtExam2.Location = new System.Drawing.Point(276, 119);
            this.txtExam2.Name = "txtExam2";
            this.txtExam2.Size = new System.Drawing.Size(86, 20);
            this.txtExam2.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(9, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(445, 35);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Додати абітурієнта до масиву";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtExam1
            // 
            this.txtExam1.Location = new System.Drawing.Point(184, 119);
            this.txtExam1.Name = "txtExam1";
            this.txtExam1.Size = new System.Drawing.Size(86, 20);
            this.txtExam1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Результати іспитів (3 предмети):";
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(109, 87);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(345, 20);
            this.txtSpec.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Спеціальність:";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(109, 57);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(345, 20);
            this.txtGender.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Стать:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(345, 20);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Прізвище, ініціали:";
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(12, 303);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(460, 212);
            this.lstOutput.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.txtPassingScore);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnSort);
            this.groupBox2.Location = new System.Drawing.Point(12, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 89);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дії";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(232, 51);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(222, 28);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Знайти (Завдання 3)";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtPassingScore
            // 
            this.txtPassingScore.Location = new System.Drawing.Point(354, 25);
            this.txtPassingScore.Name = "txtPassingScore";
            this.txtPassingScore.Size = new System.Drawing.Size(100, 20);
            this.txtPassingScore.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Введіть прохідний бал:";
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSort.Location = new System.Drawing.Point(9, 28);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(214, 51);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Впорядкувати за сер. балом\r\n(Завдання 2)";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 527);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Лаба 7. Масив структур (Абітурієнти)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtExam3;
        private System.Windows.Forms.TextBox txtExam2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtExam1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtPassingScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSort;
    }
}