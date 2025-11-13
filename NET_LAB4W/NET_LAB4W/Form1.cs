namespace NET_LAB4W
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void buttonShow_Click(object sender, EventArgs e)
        {
            textBoxOutput.Clear();

            object[][] data = new object[3][];

            data[0] = new object[] { "Мотоцикл", "Yamaha", 600, 2020 };
            data[1] = new object[] { "Студент", "Иванов", 19, "ИТ-21" };
            data[2] = new object[] { "Пассажирский самолёт", "Boeing 737", 160, 850.5 };

            foreach (object[] arr in data)
            {
                foreach (object item in arr)
                {
                    textBoxOutput.AppendText(item.ToString() + " ");
                }
                textBoxOutput.AppendText(Environment.NewLine);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxOutput.Clear();
        }
    }
}
