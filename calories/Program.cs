using System.Security.Cryptography.X509Certificates;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        double countedCalories;

        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        Console.WriteLine("Добро пожаловать в калькулятор КБЖУ!\n");
        Console.WriteLine("Напишите ваш пол: муж / жен");

        string gender = Console.ReadLine();
        Console.WriteLine();

        double CountCalories (double weight, double height, int age, int caloriesConstanta)
        {
            return 10 * weight + 6.25 * height + 5 * age + caloriesConstanta;
        }

        if (gender == "муж" || gender == "жен")
        {
           Console.WriteLine("Введите ваш вес:");
           double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

			Console.WriteLine("Введите ваш рост:");
			double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

			Console.WriteLine("Введите ваш возраст:\n");
			int age = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine();

            int caloriesConstanta = gender == "муж" 
                ? 5 
                : -161;

            countedCalories = CountCalories(weight, height, age, caloriesConstanta);

            Console.WriteLine("Напишите как часто в течение недели вы занимаетесь спортом, варианты ответов: не занимаюсь / три раза / ежедневно");
            string sportExcercies = Console.ReadLine();

			switch (sportExcercies)
            {
                case "не занимаюсь":
                    Console.WriteLine("Вам необходимо набирать в день " + countedCalories * 1.2 + " каллорий");
                    break;

                case "три раза":
					Console.WriteLine("Вам необходимо набирать в день " + countedCalories * 1.375 + " каллорий");
                    break;

                case "ежедневно":
					Console.WriteLine("Вам необходимо набирать в день " + countedCalories * 1.6375 + " каллорий");
					break;

                default:
                    Console.WriteLine("Вы ввели неправильный параметр, начните заново!");
                    break;
                    Environment.Exit(0);
			}
		} 
        else
        {
            Console.WriteLine("Вы ввели неправильный пол, начните заново!");
            Environment.Exit(0);
        }
    }
}