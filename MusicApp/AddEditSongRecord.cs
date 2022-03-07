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
    public partial class frmAddEditSongRecord : Form
    {
        private bool _isEditMode;
        private frmManageSongs _frmManageSongs; 
        private readonly MusicAppEntities _db = new MusicAppEntities();
        
        public frmAddEditSongRecord(frmManageSongs frmManageSongs = null)  // Notice nullability 
        {
            InitializeComponent();
            this.Text = "Add Song to Music Library";  // Changes form name 
            lblAddEditSongRecord.Text = "Add Song to Music Library";  // Changes form label/title  
            _isEditMode = false;
            _frmManageSongs = frmManageSongs;
        }

        public frmAddEditSongRecord(SongRecord songToEdit, frmManageSongs frmManageSongs = null)
        {
            InitializeComponent();
            this.Text = "Edit Song in Music Library";
            lblAddEditSongRecord.Text = "Edit Song in Music Library";
            _isEditMode = true;
            _frmManageSongs = frmManageSongs;
            PopulateFields(songToEdit);
        }

        private void PopulateFields(SongRecord songToEdit)
        {
            txtSongTitle.Text = songToEdit.SongName;
            txtArtist.Text = songToEdit.ArtistName; 
            txtAlbum.Text = songToEdit.AlbumName;
            cboGenre.Text = songToEdit.Genre.GenreName;
            lblSongRecordId.Text = songToEdit.SongRecordID.ToString();
        }

        private void frmAddEditSongRecord_Load(object sender, EventArgs e)
        {
            // Query database 
            var genres = _db.Genres.ToList();

            // Fill the combo box / dropdown with list of genres from database
            cboGenre.DataSource = genres;
            cboGenre.ValueMember = "GenreID";
            cboGenre.DisplayMember = "GenreName";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string songTitle = txtSongTitle.Text;
                string artist = txtArtist.Text;
                string album = txtAlbum.Text;
                string genre = cboGenre.Text;
                bool isValid = true;
                string errorMessage = "";

                // Input validation 
                if (string.IsNullOrWhiteSpace(songTitle))
                {
                    isValid = false;
                    errorMessage += "Error: Please enter a song title.\n\r";
                }

                if (string.IsNullOrWhiteSpace(artist))
                {
                    isValid = false;
                    errorMessage += "Error: Please enter an artist name or type 'unknown'.\n\r";
                }

                if (string.IsNullOrWhiteSpace(album))
                {
                    isValid = false;
                    errorMessage += "Error: Please enter an album name or type 'unknown'.\n\r";
                }

                if (isValid)
                {
                    // Declare an object of the record to be added 
                    SongRecord songRecord = new SongRecord(); 

                    // If editing, get the ID and retrieve the record from the database and place 
                    // the result in the songRecord object 
                    if (_isEditMode)
                    {
                        int id = int.Parse(lblSongRecordId.Text);
                        songRecord = _db.SongRecords.FirstOrDefault(q => q.SongRecordID == id);
                    }

                    // Populate the songRecord object with values from the form 
                    songRecord.SongName = songTitle;
                    songRecord.ArtistName = artist;
                    songRecord.AlbumName = album;
                    songRecord.GenreID = (int)cboGenre.SelectedValue;
                    
                    // If not editing, add the songRecord object to the database 
                    if (!_isEditMode) { _db.SongRecords.Add(songRecord); }

                    // Save changes made to the database and repopulate grid  
                    _db.SaveChanges();
                    _frmManageSongs.PopulateSongGrid();

                    MessageBox.Show($"Music Library successfully updated.\n\r" +
                        $"Song Name: {songTitle}\n\r" +
                        $"Artist Name: {artist}\n\r" +
                        $"Album Name: {album}\n\r" +
                        $"Genre: {genre}"); 
                    
                    Close();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception)  // Maybe handle the exception of submitting the same song? 
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}