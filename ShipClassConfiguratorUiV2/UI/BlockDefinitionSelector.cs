using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ShipConfigurator_Definitions;

namespace ShipClassConfiguratorUiV2.UI
{
    public partial class BlockDefinitionSelector : Form
    {
        public CubeBlock selectedBlockDefinition;
        public List<CubeBlock> allDefinitions;
        public List<CubeBlock> filteredDefinitions;
        public BlockDefinitionSelector(List<CubeBlock> blockDefinitions)
        {
            InitializeComponent();
            cubeBlockBindingSource.DataSource = blockDefinitions;
            allDefinitions = blockDefinitions;
            filteredDefinitions = blockDefinitions;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            selectedBlockDefinition = lst_BlockDefinitions.SelectedItem as CubeBlock;
            this.Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            selectedBlockDefinition = null;
            this.Close();
        }

        private void txtFilterBox_TextChanged(object sender, System.EventArgs e)
        {
            filteredDefinitions = allDefinitions.Where(x => x.DisplayName.ToLower().Contains(txtFilterBox.Text.ToLower())).ToList();
            cubeBlockBindingSource.DataSource = filteredDefinitions;
        }
    }
}
