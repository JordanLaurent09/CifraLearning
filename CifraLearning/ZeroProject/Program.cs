using System.Text;

namespace ZeroProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _line;
            StringBuilder _valueStringBuilder = new StringBuilder();
            float _value = 0;
            // ввод
            Console.WriteLine("Enter the line");
            _line = Console.ReadLine();

            ParseLine(true);

            // обработка
            for (int i = 0; i < _line.Length; i++)
            {
                char letter = _line[i];
                if (char.IsDigit(letter))
                {
                    _valueStringBuilder.Append(letter);
                } else if (letter == '.' || letter == ',') {
                    _valueStringBuilder.Append(letter);
                }
            }

            if (_valueStringBuilder.Length == 0)
            {
                Console.WriteLine("The number has not found");
            }
            else
            {
                _value = float.Parse(_valueStringBuilder.ToString());
            }

            // вывод

            Console.WriteLine($"Number is {_value}");


            void ParseLine(bool exitOnFirstLetter)
            {
                for (int i = 0; i < _line.Length; i++)
                {
                    char letter = _line[i];
                    if (char.IsDigit(letter))
                    {
                        _valueStringBuilder.Append(letter);
                        continue;
                    }
                    else if (letter == '.' || letter == ',')
                    {
                        _valueStringBuilder.Append(',');
                        continue;
                    }
                }
            }
        }
    }
}