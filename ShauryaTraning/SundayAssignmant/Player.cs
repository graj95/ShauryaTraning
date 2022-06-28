using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ShauryaTraning.SundayAssignmant
{
    class Player
    {
        int pid;
        string Name, Country, team;

        public Player(int pid, string name, string country, string team)
        {
            this.pid = pid;
            Name = name;
            Country = country;
            this.team = team;
        }

        public int Pid { get => pid; set => pid = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Country1 { get => Country; set => Country = value; }
        public string Team { get => team; set => team = value; }
    }


    class Demo
    {
        static void Main(string[] args)
        {
            List<Player> t20 = new List<Player>();
            t20.Add(new Player(1, "MSDhoni", "India", "Chennai Super Kings"));


            foreach (Player ob in t20)
            {
                
              Console.WriteLine(ob);
            }

        }
    }
}
