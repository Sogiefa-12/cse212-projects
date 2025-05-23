/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */

using Microsoft.VisualBasic.FileIO;

public class Basketball
{
    public static void Run()
    {
        var players = new Dictionary<string, int>();

        using var reader = new TextFieldParser("C:/Users/user/Desktop/cse212/cse212-projects/week03/teach/basketball.csv");
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        reader.ReadFields(); // ignore header row

        while (!reader.EndOfData) {
            var fields = reader.ReadFields()!;
            var playerId = fields[0];
            var points = int.Parse(fields[8]);

            if (players.ContainsKey(playerId))
            {
                players[playerId] += points;
            }
            else
            {
                players.Add(playerId, points);
            }

        }
        // Sort the players by points in descending order
        var sortedPlayers = players.OrderByDescending(pair => pair.Value).ToList();
        // Get the top 10 players
        var topPlayers = sortedPlayers.Take(10).Select(player => player.Key).ToArray();

       
        // Console.WriteLine($"Players: {{{string.Join(", ", players)}}}");

        Console.WriteLine($"Top 10 Players: {{{string.Join(", ", topPlayers)}}}");
        Console.WriteLine($"Top 10 Players Points: {{{string.Join(", ", topPlayers.Select(player => players[player]))}}}");
        // Print the top 10 players and their points
        Console.WriteLine("Using Map to Display Top 10 Players and their points:");
        foreach (var player in topPlayers)
        {
            Console.WriteLine($"{player}: {players[player]}");
        }
        // Print the total number of players
        Console.WriteLine($"Total number of players: {players.Count}");
        // Print the total number of points
        var totalPoints = players.Values.Sum();
        Console.WriteLine($"Total number of points: {totalPoints}");
        
        
    }
}