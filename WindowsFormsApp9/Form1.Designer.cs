
namespace WindowsFormsApp9
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Groupnamelbl = new System.Windows.Forms.Label();
            this.MainTeacherbtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.AnotherTeacherBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Lessontxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SavelessonBtn = new Guna.UI2.WinForms.Guna2Button();
            this.IgnoreLessonBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.CrystalLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.MarkAllBtn = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Groupnamelbl
            // 
            this.Groupnamelbl.AutoSize = true;
            this.Groupnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Groupnamelbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Groupnamelbl.Location = new System.Drawing.Point(12, 33);
            this.Groupnamelbl.Name = "Groupnamelbl";
            this.Groupnamelbl.Size = new System.Drawing.Size(171, 31);
            this.Groupnamelbl.TabIndex = 0;
            this.Groupnamelbl.Text = "FDSA_3914";
            // 
            // MainTeacherbtn
            // 
            this.MainTeacherbtn.AutoSize = true;
            this.MainTeacherbtn.CheckedState.BorderColor = System.Drawing.Color.Teal;
            this.MainTeacherbtn.CheckedState.BorderThickness = 0;
            this.MainTeacherbtn.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.MainTeacherbtn.CheckedState.InnerColor = System.Drawing.Color.Teal;
            this.MainTeacherbtn.CheckedState.InnerOffset = -4;
            this.MainTeacherbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.MainTeacherbtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MainTeacherbtn.Location = new System.Drawing.Point(18, 111);
            this.MainTeacherbtn.Name = "MainTeacherbtn";
            this.MainTeacherbtn.Size = new System.Drawing.Size(121, 20);
            this.MainTeacherbtn.TabIndex = 1;
            this.MainTeacherbtn.Text = "Main Teacher";
            this.MainTeacherbtn.UncheckedState.BorderColor = System.Drawing.Color.Teal;
            this.MainTeacherbtn.UncheckedState.BorderThickness = 2;
            this.MainTeacherbtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.MainTeacherbtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.MainTeacherbtn.Click += new System.EventHandler(this.Teacherbtn_Click);
            // 
            // AnotherTeacherBtn
            // 
            this.AnotherTeacherBtn.AutoSize = true;
            this.AnotherTeacherBtn.CheckedState.BorderColor = System.Drawing.Color.Teal;
            this.AnotherTeacherBtn.CheckedState.BorderThickness = 0;
            this.AnotherTeacherBtn.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.AnotherTeacherBtn.CheckedState.InnerColor = System.Drawing.Color.Teal;
            this.AnotherTeacherBtn.CheckedState.InnerOffset = -4;
            this.AnotherTeacherBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.AnotherTeacherBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AnotherTeacherBtn.Location = new System.Drawing.Point(145, 111);
            this.AnotherTeacherBtn.Name = "AnotherTeacherBtn";
            this.AnotherTeacherBtn.Size = new System.Drawing.Size(141, 20);
            this.AnotherTeacherBtn.TabIndex = 2;
            this.AnotherTeacherBtn.Text = "Another Teacher";
            this.AnotherTeacherBtn.UncheckedState.BorderColor = System.Drawing.Color.Teal;
            this.AnotherTeacherBtn.UncheckedState.BorderThickness = 2;
            this.AnotherTeacherBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.AnotherTeacherBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.AnotherTeacherBtn.Click += new System.EventHandler(this.Teacherbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(799, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lesson";
            // 
            // Lessontxtbox
            // 
            this.Lessontxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Lessontxtbox.DefaultText = "";
            this.Lessontxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Lessontxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Lessontxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Lessontxtbox.DisabledState.Parent = this.Lessontxtbox;
            this.Lessontxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Lessontxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Lessontxtbox.FocusedState.Parent = this.Lessontxtbox;
            this.Lessontxtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Lessontxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Lessontxtbox.HoverState.Parent = this.Lessontxtbox;
            this.Lessontxtbox.Location = new System.Drawing.Point(805, 67);
            this.Lessontxtbox.Name = "Lessontxtbox";
            this.Lessontxtbox.PasswordChar = '\0';
            this.Lessontxtbox.PlaceholderText = "";
            this.Lessontxtbox.SelectedText = "";
            this.Lessontxtbox.ShadowDecoration.Parent = this.Lessontxtbox;
            this.Lessontxtbox.Size = new System.Drawing.Size(180, 64);
            this.Lessontxtbox.TabIndex = 4;
            // 
            // SavelessonBtn
            // 
            this.SavelessonBtn.CheckedState.Parent = this.SavelessonBtn;
            this.SavelessonBtn.CustomImages.Parent = this.SavelessonBtn;
            this.SavelessonBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.SavelessonBtn.ForeColor = System.Drawing.Color.White;
            this.SavelessonBtn.HoverState.Parent = this.SavelessonBtn;
            this.SavelessonBtn.Location = new System.Drawing.Point(805, 138);
            this.SavelessonBtn.Name = "SavelessonBtn";
            this.SavelessonBtn.ShadowDecoration.Parent = this.SavelessonBtn;
            this.SavelessonBtn.Size = new System.Drawing.Size(87, 32);
            this.SavelessonBtn.TabIndex = 5;
            this.SavelessonBtn.Text = "Save";
            this.SavelessonBtn.Click += new System.EventHandler(this.SavelessonBtn_Click);
            // 
            // IgnoreLessonBtn
            // 
            this.IgnoreLessonBtn.CheckedState.Parent = this.IgnoreLessonBtn;
            this.IgnoreLessonBtn.CustomImages.Parent = this.IgnoreLessonBtn;
            this.IgnoreLessonBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.IgnoreLessonBtn.ForeColor = System.Drawing.Color.White;
            this.IgnoreLessonBtn.HoverState.Parent = this.IgnoreLessonBtn;
            this.IgnoreLessonBtn.Location = new System.Drawing.Point(898, 138);
            this.IgnoreLessonBtn.Name = "IgnoreLessonBtn";
            this.IgnoreLessonBtn.ShadowDecoration.Parent = this.IgnoreLessonBtn;
            this.IgnoreLessonBtn.Size = new System.Drawing.Size(87, 32);
            this.IgnoreLessonBtn.TabIndex = 6;
            this.IgnoreLessonBtn.Text = "Ignore";
            this.IgnoreLessonBtn.Click += new System.EventHandler(this.IgnoreLessonBtn_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.CrystalLbl);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2CustomGradientPanel1.Controls.Add(this.MarkAllBtn);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(12, 174);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1104, 87);
            this.guna2CustomGradientPanel1.TabIndex = 7;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::WindowsFormsApp9.Properties.Resources.diamond;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(843, 15);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(24, 29);
            this.guna2CirclePictureBox1.TabIndex = 8;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // CrystalLbl
            // 
            this.CrystalLbl.BackColor = System.Drawing.Color.Transparent;
            this.CrystalLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrystalLbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CrystalLbl.Location = new System.Drawing.Point(826, 15);
            this.CrystalLbl.Name = "CrystalLbl";
            this.CrystalLbl.Size = new System.Drawing.Size(11, 21);
            this.CrystalLbl.TabIndex = 7;
            this.CrystalLbl.Text = "5";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(938, 15);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(67, 21);
            this.guna2HtmlLabel6.TabIndex = 6;
            this.guna2HtmlLabel6.Text = "Comment";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(643, 15);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(83, 21);
            this.guna2HtmlLabel5.TabIndex = 5;
            this.guna2HtmlLabel5.Text = "Exam Work";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(538, 15);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(82, 21);
            this.guna2HtmlLabel4.TabIndex = 4;
            this.guna2HtmlLabel4.Text = "Class Work";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(390, 15);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(65, 21);
            this.guna2HtmlLabel3.TabIndex = 3;
            this.guna2HtmlLabel3.Text = "Mark All";
            // 
            // MarkAllBtn
            // 
            this.MarkAllBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MarkAllBtn.CheckedState.BorderThickness = 0;
            this.MarkAllBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.MarkAllBtn.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MarkAllBtn.CheckedState.InnerOffset = -5;
            this.MarkAllBtn.CheckedState.Parent = this.MarkAllBtn;
            this.MarkAllBtn.Location = new System.Drawing.Point(414, 38);
            this.MarkAllBtn.Name = "MarkAllBtn";
            this.MarkAllBtn.ShadowDecoration.Parent = this.MarkAllBtn;
            this.MarkAllBtn.Size = new System.Drawing.Size(20, 20);
            this.MarkAllBtn.TabIndex = 2;
            this.MarkAllBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MarkAllBtn.UncheckedState.BorderThickness = 2;
            this.MarkAllBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.MarkAllBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.MarkAllBtn.UncheckedState.Parent = this.MarkAllBtn;
            this.MarkAllBtn.CheckedChanged += new System.EventHandler(this.MarkAllBtn_CheckedChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(235, 15);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(81, 21);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Last visited";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(87, 15);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(106, 21);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Name,Surname";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 450);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.IgnoreLessonBtn);
            this.Controls.Add(this.SavelessonBtn);
            this.Controls.Add(this.Lessontxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnotherTeacherBtn);
            this.Controls.Add(this.MainTeacherbtn);
            this.Controls.Add(this.Groupnamelbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Groupnamelbl;
        private Guna.UI2.WinForms.Guna2RadioButton MainTeacherbtn;
        private Guna.UI2.WinForms.Guna2RadioButton AnotherTeacherBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox Lessontxtbox;
        private Guna.UI2.WinForms.Guna2Button SavelessonBtn;
        private Guna.UI2.WinForms.Guna2Button IgnoreLessonBtn;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton MarkAllBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel CrystalLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}

