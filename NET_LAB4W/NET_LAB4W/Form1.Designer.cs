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
            buttonShow = new Button();
            textBoxOutput = new TextBox();
            buttonClear = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // buttonShow
            // 
            buttonShow.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonShow.Location = new Point(30, 361);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(225, 65);
            buttonShow.TabIndex = 0;
            buttonShow.Text = "Показать данные";
            buttonShow.UseVisualStyleBackColor = true;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(261, 70);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(340, 285);
            textBoxOutput.TabIndex = 1;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonClear.Location = new Point(320, 361);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(225, 65);
            buttonClear.TabIndex = 2;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 70);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 285);
            textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 450);
            Controls.Add(textBox1);
            Controls.Add(buttonClear);
            Controls.Add(textBoxOutput);
            Controls.Add(buttonShow);
            Name = "Form1";
            Text = "Лабараторная работа 4. Задание 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonShow;
        private TextBox textBoxOutput;
        private Button buttonClear;
        private TextBox textBox1;
    }
}
