using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace IT_Veterans_Home_Work_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            volumeOfShapes();
            Console.WriteLine("\t -------------------------------------");
            volumeAndAreaOfShapes();

        }
        static void ErrorColor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Error: choise or volume not correct");
            Console.ResetColor();
        }
        static void volumeOfShapes()
        {
            Console.WriteLine("Program for calculating the volume of geometric figure\n");
            Console.WriteLine("\t\tSelekt geometric figure \n\t 1 - sphere, 2 - parallelepiped, 3 - pyramid ");
            Console.ForegroundColor = ConsoleColor.Blue;
            var choise = Console.ReadLine();
            Console.ResetColor();
            if (choise == "1")
            {
                Console.Write("Enter the radius of the sphere (sm) : ");
                Console.ForegroundColor = ConsoleColor.Green;
                var radiusBool = double.TryParse(Console.ReadLine(), out var radiusValue);
                Console.ResetColor();
                if (radiusBool)
                {
                    var VolumeSphere = 4.0 / 3.0 * Math.PI * Math.Pow(radiusValue, 3);
                    Console.WriteLine($"The volume of a sphere with radius {radiusValue:F2} sm is equal to {VolumeSphere:F2} cubic centimeters");
                }
                else ErrorColor();

            }
            else if (choise == "2")
            {
                Console.WriteLine("Enter the ");
                Console.Write("legth(sm): ");
                Console.ForegroundColor = ConsoleColor.Green;
                var leghtBool = double.TryParse(Console.ReadLine(), out var leghtValue);
                Console.ResetColor();
                Console.Write("height(sm): ");
                Console.ForegroundColor = ConsoleColor.Green;
                var heightBool = double.TryParse(Console.ReadLine(), out var heightValue);
                Console.ResetColor();
                Console.Write("width(sm) : ");
                Console.ForegroundColor = ConsoleColor.Green;
                var widthBool = double.TryParse(Console.ReadLine(), out var widthValue);
                Console.ResetColor();
                if (widthBool && leghtBool && heightBool)
                {
                    var volumeParallelepiped = leghtValue * heightValue * widthValue;
                    Console.WriteLine($" The volume of a sphere Parallelepiped with sizes :  \n {leghtValue:F2} sm X {heightValue:F2} sm X {widthValue} sm = {volumeParallelepiped:F2} cubic centimeters");
                }
                else ErrorColor();
            }
            else if (choise == "3")
            {
                Console.WriteLine("Enter the ");
                Console.Write("Base side(sm) : ");
                Console.ForegroundColor = ConsoleColor.Green;
                var baseSideBool = double.TryParse(Console.ReadLine(), out var baseSideValue);
                Console.ResetColor();
                Console.Write("Base height(sm): ");
                Console.ForegroundColor = ConsoleColor.Green;
                var baseHeightBool = double.TryParse(Console.ReadLine(), out var baseHeightValue);
                Console.ResetColor();
                Console.Write("Pyramid height(sm): ");
                Console.ForegroundColor = ConsoleColor.Green;
                var piramHeightBool = double.TryParse(Console.ReadLine(), out var piramHeightValue);
                Console.ResetColor();
                if (piramHeightBool && baseSideBool && baseHeightBool)
                {
                    var volumePiramide = baseSideValue * baseHeightValue * piramHeightValue / 6.0;
                    Console.WriteLine($" The volume of a pyramid with given dimensions :  \n {baseSideValue:F2} sm X {baseHeightValue:F2} sm X {piramHeightValue:F2} sm = {volumePiramide:F2} cubic centimeters");
                }
                else ErrorColor();
            }
            else ErrorColor();
        }
        // ---------------------------------------------------------------------------------------------
        static void ErrorColor(string str)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("'" + str + "' could not be parsed as floating number.");
            Console.ResetColor();
        }
        static void volumeAndAreaOfShapes()
        {
            Console.WriteLine("Program for calculating the Volume or Area of geometric figure\n");
            Console.WriteLine("\t\tSelekt geometric figure \n\t 1 - sphere, 2 - parallelepiped, 3 - pyramid ");


            Console.WriteLine("Enter the for parallelepiped ");
            Console.Write("legth(sm): ");
            Console.ForegroundColor = ConsoleColor.Green;
            string leghtStr = Console.ReadLine();
            Console.ResetColor();
            float leghtValue;
            if (!float.TryParse(leghtStr, out leghtValue))
            {
                ErrorColor(leghtStr);
                return;
            }
            Console.Write("height(sm): ");
            Console.ForegroundColor = ConsoleColor.Green;
            string heightStr = Console.ReadLine();
            Console.ResetColor();
            float heightValue;
            if (!float.TryParse(heightStr, out heightValue))
            {
                ErrorColor(heightStr);
                return;
            }
            Console.Write("legth(sm): ");
            Console.ForegroundColor = ConsoleColor.Green;
            string widthStr = Console.ReadLine();
            Console.ResetColor();
            float widthValue;
            if (!float.TryParse(widthStr, out widthValue))
            {
                ErrorColor(widthStr);
                return;
            }
            Console.Write("Enter 1 if Area or 2 if Volume --> ");
            Console.ForegroundColor = ConsoleColor.Green;
            string choise = Console.ReadLine();
            Console.ResetColor();
            if (choise == "1")
            {
                float area = 2 * (leghtValue * heightValue + leghtValue * widthValue + heightValue * widthValue);
                Console.WriteLine($"Area of the paralelepited : {area} square centimeters");
            }
            else if (choise == "2")
            {
                float volumePar = leghtValue * heightValue * widthValue;
                Console.WriteLine($"Volume of the paralelepited : {volumePar} cubic centimeters");
            }
            else ErrorColor();
        }
    }
}
