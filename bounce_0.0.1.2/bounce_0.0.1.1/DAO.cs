using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace bounce_0._0._1._1
{
    class DAO
    {
        string location;
        List<string[]> DataBase;

        public DAO(string path)
        {
            location = path;
            Init();
        }

        void Init()
        {
            try
            {
                DataBase = new List<string[]>();
                StreamReader basecapture = new StreamReader(location);
                while (!basecapture.EndOfStream)
                {
                    DataBase.Add(basecapture.ReadLine().Split('~'));
                }
                basecapture.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool Login(string login, string password)
        {
            if (DataBase.Count > 0)
            {
                foreach (var record in DataBase)
                {
                    if (login == record[0] & password == record[1])
                        return true;
                }  
            }
            return false;
        }


        public void Register(string login, string password)
        {
            bool exist = false,iswrite=false;
            if(DataBase.Count>0)
            {

                foreach (var userwrite in DataBase)
                {
                    if (userwrite[0] == login)
                        exist = true;
                }
                if (!exist)
                {
                    string[] t = { login, password };
                    DataBase.Add(t);
                    iswrite = true;
                }
            }
            else
            {
                string[] t = new string[2]{ login, password };
                DataBase.Add(t);
                iswrite = true;
            }

            if(iswrite)
            {
            StreamWriter writeProceed = new StreamWriter(location);
            foreach (var record in DataBase)
            {
                writeProceed.WriteLine(String.Concat(record[0], "~", record[1]));
            }
                writeProceed.Close();
            }
            Init();
        }

    }
}
