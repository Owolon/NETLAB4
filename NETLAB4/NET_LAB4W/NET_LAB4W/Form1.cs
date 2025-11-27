namespace NET_LAB4W
{
    public partial class Form1 : Form
    {
        private List<object[]> objectsList = new List<object[]>();

        public Form1()
        {
            InitializeComponent();

        }

        private void ShowObjects()
        {
            textBoxOutput.Clear();

            foreach (var obj in objectsList)
            {
                foreach (var item in obj)
                {
                    textBoxOutput.AppendText(item.ToString() + ",   ");
                }
                textBoxOutput.AppendText(Environment.NewLine);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = "", Grup = "", Gorod = "";
            int Age = 0;
            if (!CheckTextBoxNotEmpty(textBoxPut0, "Имя студента")) 
                errorProvider1.SetError(textBoxPut0, "Введите значение");
            else { Name = textBoxPut0.Text; }
            if (!CheckTextBoxNotEmpty(textBoxPut1, "Группа студента")) 
                errorProvider1.SetError(textBoxPut1, "Введите значение");
            else { Grup = textBoxPut1.Text; }
            if (!CheckNumber(textBoxPut2, "Возраст студента")) 
                errorProvider1.SetError(textBoxPut2, "Введите значение");
            else { Age = Convert.ToInt32(textBoxPut2.Text); }
            if (!CheckTextBoxNotEmpty(textBoxPut3, "Город рождения студента"))
                errorProvider1.SetError(textBoxPut3, "Введите значение");
            else
            { Gorod = textBoxPut3.Text; }

            if (Name != "" && Grup != "" && Gorod != "" && Age != 0)
                {object[] newStudent = new object[] { Name, Grup, Age, Gorod };
                objectsList.Add(newStudent);
            }

            ShowObjects();
        }

        bool CheckTextBoxNotEmpty(TextBox box, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(box.Text))
            {
                MessageBox.Show($"Поле '{fieldName}' не заполнено!", "Ошибка ввода");
                box.Focus();
                return false;
            }
            return true;
        }
        bool CheckNumber(TextBox box, string fieldName)
        {
            if (!double.TryParse(box.Text, out _))
            {
                MessageBox.Show($"Поле '{fieldName}' должно содержать число!", "Ошибка ввода");
                box.Clear();
                box.Focus();
                return false;
            }
            return true;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            objectsList.Clear();
            textBoxOutput.Clear();
            textBoxPut0.Clear();
            textBoxPut1.Clear();
            textBoxPut2.Clear();
            textBoxPut3.Clear();
            MessageBox.Show("Поля очищены.");
        }
        
    }
}
