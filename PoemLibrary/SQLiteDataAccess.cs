using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Microsoft.Data.Sqlite;
using Dapper;

namespace PoemLibrary
{
    public class SQLiteDataAccess
    {
        public static List<FirstLineModel> LoadFirstLine()
        {
            using (IDbConnection cnn = new SqliteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<FirstLineModel>("Select * from FirstLine", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<SecondLineModel> LoadSecondLine()
        {
            using (IDbConnection cnn2 = new SqliteConnection(LoadConnectionString()))
            {
                var output2 = cnn2.Query<SecondLineModel>("Select * from SecondLine", new DynamicParameters());
                return output2.ToList();
            }
        }
        public static List<ThirdLineModel> LoadThirdLine()
        {
            using (IDbConnection cnn3 = new SqliteConnection(LoadConnectionString()))
            {
                var output3 = cnn3.Query<ThirdLineModel>("Select * from ThirdLine", new DynamicParameters());
                return output3.ToList();
            }
        }


        private static string LoadConnectionString(string id = "Default")
            {
                return ConfigurationManager.ConnectionStrings[id].ConnectionString;
            }
        }
    }

