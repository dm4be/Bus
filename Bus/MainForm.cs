using Newtonsoft.Json;
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
    public partial class MainForm : Form
    {
        private MainModule mod;
        private int timerIntervalInSeconds = 1;
        private TimeTable tt;
        private DateTime StartTime;
        private DateTime EndTime;
        public MainForm(Config cfg)
        {
            FormClosing += new FormClosingEventHandler(SaveStatsToFile); 
            Console.WriteLine("Config:");
            Console.WriteLine($"{cfg.StartTime}");
            Console.WriteLine($"{cfg.EndTime}");
            Console.WriteLine($"{cfg.FlowCapacity}");
            Console.WriteLine($"{cfg.BoxOfficesCount}");
            StartTime = cfg.StartTime;
            EndTime = cfg.EndTime;
            tt = new TimeTable(RoutesGenerator.GenerateRandomRoutes(StartTime, EndTime, cfg.RoutesCount));
            PassengerFlowController pfc = new PassengerFlowController(tt, StartTime, EndTime, cfg.FlowCapacity);
            TicketProcessor tp = new TicketProcessor(StartTime, EndTime, cfg.BoxOfficesCount);
            mod = new MainModule(pfc, tp, cfg);

            InitializeComponent();
            BoxOfficesDatagridView.RowPrePaint += Boxoffices_RowPrePaint;
            MainTimer.Interval = 1000 * cfg.TimeIntervalInSeconds;
        }

        private void SaveStatsToFile(object sender, FormClosingEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON файл (*.json)|*.json|Все файлы (*.*)|*.*";
            saveFileDialog.Title = "Сохранить в JSON файл";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    WriteDataGridViewToFile(filePath, BoxOfficesDatagridView);
                    WriteDataGridViewToFile(filePath, dataGridView2);
                    MessageBox.Show("Данные успешно сохранены в JSON файл.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении в JSON файл: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void WriteDataGridViewToFile(string filename, DataGridView dgv)
        {
            List<Dictionary<string, object>> dataList = new List<Dictionary<string, object>>();

            // Преобразование данных из DataGridView в список словарей
            foreach (DataGridViewRow row in dgv.Rows)
            {
                Dictionary<string, object> rowData = new Dictionary<string, object>();

                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    rowData[col.Name] = row.Cells[col.Index].Value;
                }

                dataList.Add(rowData);
            }

            // Сериализация в JSON и запись в файл
            string json = JsonConvert.SerializeObject(dataList, Formatting.Indented);
            File.AppendAllText(filename, json);

        }
        private void MainTimer_Tick(object sender, EventArgs e)
        {
            if (mod.CurrentSimulationTime > EndTime)
            { 
                MainTimer.Stop();
                return;
            }

            boxOfficeBindingSource.DataSource = mod.GetListOfBoxOffices().OrderBy(box => box.Id);
            CurrentTimeLabel.Text = mod.CurrentSimulationTime.ToString();
            suburbanRouteBindingSource.DataSource = tt.GetAllSuburbanRoutes();
            //tt.GetAllSuburbanRoutes();
            mod.SimulationStep(TimeSpan.FromSeconds(timerIntervalInSeconds));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainTimer.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainTimer.Stop();
        }

        private void Boxoffices_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

            int cashierStatusColumnIndex = BoxOfficesDatagridView.Columns["handlerStatusDataGridViewTextBoxColumn"].Index;
            // Получить значение в указанной колонке для текущей строки
            string cashierStatus = BoxOfficesDatagridView.Rows[e.RowIndex].Cells[cashierStatusColumnIndex].Value?.ToString();

            if (cashierStatus == "На перерыве")
            {
                // Изменить цвет строки в зависимости от значения
                BoxOfficesDatagridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                return;
            }

            // Указать номер колонки, значение которой будет определять цвет строки
            int avgQueueLengthColumnIndex = BoxOfficesDatagridView.Columns["averageQueueLengthDataGridViewTextBoxColumn"].Index;
            // Указать пороговое значение, при котором цвет строки будет изменен
            int thresholdValue = 3;
            // Получить значение в указанной колонке для текущей строки
            int cellValue = Convert.ToInt32(BoxOfficesDatagridView.Rows[e.RowIndex].Cells[avgQueueLengthColumnIndex].Value);


            // Изменить цвет строки в зависимости от значения
            BoxOfficesDatagridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = cellValue < thresholdValue
                ? Color.LightGreen
                : Color.LightCoral;
        }
    }
}
