namespace digitalisnyomozoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            EvidenceManager em = new EvidenceManager();

            do
            {
                em.BizonyitekHozzaadasa(id);
				id += 1;
                em.BizonyitekTorlese();
			} while (id < 10);
			
        }
    }
}
