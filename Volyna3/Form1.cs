namespace Volyna3
{
    public partial class Form1 : Form
    {
        Vehicle currentVehicle;

        public Form1()
        {
            InitializeComponent();
            comboBoxType.Items.AddRange(new string[] { "Plane", "Car", "Ship" });

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            bool allOK = true;


            switch (comboBoxType.SelectedItem?.ToString())
            {
                case "Plane":
                    currentVehicle = new Plane();

                    if (double.TryParse(textBoxHeight.Text, out double height))
                    {
                        currentVehicle["Height"] = Convert.ToDouble(textBoxHeight.Text);
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, введіть коректну висоту літака (число).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        allOK = false;
                    }

                    if (int.TryParse(textBoxPassengers.Text, out int passengers))
                    {
                        currentVehicle["Passengers"] = Convert.ToInt32(textBoxPassengers.Text);
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, введіть кількість пасажирів (ціле число).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        allOK = false;
                    }
                    break;
                case "Car":
                    currentVehicle = new Car();
                    break;
                case "Ship":
                    currentVehicle = new Ship();

                    if (!string.IsNullOrWhiteSpace(textBoxPort.Text))
                    {
                        currentVehicle["Port"] = textBoxPort.Text;
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, введіть порт приписки для корабля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        allOK = false;
                    }

                    if (int.TryParse(textBoxPassengers.Text, out int passengersShip))
                    {
                        currentVehicle["Passengers"] = Convert.ToInt32(textBoxPassengers.Text);
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, введіть кількість пасажирів (ціле число).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        allOK = false;
                    }

                    break;
                default:
                    MessageBox.Show("Please select a vehicle type.");
                    return;
            }


            if (double.TryParse(textBoxPrice.Text, out double price))
            {
                currentVehicle["Price"] = Convert.ToDouble(textBoxPrice.Text);

            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректну ціну (число).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                allOK = false;
            }

            if (double.TryParse(textBoxSpeed.Text, out double speed))
            {
                currentVehicle["Speed"] = Convert.ToDouble(textBoxSpeed.Text);

            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректну швидкість (число).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                allOK = false;

            }

            if (int.TryParse(textBoxYear.Text, out int year))
            {
                currentVehicle["Year"] = Convert.ToInt32(textBoxYear.Text);
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректний рік (ціле число).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                allOK = false;
            }

            //currentVehicle["Price"] = Convert.ToDouble(textBoxPrice.Text);
            //currentVehicle["Speed"] = Convert.ToDouble(textBoxSpeed.Text);
            //currentVehicle["Year"] = Convert.ToInt32(textBoxYear.Text);
            if (allOK)
            {
                MessageBox.Show("Vehicle created!");

            }
            if (currentVehicle != null)
                listBoxOutput.Items.Add(currentVehicle.GetInfo());
            else
                MessageBox.Show("No vehicle created.");
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (currentVehicle != null)
                listBoxOutput.Items.Add(currentVehicle.GetInfo());
            else
                MessageBox.Show("No vehicle created.");
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBoxType.SelectedItem.ToString();
            textBoxHeight.Enabled = selected == "Plane";
            textBoxPassengers.Enabled = selected == "Plane" || selected == "Ship";
            textBoxPort.Enabled = selected == "Ship";
        }

        private void listBoxOutput_Click(object sender, EventArgs e)
        {
            
        }
    }
}
