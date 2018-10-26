Public Class FAutor1
    Dim FuncAutor As New DAutor1
    Dim DatAutor As New LAutor1
    Private Sub FAutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargarListaAutor()
    End Sub

    Public Sub CargarListaAutor()
        Dim CantRegistros As Integer
        Try
            dgvAutor.DataSource = FuncAutor.MostrarAutor

            CantRegistros = dgvAutor.RowCount

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dgvAutor.ClearSelection()
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim valordecajas As Boolean
            valordecajas = True

            For Each Caja As Control In GroupBox2.Controls
                If TypeOf (Caja) Is TextBox Then
                    If Trim(Caja.Text) = "" Then
                        valordecajas = False
                        Exit For
                    End If
                End If
            Next

    Private Sub FAutor1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class