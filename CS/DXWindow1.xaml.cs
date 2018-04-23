using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.UI;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.PropertyGrid;
using DevExpress.Xpf.Reports.UserDesigner;
using DevExpress.XtraReports.UI;


namespace WpfApplicationEUDCustomPropertiesWindow {
    /// <summary>
    /// Interaction logic for DXWindow1.xaml
    /// </summary>
    public partial class DXWindow1 : DXWindow {
        string dataSourcePropertyName = "DataSource";
        string dataMemberPropertyName = "DataMember";
        string dataAdapterPropertyName = "DataAdapter";

        public DXWindow1() {
            InitializeComponent();
            reportDesigner.OpenDocument(new XtraReport());
        }
        private void DXWindow_Loaded(object sender, RoutedEventArgs e) {
            HideGridProperties();
        }
        private void HideGridProperties() {
            PropertyGridControl grid = LayoutTreeHelper.GetVisualChildren(this).Where(x => x is PropertyGridControl).Cast<PropertyGridControl>().FirstOrDefault();
            if(grid == null)
                return;
            HideProperty(grid, dataSourcePropertyName);
            HideProperty(grid, dataMemberPropertyName);
            HideProperty(grid, dataAdapterPropertyName);
        }
        private static void HideProperty(PropertyGridControl grid, string propertyName) {
            PropertyDefinitionBase propertyInstance = grid.PropertyDefinitions.FirstOrDefault(x=> x.Path == propertyName);
            if(propertyInstance == null){
                propertyInstance = new PropertyDefinition() {
                    Path = propertyName,
                };
                grid.PropertyDefinitions.Add(propertyInstance);
            }
            propertyInstance.Visibility = System.Windows.Visibility.Collapsed;
            }
        }
}
