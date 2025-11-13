namespace NET_LAB4W
{
    public partial class Form1 : Form
    {
        private List<object[]> objectsList = new List<object[]>();

        public Form1()
        {
            InitializeComponent();

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string Name = textBoxPut0.Text;
            string Grup = textBoxPut1.Text;
            int Age = Convert.ToInt32(textBoxPut2.Text);
            string Gorod = textBoxPut3.Text;

            object[] newStudent = new object[] { Name, Grup, Age, Gorod };
            objectsList.Add(newStudent);

            ShowObjects();
        }

        private void ShowObjects()
        {
            textBoxOutput.Clear();

            foreach (var obj in objectsList)
            {
                foreach (var item in obj)
                {
                    textBoxOutput.AppendText(item.ToString() + "\t");
                }
                textBoxOutput.AppendText(Environment.NewLine);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            objectsList.Clear();
            textBoxOutput.Clear();
            textBoxPut0.Clear();
            textBoxPut1.Clear();
            textBoxPut2.Clear();
            textBoxPut3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {

        }
    }
}
