class Calculadora
{
    public static double Calcular(double num1, double num2, string op)
    {
        double resultado = double.NaN; 

        // Usar uma instrução switch para fazer uma operação matemática.
        switch (Console.ReadLine())
        {
            case "0": //Sair
                Console.WriteLine("Obrigado e até breve");
                break;
            case "1":
                Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                break;
            case "2":
                Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                break;
            case "3":
                Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                break;
            case "4":
                // inserir um divisor diferente de zero..
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                break;
            
            case "5": // Resto da Divisão
                int resto = RestoDivisao();
                Console.WriteLine($"Resultado: {resto}");
                break;
            
            case "6": // Potencialização
                double potencia = Potenciacao();
                Console.WriteLine($"Resultado: {potencia}");
                break;
            default:
                break;
        }
        return resultado;
    }
    
    static int RestoDivisao()
    {
        Console.WriteLine("Digite o primeiro valor: ");
        int valor1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        int valor2 = int.Parse(Console.ReadLine());

        return valor1 % valor2;
    }
    private static double Potenciacao()
    {
        Console.WriteLine("Digite a base: ");
        double baseNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o expoente: ");
        double expoente = double.Parse(Console.ReadLine());

        return Math.Pow(baseNum, expoente);
    }
}

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        
        Console.WriteLine("Calculadora em C#.\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {
            // Declara variáveis e define como vazio.
            
            string numInput1 = "";
            string numInput2 = "";
            double result = 0;

            //digitar o primeiro número.
            
            Console.Write("Digite um número e pressione Enter:");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("Esta não é uma entrada válida. Por favor insira um valor inteiro: ");
                numInput1 = Console.ReadLine();
            }

            //digitar o segundo número
            Console.Write("Digite um número e pressione Enter: ");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("Esta não é uma entrada válida. Por favor insira um valor inteiro:");
                numInput2 = Console.ReadLine();
            }
            
            Console.WriteLine("Escolha uma operação na lista a seguir:");
            Console.WriteLine("\t0 - Sair");
            Console.WriteLine("\t1 - Somar");
            Console.WriteLine("\t2 - Subtrair");
            Console.WriteLine("\t3 - Multiplicar");
            Console.WriteLine("\t4 - Dividir");
            Console.WriteLine("\t5 - Resto da Divisão");
            Console.WriteLine("\t6 - Potenciação");

            string op = Console.ReadLine();

            try
            {
                result = Calculadora.Calcular(cleanNum1, cleanNum2, op);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("Não é possível dividir por 0.\n");
                }
                else Console.WriteLine("Resultado: {0:0.##}\n", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ah, não! Ocorreu uma exceção ao tentar fazer as contas.\n - Detalhes: " + e.Message);
            }

            Console.WriteLine("------------------------\n");

           
            Console.Write("Pressione 's' e Enter para fechar o aplicativo ou pressione qualquer outra tecla e Enter para continuar: ");
            if (Console.ReadLine() == "s") endApp = true;

            Console.WriteLine("\n");
        }
        return;
    }
}
