namespace SlotMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timerZamanlayici_Tick(object sender, EventArgs e)
        {
            //her 10ms dolduğunda ne yapacak?
            //üç farklı rastgele sayı üretecek.
            //bu sayılar 0-7 arasında olacak.
            //her karta bir sayı eklenecek
            Random rastgele = new Random();
            int sayi1 = rastgele.Next(0, 8);
            int sayi2 = rastgele.Next(0, 8);
            int sayi3 = rastgele.Next(0, 8);

            labelKart1.Text = Convert.ToString(sayi1);
            labelKart2.Text = sayi2.ToString();
            labelKart3.Text = sayi3.ToString();



        }

        private void buttonBaslat_Click(object sender, EventArgs e)
        {
            //timerZamanlayıcı'yı başlat:
            timerZamanlayici.Start();
        }

        private void buttonDurdur_Click(object sender, EventArgs e)
        {
            //timerZamanlayıcı'yı durdur:
            timerZamanlayici.Stop();

            //Üç kart da aynıysa "KAZANDIN"
            //Sadece ikisi aynıysa "bir bedava tur"
            //Üçü farklıysa kaybettin.

            if (labelKart1.Text == labelKart2.Text && labelKart1.Text == labelKart3.Text)
            {
                MessageBox.Show("Kazandın!");
            }
            else if (labelKart1.Text == labelKart2.Text || labelKart1.Text == labelKart3.Text || labelKart2.Text == labelKart3.Text)
            {
                MessageBox.Show("Bedava bir şans daha!");
            }
            else
            {
                MessageBox.Show("kaybettiniz");
            }
        }
    }
}
