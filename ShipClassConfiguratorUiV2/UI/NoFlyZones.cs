using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ShipConfigurator_Definitions;

namespace ShipClassConfiguratorUiV2.UI
{
    public partial class NoFlyZones : Form
    {
        private bool initialized;
        public NoFlyZones(List<Zones> zones, List<GridClass> allGridClasses)
        {
            InitializeComponent();
            zonesBindingSource.DataSource = zones;
            gridClassBindingSource.DataSource = allGridClasses;
            SetSelectedClasses();
            initialized = true;
        }

        private List<Zones> zoneList => (List<Zones>)zonesBindingSource.DataSource;

        private void btnAddNoFlyZone_Click(object sender, System.EventArgs e)
        {
            var newId = zoneList.Max(x => x.Id) + 1;
            zoneList.Add(new Zones { Id = newId});

            zonesBindingSource.ResetBindings(false);
        }

        private void btnRemoveNoFlyZone_Click(object sender, System.EventArgs e)
        {
            var selectedIndex = lstNoFlyZones.SelectedIndex;
            zoneList.RemoveAt(selectedIndex);
            zonesBindingSource.ResetBindings(false);
        }

        private void lst_AllowedClasses_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (!initialized)
                return;

            var selectedIds = lst_AllowedClasses.SelectedItems.Cast<GridClass>().Select(x => x.Id);
            var selectedItem = (Zones)lstNoFlyZones.SelectedItem;
            selectedItem.AllowedClassesById = selectedIds.Select(x => (long)x).ToList();
            lbl_AllowedClasses.Text = String.Join(",", selectedIds);
        }

        private void lstNoFlyZones_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSelectedClasses();
        }

        private List<GridClass> allGrids => gridClassBindingSource.DataSource as List<GridClass>;

        private void SetSelectedClasses()
        {
            if (allGrids == null)
                return;
            if (lstNoFlyZones.SelectedItem as Zones == null)
                return;

            var selectedIds = ((Zones)lstNoFlyZones.SelectedItem).AllowedClassesById;
            lst_AllowedClasses.SelectedItems.Clear();
            foreach (var id in selectedIds)
            {
                var gridClass = allGrids.SingleOrDefault(x => x.Id == id);
                if(gridClass != null)
                    lst_AllowedClasses.SelectedItems.Add(gridClass);
            }
            lbl_AllowedClasses.Text = String.Join(",", selectedIds);
        }
    }
}
