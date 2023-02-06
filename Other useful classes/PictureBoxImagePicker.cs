using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_TruongMauGiao
{
    class PictureBoxImagePicker
    {
        /// <summary>
        /// Make a picture picker to change the PictureBox's Image when open and select a file from OpenFileDialog
        /// </summary>
        /// <param name="pictureBox">The PictureBox will change based on the Image selected</param>
        /// <param name="openFileDialog">Open a Image file (.jpg, .png, .gif format) to choose PictureBox Image</param>
        /// <returns></returns>
        public static bool pick(PictureBox pictureBox, OpenFileDialog openFileDialog)
        {
            try
            {
                openFileDialog.Filter = "Select Image(*.jpg,*.png,*.gif)|*.jpg;*.png;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
