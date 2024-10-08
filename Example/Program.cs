namespace Example
{
    internal class Program
    {
        struct Lud
        {
            public string f;
            public int gr;
            public char p;
            public string Vivod()
            {
                string s = f + " " + Convert.ToString(gr) +
                    " " + Convert.ToString(p);
                return s;
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Lud> students = new List<Lud>();
            Lud stud;
            Lud mx = new Lud();
            int n = 4;

            Console.WriteLine("Введіть дані:");
            for (int i = 0; i < n; i++)
            {
                stud.f = Console.ReadLine();
                stud.gr = Convert.ToInt32(Console.ReadLine());
                stud.p = Convert.ToChar(Console.ReadLine());
                students.Add(stud);
            }

            Console.WriteLine("Список студентів:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(students[i].Vivod());
            }

            for (int i = 0; i < n; i++)
            {
                if (students[i].p == 'ж' &&
                    (students[i].gr == 0 || students[i].gr > mx.gr)) mx = students[i];
            }
            if (mx.gr != 0)
                Console.WriteLine("\nНаймолодша студентка: {0} {1} {2}", mx.f, mx.gr, mx.p);
            else Console.WriteLine("\nНемає дівчат");

        }
    }
}
