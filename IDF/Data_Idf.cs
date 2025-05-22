using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_IDF.IDF
{
    internal class Data_Idf
    {

         public Dictionary<string, List<Weapon>> Database = new Dictionary<string, List<Weapon>>();

          
        public void AddNewWeapon(Weapon newWeaP)
        {
            if (!Database.ContainsKey(newWeaP.Name))
            {
                Database[newWeaP.Name] = new List<Weapon>();
            }
             Database[newWeaP.Name].Add(newWeaP);

            Console.WriteLine("ok");
        }
   

       






    }
}
