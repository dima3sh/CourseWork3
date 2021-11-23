
using AutoPark;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bar
{
    public class DaoXml
    {
        private static DaoXml _daoXml;
        private static object _syncRoot = new Object();
        private static string _filePath;
        private static DataBase _dataBase;


        private DaoXml()
        {
            _filePath = @"D:\\note.xml";
            InitializeServiceAsync();
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

        private void InitializeServiceAsync()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(DataBase));

            using (Stream fs = new FileStream(_filePath, FileMode.OpenOrCreate))
            {
                _dataBase = fs.Length != 0 ? (DataBase)formatter.Deserialize(fs) : new DataBase();
            }
        }

        public static void saveAsync()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(DataBase));

            using (FileStream fs = new FileStream(_filePath, FileMode.Create))
            {
                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    WriteIndented = true
                };            
                formatter.Serialize(fs, _dataBase);
                //formatter.Serialize(fs, DataBase);
            }
        }

    }
}
