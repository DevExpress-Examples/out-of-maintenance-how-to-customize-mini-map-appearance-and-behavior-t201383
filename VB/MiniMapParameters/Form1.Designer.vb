Namespace MiniMapParameters
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim imageTilesLayer1 As New DevExpress.XtraMap.ImageTilesLayer()
            Dim bingMapDataProvider1 As New DevExpress.XtraMap.BingMapDataProvider()
            Dim miniMap1 As New DevExpress.XtraMap.MiniMap()
            Dim dynamicMiniMapBehavior1 As New DevExpress.XtraMap.DynamicMiniMapBehavior()
            Dim miniMapImageTilesLayer1 As New DevExpress.XtraMap.MiniMapImageTilesLayer()
            Dim bingMapDataProvider2 As New DevExpress.XtraMap.BingMapDataProvider()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
            Me.cbBehavior = New System.Windows.Forms.ComboBox()
            Me.cbAlignment = New System.Windows.Forms.ComboBox()
            Me.mapControl = New DevExpress.XtraMap.MapControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.mapControl, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.propertyGrid)
            Me.layoutControl1.Controls.Add(Me.cbBehavior)
            Me.layoutControl1.Controls.Add(Me.cbAlignment)
            Me.layoutControl1.Controls.Add(Me.mapControl)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = New System.Drawing.Font("Tahoma", 10.25F)
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = True
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = True
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = True
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(1001, 684)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' propertyGrid
            ' 
            Me.propertyGrid.Location = New System.Drawing.Point(709, 78)
            Me.propertyGrid.Name = "propertyGrid"
            Me.propertyGrid.Size = New System.Drawing.Size(280, 594)
            Me.propertyGrid.TabIndex = 7
            ' 
            ' cbBehavior
            ' 
            Me.cbBehavior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbBehavior.FormattingEnabled = True
            Me.cbBehavior.Location = New System.Drawing.Point(854, 37)
            Me.cbBehavior.Name = "cbBehavior"
            Me.cbBehavior.Size = New System.Drawing.Size(135, 21)
            Me.cbBehavior.TabIndex = 6
            ' 
            ' cbAlignment
            ' 
            Me.cbAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbAlignment.FormattingEnabled = True
            Me.cbAlignment.Location = New System.Drawing.Point(854, 12)
            Me.cbAlignment.Name = "cbAlignment"
            Me.cbAlignment.Size = New System.Drawing.Size(135, 21)
            Me.cbAlignment.TabIndex = 5
            ' 
            ' mapControl
            ' 
            bingMapDataProvider1.BingKey = "Your Bing Key Here"
            imageTilesLayer1.DataProvider = bingMapDataProvider1
            Me.mapControl.Layers.Add(imageTilesLayer1)
            Me.mapControl.Location = New System.Drawing.Point(12, 12)
            miniMap1.Behavior = dynamicMiniMapBehavior1
            miniMap1.Height = 240
            bingMapDataProvider2.BingKey = "Your Bing Key Here"
            miniMapImageTilesLayer1.DataProvider = bingMapDataProvider2
            miniMap1.Layers.Add(miniMapImageTilesLayer1)
            miniMap1.Width = 320
            Me.mapControl.MiniMap = miniMap1
            Me.mapControl.Name = "mapControl"
            Me.mapControl.Size = New System.Drawing.Size(693, 660)
            Me.mapControl.TabIndex = 4
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1001, 684)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.mapControl
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(697, 664)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.cbAlignment
            Me.layoutControlItem2.Location = New System.Drawing.Point(697, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(284, 25)
            Me.layoutControlItem2.Text = "Mini Map Alignment:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(142, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.cbBehavior
            Me.layoutControlItem3.Location = New System.Drawing.Point(697, 25)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(284, 25)
            Me.layoutControlItem3.Text = "Mini Map Behavior:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(142, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.propertyGrid
            Me.layoutControlItem4.Location = New System.Drawing.Point(697, 50)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(284, 614)
            Me.layoutControlItem4.Text = "Mini Map Behavior Properties:"
            Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(142, 13)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1001, 684)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.mapControl, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private propertyGrid As System.Windows.Forms.PropertyGrid
        Private mapControl As DevExpress.XtraMap.MapControl
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents cbBehavior As System.Windows.Forms.ComboBox
        Private WithEvents cbAlignment As System.Windows.Forms.ComboBox
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

