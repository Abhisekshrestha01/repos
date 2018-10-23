using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        string fileLocation = @"C:\Demo\test.txt";
        public void Register(int id, string name, int age, long phone)
        {

            using (StreamWriter wr = new StreamWriter(fileLocation, true))
            {

                wr.WriteLine(id + "\t" + name + "\t" + age + "\t" + phone);

            }

        }
        public void CreateFileIfNotExit()
        {
            if (!File.Exists(fileLocation))
            {
                using (StreamWriter wr = new StreamWriter(fileLocation, true))
                {

                    

                }

            }
        }
        public int GreatestId()
        {
            

            using (StreamReader sr = new StreamReader(fileLocation))
            {
                string line;

                List<int> lst1 = new List<int>();
                while ((line = sr.ReadLine()) != null)
                {
                    string[] templst = line.Split('\t');
                    if(int.TryParse(templst[0],out int x))
                    {
                        lst1.Add(x);
                    }


                }
                if (!(lst1.Count() <= 1))
                {
                    return lst1.Max() + 1;
                }
                else
                {
                    return 1;
                }
                
            }
        }
        public void UpdateName(int id, string name)
        {
            string all = File.ReadAllText(fileLocation);
            string t = "";
            FileStream fs = new FileStream(fileLocation, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);

            StreamReader sr = new StreamReader(fs);
            
                string line;
            
                List<string> lst1 = new List<string>();
                while ((line = sr.ReadLine()) != null)
                {
                    string[] templst = line.Split('\t');
                    if (int.Parse(templst[0]) == id)
                    {
                    StreamWriter wr = new StreamWriter(fs);
                    string temp1 = templst[0] + "\t" + templst[1] + "\t" + templst[2] + "\t" + templst[3];
                    string temp = templst[0] + "\t" + name + "\t" + templst[2] + "\t" + templst[3];
                    t = all.Replace(temp1, temp);
                    wr.Flush();

                }

                }
            fs.Close();
            File.WriteAllText(fileLocation,t);


        }
        public void UpdateAge(int id, int age)
        {
            string all = File.ReadAllText(fileLocation);
            string t = "";
            FileStream fs = new FileStream(fileLocation, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);

            StreamReader sr = new StreamReader(fs);

            string line;

            List<string> lst1 = new List<string>();
            while ((line = sr.ReadLine()) != null)
            {
                string[] templst = line.Split('\t');
                if (int.Parse(templst[0]) == id)
                {
                    StreamWriter wr = new StreamWriter(fs);
                    string temp1 = templst[0] + "\t" + templst[1] + "\t" + templst[2] + "\t" + templst[3];
                    string temp = templst[0] + "\t" + templst[1] + "\t" + age.ToString() + "\t" + templst[3];
                    t = all.Replace(temp1, temp);
                    wr.Flush();

                }

            }
            fs.Close();
            File.WriteAllText(fileLocation, t);


        }
        public void Delete(int id)
        {
            string all = File.ReadAllText(fileLocation);
            string t = "";
            FileStream fs = new FileStream(fileLocation, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);

            StreamReader sr = new StreamReader(fs);

            string line;

            List<string> lst1 = new List<string>();
            while ((line = sr.ReadLine()) != null)
            {
                string[] templst = line.Split('\t');
                if (int.Parse(templst[0]) == id)
                {
                    StreamWriter wr = new StreamWriter(fs);
                    string temp1 = templst[0] + "\t" + templst[1] + "\t" + templst[2] + "\t" + templst[3];
                    
                    t = all.Replace(temp1, "");
                    wr.Flush();

                }

            }
            fs.Close();
            File.WriteAllText(fileLocation, t);
        }
        public void UpdatePhone(int id, long phone)
        {
            string all = File.ReadAllText(fileLocation);
            string t = "";
            FileStream fs = new FileStream(fileLocation, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);

            StreamReader sr = new StreamReader(fs);

            string line;

            List<string> lst1 = new List<string>();
            while ((line = sr.ReadLine()) != null)
            {
                string[] templst = line.Split('\t');
                if (int.Parse(templst[0]) == id)
                {
                    StreamWriter wr = new StreamWriter(fs);
                    string temp1 = templst[0] + "\t" + templst[1] + "\t" + templst[2] + "\t" + templst[3];
                    string temp = templst[0] + "\t" + templst[1] + "\t" + templst[2] + "\t" + phone.ToString();
                    t = all.Replace(temp1, temp);
                    wr.Flush();

                }

            }
            fs.Close();
            File.WriteAllText(fileLocation, t);


        }



        public List<string> ViewAll()
        {
            using (StreamReader sr = new StreamReader(fileLocation))
            {
                string line;
                List<string> lst1 = new List<string>();
                while ((line = sr.ReadLine()) != null)
                {
                    lst1.Add(line);
                }
                return lst1;
            }

        }
        public bool Checkid(int id)
        {
            using (StreamReader sr = new StreamReader(fileLocation))
            {
                string line;

                List<string> lst1 = new List<string>();
                while ((line = sr.ReadLine()) != null)
                {
                    string[] templst = line.Split('\t');
                    if (int.Parse(templst[0]) == id)
                    {
                        return true;
                    }

                }
                return false;
            }



        }
        public string ViewDetail(int id)
        {
            using (StreamReader sr = new StreamReader(fileLocation))
            {

                string line;

                List<string> lst1 = new List<string>();
                while ((line = sr.ReadLine()) != null)
                {
                    string[] templst = line.Split('\t');
                    if (int.Parse(templst[0]) == id)
                    {
                        return line;
                    }

                }
                return null;
            }
        }

    }
}

