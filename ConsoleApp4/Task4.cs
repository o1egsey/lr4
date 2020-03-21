using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        class warehouse
        {
            private string name;
            private string producer;
            private string date;
            private float price;
            private float dimensions;
            public void Input()
            {
                Console.WriteLine("Введите название продукции:");
                name = Console.ReadLine();
                Console.WriteLine("Введите производителя:");
                producer = Console.ReadLine();
                Console.WriteLine("Дата поступления на склад:");
                date = Console.ReadLine();
                Console.WriteLine("Цена товара составляет:");
                price = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите габариты товара:");
                dimensions = float.Parse(Console.ReadLine());
            }
            public void Show()
            {
                Console.WriteLine("***********************************");
                Console.WriteLine("Название продукции - " + name + ";");
                Console.WriteLine("Производитель - " + producer + ";");
                Console.WriteLine("Дата поступления на склад - " + date + ";");
                Console.WriteLine("Цена товара - " + price + ";");
                Console.WriteLine("Габариты товара - " + dimensions + ";");
                Console.WriteLine("***********************************");
            }
            public void Search(ref string dez_date, ref float dez_price, ref float dez_dimensions)
            {
                if ((string.Equals(date, dez_date)) && price == dez_price && dimensions == dez_dimensions)
                    Show();
            }
            public void SortByPrice(int n, warehouse[] A)
            {
                float[] prices = new float[n];
                for (int i = 0; i != n; i++)
                    prices[i] = A[i].price;
                Array.Sort(prices, A, 0, n);
            }
        }

        static void Main(string[] args)
        {
            int n;
            string dez_date;
            float dez_price, dez_dimensions;

            Console.WriteLine("----------Добавления товара на склад------------");
            Console.WriteLine("Введите количество продукции на складе:");
            n = int.Parse(Console.ReadLine());
            warehouse[] A = new warehouse[n];

            for (int i = 0; i < n; i++)
            {
                A[i] = new warehouse();
                A[i].Input();
                A[i].Show();
            }

            Console.WriteLine("------------Поиск товара--------------");
            Console.WriteLine("Введите необходимую дату для поиска:");
            dez_date = Console.ReadLine();
            Console.WriteLine("Введите необходимую цену для поиска:");
            dez_price = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите необходимие габариты для поиска:");
            dez_dimensions = float.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                A[i].Search(ref dez_date, ref dez_price, ref dez_dimensions);
            }

            Console.WriteLine("---------Сортировка товара за ценой--------------");
            for (int i = 0; i < n; i++)
            {
                A[i].SortByPrice(n, A);
                A[i].Show();
            }
            Console.ReadKey();
        }
    }

}
