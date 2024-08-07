using System.Text;
using System.Xml.Serialization;
using Ship_Class_System_Config_Editor.Definitions;
using Ship_Class_System_Config_Editor.FileDefinitions;

namespace Ship_Class_System_Config_Editor
{
    public partial class MainForm : Form
    {
        private ModConfig currentFile => (ModConfig)modConfigBindingSource.DataSource;
        static Encoding encoding => Encoding.GetEncoding("UTF-16");
        private List<string> blockTypeNames = new List<string>();
        private DefinitionFiles definitionFiles = new DefinitionFiles();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modConfigBindingSource.DataSource = new ModConfig();
            definitionFiles.LoadConfig();
            RefreshBlockQuickSelect();
        }

        public void LoadConfig(string filePath)
        {
            var serializer = new XmlSerializer(typeof(ModConfig));
            using (var reader = new StreamReader(filePath))
            {
                modConfigBindingSource.DataSource = (ModConfig)serializer.Deserialize(reader);
            }

            currentFile.GridClasses.Add(currentFile.DefaultGridClass);
            gridClassesBindingSource.DataSource = currentFile.GridClasses.OrderBy(x => x.Id);
            noFlyZonesBindingSource.DataSource = currentFile.NoFlyZones;
        }

        public void SaveConfig(string filename)
        {
            var defaultClass = currentFile.GridClasses.SingleOrDefault(x => x.Id == 0);
            currentFile.DefaultGridClass = defaultClass;
            currentFile.GridClasses.Remove(defaultClass);
            var fs = new FileStream(filename, FileMode.Create);

            var w = new XmlSerializer(typeof(ModConfig));
            //<< -------------- "OptionsSettings" put here your class

            var sw = new StreamWriter(fs, encoding);
            w.Serialize(sw, currentFile);
            sw.Close();
            fs.Close();
            currentFile.GridClasses.Add(defaultClass);
        }

        private void LstBx_IgnoredFactionTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFactionTag.Text = lstBx_IgnoredFactionTags.SelectedItem?.ToString() ?? string.Empty;
        }

        private void btn_AddFactionTag_Click(object sender, EventArgs e)
        {
            currentFile.IgnoreFactionTags.Add(txtFactionTag.Text);
            modConfigBindingSource.ResetBindings(false);
        }

        private void btn_RemoveFactionTag_Click(object sender, EventArgs e)
        {
            currentFile.IgnoreFactionTags.Remove(txtFactionTag.Text);
            modConfigBindingSource.ResetBindings(false);
        }

        private void lstbx_GridClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedGridClass = (GridClass)lstbx_GridClasses.SelectedItem;
            if (selectedGridClass == null) return;

            selectedGridClassBindingSource.DataSource = selectedGridClass;
            selectedGridClassBindingSource.ResetBindings(false);

            selectedClassUtilModifiersBindingSource.DataSource = selectedGridClass?.Modifiers;
            selectedClassUtilModifiersBindingSource.ResetBindings(false);

            selectedClassDamageModifiersBindingSource.DataSource = selectedGridClass?.DamageModifiers;
            selectedClassDamageModifiersBindingSource.ResetBindings(false);

            blockLimitsBindingSource.DataSource = selectedGridClass?.BlockLimits;
            blockLimitsBindingSource.ResetBindings(false);

            lstbx_BlockLimits.ClearSelected();
            lstbx_BlockTypes.ClearSelected();
            lstbx_BlockTypes.Items.Clear();
        }

        private void lstbx_BlockLimits_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedLimit = (BlockLimit)lstbx_BlockLimits.SelectedItem;
            if (selectedLimit == null) return;

            lstbx_BlockTypes.Items.Clear();
            lstbx_BlockTypes.Items.AddRange(selectedLimit.BlockTypes.Select(x => x.CombinedName).ToArray());

            blockTypesBindingSource.DataSource = selectedLimit?.BlockTypes;
            blockTypesBindingSource.ResetBindings(false);
            lstbx_BlockTypes.ClearSelected();
        }

        private void lstbx_BlockTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbx_BlockLimits.SelectedItem == null || lstbx_BlockTypes.SelectedItem == null) return;
            var selectedLimit = ((BlockLimit)lstbx_BlockLimits.SelectedItem);
            var selectedType = selectedLimit
                .BlockTypes
                .SingleOrDefault(x => x.CombinedName == lstbx_BlockTypes.SelectedItem.ToString());
            if (selectedType == null) return;

            selectedBlockTypeBindingSource.DataSource = selectedType;
            selectedBlockTypeBindingSource.ResetBindings(false);
            if(cmbBoxBlockQuickSelect.Items.Count > 0)
                cmbBoxBlockQuickSelect.SelectedIndex = 0;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LoadConfig(openFileDialog1.FileName);
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveConfig(saveFileDialog1.FileName);
        }

        private void btn_AddNewClass_Click(object sender, EventArgs e)
        {
            var newClass = GridClass.Default;
            newClass.Id = NextGridClassId();
            currentFile.GridClasses.Add(newClass);

            gridClassesBindingSource.DataSource = currentFile.GridClasses.OrderBy(x => x.Id);
            gridClassesBindingSource.ResetBindings(false);
        }

        private int NextGridClassId()
        {
            return currentFile.GridClasses.Any() ? currentFile.GridClasses.OrderByDescending(x => x.Id).First().Id + 1 : 0;
        }

        private void btnRemoveBlockLimit_Click(object sender, EventArgs e)
        {
            var selectedLimit = (BlockLimit)lstbx_BlockLimits.SelectedItem;
            if (selectedLimit == null) return;

            var selectedGridClass = (GridClass)lstbx_GridClasses.SelectedItem;
            selectedGridClass.BlockLimits.Remove(selectedLimit);
            blockLimitsBindingSource.ResetBindings(false);
            lstbx_BlockLimits.ClearSelected();
        }

        private void btn_DeleteClass_Click(object sender, EventArgs e)
        {
            currentFile.GridClasses.Remove((GridClass)lstbx_GridClasses.SelectedItem);
            gridClassesBindingSource.DataSource = currentFile.GridClasses.OrderBy(x => x.Id);
            gridClassesBindingSource.ResetBindings(false);
            lstbx_GridClasses.ClearSelected();
        }

        private void btnAddBlockLimit_Click(object sender, EventArgs e)
        {
            var selectedGridClass = (GridClass)lstbx_GridClasses.SelectedItem;
            if (selectedGridClass == null) return;

            selectedGridClass.BlockLimits.Add(BlockLimit.Default);
            blockLimitsBindingSource.ResetBindings(false);
        }

        private void btnAddBlockType_Click(object sender, EventArgs e)
        {
            var selectedLimit = (BlockLimit)lstbx_BlockLimits.SelectedItem;
            if (selectedLimit == null) return;

            var newBlockType = BlockType.Default;
            int i = 0;
            while (selectedLimit.BlockTypes.Any(x => x.CombinedName == newBlockType.CombinedName))
            {
                i++;
                if (newBlockType.TypeId.Contains($"({i - 1})"))
                    newBlockType.TypeId = newBlockType.TypeId.Replace($"({i - 1})", $"({i})");
                else newBlockType.TypeId = $"({i}){newBlockType.TypeId}";
            }
            selectedLimit.BlockTypes.Add(newBlockType);
            blockLimitsBindingSource.ResetBindings(false);
            blockTypesBindingSource.ResetBindings(false);
            lstbx_BlockLimits_SelectedIndexChanged(sender, e);
        }

        private void btnRemoveBlockType_Click(object sender, EventArgs e)
        {
            var selectedLimit = (BlockLimit)lstbx_BlockLimits.SelectedItem;
            if (selectedLimit == null) return;

            var selectedBlockType = selectedLimit.BlockTypes.Single(x => x.CombinedName == lstbx_BlockTypes.SelectedItem.ToString());
            if (selectedBlockType == null) return;

            blockTypesBindingSource.Remove(selectedBlockType);
            blockTypesBindingSource.ResetBindings(false);

            lstbx_BlockTypes.ClearSelected();
            lstbx_BlockLimits_SelectedIndexChanged(sender, e);
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void btnAddNoFlyZone_Click(object sender, EventArgs e)
        {
            var nextId = ((((List<Zones>)noFlyZonesBindingSource.DataSource).MaxBy(x => x.Id)?.Id) ?? -1) + 1;
            noFlyZonesBindingSource.Add(new Zones { Id = nextId });
            noFlyZonesBindingSource.ResetBindings(false);
        }

        private void btnRemoveNoFlyZone_Click(object sender, EventArgs e)
        {
            var selectedItem = (Zones)lstNoFlyZones.SelectedItem;
            noFlyZonesBindingSource.Remove(selectedItem);
            noFlyZonesBindingSource.ResetBindings(false);
        }

        private void lstNoFlyZones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNoFlyZones.SelectedItem == null)
                return;

            lstBx_AllowedClasses.ClearSelected();
            lstBx_AllowedClasses.Items.Clear();
            foreach (var gridclass in currentFile.GridClasses)
            {
                lstBx_AllowedClasses.Items.Add(gridclass.Name);
                var gridClassId = currentFile.GridClasses.Single(x => x.Name == gridclass.Name).Id;
                var isIncluded = ((Zones)lstNoFlyZones.SelectedItem).AllowedClassesById.Contains(gridClassId);
                lstBx_AllowedClasses.SetSelected(lstBx_AllowedClasses.Items.Count - 1, isIncluded);
            }
        }

        private void lstBx_AllowedClasses_MouseCaptureChanged(object sender, EventArgs e)
        {
            var selectedZone = (Zones)lstNoFlyZones.SelectedItem;
            if (selectedZone == null)
                return;

            var selectedClasses = lstBx_AllowedClasses.SelectedItems;
            if (selectedClasses == null)
            {
                selectedZone.AllowedClassesById = new List<long>();
                return;
            }

            var selectedClassIds = currentFile.GridClasses.Where(x => selectedClasses.Contains(x.Name)).Select(x => (long)x.Id);
            selectedZone.AllowedClassesById = selectedClassIds.ToList();
        }

        private void btn_DupGridClass_Click(object sender, EventArgs e)
        {
            var source = (GridClass)lstbx_GridClasses.SelectedItem;
            var newClass = source.CloneToId(NextGridClassId());
            newClass.Name = $"{newClass.Name} (Copy)";
            currentFile.GridClasses.Add(newClass);

            gridClassesBindingSource.DataSource = currentFile.GridClasses.OrderBy(x => x.Id);
            gridClassesBindingSource.ResetBindings(false);
        }

        private BlockLimit copiedBlockLimit;
        private void btnCopyBlockLimit_Click(object sender, EventArgs e)
        {
            copiedBlockLimit = (BlockLimit)lstbx_BlockLimits.SelectedItem;
        }

        private void btn_PasteBlockLimit_Click(object sender, EventArgs e)
        {
            var gridClass = (GridClass)lstbx_GridClasses.SelectedItem;
            gridClass.BlockLimits.Add((BlockLimit)copiedBlockLimit.Clone());

            blockLimitsBindingSource.ResetBindings(false);
            blockTypesBindingSource.ResetBindings(false);
            lstbx_BlockLimits_SelectedIndexChanged(sender, e);
        }

        private void loadBlockDefinitionFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDefFileDialog.ShowDialog();
        }

        private void openDefFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            definitionFiles.AddFile(openDefFileDialog.FileName);
            RefreshBlockQuickSelect();
        }

        private void RefreshBlockQuickSelect()
        {
            cmbBoxBlockQuickSelect.Items.Clear();
            cmbBoxBlockQuickSelect.Items.AddRange(definitionFiles.LoadedDefinitions.Select(x => x.DisplayName).ToArray());
        }

        private void btnApplySelectedBlock_Click(object sender, EventArgs e)
        {
            var quickSelectName = cmbBoxBlockQuickSelect.SelectedItem as string;
            var quickSelectBlockDefinition = definitionFiles.LoadedDefinitions.SingleOrDefault(x => x.DisplayName == quickSelectName) as CubeBlock;
            if (quickSelectBlockDefinition == null)
                return;

            var selectedLimits = (BlockLimit)lstbx_BlockLimits.SelectedItem;
            var selectedType = selectedLimits.BlockTypes.SingleOrDefault(x => x.CombinedName == (string)lstbx_BlockTypes.SelectedItem);
            if(selectedType == null) return;

            selectedType.TypeId = quickSelectBlockDefinition.TypeId;
            selectedType.SubtypeId = quickSelectBlockDefinition.SubtypeId;
            txtTypeId.Text = selectedType.TypeId;
            txtSubTypeId.Text = selectedType.SubtypeId;

            blockLimitsBindingSource.ResetBindings(false);
            blockTypesBindingSource.ResetBindings(false);
            lstbx_BlockLimits_SelectedIndexChanged(sender, e);
        }
    }
}
