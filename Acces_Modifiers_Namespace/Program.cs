using System;

namespace Acces_Modifiers_Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Emilya", "Aghayeva", 20, 98);
            Student st2 = new Student("Gulchin", "Aghayeva", 20, 134);
            Student st3 = new Student("EMil", "Agha", 31, 90);
            Group gr = new Group();
            gr.AddStudent(st1);
            gr.AddStudent(st2);
            gr.AddStudent(st3);
            Console.WriteLine(gr.Sort());
        }
    }

}
