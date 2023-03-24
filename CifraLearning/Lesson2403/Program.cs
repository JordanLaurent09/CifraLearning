namespace Lesson2403
{
    
        
    class Program
    {
        static void Main(string[] args)
        {

            //Вариант без методов

            string _userValue;
            float _value;
            string valueType = "";
            //0 - не определено
            //1 - number
            //2 - line



            while (true)
            {

                _userValue = ReadValue();



                if (_userValue == "exit")
                {
                    break;
                }

                valueType = GetValueType();

                switch (valueType)
                {
                    case "number":
                        PrintNumberInfo();
                        break;
                    case "string":
                        PrintStringInfo();
                        break;
                }

            
                
            }
            string ReadValue()
            {
                Console.Write("Введите значение: ");
                return Console.ReadLine().Replace(".", ",");
            }

            string GetValueType()
            {
                bool isNumber = float.TryParse(_userValue, out _value);

                return isNumber ? "nimber" : "string";


            }

            void PrintNumberInfo()
            {
                if (_value % 1 == 0)
                {
                    Console.WriteLine($"{_value} -  Целое число\n");
                }
                else
                {
                    Console.WriteLine($"{_value} -  Вещественное число\n");
                }
            }

            void PrintStringInfo()
            {
                char[] separators = new char[] { ' ', ',', '.' };
                string[] words = _userValue.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                int wordsCount = words.Length;

                if (wordsCount == 1)
                {
                    Console.Write($"{_userValue} -  Слово.\t");
                    Console.WriteLine($"Длина слова =  {_userValue.Length}\n");
                }
                else
                {
                    Console.Write($"{_userValue} -  Предложение.\t");
                    Console.WriteLine($"Количество слов =  {wordsCount}\n");
                }
            }
        }
    }

}
   