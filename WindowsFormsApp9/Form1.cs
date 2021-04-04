using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        private readonly List<Student> Students = new List<Student>();
        private string _LessonTxtBxTextHelper = default;
        private readonly int _currentcursor = default;
        private readonly List<UserControl1> UserControls = new List<UserControl1>();
        private bool _isTeacherselected = false;


        private void SetVisibleLesson()
        {
            Lessontxtbox.Visible = true;
            SavelessonBtn.Visible = true;
            IgnoreLessonBtn.Visible = true;
        }
        private void SetInvisibleLesson()
        {
            Lessontxtbox.Visible = false;
            SavelessonBtn.Visible = false;
            IgnoreLessonBtn.Visible = false;
        }


        public Form1()
        {
            InitializeComponent();
            if (File.Exists("Data/Students.json") && File.Exists("Data/Crystals.json"))
            {
                string helper = default;
                JsonReadWrite.JSONDeSerialization(ref Students, "Students.json");
                JsonReadWrite.JSONDeSerialization(ref helper, "Crystals.json");
                CrystalLbl.Text = helper;
            }
            else
            {
               Students.Add(new Student("Zaur Cafarov", DateTime.Now, Atendee.None, "-", "-", 0, ""));
               Students.Add(new Student("Amin Aliyev", DateTime.Now, Atendee.None, "-", "-", 0, ""));
               Students.Add(new Student("Ayxan Axundov", DateTime.Now, Atendee.None, "-", "-", 0, ""));
               Students.Add(new Student("Arifali Bagirli", DateTime.Now, Atendee.None, "-", "-", 0, ""));
            }

            if (File.Exists("Data/Lesson.json"))
            {
                string helper = default;
                JsonReadWrite.JSONDeSerialization(ref helper, "Lesson.json");
                Lessontxtbox.Text = helper;
            }
            _currentcursor = guna2CustomGradientPanel1.Location.Y;
            for(int i = 0; i < Students.Count; i++)
            {
                UserControls.Add(new UserControl1());
                UserControls[i].CrystalLbl = CrystalLbl;
                UserControls[i].FullName = Students[i].FullName;
                UserControls[i].Number = i + 1;
                _currentcursor += 100;
                UserControls[i].Location = new Point(35, _currentcursor);
                UserControls[i].Student = Students[i];
                Controls.Add(UserControls[i]);
            }

        }

        private void MarkAllBtn_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < UserControls.Count; i++)
            {
                UserControls[i].MarkAllBtn_CheckedChanged(sender, e);
            }
        }

        private void Teacherbtn_Click(object sender, EventArgs e)
        {
            //Lessontxtbox.Text=_LessonTxtBxTextHelper;
            //SetVisibleLesson();
            SetVisibleLesson();
            if (_isTeacherselected == false)
            {
                _isTeacherselected = true;
                _LessonTxtBxTextHelper = Lessontxtbox.Text;

            }
            else
            {
                _isTeacherselected = false;
                Lessontxtbox.Text = _LessonTxtBxTextHelper;
            }
            
        }

        private void SavelessonBtn_Click(object sender, EventArgs e)
        {
            _isTeacherselected = false;
        }

        private void IgnoreLessonBtn_Click(object sender, EventArgs e)
        {
            Lessontxtbox.Text = _LessonTxtBxTextHelper;
            _isTeacherselected = false;
        }
    }
}
