namespace Tyuiu.VashumirskayaEV.Sprint7.Project.V10
{
    partial class FormAbout_VEV
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            buttonClose_VEV = new Button();
            toolTipClose = new ToolTip(components);
            toolTipPhoto = new ToolTip(components);
            toolTipInfo = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(25, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 267);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            toolTipPhoto.SetToolTip(pictureBox1, "Фото разработчика");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(241, 36);
            label1.Name = "label1";
            label1.Size = new Size(389, 100);
            label1.TabIndex = 1;
            label1.Text = "Разработчик: Вашумирская Елизавета Владимировна\r\nГруппа: СМАРТб-25-1\r\nПрограмма разработана в рамках обучения языка С#\r\nТюменский Индустриальный Университет (ВШЦТ)\r\nВнутреннее имя:";
            toolTipInfo.SetToolTip(label1, "Краткая информация");
            // 
            // buttonClose_VEV
            // 
            buttonClose_VEV.Font = new Font("Segoe UI", 11F);
            buttonClose_VEV.Location = new Point(504, 280);
            buttonClose_VEV.Name = "buttonClose_VEV";
            buttonClose_VEV.Size = new Size(126, 44);
            buttonClose_VEV.TabIndex = 2;
            buttonClose_VEV.Text = "Закрыть";
            toolTipClose.SetToolTip(buttonClose_VEV, "Закрыть окно");
            buttonClose_VEV.UseVisualStyleBackColor = true;
            buttonClose_VEV.Click += buttonClose_VEV_Click;
            // 
            // FormAbout_VEV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(642, 336);
            Controls.Add(buttonClose_VEV);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormAbout_VEV";
            Text = "FormAbout_VEV";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button buttonClose_VEV;
        private ToolTip toolTipClose;
        private ToolTip toolTipPhoto;
        private ToolTip toolTipInfo;
    }
}