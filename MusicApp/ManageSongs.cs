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
    public partial class frmManageSongs : Form
    {
        private readonly MusicAppEntities _db = new MusicAppEntities();

        public frmManageSongs()
        {
            InitializeComponent();
        }

        private void frmManageSongs_Load(object sender, EventArgs e)
        {
            try
            {
                // Populates the grid when the form is loaded
                // Also used to populate grid whenever the Refresh button is clicked 
                PopulateSongGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void PopulateSongGrid()  // Notice public access modifier 
        {
            // Use LINQ to query database and define aliases  
            // Notice use of lambda expression 
            var songRecords = _db.SongRecords.Select(q => new
            {
                q.SongRecordID,
                Name = q.SongName,
                Artist = q.ArtistName,
                Album = q.AlbumName,
                Genre = q.Genre.GenreName
            }).ToList();

            dgvSongList.DataSource = songRecords;
            dgvSongList.Columns["SongRecordID"].Visible = false;  // Hides ID column
        }

        // The grid is automatically populated when the form is loaded and when changes are made through the form
        // Refresh button is included so changes made to the database can be seen 
        private void btnRefreshSongs_Click(object sender, EventArgs e)
        {
            PopulateSongGrid();
        }

        private void btnAddNewSong_Click(object sender, EventArgs e)
        {
            // Prevents user from adding/editing on multiple forms at once
            frmAddEditSongRecord addSongRecord = new frmAddEditSongRecord(this);
            addSongRecord.ShowDialog();
        }

        private void btnEditSong_Click(object sender, EventArgs e)
        {
            try
            {
                // Get ID of selected row 
                int id = (int)dgvSongList.SelectedRows[0].Cells["SongRecordID"].Value;

                // Query database for song 
                var song = _db.SongRecords.FirstOrDefault(q => q.SongRecordID == id);

                // Launch AddEditSongRecord window with data 
                // Prevents user from adding/editing on multiple forms at once
                frmAddEditSongRecord editSongRecord = new frmAddEditSongRecord(song, this);
                editSongRecord.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure you have selected a row.");
            }
        }

        private void btnDeleteSong_Click(object sender, EventArgs e)
        {
            try
            {
                // Get ID of selected row 
                int id = (int)dgvSongList.SelectedRows[0].Cells["SongRecordID"].Value;

                // Query database for song 
                var song = _db.SongRecords.FirstOrDefault(q => q.SongRecordID == id);

                // Dialog Box 
                DialogResult dialogResult = MessageBox.Show("Do you want to delete this song?",
                    "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    // Delete song from table 
                    _db.SongRecords.Remove(song);
                    _db.SaveChanges();
                    MessageBox.Show("Song successfully deleted from your Music Library.");
                }

                PopulateSongGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure you have selected a row.");
            }
        }
    }
}