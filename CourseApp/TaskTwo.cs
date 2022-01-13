namespace CourseApp
{
    using System;

    public class TaskTwo
    {
        private const int CurrentDay = 13;
        private const int CurrentMonth = 1;
        private const int CurrentYear = 2022;
        private int day = 0;
        private int month = 0;
        private int year = 0;
        private bool check = true;

        public void InitData(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!(s[i] == '1' || s[i] == '2' || s[i] == '3' || s[i] == '4' || s[i] == '5' || s[i] == '6' || s[i] == '7' || s[i] == '8' || s[i] == '9' || s[i] == '0' || s[i] == '.'))
                {
                    check = false;
                }
            }

            int w;
            if (s.Length != 10 && check)
            {
                check = false;
            }
            else
            {
                w = ((Convert.ToInt32(s[0]) - 48) * 10) + (Convert.ToInt32(s[1]) - 48);
                if (w > 0 && w < 32 && check)
                {
                    day = w;
                }
                else
                {
                    check = false;
                }

                w = ((Convert.ToInt32(s[3]) - 48) * 10) + (Convert.ToInt32(s[4]) - 48);
                if (w > 0 && w < 13 && check)
                {
                    month = w;
                }
                else
                {
                    check = false;
                }

                w = ((Convert.ToInt32(s[6]) - 48) * 1000) + ((Convert.ToInt32(s[7]) - 48) * 100) + ((Convert.ToInt32(s[8]) - 48) * 10) + (Convert.ToInt32(s[9]) - 48);
                if (w > 0 && w < 10000 && check)
                {
                    year = w;
                }
                else
                {
                    check = false;
                }
            }
        }

        public string Check()
        {
            if (!check)
            {
                return "Incorrect Data";
            }

            if (year < CurrentYear)
            {
                return "The birthday in the past.";
            }
            else if (year > CurrentYear)
            {
                return "The birthday in the future.";
            }
            else if (month < CurrentMonth)
            {
                return "The birthday in the past.";
            }
            else if (month > CurrentMonth)
            {
                return "The birthday in the future.";
            }
            else if (day < CurrentDay)
            {
                return "The birthday in the past.";
            }
            else if (day > CurrentDay)
            {
                return "The birthday in the future.";
            }
            else
            {
                return "The birthday today.";
            }
        }
    }
}