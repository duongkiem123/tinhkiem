using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System.IO;
using UnityEngine.Networking;
using System;

namespace GameCore
{
    public class DatabaseManager : MonoBehaviour
    {
        public static DatabaseManager Instance { get; private set; }
        private string dbPath;
        private IDbConnection dbConnection;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
            dbPath = "URI=file:" + Application.persistentDataPath + "/GameDatabase.db";
            InitializeDatabase();
        }

        void InitializeDatabase()
        {
            if (!File.Exists(dbPath))
            {
                string sourcePath = Path.Combine(Application.streamingAssetsPath, "GameDatabase.db");
                if (sourcePath.Contains("://"))
                {
                    UnityWebRequest request = UnityWebRequest.Get(sourcePath);
                    request.SendWebRequest().completed += (operation) =>
                    {
                        if (request.result == UnityWebRequest.Result.Success)
                        {
                            File.WriteAllBytes(dbPath, request.downloadHandler.data);
                            SetupDatabase();
                        }
                        else
                        {
                            Debug.LogError("Lỗi tải database: " + request.error);
                        }
                    };
                }
                else
                {
                    File.Copy(sourcePath, dbPath);
                    SetupDatabase();
                }
            }
            else
            {
                SetupDatabase();
            }
        }

        void SetupDatabase()
        {
            dbConnection = new SqliteConnection(dbPath);
            dbConnection.Open();
            CreateTables();
        }

        void CreateTables()
        {
            using (IDbCommand cmd = dbConnection.CreateCommand())
            {
                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Players (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        playerId TEXT UNIQUE,
                        password TEXT,
                        characterName TEXT UNIQUE,
                        gender INTEGER,
                        faction INTEGER,
                        level INTEGER DEFAULT 1,
                        exp INTEGER DEFAULT 0,
                        hp INTEGER DEFAULT 100,
                        mp INTEGER DEFAULT 50,
                        potentialPoints INTEGER DEFAULT 0,
                        skillPoints INTEGER DEFAULT 0
                    )";
                cmd.ExecuteNonQuery();
            }
        }

        public bool RegisterPlayer(string playerId, string password)
        {
            using (IDbCommand cmd = dbConnection.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Players (playerId, password) VALUES (@playerId, @password)";
                cmd.Parameters.Add(new SqliteParameter("@playerId", playerId));
                cmd.Parameters.Add(new SqliteParameter("@password", password));
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool LoginPlayer(string playerId, string password)
        {
            using (IDbCommand cmd = dbConnection.CreateCommand())
            {
                cmd.CommandText = "SELECT COUNT(*) FROM Players WHERE playerId = @playerId AND password = @password";
                cmd.Parameters.Add(new SqliteParameter("@playerId", playerId));
                cmd.Parameters.Add(new SqliteParameter("@password", password));
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public void SaveCharacter(string playerId, string characterName, int gender, int faction)
        {
            using (IDbCommand cmd = dbConnection.CreateCommand())
            {
                cmd.CommandText = "UPDATE Players SET characterName = @name, gender = @gender, faction = @faction WHERE playerId = @playerId";
                cmd.Parameters.Add(new SqliteParameter("@name", characterName));
                cmd.Parameters.Add(new SqliteParameter("@gender", gender));
                cmd.Parameters.Add(new SqliteParameter("@faction", faction));
                cmd.Parameters.Add(new SqliteParameter("@playerId", playerId));
                cmd.ExecuteNonQuery();
            }
        }
    }
}