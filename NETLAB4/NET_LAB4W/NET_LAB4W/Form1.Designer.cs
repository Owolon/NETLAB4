namespace NET_LAB4W
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
            components = new System.ComponentModel.Container();
            textBoxPut0 = new TextBox();
            buttonClear = new Button();
            textBoxOutput = new TextBox();
            buttonAdd = new Button();
            textBoxPut1 = new TextBox();
            textBoxPut2 = new TextBox();
            textBoxPut3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            SuspendLayout();
            // 
            // textBoxPut0
            // 
            textBoxPut0.Location = new Point(1, 46);
            textBoxPut0.Name = "textBoxPut0";
            textBoxPut0.Size = new Size(340, 23);
            textBoxPut0.TabIndex = 1;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonClear.Location = new Point(517, 361);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(134, 65);
            buttonClear.TabIndex = 2;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click_1;
            // 
            // textBoxOutput
            // 
            textBoxOutput.BackColor = SystemColors.GradientActiveCaption;
            textBoxOutput.BorderStyle = BorderStyle.None;
            textBoxOutput.Location = new Point(30, 70);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(274, 356);
            textBoxOutput.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAdd.Location = new Point(311, 361);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(200, 65);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Добавить элемент";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += button1_Click;
            // 
            // textBoxPut1
            // 
            textBoxPut1.Location = new Point(0, 120);
            textBoxPut1.Name = "textBoxPut1";
            textBoxPut1.Size = new Size(340, 23);
            textBoxPut1.TabIndex = 5;
            // 
            // textBoxPut2
            // 
            textBoxPut2.Location = new Point(0, 203);
            textBoxPut2.Name = "textBoxPut2";
            textBoxPut2.Size = new Size(340, 23);
            textBoxPut2.TabIndex = 6;
            // 
            // textBoxPut3
            // 
            textBoxPut3.Location = new Point(0, 279);
            textBoxPut3.Name = "textBoxPut3";
            textBoxPut3.Size = new Size(340, 23);
            textBoxPut3.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 28);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 8;
            label1.Text = "Введите имя студента:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 102);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 9;
            label2.Text = "Введите группу студента:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 185);
            label3.Name = "label3";
            label3.Size = new Size(148, 15);
            label3.TabIndex = 10;
            label3.Text = "Введите возраст студента:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 261);
            label4.Name = "label4";
            label4.Size = new Size(196, 15);
            label4.TabIndex = 11;
            label4.Text = "Введите город рождения студента:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(114, 37);
            label5.TabIndex = 12;
            label5.Text = "Студент";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 52);
            label6.Name = "label6";
            label6.Size = new Size(196, 15);
            label6.TabIndex = 13;
            label6.Text = "Сохранённые карточки студентов:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxPut3);
            groupBox1.Controls.Add(textBoxPut2);
            groupBox1.Controls.Add(textBoxPut1);
            groupBox1.Controls.Add(textBoxPut0);
            groupBox1.Location = new Point(310, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 338);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(689, 450);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxOutput);
            Controls.Add(buttonClear);
            Name = "Form1";
            Text = "Лабараторная работа 4. Задание 2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxPut0;
        private Button buttonClear;
        private TextBox textBoxOutput;
        private Button buttonAdd;
        private TextBox textBoxPut1;
        private TextBox textBoxPut2;
        private TextBox textBoxPut3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
    }
}
