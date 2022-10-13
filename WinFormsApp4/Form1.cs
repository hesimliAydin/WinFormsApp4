namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //var cars = new List<string>
            //{
            //    "Chevrolet",
            //    "Audi",
            //    "Mercedes",
            //    "Ferrari"
            //};
            //listBox1.DataSource = cars;
            //listBox1.SelectedIndex = 2;


            List<Car> cars = new List<Car>
            {
                new Car
                {
                    Name="BMW F10"
                },
                new Car
                {
                    Name="Cadillac"
                },
                new Car
                {
                    Name="Toyota Camry"
                }
            };

            listBox1.Items.AddRange(cars.ToArray());
            listBox1.SelectedIndex = 0;
            //listBox1.DataSource = cars;


         //   listBox1.DisplayMember = nameof(Car.Name);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var item = (listBox1).SelectedItem as string;
            //label1.Text = item;
            try
            {
            var item=listBox1.SelectedItem as Car;
            label1.Text = item.ToString();

            }
            catch (Exception ex)
            {
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Car
            {
                Name = textBox1.Text
            });
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.DataSource = null;
            listBox2.DataSource = listBox1.SelectedItems;
        }
    }
}