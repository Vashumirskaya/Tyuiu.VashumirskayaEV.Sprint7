namespace Tyuiu.VashumirskayaEV.Sprint7.Project.V10
{
    partial class FormOrders_VEV
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
            labelSearch_VEV = new Label();
            textBoxSearch_VEV = new TextBox();
            DataGridViewOrders_VEV = new DataGridView();
            buttonRun_VEV = new Button();
            buttonSave_VEV = new Button();
            buttonClose_VEV = new Button();
            buttonAnalytics_VEV = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOrders_VEV).BeginInit();
            SuspendLayout();
            // 
            // labelSearch_VEV
            // 
            labelSearch_VEV.AutoSize = true;
            labelSearch_VEV.Font = new Font("Segoe UI", 10F);
            labelSearch_VEV.Location = new Point(23, 20);
            labelSearch_VEV.Name = "labelSearch_VEV";
            labelSearch_VEV.Size = new Size(62, 23);
            labelSearch_VEV.TabIndex = 0;
            labelSearch_VEV.Text = "Поиск:";
            // 
            // textBoxSearch_VEV
            // 
            textBoxSearch_VEV.Location = new Point(95, 17);
            textBoxSearch_VEV.Name = "textBoxSearch_VEV";
            textBoxSearch_VEV.Size = new Size(684, 27);
            textBoxSearch_VEV.TabIndex = 1;
            textBoxSearch_VEV.TextChanged += textBoxSearch_VEV_TextChanged;
            // 
            // DataGridViewOrders_VEV
            // 
            DataGridViewOrders_VEV.AllowUserToAddRows = false;
            DataGridViewOrders_VEV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewOrders_VEV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewOrders_VEV.Location = new Point(23, 59);
            DataGridViewOrders_VEV.Name = "DataGridViewOrders_VEV";
            DataGridViewOrders_VEV.ReadOnly = true;
            DataGridViewOrders_VEV.RowHeadersWidth = 51;
            DataGridViewOrders_VEV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewOrders_VEV.Size = new Size(756, 284);
            DataGridViewOrders_VEV.TabIndex = 2;
            DataGridViewOrders_VEV.CellContentClick += DataGridViewOrders_VEV_CellContentClick;
            // 
            // buttonRun_VEV
            // 
            buttonRun_VEV.Font = new Font("Segoe UI", 12F);
            buttonRun_VEV.Location = new Point(23, 359);
            buttonRun_VEV.Name = "buttonRun_VEV";
            buttonRun_VEV.Size = new Size(175, 70);
            buttonRun_VEV.TabIndex = 3;
            buttonRun_VEV.Text = "Запустить";
            buttonRun_VEV.UseVisualStyleBackColor = true;
            buttonRun_VEV.Click += buttonRun_VEV_Click;
            // 
            // buttonSave_VEV
            // 
            buttonSave_VEV.Font = new Font("Segoe UI", 12F);
            buttonSave_VEV.Location = new Point(217, 359);
            buttonSave_VEV.Name = "buttonSave_VEV";
            buttonSave_VEV.Size = new Size(175, 70);
            buttonSave_VEV.TabIndex = 4;
            buttonSave_VEV.Text = "Сохранить";
            buttonSave_VEV.UseVisualStyleBackColor = true;
            buttonSave_VEV.Click += buttonSave_VEV_Click;
            // 
            // buttonClose_VEV
            // 
            buttonClose_VEV.Font = new Font("Segoe UI", 12F);
            buttonClose_VEV.Location = new Point(604, 359);
            buttonClose_VEV.Name = "buttonClose_VEV";
            buttonClose_VEV.Size = new Size(175, 70);
            buttonClose_VEV.TabIndex = 5;
            buttonClose_VEV.Text = "Закрыть";
            buttonClose_VEV.UseVisualStyleBackColor = true;
            buttonClose_VEV.Click += buttonClose_VEV_Click;
            // 
            // buttonAnalytics_VEV
            // 
            buttonAnalytics_VEV.Font = new Font("Segoe UI", 12F);
            buttonAnalytics_VEV.Location = new Point(412, 359);
            buttonAnalytics_VEV.Name = "buttonAnalytics_VEV";
            buttonAnalytics_VEV.Size = new Size(175, 70);
            buttonAnalytics_VEV.TabIndex = 6;
            buttonAnalytics_VEV.Text = "Аналитика";
            buttonAnalytics_VEV.UseVisualStyleBackColor = true;
            buttonAnalytics_VEV.Click += buttonAnalytics_VEV_Click;
            // 
            // FormOrders_VEV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAnalytics_VEV);
            Controls.Add(buttonClose_VEV);
            Controls.Add(buttonSave_VEV);
            Controls.Add(buttonRun_VEV);
            Controls.Add(DataGridViewOrders_VEV);
            Controls.Add(textBoxSearch_VEV);
            Controls.Add(labelSearch_VEV);
            Name = "FormOrders_VEV";
            Text = "FormOrders_VEV";
            ((System.ComponentModel.ISupportInitialize)DataGridViewOrders_VEV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSearch_VEV;
        private TextBox textBoxSearch_VEV;
        private DataGridView DataGridViewOrders_VEV;
        private Button buttonRun_VEV;
        private Button buttonSave_VEV;
        private Button buttonClose_VEV;
        private Button buttonAnalytics_VEV;
    }
}