namespace Program;
    using System.Media;

    internal class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer player = new SoundPlayer("C:\\Users\\Student\\source\\repos\\Program\\Program\\Properties\\voice\\Rosebank College.wav");
            player.PlaySync();

            Console.WriteLine("Voice played successfully!");
            //Console.ReadLine();

            //ASCII LOGO

            logo logo1 = new logo(); 
            logo1.DisplayLogo(); 

            Console.ForegroundColor = ConsoleColor.Magenta; 
            Console.WriteLine("Welcome to the Cybersecurity AwarenessBot!");
            Console.ResetColor();
            Console.ReadLine(); 
        }
    }

