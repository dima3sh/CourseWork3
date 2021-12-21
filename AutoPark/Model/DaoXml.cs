using AutoPark;
using AutoPark.Properties;
using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Model
{
    public class DaoXml
    {
        private static DaoXml _daoXml;
        private static object _syncRoot = new Object();
        private static string _filePath;
        private static string _defaultPath;
        private static DataBase _dataBase;


        private DaoXml()
        {
            _filePath = @Resources.filePath;
            _defaultPath = @Resources.defaultPath;
            InitializeService();
        }

        public static DataBase GetDataBase()
        {
            if (_daoXml == null)
            {
                lock (_syncRoot)
                {
                    _daoXml = new DaoXml();
                }
            }
            return _dataBase;
        }

        private void InitializeService() 
        {
            XmlSerializer formatter = new XmlSerializer(typeof(DataBase));

            using (Stream fs = new FileStream(_filePath, FileMode.OpenOrCreate))
            {
                _dataBase = fs.Length != 0 ? (DataBase)formatter.Deserialize(fs) 
                                           : InitializeDefaultService();
            }
        }

        private DataBase InitializeDefaultService()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(DataBase));
            DataBase dataBase;

            using (Stream fs = new FileStream(_defaultPath, FileMode.Open))
            {
                dataBase = fs.Length != 0 ? (DataBase)formatter.Deserialize(fs)
                                           : new DataBase();
            }
            return dataBase;
        }

        public static void Save()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(DataBase));

            using (FileStream fs = new FileStream(_filePath, FileMode.Create))
            {
                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    WriteIndented = true
                };            
                formatter.Serialize(fs, _dataBase);                
            }
        }

    }
}
