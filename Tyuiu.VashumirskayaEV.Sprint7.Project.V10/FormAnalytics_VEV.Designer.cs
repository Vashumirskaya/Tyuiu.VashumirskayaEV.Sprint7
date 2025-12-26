namespace Tyuiu.VashumirskayaEV.Sprint7.Project.V10
{
    partial class FormAnalytics_VEV
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            labelTitleAnalytics_VEV = new Label();
            chartOrders_VEV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonClose_VEV = new Button();
            ((System.ComponentModel.ISupportInitialize)chartOrders_VEV).BeginInit();
            SuspendLayout();
            // 
            // labelTitleAnalytics_VEV
            // 
            labelTitleAnalytics_VEV.AutoSize = true;
            labelTitleAnalytics_VEV.Dock = DockStyle.Top;
            labelTitleAnalytics_VEV.Font = new Font("Segoe UI", 11F);
            labelTitleAnalytics_VEV.Location = new Point(0, 0);
            labelTitleAnalytics_VEV.Name = "labelTitleAnalytics_VEV";
            labelTitleAnalytics_VEV.Size = new Size(258, 25);
            labelTitleAnalytics_VEV.TabIndex = 0;
            labelTitleAnalytics_VEV.Text = "Что заказывают чаще всего:";
            labelTitleAnalytics_VEV.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chartOrders_VEV
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = -45;
            chartArea1.AxisX.LabelStyle.Font = new Font("Microsoft Sans Serif", 10F);
            chartArea1.AxisX.Title = "Товар";
            chartArea1.AxisY.Title = "Кол-во заказов";
            chartArea1.Name = "ChartArea1";
            chartOrders_VEV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartOrders_VEV.Legends.Add(legend1);
            chartOrders_VEV.Location = new Point(12, 44);
            chartOrders_VEV.Name = "chartOrders_VEV";
            chartOrders_VEV.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            chartOrders_VEV.Size = new Size(606, 394);
            chartOrders_VEV.TabIndex = 1;
            // 
            // buttonClose_VEV
            // 
            buttonClose_VEV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose_VEV.Font = new Font("Segoe UI", 12F);
            buttonClose_VEV.Location = new Point(633, 366);
            buttonClose_VEV.Name = "buttonClose_VEV";
            buttonClose_VEV.Size = new Size(155, 72);
            buttonClose_VEV.TabIndex = 2;
            buttonClose_VEV.Text = "Закрыть";
            buttonClose_VEV.UseVisualStyleBackColor = true;
            buttonClose_VEV.Click += buttonClose_VEV_Click;
            // 
            // FormAnalytics_VEV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClose_VEV);
            Controls.Add(chartOrders_VEV);
            Controls.Add(labelTitleAnalytics_VEV);
            Name = "FormAnalytics_VEV";
            Text = "FormAnalytics_VEV";
            ((System.ComponentModel.ISupportInitialize)chartOrders_VEV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitleAnalytics_VEV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrders_VEV;
        private Button buttonClose_VEV;
    }
}