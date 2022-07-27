namespace Methotst
{
    internal static class ProgramHelpers
    {


        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add3(int number1, int number2)
        {
            var result = number1 + number2;
            return result;

        }
        static int Add3(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;

        }
    }
}