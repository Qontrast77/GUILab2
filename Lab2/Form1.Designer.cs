namespace Lab2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Элементы управления
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtSequence;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblResult;

        // Конструктор формы
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Метод инициализации компонентов
        private void InitializeComponent()
        {
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtSequence = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(15, 15);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(200, 23);
            this.txtN.TabIndex = 0;
            // 
            // txtSequence
            // 
            this.txtSequence.Location = new System.Drawing.Point(15, 45);
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.Size = new System.Drawing.Size(200, 23);
            this.txtSequence.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(15, 75);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 23);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(15, 110);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(300, 20);
            this.lblResult.TabIndex = 2;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(342, 136);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtSequence);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Проверка последовательности";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
