using Ship_Class_System_Config_Editor.FileDefinitions;

namespace Ship_Class_System_Config_Editor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            CheckBox chkBox_IncludeAiFactions;
            modConfigBindingSource = new BindingSource(components);
            lstBx_IgnoredFactionTags = new ListBox();
            ignoreFactionTagsBindingSource = new BindingSource(components);
            txtFactionTag = new TextBox();
            btn_AddFactionTag = new Button();
            btn_RemoveFactionTag = new Button();
            label1 = new Label();
            grpbx_Factions = new GroupBox();
            gpbox_GridClasses = new GroupBox();
            btn_DupGridClass = new Button();
            btn_AddNewClass = new Button();
            btn_DeleteClass = new Button();
            lstbx_GridClasses = new ListBox();
            gridClassesBindingSource = new BindingSource(components);
            blockLimitsBindingSource = new BindingSource(components);
            grpbx_Details = new GroupBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            txt_ClassId = new TextBox();
            selectedGridClassBindingSource = new BindingSource(components);
            txtClassName = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label11 = new Label();
            txtMinPlayers = new TextBox();
            label10 = new Label();
            txtMinBlocks = new TextBox();
            label9 = new Label();
            txtMaxPerPlayer = new TextBox();
            label8 = new Label();
            txtMaxPerFaction = new TextBox();
            txtMaxMass = new TextBox();
            label7 = new Label();
            txtMaxPcu = new TextBox();
            label6 = new Label();
            txt_MaxBlocks = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            chkbx_SmallGrid = new CheckBox();
            chkbox_LgGridMobile = new CheckBox();
            LgGridStatic = new CheckBox();
            grpbx_Broadcasting = new GroupBox();
            txtBroadcastRange = new TextBox();
            label4 = new Label();
            chkbx_ForceBroadcast = new CheckBox();
            groupBox4 = new GroupBox();
            groupBox6 = new GroupBox();
            label26 = new Label();
            txtKinetic = new TextBox();
            selectedClassDamageModifiersBindingSource = new BindingSource(components);
            label25 = new Label();
            txtEnergy = new TextBox();
            label24 = new Label();
            txtEnvironment = new TextBox();
            label23 = new Label();
            txtExplosion = new TextBox();
            label22 = new Label();
            txtRocket = new TextBox();
            label21 = new Label();
            txtBullet = new TextBox();
            groupBox5 = new GroupBox();
            label37 = new Label();
            label36 = new Label();
            txtBoostCooldown = new TextBox();
            selectedClassUtilModifiersBindingSource = new BindingSource(components);
            txtBoostDuration = new TextBox();
            txtShipClassBoost = new TextBox();
            label35 = new Label();
            txtShipClassMaxSpeed = new TextBox();
            label34 = new Label();
            label20 = new Label();
            label19 = new Label();
            txtThrusterForce = new TextBox();
            txtThrusterEfficiency = new TextBox();
            label18 = new Label();
            txtRefineSpeed = new TextBox();
            label17 = new Label();
            txtRefineEfficiency = new TextBox();
            label16 = new Label();
            txtPowerProducersOutput = new TextBox();
            label15 = new Label();
            txtGyroForce = new TextBox();
            label14 = new Label();
            txtGyroEfficiency = new TextBox();
            label13 = new Label();
            label12 = new Label();
            txtDrillHarvestMultiplier = new TextBox();
            txtAssemblerSpeed = new TextBox();
            lstbx_BlockLimits = new ListBox();
            blockLimitBindingSource = new BindingSource(components);
            blockTypesBindingSource = new BindingSource(components);
            groupBox7 = new GroupBox();
            btn_PasteBlockLimit = new Button();
            btnCopyBlockLimit = new Button();
            chkBx_TurnedOffByNoFlyZone = new CheckBox();
            label27 = new Label();
            txtMaxCount = new TextBox();
            txtBlockLimitName = new TextBox();
            btnRemoveBlockLimit = new Button();
            btnAddBlockLimit = new Button();
            groupBox8 = new GroupBox();
            btnRemoveBlockType = new Button();
            btnAddBlockType = new Button();
            lstbx_BlockTypes = new ListBox();
            blockTypeBindingSource = new BindingSource(components);
            label28 = new Label();
            groupBox9 = new GroupBox();
            btnApplySelectedBlock = new Button();
            cmbBoxBlockQuickSelect = new ComboBox();
            cubeBlockBindingSource = new BindingSource(components);
            label31 = new Label();
            txtCountWeight = new TextBox();
            selectedBlockTypeBindingSource = new BindingSource(components);
            label30 = new Label();
            txtSubTypeId = new TextBox();
            label29 = new Label();
            txtTypeId = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadFileToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            loadBlockDefinitionFileToolStripMenuItem = new ToolStripMenuItem();
            groupBox10 = new GroupBox();
            txtGlobalMaxSpeed = new TextBox();
            label33 = new Label();
            groupBox11 = new GroupBox();
            groupBox12 = new GroupBox();
            lstBx_AllowedClasses = new ListBox();
            btnAddNoFlyZone = new Button();
            btnRemoveNoFlyZone = new Button();
            txtRadius = new TextBox();
            noFlyZonesBindingSource = new BindingSource(components);
            label42 = new Label();
            label41 = new Label();
            txt_ZCoord = new TextBox();
            label40 = new Label();
            txt_YCoord = new TextBox();
            label39 = new Label();
            txt_XCoord = new TextBox();
            label38 = new Label();
            txtId = new TextBox();
            lstNoFlyZones = new ListBox();
            zoneBindingSource = new BindingSource(components);
            openDefFileDialog = new OpenFileDialog();
            chkBox_IncludeAiFactions = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)modConfigBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ignoreFactionTagsBindingSource).BeginInit();
            grpbx_Factions.SuspendLayout();
            gpbox_GridClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridClassesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blockLimitsBindingSource).BeginInit();
            grpbx_Details.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selectedGridClassBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            grpbx_Broadcasting.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selectedClassDamageModifiersBindingSource).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selectedClassUtilModifiersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blockLimitBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blockTypesBindingSource).BeginInit();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)blockTypeBindingSource).BeginInit();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cubeBlockBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectedBlockTypeBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)noFlyZonesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zoneBindingSource).BeginInit();
            SuspendLayout();
            // 
            // chkBox_IncludeAiFactions
            // 
            chkBox_IncludeAiFactions.AutoSize = true;
            chkBox_IncludeAiFactions.DataBindings.Add(new Binding("Checked", modConfigBindingSource, "IncludeAiFactions", true));
            chkBox_IncludeAiFactions.Location = new Point(6, 22);
            chkBox_IncludeAiFactions.Name = "chkBox_IncludeAiFactions";
            chkBox_IncludeAiFactions.Size = new Size(126, 19);
            chkBox_IncludeAiFactions.TabIndex = 0;
            chkBox_IncludeAiFactions.Text = "Include Ai Factions";
            chkBox_IncludeAiFactions.UseVisualStyleBackColor = true;
            // 
            // lstBx_IgnoredFactionTags
            // 
            lstBx_IgnoredFactionTags.FormattingEnabled = true;
            lstBx_IgnoredFactionTags.ItemHeight = 15;
            lstBx_IgnoredFactionTags.Location = new Point(12, 62);
            lstBx_IgnoredFactionTags.Name = "lstBx_IgnoredFactionTags";
            lstBx_IgnoredFactionTags.Size = new Size(120, 154);
            lstBx_IgnoredFactionTags.TabIndex = 1;
            lstBx_IgnoredFactionTags.SelectedIndexChanged += LstBx_IgnoredFactionTags_SelectedIndexChanged;
            // 
            // ignoreFactionTagsBindingSource
            // 
            ignoreFactionTagsBindingSource.DataMember = "IgnoreFactionTags";
            ignoreFactionTagsBindingSource.DataSource = modConfigBindingSource;
            // 
            // txtFactionTag
            // 
            txtFactionTag.Location = new Point(12, 222);
            txtFactionTag.Name = "txtFactionTag";
            txtFactionTag.Size = new Size(120, 23);
            txtFactionTag.TabIndex = 2;
            // 
            // btn_AddFactionTag
            // 
            btn_AddFactionTag.Location = new Point(79, 252);
            btn_AddFactionTag.Name = "btn_AddFactionTag";
            btn_AddFactionTag.Size = new Size(53, 23);
            btn_AddFactionTag.TabIndex = 3;
            btn_AddFactionTag.Text = "+";
            btn_AddFactionTag.UseVisualStyleBackColor = true;
            btn_AddFactionTag.Click += btn_AddFactionTag_Click;
            // 
            // btn_RemoveFactionTag
            // 
            btn_RemoveFactionTag.Location = new Point(12, 252);
            btn_RemoveFactionTag.Name = "btn_RemoveFactionTag";
            btn_RemoveFactionTag.Size = new Size(48, 23);
            btn_RemoveFactionTag.TabIndex = 4;
            btn_RemoveFactionTag.Text = "-";
            btn_RemoveFactionTag.UseVisualStyleBackColor = true;
            btn_RemoveFactionTag.Click += btn_RemoveFactionTag_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 5;
            label1.Text = "Ignored Faction Tags";
            // 
            // grpbx_Factions
            // 
            grpbx_Factions.Controls.Add(chkBox_IncludeAiFactions);
            grpbx_Factions.Controls.Add(btn_RemoveFactionTag);
            grpbx_Factions.Controls.Add(label1);
            grpbx_Factions.Controls.Add(btn_AddFactionTag);
            grpbx_Factions.Controls.Add(lstBx_IgnoredFactionTags);
            grpbx_Factions.Controls.Add(txtFactionTag);
            grpbx_Factions.Location = new Point(157, 27);
            grpbx_Factions.Name = "grpbx_Factions";
            grpbx_Factions.Size = new Size(151, 285);
            grpbx_Factions.TabIndex = 6;
            grpbx_Factions.TabStop = false;
            grpbx_Factions.Text = "Factions";
            // 
            // gpbox_GridClasses
            // 
            gpbox_GridClasses.Controls.Add(btn_DupGridClass);
            gpbox_GridClasses.Controls.Add(btn_AddNewClass);
            gpbox_GridClasses.Controls.Add(btn_DeleteClass);
            gpbox_GridClasses.Controls.Add(lstbx_GridClasses);
            gpbox_GridClasses.Location = new Point(325, 35);
            gpbox_GridClasses.Name = "gpbox_GridClasses";
            gpbox_GridClasses.Size = new Size(200, 285);
            gpbox_GridClasses.TabIndex = 7;
            gpbox_GridClasses.TabStop = false;
            gpbox_GridClasses.Text = "GridClasses";
            // 
            // btn_DupGridClass
            // 
            btn_DupGridClass.Location = new Point(61, 252);
            btn_DupGridClass.Name = "btn_DupGridClass";
            btn_DupGridClass.Size = new Size(75, 23);
            btn_DupGridClass.TabIndex = 9;
            btn_DupGridClass.Text = "Duplicate";
            btn_DupGridClass.UseVisualStyleBackColor = true;
            btn_DupGridClass.Click += btn_DupGridClass_Click;
            // 
            // btn_AddNewClass
            // 
            btn_AddNewClass.Location = new Point(141, 252);
            btn_AddNewClass.Name = "btn_AddNewClass";
            btn_AddNewClass.Size = new Size(53, 23);
            btn_AddNewClass.TabIndex = 8;
            btn_AddNewClass.Text = "+";
            btn_AddNewClass.UseVisualStyleBackColor = true;
            btn_AddNewClass.Click += btn_AddNewClass_Click;
            // 
            // btn_DeleteClass
            // 
            btn_DeleteClass.Location = new Point(6, 252);
            btn_DeleteClass.Name = "btn_DeleteClass";
            btn_DeleteClass.Size = new Size(49, 23);
            btn_DeleteClass.TabIndex = 8;
            btn_DeleteClass.Text = "-";
            btn_DeleteClass.UseVisualStyleBackColor = true;
            btn_DeleteClass.Click += btn_DeleteClass_Click;
            // 
            // lstbx_GridClasses
            // 
            lstbx_GridClasses.DataSource = gridClassesBindingSource;
            lstbx_GridClasses.DisplayMember = "Name";
            lstbx_GridClasses.FormattingEnabled = true;
            lstbx_GridClasses.ItemHeight = 15;
            lstbx_GridClasses.Location = new Point(6, 17);
            lstbx_GridClasses.Name = "lstbx_GridClasses";
            lstbx_GridClasses.Size = new Size(188, 229);
            lstbx_GridClasses.TabIndex = 8;
            lstbx_GridClasses.SelectedIndexChanged += lstbx_GridClasses_SelectedIndexChanged;
            // 
            // gridClassesBindingSource
            // 
            gridClassesBindingSource.DataMember = "GridClasses";
            gridClassesBindingSource.DataSource = modConfigBindingSource;
            // 
            // blockLimitsBindingSource
            // 
            blockLimitsBindingSource.DataMember = "BlockLimits";
            blockLimitsBindingSource.DataSource = gridClassesBindingSource;
            // 
            // grpbx_Details
            // 
            grpbx_Details.Controls.Add(groupBox3);
            grpbx_Details.Controls.Add(groupBox2);
            grpbx_Details.Controls.Add(groupBox1);
            grpbx_Details.Controls.Add(grpbx_Broadcasting);
            grpbx_Details.Location = new Point(520, 27);
            grpbx_Details.Name = "grpbx_Details";
            grpbx_Details.Size = new Size(377, 364);
            grpbx_Details.TabIndex = 8;
            grpbx_Details.TabStop = false;
            grpbx_Details.Text = "Details";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txt_ClassId);
            groupBox3.Controls.Add(txtClassName);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(11, 13);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(157, 75);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 13);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 2;
            label3.Text = "Id:";
            // 
            // txt_ClassId
            // 
            txt_ClassId.DataBindings.Add(new Binding("Text", selectedGridClassBindingSource, "Id", true));
            txt_ClassId.Location = new Point(49, 10);
            txt_ClassId.Name = "txt_ClassId";
            txt_ClassId.Size = new Size(33, 23);
            txt_ClassId.TabIndex = 4;
            // 
            // selectedGridClassBindingSource
            // 
            selectedGridClassBindingSource.DataSource = typeof(GridClass);
            // 
            // txtClassName
            // 
            txtClassName.DataBindings.Add(new Binding("Text", selectedGridClassBindingSource, "Name", true));
            txtClassName.Location = new Point(49, 39);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(100, 23);
            txtClassName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 42);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtMinPlayers);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtMinBlocks);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtMaxPerPlayer);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtMaxPerFaction);
            groupBox2.Controls.Add(txtMaxMass);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtMaxPcu);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_MaxBlocks);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(11, 200);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(354, 151);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Grid Limits";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(213, 87);
            label11.Name = "label11";
            label11.Size = new Size(71, 15);
            label11.TabIndex = 10;
            label11.Text = "Min Players:";
            // 
            // txtMinPlayers
            // 
            txtMinPlayers.DataBindings.Add(new Binding("Text", selectedGridClassBindingSource, "MinPlayers", true));
            txtMinPlayers.Location = new Point(290, 82);
            txtMinPlayers.Name = "txtMinPlayers";
            txtMinPlayers.Size = new Size(35, 23);
            txtMinPlayers.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 44);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 10;
            label10.Text = "MinBlocks:";
            // 
            // txtMinBlocks
            // 
            txtMinBlocks.DataBindings.Add(new Binding("Text", selectedGridClassBindingSource, "MinBlocks", true));
            txtMinBlocks.Location = new Point(82, 41);
            txtMinBlocks.Name = "txtMinBlocks";
            txtMinBlocks.Size = new Size(51, 23);
            txtMinBlocks.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(196, 58);
            label9.Name = "label9";
            label9.Size = new Size(88, 15);
            label9.TabIndex = 10;
            label9.Text = "Max per Player:";
            // 
            // txtMaxPerPlayer
            // 
            txtMaxPerPlayer.DataBindings.Add(new Binding("Text", selectedGridClassBindingSource, "MaxPerPlayer", true));
            txtMaxPerPlayer.Location = new Point(290, 55);
            txtMaxPerPlayer.Name = "txtMaxPerPlayer";
            txtMaxPerPlayer.Size = new Size(35, 23);
            txtMaxPerPlayer.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(189, 31);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 7;
            label8.Text = "Max per Faction:";
            // 
            // txtMaxPerFaction
            // 
            txtMaxPerFaction.DataBindings.Add(new Binding("Text", selectedGridClassBindingSource, "MaxPerFaction", true));
            txtMaxPerFaction.Location = new Point(290, 26);
            txtMaxPerFaction.Name = "txtMaxPerFaction";
            txtMaxPerFaction.Size = new Size(35, 23);
            txtMaxPerFaction.TabIndex = 6;
            // 
            // txtMaxMass
            // 
            txtMaxMass.DataBindings.Add(new Binding("Text", selectedGridClassBindingSource, "MaxMass", true));
            txtMaxMass.Location = new Point(82, 99);
            txtMaxMass.Name = "txtMaxMass";
            txtMaxMass.Size = new Size(51, 23);
            txtMaxMass.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 102);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 4;
            label7.Text = "Max Mass:";
            // 
            // txtMaxPcu
            // 
            txtMaxPcu.DataBindings.Add(new Binding("Text", selectedGridClassBindingSource, "MaxPCU", true));
            txtMaxPcu.Location = new Point(82, 70);
            txtMaxPcu.Name = "txtMaxPcu";
            txtMaxPcu.Size = new Size(51, 23);
            txtMaxPcu.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 73);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 2;
            label6.Text = "Max PCU:";
            // 
            // txt_MaxBlocks
            // 
            txt_MaxBlocks.DataBindings.Add(new Binding("Text", selectedGridClassBindingSource, "MaxBlocks", true));
            txt_MaxBlocks.Location = new Point(82, 14);
            txt_MaxBlocks.Name = "txt_MaxBlocks";
            txt_MaxBlocks.Size = new Size(51, 23);
            txt_MaxBlocks.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 17);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 0;
            label5.Text = "Max Blocks:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkbx_SmallGrid);
            groupBox1.Controls.Add(chkbox_LgGridMobile);
            groupBox1.Controls.Add(LgGridStatic);
            groupBox1.Location = new Point(12, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 100);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Grid Type";
            // 
            // chkbx_SmallGrid
            // 
            chkbx_SmallGrid.AutoSize = true;
            chkbx_SmallGrid.DataBindings.Add(new Binding("Checked", selectedGridClassBindingSource, "SmallGrid", true));
            chkbx_SmallGrid.Location = new Point(6, 72);
            chkbx_SmallGrid.Name = "chkbx_SmallGrid";
            chkbx_SmallGrid.Size = new Size(80, 19);
            chkbx_SmallGrid.TabIndex = 2;
            chkbx_SmallGrid.Text = "Small Grid";
            chkbx_SmallGrid.UseVisualStyleBackColor = true;
            // 
            // chkbox_LgGridMobile
            // 
            chkbox_LgGridMobile.AutoSize = true;
            chkbox_LgGridMobile.DataBindings.Add(new Binding("Checked", selectedGridClassBindingSource, "LargeGridMobile", true));
            chkbox_LgGridMobile.Location = new Point(6, 47);
            chkbox_LgGridMobile.Name = "chkbox_LgGridMobile";
            chkbox_LgGridMobile.Size = new Size(120, 19);
            chkbox_LgGridMobile.TabIndex = 1;
            chkbox_LgGridMobile.Text = "Large Grid Mobile";
            chkbox_LgGridMobile.UseVisualStyleBackColor = true;
            // 
            // LgGridStatic
            // 
            LgGridStatic.AutoSize = true;
            LgGridStatic.DataBindings.Add(new Binding("Checked", selectedGridClassBindingSource, "LargeGridStatic", true));
            LgGridStatic.Location = new Point(6, 22);
            LgGridStatic.Name = "LgGridStatic";
            LgGridStatic.Size = new Size(112, 19);
            LgGridStatic.TabIndex = 0;
            LgGridStatic.Text = "Large Grid Static";
            LgGridStatic.UseVisualStyleBackColor = true;
            // 
            // grpbx_Broadcasting
            // 
            grpbx_Broadcasting.Controls.Add(txtBroadcastRange);
            grpbx_Broadcasting.Controls.Add(label4);
            grpbx_Broadcasting.Controls.Add(chkbx_ForceBroadcast);
            grpbx_Broadcasting.Location = new Point(174, 16);
            grpbx_Broadcasting.Name = "grpbx_Broadcasting";
            grpbx_Broadcasting.Size = new Size(191, 72);
            grpbx_Broadcasting.TabIndex = 6;
            grpbx_Broadcasting.TabStop = false;
            grpbx_Broadcasting.Text = "Broadcasting";
            // 
            // txtBroadcastRange
            // 
            txtBroadcastRange.DataBindings.Add(new Binding("Text", selectedGridClassBindingSource, "ForceBroadCastRange", true));
            txtBroadcastRange.Location = new Point(124, 41);
            txtBroadcastRange.Name = "txtBroadcastRange";
            txtBroadcastRange.Size = new Size(63, 23);
            txtBroadcastRange.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 44);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 6;
            label4.Text = "Broadcasting Range:";
            // 
            // chkbx_ForceBroadcast
            // 
            chkbx_ForceBroadcast.AutoSize = true;
            chkbx_ForceBroadcast.DataBindings.Add(new Binding("Checked", selectedGridClassBindingSource, "ForceBroadCast", true));
            chkbx_ForceBroadcast.Location = new Point(6, 22);
            chkbx_ForceBroadcast.Name = "chkbx_ForceBroadcast";
            chkbx_ForceBroadcast.Size = new Size(107, 19);
            chkbx_ForceBroadcast.TabIndex = 5;
            chkbx_ForceBroadcast.Text = "ForceBroadcast";
            chkbx_ForceBroadcast.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Location = new Point(903, 27);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(386, 364);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Modifiers";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label26);
            groupBox6.Controls.Add(txtKinetic);
            groupBox6.Controls.Add(label25);
            groupBox6.Controls.Add(txtEnergy);
            groupBox6.Controls.Add(label24);
            groupBox6.Controls.Add(txtEnvironment);
            groupBox6.Controls.Add(label23);
            groupBox6.Controls.Add(txtExplosion);
            groupBox6.Controls.Add(label22);
            groupBox6.Controls.Add(txtRocket);
            groupBox6.Controls.Add(label21);
            groupBox6.Controls.Add(txtBullet);
            groupBox6.Location = new Point(67, 244);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(248, 111);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Damage Modifiers";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(146, 82);
            label26.Name = "label26";
            label26.Size = new Size(46, 15);
            label26.TabIndex = 4;
            label26.Text = "Kinetic:";
            // 
            // txtKinetic
            // 
            txtKinetic.DataBindings.Add(new Binding("Text", selectedClassDamageModifiersBindingSource, "Kinetic", true));
            txtKinetic.Location = new Point(198, 79);
            txtKinetic.Name = "txtKinetic";
            txtKinetic.Size = new Size(31, 23);
            txtKinetic.TabIndex = 4;
            // 
            // selectedClassDamageModifiersBindingSource
            // 
            selectedClassDamageModifiersBindingSource.DataSource = typeof(DamageModifiers);
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(146, 51);
            label25.Name = "label25";
            label25.Size = new Size(46, 15);
            label25.TabIndex = 14;
            label25.Text = "Energy:";
            // 
            // txtEnergy
            // 
            txtEnergy.DataBindings.Add(new Binding("Text", selectedClassDamageModifiersBindingSource, "Energy", true));
            txtEnergy.Location = new Point(198, 48);
            txtEnergy.Name = "txtEnergy";
            txtEnergy.Size = new Size(31, 23);
            txtEnergy.TabIndex = 13;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(114, 22);
            label24.Name = "label24";
            label24.Size = new Size(78, 15);
            label24.TabIndex = 12;
            label24.Text = "Environment:";
            // 
            // txtEnvironment
            // 
            txtEnvironment.DataBindings.Add(new Binding("Text", selectedClassDamageModifiersBindingSource, "Environment", true));
            txtEnvironment.Location = new Point(198, 19);
            txtEnvironment.Name = "txtEnvironment";
            txtEnvironment.Size = new Size(31, 23);
            txtEnvironment.TabIndex = 11;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(6, 79);
            label23.Name = "label23";
            label23.Size = new Size(61, 15);
            label23.TabIndex = 10;
            label23.Text = "Explosion:";
            // 
            // txtExplosion
            // 
            txtExplosion.DataBindings.Add(new Binding("Text", selectedClassDamageModifiersBindingSource, "Explosion", true));
            txtExplosion.Location = new Point(73, 76);
            txtExplosion.Name = "txtExplosion";
            txtExplosion.Size = new Size(31, 23);
            txtExplosion.TabIndex = 4;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(21, 51);
            label22.Name = "label22";
            label22.Size = new Size(46, 15);
            label22.TabIndex = 3;
            label22.Text = "Rocket:";
            // 
            // txtRocket
            // 
            txtRocket.DataBindings.Add(new Binding("Text", selectedClassDamageModifiersBindingSource, "Rocket", true));
            txtRocket.Location = new Point(73, 48);
            txtRocket.Name = "txtRocket";
            txtRocket.Size = new Size(31, 23);
            txtRocket.TabIndex = 2;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(27, 23);
            label21.Name = "label21";
            label21.Size = new Size(40, 15);
            label21.TabIndex = 1;
            label21.Text = "Bullet:";
            // 
            // txtBullet
            // 
            txtBullet.DataBindings.Add(new Binding("Text", selectedClassDamageModifiersBindingSource, "Bullet", true));
            txtBullet.Location = new Point(73, 19);
            txtBullet.Name = "txtBullet";
            txtBullet.Size = new Size(31, 23);
            txtBullet.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label37);
            groupBox5.Controls.Add(label36);
            groupBox5.Controls.Add(txtBoostCooldown);
            groupBox5.Controls.Add(txtBoostDuration);
            groupBox5.Controls.Add(txtShipClassBoost);
            groupBox5.Controls.Add(label35);
            groupBox5.Controls.Add(txtShipClassMaxSpeed);
            groupBox5.Controls.Add(label34);
            groupBox5.Controls.Add(label20);
            groupBox5.Controls.Add(label19);
            groupBox5.Controls.Add(txtThrusterForce);
            groupBox5.Controls.Add(txtThrusterEfficiency);
            groupBox5.Controls.Add(label18);
            groupBox5.Controls.Add(txtRefineSpeed);
            groupBox5.Controls.Add(label17);
            groupBox5.Controls.Add(txtRefineEfficiency);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(txtPowerProducersOutput);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(txtGyroForce);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(txtGyroEfficiency);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(txtDrillHarvestMultiplier);
            groupBox5.Controls.Add(txtAssemblerSpeed);
            groupBox5.Location = new Point(6, 22);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(370, 223);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Utility Modifiers";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(180, 190);
            label37.Name = "label37";
            label37.Size = new Size(98, 15);
            label37.TabIndex = 20;
            label37.Text = "Boost Cooldown:";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(39, 190);
            label36.Name = "label36";
            label36.Size = new Size(89, 15);
            label36.TabIndex = 20;
            label36.Text = "Boost Duration:";
            // 
            // txtBoostCooldown
            // 
            txtBoostCooldown.DataBindings.Add(new Binding("Text", selectedClassUtilModifiersBindingSource, "BoostCoolDown", true));
            txtBoostCooldown.Location = new Point(284, 187);
            txtBoostCooldown.Name = "txtBoostCooldown";
            txtBoostCooldown.Size = new Size(33, 23);
            txtBoostCooldown.TabIndex = 20;
            // 
            // selectedClassUtilModifiersBindingSource
            // 
            selectedClassUtilModifiersBindingSource.DataSource = typeof(UtilModifiers);
            // 
            // txtBoostDuration
            // 
            txtBoostDuration.DataBindings.Add(new Binding("Text", selectedClassUtilModifiersBindingSource, "BoostDuration", true));
            txtBoostDuration.Location = new Point(134, 187);
            txtBoostDuration.Name = "txtBoostDuration";
            txtBoostDuration.Size = new Size(31, 23);
            txtBoostDuration.TabIndex = 20;
            // 
            // txtShipClassBoost
            // 
            txtShipClassBoost.DataBindings.Add(new Binding("Text", selectedClassUtilModifiersBindingSource, "MaxBoost", true));
            txtShipClassBoost.Location = new Point(133, 159);
            txtShipClassBoost.Name = "txtShipClassBoost";
            txtShipClassBoost.Size = new Size(32, 23);
            txtShipClassBoost.TabIndex = 20;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(61, 162);
            label35.Name = "label35";
            label35.Size = new Size(66, 15);
            label35.TabIndex = 20;
            label35.Text = "Max Boost:";
            // 
            // txtShipClassMaxSpeed
            // 
            txtShipClassMaxSpeed.DataBindings.Add(new Binding("Text", selectedClassUtilModifiersBindingSource, "MaxSpeed", true));
            txtShipClassMaxSpeed.Location = new Point(134, 130);
            txtShipClassMaxSpeed.Name = "txtShipClassMaxSpeed";
            txtShipClassMaxSpeed.Size = new Size(31, 23);
            txtShipClassMaxSpeed.TabIndex = 20;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(63, 133);
            label34.Name = "label34";
            label34.Size = new Size(68, 15);
            label34.TabIndex = 21;
            label34.Text = "Max Speed:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(235, 130);
            label20.Name = "label20";
            label20.Size = new Size(85, 15);
            label20.TabIndex = 3;
            label20.Text = "Thruster Force:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(213, 101);
            label19.Name = "label19";
            label19.Size = new Size(107, 15);
            label19.TabIndex = 3;
            label19.Text = "Thruster Efficiency:";
            // 
            // txtThrusterForce
            // 
            txtThrusterForce.DataBindings.Add(new Binding("Text", selectedClassUtilModifiersBindingSource, "ThrusterForce", true));
            txtThrusterForce.Location = new Point(326, 127);
            txtThrusterForce.Name = "txtThrusterForce";
            txtThrusterForce.Size = new Size(31, 23);
            txtThrusterForce.TabIndex = 3;
            // 
            // txtThrusterEfficiency
            // 
            txtThrusterEfficiency.DataBindings.Add(new Binding("Text", selectedClassUtilModifiersBindingSource, "ThrusterEfficiency", true));
            txtThrusterEfficiency.Location = new Point(326, 98);
            txtThrusterEfficiency.Name = "txtThrusterEfficiency";
            txtThrusterEfficiency.Size = new Size(31, 23);
            txtThrusterEfficiency.TabIndex = 4;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(242, 74);
            label18.Name = "label18";
            label18.Size = new Size(78, 15);
            label18.TabIndex = 13;
            label18.Text = "Refine Speed:";
            // 
            // txtRefineSpeed
            // 
            txtRefineSpeed.DataBindings.Add(new Binding("Text", selectedClassUtilModifiersBindingSource, "RefineSpeed", true));
            txtRefineSpeed.Location = new Point(326, 69);
            txtRefineSpeed.Name = "txtRefineSpeed";
            txtRefineSpeed.Size = new Size(31, 23);
            txtRefineSpeed.TabIndex = 12;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(223, 43);
            label17.Name = "label17";
            label17.Size = new Size(97, 15);
            label17.TabIndex = 11;
            label17.Text = "Refine Efficiency:";
            // 
            // txtRefineEfficiency
            // 
            txtRefineEfficiency.DataBindings.Add(new Binding("Text", selectedClassUtilModifiersBindingSource, "RefineEfficiency", true));
            txtRefineEfficiency.Location = new Point(326, 40);
            txtRefineEfficiency.Name = "txtRefineEfficiency";
            txtRefineEfficiency.Size = new Size(31, 23);
            txtRefineEfficiency.TabIndex = 10;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(180, 17);
            label16.Name = "label16";
            label16.Size = new Size(140, 15);
            label16.TabIndex = 3;
            label16.Text = "Power Producers Output:";
            // 
            // txtPowerProducersOutput
            // 
            txtPowerProducersOutput.DataBindings.Add(new Binding("Text", selectedClassUtilModifiersBindingSource, "PowerProducersOutput", true));
            txtPowerProducersOutput.Location = new Point(326, 14);
            txtPowerProducersOutput.Name = "txtPowerProducersOutput";
            txtPowerProducersOutput.Size = new Size(31, 23);
            txtPowerProducersOutput.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(61, 104);
            label15.Name = "label15";
            label15.Size = new Size(67, 15);
            label15.TabIndex = 8;
            label15.Text = "Gyro Force:";
            // 
            // txtGyroForce
            // 
            txtGyroForce.DataBindings.Add(new Binding("Text", selectedClassUtilModifiersBindingSource, "GyroForce", true));
            txtGyroForce.Location = new Point(134, 101);
            txtGyroForce.Name = "txtGyroForce";
            txtGyroForce.Size = new Size(31, 23);
            txtGyroForce.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(39, 75);
            label14.Name = "label14";
            label14.Size = new Size(89, 15);
            label14.TabIndex = 6;
            label14.Text = "Gyro Efficiency:";
            // 
            // txtGyroEfficiency
            // 
            txtGyroEfficiency.DataBindings.Add(new Binding("Text", selectedClassUtilModifiersBindingSource, "GyroEfficiency", true));
            txtGyroEfficiency.Location = new Point(134, 72);
            txtGyroEfficiency.Name = "txtGyroEfficiency";
            txtGyroEfficiency.Size = new Size(31, 23);
            txtGyroEfficiency.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 46);
            label13.Name = "label13";
            label13.Size = new Size(125, 15);
            label13.TabIndex = 4;
            label13.Text = "Drill Harvest Multipler:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(28, 17);
            label12.Name = "label12";
            label12.Size = new Size(100, 15);
            label12.TabIndex = 1;
            label12.Text = "Assembler Speed:";
            // 
            // txtDrillHarvestMultiplier
            // 
            txtDrillHarvestMultiplier.DataBindings.Add(new Binding("Text", selectedClassUtilModifiersBindingSource, "DrillHarvestMultipler", true));
            txtDrillHarvestMultiplier.Location = new Point(134, 43);
            txtDrillHarvestMultiplier.Name = "txtDrillHarvestMultiplier";
            txtDrillHarvestMultiplier.Size = new Size(31, 23);
            txtDrillHarvestMultiplier.TabIndex = 3;
            // 
            // txtAssemblerSpeed
            // 
            txtAssemblerSpeed.DataBindings.Add(new Binding("Text", selectedClassUtilModifiersBindingSource, "AssemblerSpeed", true));
            txtAssemblerSpeed.Location = new Point(134, 14);
            txtAssemblerSpeed.Name = "txtAssemblerSpeed";
            txtAssemblerSpeed.Size = new Size(31, 23);
            txtAssemblerSpeed.TabIndex = 0;
            // 
            // lstbx_BlockLimits
            // 
            lstbx_BlockLimits.DataBindings.Add(new Binding("DataContext", blockLimitsBindingSource, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            lstbx_BlockLimits.DataSource = blockLimitsBindingSource;
            lstbx_BlockLimits.DisplayMember = "Name";
            lstbx_BlockLimits.FormattingEnabled = true;
            lstbx_BlockLimits.ItemHeight = 15;
            lstbx_BlockLimits.Location = new Point(6, 22);
            lstbx_BlockLimits.Name = "lstbx_BlockLimits";
            lstbx_BlockLimits.Size = new Size(183, 244);
            lstbx_BlockLimits.TabIndex = 0;
            lstbx_BlockLimits.SelectedIndexChanged += lstbx_BlockLimits_SelectedIndexChanged;
            // 
            // blockLimitBindingSource
            // 
            blockLimitBindingSource.DataSource = typeof(BlockLimit);
            // 
            // blockTypesBindingSource
            // 
            blockTypesBindingSource.DataMember = "BlockTypes";
            blockTypesBindingSource.DataSource = blockLimitsBindingSource;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(btn_PasteBlockLimit);
            groupBox7.Controls.Add(btnCopyBlockLimit);
            groupBox7.Controls.Add(chkBx_TurnedOffByNoFlyZone);
            groupBox7.Controls.Add(label27);
            groupBox7.Controls.Add(txtMaxCount);
            groupBox7.Controls.Add(txtBlockLimitName);
            groupBox7.Controls.Add(btnRemoveBlockLimit);
            groupBox7.Controls.Add(btnAddBlockLimit);
            groupBox7.Controls.Add(lstbx_BlockLimits);
            groupBox7.Location = new Point(455, 400);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(195, 417);
            groupBox7.TabIndex = 10;
            groupBox7.TabStop = false;
            groupBox7.Text = "Block Limits";
            // 
            // btn_PasteBlockLimit
            // 
            btn_PasteBlockLimit.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_PasteBlockLimit.Location = new Point(58, 374);
            btn_PasteBlockLimit.Name = "btn_PasteBlockLimit";
            btn_PasteBlockLimit.Size = new Size(75, 27);
            btn_PasteBlockLimit.TabIndex = 21;
            btn_PasteBlockLimit.Text = "Paste";
            btn_PasteBlockLimit.UseVisualStyleBackColor = true;
            btn_PasteBlockLimit.Click += btn_PasteBlockLimit_Click;
            // 
            // btnCopyBlockLimit
            // 
            btnCopyBlockLimit.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCopyBlockLimit.Location = new Point(58, 344);
            btnCopyBlockLimit.Name = "btnCopyBlockLimit";
            btnCopyBlockLimit.Size = new Size(75, 24);
            btnCopyBlockLimit.TabIndex = 21;
            btnCopyBlockLimit.Text = "Copy";
            btnCopyBlockLimit.UseVisualStyleBackColor = true;
            btnCopyBlockLimit.Click += btnCopyBlockLimit_Click;
            // 
            // chkBx_TurnedOffByNoFlyZone
            // 
            chkBx_TurnedOffByNoFlyZone.AutoSize = true;
            chkBx_TurnedOffByNoFlyZone.DataBindings.Add(new Binding("CheckState", blockLimitsBindingSource, "TurnedOffByNoFlyZone", true, DataSourceUpdateMode.OnPropertyChanged));
            chkBx_TurnedOffByNoFlyZone.Location = new Point(7, 319);
            chkBx_TurnedOffByNoFlyZone.Name = "chkBx_TurnedOffByNoFlyZone";
            chkBx_TurnedOffByNoFlyZone.Size = new Size(166, 19);
            chkBx_TurnedOffByNoFlyZone.TabIndex = 20;
            chkBx_TurnedOffByNoFlyZone.Text = "Turned Off By No Fly Zone";
            chkBx_TurnedOffByNoFlyZone.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(6, 293);
            label27.Name = "label27";
            label27.Size = new Size(69, 15);
            label27.TabIndex = 19;
            label27.Text = "Max Count:";
            // 
            // txtMaxCount
            // 
            txtMaxCount.DataBindings.Add(new Binding("Text", blockLimitsBindingSource, "MaxCount", true));
            txtMaxCount.Location = new Point(79, 290);
            txtMaxCount.Name = "txtMaxCount";
            txtMaxCount.Size = new Size(110, 23);
            txtMaxCount.TabIndex = 19;
            // 
            // txtBlockLimitName
            // 
            txtBlockLimitName.DataBindings.Add(new Binding("Text", blockLimitsBindingSource, "Name", true));
            txtBlockLimitName.Location = new Point(6, 261);
            txtBlockLimitName.Name = "txtBlockLimitName";
            txtBlockLimitName.Size = new Size(183, 23);
            txtBlockLimitName.TabIndex = 17;
            // 
            // btnRemoveBlockLimit
            // 
            btnRemoveBlockLimit.Location = new Point(7, 359);
            btnRemoveBlockLimit.Name = "btnRemoveBlockLimit";
            btnRemoveBlockLimit.Size = new Size(31, 23);
            btnRemoveBlockLimit.TabIndex = 2;
            btnRemoveBlockLimit.Text = "-";
            btnRemoveBlockLimit.UseVisualStyleBackColor = true;
            btnRemoveBlockLimit.Click += btnRemoveBlockLimit_Click;
            // 
            // btnAddBlockLimit
            // 
            btnAddBlockLimit.Location = new Point(150, 359);
            btnAddBlockLimit.Name = "btnAddBlockLimit";
            btnAddBlockLimit.Size = new Size(39, 23);
            btnAddBlockLimit.TabIndex = 1;
            btnAddBlockLimit.Text = "+";
            btnAddBlockLimit.UseVisualStyleBackColor = true;
            btnAddBlockLimit.Click += btnAddBlockLimit_Click;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(btnRemoveBlockType);
            groupBox8.Controls.Add(btnAddBlockType);
            groupBox8.Controls.Add(lstbx_BlockTypes);
            groupBox8.Location = new Point(656, 400);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(307, 417);
            groupBox8.TabIndex = 12;
            groupBox8.TabStop = false;
            groupBox8.Text = "Block Types";
            // 
            // btnRemoveBlockType
            // 
            btnRemoveBlockType.Location = new Point(6, 388);
            btnRemoveBlockType.Name = "btnRemoveBlockType";
            btnRemoveBlockType.Size = new Size(75, 23);
            btnRemoveBlockType.TabIndex = 17;
            btnRemoveBlockType.Text = "-";
            btnRemoveBlockType.UseVisualStyleBackColor = true;
            btnRemoveBlockType.Click += btnRemoveBlockType_Click;
            // 
            // btnAddBlockType
            // 
            btnAddBlockType.Location = new Point(226, 388);
            btnAddBlockType.Name = "btnAddBlockType";
            btnAddBlockType.Size = new Size(75, 23);
            btnAddBlockType.TabIndex = 1;
            btnAddBlockType.Text = "+";
            btnAddBlockType.UseVisualStyleBackColor = true;
            btnAddBlockType.Click += btnAddBlockType_Click;
            // 
            // lstbx_BlockTypes
            // 
            lstbx_BlockTypes.Cursor = Cursors.IBeam;
            lstbx_BlockTypes.DataBindings.Add(new Binding("DataContext", blockTypeBindingSource, "SubtypeId", true));
            lstbx_BlockTypes.FormattingEnabled = true;
            lstbx_BlockTypes.ItemHeight = 15;
            lstbx_BlockTypes.Location = new Point(6, 22);
            lstbx_BlockTypes.Name = "lstbx_BlockTypes";
            lstbx_BlockTypes.Size = new Size(295, 244);
            lstbx_BlockTypes.TabIndex = 0;
            lstbx_BlockTypes.SelectedIndexChanged += lstbx_BlockTypes_SelectedIndexChanged;
            // 
            // blockTypeBindingSource
            // 
            blockTypeBindingSource.DataSource = typeof(BlockType);
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(969, 576);
            label28.Name = "label28";
            label28.Size = new Size(23, 15);
            label28.TabIndex = 13;
            label28.Text = ">>";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(btnApplySelectedBlock);
            groupBox9.Controls.Add(cmbBoxBlockQuickSelect);
            groupBox9.Controls.Add(label31);
            groupBox9.Controls.Add(txtCountWeight);
            groupBox9.Controls.Add(label30);
            groupBox9.Controls.Add(txtSubTypeId);
            groupBox9.Controls.Add(label29);
            groupBox9.Controls.Add(txtTypeId);
            groupBox9.Location = new Point(998, 521);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(326, 145);
            groupBox9.TabIndex = 14;
            groupBox9.TabStop = false;
            groupBox9.Text = "Block Settings";
            // 
            // btnApplySelectedBlock
            // 
            btnApplySelectedBlock.Location = new Point(292, 81);
            btnApplySelectedBlock.Name = "btnApplySelectedBlock";
            btnApplySelectedBlock.Size = new Size(28, 23);
            btnApplySelectedBlock.TabIndex = 21;
            btnApplySelectedBlock.Text = "*";
            btnApplySelectedBlock.UseVisualStyleBackColor = true;
            btnApplySelectedBlock.Click += btnApplySelectedBlock_Click;
            // 
            // cmbBoxBlockQuickSelect
            // 
            cmbBoxBlockQuickSelect.DataBindings.Add(new Binding("Text", cubeBlockBindingSource, "DisplayName", true));
            cmbBoxBlockQuickSelect.FormattingEnabled = true;
            cmbBoxBlockQuickSelect.Location = new Point(6, 81);
            cmbBoxBlockQuickSelect.Name = "cmbBoxBlockQuickSelect";
            cmbBoxBlockQuickSelect.Size = new Size(285, 23);
            cmbBoxBlockQuickSelect.TabIndex = 6;
            // 
            // cubeBlockBindingSource
            // 
            cubeBlockBindingSource.DataSource = typeof(CubeBlock);
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(6, 113);
            label31.Name = "label31";
            label31.Size = new Size(84, 15);
            label31.TabIndex = 5;
            label31.Text = "Count Weight:";
            // 
            // txtCountWeight
            // 
            txtCountWeight.DataBindings.Add(new Binding("Text", selectedBlockTypeBindingSource, "CountWeight", true));
            txtCountWeight.Location = new Point(96, 110);
            txtCountWeight.Name = "txtCountWeight";
            txtCountWeight.Size = new Size(114, 23);
            txtCountWeight.TabIndex = 4;
            // 
            // selectedBlockTypeBindingSource
            // 
            selectedBlockTypeBindingSource.DataSource = typeof(BlockType);
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(26, 55);
            label30.Name = "label30";
            label30.Size = new Size(64, 15);
            label30.TabIndex = 3;
            label30.Text = "SubTypeId:";
            // 
            // txtSubTypeId
            // 
            txtSubTypeId.DataBindings.Add(new Binding("Text", selectedBlockTypeBindingSource, "SubtypeId", true));
            txtSubTypeId.Location = new Point(96, 52);
            txtSubTypeId.Name = "txtSubTypeId";
            txtSubTypeId.Size = new Size(172, 23);
            txtSubTypeId.TabIndex = 2;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(46, 26);
            label29.Name = "label29";
            label29.Size = new Size(44, 15);
            label29.TabIndex = 1;
            label29.Text = "TypeId:";
            // 
            // txtTypeId
            // 
            txtTypeId.DataBindings.Add(new Binding("Text", selectedBlockTypeBindingSource, "TypeId", true));
            txtTypeId.Location = new Point(96, 23);
            txtTypeId.Name = "txtTypeId";
            txtTypeId.Size = new Size(172, 23);
            txtTypeId.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1336, 24);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadFileToolStripMenuItem, saveFileToolStripMenuItem, loadBlockDefinitionFileToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadFileToolStripMenuItem
            // 
            loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            loadFileToolStripMenuItem.Size = new Size(208, 22);
            loadFileToolStripMenuItem.Text = "Load File";
            loadFileToolStripMenuItem.Click += loadFileToolStripMenuItem_Click;
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(208, 22);
            saveFileToolStripMenuItem.Text = "Save File";
            saveFileToolStripMenuItem.Click += saveFileToolStripMenuItem_Click;
            // 
            // loadBlockDefinitionFileToolStripMenuItem
            // 
            loadBlockDefinitionFileToolStripMenuItem.Name = "loadBlockDefinitionFileToolStripMenuItem";
            loadBlockDefinitionFileToolStripMenuItem.Size = new Size(208, 22);
            loadBlockDefinitionFileToolStripMenuItem.Text = "Load Block Definition File";
            loadBlockDefinitionFileToolStripMenuItem.Click += loadBlockDefinitionFileToolStripMenuItem_Click;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(txtGlobalMaxSpeed);
            groupBox10.Controls.Add(label33);
            groupBox10.Location = new Point(12, 27);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(139, 54);
            groupBox10.TabIndex = 19;
            groupBox10.TabStop = false;
            groupBox10.Text = "Global";
            // 
            // txtGlobalMaxSpeed
            // 
            txtGlobalMaxSpeed.DataBindings.Add(new Binding("Text", modConfigBindingSource, "MaxPossibleSpeedMetersPerSecond", true));
            txtGlobalMaxSpeed.Location = new Point(71, 16);
            txtGlobalMaxSpeed.Name = "txtGlobalMaxSpeed";
            txtGlobalMaxSpeed.Size = new Size(62, 23);
            txtGlobalMaxSpeed.TabIndex = 20;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(6, 19);
            label33.Name = "label33";
            label33.Size = new Size(65, 15);
            label33.TabIndex = 20;
            label33.Text = "Max Speed";
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(groupBox12);
            groupBox11.Controls.Add(btnAddNoFlyZone);
            groupBox11.Controls.Add(btnRemoveNoFlyZone);
            groupBox11.Controls.Add(txtRadius);
            groupBox11.Controls.Add(label42);
            groupBox11.Controls.Add(label41);
            groupBox11.Controls.Add(txt_ZCoord);
            groupBox11.Controls.Add(label40);
            groupBox11.Controls.Add(txt_YCoord);
            groupBox11.Controls.Add(label39);
            groupBox11.Controls.Add(txt_XCoord);
            groupBox11.Controls.Add(label38);
            groupBox11.Controls.Add(txtId);
            groupBox11.Controls.Add(lstNoFlyZones);
            groupBox11.Location = new Point(23, 400);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(357, 417);
            groupBox11.TabIndex = 20;
            groupBox11.TabStop = false;
            groupBox11.Text = "No Fly Zones";
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(lstBx_AllowedClasses);
            groupBox12.Location = new Point(139, 16);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(218, 401);
            groupBox12.TabIndex = 23;
            groupBox12.TabStop = false;
            groupBox12.Text = "Allowed Classes";
            // 
            // lstBx_AllowedClasses
            // 
            lstBx_AllowedClasses.FormattingEnabled = true;
            lstBx_AllowedClasses.ItemHeight = 15;
            lstBx_AllowedClasses.Location = new Point(6, 16);
            lstBx_AllowedClasses.Name = "lstBx_AllowedClasses";
            lstBx_AllowedClasses.SelectionMode = SelectionMode.MultiExtended;
            lstBx_AllowedClasses.Size = new Size(206, 379);
            lstBx_AllowedClasses.TabIndex = 0;
            lstBx_AllowedClasses.MouseCaptureChanged += lstBx_AllowedClasses_MouseCaptureChanged;
            // 
            // btnAddNoFlyZone
            // 
            btnAddNoFlyZone.Location = new Point(92, 176);
            btnAddNoFlyZone.Name = "btnAddNoFlyZone";
            btnAddNoFlyZone.Size = new Size(41, 24);
            btnAddNoFlyZone.TabIndex = 21;
            btnAddNoFlyZone.Text = "+";
            btnAddNoFlyZone.UseVisualStyleBackColor = true;
            btnAddNoFlyZone.Click += btnAddNoFlyZone_Click;
            // 
            // btnRemoveNoFlyZone
            // 
            btnRemoveNoFlyZone.Location = new Point(3, 176);
            btnRemoveNoFlyZone.Name = "btnRemoveNoFlyZone";
            btnRemoveNoFlyZone.Size = new Size(40, 23);
            btnRemoveNoFlyZone.TabIndex = 21;
            btnRemoveNoFlyZone.Text = "-";
            btnRemoveNoFlyZone.UseVisualStyleBackColor = true;
            btnRemoveNoFlyZone.Click += btnRemoveNoFlyZone_Click;
            // 
            // txtRadius
            // 
            txtRadius.DataBindings.Add(new Binding("DataContext", noFlyZonesBindingSource, "Radius", true));
            txtRadius.DataBindings.Add(new Binding("Text", noFlyZonesBindingSource, "Radius", true));
            txtRadius.Location = new Point(54, 341);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(51, 23);
            txtRadius.TabIndex = 21;
            // 
            // noFlyZonesBindingSource
            // 
            noFlyZonesBindingSource.DataSource = typeof(Zones);
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new Point(3, 344);
            label42.Name = "label42";
            label42.Size = new Size(45, 15);
            label42.TabIndex = 22;
            label42.Text = "Radius:";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(8, 292);
            label41.Name = "label41";
            label41.Size = new Size(17, 15);
            label41.TabIndex = 21;
            label41.Text = "Z:";
            // 
            // txt_ZCoord
            // 
            txt_ZCoord.DataBindings.Add(new Binding("DataContext", noFlyZonesBindingSource, "Z", true));
            txt_ZCoord.DataBindings.Add(new Binding("Text", noFlyZonesBindingSource, "Z", true));
            txt_ZCoord.Location = new Point(31, 290);
            txt_ZCoord.Name = "txt_ZCoord";
            txt_ZCoord.Size = new Size(26, 23);
            txt_ZCoord.TabIndex = 21;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(8, 263);
            label40.Name = "label40";
            label40.Size = new Size(17, 15);
            label40.TabIndex = 21;
            label40.Text = "Y:";
            // 
            // txt_YCoord
            // 
            txt_YCoord.DataBindings.Add(new Binding("DataContext", noFlyZonesBindingSource, "Y", true));
            txt_YCoord.DataBindings.Add(new Binding("Text", noFlyZonesBindingSource, "Y", true));
            txt_YCoord.Location = new Point(31, 260);
            txt_YCoord.Name = "txt_YCoord";
            txt_YCoord.Size = new Size(26, 23);
            txt_YCoord.TabIndex = 21;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(8, 234);
            label39.Name = "label39";
            label39.Size = new Size(17, 15);
            label39.TabIndex = 21;
            label39.Text = "X:";
            // 
            // txt_XCoord
            // 
            txt_XCoord.DataBindings.Add(new Binding("DataContext", noFlyZonesBindingSource, "X", true));
            txt_XCoord.DataBindings.Add(new Binding("Text", noFlyZonesBindingSource, "X", true));
            txt_XCoord.Location = new Point(31, 231);
            txt_XCoord.Name = "txt_XCoord";
            txt_XCoord.Size = new Size(26, 23);
            txt_XCoord.TabIndex = 21;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(4, 205);
            label38.Name = "label38";
            label38.Size = new Size(21, 15);
            label38.TabIndex = 21;
            label38.Text = "ID:";
            // 
            // txtId
            // 
            txtId.DataBindings.Add(new Binding("DataContext", noFlyZonesBindingSource, "Id", true));
            txtId.DataBindings.Add(new Binding("Text", noFlyZonesBindingSource, "Id", true));
            txtId.Location = new Point(31, 202);
            txtId.Name = "txtId";
            txtId.Size = new Size(26, 23);
            txtId.TabIndex = 21;
            // 
            // lstNoFlyZones
            // 
            lstNoFlyZones.DataSource = noFlyZonesBindingSource;
            lstNoFlyZones.DisplayMember = "Id";
            lstNoFlyZones.FormattingEnabled = true;
            lstNoFlyZones.ItemHeight = 15;
            lstNoFlyZones.Location = new Point(3, 16);
            lstNoFlyZones.Name = "lstNoFlyZones";
            lstNoFlyZones.Size = new Size(130, 154);
            lstNoFlyZones.TabIndex = 21;
            lstNoFlyZones.SelectedIndexChanged += lstNoFlyZones_SelectedIndexChanged;
            // 
            // openDefFileDialog
            // 
            openDefFileDialog.FileOk += openDefFileDialog_FileOk;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 829);
            Controls.Add(groupBox11);
            Controls.Add(groupBox10);
            Controls.Add(groupBox9);
            Controls.Add(label28);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox4);
            Controls.Add(grpbx_Details);
            Controls.Add(gpbox_GridClasses);
            Controls.Add(grpbx_Factions);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)modConfigBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ignoreFactionTagsBindingSource).EndInit();
            grpbx_Factions.ResumeLayout(false);
            grpbx_Factions.PerformLayout();
            gpbox_GridClasses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridClassesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)blockLimitsBindingSource).EndInit();
            grpbx_Details.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)selectedGridClassBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpbx_Broadcasting.ResumeLayout(false);
            grpbx_Broadcasting.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)selectedClassDamageModifiersBindingSource).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)selectedClassUtilModifiersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)blockLimitBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)blockTypesBindingSource).EndInit();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)blockTypeBindingSource).EndInit();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cubeBlockBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectedBlockTypeBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)noFlyZonesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)zoneBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource modConfigBindingSource;
        private ListBox lstBx_IgnoredFactionTags;
        private BindingSource ignoreFactionTagsBindingSource;
        private TextBox txtFactionTag;
        private Button btn_AddFactionTag;
        private Button btn_RemoveFactionTag;
        private Label label1;
        private GroupBox grpbx_Factions;
        private GroupBox gpbox_GridClasses;
        private Button btn_DeleteClass;
        private ListBox lstbx_GridClasses;
        private BindingSource gridClassesBindingSource;
        private BindingSource blockLimitsBindingSource;
        private Button btn_AddNewClass;
        private GroupBox grpbx_Details;
        private BindingSource selectedGridClassBindingSource;
        private Label label2;
        private TextBox txt_ClassId;
        private TextBox txtClassName;
        private Label label3;
        private GroupBox grpbx_Broadcasting;
        private TextBox txtBroadcastRange;
        private Label label4;
        private CheckBox chkbx_ForceBroadcast;
        private GroupBox groupBox1;
        private CheckBox chkbx_SmallGrid;
        private CheckBox chkbox_LgGridMobile;
        private CheckBox LgGridStatic;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox txt_MaxBlocks;
        private Label label5;
        private TextBox txtMaxMass;
        private Label label7;
        private TextBox txtMaxPcu;
        private GroupBox groupBox3;
        private Label label10;
        private TextBox txtMinBlocks;
        private Label label9;
        private TextBox txtMaxPerPlayer;
        private Label label8;
        private TextBox txtMaxPerFaction;
        private Label label11;
        private TextBox txtMinPlayers;
        private GroupBox groupBox4;
        private TextBox txtAssemblerSpeed;
        private BindingSource selectedClassUtilModifiersBindingSource;
        private GroupBox groupBox5;
        private Label label12;
        private TextBox txtGyroForce;
        private Label label14;
        private TextBox txtGyroEfficiency;
        private Label label13;
        private TextBox txtDrillHarvestMultiplier;
        private Label label15;
        private Label label16;
        private TextBox txtPowerProducersOutput;
        private Label label18;
        private TextBox txtRefineSpeed;
        private Label label17;
        private TextBox txtRefineEfficiency;
        private GroupBox groupBox6;
        private Label label20;
        private Label label19;
        private TextBox txtThrusterForce;
        private TextBox txtThrusterEfficiency;
        private TextBox txtBullet;
        private BindingSource selectedClassDamageModifiersBindingSource;
        private Label label23;
        private TextBox txtExplosion;
        private Label label22;
        private TextBox txtRocket;
        private Label label21;
        private Label label24;
        private TextBox txtEnvironment;
        private Label label26;
        private TextBox txtKinetic;
        private Label label25;
        private TextBox txtEnergy;
        private ListBox lstbx_BlockLimits;
        private BindingSource blockTypesBindingSource;
        private BindingSource blockLimitBindingSource;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private ListBox lstbx_BlockTypes;
        private Label label28;
        private GroupBox groupBox9;
        private TextBox txtTypeId;
        private BindingSource selectedBlockTypeBindingSource;
        private Label label29;
        private TextBox txtSubTypeId;
        private Label label31;
        private TextBox txtCountWeight;
        private Label label30;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnRemoveBlockLimit;
        private Button btnAddBlockLimit;
        private Button btnRemoveBlockType;
        private Button btnAddBlockType;
        private BindingSource blockTypeBindingSource;
        private TextBox txtBlockLimitName;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadFileToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private TextBox txtMaxCount;
        private Label label27;
        private GroupBox groupBox10;
        private Label label33;
        private TextBox txtGlobalMaxSpeed;
        private TextBox txtBoostDuration;
        private TextBox txtShipClassBoost;
        private Label label35;
        private TextBox txtShipClassMaxSpeed;
        private Label label34;
        private TextBox txtBoostCooldown;
        private Label label36;
        private Label label37;
        private GroupBox groupBox11;
        private ListBox lstNoFlyZones;
        private BindingSource zoneBindingSource;
        private BindingSource noFlyZonesBindingSource;
        private Label label38;
        private TextBox txtId;
        private TextBox txt_XCoord;
        private TextBox txtRadius;
        private Label label42;
        private Label label41;
        private TextBox txt_ZCoord;
        private Label label40;
        private TextBox txt_YCoord;
        private Label label39;
        private Button btnRemoveNoFlyZone;
        private Button btnAddNoFlyZone;
        private GroupBox groupBox12;
        private ListBox lstBx_AllowedClasses;
        private CheckBox chkBx_TurnedOffByNoFlyZone;
        private Button btn_DupGridClass;
        private Button btnCopyBlockLimit;
        private Button btn_PasteBlockLimit;
        private ToolStripMenuItem loadBlockDefinitionFileToolStripMenuItem;
        private OpenFileDialog openDefFileDialog;
        private ComboBox cmbBoxBlockQuickSelect;
        private BindingSource cubeBlockBindingSource;
        private Button btnApplySelectedBlock;
    }
}
