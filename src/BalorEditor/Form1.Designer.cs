﻿namespace BalorEditor
{
    partial class Form1
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnMaxStats = new System.Windows.Forms.Button();
			this.cbPlayerOwned = new System.Windows.Forms.CheckBox();
			this.udCharm = new System.Windows.Forms.NumericUpDown();
			this.udMind = new System.Windows.Forms.NumericUpDown();
			this.udGroup = new System.Windows.Forms.NumericUpDown();
			this.udArms = new System.Windows.Forms.NumericUpDown();
			this.udDex = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.udLevel = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.itemSelector1 = new BalorEditor.ItemSelector();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.worldDisplay1 = new BalorEditor.CustomComponents.WorldDisplay();
			this.btnResetHeights = new System.Windows.Forms.Button();
			this.rbShallows = new System.Windows.Forms.RadioButton();
			this.rbTent = new System.Windows.Forms.RadioButton();
			this.rbOcean = new System.Windows.Forms.RadioButton();
			this.rbCitadel = new System.Windows.Forms.RadioButton();
			this.rbRiver = new System.Windows.Forms.RadioButton();
			this.rbBurg = new System.Windows.Forms.RadioButton();
			this.rbUnknown = new System.Windows.Forms.RadioButton();
			this.rbFarmland = new System.Windows.Forms.RadioButton();
			this.rbOak = new System.Windows.Forms.RadioButton();
			this.rbPine = new System.Windows.Forms.RadioButton();
			this.rbRock = new System.Windows.Forms.RadioButton();
			this.rbGrassland = new System.Windows.Forms.RadioButton();
			this.isRegion = new BalorEditor.ItemSelector();
			this.menuStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udCharm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udMind)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udGroup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udArms)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udDex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udLevel)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(676, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 24);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(676, 564);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Controls.Add(this.itemSelector1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(668, 538);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Heroes";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnMaxStats);
			this.panel1.Controls.Add(this.cbPlayerOwned);
			this.panel1.Controls.Add(this.udCharm);
			this.panel1.Controls.Add(this.udMind);
			this.panel1.Controls.Add(this.udGroup);
			this.panel1.Controls.Add(this.udArms);
			this.panel1.Controls.Add(this.udDex);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.udLevel);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.lbName);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 33);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(662, 502);
			this.panel1.TabIndex = 1;
			// 
			// btnMaxStats
			// 
			this.btnMaxStats.Location = new System.Drawing.Point(8, 136);
			this.btnMaxStats.Name = "btnMaxStats";
			this.btnMaxStats.Size = new System.Drawing.Size(121, 23);
			this.btnMaxStats.TabIndex = 3;
			this.btnMaxStats.Text = "Max Player Unit Stats";
			this.btnMaxStats.UseVisualStyleBackColor = true;
			this.btnMaxStats.Click += new System.EventHandler(this.btnMaxStats_Click);
			// 
			// cbPlayerOwned
			// 
			this.cbPlayerOwned.AutoSize = true;
			this.cbPlayerOwned.Location = new System.Drawing.Point(268, 7);
			this.cbPlayerOwned.Name = "cbPlayerOwned";
			this.cbPlayerOwned.Size = new System.Drawing.Size(89, 17);
			this.cbPlayerOwned.TabIndex = 2;
			this.cbPlayerOwned.Text = "PlayerOwned";
			this.cbPlayerOwned.UseVisualStyleBackColor = true;
			// 
			// udCharm
			// 
			this.udCharm.Location = new System.Drawing.Point(52, 110);
			this.udCharm.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.udCharm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.udCharm.Name = "udCharm";
			this.udCharm.Size = new System.Drawing.Size(62, 20);
			this.udCharm.TabIndex = 1;
			this.udCharm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// udMind
			// 
			this.udMind.Location = new System.Drawing.Point(52, 84);
			this.udMind.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.udMind.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.udMind.Name = "udMind";
			this.udMind.Size = new System.Drawing.Size(62, 20);
			this.udMind.TabIndex = 1;
			this.udMind.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// udGroup
			// 
			this.udGroup.Location = new System.Drawing.Point(200, 32);
			this.udGroup.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.udGroup.Name = "udGroup";
			this.udGroup.Size = new System.Drawing.Size(62, 20);
			this.udGroup.TabIndex = 1;
			this.udGroup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// udArms
			// 
			this.udArms.Location = new System.Drawing.Point(52, 32);
			this.udArms.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.udArms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.udArms.Name = "udArms";
			this.udArms.Size = new System.Drawing.Size(62, 20);
			this.udArms.TabIndex = 1;
			this.udArms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// udDex
			// 
			this.udDex.Location = new System.Drawing.Point(52, 58);
			this.udDex.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.udDex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.udDex.Name = "udDex";
			this.udDex.Size = new System.Drawing.Size(62, 20);
			this.udDex.TabIndex = 1;
			this.udDex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(5, 112);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Charm:";
			// 
			// udLevel
			// 
			this.udLevel.Location = new System.Drawing.Point(200, 6);
			this.udLevel.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
			this.udLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.udLevel.Name = "udLevel";
			this.udLevel.Size = new System.Drawing.Size(62, 20);
			this.udLevel.TabIndex = 1;
			this.udLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(5, 86);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Mind:";
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Location = new System.Drawing.Point(49, 8);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(0, 13);
			this.lbName.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(158, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Group:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(5, 60);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Dex:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(5, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Arms:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(158, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Level:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// itemSelector1
			// 
			this.itemSelector1.Collection = null;
			this.itemSelector1.Dock = System.Windows.Forms.DockStyle.Top;
			this.itemSelector1.Location = new System.Drawing.Point(3, 3);
			this.itemSelector1.Name = "itemSelector1";
			this.itemSelector1.Size = new System.Drawing.Size(662, 30);
			this.itemSelector1.TabIndex = 0;
			this.itemSelector1.ItemSelectorIndexChanged += new BalorEditor.ItemSelector.ItemSelectorEventHandler(this.itemSelector1_ItemSelectorIndexChanged);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.statusStrip1);
			this.tabPage2.Controls.Add(this.splitContainer1);
			this.tabPage2.Controls.Add(this.isRegion);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(668, 538);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Regions";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(3, 513);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(662, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(3, 30);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.worldDisplay1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.btnResetHeights);
			this.splitContainer1.Panel2.Controls.Add(this.rbShallows);
			this.splitContainer1.Panel2.Controls.Add(this.rbTent);
			this.splitContainer1.Panel2.Controls.Add(this.rbOcean);
			this.splitContainer1.Panel2.Controls.Add(this.rbCitadel);
			this.splitContainer1.Panel2.Controls.Add(this.rbRiver);
			this.splitContainer1.Panel2.Controls.Add(this.rbBurg);
			this.splitContainer1.Panel2.Controls.Add(this.rbUnknown);
			this.splitContainer1.Panel2.Controls.Add(this.rbFarmland);
			this.splitContainer1.Panel2.Controls.Add(this.rbOak);
			this.splitContainer1.Panel2.Controls.Add(this.rbPine);
			this.splitContainer1.Panel2.Controls.Add(this.rbRock);
			this.splitContainer1.Panel2.Controls.Add(this.rbGrassland);
			this.splitContainer1.Size = new System.Drawing.Size(662, 480);
			this.splitContainer1.SplitterDistance = 544;
			this.splitContainer1.TabIndex = 2;
			// 
			// worldDisplay1
			// 
			this.worldDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.worldDisplay1.Location = new System.Drawing.Point(0, 0);
			this.worldDisplay1.Name = "worldDisplay1";
			this.worldDisplay1.Size = new System.Drawing.Size(544, 480);
			this.worldDisplay1.TabIndex = 0;
			// 
			// btnResetHeights
			// 
			this.btnResetHeights.Location = new System.Drawing.Point(3, 285);
			this.btnResetHeights.Name = "btnResetHeights";
			this.btnResetHeights.Size = new System.Drawing.Size(106, 23);
			this.btnResetHeights.TabIndex = 12;
			this.btnResetHeights.Text = "Reset All Heights";
			this.btnResetHeights.UseVisualStyleBackColor = true;
			this.btnResetHeights.Click += new System.EventHandler(this.btnResetHeights_Click);
			// 
			// rbShallows
			// 
			this.rbShallows.AutoSize = true;
			this.rbShallows.Location = new System.Drawing.Point(12, 262);
			this.rbShallows.Name = "rbShallows";
			this.rbShallows.Size = new System.Drawing.Size(67, 17);
			this.rbShallows.TabIndex = 11;
			this.rbShallows.TabStop = true;
			this.rbShallows.Text = "Shallows";
			this.rbShallows.UseVisualStyleBackColor = true;
			this.rbShallows.CheckedChanged += new System.EventHandler(this.rbMaterialSelected);
			// 
			// rbTent
			// 
			this.rbTent.AutoSize = true;
			this.rbTent.Location = new System.Drawing.Point(12, 170);
			this.rbTent.Name = "rbTent";
			this.rbTent.Size = new System.Drawing.Size(47, 17);
			this.rbTent.TabIndex = 7;
			this.rbTent.TabStop = true;
			this.rbTent.Text = "Tent";
			this.rbTent.UseVisualStyleBackColor = true;
			this.rbTent.CheckedChanged += new System.EventHandler(this.rbMaterialSelected);
			// 
			// rbOcean
			// 
			this.rbOcean.AutoSize = true;
			this.rbOcean.Location = new System.Drawing.Point(12, 239);
			this.rbOcean.Name = "rbOcean";
			this.rbOcean.Size = new System.Drawing.Size(57, 17);
			this.rbOcean.TabIndex = 10;
			this.rbOcean.TabStop = true;
			this.rbOcean.Text = "Ocean";
			this.rbOcean.UseVisualStyleBackColor = true;
			this.rbOcean.CheckedChanged += new System.EventHandler(this.rbMaterialSelected);
			// 
			// rbCitadel
			// 
			this.rbCitadel.AutoSize = true;
			this.rbCitadel.Location = new System.Drawing.Point(12, 147);
			this.rbCitadel.Name = "rbCitadel";
			this.rbCitadel.Size = new System.Drawing.Size(57, 17);
			this.rbCitadel.TabIndex = 6;
			this.rbCitadel.TabStop = true;
			this.rbCitadel.Text = "Citadel";
			this.rbCitadel.UseVisualStyleBackColor = true;
			this.rbCitadel.CheckedChanged += new System.EventHandler(this.rbMaterialSelected);
			// 
			// rbRiver
			// 
			this.rbRiver.AutoSize = true;
			this.rbRiver.Location = new System.Drawing.Point(12, 216);
			this.rbRiver.Name = "rbRiver";
			this.rbRiver.Size = new System.Drawing.Size(50, 17);
			this.rbRiver.TabIndex = 9;
			this.rbRiver.TabStop = true;
			this.rbRiver.Text = "River";
			this.rbRiver.UseVisualStyleBackColor = true;
			this.rbRiver.CheckedChanged += new System.EventHandler(this.rbMaterialSelected);
			// 
			// rbBurg
			// 
			this.rbBurg.AutoSize = true;
			this.rbBurg.Location = new System.Drawing.Point(12, 124);
			this.rbBurg.Name = "rbBurg";
			this.rbBurg.Size = new System.Drawing.Size(47, 17);
			this.rbBurg.TabIndex = 5;
			this.rbBurg.TabStop = true;
			this.rbBurg.Text = "Burg";
			this.rbBurg.UseVisualStyleBackColor = true;
			this.rbBurg.CheckedChanged += new System.EventHandler(this.rbMaterialSelected);
			// 
			// rbUnknown
			// 
			this.rbUnknown.AutoSize = true;
			this.rbUnknown.Location = new System.Drawing.Point(12, 193);
			this.rbUnknown.Name = "rbUnknown";
			this.rbUnknown.Size = new System.Drawing.Size(54, 17);
			this.rbUnknown.TabIndex = 8;
			this.rbUnknown.TabStop = true;
			this.rbUnknown.Text = "Marsh";
			this.rbUnknown.UseVisualStyleBackColor = true;
			this.rbUnknown.CheckedChanged += new System.EventHandler(this.rbMaterialSelected);
			// 
			// rbFarmland
			// 
			this.rbFarmland.AutoSize = true;
			this.rbFarmland.Location = new System.Drawing.Point(12, 101);
			this.rbFarmland.Name = "rbFarmland";
			this.rbFarmland.Size = new System.Drawing.Size(68, 17);
			this.rbFarmland.TabIndex = 4;
			this.rbFarmland.TabStop = true;
			this.rbFarmland.Text = "Farmland";
			this.rbFarmland.UseVisualStyleBackColor = true;
			this.rbFarmland.CheckedChanged += new System.EventHandler(this.rbMaterialSelected);
			// 
			// rbOak
			// 
			this.rbOak.AutoSize = true;
			this.rbOak.Location = new System.Drawing.Point(12, 78);
			this.rbOak.Name = "rbOak";
			this.rbOak.Size = new System.Drawing.Size(45, 17);
			this.rbOak.TabIndex = 3;
			this.rbOak.TabStop = true;
			this.rbOak.Text = "Oak";
			this.rbOak.UseVisualStyleBackColor = true;
			this.rbOak.CheckedChanged += new System.EventHandler(this.rbMaterialSelected);
			// 
			// rbPine
			// 
			this.rbPine.AutoSize = true;
			this.rbPine.Location = new System.Drawing.Point(12, 55);
			this.rbPine.Name = "rbPine";
			this.rbPine.Size = new System.Drawing.Size(46, 17);
			this.rbPine.TabIndex = 2;
			this.rbPine.TabStop = true;
			this.rbPine.Text = "Pine";
			this.rbPine.UseVisualStyleBackColor = true;
			this.rbPine.CheckedChanged += new System.EventHandler(this.rbMaterialSelected);
			// 
			// rbRock
			// 
			this.rbRock.AutoSize = true;
			this.rbRock.Location = new System.Drawing.Point(12, 32);
			this.rbRock.Name = "rbRock";
			this.rbRock.Size = new System.Drawing.Size(51, 17);
			this.rbRock.TabIndex = 1;
			this.rbRock.TabStop = true;
			this.rbRock.Text = "Rock";
			this.rbRock.UseVisualStyleBackColor = true;
			this.rbRock.CheckedChanged += new System.EventHandler(this.rbMaterialSelected);
			// 
			// rbGrassland
			// 
			this.rbGrassland.AutoSize = true;
			this.rbGrassland.Location = new System.Drawing.Point(12, 9);
			this.rbGrassland.Name = "rbGrassland";
			this.rbGrassland.Size = new System.Drawing.Size(72, 17);
			this.rbGrassland.TabIndex = 0;
			this.rbGrassland.TabStop = true;
			this.rbGrassland.Text = "Grassland";
			this.rbGrassland.UseVisualStyleBackColor = true;
			this.rbGrassland.CheckedChanged += new System.EventHandler(this.rbMaterialSelected);
			// 
			// isRegion
			// 
			this.isRegion.Collection = null;
			this.isRegion.Dock = System.Windows.Forms.DockStyle.Top;
			this.isRegion.Location = new System.Drawing.Point(3, 3);
			this.isRegion.Name = "isRegion";
			this.isRegion.Size = new System.Drawing.Size(662, 30);
			this.isRegion.TabIndex = 1;
			this.isRegion.ItemSelectorIndexChanged += new BalorEditor.ItemSelector.ItemSelectorEventHandler(this.isRegion_ItemSelectorIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(676, 588);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.udCharm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udMind)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udGroup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udArms)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udDex)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udLevel)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private ItemSelector itemSelector1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.NumericUpDown udCharm;
		private System.Windows.Forms.NumericUpDown udMind;
		private System.Windows.Forms.NumericUpDown udArms;
		private System.Windows.Forms.NumericUpDown udDex;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown udLevel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox cbPlayerOwned;
		private System.Windows.Forms.NumericUpDown udGroup;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnMaxStats;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private CustomComponents.WorldDisplay worldDisplay1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private ItemSelector isRegion;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.RadioButton rbTent;
		private System.Windows.Forms.RadioButton rbCitadel;
		private System.Windows.Forms.RadioButton rbBurg;
		private System.Windows.Forms.RadioButton rbFarmland;
		private System.Windows.Forms.RadioButton rbOak;
		private System.Windows.Forms.RadioButton rbPine;
		private System.Windows.Forms.RadioButton rbRock;
		private System.Windows.Forms.RadioButton rbGrassland;
		private System.Windows.Forms.RadioButton rbShallows;
		private System.Windows.Forms.RadioButton rbOcean;
		private System.Windows.Forms.RadioButton rbRiver;
		private System.Windows.Forms.RadioButton rbUnknown;
		private System.Windows.Forms.Button btnResetHeights;
    }
}

