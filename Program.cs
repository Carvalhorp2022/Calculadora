class Calculadora
{
    public static double Calcular(double num1, double num2, string op)
    {
        double resultado = double.NaN; 

        // Usar uma instrução switch para fazer uma operação matemática.
        switch (op)
        {
            case "1":
                resultado = num1 + num2;
                break;
            case "2":
                resultado = num1 - num2;
                break;
            case "3":
                resultado = num1 * num2;
                break;
            case "4":
                // inserir um divisor diferente de zero..
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                break;
            
            default:
                break;
        }
        return resultado;
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
            Console.WriteLine("\t1 - Somar");
            Console.WriteLine("\t2 - Subtrair");
            Console.WriteLine("\t3 - Multiplicar");
            Console.WriteLine("\t4 - Dividir");
            Console.Write("Sua Opção é ? ");

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

           
            Console.Write("Pressione '0' e Enter para fechar o aplicativo ou pressione qualquer outra tecla e Enter para continuar: ");
            if (Console.ReadLine() == "0") endApp = true;

            Console.WriteLine("\n");
        }
        return;
    }
}
