namespace kararYapisi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTikla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ugulamamıza hoş geldiniz. Butona tıkladınız");
        }

        private void buttonYakala_MouseEnter(object sender, EventArgs e)
        {
            Random rastgeleSayiUretici = new Random();
            buttonYakala.Top = rastgeleSayiUretici.Next(0, this.Height - buttonYakala.Height);
            buttonYakala.Left = rastgeleSayiUretici.Next(0,this.Width - buttonYakala.Width  );
        }
    }
}
