namespace CourseApp.RPGsaga
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    public class Game
    {
        private Screen screen;

        public Character[] Active { get; set; }

        public List<Character> TeamFirst { get; set; }

        public List<Character> TeamSecond { get; set; }

        public void Start()
        {
            TeamFirst = new List<Character>();
            TeamSecond = new List<Character>();
            Active = new Character[2];
            Active[0] = null;
            Active[1] = null;
            screen = new Screen(this);
            int n = screen.RequestNumber();
            string[] m = { "Mag", "Archer", "Knight" };
            bool flag_name = screen.RequestName();
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                string type = m[rnd.Next(3)];
                if (flag_name)
                {
                    string name = screen.RequestForName(type);
                    TeamFirst.Add(Creator.CreateCharacter(type, name));
                }
                else
                {
                    TeamFirst.Add(Creator.CreateCharacter(type));
                }
            }

            for (int i = 0; i < n; i++)
            {
                TeamSecond.Add(Creator.CreateCharacter(m[rnd.Next(3)]));
            }

            GamePlay();
        }

        private void GamePlay()
        {
            Random rnd = new Random();
            while (!CheckAllDeath())
            {
                GenerateActive();
                screen.UpDate();
                Thread.Sleep(1000);
                int attackindex = rnd.Next(2);
                Active[attackindex].Turn();

                // screen.ShowAttack(attackindex);
                Thread.Sleep(1000);
                screen.UpDate();
                Thread.Sleep(1000);
            }

            if (CheckTeamDeath(TeamFirst))
            {
                screen.ShowFinalPage("Win");
            }
            else
            {
                screen.ShowFinalPage("Lose");
            }
        }

        private void GenerateActive()
        {
            Random rnd = new Random();
            if (Active[0] != null)
            {
                TeamFirst.Add(Active[0]);
            }

            if (Active[1] != null)
            {
                TeamSecond.Add(Active[1]);
            }

            Character c = TeamFirst[rnd.Next(TeamFirst.Count)];
            if (!c.Dead)
            {
                Active[0] = c;
            }

            TeamFirst.Remove(c);

            c = TeamSecond[rnd.Next(TeamSecond.Count)];
            if (!c.Dead)
            {
                Active[1] = c;
            }

            TeamSecond.Remove(c);
            Active[0].SetEnemy(Active[1]);
            Active[1].SetEnemy(Active[0]);
        }

        private bool CheckAllDeath()
        {
            if (!CheckTeamDeath(TeamFirst) && !CheckTeamDeath(TeamSecond))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CheckTeamDeath(List<Character> team)
        {
            int countDeath = 0;
            foreach (Character one in team)
            {
                if (one.Dead)
                {
                    countDeath++;
                }
            }

            if (countDeath == team.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
