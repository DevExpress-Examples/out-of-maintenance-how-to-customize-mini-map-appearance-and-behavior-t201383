using DevExpress.XtraMap;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MiniMapParameters {
    public partial class Form1 : Form {
        #region #InitEditors
        List<MiniMapBehavior> behaviors = new List<MiniMapBehavior> { 
            new FixedMiniMapBehavior(), 
            new DynamicMiniMapBehavior()
        };

        private void Form1_Load(object sender, EventArgs e) {
            cbAlignment.DataSource = Enum.GetValues(typeof(MiniMapAlignment));
            cbBehavior.DataSource = behaviors;
        }
        #endregion #InitEditors

        public Form1() {
            InitializeComponent();
        }

        #region #BehaviorChanged
        private void cbBehavior_SelectedIndexChanged(object sender, EventArgs e) {
            MiniMapBehavior behavior = cbBehavior.SelectedValue as MiniMapBehavior;
            if (behavior == null) return;
            propertyGrid.SelectedObject = behavior;

            if (mapControl.MiniMap == null) return;
            mapControl.MiniMap.Behavior = behavior;
        
        }
        #endregion #BehaviorChanged

        #region #AlignmentChanged
        private void cbAlignment_SelectedIndexChanged(object sender, EventArgs e) {
            MiniMapAlignment alignment = (MiniMapAlignment)cbAlignment.SelectedValue;
            if (mapControl.MiniMap == null) return;
            mapControl.MiniMap.Alignment = alignment;
        }
        #endregion #AlignmentChanged
    }
}
