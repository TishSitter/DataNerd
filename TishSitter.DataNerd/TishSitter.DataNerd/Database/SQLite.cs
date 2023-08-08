using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TishSitter.DataNerd;

namespace TishSitter.DataNerd.Database;

public class DbTools
{
    public static SQLiteConnection CreateConnection()
    {
        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "TishSitter", "DataNerd", "DN_gathered.db");
        if(!File.Exists(dbPath))
        {
            SQLiteConnection.CreateFile(dbPath);
        }
        
        var connectionString = new SQLiteConnectionStringBuilder()
        {
            DataSource = dbPath,
            Version = 3,
            Pooling = true,
            FailIfMissing = true
        }.ConnectionString;
        
        var dbConnection = new SQLiteConnection(connectionString);
        try
        {
            dbConnection.Open();
            
            // Check if Config table exists, if not initialise the database
            SQLiteCommand sqlite_cmd = new SQLiteCommand();
            sqlite_cmd = dbConnection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT name FROM sqlite_master WHERE type='table' AND name='Config'";
            var result = sqlite_cmd.ExecuteScalar();
            if (result == null)
            {
                Initialise(dbConnection);
            }
            
            return dbConnection;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            throw;
        }
    }

    static void CloseConnection(SQLiteConnection conn)
    {
        try
        {
            conn.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            throw;
        }
    }

    private static void Initialise(SQLiteConnection conn)
    {
        SQLiteCommand sqlite_cmd = new SQLiteCommand();
        sqlite_cmd = conn.CreateCommand();
        sqlite_cmd.CommandText =
            "CREATE TABLE Config (SettingKey VARCHAR(20), ValueString VARCHAR(20), ValueInt INT, ValueBool BIT)";
        sqlite_cmd.ExecuteNonQuery();
        
        sqlite_cmd.CommandText = 
                "CREATE TABLE FishLog (Timestamp VARCHAR(20), PositionX FLOAT, PositionY FLOAT, FishType VARCHAR(20), IsStar BIT, Outcome VARCHAR(20))";
        sqlite_cmd.ExecuteNonQuery();
    }
    
    public static void ExecuteNonStandardQuery(SQLiteConnection conn, string query)
    {
        SQLiteCommand sqlite_cmd = new SQLiteCommand();
        sqlite_cmd = conn.CreateCommand();
        sqlite_cmd.CommandText = query;
        sqlite_cmd.ExecuteNonQuery();
    }
}