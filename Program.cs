namespace digitalisnyomozoo
{
    internal class Program
    {

        static void Menu(EvidenceManager em, CaseManager cm, DecisionEngine de, DataStore ds, User felhasznalo)
        {
            bool megy = true;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("A programban található emberek csak kitalációk, bármi egyezés a valósággal a véletlen műve.");
            Console.ResetColor();
            do
            {

                Console.WriteLine("Milyen adatokat szeretne módosítani, törölni, vagy listázni?");
                string valasztas = "";
                do
                {
                    Console.Write("Bizonyítékok (B) | Ügyek (U) | Gyanusítottak (G) | Kilépés (K): ");
                    valasztas = Console.ReadLine().ToUpper();
                } while (valasztas != "B" && valasztas != "U" && valasztas != "G" && valasztas != "K");

                switch (valasztas)
                {
                    case "B": 
                        Console.Clear();
                        em.Kivalaszto(); break;
                    case "U":
                        Console.Clear();
                        cm.Kivalaszto(ds, em); break;
                    case "G":
                        Console.Clear();
                        de.GyanusitottsagModositas(); break;
                    case "K":
                        Console.Clear();
                        megy = false; break;

                    default: Console.Clear(); break;
                }
            } while (megy);
        }

        static void Main(string[] args)
        {
            
            EvidenceManager em = new EvidenceManager();
            CaseManager cm = new CaseManager();
            DecisionEngine de = new DecisionEngine();
            DataStore ds = new DataStore();
            User admin = new User("admin", 0, "admin");
            em.KezdoBizonyitek();
            ds.EmberGeneralas();
            de.KezdoGyanusitas(em.Lista[0], ds.emberekLista);

            Menu(em, cm, de, ds, admin);
            
            
			
        }
    }
}
