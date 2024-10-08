namespace Lab04
{
    internal class Program
    {
        struct Boxer
        {
            public string fb; //Прізвище боксера
            public int w; //К-ть перемог
            public string ft; //Празвище тренера
            public string Vivod()
            {
                string s = $"{fb}\t{Convert.ToString(w)}\t{ft}";
                return s;
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Boxer> boxers = new List<Boxer>();
            Boxer box;
            Boxer mw = new Boxer();
            int n = 5;

            Console.WriteLine("Введіть дані:");
            for (int i = 0; i < n; i++)
            {
                box.fb = Console.ReadLine();
                box.w = Convert.ToInt32(Console.ReadLine());
                box.ft = Console.ReadLine();
                boxers.Add(box);
            }

            Console.WriteLine("\nСписок боксерів:");
            Console.WriteLine("\nБоксер\tПеремог\tТренер");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(boxers[i].Vivod());
            }

            Console.WriteLine("\nВведіть тренера:");
            string trener = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                if (boxers[i].ft == trener)
                {
                    if (boxers[i].w == 0 || boxers[i].w > mw.w)
                    {
                        mw = boxers[i];
                    }
                    Console.WriteLine(boxers[i].Vivod());
                }
            }
            if (mw.w != 0)
                Console.WriteLine("\nНайбільше перемог у тренера {0}: {1} з {2} перемогами", mw.ft, mw.fb, mw.w);
            else Console.WriteLine("Немає такого тренера");
        }
    }
}
