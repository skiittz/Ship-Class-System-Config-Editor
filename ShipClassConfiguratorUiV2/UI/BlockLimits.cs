using System.Collections.Generic;
using System.Windows.Forms;
using ShipConfigurator_Definitions;

namespace ShipClassConfiguratorUiV2.UI
{
    public partial class BlockLimits : Form
    {
        private List<CubeBlock> blockDefinitions = new List<CubeBlock>();
        public BlockLimits(List<BlockLimit> limits, List<CubeBlock> blockDefinitions, BlockLimit blockLimitClipboard)
        {
            InitializeComponent();
            blockLimitBindingSource.DataSource = limits;
            this.blockDefinitions = blockDefinitions;
            this.BlockLimitClipboard  = blockLimitClipboard;
        }

        private void lstBlockLimits_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            blockTypeBindingSource.DataSource = ((BlockLimit)lstBlockLimits.SelectedItem).BlockTypes;
        }

        private void btnSelectDefinition_Click(object sender, System.EventArgs e)
        {
            var blockDefinitionSelector = new BlockDefinitionSelector(blockDefinitions);
            blockDefinitionSelector.ShowDialog();
            var result = blockDefinitionSelector.selectedBlockDefinition;
            if(result == null)
                return;

            var selectedItem = lstBlockTypes.SelectedItem as BlockType;
            selectedItem.TypeId = result.TypeId;
            selectedItem.SubtypeId = result.SubtypeId;
            blockTypeBindingSource.ResetBindings(false);
        }

        public BlockLimit BlockLimitClipboard;
        private void btnCopyBlockLimit_Click(object sender, System.EventArgs e)
        {
            BlockLimitClipboard = lstBlockLimits.SelectedItem as BlockLimit;
        }

        private void btnPasteLimit_Click(object sender, System.EventArgs e)
        {
            if (BlockLimitClipboard == null)
                return;

            ((List<BlockLimit>) blockLimitBindingSource.DataSource).Add(BlockLimitClipboard);
            blockLimitBindingSource.ResetBindings(false);
        }
    }
}
