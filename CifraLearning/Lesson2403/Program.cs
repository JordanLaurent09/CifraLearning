namespace Lesson2403
{
    
        
    class Program
    {

        enum Types
        {
            None,
            StringType,
            NumberType,
            MixType
        }

        static void Main(string[] args)
        {

            string _userValue;
            float _value;
            Types valueType = Types.None;
            //const string NumberType = "number";
            //const string StringType = "string";

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
                    case Types.NumberType:
                        PrintNumberInfo();
                        break;
                    case Types.StringType:
                        PrintStringInfo();
                        break;
                    
                }

            
                
            }
            string ReadValue()
            {
                Console.Write("Введите значение: ");
                return Console.ReadLine().Replace(".", ",");
            }

            Types GetValueType()
            {
                bool isNumber = float.TryParse(_userValue, out _value);

                return isNumber ? Types.NumberType : Types.StringType;


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
   