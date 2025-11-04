namespace Labka5n3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtExtraParam = new System.Windows.Forms.TextBox();
            this.lblExtraParam = new System.Windows.Forms.Label();
            this.txtMaxSpeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCylinders = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnUpdateAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Транспортний засіб",
            "Вантажівка",
            "Трактор"});
            this.cmbType.Location = new System.Drawing.Point(111, 12);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(306, 24);
            this.cmbType.TabIndex = 0;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Виберіть тип:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtExtraParam);
            this.groupBox1.Controls.Add(this.lblExtraParam);
            this.groupBox1.Controls.Add(this.txtMaxSpeed);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPower);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCylinders);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMarka);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 180);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметри";
            // 
            // txtExtraParam
            // 
            this.txtExtraParam.Location = new System.Drawing.Point(127, 143);
            this.txtExtraParam.Name = "txtExtraParam";
            this.txtExtraParam.Size = new System.Drawing.Size(269, 20);
            this.txtExtraParam.TabIndex = 9;
            // 
            // lblExtraParam
            // 
            this.lblExtraParam.AutoSize = true;
            this.lblExtraParam.Location = new System.Drawing.Point(16, 146);
            this.lblExtraParam.Name = "lblExtraParam";
            this.lblExtraParam.Size = new System.Drawing.Size(71, 13);
            this.lblExtraParam.TabIndex = 8;
            this.lblExtraParam.Text = "Дод. Поле:";
            // 
            // txtMaxSpeed
            // 
            this.txtMaxSpeed.Location = new System.Drawing.Point(127, 117);
            this.txtMaxSpeed.Name = "txtMaxSpeed";
            this.txtMaxSpeed.Size = new System.Drawing.Size(269, 20);
            this.txtMaxSpeed.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Макс. швидкість:";
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(127, 91);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(269, 20);
            this.txtPower.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Потужність:";
            // 
            // txtCylinders
            // 
            this.txtCylinders.Location = new System.Drawing.Point(127, 65);
            this.txtCylinders.Name = "txtCylinders";
            this.txtCylinders.Size = new System.Drawing.Size(269, 20);
            this.txtCylinders.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Число циліндрів:";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(127, 39);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(269, 20);
            this.txtMarka.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Марка:";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.Location = new System.Drawing.Point(15, 238);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(402, 33);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Створити об\'єкт";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(15, 316);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(402, 171);
            this.txtOutput.TabIndex = 4;
            // 
            // btnUpdateAll
            // 
            this.btnUpdateAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateAll.Location = new System.Drawing.Point(15, 277);
            this.btnUpdateAll.Name = "btnUpdateAll";
            this.btnUpdateAll.Size = new System.Drawing.Size(402, 33);
            this.btnUpdateAll.TabIndex = 5;
            this.btnUpdateAll.Text = "Оновити моделі (для всіх створених)";
            this.btnUpdateAll.UseVisualStyleBackColor = true;
            this.btnUpdateAll.Click += new System.EventHandler(this.btnUpdateAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 499);
            this.Controls.Add(this.btnUpdateAll);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbType);
            this.Name = "Form1";
            this.Text = "Поліморфізм";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
#endregion

        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtExtraParam;
        private System.Windows.Forms.Label lblExtraParam;
        private System.Windows.Forms.TextBox txtMaxSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCylinders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnUpdateAll;
    }
}