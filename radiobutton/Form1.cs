namespace radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double num1 = 0.0;
            double num2 = 0.0;
            double res = 0.0;

           num1= System.Convert.ToDouble(txt1.Text);
           num2 =  System.Convert.ToDouble(txt2.Text);

            if (num1 == 0)
            {
                MessageBox.Show("Ingrese un primer numero");
            }

            if (num2  == 0)
            {
                MessageBox.Show("Ingrese un segundo numero");
            }



            if (rbsuma.Checked == true)
            {   
                res = num1 + num2;
                lblresultado.Text = "El resultado es :" + System.Convert.ToString(res);
            }

            if (rbresta.Checked == true)
            {
                res = num1 - num2;
                lblresultado.Text = "El resultado es :" +  System.Convert.ToString(res);
            }

            if (rbmulti.Checked == true)
            {
                res = num1 * num2;
                lblresultado.Text = "El resultado es :" + System.Convert.ToString(res);
            }

            if (rbdiv.Checked == true)
            {
                res = num1 / num2;
                lblresultado.Text = "El resultado es :" + System.Convert.ToString(res);
            }
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2_HideSelectionChanged(object sender, EventArgs e)
        {

        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
    
    
}