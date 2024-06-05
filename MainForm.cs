using Ship_Class_System_Config_Editor.Definitions;
using System.Text;
using System.Xml.Serialization;
using Ship_Class_System_Config_Editor.FileDefinitions;

namespace Ship_Class_System_Config_Editor
{
    public partial class MainForm : Form
    {
        private ModConfig currentFile => (ModConfig)modConfigBindingSource.DataSource;
        //private List<string> classNames => currentFile.GridClasses.OrderBy(x => x.Id).Select(x => x.Name).ToList();
        static Encoding encoding => Encoding.GetEncoding("UTF-16");
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modConfigBindingSource.DataSource = new ModConfig();
        }

        public void LoadConfig(string filePath)
        {
            var serializer = new XmlSerializer(typeof(ModConfig));
            using (var reader = new StreamReader(filePath))
                modConfigBindingSource.DataSource = (ModConfig)serializer.Deserialize(reader);
            currentFile.GridClasses.Add(currentFile.DefaultGridClass);
            gridClassesBindingSource.DataSource = currentFile.GridClasses.OrderBy(x => x.Id);
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
        }

        private void lstbx_BlockLimits_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedLimit = (BlockLimit)lstbx_BlockLimits.SelectedItem;
            if (selectedLimit == null) return;

            blockTypesBindingSource.DataSource = selectedLimit?.BlockTypes;
            blockTypesBindingSource.ResetBindings(false);
            lstbx_BlockTypes.ClearSelected();
        }

        private void lstbx_BlockTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedType = (BlockType)lstbx_BlockTypes.SelectedItem;
            if (selectedType == null) return;

            selectedBlockTypeBindingSource.DataSource = selectedType ?? new BlockType();
            selectedBlockTypeBindingSource.ResetBindings(false);
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LoadConfig(openFileDialog1.FileName);
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveConfig(saveFileDialog1.FileName);
        }

        private void btn_AddNewClass_Click(object sender, EventArgs e)
        {
            var newId = currentFile.GridClasses.Any() ? currentFile.GridClasses.OrderByDescending(x => x.Id).First().Id + 1 : 0;
            var newClass = GridClass.Default;
            newClass.Id = newId;
            currentFile.GridClasses.Add(newClass);

            gridClassesBindingSource.DataSource = currentFile.GridClasses.OrderBy(x => x.Id);
            gridClassesBindingSource.ResetBindings(false);
        }

        private void btnRemoveBlockLimit_Click(object sender, EventArgs e)
        {
            var selectedLimit = (BlockLimit)lstbx_BlockLimits.SelectedItem;
            if (selectedLimit == null) return;

            var selectedGridClass = (GridClass)lstbx_GridClasses.SelectedItem;
            selectedGridClass.BlockLimits.Remove(selectedLimit);
            blockLimitsBindingSource.ResetBindings(false);
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
            if(selectedGridClass == null) return;

            selectedGridClass.BlockLimits.Add(BlockLimit.Default);
            blockLimitsBindingSource.ResetBindings(false);
        }

        private void btnAddBlockType_Click(object sender, EventArgs e)
        {
            var selectedLimit = (BlockLimit)lstbx_BlockLimits.SelectedItem;
            if (selectedLimit == null) return;

            selectedLimit.BlockTypes.Add(BlockType.Default);
            blockLimitsBindingSource.ResetBindings(false);
        }

        private void btnRemoveBlockType_Click(object sender, EventArgs e)
        {
            var selectedBlockType = (BlockType)lstbx_BlockTypes.SelectedItem;
            if (selectedBlockType == null) return;

            blockTypesBindingSource.Remove(selectedBlockType);
            blockTypesBindingSource.ResetBindings(false);
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
    }
}
