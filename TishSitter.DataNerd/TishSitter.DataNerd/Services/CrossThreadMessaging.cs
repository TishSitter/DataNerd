using System;
using TishSitter.DataNerd.Database;

namespace TishSitter.DataNerd.Services;

public class CrossThreadMessaging
{
    public Action<string> MethodToCall { get; set; }
    public DbQueueObj DbQueueObj { get; set; }
}