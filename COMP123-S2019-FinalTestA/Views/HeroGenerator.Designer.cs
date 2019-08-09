namespace COMP123_S2019_FinalTestA.Views
{
    partial class HeroGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeroGenerator));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.AbilitiesTabPage = new System.Windows.Forms.TabPage();
            this.PowersTabPage = new System.Windows.Forms.TabPage();
            this.IdentityTabPage = new System.Windows.Forms.TabPage();
            this.CharacterSheetTabPage = new System.Windows.Forms.TabPage();
            this.HeroMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HeroToolStrip = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.HeroNameLabel = new System.Windows.Forms.Label();
            this.EnterHeroTextBox = new System.Windows.Forms.TextBox();
            this.FirstLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameDataLabel = new System.Windows.Forms.Label();
            this.LastNameDataLabel = new System.Windows.Forms.Label();
            this.GenerateNameNutton = new System.Windows.Forms.Button();
            this.FightingDataLabel = new System.Windows.Forms.Label();
            this.FigthingLabel = new System.Windows.Forms.Label();
            this.StrengthDataLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EnduranceDataLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ReasonDataLabel = new System.Windows.Forms.Label();
            this.IntuitionDataLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PsycheDataLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PopurlarityDataLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AgilityDataLabel = new System.Windows.Forms.Label();
            this.PhysicalAbilitiesLabel = new System.Windows.Forms.Label();
            this.MentalAbilitiesLabel = new System.Windows.Forms.Label();
            this.AbilitiesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.GenerateAbilitesButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.AbilitiesTabPage.SuspendLayout();
            this.IdentityTabPage.SuspendLayout();
            this.HeroMenuStrip.SuspendLayout();
            this.HeroToolStrip.SuspendLayout();
            this.AbilitiesTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.IdentityTabPage);
            this.MainTabControl.Controls.Add(this.AbilitiesTabPage);
            this.MainTabControl.Controls.Add(this.PowersTabPage);
            this.MainTabControl.Controls.Add(this.CharacterSheetTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(782, 460);
            this.MainTabControl.TabIndex = 0;
            // 
            // AbilitiesTabPage
            // 
            this.AbilitiesTabPage.Controls.Add(this.AbilitiesTableLayoutPanel);
            this.AbilitiesTabPage.Location = new System.Drawing.Point(4, 38);
            this.AbilitiesTabPage.Name = "AbilitiesTabPage";
            this.AbilitiesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AbilitiesTabPage.Size = new System.Drawing.Size(774, 418);
            this.AbilitiesTabPage.TabIndex = 0;
            this.AbilitiesTabPage.Text = "Abilities";
            this.AbilitiesTabPage.UseVisualStyleBackColor = true;
            // 
            // PowersTabPage
            // 
            this.PowersTabPage.Location = new System.Drawing.Point(4, 38);
            this.PowersTabPage.Name = "PowersTabPage";
            this.PowersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PowersTabPage.Size = new System.Drawing.Size(750, 418);
            this.PowersTabPage.TabIndex = 1;
            this.PowersTabPage.Text = "Powers";
            this.PowersTabPage.UseVisualStyleBackColor = true;
            // 
            // IdentityTabPage
            // 
            this.IdentityTabPage.Controls.Add(this.GenerateNameNutton);
            this.IdentityTabPage.Controls.Add(this.EnterHeroTextBox);
            this.IdentityTabPage.Controls.Add(this.LastNameLabel);
            this.IdentityTabPage.Controls.Add(this.LastNameDataLabel);
            this.IdentityTabPage.Controls.Add(this.FirstNameDataLabel);
            this.IdentityTabPage.Controls.Add(this.FirstLabel);
            this.IdentityTabPage.Controls.Add(this.HeroNameLabel);
            this.IdentityTabPage.Controls.Add(this.HeroToolStrip);
            this.IdentityTabPage.Controls.Add(this.HeroMenuStrip);
            this.IdentityTabPage.Location = new System.Drawing.Point(4, 38);
            this.IdentityTabPage.Name = "IdentityTabPage";
            this.IdentityTabPage.Size = new System.Drawing.Size(774, 418);
            this.IdentityTabPage.TabIndex = 2;
            this.IdentityTabPage.Text = "Identity";
            this.IdentityTabPage.UseVisualStyleBackColor = true;
            // 
            // CharacterSheetTabPage
            // 
            this.CharacterSheetTabPage.Location = new System.Drawing.Point(4, 38);
            this.CharacterSheetTabPage.Name = "CharacterSheetTabPage";
            this.CharacterSheetTabPage.Size = new System.Drawing.Size(750, 418);
            this.CharacterSheetTabPage.TabIndex = 3;
            this.CharacterSheetTabPage.Text = "Character Sheet";
            this.CharacterSheetTabPage.UseVisualStyleBackColor = true;
            // 
            // HeroMenuStrip
            // 
            this.HeroMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.HeroMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.HeroMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.HeroMenuStrip.Name = "HeroMenuStrip";
            this.HeroMenuStrip.Size = new System.Drawing.Size(774, 28);
            this.HeroMenuStrip.TabIndex = 0;
            this.HeroMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(221, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // HeroToolStrip
            // 
            this.HeroToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.HeroToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator3,
            this.helpToolStripButton});
            this.HeroToolStrip.Location = new System.Drawing.Point(0, 28);
            this.HeroToolStrip.Name = "HeroToolStrip";
            this.HeroToolStrip.Size = new System.Drawing.Size(774, 27);
            this.HeroToolStrip.TabIndex = 1;
            this.HeroToolStrip.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(668, 482);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(110, 47);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(4, 482);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(110, 47);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // HeroNameLabel
            // 
            this.HeroNameLabel.Location = new System.Drawing.Point(3, 82);
            this.HeroNameLabel.Name = "HeroNameLabel";
            this.HeroNameLabel.Size = new System.Drawing.Size(233, 35);
            this.HeroNameLabel.TabIndex = 2;
            this.HeroNameLabel.Text = "Enter Hero Name";
            this.HeroNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnterHeroTextBox
            // 
            this.EnterHeroTextBox.Location = new System.Drawing.Point(242, 82);
            this.EnterHeroTextBox.Name = "EnterHeroTextBox";
            this.EnterHeroTextBox.Size = new System.Drawing.Size(423, 34);
            this.EnterHeroTextBox.TabIndex = 3;
            // 
            // FirstLabel
            // 
            this.FirstLabel.Location = new System.Drawing.Point(-9, 151);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Size = new System.Drawing.Size(233, 35);
            this.FirstLabel.TabIndex = 2;
            this.FirstLabel.Text = "First Name";
            this.FirstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Location = new System.Drawing.Point(-9, 200);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(233, 35);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameDataLabel
            // 
            this.FirstNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FirstNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameDataLabel.Location = new System.Drawing.Point(237, 151);
            this.FirstNameDataLabel.Name = "FirstNameDataLabel";
            this.FirstNameDataLabel.Size = new System.Drawing.Size(428, 35);
            this.FirstNameDataLabel.TabIndex = 2;
            this.FirstNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastNameDataLabel
            // 
            this.LastNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LastNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameDataLabel.Location = new System.Drawing.Point(237, 200);
            this.LastNameDataLabel.Name = "LastNameDataLabel";
            this.LastNameDataLabel.Size = new System.Drawing.Size(428, 35);
            this.LastNameDataLabel.TabIndex = 2;
            this.LastNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenerateNameNutton
            // 
            this.GenerateNameNutton.Location = new System.Drawing.Point(455, 302);
            this.GenerateNameNutton.Name = "GenerateNameNutton";
            this.GenerateNameNutton.Size = new System.Drawing.Size(210, 40);
            this.GenerateNameNutton.TabIndex = 4;
            this.GenerateNameNutton.Text = "Generate Name";
            this.GenerateNameNutton.UseVisualStyleBackColor = true;
            // 
            // FightingDataLabel
            // 
            this.FightingDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FightingDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FightingDataLabel.Location = new System.Drawing.Point(195, 51);
            this.FightingDataLabel.Name = "FightingDataLabel";
            this.FightingDataLabel.Size = new System.Drawing.Size(186, 51);
            this.FightingDataLabel.TabIndex = 3;
            this.FightingDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FightingDataLabel.Click += new System.EventHandler(this.FightingDataLabel_Click);
            // 
            // FigthingLabel
            // 
            this.FigthingLabel.Location = new System.Drawing.Point(3, 51);
            this.FigthingLabel.Name = "FigthingLabel";
            this.FigthingLabel.Size = new System.Drawing.Size(186, 32);
            this.FigthingLabel.TabIndex = 4;
            this.FigthingLabel.Text = "Figthing";
            this.FigthingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StrengthDataLabel
            // 
            this.StrengthDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StrengthDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StrengthDataLabel.Location = new System.Drawing.Point(195, 153);
            this.StrengthDataLabel.Name = "StrengthDataLabel";
            this.StrengthDataLabel.Size = new System.Drawing.Size(186, 51);
            this.StrengthDataLabel.TabIndex = 7;
            this.StrengthDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Strength";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnduranceDataLabel
            // 
            this.EnduranceDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EnduranceDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnduranceDataLabel.Location = new System.Drawing.Point(195, 204);
            this.EnduranceDataLabel.Name = "EnduranceDataLabel";
            this.EnduranceDataLabel.Size = new System.Drawing.Size(186, 51);
            this.EnduranceDataLabel.TabIndex = 9;
            this.EnduranceDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Endurance";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(387, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Reason";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReasonDataLabel
            // 
            this.ReasonDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ReasonDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReasonDataLabel.Location = new System.Drawing.Point(579, 51);
            this.ReasonDataLabel.Name = "ReasonDataLabel";
            this.ReasonDataLabel.Size = new System.Drawing.Size(186, 51);
            this.ReasonDataLabel.TabIndex = 3;
            this.ReasonDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IntuitionDataLabel
            // 
            this.IntuitionDataLabel.Location = new System.Drawing.Point(387, 102);
            this.IntuitionDataLabel.Name = "IntuitionDataLabel";
            this.IntuitionDataLabel.Size = new System.Drawing.Size(176, 32);
            this.IntuitionDataLabel.TabIndex = 6;
            this.IntuitionDataLabel.Text = "Intuition";
            this.IntuitionDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(579, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 51);
            this.label10.TabIndex = 5;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(387, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 32);
            this.label11.TabIndex = 8;
            this.label11.Text = "Psyche";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PsycheDataLabel
            // 
            this.PsycheDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PsycheDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PsycheDataLabel.Location = new System.Drawing.Point(579, 153);
            this.PsycheDataLabel.Name = "PsycheDataLabel";
            this.PsycheDataLabel.Size = new System.Drawing.Size(186, 51);
            this.PsycheDataLabel.TabIndex = 7;
            this.PsycheDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(387, 204);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(176, 32);
            this.label13.TabIndex = 10;
            this.label13.Text = "Popurlarity";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PopurlarityDataLabel
            // 
            this.PopurlarityDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PopurlarityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PopurlarityDataLabel.Location = new System.Drawing.Point(579, 204);
            this.PopurlarityDataLabel.Name = "PopurlarityDataLabel";
            this.PopurlarityDataLabel.Size = new System.Drawing.Size(186, 51);
            this.PopurlarityDataLabel.TabIndex = 9;
            this.PopurlarityDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Agility";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgilityDataLabel
            // 
            this.AgilityDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AgilityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgilityDataLabel.Location = new System.Drawing.Point(195, 102);
            this.AgilityDataLabel.Name = "AgilityDataLabel";
            this.AgilityDataLabel.Size = new System.Drawing.Size(186, 51);
            this.AgilityDataLabel.TabIndex = 12;
            this.AgilityDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhysicalAbilitiesLabel
            // 
            this.AbilitiesTableLayoutPanel.SetColumnSpan(this.PhysicalAbilitiesLabel, 2);
            this.PhysicalAbilitiesLabel.Location = new System.Drawing.Point(3, 0);
            this.PhysicalAbilitiesLabel.Name = "PhysicalAbilitiesLabel";
            this.PhysicalAbilitiesLabel.Size = new System.Drawing.Size(378, 51);
            this.PhysicalAbilitiesLabel.TabIndex = 13;
            this.PhysicalAbilitiesLabel.Text = "Physical Abilities";
            this.PhysicalAbilitiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MentalAbilitiesLabel
            // 
            this.AbilitiesTableLayoutPanel.SetColumnSpan(this.MentalAbilitiesLabel, 2);
            this.MentalAbilitiesLabel.Location = new System.Drawing.Point(387, 0);
            this.MentalAbilitiesLabel.Name = "MentalAbilitiesLabel";
            this.MentalAbilitiesLabel.Size = new System.Drawing.Size(376, 51);
            this.MentalAbilitiesLabel.TabIndex = 14;
            this.MentalAbilitiesLabel.Text = "Mental Abilities";
            this.MentalAbilitiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AbilitiesTableLayoutPanel
            // 
            this.AbilitiesTableLayoutPanel.ColumnCount = 4;
            this.AbilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilitiesTableLayoutPanel.Controls.Add(this.PopurlarityDataLabel, 3, 4);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.AgilityDataLabel, 1, 2);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.PsycheDataLabel, 3, 3);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.label13, 2, 4);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.label10, 3, 2);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.EnduranceDataLabel, 1, 4);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.ReasonDataLabel, 3, 1);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.label11, 2, 3);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.label1, 0, 2);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.FigthingLabel, 0, 1);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.label4, 0, 3);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.StrengthDataLabel, 1, 3);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.label7, 2, 1);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.label6, 0, 4);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.FightingDataLabel, 1, 1);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.IntuitionDataLabel, 2, 2);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.PhysicalAbilitiesLabel, 0, 0);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.GenerateAbilitesButton, 2, 6);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.MentalAbilitiesLabel, 2, 0);
            this.AbilitiesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AbilitiesTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.AbilitiesTableLayoutPanel.Name = "AbilitiesTableLayoutPanel";
            this.AbilitiesTableLayoutPanel.RowCount = 7;
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AbilitiesTableLayoutPanel.Size = new System.Drawing.Size(768, 359);
            this.AbilitiesTableLayoutPanel.TabIndex = 15;
            // 
            // GenerateAbilitesButton
            // 
            this.AbilitiesTableLayoutPanel.SetColumnSpan(this.GenerateAbilitesButton, 2);
            this.GenerateAbilitesButton.Location = new System.Drawing.Point(387, 309);
            this.GenerateAbilitesButton.Name = "GenerateAbilitesButton";
            this.GenerateAbilitesButton.Size = new System.Drawing.Size(376, 47);
            this.GenerateAbilitesButton.TabIndex = 15;
            this.GenerateAbilitesButton.Text = "Generate Abilites";
            this.GenerateAbilitesButton.UseVisualStyleBackColor = true;
            // 
            // HeroGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.MainTabControl);
            this.MainMenuStrip = this.HeroMenuStrip;
            this.Name = "HeroGenerator";
            this.Text = "HeroGenerator";
            this.MainTabControl.ResumeLayout(false);
            this.AbilitiesTabPage.ResumeLayout(false);
            this.IdentityTabPage.ResumeLayout(false);
            this.IdentityTabPage.PerformLayout();
            this.HeroMenuStrip.ResumeLayout(false);
            this.HeroMenuStrip.PerformLayout();
            this.HeroToolStrip.ResumeLayout(false);
            this.HeroToolStrip.PerformLayout();
            this.AbilitiesTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage IdentityTabPage;
        private System.Windows.Forms.ToolStrip HeroToolStrip;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.MenuStrip HeroMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage AbilitiesTabPage;
        private System.Windows.Forms.TabPage PowersTabPage;
        private System.Windows.Forms.TabPage CharacterSheetTabPage;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button GenerateNameNutton;
        private System.Windows.Forms.TextBox EnterHeroTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label LastNameDataLabel;
        private System.Windows.Forms.Label FirstNameDataLabel;
        private System.Windows.Forms.Label FirstLabel;
        private System.Windows.Forms.Label HeroNameLabel;
        private System.Windows.Forms.Label PopurlarityDataLabel;
        private System.Windows.Forms.Label EnduranceDataLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PsycheDataLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label StrengthDataLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IntuitionDataLabel;
        private System.Windows.Forms.Label ReasonDataLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label FightingDataLabel;
        private System.Windows.Forms.Label FigthingLabel;
        private System.Windows.Forms.Label AgilityDataLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MentalAbilitiesLabel;
        private System.Windows.Forms.Label PhysicalAbilitiesLabel;
        private System.Windows.Forms.TableLayoutPanel AbilitiesTableLayoutPanel;
        private System.Windows.Forms.Button GenerateAbilitesButton;
    }
}
