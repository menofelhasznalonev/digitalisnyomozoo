namespace digitalisnyomozoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            EvidenceManager em = new EvidenceManager();
            User admin = new User("admin", 0, "admin");

            admin.Feltoltes();

            foreach (Person item in admin.emberekLista)
            {
                Console.WriteLine(item.Nev);
            }

            do
            {
                em.Kivalaszto();
			} while (true);
			
        }
    }
}
