namespace CourseApp.RPGsaga
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    public class Screen
    {
        private Game game;

        public Screen(Game game)
        {
            this.game = game;
        }

        public int RequestNumber()
        {
            Console.Clear();
            Print("Please choose size of commands: ", 2);
            return Console.Read();
        }

        public bool RequestName()
        {
            Console.Clear();
            Print("Do u want to name characters? (YES/NO)\n", 2);
            string s = Console.ReadLine();
            switch (s)
            {
                case "YES":
                    return true;
                default:
                    return false;
            }
        }

        public string RequestForName(string type)
        {
            Console.Clear();
            Println($"Enter name of {type}(sings <= 6):", 2);

            string name = Console.ReadLine();
            string result = null;
            for (int i = 0; i < name.Length; i++)
            {
                if (i == 7)
                {
                    break;
                }

                result += name[i];
            }

            return result;
        }

        public void UpDate()
        {
            /*
            Console.Clear();
            Console.SetCursorPosition(0, 2);
            int y = Console.CursorTop;
            Print(game.Active[0].Card.Content, 3);
            Console.SetCursorPosition(Console.CursorLeft + 20, y);
            Print(game.Active[1].Card.Content, 3);
            Console.SetCursorPosition(0, y + 21);
            for (int k = 0; k < 25; k++)
            {
                Console.Write('*');
            }

            Console.WriteLine();
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
            y = Console.CursorTop;
            foreach (Character player in game.TeamFirst)
            {
                Print(player.Card.Content, 3);
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 2);
            }

            Console.SetCursorPosition(Console.CursorLeft + 20, y);
            foreach (Character player in game.TeamSecond)
            {
                Print(player.Card.Content, 3);
                Console.SetCursorPosition(Console.CursorLeft + 20, Console.CursorTop + 2);
            }

            Console.SetCursorPosition(26, 2);
            Print("Game logs:", 3);
            List<string> logs = Logs.GetLogs();
            Console.SetCursorPosition(26, 3);
            foreach (string row in logs)
            {
                Println(row, 3);
                Console.SetCursorPosition(26, Console.CursorTop);
            }
            */
            Console.Clear();
            List<string> logs = Logs.GetLogs();
            foreach (string row in logs)
            {
                Println(row, 2);
            }
        }

        public void ShowAttack(int index)
        {
            Ability attack = Logs.LastAbility;
            if (index == 0 && !attack.OnYourself)
            {
                int inx = game.Active[0].Abilities.IndexOf(attack) + 1;
                Console.SetCursorPosition(13, 8 + inx);
                string attacke = $"---{attack.Name}--->";
                Print(attacke, 2);
                Console.SetCursorPosition(13, 8 + inx);
                for (int i = 0; i < attacke.Length; i++)
                {
                    Print(" ", 2);
                }
            }
            else if (index == 1 && !attack.OnYourself)
            {
                int inx = game.Active[1].Abilities.IndexOf(attack) + 1;
                Console.SetCursorPosition(29, 8 + inx);
                string attacke = $"<---{attack.Name}---";
                for (int i = attacke.Length - 1; i >= 0; i--)
                {
                    Print($"{attacke[i]}", 2);
                    Console.SetCursorPosition(Console.CursorLeft - 2, 8 + inx);
                }

                for (int i = attacke.Length - 1; i >= 0; i--)
                {
                    Print(" ", 2);
                    Console.SetCursorPosition(Console.CursorLeft - 2, 8 + inx);
                }
            }
            else if (index == 0 && attack.OnYourself)
            {
                int inx = game.Active[0].Abilities.IndexOf(attack) + 1;
                Console.SetCursorPosition(13, 8 + inx);
                string down = $"--{attack.Name}--";
                Print(down, 2);
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                for (int i = 0; i < inx + 1; i++)
                {
                    Print("|", 2);
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop - 1);
                }

                string up = "<";
                for (int i = 0; i < down.Length - 1; i++)
                {
                    up += "-";
                }

                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);

                for (int i = up.Length - 1; i <= 0; i--)
                {
                    Print($"{up[i]}", 2);
                    Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
                }

                Console.SetCursorPosition(13, 8 + inx);
                for (int i = 0; i < down.Length; i++)
                {
                    Print(" ", 2);
                }

                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                for (int i = 0; i < inx + 1; i++)
                {
                    Print(" ", 2);
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop - 1);
                }

                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                for (int i = 0; i < up.Length; i++)
                {
                    Print(" ", 2);
                    Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
                }
            }
        }

        public void ShowFinalPage(string par)
        {
            switch (par)
            {
                case "Win":
                    Print("Your team win!", 2);
                    break;
                default:
                    Print("Your team lose :(", 2);
                    break;
            }
        }

        private void Print(string s, int speed)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]);
                Thread.Sleep((1 / speed) * 1000);
            }
        }

        private void Println(string s, int speed)
        {
            Print(s, speed);
            Console.WriteLine();
        }
    }
}
