using System;
using System.Reflection;
using System.Text;

namespace TitleLib
{
    public static class Title
    {
        private static readonly int QuantityElements = 40;

        public static void UpperIndent(Assembly assembly)
        {
            string name = string.Empty;
            if (assembly != null)
            {
                name = assembly.GetName().Name;
            }
            int lengthName = name.Length;

            int beforeName = (QuantityElements - lengthName) / 2;
            int afterName = QuantityElements - beforeName - lengthName;

            var sb = new StringBuilder(QuantityElements);
            sb.Append(new string('-', beforeName));
            sb.Append(name);
            sb.Append(new string('-', afterName));
            sb.AppendLine();
            sb.AppendLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(sb.ToString());
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void BottonIndent()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--------------Press any key-------------");
            Console.ReadKey();
        }
    }
}
