Partial Class dbventasDataSet
    Partial Public Class usuarioDataTable
        Private Sub usuarioDataTable_usuarioRowChanging(sender As Object, e As usuarioRowChangeEvent) Handles Me.usuarioRowChanging

        End Sub

        Private Sub usuarioDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.idusuarioColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class
