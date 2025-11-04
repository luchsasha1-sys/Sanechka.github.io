namespace Labka6n3
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
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtPageCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSortByPages = new System.Windows.Forms.Button();
            this.btnSortByPrice = new System.Windows.Forms.Button();
            this.btnSortDefault = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddBook);
            this.groupBox1.Controls.Add(this.txtPageCount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додати книгу";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddBook.Location = new System.Drawing.Point(9, 149);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(415, 33);
            this.btnAddBook.TabIndex = 8;
            this.btnAddBook.Text = "Додати";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(111, 114);
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.Size = new System.Drawing.Size(313, 20);
            this.txtPageCount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Кількість сторінок:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(111, 88);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(313, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ціна (грн):";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(111, 62);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(313, 20);
            this.txtAuthor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Автор:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(111, 36);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(313, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSortByPages);
            this.groupBox2.Controls.Add(this.btnSortByPrice);
            this.groupBox2.Controls.Add(this.btnSortDefault);
            this.groupBox2.Location = new System.Drawing.Point(12, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 68);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сортування";
            // 
            // btnSortByPages
            // 
            this.btnSortByPages.Location = new System.Drawing.Point(294, 28);
            this.btnSortByPages.Name = "btnSortByPages";
            this.btnSortByPages.Size = new System.Drawing.Size(130, 23);
            this.btnSortByPages.TabIndex = 2;
            this.btnSortByPages.Text = "За сторінками (IComparer)";
            this.btnSortByPages.UseVisualStyleBackColor = true;
            this.btnSortByPages.Click += new System.EventHandler(this.btnSortByPages_Click);
            // 
            // btnSortByPrice
            // 
            this.btnSortByPrice.Location = new System.Drawing.Point(150, 28);
            this.btnSortByPrice.Name = "btnSortByPrice";
            this.btnSortByPrice.Size = new System.Drawing.Size(138, 23);
            this.btnSortByPrice.TabIndex = 1;
            this.btnSortByPrice.Text = "За ціною (IComparer)";
            this.btnSortByPrice.UseVisualStyleBackColor = true;
            this.btnSortByPrice.Click += new System.EventHandler(this.btnSortByPrice_Click);
            // 
            // btnSortDefault
            // 
            this.btnSortDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSortDefault.Location = new System.Drawing.Point(9, 28);
            this.btnSortDefault.Name = "btnSortDefault";
            this.btnSortDefault.Size = new System.Drawing.Size(135, 23);
            this.btnSortDefault.TabIndex = 0;
            this.btnSortDefault.Text = "За ціною (IComparable)";
            this.btnSortDefault.UseVisualStyleBackColor = true;
            this.btnSortDefault.Click += new System.EventHandler(this.btnSortDefault_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(12, 284);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(430, 199);
            this.lstOutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 497);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Лаба 6 (Вбудовані інтерфейси)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtPageCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSortByPages;
        private System.Windows.Forms.Button btnSortByPrice;
        private System.Windows.Forms.Button btnSortDefault;
        private System.Windows.Forms.ListBox lstOutput;
    }
}