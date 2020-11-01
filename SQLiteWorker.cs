using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;

namespace ViewBidAskDB
{
    /// <summary>
    /// Класс для работы с БД котировок
    /// </summary>
    class SQLiteWorker
    {
        private static string _DBSECURITY= "ЦБ.db";
        private static string _DBTRADECONNECTIONSTRING { get { return "Data Source=" + _DBSECURITY + ";Version=3;"; } }
        //
        ////переменная для логирования
        //private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //создать если нет БД сделок        
        internal static bool SetDB(string fname, out string errMsg)
        {
            _DBSECURITY = fname;
            errMsg = "";
            return true;
        }

        internal static List<string> DBSelectTickers(out string errMsg)
        {
            errMsg = "";
            List<string> list= new List<string>();
            if (!File.Exists(_DBSECURITY)) //проверка на наличие БД
                return list;

            try
            {
                using (SQLiteConnection connect = new SQLiteConnection(_DBTRADECONNECTIONSTRING))
                {
                    connect.Open();
                    SQLiteCommand m_sqlCmd = new SQLiteCommand("select * from sqlite_master where type = 'table'", connect);
                    using (SQLiteDataReader reader = m_sqlCmd.ExecuteReader())
                    {
                        while (reader.Read())
                            list.Add(reader["tbl_name"].ToString());
                    }
                }
            }
            catch (Exception exc)
            {
                errMsg = exc.Message;
            }
            return list;
        }
        
        internal static List<BidAskData> DBSelectAll(string tblName, out string errMsg)
        {
            errMsg = "";
            if (!File.Exists(_DBSECURITY)) //проверка на наличие БД
                return new List<BidAskData>();

            return _DBSelect("SELECT * FROM '" + tblName + "'", out errMsg);
        }
        private static List<BidAskData> _DBSelect(string commandString, out string errMsg)
        {
            List<BidAskData> list = new List<BidAskData>();
            errMsg = "";
            try
            {
                using (SQLiteConnection connect = new SQLiteConnection(_DBTRADECONNECTIONSTRING))
                {
                    connect.Open();
                    SQLiteCommand m_sqlCmd = new SQLiteCommand(commandString, connect);
                    using (SQLiteDataReader reader = m_sqlCmd.ExecuteReader())
                    {
                        DateTime era = new DateTime(1970, 1, 1, 3, 0, 0);
                        while (reader.Read())
                            list.Add(new BidAskData( era.AddSeconds((long)reader["dt"]), (double)reader["bid"], 
                                (int)(long)reader["bidDepth"], (double)reader["ask"], (int)(long)reader["askDepth"], (double)reader["stepprice"]));
                    }
                }
            }
            catch (Exception exc)
            {
                errMsg = exc.Message;
            }
            return list;
        }
    }
}