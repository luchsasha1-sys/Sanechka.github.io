namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtInput;
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
            btnCalculate = new Button();
            txtInput = new TextBox();
            lblResult = new Label();
            SuspendLayout();
            

            btnCalculate.Location = new Point(331, 181);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 30);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Підрахувати";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            
            
            txtInput.Location = new Point(280, 126);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(200, 23);
            txtInput.TabIndex = 1;
            txtInput.TextChanged += txtInput_TextChanged;
            
            
            lblResult.AutoSize = true;
            lblResult.Location = new Point(50, 100);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 2;
            
            
            ClientSize = new Size(795, 389);
            Controls.Add(lblResult);
            Controls.Add(txtInput);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "Підрахунок символів";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
