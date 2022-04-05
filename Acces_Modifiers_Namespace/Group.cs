using System;

namespace Acces_Modifiers_Namespace
{
    class Group 
    {
        public static int _no;
        public int No { get { return _no; } }
        int count = 0;
        public Group()
        {
            _no++;
            count = _no;
        }
        Student[] stud = new Student[] { };
        public void AddStudent(Student student)
        {
            Array.Resize(ref stud, stud.Length + 1);
            stud[stud.Length - 1] = student;
        }
        public Student[] GetAllStudent()
        {
            return stud;
        }
        public Student[] Sort()
        {
            for (int i = 0; i < stud.Length; i++)
            {
                int min = stud[i].Point;
                for (int j = i + 1; j < stud.Length; j++)
                {
                    if (stud[i].Point > stud[j].Point)
                    {
                        stud[i] = stud[j];
                        min = stud[j].Point;
                    }
                }
            }
            return stud;
        }
    }
}
