namespace Musicadb
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void salidaBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeBoton_Click(object sender, EventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.ShowDialog();
        }
    }
}
