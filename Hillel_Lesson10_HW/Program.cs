namespace Hillel_Lesson10_HW
{
    class Programm
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            
            int[] numbers = new int[12];

            int sumArrayNumbers;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 21);
                Console.WriteLine("{0}", numbers[i]);

            }


            CountArrayNumbers(numbers);

            Thread.Sleep(1000);
            Console.WriteLine("Trololololo");
            
            
            Console.ReadKey();

        }
        

        public static async void CountArrayNumbers(int[] numbers)
        {

            int sumArrayNumbers = 0;
            
            bool condidion = await CheckCondition(numbers);


            if (condidion)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    sumArrayNumbers += numbers[i];
                }
            }


            Console.WriteLine("Cheking Condition..)");
            Thread.Sleep(2000);
            Console.WriteLine("2 sec...");

            Thread.Sleep(2000);

            Console.WriteLine(sumArrayNumbers);
        }
        
        
        public static async Task<bool> CheckCondition(int[] numbers)
        {
            bool condition = true;

            return await Task.Run(() =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < 1)
                    {
                        condition = false;
                    }
                }
                return condition;
            });
        }

    }
}