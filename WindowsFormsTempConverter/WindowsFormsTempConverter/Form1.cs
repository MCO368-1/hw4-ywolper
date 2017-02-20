using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsTempConverter.Utilities;

namespace WindowsFormsTempConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void toComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temperature fromTemperature = (Temperature)fromComboBox.SelectedValue;
            Temperature toTemperature = (Temperature)toComboBox.SelectedValue;

            convertedTempLabel.Text = TemperatureConversion(decimal.Parse(tempTextBox.Text),
                fromTemperature,
                toTemperature).ToString("0.#");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fromComboBox.DataSource = Enum.GetValues(typeof(Temperature));
            toComboBox.DataSource = Enum.GetValues(typeof(Temperature));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
