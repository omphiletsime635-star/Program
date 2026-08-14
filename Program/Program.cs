namespace Program;
    using System.Media;

internal class Program
{
    private static string? userName;

    static void Main(string[] args)
    {

        logo logo1 = new logo();
        logo1.DisplayLogo();
        Console.WriteLine("Voice played successfully!");

        SoundPlayer player = new SoundPlayer("C:\\Users\\Student\\source\\repos\\Program\\Program\\Properties\\voice\\Rosebank College.wav");
        player.PlaySync();

        
        //Console.ReadLine();

        //ASCII LOGO

        

        /*Console.ForegroundColor = ConsoleColor.Magenta; 
        Console.WriteLine("Welcome to Zamaswasi Cybersecurity AwarenessBot! Before we start, what should I call you?");
        Console.ResetColor();
        Console.ReadLine();*/




        // ===== TASK 3: Text-Based Greeting and User Interaction =====
        ShowHeader();
        GetUserName();
        ShowWelcomeBanner();

        // ===== MAIN LOOP: TASK 4 + 5 =====
        while (true)
        {
            ShowPrompts(); // Easy to understand prompts
            string input = Console.ReadLine();

            if (HandleInputValidation(input)) // TASK 5
            {
                ProcessUserInput(input); // TASK 4
            }
        }
    }

    // ===== TASK 6: Enhanced Console UI =====
    static void ShowHeader()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("==================================================");
        Console.WriteLine("       Zamaswasi Cybersecurity AwarenessBot");
        Console.WriteLine("           Your Guide to Online Safety");
        Console.WriteLine("==================================================");
        Console.ResetColor();
        Console.WriteLine();
    }
    static void TypeText(string text, int delay = 30)
    {
        // Typing effect for conversational feel
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine();
    }

    // ===== TASK 3: Ask name + Personalise =====
    static void GetUserName()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        TypeText("Hello! Zamaswasi Cybersecurity AwarenessBot. What's your name?");
        Console.ResetColor();

        while (true)
        {
            Console.Write("> ");
            userName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(userName))
                break;

            Console.ForegroundColor = ConsoleColor.Red;
            TypeText("Oops! I didn't catch that. Please enter your name.");
            Console.ResetColor();
        }
    }

    static void ShowWelcomeBanner()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"
   __        __   _                            _ 
   \      / /__| | ___ ___  _ __ ___   ___  | |
    \ \ /\ / / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | |
     \ V  V /  __/ | (_| (_) | | | |  __/ |_|
      \_/\_/ \___|_|\___\___/|_| |_| |_|\___| (_)
        ");
        TypeText($"Welcome, {userName}! I'm here to help you stay safe online.");
        Console.ResetColor();
        Console.WriteLine("--------------------------------------------------");
    }

    // ===== EASY PROMPTS FOR USER =====
    static void ShowPrompts()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n[What would you like to ask me?]");
        Console.ResetColor();
        Console.WriteLine(" 1. How are you?");
        Console.WriteLine(" 2. What's your purpose?");
        Console.WriteLine("  3. What can I ask you about?");
        Console.WriteLine("  4. Password Safety");
        Console.WriteLine("  5. Phishing");
        Console.WriteLine("  6. Safe Browsing");
        Console.WriteLine("  7. Exit");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"\n{userName}, type your question or number: ");
        Console.ResetColor();
    }

    // ===== TASK 5: Input Validation =====
    static bool HandleInputValidation(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            TypeText("I didn't quite understand that. Could you rephrase?");
            Console.ResetColor();
            return false;
        }
        return true;
    }

    // ===== TASK 4: Basic Response System =====
    static void ProcessUserInput(string input)
    {
        string lowerInput = input.ToLower();

        Console.WriteLine("--------------------------------------------------");

        // Sub-prompts based on what user selected
        if (lowerInput.Contains("how are you") || lowerInput == "1")
        {
            TypeText($"I'm doing great, {userName}! Thanks for asking. Ready to help you learn about cybersecurity.");
        }
        else if (lowerInput.Contains("purpose") || lowerInput == "2")
        {
            TypeText($"My purpose is to teach you about staying safe online, {userName}.");
            TypeText("I can give tips on passwords, phishing scams, and safe browsing.");
        }
        else if (lowerInput.Contains("ask") || lowerInput == "3")
        {
            TypeText($"You can ask me about these topics, {userName}:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  - Password Safety: How to create strong passwords");
            Console.WriteLine("  - Phishing: How to spot scam emails and links");
            Console.WriteLine("  - Safe Browsing: How to stay safe on websites");
            Console.ResetColor();
        }
        else if (lowerInput.Contains("password") || lowerInput == "4")
        {
            ShowPasswordSafety();
        }
        else if (lowerInput.Contains("phishing") || lowerInput == "5")
        {
            ShowPhishingInfo();
        }
        else if (lowerInput.Contains("browsing") || lowerInput == "6")
        {
            ShowSafeBrowsing();
        }
        else if (lowerInput.Contains("exit") || lowerInput == "7")
        {
            TypeText($"Goodbye, {userName}! Stay safe online.");
            Environment.Exit(0);
        }
        else // Default response for unsupported queries
        {
            Console.ForegroundColor = ConsoleColor.Red;
            TypeText("I didn't quite understand that. Could you rephrase?");
            TypeText("Try typing: 'Password Safety', 'Phishing', or 'Safe Browsing'");
            Console.ResetColor();
        }
        Console.WriteLine("--------------------------------------------------");
    }

    // ===== SUB-PROMPTS FOR CYBERSECURITY TOPICS =====
    static void ShowPasswordSafety()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        TypeText("[PASSWORD SAFETY TIPS]");
        Console.ResetColor();
        TypeText("1. Use at least 12 characters");
        TypeText("2. Mix uppercase, lowercase, numbers, and symbols");
        TypeText("3. Don't reuse passwords across sites");
        TypeText("4. Use a password manager to remember them");
    }

    static void ShowPhishingInfo()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        TypeText("[PHISHING WARNING SIGNS]");
        Console.ResetColor();
        TypeText("1. Urgent language: 'Your account will be closed!'");
        TypeText("2. Suspicious sender email address");
        TypeText("3. Links that don't match the company website");
        TypeText("4. Asking for passwords or bank details via email");
        TypeText("Tip: Always hover over links before clicking!");
    }

    static void ShowSafeBrowsing()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        TypeText("[SAFE BROWSING TIPS]");
        Console.ResetColor();
        TypeText("1. Look for 'https://' and a padlock icon in the URL");
        TypeText("2. Don't download files from unknown websites");
        TypeText("3. Keep your browser and antivirus updated");
        TypeText("4. Use public Wi-Fi carefully - avoid banking on it");
    }
}
    
