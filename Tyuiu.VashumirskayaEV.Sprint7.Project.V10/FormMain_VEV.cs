namespace Tyuiu.VashumirskayaEV.Sprint7.Project.V10
{
    public partial class FormMain_VEV : Form
    {
        public FormMain_VEV()
        {
            InitializeComponent();
        }

        private void toolStripMain_VEV_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAbout_VEV_Click(object sender, EventArgs e)
        {
            FormAbout_VEV about = new FormAbout_VEV();
            about.ShowDialog();
        }

        private void buttonOpenOrders_VEV_Click(object sender, EventArgs e)
        {
            FormOrders_VEV formOrders = new FormOrders_VEV();
            formOrders.ShowDialog();
        }
    }
}
