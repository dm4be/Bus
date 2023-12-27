namespace Bus
{
    partial class ConfigForm
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
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RoutesCountMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FlowPowerMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SimCoefficientMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BoxOfficeCountMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Location = new System.Drawing.Point(317, 12);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.StartDateTimePicker.TabIndex = 0;
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Location = new System.Drawing.Point(317, 63);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.EndDateTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата и время старта симуляции";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(16, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(501, 78);
            this.button1.TabIndex = 3;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RoutesCountMaskedTextBox
            // 
            this.RoutesCountMaskedTextBox.Location = new System.Drawing.Point(317, 117);
            this.RoutesCountMaskedTextBox.Mask = "000";
            this.RoutesCountMaskedTextBox.Name = "RoutesCountMaskedTextBox";
            this.RoutesCountMaskedTextBox.Size = new System.Drawing.Size(200, 26);
            this.RoutesCountMaskedTextBox.TabIndex = 4;
            this.RoutesCountMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.RoutesCountMaskedTextBox_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата и время окончания симуляции";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество маршрутов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Мощность потока пассажиров";
            // 
            // FlowPowerMaskedTextBox
            // 
            this.FlowPowerMaskedTextBox.Location = new System.Drawing.Point(317, 150);
            this.FlowPowerMaskedTextBox.Mask = "00000";
            this.FlowPowerMaskedTextBox.Name = "FlowPowerMaskedTextBox";
            this.FlowPowerMaskedTextBox.Size = new System.Drawing.Size(200, 26);
            this.FlowPowerMaskedTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Коэффициент симуляции";
            // 
            // SimCoefficientMaskedTextBox
            // 
            this.SimCoefficientMaskedTextBox.Location = new System.Drawing.Point(317, 195);
            this.SimCoefficientMaskedTextBox.Mask = "00000";
            this.SimCoefficientMaskedTextBox.Name = "SimCoefficientMaskedTextBox";
            this.SimCoefficientMaskedTextBox.Size = new System.Drawing.Size(200, 26);
            this.SimCoefficientMaskedTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Количество касс";
            // 
            // BoxOfficeCountMaskedTextBox
            // 
            this.BoxOfficeCountMaskedTextBox.Location = new System.Drawing.Point(317, 244);
            this.BoxOfficeCountMaskedTextBox.Mask = "00";
            this.BoxOfficeCountMaskedTextBox.Name = "BoxOfficeCountMaskedTextBox";
            this.BoxOfficeCountMaskedTextBox.Size = new System.Drawing.Size(200, 26);
            this.BoxOfficeCountMaskedTextBox.TabIndex = 12;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.BoxOfficeCountMaskedTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SimCoefficientMaskedTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FlowPowerMaskedTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoutesCountMaskedTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.StartDateTimePicker);
            this.Name = "ConfigForm";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox RoutesCountMaskedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox FlowPowerMaskedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox SimCoefficientMaskedTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox BoxOfficeCountMaskedTextBox;
    }
}