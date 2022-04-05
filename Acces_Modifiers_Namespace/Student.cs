using System;

namespace Acces_Modifiers_Namespace
{
    class Student
    {
        public string Name;
        public string Surname;
        public int Point;
        public int Age;
        private static int _id;
        public int Id { get { return _id; } }
        int count = 0;
        
        public Student(string name, string surname, int age, int point)
        {
            _id++;
            count = _id;
            Name = name;
            Surname = surname;
            Age = age;
            Point = point;
        }
        public string ShowInfo()
        {
            return $"{Name} {Surname} {Point}";
        }
       
    }
}
