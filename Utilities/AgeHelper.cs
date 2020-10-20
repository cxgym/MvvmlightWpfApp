using System;

namespace MvvmlightWpfApp.Utilities
{
    public class AgeHelper
    {
        public static int CalAgebyBirthday(DateTime birthday)
        {
            return CalAgebyBirthday(birthday.Date, DateTime.Today);
        }

        public static int CalAgebyBirthday(DateTime birthday, DateTime date)
        {
            // Calculate the age.
            var currentAge = date.Year - birthday.Year;
            // Do stuff with it.
            if (birthday > date.AddYears(-currentAge))
            {
                currentAge--;
            }
            return currentAge;
        }
    }
}