using System.Globalization;

namespace Exercicio_3;
internal class Program
{
    static void Main()
    {
        //Programa que solicita ao usuario a exebição da data atual em diferentes formatos.
        Console.WriteLine("Escolha um formato de exibição de data: ");
        Console.WriteLine("1- (formato completo) dia da semana, dia, mês, ano , hora, minutos e segundos");
        Console.WriteLine("2- (Apenas a data do formato) exemplo: '26/10/2024' ");
        Console.WriteLine("3- (O formato de 24 horas) horas, minutos e segundos");
        Console.WriteLine("4- (usando a data do ano com o mês por extenso) exemplo: 'dia:9, mês: outubro, ano:2024");
        // capturando a opção que o usuario digitar.
        var opcao = Console.ReadLine();
        //Chamando a função estatica para a Main:
        Program.ExibirOpcaoFormato(opcao);
    }
    //recebe opção e exibe a data e a hora com base no formato que o usuário escolheu.
    static void ExibirOpcaoFormato(string? opcao)
    {   // recebe a data e o horario atual do sistema usando DateTime.Now.
        var dataAtual = DateTime.Now;
        // usando switch case para caso o usuário escolha uma das opções a seguir: 
        switch (opcao)
        { // caso de formato completo:
            case "1":  // pegando a configurção brasileira de data
                //exemplo: segunda-feira, 01 de janeiro de 2024, 23hrs 12min e 50seg.
                Console.WriteLine(dataAtual.ToString($"dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss", new CultureInfo("pt-BR")));
                break;
                // Apenas a data do horário padrão (12/08/2014)
            case "2":
                Console.WriteLine(dataAtual.ToString($"dd/MM/yyyy"));
                break;
                // formato de 24 horas
            case "3":
                Console.WriteLine(dataAtual.ToString($"HH:mm:ss"));
                break;
                //data com o mês por extenso, EXEMPLO: 8 de janeiro de 2024
            case "4":
                Console.WriteLine(dataAtual.ToString($"dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
                break;
                //caso o usuário não tenha feito uma escolha valida:
                default:
                Console.WriteLine("Escolha invalida!");
                break;
        }
    }
}
