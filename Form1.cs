namespace hesapmakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayi1;
        double sayi2;
        private void button4_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(txtsay�1.Text);

            sayi2 = double.Parse(txtsay�2.Text);

            double sonuc = sayi1 * sayi2;

            lblsonuc.Text = sonuc.ToString();
        }

        private void btnart�_Click(object sender, EventArgs e)
        {
           

            sayi1 =double.Parse (txtsay�1.Text);

            sayi2 =double.Parse(txtsay�2.Text);

            double sonuc = sayi1 + sayi2;

            lblsonuc.Text = sonuc.ToString();


        }

        private void btneksi_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(txtsay�1.Text);

            sayi2 = double.Parse(txtsay�2.Text);

            double sonuc = sayi1 - sayi2;

            lblsonuc.Text = sonuc.ToString();


        }

        private void btnb�l�_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(txtsay�1.Text);

            sayi2 = double.Parse(txtsay�2.Text);

            double sonuc = sayi1 / sayi2;

            lblsonuc.Text = sonuc.ToString();

        }

        private void txtsay�1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsay�2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblsonuc_Click(object sender, EventArgs e)
        {

        }
    }
}