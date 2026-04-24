namespace switchCase2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxRenkler_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //comboboxxRenkler içinden seçilen elemanın değerine göre butonun arkaplan rengini değiştir

            switch (comboBoxRenkler.SelectedItem.ToString())
            {
                case "Pembe":
                    buttonRenk.BackColor = Color.Pink;
                    break;
                case "Yeşil":
                    buttonRenk.BackColor = Color.Green;
                    break;
                case "Mor":
                    buttonRenk.BackColor = Color.Purple;
                    break;
                default:
                    break;
            }



        }

        private void comboBoxIskambil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (comboBoxIskambil.SelectedItem.ToString())
            {
                case "Sinek":
                case "Maça":
                    buttonKartRengi.BackColor = Color.Black;
                    break;

                case "Karo":
                case "Kupa":
                    buttonKartRengi.BackColor = Color.Red;
                    break;

                default:
                    break;
            }
        }

        private void buttonGunler_Click(object sender, EventArgs e)
        {
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    MessageBox.Show("hafta sonu");
                    break;
                //case DayOfWeek.Monday:
                //    break;
                //case DayOfWeek.Tuesday:
                //    break;
                //case DayOfWeek.Wednesday:
                //    break;
                //case DayOfWeek.Thursday:
                //    break;
                //case DayOfWeek.Friday:
                //    break;

                default:
                    MessageBox.Show("Hafta içi...");
                    break;
            }
        }
    }
}
