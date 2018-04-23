Imports DevExpress.XtraMap
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace MiniMapParameters
    Partial Public Class Form1
        Inherits Form

        #Region "#InitEditors"
        Private behaviors As New List(Of MiniMapBehavior)() From { _
            New FixedMiniMapBehavior(), _
            New DynamicMiniMapBehavior() _
        }

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            cbAlignment.DataSource = System.Enum.GetValues(GetType(MiniMapAlignment))
            cbBehavior.DataSource = behaviors
        End Sub
        #End Region ' #InitEditors

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#BehaviorChanged"
        Private Sub cbBehavior_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbBehavior.SelectedIndexChanged
            Dim behavior As MiniMapBehavior = TryCast(cbBehavior.SelectedValue, MiniMapBehavior)
            If behavior Is Nothing Then
                Return
            End If
            propertyGrid.SelectedObject = behavior

            If mapControl.MiniMap Is Nothing Then
                Return
            End If
            mapControl.MiniMap.Behavior = behavior

        End Sub
        #End Region ' #BehaviorChanged

        #Region "#AlignmentChanged"
        Private Sub cbAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAlignment.SelectedIndexChanged
            Dim alignment As MiniMapAlignment = DirectCast(cbAlignment.SelectedValue, MiniMapAlignment)
            If mapControl.MiniMap Is Nothing Then
                Return
            End If
            mapControl.MiniMap.Alignment = alignment
        End Sub
        #End Region ' #AlignmentChanged
    End Class
End Namespace
