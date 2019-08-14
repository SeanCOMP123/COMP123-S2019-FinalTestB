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

      
        string[] FirstNameList;
        string[] LastNameList;
        
       

        public void LoadNames()
        {
            FirstNameList = File.ReadAllLines(@"firstNames.txt", Encoding.UTF8);
            LastNameList = File.ReadAllLines(@"lastNames.txt", Encoding.UTF8);

        }
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
    }
}
