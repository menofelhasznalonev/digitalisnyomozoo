namespace digitalisnyomozoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            User u1 = new User("asd",1,"asdassdsa asd a");
			Console.WriteLine( u1.Id);
            u1.Nev = "jkl";
			Console.WriteLine(u1);
            //teszt
        }
    }
}
