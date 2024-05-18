using System.Text;

namespace Homework_001
{
	internal class Program
	{
		static void Main()
		{
			Console.OutputEncoding = Encoding.UTF8;

			#region Ex1.1
			/*
			 * Рассчитать и вывести на экран площадь и периметр прямоугольника
			 * стороны которого запросить у пользователя (ввод с клавиатуры).
			 * Задача на ввод/вывод информации, арифметические операции
			 */
			Console.WriteLine("Exercise No1");
			Console.Write("Enter the length (in meters): ");
			int length = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the width (in meters): ");
			int width = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("The perimeter is: {0} m., the area is: {1} m²", 2 * (length + width), length * width);
			Console.WriteLine();
			#endregion

			#region Ex1.2
			/*
			 * Найдите сумму «1+2+3+…+n», где n вводится пользователем с клавиатуры.
			 * Задача на цикл «For…» 
			 */
			Console.WriteLine("Exercise No2");
			Console.Write("Enter a number: ");
			int n = Convert.ToInt32(Console.ReadLine());
			//Console.WriteLine("The sum(1...{0}) is equal: {1}", n, n * (n + 1) / 2);
			int sum = 0;
			for (int i = 1; i <= n; i++)
			{
				sum += i;
			}
			Console.WriteLine("The sum(1...{0}) is equal: {1}", n, sum);
			Console.WriteLine();
			#endregion

			#region Ex1.3
			/*
			 * Даны числа от 35 до 87. Вывести на консоль те из них, которые при делении на 7 дают остаток 1, 2 или 5.
			 * Задача на цикл «For…»
			 */
			Console.WriteLine("Exercise No3");
			for (int i = 35; i <= 87; i++)
			{
				if (i % 7 == 1 || i % 7 == 2 || i % 7 == 5)
				{
					Console.Write(i + " ");
				}
			}
			Console.WriteLine();
			Console.WriteLine();
			#endregion

			#region Ex1.4
			/*
			 * Представьте, что на складе имеется определённое количество ящиков с яблоками.
			 * Когда подъезжает машина для погрузки, попросить пользователя ввести с клавиатуры число – количество ящиков,
			 * которые готова забрать машина. Цикл должен работать до тех пор, пока все ящики не отгрузят со склада.
			 * Предусмотреть тот случай, когда пользователь введёт количество ящиков больше, чем есть на складе
			 * (сообщить о том, что столько нет и отгрузить сколько есть).
			 * Задача на цикл «While…»
			 */
			Console.WriteLine("Exercise No4");
			Random rand = new();
			int numOfBoxes = rand.Next(10, 101);

			while (numOfBoxes > 0)
			{
				Console.WriteLine("There are {0} boxes of apples in the warehouse", numOfBoxes);
				Console.Write("Boxes for shipment: ");
				int boxes = Convert.ToInt32(Console.ReadLine());
				if (boxes < 0)
				{
					Console.WriteLine("Incorrect number of boxes");
					continue;
				}
				if (boxes > numOfBoxes)
				{
					Console.WriteLine("Not enough boxes...");
					boxes = numOfBoxes;
				}
				Console.WriteLine("{0} boxes have been sent", boxes);
				numOfBoxes -= boxes;
			}
			#endregion
		}

	}
}
