Imports DevExpress.XtraTreeMap
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms

Namespace FlatDataAdapterSample

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ConfigureTreeMapDataAdapter()
            ConfigureTreeMapColorizer()
        End Sub

#Region "#FlatDataAdapter"
        Private Sub ConfigureTreeMapDataAdapter()
            Dim adapter As TreeMapFlatDataAdapter = New TreeMapFlatDataAdapter With {.DataSource = CreateBillionaireInfos(), .LabelDataMember = "Name", .ValueDataMember = "NetWorth"}
            adapter.GroupDataMembers.Add("Residence")
            treeMap.DataAdapter = adapter
        End Sub

#End Region  ' #FlatDataAdapter
#Region "#GroupGradientColorizer"
        Private Sub ConfigureTreeMapColorizer()
            treeMap.Colorizer = New TreeMapGroupGradientColorizer With {.GradientColor = Color.White, .Max = 1, .Min = 0.3, .Palette = Palette.Office2013Palette}
        End Sub

#End Region  ' #GroupGradientColorizer
        Private Function CreateBillionaireInfos() As List(Of BillionaireInfo)
            Dim infos As List(Of BillionaireInfo) = New List(Of BillionaireInfo) From {New BillionaireInfo With {.Name = "Bill Gates", .NetWorth = 79.2, .Age = 60, .Residence = "United States", .Source = "Microsoft"}, New BillionaireInfo With {.Name = "Carlos Slim Helu", .NetWorth = 77.1, .Age = 75, .Residence = "Mexico", .Source = "telecom"}, New BillionaireInfo With {.Name = "Warren Buffett", .NetWorth = 72.7, .Age = 85, .Residence = "United States", .Source = "Berkshire Hathaway"}, New BillionaireInfo With {.Name = "Amancio Ortega", .NetWorth = 64.5, .Age = 79, .Residence = "Spain", .Source = "Zara"}, New BillionaireInfo With {.Name = "Larry Ellison", .NetWorth = 54.3, .Age = 71, .Residence = "United States", .Source = "Oracle"}, New BillionaireInfo With {.Name = "Charles Koch", .NetWorth = 42.9, .Age = 79, .Residence = "United States", .Source = "diversified"}, New BillionaireInfo With {.Name = "David Koch", .NetWorth = 42.9, .Age = 75, .Residence = "United States", .Source = "diversified"}, New BillionaireInfo With {.Name = "Christy Walton", .NetWorth = 41.7, .Age = 60, .Residence = "United States", .Source = "Wal-Mart"}, New BillionaireInfo With {.Name = "Jim Walton", .NetWorth = 40.6, .Age = 67, .Residence = "United States", .Source = "Wal-Mart"}, New BillionaireInfo With {.Name = "Liliane Bettencourt", .NetWorth = 40.1, .Age = 93, .Residence = "France", .Source = "L'Oreal"}}
            Return infos
        End Function
    End Class
End Namespace
