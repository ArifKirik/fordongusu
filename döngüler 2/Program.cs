namespace döngüler_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i;
            //for(i=1; i<100; i++)
            //{
            //    if(i%9==0)
            //        Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //int sayi = 120;
            //int i;
            //for(i=1;i<=120;i++)
            //{
            //    if(sayi%i==0)
            //        Console.WriteLine(i);

            //}
            //Console.ReadLine();
            int a=1;
            int b=1;
            int c;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 1;i<=8 ;i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);

            }
            Console.ReadLine();
        }
    }
}
