using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ShipClassConfiguratorUiV2.UI
{
    public partial class IgnoredFactionTags : Form
    {
        public List<string> ignoredFactions;
        public IgnoredFactionTags(List<string> ignoredFactions)
        {
            InitializeComponent();
            this.ignoredFactions = ignoredFactions;
            RefreshList();
        }

        private void RefreshList()
        {
            lstIgnoredFactionTags.Items.Clear();
            lstIgnoredFactionTags.Items.AddRange(ignoredFactions.ToArray());
        }

        private void lstIgnoredFactionTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFactionTag.Text = lstIgnoredFactionTags.SelectedItem.ToString();
        }

        private void btnAddFaction_Click(object sender, EventArgs e)
        {
            ignoredFactions.Add($"Tag{lstIgnoredFactionTags.Items.Count}");
            RefreshList();
        }

        private void btnRemoveFaction_Click(object sender, EventArgs e)
        {
            if (lstIgnoredFactionTags.SelectedIndex == -1)
                return;

            ignoredFactions.RemoveAt(lstIgnoredFactionTags.SelectedIndex);
            RefreshList();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (lstIgnoredFactionTags.SelectedIndex == 0)
                return;

            ignoredFactions[lstIgnoredFactionTags.SelectedIndex] = txtFactionTag.Text;
            RefreshList();
        }
    }
}
