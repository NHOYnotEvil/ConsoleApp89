using System.Linq.Expressions;

namespace ConsoleApp89
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string symbol;
            int bracketExpression = 0;
            int depthExpression = 0;

            Console.Write("Введите скобочное выражение:");
            symbol = Console.ReadLine();

            for(int i = 0; i < symbol.Length; i++)
            {
                if (symbol[i] == '(')
                {
                    bracketExpression++;
                    depthExpression++;
                }
                else if (symbol[i] == ')')
                {
                    bracketExpression--;
                }
            }

            if (bracketExpression == 0)
            {
                Console.WriteLine("Скобочное выражение - верное.");
            }
            else
            {
                Console.WriteLine("Скобочное выражение - не верное.");
            }

            Console.WriteLine("Максимальная глубина скобочного выражения - " + depthExpression);
        }
    }
}