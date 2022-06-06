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





            double num1 = 0;
            double num2 = 0;
            double res = 0;  



            

            if (txt1.Text == "" )
            {
                MessageBox.Show("Ingrese primer numero ahora","Advertencia",MessageBoxButtons.OK ,MessageBoxIcon.Exclamation);
                txt1.Focus();
               

            }
             else if (txt2.Text == "")
            {
                MessageBox.Show("Ingrese segundo numero ahora", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt2.Focus();
                
            }

            else
            {
                num1 = System.Convert.ToDouble(txt1.Text);
                num2 = System.Convert.ToDouble(txt2.Text);
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

            if (rbsuma.Checked == false && rbresta.Checked == false && rbdiv.Checked == false && rbmulti.Checked == false)
            {
                MessageBox.Show("Elija una operacion", "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        
        
        
        
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255) ||e.KeyChar == 46)
            {
                MessageBox.Show("Ingrese solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            
            
            if ((e.KeyChar >= 32 && e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255) || e.KeyChar == 46)
            {
                MessageBox.Show("Ingrese solo numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void rbsuma_CheckedChanged(object sender, EventArgs e)
        {
            string suma; 

            suma = "Eligio suma";

            lbl2.Text = suma;
        }

        private void rbresta_CheckedChanged(object sender, EventArgs e)
        {
            string resta; 

            resta = "Eligio resta";

            lbl2.Text = resta;
        }

        private void rbmulti_CheckedChanged(object sender, EventArgs e)
        {
            string multiplicacion; 

            multiplicacion = "Eligio multiplicacion";

            lbl2.Text = multiplicacion;
        }

        private void rbdiv_CheckedChanged(object sender, EventArgs e)
        {
            string division; 

            division = "Eligio division";

            lbl2.Text = division;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            var eleccion = DialogResult;
                                          
            
                eleccion = MessageBox.Show("¿Desea salir?" , "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

          
            if (eleccion == DialogResult.Yes)
            {
                Close();
            }
        }
    }
    
    
}