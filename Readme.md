<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128578785/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3093)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DXPivotGrid_OLAPSortBySummary/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXPivotGrid_OLAPSortBySummary/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DXPivotGrid_OLAPSortBySummary/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXPivotGrid_OLAPSortBySummary/MainWindow.xaml.vb))
<!-- default file list end -->
# How to implement Sorting by Summary in OLAP mode


<p>The following example demonstrates how to implement <a href="https://documentation.devexpress.com/#WPF/CustomDocument8072">Sorting by Summary</a> in OLAP mode.</p>
<p>In this example, values of the <strong>Semester</strong> field are sorted by the <strong>Australia | Bendigo</strong> column summary values. To do this, two sort conditions represented by <strong>SortByCondition</strong> instances are created. One of them represents an OLAP member that corresponds to the 'Australia' value, while another corresponds to the 'Bendigo' value. These sort conditions are added to the Semester field's <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPivotGridPivotGridField_SortByConditionstopic">PivotGridField.SortByConditions</a> collection to specify the column by which <strong>Semester </strong>values should be sorted. A data field that identifies the column is specified via the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPivotGridPivotGridField_SortByFieldtopic">PivotGridField.SortByField</a> property.</p>
<p>OLAP members corresponding to the Australia and Bendigo values are obtained using the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPivotGridPivotGridControl_GetFieldValueOlapMembertopic">PivotGridControl.GetFieldValueOlapMember</a> method. Note that OLAP members can be obtained only for visible field values. For this reason, the <strong>Australia</strong> field value is expanded before initializing OLAP members in order to obtain the <strong>Bendigo</strong> OLAP member.</p>
<p>This sample uses the <strong>Adventure Works</strong> cube.</p>
<p> </p>

<br/>


