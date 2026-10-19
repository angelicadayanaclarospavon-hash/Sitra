Public Class frmCategoria
    Private Sub CategoriaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CategoriaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CategoriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._system2026_2002_2003_DataSet)

    End Sub

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_system2026_2002_2003_DataSet.categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me._system2026_2002_2003_DataSet.categoria)

    End Sub

    Private Sub IdcategoriaLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class