using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class MainWindow : Form
    {
        private frmLogin _frmLogin;
        public User _user;
        public string _roleName;

        public MainWindow(frmLogin login, User user)
        {
            InitializeComponent();
            _frmLogin = login;
            _user = user; 
            _roleName = user.UserRoles.FirstOrDefault().Role.ShortName;
        }
        
        private void manageGenresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check to see if an instance of frmManageGenres is already open 
            // if form !open, create a new instance and show 
            if (!Utils.FormIsOpen("frmManageGenres"))
            {
                frmManageGenres manageGenres = new frmManageGenres();
                manageGenres.MdiParent = this;
                manageGenres.Show();
            }
        }

        private void manageSongsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("frmManageSongs"))
            {
                frmManageSongs manageSongs = new frmManageSongs();
                manageSongs.MdiParent = this;
                manageSongs.Show();
            }
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("frmManageUsers"))
            {
                frmManageUsers manageUsers = new frmManageUsers();
                manageUsers.MdiParent = this;
                manageUsers.Show();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // If a user has the default password, they need to change it 
            if (_user.Password == Utils.DefaultHashedPassword())
            {
                frmResetPassword resetPassword = new frmResetPassword(_user);
                this.Hide();
                _frmLogin.Hide(); 
                resetPassword.ShowDialog();
                this.Show(); 
            }

            // Shows which user is logged in 
            string username = _user.Username;
            toolStripStatusLabelMainWindow.Text = $"Logged In As: {username}";

            // Prevents non-admin users from managing users 
            if (_roleName != "admin")
            {
                manageUsersToolStripMenuItem.Visible = false;
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frmLogin.Close();
        }
    }
}