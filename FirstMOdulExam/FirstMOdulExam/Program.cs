namespace FirstMOdulExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        //1__
        public static int EvenNumbers(List<int> numbers)
        {
            var evens = 0;
            List<int> list = new List<int>();
            foreach (int i in list)
            {
                if (i % 2 == 0)
                {
                    evens++;
                }
            }
            return evens;
        }

        // 2__
        public static bool ElementIsBiggerThanFive(List<string> texts)
        {
            foreach (string text in texts)
            {
                if (text.Length > 5)
                {
                    return true;
                }
            }
            return false;
        }

        // 3__
        public static string FirstThreeWords(string text)
        {
            text = text.Substring(0, 3);
            return text;
        }

        // 4__
        public static bool FirstWordIsPDP(string word)
        {
            var text = word.Substring(0, 3);
            if (text == "PDP")
            {
                return true;
            }
            return false;
        }
    }
}
