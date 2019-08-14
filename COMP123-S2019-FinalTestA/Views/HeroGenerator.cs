using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using COMP123_S2019_FinalTestA.Objects;
using System.IO;
/*
 * 
 * STUDNET NAME: Jason Li
 * STUDENT ID: 301012468
 * DESCRIPTION : This is the Hero Generator Form
 */
namespace COMP123_S2019_FinalTestA.Views
{
    public partial class HeroGenerator : COMP123_S2019_FinalTestA.Views.MasterForm
    {
        public HeroGenerator()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the NextButton Click
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
        /// This is the event handler for the BackButton Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }
        private void FightingDataLabel_Click(object sender, EventArgs e)
        {

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter outputString = new StreamWriter("filename.txt"))
            {

                outputString.Close();
                outputString.Dispose();
            }
        }

        private void GenerateNameNButton_Click(object sender, EventArgs e)
        {
            EnterHeroTextBox.Text = Program.character.HeroName;
            FirstNameDataLabel.Text = Program.character.FirstName;
            LastNameDataLabel.Text = Program.character.LastName;
            LoadNames();
            GenerateNames();
      
        }

        private void GenerateAbilitesButton_Click(object sender, EventArgs e)
        {
            Random abilityGenerator = new Random();
            int ability = abilityGenerator.Next(10, 50);
            FightingDataLabel.Text = ability.ToString();
            AgilityDataLabel.Text = ability.ToString();
            StrengthDataLabel.Text = ability.ToString();
            EnduranceDataLabel.Text = ability.ToString();
            ReasonDataLabel.Text = ability.ToString();
            IntuitionDataLabel.Text = ability.ToString();
            PsycheDataLabel.Text = ability.ToString();
            PopurlarityDataLabel.Text = ability.ToString();
        }
        private void IdentityTabPage_Click(object sender, EventArgs e)
        {

        }

        private void HeroNameLabel_Click(object sender, EventArgs e)
        {

        }


        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public List<string> LastNameList = new List<string>();

        public List<string> FirstNameList = new List<string>();
        public List<string> Powers = new List<string>();

        public void LoadNames()
        {
            var lastnameFileStream = new FileStream("..\\..\\Data\\lastNames.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(lastnameFileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    LastNameList.Add(line);
                }
               
            }
            var firstnameFileStream = new FileStream("..\\..\\Data\\firstNames.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(firstnameFileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    FirstNameList.Add(line);
                 
                }
            }
        }
        public void GenerateNames()
        {
            var fnamerandom = new Random();
            int fnameindex = fnamerandom.Next(FirstNameList.Count);
            FirstNameDataLabel.Text = fnameindex.ToString();

            var lnamerandom = new Random();
            int lnameindex = lnamerandom.Next(LastNameList.Count);
            LastNameDataLabel.Text = lnameindex.ToString();
        }
        public void LoadPowers()
        {
            var powerFileStream = new FileStream("..\\..\\Data\\powers.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(powerFileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Powers.Add(line);
                }
            }
        }

        private void PowersTabPage_Click(object sender, EventArgs e)
        {

        }

        private void HeroGenerator_Load(object sender, EventArgs e)
        {
            LoadPowers();
        }
        public void GenerateRnadomPowers()
        {
            //Display number format instead of string
            var randomPower = new Random();
            int powerindex = randomPower.Next(Powers.Count);
            Power1Datalabel.Text = powerindex.ToString();
            Power2Datalabel.Text = powerindex.ToString();
            Power3Datalabel.Text = powerindex.ToString();
            Power4Datalabel.Text = powerindex.ToString();
        }

        private void GeneratePowerButton_Click(object sender, EventArgs e)
        {
            GenerateRnadomPowers();
        }
    }
}
