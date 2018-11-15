<!-- default file list -->
*Files to look at*:

* [Dictionary1.xaml](./CS/Dictionary1.xaml)
* [DXWindow1.xaml](./CS/DXWindow1.xaml) (VB: [DXWindow1.xaml](./VB/DXWindow1.xaml))
* [DXWindow1.xaml.cs](./CS/DXWindow1.xaml.cs) (VB: [DXWindow1.xaml](./VB/DXWindow1.xaml))
<!-- default file list end -->
# WPF End-User Report Designer - How to hide a property in the Properties window


This example demonstrates how to hide the "DataSource", "DataMember", and "DataAdapter" properties in the Properties window. <br><br>First, get the <a href="https://documentation.devexpress.com/#WPF/CustomDocument15640">Property Grid</a> from the visual tree. I completed this by using the <a href="https://documentation.devexpress.com/#WPF/clsDevExpressMvvmUILayoutTreeHelpertopic">LayoutTreeHelper</a> class. Then, get a property definition instance from the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyGridControl_PropertyDefinitionstopic">PropertyGridControl.PropertyDefinitions</a> collection and set <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyDefinitionBaseMembersTopicAll">PropertyDefinitionBase.Visibility</a> to Collapsed to hide a property.<br>Here are some points regarding how to get a property from the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyGridControl_PropertyDefinitionstopic">PropertyGridControl.PropertyDefinitions</a> collection. Some properties are determined by the PropertyDefinitionBase.Path property (for instance, the "DataSource" and "PrinterName" properties). To hide them, compare the PropertyDefinitionBase.Path property value with the string value (e.g. "DataSource") to get a property object from <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyGridControl_PropertyDefinitionstopic">PropertyGridControl.PropertyDefinitions</a>.<br>Other properties are determined by the type. To hide them, create a brand new PropertyDefinitionBase object (set up its Path as required) and add it to the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyGridControl_PropertyDefinitionstopic">PropertyGridControl.PropertyDefinitions</a>.<br><br>WinForms: <a href="https://www.devexpress.com/Support/Center/p/T211487">WinForms End-User Report Designer - How to hide a property in the Properties window</a>

<br/>


