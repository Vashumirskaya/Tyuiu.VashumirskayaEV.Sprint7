namespace Tyuiu.VashumirskayaEV.Sprint7.Project.V10
{
    partial class FormMain_VEV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_VEV));
            labelProjectInfo_VEV = new Label();
            buttonAbout_VEV = new Button();
            buttonOpenOrders_VEV = new Button();
            toolTipMain_VEV = new ToolTip(components);
            errorProvider1 = new ErrorProvider(components);
            toolTipOpen = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // labelProjectInfo_VEV
            // 
            labelProjectInfo_VEV.Font = new Font("Segoe UI", 12F);
            labelProjectInfo_VEV.Location = new Point(144, 39);
            labelProjectInfo_VEV.Name = "labelProjectInfo_VEV";
            labelProjectInfo_VEV.Size = new Size(500, 197);
            labelProjectInfo_VEV.TabIndex = 0;
            labelProjectInfo_VEV.Text = resources.GetString("labelProjectInfo_VEV.Text");
            labelProjectInfo_VEV.TextAlign = ContentAlignment.MiddleCenter;
            labelProjectInfo_VEV.Click += label1_Click;
            // 
            // buttonAbout_VEV
            // 
            buttonAbout_VEV.BackColor = Color.Gainsboro;
            buttonAbout_VEV.Image = Properties.Resources.warning_icon_exclamation_mark_3d_illustration_118019_68042;
            buttonAbout_VEV.Location = new Point(12, 255);
            buttonAbout_VEV.Name = "buttonAbout_VEV";
            buttonAbout_VEV.Size = new Size(154, 155);
            buttonAbout_VEV.TabIndex = 1;
            buttonAbout_VEV.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTipMain_VEV.SetToolTip(buttonAbout_VEV, "О программе");
            buttonAbout_VEV.UseVisualStyleBackColor = false;
            buttonAbout_VEV.Click += buttonAbout_VEV_Click;
            // 
            // buttonOpenOrders_VEV
            // 
            buttonOpenOrders_VEV.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOpenOrders_VEV.BackColor = Color.White;
            buttonOpenOrders_VEV.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOpenOrders_VEV.Location = new Point(569, 285);
            buttonOpenOrders_VEV.Name = "buttonOpenOrders_VEV";
            buttonOpenOrders_VEV.Size = new Size(198, 103);
            buttonOpenOrders_VEV.TabIndex = 3;
            buttonOpenOrders_VEV.Text = "Открыть";
            toolTipOpen.SetToolTip(buttonOpenOrders_VEV, "Открыть окно работы с заказами");
            buttonOpenOrders_VEV.UseVisualStyleBackColor = false;
            buttonOpenOrders_VEV.Click += buttonOpenOrders_VEV_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormMain_VEV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 453);
            Controls.Add(buttonOpenOrders_VEV);
            Controls.Add(buttonAbout_VEV);
            Controls.Add(labelProjectInfo_VEV);
            MinimumSize = new Size(800, 500);
            Name = "FormMain_VEV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Заказы - Главное Меню";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelProjectInfo_VEV;
        private Button buttonAbout_VEV;
        private Button buttonOpenOrders_VEV;
        private ToolTip toolTipMain_VEV;
        private ErrorProvider errorProvider1;
        private ToolTip toolTipOpen;
    }
}
