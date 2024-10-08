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
                string s = fb + " " + Convert.ToString(w) + " " + ft;
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

            Console.WriteLine("Список боксерів:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(boxers[i].Vivod());
            }

            Console.WriteLine("Введіть тренера:");
            string trener = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (boxers[i].ft == trener)
                {
                    mw = boxers[i];
                    Console.WriteLine("\nТренер: {0} {1} {2}", mw.fb, mw.w, mw.ft);
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (boxers[i].ft == trener &&
                    (boxers[i].w > mw.w)) mw = boxers[i];
            }
            Console.WriteLine("\nНайбільше перемог у тренера: {0} {1} {2}", mw.fb, mw.w, mw.ft);


        }
    }
}
