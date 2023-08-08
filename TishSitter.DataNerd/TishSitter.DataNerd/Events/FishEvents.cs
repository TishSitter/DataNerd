using System;
using System.Collections.Concurrent;
using TishSitter.DataNerd.Database;
using TishSitter.DataNerd.Services;

namespace TishSitter.DataNerd.Events;

public class FishEvents
{
    public static void LogLootGenerated(string line, BlockingCollection<DbQueueObj> commandQueue)
    {
        var fishType = line.Substring(line.IndexOf("=") + 1).Replace(" )", "");
        Console.WriteLine($">> FishAssist: [LOOT GENERATED] {fishType}", ConsoleColor.Cyan);
        
        commandQueue.Add(new DbQueueObj
        {
            Timestamp = DateTime.UtcNow,
            ConstructedQuery = $"INSERT INTO FishLog (FishType, Timestamp) VALUES ('{fishType}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')"
        });
    }
}