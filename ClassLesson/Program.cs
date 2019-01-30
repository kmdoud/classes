using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLesson
{

    class Program
    {
        static void Main(string[] args)
        {
            var chris = new Student();
            var ken = new Student();
            var kellan = new Student();
            var seth = new Student();
            var irenea = new Student();
            var ben = new Student();
            var sammy = new Student();

            chris.FirstName = "Chris";
            chris.LastName = "Caudill";
            chris.Email = "christophercaudill@gmail.com";
            chris.GPA = 3.9;
            chris.SAT = 1493;
            chris.Phone = "937-716-4027";
            Console.WriteLine(chris.Print());
            Console.WriteLine(chris.Print("New Print Method"));

            var chrisfullname = chris.FullName();

            ken.FirstName = "Kenneth";
            ken.LastName = "Doud";
            ken.Email = "kmdoud@gmail.com";
            ken.Phone = "513-600-3890";
            ken.GPA = 2.5;
            ken.SAT = 1060;
           Console.WriteLine(ken.Print());


            kellan.FirstName = "Kellan";
            kellan.LastName = "Arick";
            kellan.Email = "kellan5015@gmail.com";
            kellan.GPA = 3.8;
            kellan.SAT = 1495;
            kellan.Phone = "330-209-8167";
            Console.WriteLine(kellan.Print());


            seth.FirstName = "Seth";
            seth.LastName = "Phillips";
            seth.Email = "sethphillips042@gmail.com";
            seth.GPA = 2.6;
            seth.SAT = 1496;
            seth.Phone = "513-335-3053";
            Console.WriteLine(seth.Print());

            sammy.FirstName = "Sam";
            sammy.LastName = "Amare";
            sammy.Email = "samrawit.amare@ymail.com";
            sammy.Phone = "513-602-8450";
            sammy.GPA = 3.9;
            sammy.SAT = 1595;
            Console.WriteLine(sammy.Print());


        }
    }
}
