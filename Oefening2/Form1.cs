

namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Koe koe = new Koe(300);
            
            Slang slang = new Slang(12);
            
            Varken varken = new Varken(130);


            if (Koe.Checked)
            {
                MessageBox.Show(koe.ToString());
            }
            if (Slang.Checked)
            {
                MessageBox.Show(slang.ToString());
            }
            if (Varken.Checked)
            {
                MessageBox.Show(varken.ToString());
            }
        }
    }
}