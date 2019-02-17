using System;

namespace Exercise.Akka
{
    public static class ColorConsole
    {
        public static void WriteGreen(string message, params object[] args) =>
            WriteWithColor(ConsoleColor.Green, message, args);

        public static void WriteYellow(string message, params object[] args) =>
            WriteWithColor(ConsoleColor.Yellow, message, args);

        public static void WriteRed(string message, params object[] args) =>
            WriteWithColor(ConsoleColor.Red, message, args);

        public static void WriteGray(string message, params object[] args) =>
            WriteWithColor(ConsoleColor.Gray, message, args);

        public static void WriteWithColor(ConsoleColor color, string message, params object[] args)
        {
            var before = Console.ForegroundColor;

            Console.ForegroundColor = color;

            Console.WriteLine(string.Format(message, args));

            Console.ForegroundColor = before;
        }
    }
}
