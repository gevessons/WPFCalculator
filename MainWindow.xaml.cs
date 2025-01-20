using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public enum OperacaoSelecionada
    {
        Soma,
        Subtracao,
        Multiplicacao,
        Divisao
    }

    public class Calcular
    {
        public static double Soma(double n1, double n2)
        {
            return n1 + n2;
        }
        public static double Subtrair(double n1, double n2)
        {
            return n1 - n2;
        }
        public static double Multipicacao(double n1, double n2)
        {
            return n1 * n2;
        }
        public static double Divisao(double n1, double n2)
        {
            return n1 / n2;
        }
    }

    public partial class MainWindow : Window
    {
        double numeroAnterior, resultado;
        OperacaoSelecionada operacaoSelecionada;

        public MainWindow()
        {
            InitializeComponent();
            acBoton.Click += AcBoton_Click;
            negativoBoton.Click += NegativoBoton_Click;
            porcentagemBoton.Click += PorcentagemBoton_Click;
            igualBoton.Click += IgualBoton_Click;
            pontoBoton.Click += PontoBoton_Click;
            this.TextInput += MainWindow_TextInput; ;
        }

        private void MainWindow_TextInput(object sender, TextCompositionEventArgs e)
        {
            if (int.TryParse(e.Text, out int number))
            {
                SetResultadoLabel(number);
            }
            else if (e.Text == "+")
            {
                Operacoes(maisBoton);
            }
            else if (e.Text == "-")
            {
                Operacoes(menosBoton);
            }
            else if (e.Text == "*")
            {
                Operacoes(multiplicacaoBoton);
            }
            else if (e.Text == "/")
            {
                Operacoes(divisionBoton);
            }else if (e.Text == ",")
            {
                Ponto();
            }
            else if (e.Text == "=")
            {
                Resultado();
            }
        }

        private void PontoBoton_Click(object sender, RoutedEventArgs e)
        {
            Ponto();
        }

        private void Ponto()
        {

            if (!resultadoLabel.ToString().Contains(","))
            {
                resultadoLabel.Content = $"{resultadoLabel.Content},";
            }
        }

        private void IgualBoton_Click(object sender, RoutedEventArgs e)
        {
            Resultado();
        }

        private void Resultado()
        {
            double numeroNovo;
            if (double.TryParse(resultadoLabel.Content.ToString(), out numeroNovo))
            {
                switch (operacaoSelecionada)
                {
                    case OperacaoSelecionada.Soma:
                        resultado = Calcular.Soma(numeroAnterior, numeroNovo);
                        break;
                    case OperacaoSelecionada.Subtracao:
                        resultado = Calcular.Subtrair(numeroAnterior, numeroNovo);
                        break;
                    case OperacaoSelecionada.Multiplicacao:
                        resultado = Calcular.Multipicacao(numeroAnterior, numeroNovo);
                        break;
                    case OperacaoSelecionada.Divisao:
                        resultado = Calcular.Divisao(numeroAnterior, numeroNovo);
                        break;
                }
                resultadoLabel.Content = $"{resultado}";
            }
        }

        private void OperacaoBoton_Click(object sender, RoutedEventArgs e)
        {
            Operacoes(sender as Button);
        }

        private void Operacoes(Button operador)
        {
            //Com isso retorno o valor exibido para 0 e salvo meu valor anterior na variável numeroAnterior
            if (double.TryParse(resultadoLabel.Content.ToString(), out numeroAnterior))
            {
                resultadoLabel.Content = "0";
            }
            //Selecionar a operação de entrada
            operacaoSelecionada = operador == multiplicacaoBoton? OperacaoSelecionada.Multiplicacao : operacaoSelecionada;
            operacaoSelecionada = operador == divisionBoton ? OperacaoSelecionada.Divisao : operacaoSelecionada;
            operacaoSelecionada = operador == menosBoton ? OperacaoSelecionada.Subtracao : operacaoSelecionada;
            operacaoSelecionada = operador == maisBoton ? OperacaoSelecionada.Soma : operacaoSelecionada;
        }

        private void NumeroBoton_Click(object sender, RoutedEventArgs e)
        {
            SetResultadoLabel(int.Parse((sender as Button).Content.ToString()));
        }

        private void SetResultadoLabel(int numero)
        {
            resultadoLabel.Content = resultadoLabel.Content.ToString() == "0" ? $"{numero}" : $"{resultadoLabel.Content}{numero}";
        }

        private void PorcentagemBoton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultadoLabel.Content.ToString(), out numeroAnterior))
            {
                numeroAnterior = numeroAnterior / 100;
                resultadoLabel.Content = $"{numeroAnterior}";
            }
        }

        private void NegativoBoton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultadoLabel.Content.ToString(), out numeroAnterior) && numeroAnterior != 0)
            {
                numeroAnterior = numeroAnterior * -1;
                resultadoLabel.Content = $"{numeroAnterior}";
            }
        }

        private void AcBoton_Click(object sender, RoutedEventArgs e)
        {
            resultadoLabel.Content = "0";
        }
    }
}