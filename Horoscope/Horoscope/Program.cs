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
            Console.Write("Please enter your birthday (MM/DD/YYYY): ");

            //Takes user input and converts to DateTime
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            //Prints day of week user was born on
            Console.WriteLine($"\nYou were born on a {birthday.DayOfWeek}.");

            //Changes birthday to current year to find next day of week birthday.
            DateTime year = DateTime.Now;
            DateTime nextBirthday = new DateTime(year.Year, birthday.Month, birthday.Day);
            int result = DateTime.Compare(nextBirthday, DateTime.Now);

            //if birthday has already occured this year, adds one year to figure out day of week.
            if (result < 0 || result == 0)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            Console.WriteLine($"\nYour next birthday will be on a {nextBirthday.DayOfWeek}.");

            //turns DateTime into in for if loop
            int month = birthday.Month;
            int day = birthday.Day;

            //creates array for easy zodiac access 
            string[] zodiac = {"Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra",
                "Scorpio", "Sagittarius", "Capricorn", "Aquarius", "Pisces"};

            //creates strings for later use
            string sign = "0";
            string horoscope = "0";

            //if loop that finds zodiac signs between two date parameters 
            if (month == 1 && day >= 20 || month == 2 && day <= 18)
            {
                //picks sign from array and assigns horoscope
                sign = zodiac[10];
                horoscope = "Your ruler is Uranus. Celebrate your magical side this week by listening to" +
                    "\n\"Uranus - the Magician\" by Gustav Holst.";
            }

            else if (month == 2 && day >= 19 || month == 3 && day <= 20)
            {

                sign = zodiac[11];
                horoscope = "Your ruler is Neptune. Spend some time daydreaming this week to songs such as" +
                    "\nGustav Holst's \"Neptune - the Mystic\".";
            }

            else if (month == 3 && day >= 21 || month == 4 && day <= 19)
            {

                sign = zodiac[0];
                horoscope = "Your ruler is Mars. Celebrate your active, assertive, and competitive nature" +
                    "\nthis week by listening to songs such as \"Mars - the Bringer of War\" by Gustav Holst.";
            }

            else if (month == 4 && day >= 20 || month == 5 && day <= 20)
            {

                sign = zodiac[1];
                horoscope = "Your ruler is Venus. This week, celebrate your love of luxury by treating yourself" +
                    "\nto a special gift or a warm bath while listening to" +
                    " songs such as Gustav Holst's \"Venus - the Bringer of Peace\".";
            }

            else if (month == 5 && day >= 21 || month == 6 && day <= 20)
            {

                sign = zodiac[2];
                horoscope = "Your ruler is Mercury. Your greatest asset is your strong sense of communication." +
                    "\nThis week, stike up a conversation with an interesting stranger and listen to" +
                    "\nsongs such as Gustav Holst's \"Mercury - the Winged Messenger\"."; ;
            }

            else if (month == 6 && day >= 21 || month == 7 && day <= 22)
            {

                sign = zodiac[3];
                horoscope = "Your ruler is the moon. If you get overwhelmed by your emotions this week," +
                    "\ntake some time to decompress and listen to songs such as \"Pink Moon\" by Nick Drake.";
            }

            else if (month == 7 && day >= 23 || month == 8 && day <= 22)
            {

                sign = zodiac[4];
                horoscope = "Your ruler is the Sun. Spend some time in the sun this week" +
                    "\nor listen to songs such as \"Here Comes the Sun\" by the Beatles.";
            }

            else if (month == 8 && day >= 23 || month == 9 && day <= 22)
            {

                sign = zodiac[5];
                horoscope = "Your ruler is Mercury. Take a break from overthinking this week, " +
                    "\nand listen to songs such as Gustav Holst's \"Mercury - the Winged Messenger\".";
            }

            else if (month == 9 && day >= 23 || month == 10 && day <= 22)
            {

                sign = zodiac[6];
                horoscope = "Your ruler is Venus. Celebrate your loving nature this week" +
                    "\nby listening to songs such as Gustav Holst's \"Venus - the Bringer of Peace\".";
            }

            else if (month == 10 && day >= 23 || month == 11 && day <= 21)
            {

                sign = zodiac[7];
                horoscope = "Your ruler is Pluto. Soothe any strong emotions this week by listening to" +
                    "\nsongs such as \"Plutonian Nights\" by Sun Ra.";
            }

            else if (month == 11 && day >= 22 || month == 12 && day <= 21)
            {

                sign = zodiac[8];
                horoscope = "Your ruler is Jupiter. Cultivate your good luck this week by listening" +
                    "\nto songs such as \"Jupiter - the Bringer of Jollity\" by Gustav Holst.";
            }

            else if (month == 1 && day <= 19 || month == 12 && day >= 22)
            {
                sign = zodiac[9];
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
