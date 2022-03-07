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
    public partial class frmManageUsers : Form
    {
        private readonly MusicAppEntities _db = new MusicAppEntities();
        
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            try
            {
                // Populates the grid when the form is loaded
                // Also used to populate grid whenever the Refresh button is clicked 
                PopulateUserGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void PopulateUserGrid()
        {
            var users = _db.Users.Select(q => new
            {
                q.UserID,
                q.Username,
                q.UserRoles.FirstOrDefault().Role.Name,
                q.IsActive
            }).ToList();

            dgvUsers.DataSource = users;
            dgvUsers.Columns["Name"].HeaderText = "Role Name";
            dgvUsers.Columns["IsActive"].HeaderText = "Active";
            dgvUsers.Columns["UserID"].Visible = false;
        }

        // The grid is automatically populated when the form is loaded and when changes are made through the form
        // Refresh button is included so changes made to the database can be seen 
        // However, when a new user is added to the Users table in the database, they are not assigned to a role
        // To ensure these users will be able to login, they must be assigned a role in the UserRole table (match their UserID with a RoleID) 
        // It is "simpler" to add users and assign them roles through the UI (by running the MusicApp program) 
        private void btnRefreshUsers_Click(object sender, EventArgs e)
        {
            PopulateUserGrid(); 
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            // Prevents the  addition of multiple users at once 
            frmAddUser addUser = new frmAddUser(this);
            addUser.ShowDialog();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                // Get Id of selected row 
                int id = (int)dgvUsers.SelectedRows[0].Cells["UserID"].Value;

                // Query database for user 
                var user = _db.Users.FirstOrDefault(q => q.UserID == id);

                string hashed_password = Utils.DefaultHashedPassword();
                user.Password = hashed_password;

                _db.SaveChanges();
                MessageBox.Show($"{user.Username}'s password has successfully been reset.");
                PopulateUserGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure you have selected a row.");
            }
        }

        private void btnDeactivateActivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Get Id of selected row 
                int id = (int)dgvUsers.SelectedRows[0].Cells["UserID"].Value;

                // Query database for user 
                var user = _db.Users.FirstOrDefault(q => q.UserID == id);

                // Deactivate or activate depending on user's current status 
                if (user.IsActive == true)
                {
                    user.IsActive = false;
                }
                else
                {
                    user.IsActive = true;
                }

                _db.SaveChanges();
                MessageBox.Show($"{user.Username}'s status has successfully been changed.");
                PopulateUserGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure you have selected a row.");
            }
        }
    }
}