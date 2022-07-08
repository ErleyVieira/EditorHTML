using System;

namespace EditorHTML
{
    public static class Menu
    {

        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Show");
            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen(){
            System.Console.Write("+");
            for (int i = 0; i <= 28; i++)
            {
                System.Console.Write("-");
            }
            System.Console.WriteLine("+");
            for (int j = 0; j <= 9; j++)
            {
                for (int i = 0; i <= 30; i++)
                {
                    if (i == 0)
                    {
                        Console.Write("|");
                    }
                    else if (i > 0 && i < 30)
                    {
                        Console.Write(" ");
                    }
                    else if (i == 30)
                    {
                        Console.WriteLine("|");
                    }
                }
            }
            System.Console.Write("+");
            for (int i = 0; i <= 28; i++)
            {
                System.Console.Write("-");
            }
            System.Console.WriteLine("+");
        }

        public static void WriteOptions(){
            Console.SetCursorPosition(3,2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3,3);
            System.Console.WriteLine("============");
            Console.SetCursorPosition(3,4);
            System.Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3,6);
            System.Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3,7);
            System.Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3,9);
            System.Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3,10);
            System.Console.Write("Opção: ");

            
        }

        public static void HandleMenuOption(short option){
            switch (option){
                case 1: System.Console.WriteLine("Editor"); break;
                case 2: System.Console.WriteLine("View"); break;
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default:{
                    System.Console.WriteLine("Opção inválida, tente novamente uma da opções");
                    Show();
                    break;
                }
            }
        }
    }
}
