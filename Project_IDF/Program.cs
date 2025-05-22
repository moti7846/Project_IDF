using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_IDF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hamas a = new Hamas();
            a.set_Trorist("mm", 5);
            a.set_Trorist("yy", 2);
            //a.get_Trorist();
            a.Set_weapaon("mm", "m16");
            a.Set_weapaon("yy", "568a");
            a.Set_weapaon("mm", "m12");
            a.Set_weapaon("yy", "yoyo");
            a.Set_weapaon("mm", "f6");
            a.Set_weapaon("yy", "vbx");
            a.get_weapaon("mm");
            a.get_weapaon("yy");


        }
    }
}
