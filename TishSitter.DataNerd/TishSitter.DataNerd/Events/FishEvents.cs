using System;

namespace TishSitter.DataNerd.Events;

public class FishEvents
{
    public static void LogLootGenerated(string line)
    {
        var fishType = line.Substring(line.IndexOf("=") + 1).Replace(" )", "");
        Console.WriteLine($">> FishAssist: [LOOT GENERATED] {fishType}", ConsoleColor.Cyan);
    }
}