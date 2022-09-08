using Newtonsoft.Json;
using QuizApplication.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using QuizApplication.Forms;


namespace QuizApplication
{
    public partial class LoginForm : Form
    {

        public List<User> Users;
        public LoginForm()
        {
            InitializeComponent();

            string text = File.ReadAllText(@"E:\AE2OP_OOP\QuizApplication\QuizApplication\Data\Users.json");

            Users = JsonConvert.DeserializeObject<List<User>>(text);
        }

        private void SingIn_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string password = passwordBox.Text;

            var query =
            from user in Users
            where
                (user.Login == login && user.Password == password)            
            select user;

            var checkUser = query.ToList();

            if (checkUser.Count() == 0)
            {
                MessageBox.Show("Invalid login or password. Try Again");
            } else {
                User loggedIn = checkUser.First();
                if (loggedIn.Role == 1)
                {
                    TeacherForm teacherUI = new TeacherForm(loggedIn);
                    teacherUI.Show();
                    this.Hide();
                } else
                {
                    StudentForm studentUI = new StudentForm(loggedIn);
                    studentUI.Show();
                    this.Hide();
                }
            }
        }

    }
}
