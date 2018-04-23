# How to: provide flat data to TreeMap


This example demonstrates how to visualize flat data using TreeMap and color it using Group Gradient Colorizer.


<h3>Description</h3>

<p>To provide flat data to TreeMap, create a&nbsp;<strong>TreeMapFlatDataAdapter</strong>&nbsp;object and assign it to the&nbsp;<strong>TreeMapControl.DataAdapter</strong>&nbsp;property. Then, specify the adapter's&nbsp;<strong>DataSource</strong>,&nbsp;<strong>LabelDataMember</strong>&nbsp;and&nbsp;<strong>ValueDataMember</strong>&nbsp;to configure the data source object and which data members should be used to generate tree map items. If it is required to group generated items, add the&nbsp;name of a data member, whose values should be used to group items, to the&nbsp;<strong>GroupDataMembers</strong>&nbsp;collection.</p>
<p>Finally, to color each tree map group using similar colors, use the&nbsp;<strong>TreeMapGroupGradientColoriezer&nbsp;</strong>class. The&nbsp;<strong>Palette</strong>&nbsp;property specifies colors assigned&nbsp;to&nbsp;groups. The&nbsp;<strong>Max</strong>&nbsp;and&nbsp;<strong>Min</strong>&nbsp;properties configure the maximum and minimum portion of palette colors in colors assigned to items. The&nbsp;<strong>GradientColor&nbsp;</strong>property sets a color with which palette colors are mixed.</p>

<br/>


