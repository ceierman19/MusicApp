using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public static class Utils
    {
        public static bool FormIsOpen(string formName)
        {
            // Check if window is already open 
            var OpenForms = Application.OpenForms.Cast<Form>();
            bool isOpen = OpenForms.Any(q => q.Name == formName);
            return isOpen;
        }

        public static string HashPassword(string password)
        {
            // Declare the one hashing algorithm to be used throughout the application  
            SHA256 sha = SHA256.Create();

            // Convert the input string to a byte array called "data" and compute the hash 
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            // Create a new StringBuilder to collect the bytes and create a string 
            StringBuilder stringBuilder = new StringBuilder();

            // Loop through each byte of the hashed data and format each one as a hexadecimal string 
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }

        public static string DefaultHashedPassword()
        {
            SHA256 sha = SHA256.Create();

            // Password@123 is the hard-coded default password 
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes("Password@123"));
            
            StringBuilder stringBuilder = new StringBuilder();
           
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }
    }
}