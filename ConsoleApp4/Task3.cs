using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        class Ship
        {
            protected string name;
            protected string purpose;
            protected string displacement;
            protected string engine_power;
            protected string fuel_type;
            public void Input()
            {
                Console.WriteLine("Введите название корабля:");
                name = Console.ReadLine();
                Console.WriteLine("Назначение корабля:");
                purpose = Console.ReadLine();
                Console.WriteLine("Водотонажность корабля - ");
                displacement = Console.ReadLine();
                Console.WriteLine("Мощность двигателя - ");
                engine_power = Console.ReadLine();
                Console.WriteLine("Вид топлива - ");
                fuel_type = Console.ReadLine();
            }
            public void Show()
            {
                Console.WriteLine("Название корабля - " + name + ";");
                Console.WriteLine("Назначение корабля - " + purpose + ";");
                Console.WriteLine("Водотонажность корабля - " + displacement + ";");
                Console.WriteLine("Мощность двигателя - " + engine_power + ";");
                Console.WriteLine("Вид топлив - " + fuel_type + ";");
            }

        }

        class Carrier : Ship
        {
            private int plane_count;
            private string plane_type;
            public void Input1()
            {
                Input();
                Console.WriteLine("Вид самолетов на борту:");
                plane_type = Console.ReadLine();
                Console.WriteLine("Количество самолетов - ");
                plane_count = int.Parse(Console.ReadLine());
            }
            public void Show1()
            {
                Show();
                Console.WriteLine("Вид самолетов на борту - " + plane_type + ";");
                Console.WriteLine("Количество самолетов - " + plane_count + ";");
            }
        }

        class Rocket_launcher : Ship
        {
            private string rocket_type;
            private int rocket_count;
            public void Input2()
            {
                Input();
                Console.WriteLine("Вид ракет на борту:");
                rocket_type = Console.ReadLine();
                Console.WriteLine("Количество ракет - ");
                rocket_count = int.Parse(Console.ReadLine());
            }
            public void Show2()
            {
                Show();
                Console.WriteLine("Вид ракет на борту - " + rocket_type + ";");
                Console.WriteLine("Количество ракет - " + rocket_count + ";");
            }
        }

        static void Main(string[] args)
        {
            Ship A = new Ship();

            A.Input();
            Console.WriteLine("********************");
            A.Show();
            Console.WriteLine("********************");

            Carrier B = new Carrier();
            B.Input1();
            Console.WriteLine("********************");
            B.Show1();
            Console.WriteLine("********************");

            Rocket_launcher C = new Rocket_launcher();
            C.Input2();
            Console.WriteLine("********************");
            C.Show2();
            Console.WriteLine("********************");
            Console.ReadKey();
        }
    }
}

