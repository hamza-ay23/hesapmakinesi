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
            sayi1 = double.Parse(txtsayý1.Text);

            sayi2 = double.Parse(txtsayý2.Text);

            double sonuc = sayi1 * sayi2;

            lblsonuc.Text = sonuc.ToString();
        }

        private void btnartý_Click(object sender, EventArgs e)
        {
           

            sayi1 =double.Parse (txtsayý1.Text);

            sayi2 =double.Parse(txtsayý2.Text);

            double sonuc = sayi1 + sayi2;

            lblsonuc.Text = sonuc.ToString();


        }

        private void btneksi_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(txtsayý1.Text);

            sayi2 = double.Parse(txtsayý2.Text);

            double sonuc = sayi1 - sayi2;

            lblsonuc.Text = sonuc.ToString();


        }

        private void btnbölü_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(txtsayý1.Text);

            sayi2 = double.Parse(txtsayý2.Text);

            double sonuc = sayi1 / sayi2;

            lblsonuc.Text = sonuc.ToString();

        }

        private void txtsayý1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsayý2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblsonuc_Click(object sender, EventArgs e)
        {

        }
    }
}