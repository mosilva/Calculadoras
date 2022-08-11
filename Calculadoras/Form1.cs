namespace Calculadoras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double.TryParse(textBoxPeso.Text, out double peso);
            double.TryParse(textBoxAltura.Text, out double altura);

            altura = altura / 100;

            var (descricaoImc,resultadoImc) = CalculadoraImc(peso, altura);

            lblResultado.Text = $"Descrição do IMC: {descricaoImc}\nSeu IMC:{resultadoImc:F2}";

        }

        private (string, double) CalculadoraImc(double peso, double altura)
        {
            double imc = (peso / Math.Pow(altura, 2));

            var resultado = imc switch
            {
                < 20 => "Abaixo do peso",
                >= 20 and < 25 => "Peso normal",
                >= 25 and < 30 => "Sobre peso",
                >= 30 and < 40 => "Obeso",
                _ => "Obeso mórbido"
            };

            return (resultado, imc);

        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            textBoxPeso.Text = String.Empty;
            textBoxAltura.Text = String.Empty;
            lblResultado.Text = String.Empty;

            textBoxPeso.Focus();
        }

    }
}