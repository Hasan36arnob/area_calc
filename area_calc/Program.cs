namespace Area_Calculator
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string answer;
            float result;
            Console.WriteLine("What shappe would you like to find area of? Please enter 'r' for rectangle and any other key for circle. ");
            answer = Console.ReadLine();
            if (answer == "r")
            {
                Console.WriteLine("Please enter the height of the rectangle");
                float height = float.Parse(Console.ReadLine());
                Console.WriteLine("please enter the width of the rectangle");
                float width = float.Parse(Console.ReadLine());
                result = height * width;
                Console.WriteLine(" Area of ractangle is :" + result);

            }
            else
            {
                Console.WriteLine("Please enter the radius of the circle");
                float radius = float.Parse(Console.ReadLine());
                Console.WriteLine("Area of the circle is :" + 3.1416 * radius * radius);
            }
        }
    }
}