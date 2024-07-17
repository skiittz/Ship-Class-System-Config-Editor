using System.Collections.Generic;
using System.Windows.Forms;
using ShipConfigurator_Definitions;

namespace ShipClassConfiguratorUiV2.UI
{
    public partial class BlockLimits : Form
    {
        private List<CubeBlock> blockDefinitions = new List<CubeBlock>();
        public BlockLimits(List<BlockLimit> limits, List<CubeBlock> blockDefinitions)
        {
            InitializeComponent();
            blockLimitBindingSource.DataSource = limits;
            this.blockDefinitions = blockDefinitions;
        }

        private void lstBlockLimits_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            blockTypeBindingSource.DataSource = ((BlockLimit)lstBlockLimits.SelectedItem).BlockTypes;
        }
    }
}
