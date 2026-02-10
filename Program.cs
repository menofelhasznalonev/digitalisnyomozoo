namespace digitalisnyomozoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EvidenceManager em = new EvidenceManager();

            em.Kivalaszto();

            do
            {
                em.Kivalaszto();
			} while (true);
			
        }
    }
}
