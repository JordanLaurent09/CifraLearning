using System.Text;

namespace ZeroProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _line;
            StringBuilder _valueStringBuilder = new StringBuilder();

            // ввод
            Console.WriteLine("Enter the line");
            _line = Console.ReadLine();

            // обработка
            for (int i = 0; i < _line.Length; i++)
            {
                char letter = _line[i];
                if (char.IsDigit(letter))
                {
                    _valueStringBuilder.Append(letter);
                }
            }

            Console.WriteLine(_valueStringBuilder.ToString());  
            // вывод
        }
    }
}