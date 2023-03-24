using MetroFramework.Forms;

namespace CalcPeso
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Verificar se os valores inseridos nas TextBoxes são válidos
            double comprimento, largura, espessura;

            if (!double.TryParse(txbox1.Text, out comprimento) || !double.TryParse(txbox2.Text, out largura) || !double.TryParse(txbox3.Text, out espessura))
            {
                MessageBox.Show("Insira valores numéricos válidos em todas as caixas de texto.");
                return;
            }

            // Calcular o peso em Kg
            double pesoEmKg = (comprimento * largura * espessura) / 6000;

            // Exibir o resultado na TextBox de resultado
            txtResultado.Text = pesoEmKg.ToString("F2") + " Kg";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Exibir uma caixa de diálogo de confirmação antes de fechar o formulário
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Fechar o formulário
                Close();
            }
        }

    }
}
