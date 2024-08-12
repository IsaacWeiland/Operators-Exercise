namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 33;
            int b = 3;
            int sum = a + b;
            int dif = a - b;
            int pro = a * b;
            int quo = a / b;
            int rem = a % b;
            Console.WriteLine($"{a}+{b} is {sum}.");
            Console.WriteLine($"{a}-{b} is {dif}.");
            Console.WriteLine($"{a}*{b} is {pro}.");
            Console.WriteLine($"{a}/{b} is {quo} with the remainder {rem}.");
            Console.WriteLine("Please enter the radius of your circle.");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of your circle radius is {AreaOfCircle(radius)}.");
            int i = 3;//First done
            int j = 4;//Last done
            int k = ++i * j++;//(3+1)*4) the "plus one" on j goes unused because it becomes k.
            Console.WriteLine($"k is {k}, and {j} is j.");//so it outputs 16
        }

        public static double AreaOfCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        
    }
}
