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
    public partial class frmAddUser : Form
    {
        private readonly MusicAppEntities _db = new MusicAppEntities();
        private frmManageUsers _frmManageUsers;

        public frmAddUser(frmManageUsers frmManageUsers)
        {
            InitializeComponent();
            _frmManageUsers = frmManageUsers;
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            // Query database 
            var roles = _db.Roles.ToList();

            // Fill combo box / dropdown with list of roles from database 
            cboRoles.DataSource = roles;
            cboRoles.ValueMember = "RoleID";
            cboRoles.DisplayMember = "Name";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Create new user 
                string username = txtUsername.Text;
                int roleId = (int)cboRoles.SelectedValue;
                string password = Utils.DefaultHashedPassword();

                User user = new User
                {
                    Username = username,
                    Password = password,
                    IsActive = true
                };

                _db.Users.Add(user);
                _db.SaveChanges();

                // Fetch UserID 
                int userId = user.UserID;

                // Assign user to their selected role 
                UserRole userRole = new UserRole
                {
                    RoleID = roleId,
                    UserID = userId
                };

                _db.UserRoles.Add(userRole);
                _db.SaveChanges();

                MessageBox.Show("New user successfully added.");
                _frmManageUsers.PopulateUserGrid();
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured. Please try again.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}