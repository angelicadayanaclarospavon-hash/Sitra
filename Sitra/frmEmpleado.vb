Public Class frmEmpleado
    Private Sub EmpleadoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpleadoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._system2026_2002_2003_DataSet)

    End Sub

    Private Sub frmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_system2026_2002_2003_DataSet.empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me._system2026_2002_2003_DataSet.empleado)

    End Sub
End Class