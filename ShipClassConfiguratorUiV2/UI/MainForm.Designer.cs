using ShipConfigurator_Definitions;

namespace ShipClassConfiguratorUiV2
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_GlobalSpeedLimit = new System.Windows.Forms.TextBox();
            this.modConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_NoFlyZoneCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_EditNoFlyZones = new System.Windows.Forms.Button();
            this.btn_EditIgnoredFactionTags = new System.Windows.Forms.Button();
            this.lblIgnoredFactionTagsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_IncludeAiFactions = new System.Windows.Forms.CheckBox();
            this.chk_DebugMode = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConfigFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenConfigFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ImportDefinitionDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Duplicate = new System.Windows.Forms.Button();
            this.btn_RemoveGridClass = new System.Windows.Forms.Button();
            this.btn_AddGridClass = new System.Windows.Forms.Button();
            this.lst_Classes = new System.Windows.Forms.ListBox();
            this.gridClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMinPlayers = new System.Windows.Forms.TextBox();
            this.txtMinBlocks = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaxPerPlayer = new System.Windows.Forms.TextBox();
            this.txtMaxPerFaction = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaxPcu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaxMass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaxBlocks = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_EditBlockLimits = new System.Windows.Forms.Button();
            this.btn_EditDamageMods = new System.Windows.Forms.Button();
            this.btn_EditGeneralModifiers = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chk_SmallGrid = new System.Windows.Forms.CheckBox();
            this.chk_LargeMobileGrid = new System.Windows.Forms.CheckBox();
            this.chk_StaticGrid = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_BroadcastRange = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chk_ForceBroadcast = new System.Windows.Forms.CheckBox();
            this.txtGridClassId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_GridClassName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveConfigDialog = new System.Windows.Forms.SaveFileDialog();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modConfigBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClassBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_GlobalSpeedLimit);
            this.groupBox1.Controls.Add(this.lbl_NoFlyZoneCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_EditNoFlyZones);
            this.groupBox1.Controls.Add(this.btn_EditIgnoredFactionTags);
            this.groupBox1.Controls.Add(this.lblIgnoredFactionTagsCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chk_IncludeAiFactions);
            this.groupBox1.Controls.Add(this.chk_DebugMode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Global Settings";
            // 
            // txt_GlobalSpeedLimit
            // 
            this.txt_GlobalSpeedLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modConfigBindingSource, "MaxPossibleSpeedMetersPerSecond", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.txt_GlobalSpeedLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GlobalSpeedLimit.Location = new System.Drawing.Point(77, 14);
            this.txt_GlobalSpeedLimit.Name = "txt_GlobalSpeedLimit";
            this.txt_GlobalSpeedLimit.Size = new System.Drawing.Size(117, 18);
            this.txt_GlobalSpeedLimit.TabIndex = 1;
            // 
            // modConfigBindingSource
            // 
            this.modConfigBindingSource.DataSource = typeof(ShipConfigurator_Definitions.ModConfig);
            // 
            // lbl_NoFlyZoneCount
            // 
            this.lbl_NoFlyZoneCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_NoFlyZoneCount.AutoSize = true;
            this.lbl_NoFlyZoneCount.Location = new System.Drawing.Point(183, 107);
            this.lbl_NoFlyZoneCount.Name = "lbl_NoFlyZoneCount";
            this.lbl_NoFlyZoneCount.Size = new System.Drawing.Size(13, 13);
            this.lbl_NoFlyZoneCount.TabIndex = 3;
            this.lbl_NoFlyZoneCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "No Fly Zones:";
            // 
            // btn_EditNoFlyZones
            // 
            this.btn_EditNoFlyZones.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditNoFlyZones.Location = new System.Drawing.Point(9, 105);
            this.btn_EditNoFlyZones.Name = "btn_EditNoFlyZones";
            this.btn_EditNoFlyZones.Size = new System.Drawing.Size(56, 19);
            this.btn_EditNoFlyZones.TabIndex = 4;
            this.btn_EditNoFlyZones.Text = "Edit";
            this.btn_EditNoFlyZones.UseVisualStyleBackColor = true;
            this.btn_EditNoFlyZones.Click += new System.EventHandler(this.btn_EditNoFlyZones_Click);
            // 
            // btn_EditIgnoredFactionTags
            // 
            this.btn_EditIgnoredFactionTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditIgnoredFactionTags.Location = new System.Drawing.Point(9, 80);
            this.btn_EditIgnoredFactionTags.Name = "btn_EditIgnoredFactionTags";
            this.btn_EditIgnoredFactionTags.Size = new System.Drawing.Size(56, 19);
            this.btn_EditIgnoredFactionTags.TabIndex = 3;
            this.btn_EditIgnoredFactionTags.Text = "Edit";
            this.btn_EditIgnoredFactionTags.UseVisualStyleBackColor = true;
            this.btn_EditIgnoredFactionTags.Click += new System.EventHandler(this.btn_EditIgnoredFactionTags_Click);
            // 
            // lblIgnoredFactionTagsCount
            // 
            this.lblIgnoredFactionTagsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIgnoredFactionTagsCount.AutoSize = true;
            this.lblIgnoredFactionTagsCount.Location = new System.Drawing.Point(183, 82);
            this.lblIgnoredFactionTagsCount.Name = "lblIgnoredFactionTagsCount";
            this.lblIgnoredFactionTagsCount.Size = new System.Drawing.Size(13, 13);
            this.lblIgnoredFactionTagsCount.TabIndex = 2;
            this.lblIgnoredFactionTagsCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ignored Faction Tags:";
            // 
            // chk_IncludeAiFactions
            // 
            this.chk_IncludeAiFactions.AutoSize = true;
            this.chk_IncludeAiFactions.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.modConfigBindingSource, "IncludeAiFactions", true));
            this.chk_IncludeAiFactions.Location = new System.Drawing.Point(9, 62);
            this.chk_IncludeAiFactions.Name = "chk_IncludeAiFactions";
            this.chk_IncludeAiFactions.Size = new System.Drawing.Size(117, 17);
            this.chk_IncludeAiFactions.TabIndex = 2;
            this.chk_IncludeAiFactions.Text = "Include AI Factions";
            this.chk_IncludeAiFactions.UseVisualStyleBackColor = true;
            // 
            // chk_DebugMode
            // 
            this.chk_DebugMode.AutoSize = true;
            this.chk_DebugMode.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.modConfigBindingSource, "DebugMode", true));
            this.chk_DebugMode.Location = new System.Drawing.Point(9, 39);
            this.chk_DebugMode.Name = "chk_DebugMode";
            this.chk_DebugMode.Size = new System.Drawing.Size(124, 17);
            this.chk_DebugMode.TabIndex = 2;
            this.chk_DebugMode.Text = "Enable Debug Mode";
            this.chk_DebugMode.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Speed Limit:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadConfigFileToolStripMenuItem,
            this.saveConfigFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadConfigFileToolStripMenuItem
            // 
            this.loadConfigFileToolStripMenuItem.Name = "loadConfigFileToolStripMenuItem";
            this.loadConfigFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadConfigFileToolStripMenuItem.Text = "Load Config File";
            this.loadConfigFileToolStripMenuItem.Click += new System.EventHandler(this.loadConfigFileToolStripMenuItem_Click);
            // 
            // saveConfigFileToolStripMenuItem
            // 
            this.saveConfigFileToolStripMenuItem.Name = "saveConfigFileToolStripMenuItem";
            this.saveConfigFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveConfigFileToolStripMenuItem.Text = "Save Config File";
            this.saveConfigFileToolStripMenuItem.Click += new System.EventHandler(this.saveConfigFileToolStripMenuItem_Click);
            // 
            // OpenConfigFileDialog
            // 
            this.OpenConfigFileDialog.FileName = "OpenConfigFileDialog";
            this.OpenConfigFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenConfigFileDialog_FileOk);
            // 
            // ImportDefinitionDialog
            // 
            this.ImportDefinitionDialog.FileName = "ImportDefinitionDialog";
            this.ImportDefinitionDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ImportDefinitionDialog_FileOk);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Duplicate);
            this.groupBox2.Controls.Add(this.btn_RemoveGridClass);
            this.groupBox2.Controls.Add(this.btn_AddGridClass);
            this.groupBox2.Controls.Add(this.lst_Classes);
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 254);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Classes";
            // 
            // btn_Duplicate
            // 
            this.btn_Duplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Duplicate.Location = new System.Drawing.Point(68, 224);
            this.btn_Duplicate.Name = "btn_Duplicate";
            this.btn_Duplicate.Size = new System.Drawing.Size(64, 19);
            this.btn_Duplicate.TabIndex = 5;
            this.btn_Duplicate.Text = "Duplicate";
            this.btn_Duplicate.UseVisualStyleBackColor = true;
            this.btn_Duplicate.Click += new System.EventHandler(this.btn_Duplicate_Click);
            // 
            // btn_RemoveGridClass
            // 
            this.btn_RemoveGridClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveGridClass.Location = new System.Drawing.Point(6, 224);
            this.btn_RemoveGridClass.Name = "btn_RemoveGridClass";
            this.btn_RemoveGridClass.Size = new System.Drawing.Size(56, 19);
            this.btn_RemoveGridClass.TabIndex = 5;
            this.btn_RemoveGridClass.Text = "-";
            this.btn_RemoveGridClass.UseVisualStyleBackColor = true;
            this.btn_RemoveGridClass.Click += new System.EventHandler(this.btn_RemoveGridClass_Click);
            // 
            // btn_AddGridClass
            // 
            this.btn_AddGridClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddGridClass.Location = new System.Drawing.Point(138, 224);
            this.btn_AddGridClass.Name = "btn_AddGridClass";
            this.btn_AddGridClass.Size = new System.Drawing.Size(56, 19);
            this.btn_AddGridClass.TabIndex = 5;
            this.btn_AddGridClass.Text = "+";
            this.btn_AddGridClass.UseVisualStyleBackColor = true;
            this.btn_AddGridClass.Click += new System.EventHandler(this.btn_AddGridClass_Click);
            // 
            // lst_Classes
            // 
            this.lst_Classes.DataSource = this.gridClassBindingSource;
            this.lst_Classes.DisplayMember = "Name";
            this.lst_Classes.FormattingEnabled = true;
            this.lst_Classes.Location = new System.Drawing.Point(6, 19);
            this.lst_Classes.Name = "lst_Classes";
            this.lst_Classes.Size = new System.Drawing.Size(188, 199);
            this.lst_Classes.TabIndex = 4;
            // 
            // gridClassBindingSource
            // 
            this.gridClassBindingSource.DataSource = typeof(ShipConfigurator_Definitions.GridClass);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.txtGridClassId);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_GridClassName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(218, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 391);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Class Details";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.txtMinPlayers);
            this.groupBox8.Controls.Add(this.txtMinBlocks);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Location = new System.Drawing.Point(6, 219);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(300, 48);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Minimum Counts";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(163, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Min Players:";
            // 
            // txtMinPlayers
            // 
            this.txtMinPlayers.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gridClassBindingSource, "MinPlayers", true));
            this.txtMinPlayers.Location = new System.Drawing.Point(233, 19);
            this.txtMinPlayers.Name = "txtMinPlayers";
            this.txtMinPlayers.Size = new System.Drawing.Size(61, 20);
            this.txtMinPlayers.TabIndex = 15;
            // 
            // txtMinBlocks
            // 
            this.txtMinBlocks.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gridClassBindingSource, "MinBlocks", true));
            this.txtMinBlocks.Location = new System.Drawing.Point(77, 19);
            this.txtMinBlocks.Name = "txtMinBlocks";
            this.txtMinBlocks.Size = new System.Drawing.Size(67, 20);
            this.txtMinBlocks.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Min Blocks:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.txtMaxPerPlayer);
            this.groupBox7.Controls.Add(this.txtMaxPerFaction);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.txtMaxPcu);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.txtMaxMass);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.txtMaxBlocks);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Location = new System.Drawing.Point(6, 137);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(300, 82);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Maximum Counts";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(152, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Max per Player:";
            // 
            // txtMaxPerPlayer
            // 
            this.txtMaxPerPlayer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gridClassBindingSource, "MaxPerPlayer", true));
            this.txtMaxPerPlayer.Location = new System.Drawing.Point(233, 35);
            this.txtMaxPerPlayer.Name = "txtMaxPerPlayer";
            this.txtMaxPerPlayer.Size = new System.Drawing.Size(61, 20);
            this.txtMaxPerPlayer.TabIndex = 13;
            // 
            // txtMaxPerFaction
            // 
            this.txtMaxPerFaction.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gridClassBindingSource, "MaxPerFaction", true));
            this.txtMaxPerFaction.Location = new System.Drawing.Point(233, 13);
            this.txtMaxPerFaction.Name = "txtMaxPerFaction";
            this.txtMaxPerFaction.Size = new System.Drawing.Size(61, 20);
            this.txtMaxPerFaction.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Max per Faction:";
            // 
            // txtMaxPcu
            // 
            this.txtMaxPcu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gridClassBindingSource, "MaxPCU", true));
            this.txtMaxPcu.Location = new System.Drawing.Point(77, 56);
            this.txtMaxPcu.Name = "txtMaxPcu";
            this.txtMaxPcu.Size = new System.Drawing.Size(67, 20);
            this.txtMaxPcu.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Max PCU:";
            // 
            // txtMaxMass
            // 
            this.txtMaxMass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gridClassBindingSource, "MaxMass", true));
            this.txtMaxMass.Location = new System.Drawing.Point(77, 35);
            this.txtMaxMass.Name = "txtMaxMass";
            this.txtMaxMass.Size = new System.Drawing.Size(67, 20);
            this.txtMaxMass.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Max Mass:";
            // 
            // txtMaxBlocks
            // 
            this.txtMaxBlocks.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gridClassBindingSource, "MaxBlocks", true));
            this.txtMaxBlocks.Location = new System.Drawing.Point(77, 13);
            this.txtMaxBlocks.Name = "txtMaxBlocks";
            this.txtMaxBlocks.Size = new System.Drawing.Size(67, 20);
            this.txtMaxBlocks.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Max Blocks:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_EditBlockLimits);
            this.groupBox6.Controls.Add(this.btn_EditDamageMods);
            this.groupBox6.Controls.Add(this.btn_EditGeneralModifiers);
            this.groupBox6.Location = new System.Drawing.Point(86, 273);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(147, 99);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Modifiers/Limits";
            // 
            // btn_EditBlockLimits
            // 
            this.btn_EditBlockLimits.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditBlockLimits.Location = new System.Drawing.Point(6, 69);
            this.btn_EditBlockLimits.Name = "btn_EditBlockLimits";
            this.btn_EditBlockLimits.Size = new System.Drawing.Size(135, 19);
            this.btn_EditBlockLimits.TabIndex = 7;
            this.btn_EditBlockLimits.Text = "Edit Block Limits";
            this.btn_EditBlockLimits.UseVisualStyleBackColor = true;
            this.btn_EditBlockLimits.Click += new System.EventHandler(this.btn_EditBlockLimits_Click);
            // 
            // btn_EditDamageMods
            // 
            this.btn_EditDamageMods.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditDamageMods.Location = new System.Drawing.Point(6, 44);
            this.btn_EditDamageMods.Name = "btn_EditDamageMods";
            this.btn_EditDamageMods.Size = new System.Drawing.Size(135, 19);
            this.btn_EditDamageMods.TabIndex = 6;
            this.btn_EditDamageMods.Text = "Edit Damage Modifiers";
            this.btn_EditDamageMods.UseVisualStyleBackColor = true;
            this.btn_EditDamageMods.Click += new System.EventHandler(this.btn_EditDamageMods_Click);
            // 
            // btn_EditGeneralModifiers
            // 
            this.btn_EditGeneralModifiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditGeneralModifiers.Location = new System.Drawing.Point(6, 19);
            this.btn_EditGeneralModifiers.Name = "btn_EditGeneralModifiers";
            this.btn_EditGeneralModifiers.Size = new System.Drawing.Size(135, 19);
            this.btn_EditGeneralModifiers.TabIndex = 5;
            this.btn_EditGeneralModifiers.Text = "Edit General Modifiers";
            this.btn_EditGeneralModifiers.UseVisualStyleBackColor = true;
            this.btn_EditGeneralModifiers.Click += new System.EventHandler(this.btn_EditGeneralModifiers_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chk_SmallGrid);
            this.groupBox5.Controls.Add(this.chk_LargeMobileGrid);
            this.groupBox5.Controls.Add(this.chk_StaticGrid);
            this.groupBox5.Location = new System.Drawing.Point(159, 43);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(147, 88);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Grid Type";
            // 
            // chk_SmallGrid
            // 
            this.chk_SmallGrid.AutoSize = true;
            this.chk_SmallGrid.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.gridClassBindingSource, "SmallGrid", true));
            this.chk_SmallGrid.Location = new System.Drawing.Point(6, 65);
            this.chk_SmallGrid.Name = "chk_SmallGrid";
            this.chk_SmallGrid.Size = new System.Drawing.Size(73, 17);
            this.chk_SmallGrid.TabIndex = 5;
            this.chk_SmallGrid.Text = "Small Grid";
            this.chk_SmallGrid.UseVisualStyleBackColor = true;
            // 
            // chk_LargeMobileGrid
            // 
            this.chk_LargeMobileGrid.AutoSize = true;
            this.chk_LargeMobileGrid.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.gridClassBindingSource, "LargeGridMobile", true));
            this.chk_LargeMobileGrid.Location = new System.Drawing.Point(6, 42);
            this.chk_LargeMobileGrid.Name = "chk_LargeMobileGrid";
            this.chk_LargeMobileGrid.Size = new System.Drawing.Size(115, 17);
            this.chk_LargeMobileGrid.TabIndex = 5;
            this.chk_LargeMobileGrid.Text = "Large Grid (Mobile)";
            this.chk_LargeMobileGrid.UseVisualStyleBackColor = true;
            // 
            // chk_StaticGrid
            // 
            this.chk_StaticGrid.AutoSize = true;
            this.chk_StaticGrid.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.gridClassBindingSource, "LargeGridStatic", true));
            this.chk_StaticGrid.Location = new System.Drawing.Point(6, 19);
            this.chk_StaticGrid.Name = "chk_StaticGrid";
            this.chk_StaticGrid.Size = new System.Drawing.Size(75, 17);
            this.chk_StaticGrid.TabIndex = 5;
            this.chk_StaticGrid.Text = "Static Grid";
            this.chk_StaticGrid.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_BroadcastRange);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.chk_ForceBroadcast);
            this.groupBox4.Location = new System.Drawing.Point(6, 66);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(147, 65);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Broadcasting";
            // 
            // txt_BroadcastRange
            // 
            this.txt_BroadcastRange.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gridClassBindingSource, "ForceBroadCastRange", true));
            this.txt_BroadcastRange.Location = new System.Drawing.Point(44, 36);
            this.txt_BroadcastRange.Name = "txt_BroadcastRange";
            this.txt_BroadcastRange.Size = new System.Drawing.Size(100, 20);
            this.txt_BroadcastRange.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Range:";
            // 
            // chk_ForceBroadcast
            // 
            this.chk_ForceBroadcast.AutoSize = true;
            this.chk_ForceBroadcast.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.gridClassBindingSource, "ForceBroadCast", true));
            this.chk_ForceBroadcast.Location = new System.Drawing.Point(6, 19);
            this.chk_ForceBroadcast.Name = "chk_ForceBroadcast";
            this.chk_ForceBroadcast.Size = new System.Drawing.Size(104, 17);
            this.chk_ForceBroadcast.TabIndex = 0;
            this.chk_ForceBroadcast.Text = "Force Broadcast";
            this.chk_ForceBroadcast.UseVisualStyleBackColor = true;
            // 
            // txtGridClassId
            // 
            this.txtGridClassId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gridClassBindingSource, "Id", true));
            this.txtGridClassId.Location = new System.Drawing.Point(50, 16);
            this.txtGridClassId.Name = "txtGridClassId";
            this.txtGridClassId.Size = new System.Drawing.Size(100, 20);
            this.txtGridClassId.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID:";
            // 
            // txt_GridClassName
            // 
            this.txt_GridClassName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gridClassBindingSource, "Name", true));
            this.txt_GridClassName.Location = new System.Drawing.Point(50, 40);
            this.txt_GridClassName.Name = "txt_GridClassName";
            this.txt_GridClassName.Size = new System.Drawing.Size(100, 20);
            this.txt_GridClassName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            // 
            // SaveConfigDialog
            // 
            this.SaveConfigDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveConfigDialog_FileOk);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 425);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Ship Class Configurator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modConfigBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridClassBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_GlobalSpeedLimit;
        private System.Windows.Forms.BindingSource modConfigBindingSource;
        private System.Windows.Forms.Label lblIgnoredFactionTagsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_IncludeAiFactions;
        private System.Windows.Forms.CheckBox chk_DebugMode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadConfigFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveConfigFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenConfigFileDialog;
        private System.Windows.Forms.OpenFileDialog ImportDefinitionDialog;
        private System.Windows.Forms.Label lbl_NoFlyZoneCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_EditNoFlyZones;
        private System.Windows.Forms.Button btn_EditIgnoredFactionTags;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_Classes;
        private System.Windows.Forms.BindingSource gridClassBindingSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_GridClassName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGridClassId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chk_StaticGrid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_BroadcastRange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_ForceBroadcast;
        private System.Windows.Forms.CheckBox chk_LargeMobileGrid;
        private System.Windows.Forms.CheckBox chk_SmallGrid;
        private System.Windows.Forms.Button btn_Duplicate;
        private System.Windows.Forms.Button btn_RemoveGridClass;
        private System.Windows.Forms.Button btn_AddGridClass;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_EditGeneralModifiers;
        private System.Windows.Forms.Button btn_EditBlockLimits;
        private System.Windows.Forms.Button btn_EditDamageMods;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaxBlocks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaxPerPlayer;
        private System.Windows.Forms.TextBox txtMaxPerFaction;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaxPcu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaxMass;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMinPlayers;
        private System.Windows.Forms.TextBox txtMinBlocks;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.SaveFileDialog SaveConfigDialog;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

