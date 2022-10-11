namespace Oefening3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            if (bx_eur.Text != "")
            {
                double EurToUsd = double.Parse(bx_eur.Text) * 0.98;
                bx_usd.Text = EurToUsd.ToString();

            }

            else if (bx_franken.Text != "")
            {
                double FrankToUsd = double.Parse(bx_franken.Text) * 1.01;
                bx_usd.Text = FrankToUsd.ToString();


            }

            else if (bx_pound.Text != "")
            {
                double PoundToUsd = double.Parse(bx_pound.Text) * 1.11;
                bx_usd.Text = PoundToUsd.ToString();

            }


            else if (bx_rupees.Text != "")
            {
                double RupeesToUsd = double.Parse(bx_rupees.Text) * 0.01;
                bx_usd.Text = RupeesToUsd.ToString();

            }


            else if (bx_yen.Text != "")
            {
                double ytd = double.Parse(bx_yen.Text) * 0.007;
                bx_usd.Text = ytd.ToString();

            }



            if (bx_usd.Text != "")
            {

                US_Dollars dollar = new US_Dollars(double.Parse(bx_usd.Text));
                US_Dollars euro = new Euro(double.Parse(bx_usd.Text));
                US_Dollars franken = new Frank(double.Parse(bx_usd.Text));
                US_Dollars pounds = new Pound(double.Parse(bx_usd.Text));
                US_Dollars yen = new Yen(double.Parse(bx_usd.Text));
                US_Dollars rupees = new Rupees(double.Parse(bx_usd.Text));

                bx_usd.Text = dollar.ToString();
                bx_eur.Text = euro.ToString();
                bx_franken.Text = franken.ToString();
                bx_pound.Text = pounds.ToString();
                bx_yen.Text = yen.ToString();
                bx_rupees.Text = rupees.ToString();

            }
        }
    }
}