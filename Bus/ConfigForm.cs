using Bus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            try
            {
                string jsonConfigData = File.ReadAllText(configJsonFilepath);
                defaultConfig = Config.DeserializeFromJson(jsonConfigData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            InitializeComponent();

            StartDateTimePicker.Value = defaultConfig.StartTime;
            EndDateTimePicker.Value = defaultConfig.EndTime;
            FlowPowerMaskedTextBox.Text = defaultConfig.FlowCapacity.ToString();
            BoxOfficeCountMaskedTextBox.Text = defaultConfig.BoxOfficesCount.ToString();
            RoutesCountMaskedTextBox.Text = defaultConfig.RoutesCount.ToString();
            SimCoefficientMaskedTextBox.Text = defaultConfig.SimulationTimeScale.ToString();
        }

        private string configJsonFilepath = "config.json";

        private Config defaultConfig = new Config
        {
            StartTime = DateTime.Now,
            EndTime = DateTime.Now.AddHours(2),
            RoutesCount = 5,
            SimulationTimeScale = 1500,
            FlowCapacity = 100,
            BoxOfficesCount = 3,
            TimeIntervalInSeconds = 1
        };
        private void button1_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            try
            {
                config.StartTime = StartDateTimePicker.Value;
                config.EndTime   = EndDateTimePicker.Value;
                config.BoxOfficesCount = Int32.Parse(BoxOfficeCountMaskedTextBox.Text);
                config.FlowCapacity = Int32.Parse(FlowPowerMaskedTextBox.Text);
                config.RoutesCount = Int32.Parse(RoutesCountMaskedTextBox.Text);
                config.SimulationTimeScale = Int32.Parse(SimCoefficientMaskedTextBox.Text);
                config.TimeIntervalInSeconds = 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                config = defaultConfig;            
            }

            string json = Config.SerializeToJson(config);
            File.WriteAllText(configJsonFilepath, json);
            MainForm mainForm = new MainForm(config);
            mainForm.ShowDialog();
            Close();
        }

        private void RoutesCountMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
