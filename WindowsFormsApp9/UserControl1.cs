using Guna.UI2.WinForms;
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
    public partial class UserControl1 : UserControl
    {

        public Guna2CustomRadioButton HereRdBtn { get => Herebutton; }
        public Guna2CustomRadioButton LateRdBtn { get => Latebutton; }
        public Guna2CustomRadioButton AbsentRdBtn { get => Absentbutton; }
        public Guna2ComboBox ExamGradeCmbBx { get => ExamGradeCmbbox; }
        public Guna2ComboBox ClassGradeCmbBx { get => ClassGredeCmbbox; }
        public Guna2TextBox CommentTxtBx { get => Commenttxtbox; }
        public int Crystals
        {
            get
            {
                if (DiamondPictureBox3.ImageLocation == "../../Resources/diamond.png")
                    return 3;
                else if (DiamondPictureBox2.ImageLocation == "../../Resources/diamond.png")
                    return 2;
                else if (DiamondPictureBox1.ImageLocation == "../../Resources/diamond.png")
                    return 1;
                return 0;
            }
        }

        //private string _pictureBox;
        private string _commentsTxtBxTextHelper = default;
        private int _numberHolder = default;
        private readonly List<string> gradesClassWork = new List<string>();
        private readonly List<string> gradesExamWork = new List<string>();
        private Student _student = default;
        public Student Student
        {
            get => _student;
            set
            {
                if (value != null && File.Exists("Data/Students.json") && File.Exists("Data/Crystals.json"))
                {
                    _student = value;
                    // SetPropertiesFromFile();
                }
            }
        }
        private int _number;
        public int Number
        {
            get { return _number; }
            set { _number = value; numberlbl.Text = value.ToString(); }
        }
        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; fullnamelbl.Text = value; }
        }
        public Guna2HtmlLabel CrystalLbl { get; set; }
        public void SetVisibleComment()
        {
            Commentpcrbox.Visible = true;
            Commentsavebtn.Visible = false;
            CommentIgnorebtn.Visible = false;
            Commenttxtbox.Visible = false;
        }
        public void SetInvisibleComment()
        {
            Commentpcrbox.Visible = false;
            Commentsavebtn.Visible = true;
            CommentIgnorebtn.Visible = true;
            Commenttxtbox.Visible = true;
        }
        public void SetDiamondImage(Guna2PictureBox pictureBox, string image)
        {
            pictureBox.Image = new Bitmap(image);

            if (image == "../../Resources/diamond.png")
                pictureBox.ImageLocation = "../../Resources/diamond.png";
            else
                pictureBox.ImageLocation = default;
        }
        public void SetCrystalNumber()
        {
            if (DiamondPictureBox1.ImageLocation == "../../Resources/diamond.png")
                CrystalLbl.Text = (int.Parse(CrystalLbl.Text) + 1).ToString();
            if (DiamondPictureBox2.ImageLocation == "../../Resources/diamond.png")
                CrystalLbl.Text = (int.Parse(CrystalLbl.Text) + 1).ToString();
            if (DiamondPictureBox3.ImageLocation == "../../Resources/diamond.png")
                CrystalLbl.Text = (int.Parse(CrystalLbl.Text) + 1).ToString();
        }
        public void ChangeToolsState(bool flag)
        {
            ExamGradeCmbbox.Enabled = flag;
            ClassGredeCmbbox.Enabled = flag;
            DiamondPictureBox1.Enabled = flag;
            DiamondPictureBox2.Enabled = flag;
            DiamondPictureBox3.Enabled = flag;
            guna2PictureBox4.Enabled = flag;
        }
        private void SetData()
        {
            if (_student.Attendence == Atendee.Here)
            {
                Herebutton.Checked = true;
            }
            else if (_student.Attendence == Atendee.Late)
            {
                Latebutton.Checked = true;
            }
            else if (_student.Attendence == Atendee.Absent)
            {
                Absentbutton.Checked = true;
            }
            ClassGredeCmbbox.Text = _student.ClasskGrade;
            ExamGradeCmbbox.Text = _student.ExamGrade;
            if (_student.Crystals >= 1)
            {
                SetDiamondImage(DiamondPictureBox1, "../../Resources/diamond.png");

            }
            if (_student.Crystals >=2)
            {
                SetDiamondImage(DiamondPictureBox2, "../../Resources/diamond.png");

            }
            if (_student.Crystals >= 3)
            {
                SetDiamondImage(DiamondPictureBox3, "../../Resources/diamond.png");

            }
            _numberHolder = _student.Crystals;
            if (!string.IsNullOrWhiteSpace(_student.Comment))
            {
                Commenttxtbox.Text = _student.Comment;
            }

        }
        public UserControl1()
        {
            InitializeComponent();
            JsonReadWrite.JSONDeSerialization(ref gradesClassWork, "Grade.json");
            ClassGradeCmbBx.DataSource = gradesClassWork;
            ClassGradeCmbBx.DropDownStyle = ComboBoxStyle.DropDown;
            JsonReadWrite.JSONDeSerialization(ref gradesExamWork, "Grade.json");
            ExamGradeCmbbox.DataSource = gradesExamWork;
            ExamGradeCmbbox.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void Commentpcrbox_Click(object sender, EventArgs e)
        {
            SetInvisibleComment();
            _commentsTxtBxTextHelper = Commenttxtbox.Text;
        }

        private void Commentsavebtn_Click(object sender, EventArgs e)
        {
            SetVisibleComment();

        }

        private void CommentIgnorebtn_Click(object sender, EventArgs e)
        {
            SetVisibleComment();
            Commenttxtbox.Text = _commentsTxtBxTextHelper;
        }

        private void DiamondPictureBox1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CrystalLbl.Text, out int result) && result + _numberHolder - 1 >= 0)
            {
                SetCrystalNumber();

                SetDiamondImage(DiamondPictureBox1, "../../Resources/diamond.png");
                SetDiamondImage(DiamondPictureBox2, "../../Resources/empty.png");
                SetDiamondImage(DiamondPictureBox3, "../../Resources/empty.png");

                CrystalLbl.Text = (int.Parse(CrystalLbl.Text) - 1).ToString();
                _numberHolder = 1;
            }
        }

        private void DiamondPictureBox2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CrystalLbl.Text, out int result) && result + _numberHolder - 1 >= 0)
            {
                SetCrystalNumber();

                SetDiamondImage(DiamondPictureBox1, "../../Resources/diamond.png");
                SetDiamondImage(DiamondPictureBox2, "../../Resources/diamond.png");
                SetDiamondImage(DiamondPictureBox3, "../../Resources/empty.png");

                CrystalLbl.Text = (int.Parse(CrystalLbl.Text) - 2).ToString();
                _numberHolder = 2;

            }
        }
        private void DiamondPictureBox3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CrystalLbl.Text, out int result) && result + _numberHolder - 1 >= 0)
            {
                SetCrystalNumber();

                SetDiamondImage(DiamondPictureBox1, "../../Resources/diamond.png");
                SetDiamondImage(DiamondPictureBox2, "../../Resources/diamond.png");
                SetDiamondImage(DiamondPictureBox3, "../../Resources/diamond.png");

                CrystalLbl.Text = (int.Parse(CrystalLbl.Text) - 3).ToString();
                _numberHolder = 3;
            }
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            if (DiamondPictureBox1.ImageLocation == "../../Resources/diamond.png")
            {
                SetCrystalNumber();

                SetDiamondImage(DiamondPictureBox1, "../../Resources/empty.png");
                SetDiamondImage(DiamondPictureBox2, "../../Resources/empty.png");
                SetDiamondImage(DiamondPictureBox3, "../../Resources/empty.png");

                _numberHolder = default;
            }
        }
        public void MarkAllBtn_CheckedChanged(object sender, EventArgs e)
        {
            Herebutton.Checked = true;
        }
        private void Herebutton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeToolsState(true);
        }

        private void Latebutton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeToolsState(true);
        }

        private void Absentbutton_CheckedChanged(object sender, EventArgs e)
        {
            ClassGredeCmbbox.SelectedIndex = 0;
            ExamGradeCmbbox.SelectedIndex = 0;
            SetCrystalNumber();
            SetDiamondImage(DiamondPictureBox1, "../../Resources/empty.png");
            SetDiamondImage(DiamondPictureBox2, "../../Resources/empty.png");
            SetDiamondImage(DiamondPictureBox3, "../../Resources/empty.png");
            ChangeToolsState(false);
        }
    }
}

