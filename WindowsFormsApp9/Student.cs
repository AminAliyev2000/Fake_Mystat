using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9
{
     public  class Student:User
    {

        public string FullName { get; set; }
        public DateTime LastDate { get; set; }
        public string Attendence { get; set; } = Atendee.None;
        public string ClasskGrade { get; set; }
        public string ExamGrade { get; set; }
        public int Crystals { get; set; } = default;
        public string Comment { get; set; } = default;
        public Student(string fullName, DateTime lastDate, string attendence, string classkGrade, string examGrade, int crystals, string comment)
        {
            FullName = fullName;
            LastDate = lastDate;
            Attendence = attendence;
            ClasskGrade = classkGrade;
            ExamGrade = examGrade;
            Crystals = crystals;
            Comment = comment;
        }

    }
}
