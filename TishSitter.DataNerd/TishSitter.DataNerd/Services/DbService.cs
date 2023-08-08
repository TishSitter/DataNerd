using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Threading.Tasks;
using TishSitter.DataNerd.Database;
using TishSitter.DataNerd.Events;

namespace TishSitter.DataNerd.Services;

public delegate void Enqueue(DbQueueObj qObj);

public class DbService
{
    public bool ThreadRunning { get; set; }
    private bool KillThread { get; set; }
    private SQLiteConnection Db { get; set; }
    private Queue<DbQueueObj> DbQueue = new Queue<DbQueueObj>();
    
    private BlockingCollection<DbQueueObj> commandQueue;

    public async void StartThread(BlockingCollection<DbQueueObj> commandQueue)
    {
        try
        {
            KillThread = false;
            Console.WriteLine("Starting DB Service.");
            this.commandQueue = commandQueue;
            Db = DbTools.CreateConnection();
            await Task.Run(DbServiceThread);
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public async void StopThread()
    {
        Console.WriteLine("Stopping DB Service.");
        KillThread = true;
        while(ThreadRunning)
        {
            await Task.Delay(500);
        }

        return;
    }
    
    private void EnqueueQuery(DbQueueObj qObj)
    {
        DbQueue.Enqueue(qObj);
    }
    
    private void DbServiceThread()
    {
        ThreadRunning = true;
        while (!KillThread)
        {
            if (commandQueue.Count > 0)
            {
                var qObj = commandQueue.Take();
                Console.WriteLine($"Retrieved query from queue.: {qObj.ConstructedQuery}");
                DbTools.ExecuteNonStandardQuery(Db, qObj.ConstructedQuery);
            }
            else
            {
                Task.Delay(5000).Wait();
            }
        }
        // kill the thread
        Console.WriteLine("Killing DB Service.");
        ThreadRunning = false;
        return;
    }
}