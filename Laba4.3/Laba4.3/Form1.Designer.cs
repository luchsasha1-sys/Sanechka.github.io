namespace Laba4_3
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
            this.labelInputFile = new System.Windows.Forms.Label();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.groupBoxNumbers = new System.Windows.Forms.GroupBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.labelNumber2 = new System.Windows.Forms.Label();
            this.labelNumber1 = new System.Windows.Forms.Label();
            this.groupBoxOperations = new System.Windows.Forms.GroupBox();
            this.rbPower = new System.Windows.Forms.RadioButton();
            this.rbDivide = new System.Windows.Forms.RadioButton();
            this.rbMultiply = new System.Windows.Forms.RadioButton();
            this.rbSubtract = new System.Windows.Forms.RadioButton();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.labelResultTitle = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBoxNumbers.SuspendLayout();
            this.groupBoxOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInputFile
            // 
            this.labelInputFile.AutoSize = true;
            this.labelInputFile.Location = new System.Drawing.Point(25, 25);
            this.labelInputFile.Name = "labelInputFile";
            this.labelInputFile.Size = new System.Drawing.Size(102, 20);
            this.labelInputFile.TabIndex = 0;
            this.labelInputFile.Text = "Вхідний файл:";
            // 
            // txtInputFile
            // 
            this.txtInputFile.Location = new System.Drawing.Point(133, 22);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(150, 27);
            this.txtInputFile.TabIndex = 1;
            this.txtInputFile.Text = "Inputdata.txt";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(298, 20);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(180, 30);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Імпортувати вхідні дані";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // groupBoxNumbers
            // 
            this.groupBoxNumbers.Controls.Add(this.txtNumber2);
            this.groupBoxNumbers.Controls.Add(this.txtNumber1);
            this.groupBoxNumbers.Controls.Add(this.labelNumber2);
            this.groupBoxNumbers.Controls.Add(this.labelNumber1);
            this.groupBoxNumbers.Location = new System.Drawing.Point(29, 70);
            this.groupBoxNumbers.Name = "groupBoxNumbers";
            this.groupBoxNumbers.Size = new System.Drawing.Size(254, 130);
            this.groupBoxNumbers.TabIndex = 3;
            this.groupBoxNumbers.TabStop = false;
            this.groupBoxNumbers.Text = "Числа";
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(104, 78);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(125, 27);
            this.txtNumber2.TabIndex = 3;
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(104, 38);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(125, 27);
            this.txtNumber1.TabIndex = 2;
            // 
            // labelNumber2
            // 
            this.labelNumber2.AutoSize = true;
            this.labelNumber2.Location = new System.Drawing.Point(15, 81);
            this.labelNumber2.Name = "labelNumber2";
            this.labelNumber2.Size = new System.Drawing.Size(69, 20);
            this.labelNumber2.TabIndex = 1;
            this.labelNumber2.Text = "Число 2:";
            // 
            // labelNumber1
            // 
            this.labelNumber1.AutoSize = true;
            this.labelNumber1.Location = new System.Drawing.Point(15, 41);
            this.labelNumber1.Name = "labelNumber1";
            this.labelNumber1.Size = new System.Drawing.Size(69, 20);
            this.labelNumber1.TabIndex = 0;
            this.labelNumber1.Text = "Число 1:";
            // 
            // groupBoxOperations
            // 
            this.groupBoxOperations.Controls.Add(this.rbPower);
            this.groupBoxOperations.Controls.Add(this.rbDivide);
            this.groupBoxOperations.Controls.Add(this.rbMultiply);
            this.groupBoxOperations.Controls.Add(this.rbSubtract);
            this.groupBoxOperations.Controls.Add(this.rbAdd);
            this.groupBoxOperations.Location = new System.Drawing.Point(298, 70);
            this.groupBoxOperations.Name = "groupBoxOperations";
            this.groupBoxOperations.Size = new System.Drawing.Size(180, 200);
            this.groupBoxOperations.TabIndex = 4;
            this.groupBoxOperations.TabStop = false;
            this.groupBoxOperations.Text = "Операції";
            // 
            // rbPower
            // 
            this.rbPower.AutoSize = true;
            this.rbPower.Location = new System.Drawing.Point(20, 160);
            this.rbPower.Name = "rbPower";
            this.rbPower.Size = new System.Drawing.Size(129, 24);
            this.rbPower.TabIndex = 4;
            this.rbPower.TabStop = true;
            this.rbPower.Text = "Піднес. степінь";
            this.rbPower.UseVisualStyleBackColor = true;
            this.rbPower.CheckedChanged += new System.EventHandler(this.Operation_CheckedChanged);
            // 
            // rbDivide
            // 
            this.rbDivide.AutoSize = true;
            this.rbDivide.Location = new System.Drawing.Point(20, 128);
            this.rbDivide.Name = "rbDivide";
            this.rbDivide.Size = new System.Drawing.Size(89, 24);
            this.rbDivide.TabIndex = 3;
            this.rbDivide.TabStop = true;
            this.rbDivide.Text = "Ділення";
            this.rbDivide.UseVisualStyleBackColor = true;
            this.rbDivide.CheckedChanged += new System.EventHandler(this.Operation_CheckedChanged);
            // 
            // rbMultiply
            // 
            this.rbMultiply.AutoSize = true;
            this.rbMultiply.Location = new System.Drawing.Point(20, 96);
            this.rbMultiply.Name = "rbMultiply";
            this.rbMultiply.Size = new System.Drawing.Size(102, 24);
            this.rbMultiply.TabIndex = 2;
            this.rbMultiply.TabStop = true;
            this.rbMultiply.Text = "Множення";
            this.rbMultiply.UseVisualStyleBackColor = true;
            this.rbMultiply.CheckedChanged += new System.EventHandler(this.Operation_CheckedChanged);
            // 
            // rbSubtract
            // 
            this.rbSubtract.AutoSize = true;
            this.rbSubtract.Location = new System.Drawing.Point(20, 64);
            this.rbSubtract.Name = "rbSubtract";
            this.rbSubtract.Size = new System.Drawing.Size(104, 24);
            this.rbSubtract.TabIndex = 1;
            this.rbSubtract.TabStop = true;
            this.rbSubtract.Text = "Віднімання";
            this.rbSubtract.UseVisualStyleBackColor = true;
            this.rbSubtract.CheckedChanged += new System.EventHandler(this.Operation_CheckedChanged);
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Checked = true;
            this.rbAdd.Location = new System.Drawing.Point(20, 32);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(104, 24);
            this.rbAdd.TabIndex = 0;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Додавання";
            this.rbAdd.UseVisualStyleBackColor = true;
            this.rbAdd.CheckedChanged += new System.EventHandler(this.Operation_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.Location = new System.Drawing.Point(29, 220);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(254, 50);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Обчислити вираз";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(29, 320);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(449, 45);
            this.lblResult.TabIndex = 6;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelResultTitle
            // 
            this.labelResultTitle.AutoSize = true;
            this.labelResultTitle.Location = new System.Drawing.Point(25, 290);
            this.labelResultTitle.Name = "labelResultTitle";
            this.labelResultTitle.Size = new System.Drawing.Size(78, 20);
            this.labelResultTitle.TabIndex = 7;
            this.labelResultTitle.Text = "Результат:";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(298, 380);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(180, 30);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Експортувати у файл";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 433);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.labelResultTitle);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBoxOperations);
            this.Controls.Add(this.groupBoxNumbers);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtInputFile);
            this.Controls.Add(this.labelInputFile);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Арифметичний калькулятор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBoxNumbers.ResumeLayout(false);
            this.groupBoxNumbers.PerformLayout();
            this.groupBoxOperations.ResumeLayout(false);
            this.groupBoxOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelInputFile;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.GroupBox groupBoxNumbers;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.Label labelNumber2;
        private System.Windows.Forms.Label labelNumber1;
        private System.Windows.Forms.GroupBox groupBoxOperations;
        private System.Windows.Forms.RadioButton rbPower;
        private System.Windows.Forms.RadioButton rbDivide;
        private System.Windows.Forms.RadioButton rbMultiply;
        private System.Windows.Forms.RadioButton rbSubtract;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label labelResultTitle;
        private System.Windows.Forms.Button btnExport;
    }
}