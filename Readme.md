<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576966/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T360926)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [BillionaireInfo.cs](./CS/FlatDataAdapterSample/BillionaireInfo.cs) (VB: [BillionaireInfo.vb](./VB/FlatDataAdapterSample/BillionaireInfo.vb))
* **[Form1.cs](./CS/FlatDataAdapterSample/Form1.cs) (VB: [Form1.vb](./VB/FlatDataAdapterSample/Form1.vb))**
<!-- default file list end -->
# How to: provide flat data to TreeMap


This example demonstrates how to visualize flat data using TreeMap and color it using Group Gradient Colorizer.


<h3>Description</h3>

<p>To provide flat data to TreeMap, create a&nbsp;<strong>TreeMapFlatDataAdapter</strong>&nbsp;object and assign it to the&nbsp;<strong>TreeMapControl.DataAdapter</strong>&nbsp;property. Then, specify the adapter's&nbsp;<strong>DataSource</strong>,&nbsp;<strong>LabelDataMember</strong>&nbsp;and&nbsp;<strong>ValueDataMember</strong>&nbsp;to configure the data source object and which data members should be used to generate tree map items. If it is required to group generated items, add the&nbsp;name of a data member, whose values should be used to group items, to the&nbsp;<strong>GroupDataMembers</strong>&nbsp;collection.</p>
<p>Finally, to color each tree map group using similar colors, use the&nbsp;<strong>TreeMapGroupGradientColoriezer&nbsp;</strong>class. The&nbsp;<strong>Palette</strong>&nbsp;property specifies colors assigned&nbsp;to&nbsp;groups. The&nbsp;<strong>Max</strong>&nbsp;and&nbsp;<strong>Min</strong>&nbsp;properties configure the maximum and minimum portion of palette colors in colors assigned to items. The&nbsp;<strong>GradientColor&nbsp;</strong>property sets a color with which palette colors are mixed.</p>

<br/>


