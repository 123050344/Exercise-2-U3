// See https://aka.ms/new-console-template for more information
namespace Exercise_2_U3
{
    internal class program
    {
        public static void Main(string[] args)
        {
            extent a = new extent();
            a . @Extent (5);
            Console.WriteLine (a.ToString ());

            extent b = new extent ();
            b . @Extent (10);

            extent c = new extent ();
            c.Perimeter();
            Console.WriteLine (c.ToString ());
            

        }
    }
}
