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
            labelTitleAnalytics_VEV = new Label();
            buttonClose_VEV = new Button();
            panelChart_VEV = new Panel();
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
            // panelChart_VEV
            // 
            panelChart_VEV.BackColor = Color.White;
            panelChart_VEV.Location = new Point(12, 37);
            panelChart_VEV.Name = "panelChart_VEV";
            panelChart_VEV.Size = new Size(615, 401);
            panelChart_VEV.TabIndex = 3;
            // 
            // FormAnalytics_VEV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(panelChart_VEV);
            Controls.Add(buttonClose_VEV);
            Controls.Add(labelTitleAnalytics_VEV);
            Name = "FormAnalytics_VEV";
            Text = "FormAnalytics_VEV";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitleAnalytics_VEV;
        private Button buttonClose_VEV;
        private Panel panelChart_VEV;
    }
}