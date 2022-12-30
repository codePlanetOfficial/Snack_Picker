using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Runtime.InteropServices;
using System.IO;

namespace Snack_Picker_GUI
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = ".\\Database\\Snacks.txt";
            if (File.Exists(filePath))
            {
                // file exists, do something
            }
            else
            {
                // file does not exist, do something else

                DialogResult result = MessageBox.Show("Database does not exist, want to create one?", "Create Database?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // user clicked "yes", create the file

                    string folderPath = ".\\Database";
                    Directory.CreateDirectory(folderPath);

                    FileStream fileStream = File.Create(filePath);
                    fileStream.Close();
                }
                else
                {
                    // user clicked "no", close the app
                    this.Close();
                }

            }

        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Add_Snack_BTN_Click(object sender, EventArgs e)
        {
            string text = Add_Snack_Text_Box.Text; // The text you want to add to the file
            string filePath = ".\\Database\\Snacks.txt"; // The path to the file

            using (StreamWriter writer = new StreamWriter(filePath, true)) // The "true" parameter tells the StreamWriter to append to the file instead of overwriting it
            {
                writer.WriteLine(text);
            }

            Status_label.Text = "Added";
        }

        private void Add_Snack_Text_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Status_label_Click(object sender, EventArgs e)
        {

        }

        private void Pick_A_Random_Snack_Click(object sender, EventArgs e)
        {
            string filePath = ".\\Database\\Snacks.txt"; // The path to the file

            List<string> lines = new List<string>(); // Create a new list to hold the lines from the file

            // Read all of the lines from the file and add them to the list
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            Random rnd = new Random(); // Create a new random number generator
            int index = rnd.Next(lines.Count); // Get a random index in the range [0, lines.Count)
            string randomLine = lines[index]; // Get the line at the random index

            // Do something with the random line, such as displaying it in a label
            Pick_A_Random_Snack_Text_Box.Text = randomLine;
        }

        private void Pick_A_Random_Snack_Text_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void View_Snacks_BTN_Click(object sender, EventArgs e)
        {
            string filePath = ".\\Database\\Snacks.txt"; // The path to the file

            // Read the contents of the file into a string
            string fileContents = File.ReadAllText(filePath);

            // Set the text of the textbox to the contents of the file
            View_Snacks_Text_Box.Text = fileContents;
        }

        private void View_Snacks_Text_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_BTN_Click(object sender, EventArgs e)
        {
            string filePath = ".\\Database\\Snacks.txt"; // The path to the file

            // Display a confirmation message
            DialogResult result = MessageBox.Show("Are you sure you want to clear the file?", "Confirmation", MessageBoxButtons.YesNo);

            // If the user clicks "Yes"
            if (result == DialogResult.Yes)
            {
                // Clear the contents of the file
                File.WriteAllText(filePath, "");
                View_Snacks_Text_Box.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://codeplanet.com.au");
        }
    }
}
