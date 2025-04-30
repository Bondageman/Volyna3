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
                        MessageBox.Show("Áóäü ëàñêà, ââåä³òü êîğåêòíó âèñîòó ë³òàêà (÷èñëî).", "Ïîìèëêà", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        allOK = false;
                    }

                    if (int.TryParse(textBoxPassengers.Text, out int passengers))
                    {
                        currentVehicle["Passengers"] = Convert.ToInt32(textBoxPassengers.Text);
                    }
                    else
                    {
                        MessageBox.Show("Áóäü ëàñêà, ââåä³òü ê³ëüê³ñòü ïàñàæèğ³â (ö³ëå ÷èñëî).", "Ïîìèëêà", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Áóäü ëàñêà, ââåä³òü ïîğò ïğèïèñêè äëÿ êîğàáëÿ.", "Ïîìèëêà", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        allOK = false;
                    }

                    if (int.TryParse(textBoxPassengers.Text, out int passengersShip))
                    {
                        currentVehicle["Passengers"] = Convert.ToInt32(textBoxPassengers.Text);
                    }
                    else
                    {
                        MessageBox.Show("Áóäü ëàñêà, ââåä³òü ê³ëüê³ñòü ïàñàæèğ³â (ö³ëå ÷èñëî).", "Ïîìèëêà", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Áóäü ëàñêà, ââåä³òü êîğåêòíó ö³íó (÷èñëî).", "Ïîìèëêà", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                allOK = false;
            }

            if (double.TryParse(textBoxSpeed.Text, out double speed))
            {
                currentVehicle["Speed"] = speed;

            }
            else
            {
                MessageBox.Show("Áóäü ëàñêà, ââåä³òü êîğåêòíó øâèäê³ñòü (÷èñëî).", "Ïîìèëêà", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                allOK = false;

            }

            if (int.TryParse(textBoxYear.Text, out int year))
            {
                if (year >= 1900 && year <= 2025)
                {
                    currentVehicle["Year"] = year; 

                }
                else
                {
                    MessageBox.Show("Ğ³ê ìàº áóòè ì³æ 1900 ³ 2025.", "Ïîìèëêà", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    allOK = false;

                }
            }
            else
            {
                MessageBox.Show("Áóäü ëàñêà, ââåä³òü êîğåêòíèé ğ³ê (ö³ëå ÷èñëî).", "Ïîìèëêà", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
