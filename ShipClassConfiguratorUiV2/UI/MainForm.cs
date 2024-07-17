using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ShipClassConfiguratorUiV2.UI;
using ShipConfigurator_Definitions;
using DamageModifiers = ShipClassConfiguratorUiV2.UI.DamageModifiers;

namespace ShipClassConfiguratorUiV2
{
    public partial class MainForm : Form
    {
        private List<CubeBlock> blockDefinitions = new List<CubeBlock>();
        private ModConfig currentFile => (ModConfig)modConfigBindingSource.DataSource;

        public MainForm()
        {
            InitializeComponent();
            blockDefinitions = CubeBlockLoader.LoadCubeBlockDefinitionsFromLocalFolder();
        }


        private void RefreshStats()
        {
            lblIgnoredFactionTagsCount.Text = currentFile.IgnoreFactionTags.Count.ToString();
            lbl_NoFlyZoneCount.Text = currentFile.NoFlyZones.Count.ToString();

            gridClassBindingSource.ResetBindings(false);
        }

        private void loadConfigFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenConfigFileDialog.ShowDialog();
        }

        private void OpenConfigFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            modConfigBindingSource.DataSource = ModConfig.LoadConfig(OpenConfigFileDialog.FileName);
            gridClassBindingSource.DataSource = currentFile.GridClasses;
            RefreshStats();
        }

        private void saveConfigFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveConfigDialog.ShowDialog();
        }

        private void SaveConfigDialog_FileOk(object sender, CancelEventArgs e)
        {
            ((ModConfig)modConfigBindingSource.DataSource).SaveConfig(SaveConfigDialog.FileName);

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportDefinitionDialog.ShowDialog();
        }

        private void ImportDefinitionDialog_FileOk(object sender, CancelEventArgs e)
        {
            //definitionFiles.AddFile(ImportDefinitionDialog.FileName);
        }

        private void btn_AddGridClass_Click(object sender, EventArgs e)
        {
            var newClass = GridClass.Default;
            newClass.Id = NextGridClassId();
            currentFile.GridClasses.Add(newClass);

            gridClassBindingSource.DataSource = currentFile.GridClasses.OrderBy(x => x.Id);
            gridClassBindingSource.ResetBindings(false);
        }

        private int NextGridClassId()
        {
            return currentFile.GridClasses.Any() ? currentFile.GridClasses.OrderByDescending(x => x.Id).First().Id + 1 : 0;
        }

        private void btn_RemoveGridClass_Click(object sender, EventArgs e)
        {
            currentFile.GridClasses.Remove((GridClass)lst_Classes.SelectedItem);
            gridClassBindingSource.DataSource = currentFile.GridClasses.OrderBy(x => x.Id);
            gridClassBindingSource.ResetBindings(false);
            lst_Classes.ClearSelected();
        }

        private void btn_Duplicate_Click(object sender, EventArgs e)
        {
            var source = (GridClass)lst_Classes.SelectedItem;
            var newClass = source.CloneToId(NextGridClassId());
            newClass.Name = $"{newClass.Name} (Copy)";
            currentFile.GridClasses.Add(newClass);

            gridClassBindingSource.DataSource = currentFile.GridClasses.OrderBy(x => x.Id);
            gridClassBindingSource.ResetBindings(false);
        }

        private void btn_EditGeneralModifiers_Click(object sender, EventArgs e)
        {
            var generalModifiersForm = new GeneralModifiers((GridClass)lst_Classes.SelectedItem);
            generalModifiersForm.ShowDialog();
        }

        private void btn_EditDamageMods_Click(object sender, EventArgs e)
        {
            var damageModifiersForm = new DamageModifiers((GridClass)lst_Classes.SelectedItem);
            damageModifiersForm.ShowDialog();
        }

        private void btn_EditIgnoredFactionTags_Click(object sender, EventArgs e)
        {
            var ignoredFactionsForm = new IgnoredFactionTags(currentFile.IgnoreFactionTags);
            ignoredFactionsForm.ShowDialog();
            currentFile.IgnoreFactionTags = ignoredFactionsForm.ignoredFactions;
            RefreshStats();
        }

        private void btn_EditNoFlyZones_Click(object sender, EventArgs e)
        {
            var noFlyZoneForm = new NoFlyZones(currentFile.NoFlyZones, currentFile.GridClasses);
            noFlyZoneForm.ShowDialog();
            RefreshStats();
        }

        private BlockLimit BlockLimitClipboard;
        private void btn_EditBlockLimits_Click(object sender, EventArgs e)
        {
            var selectedClass = lst_Classes.SelectedItem as GridClass;
            if(selectedClass == null) return;

            var blockLimits = new BlockLimits(selectedClass.BlockLimits, blockDefinitions, BlockLimitClipboard);
            blockLimits.ShowDialog();
            BlockLimitClipboard = blockLimits.BlockLimitClipboard;
        }
    }
}
