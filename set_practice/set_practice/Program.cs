using System;

namespace set_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] card1 = {"green","squigle","shaded","1" };
            string[] card2 = { "blue", "diamond", "shaded", "2" };
            string[] card3 = { "red", "pill", "shaded", "3" };
            string[] card4 = { "green", "diamond", "outline", "3" };
            string[] card5 = { "green", "pill", "solid", "3" };
            string[] card6 = { "green", "pill", "shaded", "3" };
            string[] card7 = { "green", "pill", "shaded", "3" };
            string[] card8 = { "green", "diamond", "outline", "2" };
            string[] card9 = { "green", "squigle", "solid", "1" };

            string MatchColor(string[] first, string[] second, string[] third)
            {
                if(first[0] == second[0] && second[0] == third[0])
                {
                    return "all same";
                }if(first[0] == second[0] || second[0] == third[0] || first[0] == third[0])
                {
                    return "neither";
                }
                else
                {
                    return "all unique";
                }
            }

            string MatchShape(string[] first, string[] second, string[] third)
            {
                if (first[1] == second[1] && second[1] == third[1])
                {
                    return "all same";
                }
                if (first[1] == second[1] || second[1] == third[1] || first[1] == third[1])
                {
                    return "neither";
                }
                else
                {
                    return "all unique";
                }
            }
            string MatchFill(string[] first, string[] second, string[] third)
            {
                if (first[2] == second[2] && second[2] == third[2])
                {
                    return "all same";
                }
                if (first[2] == second[2] || second[2] == third[2] || first[2] == third[2])
                {
                    return "neither";
                }
                else
                {
                    return "all unique";
                }
            }
            string MatchNumber(string[] first, string[] second, string[] third)
            {
                if (first[3] == second[3] && second[3] == third[3])
                {
                    return "all same";
                }
                if (first[3] == second[3] || second[3] == third[3] || first[3] == third[3])
                {
                    return "neither";
                }
                else
                {
                    return "all unique";
                }
            }
            bool IsSet(string[] first, string[] second, string[] third)
            {
                int unique = 0;
                int neither = 0;
                int same = 0;

                if (MatchColor(first, second, third) == "all unique") { unique += 1; }
                if (MatchColor(first, second, third) == "neither") { neither += 1; }
                if (MatchColor(first, second, third) == "all same") { same += 1; }
                if (MatchShape(first, second, third) == "all unique") { unique += 1; }
                if (MatchShape(first, second, third) == "neither") { neither += 1; }
                if (MatchShape(first, second, third) == "all same") { same += 1; }
                if (MatchFill(first, second, third) == "all unique") { unique += 1; }
                if (MatchFill(first, second, third) == "neither") { neither += 1; }
                if (MatchFill(first, second, third) == "all same") { same += 1; }
                if (MatchNumber(first, second, third) == "all unique") { unique += 1; }
                if (MatchNumber(first, second, third) == "neither") { neither += 1; }
                if (MatchNumber(first, second, third) == "all same") { same += 1; }

                if(neither == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            Console.WriteLine(IsSet(card1, card2, card3)); // true
            Console.WriteLine(IsSet(card1, card2, card4)); // false
            Console.WriteLine(IsSet(card7, card8, card9)); // true

        }
    }
}
