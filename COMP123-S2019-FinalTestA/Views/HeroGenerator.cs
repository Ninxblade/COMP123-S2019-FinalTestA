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
        public List<string> LastNameList = new List<string>();
        public List<string> FirstNameList = new List<string>();
        public List<string> Powers = new List<string>();

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
            if (MainTabControl.SelectedIndex != 0)
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
        /// <summary>
        /// Method Load file name for chacter creation event 
        /// </summary>
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
        /// <summary>
        ///  Mehtod generateName for the character
        /// </summary>
        public void GenerateNames()
        {
            var fnamerandom = new Random();
            int fnameindex = fnamerandom.Next(FirstNameList.Count);
            FirstNameDataLabel.Text = (FirstNameList[fnamerandom.Next(0, FirstNameList.Count)]);

            var lnamerandom = new Random();
            int lnameindex = lnamerandom.Next(LastNameList.Count);
            LastNameDataLabel.Text = (LastNameList[lnamerandom.Next(0, LastNameList.Count)]);

            EnterHeroTextBox.Text = FirstNameDataLabel.Text + " " + LastNameDataLabel.Text;
        }
        /// <summary>
        ///  Mehtod load the power.txt in the powers tabs
        /// </summary>
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

            var randomPower = new Random();
            int powerindex = randomPower.Next(Powers.Count);
            //displaying words
            Power1Datalabel.Text = (Powers[randomPower.Next(0, Powers.Count)]);
            Power2Datalabel.Text = (Powers[randomPower.Next(0, Powers.Count)]);
            Power3Datalabel.Text = (Powers[randomPower.Next(0, Powers.Count)]);
            Power4Datalabel.Text = (Powers[randomPower.Next(0, Powers.Count)]);
        }

        private void GeneratePowerButton_Click(object sender, EventArgs e)
        {
            GenerateRnadomPowers();
        }

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            // configuration for saveFileDialog
            ChacterSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ChacterSaveFileDialog.FileName = "Hero.txt";
            ChacterSaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";


            var result = ChacterSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                // open a stream to write
                using (StreamWriter outputStream = new StreamWriter(
                    File.Open(ChacterSaveFileDialog.FileName, FileMode.Create)))
                {
                    //No data actually being written in 
                    //list created in hero Generator not Hero Class
                    // write stuff to the file
                    outputStream.WriteLine(Program.character.FirstName);
                    outputStream.WriteLine(Program.character.LastName);
                    outputStream.WriteLine(Program.character.Fighting);
                    outputStream.WriteLine(Program.character.Agility);
                    outputStream.WriteLine(Program.character.Strength);
                    outputStream.WriteLine(Program.character.Endurance);
                    outputStream.WriteLine(Program.character.Reason);
                    outputStream.WriteLine(Program.character.Intuition);
                    outputStream.WriteLine(Program.character.Psyche);
                    outputStream.WriteLine(Program.character.Popularity);

                    outputStream.WriteLine(Program.character.Powers);
                    outputStream.WriteLine(Program.character.Powers);
                    outputStream.WriteLine(Program.character.Powers);
                    outputStream.WriteLine(Program.character.Powers);

                    // cleanup
                    outputStream.Close();
                    outputStream.Dispose();
                }
                MessageBox.Show("File Saved Successfully!", "Saving...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void OpenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // configuration for openFileDialog
            ChacterSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ChacterSaveFileDialog.FileName = "Hero.txt";
            ChacterSaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            var result = ChacterSaveFileDialog.ShowDialog();

            if (result != DialogResult.Cancel)
            {
                // open file stream to read
                using (StreamReader inputStream = new StreamReader(
                    File.Open(ChacterSaveFileDialog.FileName, FileMode.Open)))
                {
                    // read stuff from the file into the Chracter object
                    Program.character.FirstName = inputStream.ReadLine();
                    Program.character.LastName = inputStream.ReadLine();
                    Program.character.Fighting = inputStream.ReadLine();
                    Program.character.Agility = inputStream.ReadLine();
                    Program.character.Strength = inputStream.ReadLine();
                    Program.character.Endurance = inputStream.ReadLine();
                    Program.character.Reason = inputStream.ReadLine();
                    Program.character.Intuition = inputStream.ReadLine();
                    Program.character.Psyche = inputStream.ReadLine();
                    Program.character.Popularity = inputStream.ReadLine();

                    // Program.character.Powers = inputStream.ReadLine();
                    //  Program.character.Powers = inputStream.ReadLine();
                    //  Program.character.Powers = inputStream.ReadLine();
                    //   Program.character.Powers = inputStream.ReadLine()

                    //cleanup
                    inputStream.Close();
                    inputStream.Dispose();
                }
            }
        }
    }
}
