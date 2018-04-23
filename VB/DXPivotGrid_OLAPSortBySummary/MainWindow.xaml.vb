Imports System.Windows
Imports DevExpress.Xpf.PivotGrid

Namespace DXPivotGrid_OLAPSortBySummary
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            pivotGridControl1.OlapConnectionString = "provider=MSOLAP;" &
                "data source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll;" &
                "initial catalog='Adventure Works DW Standard Edition';" &
                "cube name='Adventure Works'"
        End Sub
        Private Sub pivotGridControl1_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)

            ' Expands the Australia column to be able to retrieve OLAP members 
            ' that correspond to the nested columns.
            pivotGridControl1.ExpandValue(True, New Object() { "Australia" })

            ' Obtains OLAP members corresponding to the Australia and Bendigo values.
            Dim countryMember As PivotOlapMember = pivotGridControl1.GetFieldValueOlapMember( _
                fieldCountry, 0)
            Dim cityMember As PivotOlapMember = pivotGridControl1.GetFieldValueOlapMember( _
                fieldCity, 0)

            ' Exits if the OLAP members were not obtained successfully.
            If countryMember Is Nothing OrElse cityMember Is Nothing Then
                Return
            End If

            ' Locks the pivot grid from updating while the Sort by Summary
            ' settings are being customized.
            pivotGridControl1.BeginUpdate()
            Try

                ' Specifies a data field whose summary values should be used to sort values
                ' of the Month field.
                fieldMonth.SortByField = fieldSales

                ' Specifies a column by which the Month field values should be sorted.
                fieldMonth.SortByConditions.Add(New SortByCondition(fieldCountry, _
                                                "Australia", countryMember.UniqueName))
                fieldMonth.SortByConditions.Add(New SortByCondition(fieldCity, _
                                                     "Bendigo", cityMember.UniqueName))
            Finally

                ' Unlocks the pivot grid and applies changes.
                pivotGridControl1.EndUpdate()
            End Try
        End Sub
    End Class
End Namespace
