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
    public partial class frmManageGenres : Form
    {
        private readonly MusicAppEntities _db = new MusicAppEntities(); 
        
        public frmManageGenres()
        {
            InitializeComponent();
        }

        private void frmManageGenres_Load(object sender, EventArgs e)
        {
            try
            {
                // Populates the grid when the form is loaded
                // Also used to populate grid whenever the Refresh button is clicked 
                PopulateGenreGrid(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void PopulateGenreGrid()  // Notice public access modifier 
        {
            // Use LINQ to query database and define aliases  
            // Notice use of lambda expression 
            var genres = _db.Genres.Select(q => new
            {
                q.GenreName,
                q.GenreID
            }).ToList();

            dgvGenreList.DataSource = genres;
            dgvGenreList.Columns["GenreName"].HeaderText = "Name";  // Changes column name 
            dgvGenreList.Columns["GenreID"].Visible = false;  // Hides ID column 
        }

        // The grid is automatically populated when the form is loaded and when changes are made through the form
        // Refresh button is included so changes made to the database can be seen 
        private void btnRefreshGenreList_Click(object sender, EventArgs e)
        {
            PopulateGenreGrid(); 
        }

        private void btnAddNewGenre_Click(object sender, EventArgs e)
        {
            // Prevents user from adding/editing on multiple forms at once
            frmAddEditGenre addGenre = new frmAddEditGenre(this);
            addGenre.ShowDialog();
        }

        private void btnEditGenre_Click(object sender, EventArgs e)
        {
            try
            {
                // Get ID of selected row 
                int id = (int)dgvGenreList.SelectedRows[0].Cells["GenreID"].Value;

                // Query database for genre 
                var genre = _db.Genres.FirstOrDefault(q => q.GenreID == id);

                // Launch AddEditGenre window with data 
                // Prevents user from adding/editing on multiple forms at once
                frmAddEditGenre editGenre = new frmAddEditGenre(genre, this);
                editGenre.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure you have selected a row.");
            }
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            try
            {
                // Get ID of selected row 
                int id = (int)dgvGenreList.SelectedRows[0].Cells["GenreID"].Value;

                // Query database for genre 
                var genre = _db.Genres.FirstOrDefault(q => q.GenreID == id);

                // Dialog Box
                DialogResult dialogResult = MessageBox.Show("Do you want to delete this genre?",
                    "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    // Delete genre from table 
                    _db.Genres.Remove(genre);
                    _db.SaveChanges();
                    MessageBox.Show("Genre successfully deleted from your Music Library.");
                }

                PopulateGenreGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure you have selected a row.\n" + 
                    "Cascaded deletion is not enabled so related data cannot be deleted.");
            }
        }
    }
}