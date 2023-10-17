namespace Calculadora
{
    public partial class Form1 : Form
    {
        //Declaracion de variables 
        double num1, num2;
        char operador;
        public Form1()
        {
            InitializeComponent();
        }
        //Funcion para limpiar pantalla
        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtbresultado.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = '\0';



        }
        //Funcion para mostrar numeros 
        private void AgregarNumero(object sender, EventArgs e)
        {
            if (txtbresultado.Text.Equals("0"))

                txtbresultado.Text = string.Empty;
            //Cast de tipo evento a button
            var boton = ((Button)sender);
            txtbresultado.Text += boton.Text;
        }


        //Funcion para elegir signo
        private void Signo_Selector(object sender, EventArgs e)

        {
            num1 = Convert.ToDouble(txtbresultado.Text);
            var signo = (Button)sender;
            operador = Convert.ToChar(signo.Text);
            txtbresultado.Text = "0";
        }

        //Funcion de Calculos 
        private void resolver(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtbresultado.Text);

            if (operador == '+')
            {
                txtbresultado.Text = (num1 + num2).ToString();
                num1 = Convert.ToDouble(txtbresultado.Text);

            }
            else if (operador == '-')
            {
                txtbresultado.Text = (num1 - num2).ToString();
                num1 = Convert.ToDouble(txtbresultado.Text);
            }
            else if (operador == 'x')
            {
                txtbresultado.Text = (num1 * num2).ToString();
                num1 = Convert.ToDouble(txtbresultado.Text);
            }
            else if (operador == '/')
            {
                if (txtbresultado.Text != "0")
                {
                    txtbresultado.Text = (num1 / num2).ToString();
                    num1 = Convert.ToDouble(txtbresultado.Text);


                    //Advertencia de divisor por cero                
                }
                else
                {
                    MessageBox.Show("No se puede dividir entre cero");

                }




            }

            //By Otoniel 
        }


    }
}