namespace digitalisnyomozoo
{
    internal class Program
    {

        static void Menu(EvidenceManager em, CaseManager cm, User felhasznalo)
        {
            Console.WriteLine("A programban található emberek csak kitalációk, bármi egyezés a valósággal a véletlen műve.");
            do
            {
                Console.WriteLine("Milyen adatokat szeretne módosítani, törölni, vagy listázni?");
                string valasztas = "";
                do
                {
                    Console.Write("Bizonyítékok (B) | Ügyek (U) | Vissza (V) | ");
                    valasztas = Console.ReadLine().ToUpper();
                } while (valasztas != "B" && valasztas != "U" && valasztas != "L" && valasztas != "V");

                switch (valasztas)
                {
                    case "B": em.Kivalaszto(); break;
                    case "U": cm.Kivalaszto(felhasznalo, em); break;

                    default: Console.WriteLine("----------------------------------------------------------------------------------------------------"); break;
                }
            } while (true);
        }

        static void Main(string[] args)
        {
            
            EvidenceManager em = new EvidenceManager();
            CaseManager cm = new CaseManager();
            User admin = new User("admin", 0, "admin");

            admin.EmberGeneralas();

            Menu(em, cm, admin);
            
            
			
        }
    }
}
