namespace Registration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            btnCreate = new Button();
            label1 = new Label();
            numericUpDown = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPaternal = new TextBox();
            txtMaternal = new TextBox();
            txtRegistration = new TextBox();
            txtcareer = new TextBox();
            dateTimePicker = new DateTimePicker();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(57, 58);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 28);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(534, 292);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 30);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 31);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // numericUpDown
            // 
            numericUpDown.Location = new Point(291, 236);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(200, 23);
            numericUpDown.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 31);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 4;
            label2.Text = "Paternal surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(520, 31);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 5;
            label3.Text = "Maternal surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 119);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 6;
            label4.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(291, 119);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 7;
            label5.Text = "Registration";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 200);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 8;
            label6.Text = "Career";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(291, 200);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 9;
            label7.Text = "Average";
            // 
            // txtPaternal
            // 
            txtPaternal.Location = new Point(291, 58);
            txtPaternal.Multiline = true;
            txtPaternal.Name = "txtPaternal";
            txtPaternal.Size = new Size(200, 28);
            txtPaternal.TabIndex = 10;
            // 
            // txtMaternal
            // 
            txtMaternal.Location = new Point(520, 58);
            txtMaternal.Multiline = true;
            txtMaternal.Name = "txtMaternal";
            txtMaternal.Size = new Size(200, 28);
            txtMaternal.TabIndex = 11;
            // 
            // txtRegistration
            // 
            txtRegistration.Location = new Point(291, 148);
            txtRegistration.Multiline = true;
            txtRegistration.Name = "txtRegistration";
            txtRegistration.Size = new Size(200, 28);
            txtRegistration.TabIndex = 13;
            // 
            // txtcareer
            // 
            txtcareer.Location = new Point(57, 231);
            txtcareer.Multiline = true;
            txtcareer.Name = "txtcareer";
            txtcareer.Size = new Size(200, 28);
            txtcareer.TabIndex = 14;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(57, 153);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(117, 336);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(dateTimePicker);
            Controls.Add(txtcareer);
            Controls.Add(txtRegistration);
            Controls.Add(txtMaternal);
            Controls.Add(txtPaternal);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numericUpDown);
            Controls.Add(label1);
            Controls.Add(btnCreate);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Button btnCreate;
        private Label label1;
        private NumericUpDown numericUpDown;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPaternal;
        private TextBox txtMaternal;
        private TextBox txtRegistration;
        private TextBox txtcareer;
        private DateTimePicker dateTimePicker;
        private Label label8;
    }
}
