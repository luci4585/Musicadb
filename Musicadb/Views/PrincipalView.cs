namespace Musicadb
{
    public partial class PrincipalView : Form
    {
        public PrincipalView()
        {
            InitializeComponent();
        }

        private void salidaBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeBoton_Click(object sender, EventArgs e)
        {
            AcercaDeView acercaDe = new AcercaDeView();
            acercaDe.ShowDialog();
        }
    }
}
