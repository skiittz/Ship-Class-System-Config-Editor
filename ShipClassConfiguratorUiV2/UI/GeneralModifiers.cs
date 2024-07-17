using System.Windows.Forms;
using ShipConfigurator_Definitions;

namespace ShipClassConfiguratorUiV2.UI
{
    public partial class GeneralModifiers : Form
    {
        public GeneralModifiers(GridClass selectedClass)
        {
            InitializeComponent();
            utilModifiersBindingSource.DataSource = selectedClass.Modifiers;
        }
    }
}
