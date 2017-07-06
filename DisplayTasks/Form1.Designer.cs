namespace DisplayTasks {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.MyDisplay = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Report1 = new System.Windows.Forms.Button();
            this.Report2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MyDisplay
            // 
            this.MyDisplay.FormattingEnabled = true;
            this.MyDisplay.Location = new System.Drawing.Point(46, 37);
            this.MyDisplay.Name = "MyDisplay";
            this.MyDisplay.Size = new System.Drawing.Size(758, 251);
            this.MyDisplay.TabIndex = 0;
            this.MyDisplay.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(810, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "TasksGeneration";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.TaskGeneration_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(810, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "DevelopersSorted";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DeveloperCompareClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(927, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.SalaryInput_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleName = "Select proficiency";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(927, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(810, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Pay Salary";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.PaySalary);
            // 
            // Report1
            // 
            this.Report1.Location = new System.Drawing.Point(84, 319);
            this.Report1.Name = "Report1";
            this.Report1.Size = new System.Drawing.Size(142, 36);
            this.Report1.TabIndex = 6;
            this.Report1.Text = "Sorted by Salary QA (report)";
            this.Report1.UseVisualStyleBackColor = true;
            this.Report1.Click += new System.EventHandler(this.Report1_Click);
            // 
            // Report2
            // 
            this.Report2.Location = new System.Drawing.Point(318, 319);
            this.Report2.Name = "Report2";
            this.Report2.Size = new System.Drawing.Size(124, 35);
            this.Report2.TabIndex = 7;
            this.Report2.Text = "Looking for Developer3 info(report)";
            this.Report2.UseVisualStyleBackColor = true;
            this.Report2.Click += new System.EventHandler(this.Report2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(523, 319);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 34);
            this.button6.TabIndex = 8;
            this.button6.Text = "Senior developers in the company(report)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Report3_click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(719, 319);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(131, 34);
            this.button7.TabIndex = 9;
            this.button7.Text = "Tasks difficulty < 5 report";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Report4_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(375, 392);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 35);
            this.button4.TabIndex = 10;
            this.button4.Text = "Developers with tasks estimation <10";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 583);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Report2);
            this.Controls.Add(this.Report1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MyDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MyDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Report1;
        private System.Windows.Forms.Button Report2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
    }
}

