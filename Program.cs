namespace Equations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equation equation1 = new Equation(2, 5, 2);
            Equation equation2 = new Equation(1, 2, 3);
            Console.WriteLine("Коэффициенты 1-го уравнения: " + equation1.ToString());
            equation1.Result();
            ++equation1;
            Console.WriteLine("Увеличение коэффициентов на 1: " + equation1.ToString());
            --equation1;
            Console.WriteLine("Уменьшение коэффициентов на 1: " + equation1.ToString());
            Console.WriteLine("Дискриминант уравнения равен " + (double)equation1);
            Console.WriteLine("Корни уравнения существуют: " + (bool)equation1);
            Console.WriteLine("Коэффициенты 2-го уравнения: " + equation2.ToString());
            Console.WriteLine("Уравнения равны: " + (equation1 == equation2));
            Console.WriteLine("Уравнения не равны: " + (equation1 != equation2));
        }
    }
}
