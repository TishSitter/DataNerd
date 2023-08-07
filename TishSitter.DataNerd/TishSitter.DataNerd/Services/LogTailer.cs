using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using TishSitter.DataNerd.Events;

namespace TishSitter.DataNerd.Services
{
    public class LogTailer
    {
        public bool ThreadRunning { get; set; }
        public bool KillThread { get; set; }
        
        public async void StartThread(string logFilePath)
        {
            try
            {
                KillThread = false;
                Console.WriteLine("Starting LogFile Watcher thread.");
                await Task.Run(() => LogTailerThread(logFilePath));
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
        public void StopThread()
        {
            Console.WriteLine("Stopping LogFile Watcher thread.");
            KillThread = true;
        }
        
        public void LogTailerThread(string logFilePath)
        {
            ThreadRunning = true;
            using (var reader =
                   new StreamReader(new FileStream(logFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
            {
                //start at the end of the file
                long lastMaxOffset = reader.BaseStream.Length;
                Console.WriteLine($"LogFile Watcher initialised. LastMaxOffset: {lastMaxOffset}");
                while (true)
                {
                    if (KillThread)
                    {
                        // kill the thread
                        Console.WriteLine("Killing LogFile Watcher thread.");
                        ThreadRunning = false;
                        return;
                    }

                    //if the file size has not changed, idle
                    if (reader.BaseStream.Length == lastMaxOffset)
                        continue;

                    //seek to the last max offset
                    reader.BaseStream.Seek(lastMaxOffset, SeekOrigin.Begin);

                    //read out of the file until the EOF
                    string? line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        // do shit
                        if (line.Contains("LogValeriaFishing: StartFishingAt"))
                        {
                            FishEvents.LogLootGenerated(line);
                        }

                        // update the last max offset
                        lastMaxOffset = reader.BaseStream.Position;
                    }
                }
            }
        }
    }
}