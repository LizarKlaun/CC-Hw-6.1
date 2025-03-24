namespace C__Hw_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 3, 7, 1, 9, 4, 5, 8, 2 };
            MyArray arr = new MyArray(data);

            Console.WriteLine("\nПарні числа:");
            arr.ShowEven();

            Console.WriteLine("\nНепарні числа:");
            arr.ShowOdd();
        }

        interface IOutput2
        {
            void ShowEven();
            void ShowOdd();
        }

        class MyArray : IOutput2
        {
            private int[] numbers;

            public MyArray(int[] arr)
            {
                numbers = arr;
            }

            public void ShowEven()
            {
                foreach (int num in numbers)
                {
                    if (num % 2 == 0)
                        Console.Write(num + " ");
                }
                Console.WriteLine();
            }

            public void ShowOdd()
            {
                foreach (int num in numbers)
                {
                    if (num % 2 != 0)
                        Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}