using CC01.BO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CC01.DAL
{
    public class EtudiantDAO
    {
        private static List<Etudiant> etudiants;
        private const string FILE_NAME = @"data/etudiants.json";
        FileInfo file;

        public EtudiantDAO()
        {
          
        file = new FileInfo(FILE_NAME);

            if(!file.Directory.Exists)
            {
                file.Directory.Create();
            }
     
     
            if(file.Exists)
            {
                file.Create().Close();
            }
            if(file.Length > 0)
            {
                using(StreamReader sr= new StreamReader(file.FullName))
                {
                    string Json = sr.ReadToEnd();
                    etudiants = JsonConvert.DeserializeObject<List<Etudiant>>(Json);
                }
               
            }
            else
            {
                if(etudiants == null)
                {
                    etudiants = new List<Etudiant>();
                }
            }
        }
        public void Add(Etudiant etudiant)
        {
            etudiants.Add(etudiant);
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(etudiants);
                sw.WriteLine(json);
            }
        }
        public void Delete(Etudiant etudiant)
        {
            etudiants.Remove(etudiant);
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(etudiants);
                sw.WriteLine(json);
            }
        }
      
    }
}
