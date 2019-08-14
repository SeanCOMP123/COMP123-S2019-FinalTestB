namespace COMP123_S2019_FinalTestB.Views
{
    partial class CharacterGeneratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterGeneratorForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.IdentityPage = new System.Windows.Forms.TabPage();
            this.IdentityTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.GenerateNameButton = new System.Windows.Forms.Button();
            this.CharacterNameLabel = new System.Windows.Forms.Label();
            this.LastnameLabel = new System.Windows.Forms.Label();
            this.CharacterNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameDataLabel = new System.Windows.Forms.Label();
            this.LastNameDataLabel = new System.Windows.Forms.Label();
            this.AbilitiesPage = new System.Windows.Forms.TabPage();
            this.AbilitiesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DexterityDataLabel = new System.Windows.Forms.Label();
            this.DexterityLabel = new System.Windows.Forms.Label();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.GenerateAbilitiesButton = new System.Windows.Forms.Button();
            this.ConstitutionLabel = new System.Windows.Forms.Label();
            this.WisdomLabel = new System.Windows.Forms.Label();
            this.IntelligenceLabel = new System.Windows.Forms.Label();
            this.CharismaLabel = new System.Windows.Forms.Label();
            this.StrengthDataLabel = new System.Windows.Forms.Label();
            this.ConstitutionDataLabel = new System.Windows.Forms.Label();
            this.IntelligenceDataLabel = new System.Windows.Forms.Label();
            this.WisdomDataLabel = new System.Windows.Forms.Label();
            this.CharismaDataLabel = new System.Windows.Forms.Label();
            this.InventoryPage = new System.Windows.Forms.TabPage();
            this.InventoryPageTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Item4DataLabel = new System.Windows.Forms.Label();
            this.Item3DataLabel = new System.Windows.Forms.Label();
            this.Item2DataLabel = new System.Windows.Forms.Label();
            this.ItemHeadLabel = new System.Windows.Forms.Label();
            this.Item2Label = new System.Windows.Forms.Label();
            this.Item3Label = new System.Windows.Forms.Label();
            this.Item1Label = new System.Windows.Forms.Label();
            this.Item4label = new System.Windows.Forms.Label();
            this.Item1DataLabel = new System.Windows.Forms.Label();
            this.GenerateInventoryButton = new System.Windows.Forms.Button();
            this.CharacterSheetPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HeroNameLabel = new System.Windows.Forms.Label();
            this.MianToolStrip = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.AbilityLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AbilityDataLabel = new System.Windows.Forms.Label();
            this.ItemsDataLabel = new System.Windows.Forms.Label();
            this.CharacterSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.CharacterOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainTabControl.SuspendLayout();
            this.IdentityPage.SuspendLayout();
            this.IdentityTableLayoutPanel.SuspendLayout();
            this.AbilitiesPage.SuspendLayout();
            this.AbilitiesTableLayoutPanel.SuspendLayout();
            this.InventoryPage.SuspendLayout();
            this.InventoryPageTableLayoutPanel.SuspendLayout();
            this.CharacterSheetPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.MianToolStrip.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(8, 357);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(82, 42);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(445, 357);
            this.NextButton.Margin = new System.Windows.Forms.Padding(2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(82, 42);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.IdentityPage);
            this.MainTabControl.Controls.Add(this.AbilitiesPage);
            this.MainTabControl.Controls.Add(this.InventoryPage);
            this.MainTabControl.Controls.Add(this.CharacterSheetPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(535, 346);
            this.MainTabControl.TabIndex = 4;
            // 
            // IdentityPage
            // 
            this.IdentityPage.Controls.Add(this.IdentityTableLayoutPanel);
            this.IdentityPage.Location = new System.Drawing.Point(4, 33);
            this.IdentityPage.Margin = new System.Windows.Forms.Padding(2);
            this.IdentityPage.Name = "IdentityPage";
            this.IdentityPage.Padding = new System.Windows.Forms.Padding(2);
            this.IdentityPage.Size = new System.Drawing.Size(527, 309);
            this.IdentityPage.TabIndex = 0;
            this.IdentityPage.Text = "Identity";
            this.IdentityPage.UseVisualStyleBackColor = true;
            // 
            // IdentityTableLayoutPanel
            // 
            this.IdentityTableLayoutPanel.ColumnCount = 4;
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.Controls.Add(this.FirstNameLabel, 0, 1);
            this.IdentityTableLayoutPanel.Controls.Add(this.GenerateNameButton, 2, 4);
            this.IdentityTableLayoutPanel.Controls.Add(this.CharacterNameLabel, 0, 0);
            this.IdentityTableLayoutPanel.Controls.Add(this.LastnameLabel, 0, 2);
            this.IdentityTableLayoutPanel.Controls.Add(this.CharacterNameTextBox, 1, 0);
            this.IdentityTableLayoutPanel.Controls.Add(this.FirstNameDataLabel, 1, 1);
            this.IdentityTableLayoutPanel.Controls.Add(this.LastNameDataLabel, 1, 2);
            this.IdentityTableLayoutPanel.Location = new System.Drawing.Point(6, 4);
            this.IdentityTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.IdentityTableLayoutPanel.Name = "IdentityTableLayoutPanel";
            this.IdentityTableLayoutPanel.RowCount = 5;
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.Size = new System.Drawing.Size(518, 260);
            this.IdentityTableLayoutPanel.TabIndex = 0;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameLabel.Location = new System.Drawing.Point(2, 52);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(151, 52);
            this.FirstNameLabel.TabIndex = 6;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GenerateNameButton
            // 
            this.GenerateNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdentityTableLayoutPanel.SetColumnSpan(this.GenerateNameButton, 2);
            this.GenerateNameButton.Location = new System.Drawing.Point(260, 210);
            this.GenerateNameButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateNameButton.Name = "GenerateNameButton";
            this.GenerateNameButton.Size = new System.Drawing.Size(256, 48);
            this.GenerateNameButton.TabIndex = 3;
            this.GenerateNameButton.Text = "Generate Name";
            this.GenerateNameButton.UseVisualStyleBackColor = true;
            this.GenerateNameButton.Click += new System.EventHandler(this.GenerateNameButton_Click);
            // 
            // CharacterNameLabel
            // 
            this.CharacterNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharacterNameLabel.Location = new System.Drawing.Point(2, 0);
            this.CharacterNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CharacterNameLabel.Name = "CharacterNameLabel";
            this.CharacterNameLabel.Size = new System.Drawing.Size(151, 52);
            this.CharacterNameLabel.TabIndex = 4;
            this.CharacterNameLabel.Text = "Character Name";
            this.CharacterNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LastnameLabel
            // 
            this.LastnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastnameLabel.Location = new System.Drawing.Point(2, 104);
            this.LastnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastnameLabel.Name = "LastnameLabel";
            this.LastnameLabel.Size = new System.Drawing.Size(151, 52);
            this.LastnameLabel.TabIndex = 5;
            this.LastnameLabel.Text = "Last Name";
            this.LastnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CharacterNameTextBox
            // 
            this.CharacterNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IdentityTableLayoutPanel.SetColumnSpan(this.CharacterNameTextBox, 3);
            this.CharacterNameTextBox.Location = new System.Drawing.Point(157, 8);
            this.CharacterNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CharacterNameTextBox.Multiline = true;
            this.CharacterNameTextBox.Name = "CharacterNameTextBox";
            this.CharacterNameTextBox.Size = new System.Drawing.Size(359, 35);
            this.CharacterNameTextBox.TabIndex = 7;
            // 
            // FirstNameDataLabel
            // 
            this.FirstNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FirstNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdentityTableLayoutPanel.SetColumnSpan(this.FirstNameDataLabel, 3);
            this.FirstNameDataLabel.Location = new System.Drawing.Point(157, 52);
            this.FirstNameDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameDataLabel.Name = "FirstNameDataLabel";
            this.FirstNameDataLabel.Size = new System.Drawing.Size(359, 52);
            this.FirstNameDataLabel.TabIndex = 6;
            this.FirstNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LastNameDataLabel
            // 
            this.LastNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LastNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdentityTableLayoutPanel.SetColumnSpan(this.LastNameDataLabel, 3);
            this.LastNameDataLabel.Location = new System.Drawing.Point(157, 104);
            this.LastNameDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNameDataLabel.Name = "LastNameDataLabel";
            this.LastNameDataLabel.Size = new System.Drawing.Size(359, 52);
            this.LastNameDataLabel.TabIndex = 6;
            this.LastNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AbilitiesPage
            // 
            this.AbilitiesPage.Controls.Add(this.AbilitiesTableLayoutPanel);
            this.AbilitiesPage.Location = new System.Drawing.Point(4, 33);
            this.AbilitiesPage.Margin = new System.Windows.Forms.Padding(2);
            this.AbilitiesPage.Name = "AbilitiesPage";
            this.AbilitiesPage.Padding = new System.Windows.Forms.Padding(2);
            this.AbilitiesPage.Size = new System.Drawing.Size(527, 309);
            this.AbilitiesPage.TabIndex = 1;
            this.AbilitiesPage.Text = "Abilities";
            this.AbilitiesPage.UseVisualStyleBackColor = true;
            // 
            // AbilitiesTableLayoutPanel
            // 
            this.AbilitiesTableLayoutPanel.ColumnCount = 4;
            this.AbilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilitiesTableLayoutPanel.Controls.Add(this.DexterityDataLabel, 1, 1);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.DexterityLabel, 0, 1);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.StrengthLabel, 0, 0);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.GenerateAbilitiesButton, 2, 7);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.ConstitutionLabel, 0, 2);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.WisdomLabel, 0, 4);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.IntelligenceLabel, 0, 3);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.CharismaLabel, 0, 5);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.StrengthDataLabel, 1, 0);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.ConstitutionDataLabel, 1, 2);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.IntelligenceDataLabel, 1, 3);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.WisdomDataLabel, 1, 4);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.CharismaDataLabel, 1, 5);
            this.AbilitiesTableLayoutPanel.Location = new System.Drawing.Point(6, 4);
            this.AbilitiesTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.AbilitiesTableLayoutPanel.Name = "AbilitiesTableLayoutPanel";
            this.AbilitiesTableLayoutPanel.RowCount = 8;
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.Size = new System.Drawing.Size(518, 278);
            this.AbilitiesTableLayoutPanel.TabIndex = 0;
            // 
            // DexterityDataLabel
            // 
            this.DexterityDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexterityDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DexterityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DexterityDataLabel.Location = new System.Drawing.Point(131, 34);
            this.DexterityDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DexterityDataLabel.Name = "DexterityDataLabel";
            this.DexterityDataLabel.Size = new System.Drawing.Size(125, 34);
            this.DexterityDataLabel.TabIndex = 14;
            this.DexterityDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DexterityLabel
            // 
            this.DexterityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexterityLabel.Location = new System.Drawing.Point(2, 34);
            this.DexterityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DexterityLabel.Name = "DexterityLabel";
            this.DexterityLabel.Size = new System.Drawing.Size(125, 34);
            this.DexterityLabel.TabIndex = 10;
            this.DexterityLabel.Text = "Dexterity";
            this.DexterityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthLabel.Location = new System.Drawing.Point(2, 0);
            this.StrengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(125, 34);
            this.StrengthLabel.TabIndex = 6;
            this.StrengthLabel.Text = "Strength";
            this.StrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GenerateAbilitiesButton
            // 
            this.GenerateAbilitiesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbilitiesTableLayoutPanel.SetColumnSpan(this.GenerateAbilitiesButton, 2);
            this.GenerateAbilitiesButton.Location = new System.Drawing.Point(260, 240);
            this.GenerateAbilitiesButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateAbilitiesButton.Name = "GenerateAbilitiesButton";
            this.GenerateAbilitiesButton.Size = new System.Drawing.Size(256, 36);
            this.GenerateAbilitiesButton.TabIndex = 5;
            this.GenerateAbilitiesButton.Text = "Generate Abilities";
            this.GenerateAbilitiesButton.UseVisualStyleBackColor = true;
            this.GenerateAbilitiesButton.Click += new System.EventHandler(this.GenerateAbilitiesButton_Click);
            // 
            // ConstitutionLabel
            // 
            this.ConstitutionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConstitutionLabel.Location = new System.Drawing.Point(2, 68);
            this.ConstitutionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConstitutionLabel.Name = "ConstitutionLabel";
            this.ConstitutionLabel.Size = new System.Drawing.Size(125, 34);
            this.ConstitutionLabel.TabIndex = 7;
            this.ConstitutionLabel.Text = "Constitution";
            this.ConstitutionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WisdomLabel
            // 
            this.WisdomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WisdomLabel.Location = new System.Drawing.Point(2, 136);
            this.WisdomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WisdomLabel.Name = "WisdomLabel";
            this.WisdomLabel.Size = new System.Drawing.Size(125, 34);
            this.WisdomLabel.TabIndex = 8;
            this.WisdomLabel.Text = "Wisdom";
            this.WisdomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IntelligenceLabel
            // 
            this.IntelligenceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntelligenceLabel.Location = new System.Drawing.Point(2, 102);
            this.IntelligenceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntelligenceLabel.Name = "IntelligenceLabel";
            this.IntelligenceLabel.Size = new System.Drawing.Size(125, 34);
            this.IntelligenceLabel.TabIndex = 9;
            this.IntelligenceLabel.Text = "Intelligence";
            this.IntelligenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CharismaLabel
            // 
            this.CharismaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharismaLabel.Location = new System.Drawing.Point(2, 170);
            this.CharismaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CharismaLabel.Name = "CharismaLabel";
            this.CharismaLabel.Size = new System.Drawing.Size(125, 34);
            this.CharismaLabel.TabIndex = 11;
            this.CharismaLabel.Text = "Charisma";
            this.CharismaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StrengthDataLabel
            // 
            this.StrengthDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StrengthDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StrengthDataLabel.Location = new System.Drawing.Point(131, 0);
            this.StrengthDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StrengthDataLabel.Name = "StrengthDataLabel";
            this.StrengthDataLabel.Size = new System.Drawing.Size(125, 34);
            this.StrengthDataLabel.TabIndex = 7;
            this.StrengthDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConstitutionDataLabel
            // 
            this.ConstitutionDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConstitutionDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ConstitutionDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConstitutionDataLabel.Location = new System.Drawing.Point(131, 68);
            this.ConstitutionDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConstitutionDataLabel.Name = "ConstitutionDataLabel";
            this.ConstitutionDataLabel.Size = new System.Drawing.Size(125, 34);
            this.ConstitutionDataLabel.TabIndex = 13;
            this.ConstitutionDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IntelligenceDataLabel
            // 
            this.IntelligenceDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntelligenceDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IntelligenceDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntelligenceDataLabel.Location = new System.Drawing.Point(131, 102);
            this.IntelligenceDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntelligenceDataLabel.Name = "IntelligenceDataLabel";
            this.IntelligenceDataLabel.Size = new System.Drawing.Size(125, 34);
            this.IntelligenceDataLabel.TabIndex = 15;
            this.IntelligenceDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WisdomDataLabel
            // 
            this.WisdomDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WisdomDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WisdomDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WisdomDataLabel.Location = new System.Drawing.Point(131, 136);
            this.WisdomDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WisdomDataLabel.Name = "WisdomDataLabel";
            this.WisdomDataLabel.Size = new System.Drawing.Size(125, 34);
            this.WisdomDataLabel.TabIndex = 12;
            this.WisdomDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CharismaDataLabel
            // 
            this.CharismaDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharismaDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CharismaDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CharismaDataLabel.Location = new System.Drawing.Point(131, 170);
            this.CharismaDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CharismaDataLabel.Name = "CharismaDataLabel";
            this.CharismaDataLabel.Size = new System.Drawing.Size(125, 34);
            this.CharismaDataLabel.TabIndex = 16;
            this.CharismaDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InventoryPage
            // 
            this.InventoryPage.Controls.Add(this.InventoryPageTableLayoutPanel);
            this.InventoryPage.Location = new System.Drawing.Point(4, 33);
            this.InventoryPage.Margin = new System.Windows.Forms.Padding(2);
            this.InventoryPage.Name = "InventoryPage";
            this.InventoryPage.Padding = new System.Windows.Forms.Padding(2);
            this.InventoryPage.Size = new System.Drawing.Size(527, 309);
            this.InventoryPage.TabIndex = 2;
            this.InventoryPage.Text = "Inventory";
            this.InventoryPage.UseVisualStyleBackColor = true;
            // 
            // InventoryPageTableLayoutPanel
            // 
            this.InventoryPageTableLayoutPanel.ColumnCount = 4;
            this.InventoryPageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.InventoryPageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.InventoryPageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.InventoryPageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.InventoryPageTableLayoutPanel.Controls.Add(this.Item4DataLabel, 1, 4);
            this.InventoryPageTableLayoutPanel.Controls.Add(this.Item3DataLabel, 1, 3);
            this.InventoryPageTableLayoutPanel.Controls.Add(this.Item2DataLabel, 1, 2);
            this.InventoryPageTableLayoutPanel.Controls.Add(this.ItemHeadLabel, 0, 0);
            this.InventoryPageTableLayoutPanel.Controls.Add(this.Item2Label, 0, 2);
            this.InventoryPageTableLayoutPanel.Controls.Add(this.Item3Label, 0, 3);
            this.InventoryPageTableLayoutPanel.Controls.Add(this.Item1Label, 0, 1);
            this.InventoryPageTableLayoutPanel.Controls.Add(this.Item4label, 0, 4);
            this.InventoryPageTableLayoutPanel.Controls.Add(this.Item1DataLabel, 1, 1);
            this.InventoryPageTableLayoutPanel.Controls.Add(this.GenerateInventoryButton, 2, 5);
            this.InventoryPageTableLayoutPanel.Location = new System.Drawing.Point(5, 5);
            this.InventoryPageTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.InventoryPageTableLayoutPanel.Name = "InventoryPageTableLayoutPanel";
            this.InventoryPageTableLayoutPanel.RowCount = 6;
            this.InventoryPageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.InventoryPageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.InventoryPageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.InventoryPageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.InventoryPageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.InventoryPageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.InventoryPageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.InventoryPageTableLayoutPanel.Size = new System.Drawing.Size(519, 260);
            this.InventoryPageTableLayoutPanel.TabIndex = 0;
            // 
            // Item4DataLabel
            // 
            this.Item4DataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Item4DataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Item4DataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InventoryPageTableLayoutPanel.SetColumnSpan(this.Item4DataLabel, 3);
            this.Item4DataLabel.Location = new System.Drawing.Point(131, 172);
            this.Item4DataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Item4DataLabel.Name = "Item4DataLabel";
            this.Item4DataLabel.Size = new System.Drawing.Size(386, 43);
            this.Item4DataLabel.TabIndex = 18;
            this.Item4DataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Item3DataLabel
            // 
            this.Item3DataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Item3DataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Item3DataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InventoryPageTableLayoutPanel.SetColumnSpan(this.Item3DataLabel, 3);
            this.Item3DataLabel.Location = new System.Drawing.Point(131, 129);
            this.Item3DataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Item3DataLabel.Name = "Item3DataLabel";
            this.Item3DataLabel.Size = new System.Drawing.Size(386, 43);
            this.Item3DataLabel.TabIndex = 17;
            this.Item3DataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Item2DataLabel
            // 
            this.Item2DataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Item2DataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Item2DataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InventoryPageTableLayoutPanel.SetColumnSpan(this.Item2DataLabel, 3);
            this.Item2DataLabel.Location = new System.Drawing.Point(131, 86);
            this.Item2DataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Item2DataLabel.Name = "Item2DataLabel";
            this.Item2DataLabel.Size = new System.Drawing.Size(386, 43);
            this.Item2DataLabel.TabIndex = 16;
            this.Item2DataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ItemHeadLabel
            // 
            this.ItemHeadLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InventoryPageTableLayoutPanel.SetColumnSpan(this.ItemHeadLabel, 4);
            this.ItemHeadLabel.Location = new System.Drawing.Point(2, 0);
            this.ItemHeadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ItemHeadLabel.Name = "ItemHeadLabel";
            this.ItemHeadLabel.Size = new System.Drawing.Size(515, 43);
            this.ItemHeadLabel.TabIndex = 11;
            this.ItemHeadLabel.Text = "Inventory Items";
            this.ItemHeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Item2Label
            // 
            this.Item2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Item2Label.Location = new System.Drawing.Point(2, 86);
            this.Item2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Item2Label.Name = "Item2Label";
            this.Item2Label.Size = new System.Drawing.Size(125, 43);
            this.Item2Label.TabIndex = 13;
            this.Item2Label.Text = "Item2";
            this.Item2Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Item3Label
            // 
            this.Item3Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Item3Label.Location = new System.Drawing.Point(2, 129);
            this.Item3Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Item3Label.Name = "Item3Label";
            this.Item3Label.Size = new System.Drawing.Size(125, 43);
            this.Item3Label.TabIndex = 14;
            this.Item3Label.Text = "Item3";
            this.Item3Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Item1Label
            // 
            this.Item1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Item1Label.Location = new System.Drawing.Point(2, 43);
            this.Item1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Item1Label.Name = "Item1Label";
            this.Item1Label.Size = new System.Drawing.Size(125, 43);
            this.Item1Label.TabIndex = 12;
            this.Item1Label.Text = "Item1";
            this.Item1Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Item4label
            // 
            this.Item4label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Item4label.Location = new System.Drawing.Point(2, 172);
            this.Item4label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Item4label.Name = "Item4label";
            this.Item4label.Size = new System.Drawing.Size(125, 43);
            this.Item4label.TabIndex = 15;
            this.Item4label.Text = "Item4";
            this.Item4label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Item1DataLabel
            // 
            this.Item1DataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Item1DataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Item1DataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InventoryPageTableLayoutPanel.SetColumnSpan(this.Item1DataLabel, 3);
            this.Item1DataLabel.Location = new System.Drawing.Point(131, 43);
            this.Item1DataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Item1DataLabel.Name = "Item1DataLabel";
            this.Item1DataLabel.Size = new System.Drawing.Size(386, 43);
            this.Item1DataLabel.TabIndex = 7;
            this.Item1DataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GenerateInventoryButton
            // 
            this.GenerateInventoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InventoryPageTableLayoutPanel.SetColumnSpan(this.GenerateInventoryButton, 2);
            this.GenerateInventoryButton.Location = new System.Drawing.Point(260, 217);
            this.GenerateInventoryButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateInventoryButton.Name = "GenerateInventoryButton";
            this.GenerateInventoryButton.Size = new System.Drawing.Size(257, 41);
            this.GenerateInventoryButton.TabIndex = 6;
            this.GenerateInventoryButton.Text = "Generate Inventory";
            this.GenerateInventoryButton.UseVisualStyleBackColor = true;
            // 
            // CharacterSheetPage
            // 
            this.CharacterSheetPage.Controls.Add(this.tableLayoutPanel1);
            this.CharacterSheetPage.Controls.Add(this.MianToolStrip);
            this.CharacterSheetPage.Controls.Add(this.MainMenuStrip);
            this.CharacterSheetPage.Location = new System.Drawing.Point(4, 33);
            this.CharacterSheetPage.Margin = new System.Windows.Forms.Padding(2);
            this.CharacterSheetPage.Name = "CharacterSheetPage";
            this.CharacterSheetPage.Padding = new System.Windows.Forms.Padding(2);
            this.CharacterSheetPage.Size = new System.Drawing.Size(527, 309);
            this.CharacterSheetPage.TabIndex = 3;
            this.CharacterSheetPage.Text = "CharacterSheet";
            this.CharacterSheetPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.AbilityDataLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.HeroNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AbilityLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ItemsLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ItemsDataLabel, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(510, 170);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // HeroNameLabel
            // 
            this.HeroNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeroNameLabel.Location = new System.Drawing.Point(2, 0);
            this.HeroNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeroNameLabel.Name = "HeroNameLabel";
            this.HeroNameLabel.Size = new System.Drawing.Size(123, 34);
            this.HeroNameLabel.TabIndex = 7;
            this.HeroNameLabel.Text = "Hero Name";
            this.HeroNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MianToolStrip
            // 
            this.MianToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MianToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.helpToolStripButton});
            this.MianToolStrip.Location = new System.Drawing.Point(2, 26);
            this.MianToolStrip.Name = "MianToolStrip";
            this.MianToolStrip.Size = new System.Drawing.Size(523, 31);
            this.MianToolStrip.TabIndex = 1;
            this.MianToolStrip.Text = "toolStrip1";
            this.MianToolStrip.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(2, 2);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MainMenuStrip.Size = new System.Drawing.Size(523, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(185, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsLabel.Location = new System.Drawing.Point(2, 102);
            this.ItemsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(123, 34);
            this.ItemsLabel.TabIndex = 8;
            this.ItemsLabel.Text = "Items";
            this.ItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AbilityLabel
            // 
            this.AbilityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbilityLabel.Location = new System.Drawing.Point(2, 34);
            this.AbilityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AbilityLabel.Name = "AbilityLabel";
            this.AbilityLabel.Size = new System.Drawing.Size(123, 34);
            this.AbilityLabel.TabIndex = 9;
            this.AbilityLabel.Text = "Ability";
            this.AbilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Location = new System.Drawing.Point(129, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 34);
            this.label1.TabIndex = 7;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AbilityDataLabel
            // 
            this.AbilityDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbilityDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AbilityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.AbilityDataLabel, 3);
            this.AbilityDataLabel.Location = new System.Drawing.Point(129, 34);
            this.AbilityDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AbilityDataLabel.Name = "AbilityDataLabel";
            this.tableLayoutPanel1.SetRowSpan(this.AbilityDataLabel, 2);
            this.AbilityDataLabel.Size = new System.Drawing.Size(379, 68);
            this.AbilityDataLabel.TabIndex = 10;
            this.AbilityDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ItemsDataLabel
            // 
            this.ItemsDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ItemsDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.ItemsDataLabel, 3);
            this.ItemsDataLabel.Location = new System.Drawing.Point(129, 102);
            this.ItemsDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ItemsDataLabel.Name = "ItemsDataLabel";
            this.tableLayoutPanel1.SetRowSpan(this.ItemsDataLabel, 2);
            this.ItemsDataLabel.Size = new System.Drawing.Size(379, 68);
            this.ItemsDataLabel.TabIndex = 11;
            this.ItemsDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CharacterSaveFileDialog
            // 
            this.CharacterSaveFileDialog.DereferenceLinks = false;
            // 
            // CharacterGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.ClientSize = new System.Drawing.Size(535, 408);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CharacterGeneratorForm";
            this.Text = "Character Generator";
            this.Load += new System.EventHandler(this.CharacterGeneratorForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.IdentityPage.ResumeLayout(false);
            this.IdentityTableLayoutPanel.ResumeLayout(false);
            this.IdentityTableLayoutPanel.PerformLayout();
            this.AbilitiesPage.ResumeLayout(false);
            this.AbilitiesTableLayoutPanel.ResumeLayout(false);
            this.InventoryPage.ResumeLayout(false);
            this.InventoryPageTableLayoutPanel.ResumeLayout(false);
            this.CharacterSheetPage.ResumeLayout(false);
            this.CharacterSheetPage.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.MianToolStrip.ResumeLayout(false);
            this.MianToolStrip.PerformLayout();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage IdentityPage;
        private System.Windows.Forms.TabPage AbilitiesPage;
        private System.Windows.Forms.TabPage InventoryPage;
        private System.Windows.Forms.TabPage CharacterSheetPage;
        private System.Windows.Forms.TableLayoutPanel IdentityTableLayoutPanel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button GenerateNameButton;
        private System.Windows.Forms.Label CharacterNameLabel;
        private System.Windows.Forms.Label LastnameLabel;
        private System.Windows.Forms.TextBox CharacterNameTextBox;
        private System.Windows.Forms.Label FirstNameDataLabel;
        private System.Windows.Forms.Label LastNameDataLabel;
        private System.Windows.Forms.TableLayoutPanel AbilitiesTableLayoutPanel;
        private System.Windows.Forms.Label DexterityLabel;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Button GenerateAbilitiesButton;
        private System.Windows.Forms.Label ConstitutionLabel;
        private System.Windows.Forms.Label WisdomLabel;
        private System.Windows.Forms.Label IntelligenceLabel;
        private System.Windows.Forms.Label CharismaLabel;
        private System.Windows.Forms.Label DexterityDataLabel;
        private System.Windows.Forms.Label StrengthDataLabel;
        private System.Windows.Forms.Label ConstitutionDataLabel;
        private System.Windows.Forms.Label IntelligenceDataLabel;
        private System.Windows.Forms.Label WisdomDataLabel;
        private System.Windows.Forms.Label CharismaDataLabel;
        private System.Windows.Forms.ToolStrip MianToolStrip;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel InventoryPageTableLayoutPanel;
        private System.Windows.Forms.Label ItemHeadLabel;
        private System.Windows.Forms.Label Item2Label;
        private System.Windows.Forms.Label Item3Label;
        private System.Windows.Forms.Label Item1Label;
        private System.Windows.Forms.Label Item4label;
        private System.Windows.Forms.Label Item4DataLabel;
        private System.Windows.Forms.Label Item3DataLabel;
        private System.Windows.Forms.Label Item2DataLabel;
        private System.Windows.Forms.Label Item1DataLabel;
        private System.Windows.Forms.Button GenerateInventoryButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label HeroNameLabel;
        private System.Windows.Forms.Label AbilityDataLabel;
        private System.Windows.Forms.Label AbilityLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.Label ItemsDataLabel;
        private System.Windows.Forms.SaveFileDialog CharacterSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog CharacterOpenFileDialog;
    }
}
