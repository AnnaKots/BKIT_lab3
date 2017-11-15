using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab3_BKIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 4);
            Square square = new Square(5);
            Circle circle = new Circle(5);

            Console.WriteLine("\nArrayList");//4. коллекция класса ArrayList
            ArrayList al = new ArrayList();
            al.Add(circle);//добавление элов в необобщенный список
            al.Add(rect);
            al.Add(square);

            foreach (var x in al)//повторяет группу операторов для каждого эла в списке
                Console.WriteLine(x);// вывод элементов списка

            Console.WriteLine("\nArrayList - сортировка");
            al.Sort();
            foreach (var x in al) Console.WriteLine(x);

            Console.WriteLine("\nList<Figure>");//5. Коллекция класса List<Figure>
            List<Figure> fl = new List<Figure>();//из класса Figure тип
            fl.Add(circle);
            fl.Add(rect);
            fl.Add(square);

            foreach (var x in fl) Console.WriteLine(x);

            Console.WriteLine("\nList<Figure> - сортировка");
            fl.Sort();
            foreach (var x in fl) Console.WriteLine(x);

            Console.WriteLine("\nМатрица");
            Matrix3D<Figure> cube = new Matrix3D<Figure>(3, 3, 3, null);//размерность и заполнение
            cube[0, 0, 0] = rect;
            cube[1, 1, 1] = square;
            cube[2, 2, 2] = circle;
            Console.WriteLine(cube.ToString());
            
            Console.WriteLine("\nСписок");
            SimpleList<Figure> list = new SimpleList<Figure>();
            list.Add(square);
            list.Add(rect);
            list.Add(circle);

            foreach (var x in list) Console.WriteLine(x);
            
            list.Sort();
            Console.WriteLine("\nСортировка списка");
            foreach (var x in list) Console.WriteLine(x);

            Console.WriteLine("\nСтек");
            SimpleStack<Figure> stack = new SimpleStack<Figure>();
            stack.Push(rect);
            stack.Push(square);
            stack.Push(circle);

            while (stack.Count > 0)
            {
                Figure f = stack.Pop();
                Console.WriteLine(f);
            }
            Console.ReadLine();
        }
    }
}
