namespace Practica_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int EDAD;

            EDAD = int.Parse(edad.Text);

            if (EDAD < 12)
            {
                MessageBox.Show("Es un niño");
            }

            else
            {
                if (EDAD < 18)
                {
                    MessageBox.Show("Es un adolescente");
                }

                else
                {
                    if (EDAD < 60)
                    {
                        MessageBox.Show("Es un adulto");
                    }

                    else
                    {
                        MessageBox.Show("Es un adulto mayor");
                    }
                }
            }
        }
    }
}