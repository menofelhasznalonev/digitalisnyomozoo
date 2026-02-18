namespace digitalisnyomozoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            EvidenceManager em = new EvidenceManager();
            CaseManager cm = new CaseManager();
            User admin = new User("admin", 0, "admin");

            admin.EmberGeneralas();


            Console.WriteLine("A programban található emberek csak kitalációk, bármi egyezés a valósággal a véletlen műve.");
            do
            {
                em.Kivalaszto();
                cm.UgyHozzaadasa(admin, em);
			} while (true);
			
        }
    }
}
