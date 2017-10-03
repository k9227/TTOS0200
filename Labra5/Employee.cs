using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra5
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        public Employee()
        {
        }

        public Employee(string name,string profession,int salary)
        {
            Name = name;
            Profession = profession;
            Salary = salary;
        }
    }
    class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }

        public Boss(string name, string profession, int salary,string car,int bonus)
            : base(name,profession,salary)
        {
            Car = car;
            Bonus = bonus;
        }
    }

    public class Tehtava4
    {
        public static void TestTehtava4()
        { 
            Employee duunari = new Employee("Pertti","Ryämiäs",2000);
            Boss pomo = new Boss("Keke", "Johtaja", 2000,"Mersu",500);
            Console.WriteLine(duunari.Name + " " + duunari.Profession + " " + duunari.Salary);
            Console.WriteLine(pomo.Name + " " + pomo.Profession + " " + pomo.Salary + " " + pomo.Car + " " + pomo.Bonus);
            duunari.Profession = "duunari";
            duunari.Salary = 1500;
            pomo.Car = "Porsche";
            pomo.Bonus = 1000;

            Console.WriteLine(duunari.Name +" "+ duunari.Profession + " " + duunari.Salary);
            Console.WriteLine(pomo.Name + " " + pomo.Profession + " " + pomo.Salary + " " + pomo.Car + " " + pomo.Bonus);
        }
    }
}
