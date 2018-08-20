using System;

namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            // tells user about program and asks for birthday input 
            Console.WriteLine("This program will tell you the day of the week you were born,\n" +
                "the day of the week your next birthday will be on,\nyour astrological sign, and  " +
                "a horoscope.");
            Console.Write("\nPlease enter your date of birth (MM/DD/YYYY): ");

            //Takes user input and converts to DateTime
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            //Prints day of week user was born on
            Console.WriteLine($"\nYou were born on a {birthday.DayOfWeek}.");

            //Changes birthday to current year to find next day of week birthday.
            DateTime nextBirthday = new DateTime(DateTime.Now.Year, birthday.Month, birthday.Day);

            //if birthday has already occured this year, adds one year to figure out day of week.
            if (DateTime.Now.CompareTo(nextBirthday) <= 0)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            Console.WriteLine($"\nYour next birthday will be on a {nextBirthday.DayOfWeek}.");

            //turns DateTime into in for if loop
            int month = birthday.Month;
            int day = birthday.Day;

            //creates strings for later use
            string sign;
            string horoscope;

            //if loop that finds zodiac signs between two date parameters 
            if (month == 1 && day >= 20 || month == 2 && day <= 18)
            {
                //picks sign from array and assigns horoscope
                sign = "Aquarius";
                horoscope = "Your ruler is Uranus. Celebrate your magical side this week by listening to" +
                    "\n songs such as \"Uranus - the Magician\" by Gustav Holst.";
            }

            else if (month == 2 && day >= 19 || month == 3 && day <= 20)
            {

                sign = "Pisces";
                horoscope = "Your ruler is Neptune. Spend some time daydreaming this week to songs such as" +
                    "\nGustav Holst's \"Neptune - the Mystic\".";
            }

            else if (month == 3 && day >= 21 || month == 4 && day <= 19)
            {

                sign = "Aries";
                horoscope = "Your ruler is Mars. Celebrate your active, assertive, and competitive nature" +
                    "\nthis week by listening to songs such as \"Mars - the Bringer of War\" by Gustav Holst.";
            }

            else if (month == 4 && day >= 20 || month == 5 && day <= 20)
            {

                sign = "Taurus";
                horoscope = "Your ruler is Venus. This week, celebrate your love of luxury by treating yourself" +
                    "\nto a special gift or a warm bath while listening to" +
                    " songs such as Gustav Holst's \"Venus - the Bringer of Peace\".";
            }

            else if (month == 5 && day >= 21 || month == 6 && day <= 20)
            {

                sign = "Gemini";
                horoscope = "Your ruler is Mercury. Your greatest asset is your strong sense of communication." +
                    "\nThis week, stike up a conversation with an interesting stranger and listen to" +
                    "\nsongs such as Gustav Holst's \"Mercury - the Winged Messenger\"."; ;
            }

            else if (month == 6 && day >= 21 || month == 7 && day <= 22)
            {

                sign = "Cancer";
                horoscope = "Your ruler is the moon. If you get overwhelmed by your emotions this week," +
                    "\ntake some time to decompress and listen to songs such as \"Pink Moon\" by Nick Drake.";
            }

            else if (month == 7 && day >= 23 || month == 8 && day <= 22)
            {

                sign = "Leo";
                horoscope = "Your ruler is the Sun. Spend some time in the sun this week" +
                    "\nor listen to songs such as \"Here Comes the Sun\" by the Beatles.";
            }

            else if (month == 8 && day >= 23 || month == 9 && day <= 22)
            {

                sign = "Virgo";
                horoscope = "Your ruler is Mercury. Take a break from overthinking this week, " +
                    "\nand listen to songs such as Gustav Holst's \"Mercury - the Winged Messenger\".";
            }

            else if (month == 9 && day >= 23 || month == 10 && day <= 22)
            {

                sign = "Libra";
                horoscope = "Your ruler is Venus. Celebrate your loving nature this week" +
                    "\nby listening to songs such as Gustav Holst's \"Venus - the Bringer of Peace\".";
            }

            else if (month == 10 && day >= 23 || month == 11 && day <= 21)
            {

                sign = "Scorpio";
                horoscope = "Your ruler is Pluto. Soothe any strong emotions this week by listening to" +
                    "\nsongs such as \"Plutonian Nights\" by Sun Ra.";
            }

            else if (month == 11 && day >= 22 || month == 12 && day <= 21)
            {

                sign = "Sagittarius";
                horoscope = "Your ruler is Jupiter. Cultivate your good luck this week by listening" +
                    "\nto songs such as \"Jupiter - the Bringer of Jollity\" by Gustav Holst.";
            }

            else if (month == 1 && day <= 19 || month == 12 && day >= 22)
            {

                sign = "Capricorn";
                horoscope = "Your ruler is Saturn. You are always working hard, so take a restful break" +
                    "\nthis week and listen to \"Saturn\" by Gustav Holst.";
            }

            else
            {
                sign = "Error";
                horoscope = "Error";
            }

            //prints sign and horoscope to console for user 
            Console.WriteLine($"\nYour sign is : {sign}");
            Console.WriteLine($"\nYour horoscope: {horoscope}");
            Console.ReadLine();

        }
    }
}
