using System;

namespace EndofSeasonPointCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hockey Standings Point Calculator";
            Console.WriteLine("Welcome to the hockey standings point calculator!");
            Console.WriteLine("This calculator will help determine the points a team will have at the end of the season based on the team's current pace");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter the number of wins in current record:");
            double currentWins = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the number of regulation losses in current record:");
            double currentRegulationLosses = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the number of overtime losses in current record:");
            double currentOvertimeLosses = Convert.ToDouble(Console.ReadLine());
            double currentGamesPlayed = currentWins + currentRegulationLosses + currentOvertimeLosses;
            double winPoints = 2;
            double regulationLossPoints = 0;
            double overtimeLossPoints = 1;
            double possiblePointsEarned = currentGamesPlayed * winPoints;
            double actualPointsEarned = (currentWins * winPoints) + (currentRegulationLosses * regulationLossPoints) + (currentOvertimeLosses * overtimeLossPoints);
            double pointsPercentage = actualPointsEarned / possiblePointsEarned;
            Console.WriteLine($"Your team currently has {actualPointsEarned} points after {currentGamesPlayed} games played, giving them a points percentage of {pointsPercentage}");
            Console.WriteLine("Please enter the number of games that will be played this season:");
            double gamesInSeason = Convert.ToDouble(Console.ReadLine());
            double gamesRemaining = gamesInSeason - currentGamesPlayed;
            double maximumPointsRemaining = gamesRemaining * winPoints;
            double pointsForGamesRemaining = Math.Round(maximumPointsRemaining * pointsPercentage);
            double endOfSeasonPoints = pointsForGamesRemaining + actualPointsEarned;
            Console.WriteLine($"Based on your teams current points percentage, your team can expect to finish with {endOfSeasonPoints} points at the end of the season");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please press enter to exit calculator");
            Console.ReadLine();
        }
    }
}
