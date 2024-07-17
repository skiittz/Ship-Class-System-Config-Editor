using System;
using System.Windows.Forms;
using ShipConfigurator_Definitions;

namespace ShipClassConfiguratorUiV2.UI
{
    public partial class DamageModifiers : Form
    {
        public DamageModifiers(GridClass selectedClass)
        {
            InitializeComponent();
            damageModifiersBindingSource.DataSource = selectedClass.DamageModifiers;
        }

        private void DamageModifiers_Load(object sender, EventArgs e)
        {

        }
    }
}
