using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatternFirstLesson1
{
   public class StudentVo//vo value object
    {
        private string name;
        private int studentNumber;
        public StudentVo(string name,int studentNumber)
        {
            this.name = name;
            this.studentNumber = studentNumber;
        }
        public void setName(string name)
        {
            this.name = name;

        }

        public string getName()
        {
            return this.name;
        }

        public void setStudentNumber(int studentNumber)
        {
            this.studentNumber = studentNumber;

        }

        public int getStudentNumber()
        {
           return  this.studentNumber;
        }
    }
    public class StudentBO
    {
        List<StudentVo> students;
        public StudentBO()
        {
            students = new List<StudentVo>();
            StudentVo s1 = new StudentVo("ahmed", 1);
            StudentVo s2 = new StudentVo("ali", 2);
            students.Add(s1);
            students.Add(s2);
        }
        public void add(StudentVo newStudent)
        {
            this.students.Add(newStudent);
        }
        public List<StudentVo> getAll()
        {
            return this.students;
        }
        public void deleteStudent(int studentId)
        {
            foreach (var stud in students)
            {

                if (stud.getStudentNumber() == studentId)
                {
                    students.Remove(stud);
                    Console.WriteLine("student number:- " + stud.getStudentNumber() + " student name:- " + stud.getName() + " is deleted");
                    break;
                }
            }
        }

        public void updateStudent(StudentVo StudentData,string newName)
        {
            foreach (var stud in students)
            {
                if(stud.getStudentNumber()== StudentData.getStudentNumber())
                {
                    Console.WriteLine("student number:- " + stud.getStudentNumber() + " student name:- " + stud.getName() + " befor update");
                    stud.setName(newName);
                    Console.WriteLine("student number:- " + stud.getStudentNumber() + " student name:- " + stud.getName() + " After update");
                    break;
                }
            }

        }

        public StudentVo getStudent(int studentNumber)
        {
            foreach (var stud in students)
            {
                if (stud.getStudentNumber() == studentNumber)
                {
                    return stud;
                }
            }
            return new StudentVo("no Name",studentNumber);
        }

        public void display()
        {
            foreach (var stud in students)
            {
                Console.WriteLine("student number:- " + stud.getStudentNumber() + " student name:- " + stud.getName());
            }
        }

        public void displayOneStudent(StudentVo stud)
        {
            Console.WriteLine("student number:- " + stud.getStudentNumber() + " student name:- " + stud.getName());

        }
    }
}
