Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Security
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Shapes
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.UI
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.PropertyGrid
Imports DevExpress.Xpf.Reports.UserDesigner
Imports DevExpress.XtraReports.UI


Namespace WpfApplicationEUDCustomPropertiesWindow
    ''' <summary>
    ''' Interaction logic for DXWindow1.xaml
    ''' </summary>
    Partial Public Class DXWindow1
        Inherits DXWindow

        Private dataSourcePropertyName As String = "DataSource"
        Private dataMemberPropertyName As String = "DataMember"
        Private dataAdapterPropertyName As String = "DataAdapter"

        Public Sub New()
            InitializeComponent()
            reportDesigner.OpenDocument(New XtraReport())
        End Sub
        Private Sub DXWindow_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            HideGridProperties()
        End Sub
        Private Sub HideGridProperties()
            Dim grid As PropertyGridControl = LayoutTreeHelper.GetVisualChildren(Me).Where(Function(x) TypeOf x Is PropertyGridControl).Cast(Of PropertyGridControl)().FirstOrDefault()
            If grid Is Nothing Then
                Return
            End If
            HideProperty(grid, dataSourcePropertyName)
            HideProperty(grid, dataMemberPropertyName)
            HideProperty(grid, dataAdapterPropertyName)
        End Sub
        Private Shared Sub HideProperty(ByVal grid As PropertyGridControl, ByVal propertyName As String)
            Dim propertyInstance As PropertyDefinitionBase = grid.PropertyDefinitions.FirstOrDefault(Function(x) x.Path = propertyName)
            If propertyInstance Is Nothing Then
                propertyInstance = New PropertyDefinition() With {.Path = propertyName}
                grid.PropertyDefinitions.Add(propertyInstance)
            End If
            propertyInstance.Visibility = System.Windows.Visibility.Collapsed
        End Sub
    End Class
End Namespace
