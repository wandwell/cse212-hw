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

using System.Security;
using Microsoft.VisualBasic.FileIO;

public class Basketball
{
    public static void Run()
    {
        var players = new Dictionary<string, int>();

        using var reader = new TextFieldParser("basketball.csv");
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        reader.ReadFields(); // ignore header row
        while (!reader.EndOfData)
        {
            var fields = reader.ReadFields()!;
            var playerId = fields[0];
            var points = int.Parse(fields[8]);

            if (!players.ContainsKey(playerId))
            {
                players.Add(playerId, points);
            }
            else
            {
                var total = players[playerId] + points;
                players[playerId] = total;
            }
        }

        var playersArray = players.ToArray();
        Array.Sort(playersArray, (p1, p2) => p2.Value - p1.Value);

        Console.WriteLine();

        var topPlayers = new string[10];
        for (var i = 0; i < 10; i++)
        {
            Console.WriteLine(playersArray[i]);
        }
    }

    private static object KeyValuePair<T1, T2>()
    {
        throw new NotImplementedException();
    }
}