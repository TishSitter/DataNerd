using System;

namespace TishSitter.DataNerd.Database;

public struct DbQueueObj
{
    public DateTime Timestamp { get; set; }
    public string ConstructedQuery { get; set; }
}