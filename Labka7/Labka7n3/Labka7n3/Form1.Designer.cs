namespace Labka7n3
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStartTemp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObjectCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoilerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.btnFindShortest = new System.Windows.Forms.Button();
            this.btnShowOver6Months = new System.Windows.Forms.Button();
            this.btnShowAfterOct15 = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.btnSearchByDate = new System.Windows.Forms.Button();
            this.txtSearchDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtEndDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtStartTemp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtStartDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtObjectCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoilerID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введення даних про котельню";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(9, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(415, 36);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(137, 185);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(287, 20);
            this.txtEndDate.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Дата кінця (ДДММРРРР):";
            // 
            // txtStartTemp
            // 
            this.txtStartTemp.Location = new System.Drawing.Point(137, 153);
            this.txtStartTemp.Name = "txtStartTemp";
            this.txtStartTemp.Size = new System.Drawing.Size(287, 20);
            this.txtStartTemp.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Температура повітря:";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(137, 121);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(287, 20);
            this.txtStartDate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // txtObjectCount
            // 
            this.txtObjectCount.Location = new System.Drawing.Point(137, 89);
            this.txtObjectCount.Name = "txtObjectCount";
            this.txtObjectCount.Size = new System.Drawing.Size(287, 20);
            this.txtObjectCount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "К-сть об\'єктів:";
            // 
            // txtBoilerID
            // 
            this.txtBoilerID.Location = new System.Drawing.Point(137, 57);
            this.txtBoilerID.Name = "txtBoilerID";
            this.txtBoilerID.Size = new System.Drawing.Size(287, 20);
            this.txtBoilerID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "№ котельні:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(137, 25);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(287, 20);
            this.txtCity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Населений пункт:";
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(12, 401);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(430, 186);
            this.lstOutput.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabReports);
            this.tabControl1.Controls.Add(this.tabSearch);
            this.tabControl1.Location = new System.Drawing.Point(12, 278);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(430, 117);
            this.tabControl1.TabIndex = 2;
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.btnFindShortest);
            this.tabReports.Controls.Add(this.btnShowOver6Months);
            this.tabReports.Controls.Add(this.btnShowAfterOct15);
            this.tabReports.Controls.Add(this.btnShowAll);
            this.tabReports.Location = new System.Drawing.Point(4, 22);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(422, 91);
            this.tabReports.TabIndex = 0;
            this.tabReports.Text = "Загальні звіти";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // btnFindShortest
            // 
            this.btnFindShortest.Location = new System.Drawing.Point(213, 50);
            this.btnFindShortest.Name = "btnFindShortest";
            this.btnFindShortest.Size = new System.Drawing.Size(203, 35);
            this.btnFindShortest.TabIndex = 3;
            this.btnFindShortest.Text = "Знайти найкоротший сезон (Завд. 4)";
            this.btnFindShortest.UseVisualStyleBackColor = true;
            this.btnFindShortest.Click += new System.EventHandler(this.btnFindShortest_Click);
            // 
            // btnShowOver6Months
            // 
            this.btnShowOver6Months.Location = new System.Drawing.Point(6, 50);
            this.btnShowOver6Months.Name = "btnShowOver6Months";
            this.btnShowOver6Months.Size = new System.Drawing.Size(201, 35);
            this.btnShowOver6Months.TabIndex = 2;
            this.btnShowOver6Months.Text = "Сезон > 6 місяців (Завд. 3)";
            this.btnShowOver6Months.UseVisualStyleBackColor = true;
            this.btnShowOver6Months.Click += new System.EventHandler(this.btnShowOver6Months_Click);
            // 
            // btnShowAfterOct15
            // 
            this.btnShowAfterOct15.Location = new System.Drawing.Point(213, 6);
            this.btnShowAfterOct15.Name = "btnShowAfterOct15";
            this.btnShowAfterOct15.Size = new System.Drawing.Size(203, 35);
            this.btnShowAfterOct15.TabIndex = 1;
            this.btnShowAfterOct15.Text = "Почали після 15.10 (Завд. 2)";
            this.btnShowAfterOct15.UseVisualStyleBackColor = true;
            this.btnShowAfterOct15.Click += new System.EventHandler(this.btnShowAfterOct15_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(6, 6);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(201, 35);
            this.btnShowAll.TabIndex = 0;
            this.btnShowAll.Text = "Показати всіх з тривалістю (Завд. 1)";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.btnSearchByDate);
            this.tabSearch.Controls.Add(this.txtSearchDate);
            this.tabSearch.Controls.Add(this.label7);
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(422, 91);
            this.tabSearch.TabIndex = 1;
            this.tabSearch.Text = "Пошук за датою (Завд. 5)";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.Location = new System.Drawing.Point(245, 17);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(171, 56);
            this.btnSearchByDate.TabIndex = 2;
            this.btnSearchByDate.Text = "Знайти";
            this.btnSearchByDate.UseVisualStyleBackColor = true;
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
            // 
            // txtSearchDate
            // 
            this.txtSearchDate.Location = new System.Drawing.Point(19, 53);
            this.txtSearchDate.Name = "txtSearchDate";
            this.txtSearchDate.Size = new System.Drawing.Size(220, 20);
            this.txtSearchDate.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Введіть дату початку опалювального сезону\r\n(формат ДДММРРРР):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Дата старту (ДДММРРРР):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 599);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Лаба 7. Опалювальні системи";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabReports.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStartTemp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtObjectCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoilerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.Button btnFindShortest;
        private System.Windows.Forms.Button btnShowOver6Months;
        private System.Windows.Forms.Button btnShowAfterOct15;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSearchByDate;
        private System.Windows.Forms.TextBox txtSearchDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}