namespace digitalisnyomozoo
{
    internal class Program
    {

        static void Menu(EvidenceManager em, CaseManager cm, DecisionEngine de, User felhasznalo)
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
            DecisionEngine de = new DecisionEngine();
            User admin = new User("admin", 0, "admin");
            em.KezdoBizonyitek();
            admin.EmberGeneralas();
            de.KezdoGyanusitas(em.Lista[0], admin.emberekLista);

            Menu(em, cm, de, admin);
            
            
			
        }
    }
}
