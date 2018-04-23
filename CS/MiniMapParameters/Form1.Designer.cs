namespace MiniMapParameters {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraMap.ImageLayer imageTilesLayer1 = new DevExpress.XtraMap.ImageLayer();
            DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            DevExpress.XtraMap.MiniMap miniMap1 = new DevExpress.XtraMap.MiniMap();
            DevExpress.XtraMap.DynamicMiniMapBehavior dynamicMiniMapBehavior1 = new DevExpress.XtraMap.DynamicMiniMapBehavior();
            DevExpress.XtraMap.MiniMapImageTilesLayer miniMapImageTilesLayer1 = new DevExpress.XtraMap.MiniMapImageTilesLayer();
            DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider2 = new DevExpress.XtraMap.BingMapDataProvider();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.cbBehavior = new System.Windows.Forms.ComboBox();
            this.cbAlignment = new System.Windows.Forms.ComboBox();
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.propertyGrid);
            this.layoutControl1.Controls.Add(this.cbBehavior);
            this.layoutControl1.Controls.Add(this.cbAlignment);
            this.layoutControl1.Controls.Add(this.mapControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1001, 684);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Location = new System.Drawing.Point(709, 78);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(280, 594);
            this.propertyGrid.TabIndex = 7;
            // 
            // cbBehavior
            // 
            this.cbBehavior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBehavior.FormattingEnabled = true;
            this.cbBehavior.Location = new System.Drawing.Point(854, 37);
            this.cbBehavior.Name = "cbBehavior";
            this.cbBehavior.Size = new System.Drawing.Size(135, 21);
            this.cbBehavior.TabIndex = 6;
            this.cbBehavior.SelectedIndexChanged += new System.EventHandler(this.cbBehavior_SelectedIndexChanged);
            // 
            // cbAlignment
            // 
            this.cbAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlignment.FormattingEnabled = true;
            this.cbAlignment.Location = new System.Drawing.Point(854, 12);
            this.cbAlignment.Name = "cbAlignment";
            this.cbAlignment.Size = new System.Drawing.Size(135, 21);
            this.cbAlignment.TabIndex = 5;
            this.cbAlignment.SelectedIndexChanged += new System.EventHandler(this.cbAlignment_SelectedIndexChanged);
            // 
            // mapControl
            // 
            bingMapDataProvider1.BingKey = "Your Bing Key Here";
            imageTilesLayer1.DataProvider = bingMapDataProvider1;
            this.mapControl.Layers.Add(imageTilesLayer1);
            this.mapControl.Location = new System.Drawing.Point(12, 12);
            miniMap1.Behavior = dynamicMiniMapBehavior1;
            miniMap1.Height = 240;
            bingMapDataProvider2.BingKey = "Your Bing Key Here";
            miniMapImageTilesLayer1.DataProvider = bingMapDataProvider2;
            miniMap1.Layers.Add(miniMapImageTilesLayer1);
            miniMap1.Width = 320;
            this.mapControl.MiniMap = miniMap1;
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(693, 660);
            this.mapControl.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1001, 684);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.mapControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(697, 664);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbAlignment;
            this.layoutControlItem2.Location = new System.Drawing.Point(697, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(284, 25);
            this.layoutControlItem2.Text = "Mini Map Alignment:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(142, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbBehavior;
            this.layoutControlItem3.Location = new System.Drawing.Point(697, 25);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(284, 25);
            this.layoutControlItem3.Text = "Mini Map Behavior:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(142, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.propertyGrid;
            this.layoutControlItem4.Location = new System.Drawing.Point(697, 50);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(284, 614);
            this.layoutControlItem4.Text = "Mini Map Behavior Properties:";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(142, 13);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 684);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private DevExpress.XtraMap.MapControl mapControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.ComboBox cbBehavior;
        private System.Windows.Forms.ComboBox cbAlignment;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}

