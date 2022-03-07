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
    public partial class frmAddEditGenre : Form
    {
        private bool _isEditMode;
        private frmManageGenres _frmManageGenres;
        private readonly MusicAppEntities _db = new MusicAppEntities(); 
        
        public frmAddEditGenre(frmManageGenres frmManageGenres = null)  // Notice nullability 
        {
            InitializeComponent();
            this.Text = "Add Genre";  // Changes form name 
            lblAddEditTitle.Text = "Add Genre";  // Changes form label/title 
            _isEditMode = false;
            _frmManageGenres = frmManageGenres;
        }

        public frmAddEditGenre(Genre genreToEdit, frmManageGenres frmManageGenres = null)
        {
            InitializeComponent();
            this.Text = "Edit Genre";
            lblAddEditTitle.Text = "Edit Genre";
            _isEditMode = true;
            _frmManageGenres = frmManageGenres;
            PopulateFields(genreToEdit);
        }

        private void PopulateFields(Genre genreToEdit)
        {
            lblGenreId.Text = genreToEdit.GenreID.ToString();
            txtGenreName.Text = genreToEdit.GenreName; 
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation for Genre Name input 
                if (string.IsNullOrWhiteSpace(txtGenreName.Text))
                {
                    MessageBox.Show("Please enter a genre name.");
                }
                else
                {
                    if (_isEditMode)
                    {
                        // Edit Code here 
                        int id = int.Parse(lblGenreId.Text);
                        var genre = _db.Genres.FirstOrDefault(q => q.GenreID == id);
                        genre.GenreName = txtGenreName.Text;
                    }
                    else
                    {
                        // Add Code here 
                        var newGenre = new Genre { GenreName = txtGenreName.Text };
                        _db.Genres.Add(newGenre);
                    }

                    // Save changes made to the database and repopulate grid 
                    _db.SaveChanges();
                    _frmManageGenres.PopulateGenreGrid();

                    MessageBox.Show("Operation completed.");
                    Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong.Please try again.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}