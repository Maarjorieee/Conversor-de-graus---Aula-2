namespace Conversos_de_graus
{
    public partial class ConversorJanela : Form
    {
        public ConversorJanela()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (this.cboEscolherConvers�o.SelectedIndex == 0)
            {
                float celsius = 0;
                if (float.TryParse(txtTemperaturaOriginal.Text, out celsius))
                {
                    float fahrenheit = (float)(celsius * 1.8 + 32);
                    txtTemperaturaConvertida.Text = $"{fahrenheit:N2}";
                }
                else
                {
                    MessageBox.Show("Valor Inv�lido!");
                    txtTemperaturaConvertida.Text = "";
                }
            }
            else if (this.cboEscolherConvers�o.SelectedIndex == 1)
            {

                {
                    float fahrenheit = 0;
                    if (float.TryParse(txtTemperaturaOriginal.Text, out fahrenheit))
                    {
                        float celsius = (float)((fahrenheit - 32) / 1.8);
                        txtTemperaturaConvertida.Text = $"{celsius:N2}";
                    }

                    else
                    {
                        MessageBox.Show("Valor Inv�lido!");
                        txtTemperaturaConvertida.Text = "";
                    }

                }

            }

            else
            {
                MessageBox.Show("Selecione o tipo de convers�o!");
            }

                }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTemperaturaConvertida.Text = "";
            txtTemperaturaOriginal.Text = "";

        }
    }


        }
    
