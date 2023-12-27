namespace Bus
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BoxOfficesDatagridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handledRequestsAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageQueueLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentQueueLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handlerStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxOfficeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suburbanRouteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.routeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeDepartureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeCountAvailableSeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.StartBtn = new System.Windows.Forms.Button();
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BoxOfficesDatagridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxOfficeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suburbanRouteBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxOfficesDatagridView
            // 
            this.BoxOfficesDatagridView.AllowUserToAddRows = false;
            this.BoxOfficesDatagridView.AllowUserToDeleteRows = false;
            this.BoxOfficesDatagridView.AllowUserToOrderColumns = true;
            this.BoxOfficesDatagridView.AutoGenerateColumns = false;
            this.BoxOfficesDatagridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BoxOfficesDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BoxOfficesDatagridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.handledRequestsAmountDataGridViewTextBoxColumn,
            this.averageQueueLengthDataGridViewTextBoxColumn,
            this.currentQueueLengthDataGridViewTextBoxColumn,
            this.handlerStatusDataGridViewTextBoxColumn});
            this.BoxOfficesDatagridView.DataSource = this.boxOfficeBindingSource;
            this.BoxOfficesDatagridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoxOfficesDatagridView.Location = new System.Drawing.Point(3, 2);
            this.BoxOfficesDatagridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BoxOfficesDatagridView.Name = "BoxOfficesDatagridView";
            this.BoxOfficesDatagridView.ReadOnly = true;
            this.BoxOfficesDatagridView.RowHeadersWidth = 62;
            this.BoxOfficesDatagridView.RowTemplate.Height = 28;
            this.BoxOfficesDatagridView.Size = new System.Drawing.Size(773, 437);
            this.BoxOfficesDatagridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Идентификатор";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя кассира";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // handledRequestsAmountDataGridViewTextBoxColumn
            // 
            this.handledRequestsAmountDataGridViewTextBoxColumn.DataPropertyName = "HandledRequestsAmount";
            this.handledRequestsAmountDataGridViewTextBoxColumn.HeaderText = "Количество обработанных запросов";
            this.handledRequestsAmountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.handledRequestsAmountDataGridViewTextBoxColumn.Name = "handledRequestsAmountDataGridViewTextBoxColumn";
            this.handledRequestsAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // averageQueueLengthDataGridViewTextBoxColumn
            // 
            this.averageQueueLengthDataGridViewTextBoxColumn.DataPropertyName = "AverageQueueLength";
            this.averageQueueLengthDataGridViewTextBoxColumn.HeaderText = "Средняя длина очереди";
            this.averageQueueLengthDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.averageQueueLengthDataGridViewTextBoxColumn.Name = "averageQueueLengthDataGridViewTextBoxColumn";
            this.averageQueueLengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentQueueLengthDataGridViewTextBoxColumn
            // 
            this.currentQueueLengthDataGridViewTextBoxColumn.DataPropertyName = "CurrentQueueLength";
            this.currentQueueLengthDataGridViewTextBoxColumn.HeaderText = "Текущая длина очереди";
            this.currentQueueLengthDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.currentQueueLengthDataGridViewTextBoxColumn.Name = "currentQueueLengthDataGridViewTextBoxColumn";
            this.currentQueueLengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // handlerStatusDataGridViewTextBoxColumn
            // 
            this.handlerStatusDataGridViewTextBoxColumn.DataPropertyName = "HandlerStatus";
            this.handlerStatusDataGridViewTextBoxColumn.HeaderText = "Статус работника";
            this.handlerStatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.handlerStatusDataGridViewTextBoxColumn.Name = "handlerStatusDataGridViewTextBoxColumn";
            this.handlerStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boxOfficeBindingSource
            // 
            this.boxOfficeBindingSource.DataSource = typeof(Bus.BoxOffice);
            // 
            // suburbanRouteBindingSource
            // 
            this.suburbanRouteBindingSource.DataSource = typeof(Bus.SuburbanRoute);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 470);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BoxOfficesDatagridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(779, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Кассы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(779, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расписание";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routeNumberDataGridViewTextBoxColumn,
            this.routeLengthDataGridViewTextBoxColumn,
            this.routeDepartureTimeDataGridViewTextBoxColumn,
            this.routeCountAvailableSeatsDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.suburbanRouteBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 2);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(774, 438);
            this.dataGridView2.TabIndex = 0;
            // 
            // routeNumberDataGridViewTextBoxColumn
            // 
            this.routeNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.routeNumberDataGridViewTextBoxColumn.DataPropertyName = "RouteNumber";
            this.routeNumberDataGridViewTextBoxColumn.HeaderText = "Номер маршрута";
            this.routeNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.routeNumberDataGridViewTextBoxColumn.Name = "routeNumberDataGridViewTextBoxColumn";
            this.routeNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.routeNumberDataGridViewTextBoxColumn.Width = 135;
            // 
            // routeLengthDataGridViewTextBoxColumn
            // 
            this.routeLengthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.routeLengthDataGridViewTextBoxColumn.DataPropertyName = "RouteLength";
            this.routeLengthDataGridViewTextBoxColumn.HeaderText = "Дальность";
            this.routeLengthDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.routeLengthDataGridViewTextBoxColumn.Name = "routeLengthDataGridViewTextBoxColumn";
            this.routeLengthDataGridViewTextBoxColumn.ReadOnly = true;
            this.routeLengthDataGridViewTextBoxColumn.Width = 105;
            // 
            // routeDepartureTimeDataGridViewTextBoxColumn
            // 
            this.routeDepartureTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.routeDepartureTimeDataGridViewTextBoxColumn.DataPropertyName = "RouteDepartureTime";
            this.routeDepartureTimeDataGridViewTextBoxColumn.HeaderText = "Дата и время отправления";
            this.routeDepartureTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.routeDepartureTimeDataGridViewTextBoxColumn.Name = "routeDepartureTimeDataGridViewTextBoxColumn";
            this.routeDepartureTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.routeDepartureTimeDataGridViewTextBoxColumn.Width = 192;
            // 
            // routeCountAvailableSeatsDataGridViewTextBoxColumn
            // 
            this.routeCountAvailableSeatsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.routeCountAvailableSeatsDataGridViewTextBoxColumn.DataPropertyName = "RouteCountAvailableSeats";
            this.routeCountAvailableSeatsDataGridViewTextBoxColumn.HeaderText = "Осталось мест";
            this.routeCountAvailableSeatsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.routeCountAvailableSeatsDataGridViewTextBoxColumn.Name = "routeCountAvailableSeatsDataGridViewTextBoxColumn";
            this.routeCountAvailableSeatsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 1000;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(804, 36);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(198, 51);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "Запуск";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.AutoSize = true;
            this.CurrentTimeLabel.Location = new System.Drawing.Point(804, 166);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(0, 16);
            this.CurrentTimeLabel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(804, 91);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Пауза";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CurrentTimeLabel);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Кассы и расписание";
            ((System.ComponentModel.ISupportInitialize)(this.BoxOfficesDatagridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxOfficeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suburbanRouteBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BoxOfficesDatagridView;
        private System.Windows.Forms.BindingSource boxOfficeBindingSource;
        private System.Windows.Forms.BindingSource suburbanRouteBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label CurrentTimeLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeDepartureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeCountAvailableSeatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handledRequestsAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageQueueLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentQueueLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handlerStatusDataGridViewTextBoxColumn;
    }
}