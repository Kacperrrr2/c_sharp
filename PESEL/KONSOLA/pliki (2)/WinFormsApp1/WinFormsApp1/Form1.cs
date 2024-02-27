namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSprawdzCene_Click(object sender, EventArgs e)
        {
            if (radioButtonPocztowka.Checked)
            {
                pictureBoxRodzajPaczki.Image = Properties.Resources.pocztowka;
                labelCena.Text = "Cena: 1 z³";
            }

            if (radioButtonList.Checked)
            {
                pictureBoxRodzajPaczki.Image = Properties.Resources.list;
                labelCena.Text = "Cena 1,5 z³";

            }
            if (radioButtonPaczka.Checked)
            {
                pictureBoxRodzajPaczki.Image=Properties.Resources.paczka;

                labelCena.Text = "Cena10 z³";
            }

        }

        private void buttonZatwierdzanie_Click(object sender, EventArgs e)
        {
            string cos = textBoxKodPocztowy.Text;
            if(cos.Length !=5)
            {
                MessageBox.Show("Nieprawid³owa liczba cyfr w kodzie pocztowym");
            }
            else if(Int32.TryParse(cos,out _)==false)
            {
                MessageBox.Show("Kod pocztowy powinien siê sk³adaæ z samych cyfr");
            }
            else
            {
                MessageBox.Show("Dane zostaly wprowadzone prawid³owo");
            }
        }
    }
}
