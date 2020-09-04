Public Class frmCSDatabase
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.DatabaseDataSet.User)

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        UserBindingSource.RemoveCurrent()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        UserBindingSource.EndEdit()
        UserTableAdapter.Update(DatabaseDataSet.User)
    End Sub

    Private Sub ButtonAddNew_Click(sender As Object, e As EventArgs) Handles ButtonAddNew.Click
        UserBindingSource.AddNew()
    End Sub
End Class
