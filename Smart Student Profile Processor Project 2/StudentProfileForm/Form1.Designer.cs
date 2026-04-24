namespace StudentProfileForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblName
            this.lblName.Text = "Enter Name:";
            this.lblName.Location = new System.Drawing.Point(30, 20);
            this.lblName.Size = new System.Drawing.Size(80, 20);

            // txtName
            this.txtName.Location = new System.Drawing.Point(120, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);

            // lblAge
            this.lblAge.Text = "Enter Age:";
            this.lblAge.Location = new System.Drawing.Point(30, 60);
            this.lblAge.Size = new System.Drawing.Size(80, 20);

            // txtAge
            this.txtAge.Location = new System.Drawing.Point(120, 58);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(150, 20);
            this.txtAge.TabIndex = 1;
            this.txtAge.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);

            // lblMarks
            this.lblMarks.Text = "Enter Marks:";
            this.lblMarks.Location = new System.Drawing.Point(30, 100);
            this.lblMarks.Size = new System.Drawing.Size(80, 20);

            // txtMarks
            this.txtMarks.Location = new System.Drawing.Point(120, 98);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(150, 20);
            this.txtMarks.TabIndex = 2;
            this.txtMarks.TextChanged += new System.EventHandler(this.txtMarks_TextChanged);

            // btnProcess
            this.btnProcess.Location = new System.Drawing.Point(120, 140);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(90, 25);
            this.btnProcess.TabIndex = 3;
            this.btnProcess.Text = "Process";
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);

            // lblOutput
            this.lblOutput.Location = new System.Drawing.Point(30, 185);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(400, 180);
            this.lblOutput.Text = "Results will show here.";
            this.lblOutput.AutoSize = false;
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 400);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.lblOutput);
            this.Name = "Form1";
            this.Text = "Student Profile Processor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblMarks;
    }
}