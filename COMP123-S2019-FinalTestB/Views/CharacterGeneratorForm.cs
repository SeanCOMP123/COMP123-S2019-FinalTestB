using COMP123_S2019_FinalTestB.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
/*
 * Student Name: Sean Kwak
 * Student ID: 300614352
 * Description : This is the CharacterGeneratorForm - the main form of the application
 */
namespace COMP123_S2019_FinalTestB.Views
{
    public partial class CharacterGeneratorForm : MasterForm
    {
        public CharacterGeneratorForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handelr for the Nextbutton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }
        /// <summary>
        /// This is the event handelr for the Backbutton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        //string arrary for firstname, lastname,inventory list
        string[] FirstNameList;
        string[] LastNameList;
        string[] InventoryList;
        
       
        //LoadName Function
        public void LoadNames()
        {
            FirstNameList = File.ReadAllLines(@"firstNames.txt", Encoding.UTF8);
            LastNameList = File.ReadAllLines(@"lastNames.txt", Encoding.UTF8);

        }
        //Generate Name Function
        public void GenerateName()
        {
            Random rFirstName = new Random();
            int f = rFirstName.Next(FirstNameList.Length);
            Program.character.Firstname= FirstNameList[f];
            Random rLastName = new Random();
            int l = rFirstName.Next(FirstNameList.Length);
            Program.character.Lastname = LastNameList[l];


        }
         /// <summary>
         /// This is the event handler when form load
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void CharacterGeneratorForm_Load(object sender, EventArgs e)
        {
            LoadNames();
            GenerateName();
            LoadInventory();
        }
        /// <summary>
        /// This is an event handler for GenerateNameButton Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            GenerateName();
            FirstNameDataLabel.Text = Program.character.Firstname;
            LastNameDataLabel.Text = Program.character.Lastname;
        }
        /// <summary>
        /// this is event handler for GenerateAbilitiesButton Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            Random number = new Random();
            int n = number.Next(3,18);
            StrengthDataLabel.Text = n.ToString();
            Random number2 = new Random();
            int n2 = number.Next(3, 18);
            DexterityDataLabel.Text = n.ToString();
            Random number3 = new Random();
            int n3 = number.Next(3, 18);
            ConstitutionDataLabel.Text = n.ToString();
            Random number4 = new Random();
            int n4 = number.Next(3, 18);
            IntelligenceDataLabel.Text = n.ToString();
            Random number5 = new Random();
            int n5 = number.Next(3, 18);
            WisdomDataLabel.Text = n.ToString();
            Random number6 = new Random();
            int n6 = number.Next(3, 18);
            CharismaDataLabel.Text = n.ToString();

        }
        //Load Inventory Function
        public void LoadInventory()
        {
            InventoryList = File.ReadAllLines(@"inventory.txt", Encoding.UTF8);
        }
        //GenerateRandomInventory Function
        public void GenerateRandomInventory()
        {
            Random i1 = new Random();
            int n1 = i1.Next(InventoryList.Length);
            string inventory1= InventoryList[n1];
            InventoryList
            Program.items.Description = InventoryList[n1];
            Random i2= new Random();
            int n2 = i2.Next(FirstNameList.Length);
            Program.items.Description = InventoryList[n2];

        }
        /// <summary>
        /// this is an event hanlder for saveButton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog
            CharacterSaveFileDialog.FileName = "Character.txt";
            CharacterSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            CharacterSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";



            // open file dialog - Modal Form

            var result = CharacterSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                // open file to write
                using (StreamWriter outputStream = new StreamWriter(
                    File.Open(CharacterSaveFileDialog.FileName, FileMode.Create)))
                {
                    // write stuff to the file

                    outputStream.WriteLine(Program.characters.Firstname);
                    outputStream.WriteLine(Program.characters.Lastname);
                    outputStream.WriteLine(Program.characters.Strength);
                    outputStream.WriteLine(Program.characters.Dexterity);
                    outputStream.WriteLine(Program.characters.Constitution);
                    outputStream.WriteLine(Program.items);
                    // close the file
                    outputStream.Close();
                    // dispose of the memory
                    outputStream.Dispose();

                }

                MessageBox.Show("File Saved", "Saving...",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Thie is event handler openFile click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog
            CharacterSaveFileDialog.FileName = "Character.txt";
            CharacterSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            CharacterSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";



            // open file dialog - Modal Form

            var result = CharacterOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    // open file to write
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(CharacterOpenFileDialog.FileName, FileMode.Create)))
                    {
                        // write stuff to the file

                        Program.characters.Firstname = inputStream.ReadLine();
                        Program.characters.Lastname = inputStream.ReadLine();
                        Program.characters.Strength = inputStream.ReadLine();
                        Program.characters.Dexterity = inputStream.ReadLine();
                        Program.characters.Constitution = inputStream.ReadLine();
                        Program.items = inputStream.ReadLine();
                        // close the file
                        inputStream.Close();
                        // dispose of the memory
                        inputStream.Dispose();

                    }

                }
                catch (IOException exception)

                {

                    MessageBox.Show("Error: " + exception.Message, "File I/O Error",

                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
    }
}
