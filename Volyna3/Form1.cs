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
                        if(height >= 50 && height <= 10000)
                        {
                            currentVehicle["Height"] = Convert.ToDouble(textBoxHeight.Text);
                        } else
                        {
                            MessageBox.Show("Height must be in [50; 10000] range", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            allOK = false;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the correct aircraft (number).", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        allOK = false;
                    }

                    if (int.TryParse(textBoxPassengers.Text, out int passengers))
                    {
                        if (passengers >= 0 && passengers < 850)
                        {
                            currentVehicle["Passengers"] = Convert.ToInt32(textBoxPassengers.Text);

                        } else
                        {
                            MessageBox.Show("Please enter the correct value [0; 850]", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            allOK = false;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the number of passengers (integer)", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        allOK = false;
                    }
                    if (double.TryParse(textBoxSpeed.Text, out double speed))
                    {
                        if (speed >= 0 && speed < 3500)
                        {
                            currentVehicle["Speed"] = speed;
                        }
                        else
                        {
                            MessageBox.Show("Please enter the correct value [0; 3500]", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            allOK = false;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the correct speed (number).", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        allOK = false;

                    }

                    break;
                case "Car":
                    currentVehicle = new Car();
                    if (double.TryParse(textBoxSpeed.Text, out double speed1))
                    {
                        if (speed1 >= 0 && speed1 < 500)
                        {
                            currentVehicle["Speed"] = speed1;
                        }
                        else
                        {
                            MessageBox.Show("Please enter the correct value [0; 500]", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            allOK = false;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the correct speed (number).", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        allOK = false;

                    }
                    break;
                case "Ship":
                    currentVehicle = new Ship();

                    if (!string.IsNullOrWhiteSpace(textBoxPort.Text))
                    {
                        currentVehicle["Port"] = textBoxPort.Text;
                    }
                    else
                    {
                        MessageBox.Show("Please enter the home port for the ship.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        allOK = false;
                    }

                    if (int.TryParse(textBoxPassengers.Text, out int passengersShip))
                    {
                        if (passengersShip >= 0 && passengersShip < 6500)
                        {
                            currentVehicle["Passengers"] = Convert.ToInt32(textBoxPassengers.Text);
                        }
                        else
                        {
                            MessageBox.Show("Please enter the correct value [0; 6500]", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            allOK = false;

                        }

                    }
                    else
                    {
                        MessageBox.Show("Please enter the number of passengers.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        allOK = false;
                    }
                    if (double.TryParse(textBoxSpeed.Text, out double speed2))
                    {
                        if (speed2 >= 0 && speed2 < 40)
                        {
                            currentVehicle["Speed"] = speed2;
                        }
                        else
                        {
                            MessageBox.Show("Please enter the correct value [0; 40]", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            allOK = false;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the correct speed (number).", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        allOK = false;

                    }

                    break;
                default:
                    MessageBox.Show("Please select a vehicle type.");
                    return;
            }


            if (double.TryParse(textBoxPrice.Text, out double price))
            {
                if (price >= 0 && price < 1000000)
                {
                    currentVehicle["Price"] = Convert.ToDouble(textBoxPrice.Text);

                }
                else
                {
                    MessageBox.Show("Please enter the correct value [0; 1000000]", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    allOK = false;
                }

            }
            else
            {
                MessageBox.Show("Please enter the correct price (number).", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                allOK = false;
            }

            //if (double.TryParse(textBoxSpeed.Text, out double speed))
            //{
            //    if (speed >= 0 && speed < 3500)
            //    {
            //        currentVehicle["Speed"] = speed;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please enter the correct value [0; 3500]", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please enter the correct price (number).Please enter the correct speed (number).", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    allOK = false;

            //}

            if (int.TryParse(textBoxYear.Text, out int year))
            {
                if (year >= 1900 && year <= 2025)
                {
                    currentVehicle["Year"] = year; 

                }
                else
                {
                    MessageBox.Show("Ğ³ê ìàº áóòè ì³æ 1900 ³ 2025.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    allOK = false;

                }
            }
            else
            {
                MessageBox.Show("Please enter the correct year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                allOK = false;
            }

            //currentVehicle["Price"] = Convert.ToDouble(textBoxPrice.Text);
            //currentVehicle["Speed"] = Convert.ToDouble(textBoxSpeed.Text);
            //currentVehicle["Year"] = Convert.ToInt32(textBoxYear.Text);
            if (allOK)
            {
                MessageBox.Show("Vehicle created!");
                if (currentVehicle != null)
                    listBoxOutput.Items.Add(currentVehicle.GetInfo());
                else
                    MessageBox.Show("No vehicle created.");

            }
            
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
