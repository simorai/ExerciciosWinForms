using Cronometro;

namespace CronometroConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            var relogio = new CronometroF();            
            Console.WriteLine("Pressione Enter para iniciar o cronometro");
            Console.ReadLine();

            relogio.StartClock();
            Console.WriteLine("Pressione Enter novamente para parar o cronometro");

            while (relogio.ClockState())
            {
                var tempo = DateTime.Now - relogio.StartTime();
                Console.Write("\r Tempo Corrente: {0}", tempo);
                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            }
            relogio.StopClock();

            Console.WriteLine("\r Tempo Cronometrado: {0}", relogio.GetTimeSpan());
            Console.ReadLine();
        }
    }
}
