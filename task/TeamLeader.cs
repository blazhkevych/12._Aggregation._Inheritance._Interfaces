using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    // Руководитель бригады.
    internal class TeamLeader : IWorker
    {
        String name;
        int age;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void GetName()
        {
            Console.WriteLine($"Имя: {name}\nВозраст: {age}");
        }

        public void WriteReport(Team team)
        {
            Console.WriteLine("ОТЧЕТ:");
            team.Write();
        }
    }
}
