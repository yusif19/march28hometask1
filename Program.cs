namespace march28hometask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 45, 24, 43, 52, 63, 74, 84 };
            Min(array);
            Area(2);
            Area(2, 3);
            Area(2, 3, 4);
            Area(2, 3, 4, 5);
        }
        public static void Min(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.Write("Array min element: ");
            Console.WriteLine(min);
        }
        public static void Area(double r)
        {
            int p = 3;
            Console.Write("Cevre sahesi: ");
            Console.WriteLine(p*r*r);
        }
        public static void Area(double a, double b)
        {
            Console.Write("Duzbucaqli sahesi: ");
            Console.WriteLine(a * b);
        }
        public static void Area(double a, double b, double c)
        {
            Console.Write("Duzbucaqli papalelopiped sahesi: ");
            Console.WriteLine(2 * (a * b + a * c + b * c));
        }
        public static void Area(double a, double b, double c, double r)
        {
            double p = (a + b + c) / 2;
            Console.Write("Ucbucaq daxiline cekilmis cevre sahesi: ");
            Console.WriteLine(p * r);
        }
        //arqument kimi kesr ededleride verile bildiyinden butun parametlerin tipine double vermisem





    }
}