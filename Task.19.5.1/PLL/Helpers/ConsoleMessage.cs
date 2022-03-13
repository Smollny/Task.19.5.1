using System;

namespace Task._19._5._1.PLL.Helpers
{
    public static class ConsoleMessage
    {
        public static void Show(string message, ConsoleColor color)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = originalColor;
        }
    }
}
