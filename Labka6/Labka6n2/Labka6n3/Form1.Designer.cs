namespace Labka6n2
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
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPublishYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAuthorInfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDynamic2 = new System.Windows.Forms.TextBox();
            this.lblDynamic2 = new System.Windows.Forms.Label();
            this.txtDynamic1 = new System.Windows.Forms.TextBox();
            this.lblDynamic1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Стаття",
            "Електронний ресурс"});
            this.cmbType.Location = new System.Drawing.Point(114, 12);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(325, 24);
            this.cmbType.TabIndex = 0;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Виберіть тип:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPublishYear);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAuthorInfo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAuthorName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(15, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні дані (для обох інтерфейсів)";
            // 
            // txtPublishYear
            // 
            this.txtPublishYear.Location = new System.Drawing.Point(103, 107);
            this.txtPublishYear.Name = "txtPublishYear";
            this.txtPublishYear.Size = new System.Drawing.Size(315, 20);
            this.txtPublishYear.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Рік видання:";
            // 
            // txtAuthorInfo
            // 
            this.txtAuthorInfo.Location = new System.Drawing.Point(103, 81);
            this.txtAuthorInfo.Name = "txtAuthorInfo";
            this.txtAuthorInfo.Size = new System.Drawing.Size(315, 20);
            this.txtAuthorInfo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Інфо (автор):";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(103, 55);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(315, 20);
            this.txtAuthorName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ім\'я автора:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(103, 29);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(315, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Назва:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDynamic2);
            this.groupBox2.Controls.Add(this.lblDynamic2);
            this.groupBox2.Controls.Add(this.txtDynamic1);
            this.groupBox2.Controls.Add(this.lblDynamic1);
            this.groupBox2.Location = new System.Drawing.Point(15, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 91);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Власні поля класу";
            // 
            // txtDynamic2
            // 
            this.txtDynamic2.Location = new System.Drawing.Point(103, 55);
            this.txtDynamic2.Name = "txtDynamic2";
            this.txtDynamic2.Size = new System.Drawing.Size(315, 20);
            this.txtDynamic2.TabIndex = 3;
            // 
            // lblDynamic2
            // 
            this.lblDynamic2.AutoSize = true;
            this.lblDynamic2.Location = new System.Drawing.Point(6, 58);
            this.lblDynamic2.Name = "lblDynamic2";
            this.lblDynamic2.Size = new System.Drawing.Size(43, 13);
            this.lblDynamic2.TabIndex = 2;
            this.lblDynamic2.Text = "Поле 2:";
            // 
            // txtDynamic1
            // 
            this.txtDynamic1.Location = new System.Drawing.Point(103, 29);
            this.txtDynamic1.Name = "txtDynamic1";
            this.txtDynamic1.Size = new System.Drawing.Size(315, 20);
            this.txtDynamic1.TabIndex = 1;
            // 
            // lblDynamic1
            // 
            this.lblDynamic1.AutoSize = true;
            this.lblDynamic1.Location = new System.Drawing.Point(6, 32);
            this.lblDynamic1.Name = "lblDynamic1";
            this.lblDynamic1.Size = new System.Drawing.Size(43, 13);
            this.lblDynamic1.TabIndex = 0;
            this.lblDynamic1.Text = "Поле 1:";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.Location = new System.Drawing.Point(15, 296);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(424, 31);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Створити об\'єкт";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(15, 333);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(424, 31);
            this.btnShowInfo.TabIndex = 5;
            this.btnShowInfo.Text = "Показати інформацію (з усіх інтерфейсів та власні методи)";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(15, 370);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(424, 163);
            this.txtOutput.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 545);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbType);
            this.Name = "Form1";
            this.Text = "Лаба 6 (Інтерфейси)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPublishYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAuthorInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDynamic2;
        private System.Windows.Forms.Label lblDynamic2;
        private System.Windows.Forms.TextBox txtDynamic1;
        private System.Windows.Forms.Label lblDynamic1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.TextBox txtOutput;
    }
}