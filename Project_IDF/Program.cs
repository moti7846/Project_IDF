using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using project_IDF;
using project_IDF.dashboard;
using static project_IDF.dashboard.Command_Dashboard;

namespace Project_IDF
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Menu a = new Menu();
            Strike_Forces data = new Strike_Forces();
            //DisplayForceStatus.Displayer(data);

            a.start();


        }
    }
}
