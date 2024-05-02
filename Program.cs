using Aumerial.Data.Nti;

namespace NtiConfigurationHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            str += $"server={PromptText("IP/Host", false)};";
            str += $"user={PromptText("Username", false)};";
            str += $"password={PromptText("Password", true)};";
            if (PromptBool("Use SSL/TLS")) str += $"ssl=true;untrusted=true;";
            if (!PromptBool("Use default ports"))
            {
                str += $"use default ports=false;use port mapper = true;";
                if (!PromptBool("Port mapper service on port 449"))
                {
                    str += $"mapper port={PromptText("Port mapper service port", false)};";
                }
            }
            if (!PromptBool("Use KNTI as licence library")) str += $"licence library={PromptText("Custom licence library name", false)};";
            NTiConfigurationCLI.Run(str);
        }
        private static string PromptText(string label, bool hidden)
        {
            Console.Write(label + ":");
            var input = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && input.Length > 0)
                {
                    Console.Write("\b \b");
                    input = input[0..^1];
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write(hidden ? "*" : keyInfo.KeyChar);
                    input += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);
            Console.WriteLine();
            return input;
        }
        private static bool PromptBool(string label)
        {
            Console.Write(label + " ? [Y/N]");
            var input = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(true);
                key = keyInfo.Key;
                if (key == ConsoleKey.Y)
                {
                    Console.WriteLine(" Y");
                    return true;
                }
                else if (key == ConsoleKey.N)
                {
                    Console.WriteLine(" N");
                    return false;
                }
            } while (true);

        }
    }


}
