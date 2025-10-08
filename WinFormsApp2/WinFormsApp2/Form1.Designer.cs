namespace WinFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtFirstText;
        private System.Windows.Forms.TextBox txtSecondText;
        private System.Windows.Forms.Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtFirstText = new System.Windows.Forms.TextBox();
            this.txtSecondText = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();


            this.btnProcess.Location = new System.Drawing.Point(100, 250);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(100, 30);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "Обробити";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);


            this.txtFirstText.Location = new System.Drawing.Point(50, 50);
            this.txtFirstText.Multiline = true;
            this.txtFirstText.Name = "txtFirstText";
            this.txtFirstText.Size = new System.Drawing.Size(200, 50);
            this.txtFirstText.TabIndex = 1;


            this.txtSecondText.Location = new System.Drawing.Point(50, 120);
            this.txtSecondText.Multiline = true;
            this.txtSecondText.Name = "txtSecondText";
            this.txtSecondText.Size = new System.Drawing.Size(200, 50);
            this.txtSecondText.TabIndex = 2;


            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(50, 180);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 3;


            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtSecondText);
            this.Controls.Add(this.txtFirstText);
            this.Controls.Add(this.btnProcess);
            this.Name = "Form1";
            this.Text = "Обробка текстів";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
