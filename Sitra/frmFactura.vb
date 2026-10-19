Public Class frmFactura
    Private Sub FacturaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FacturaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FacturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._system2026_2002_2003_DataSet)

    End Sub

    Private Sub frmFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_system2026_2002_2003_DataSet.factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me._system2026_2002_2003_DataSet.factura)

    End Sub
End Class