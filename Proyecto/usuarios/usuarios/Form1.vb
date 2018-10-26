Public Class login
    Public conexion As SqlClient.SqlConnection
    Dim accion As String, id As String, sql As String
    Dim res As Integer, nom, email, pass As String
    Dim com As SqlClient.SqlCommand, dr As SqlClient.SqlDataReader
    Dim da As SqlClient.SqlDataAdapter, cb As SqlClient.SqlCommandBuilder
    Dim ds As DataSet
    Public Sub conectar()
        conexion = New SqlClient.SqlConnection
        conexion.ConnectionString = ("Server=ROBERES\MSSQLSERVER2; database=registro;Integrated Security=True")
        conexion.Open()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Me.verificar()
    End Sub
    Private Sub verificar()
        id = tu.Text
        pass = tc.Text
        If id = "" Then
            lm.Visible = True
        Else
            lm.Visible = False
        End If
        If pass = "" Then
            lm1.Visible = True
        Else
            lm1.Visible = False
        End If
        If id <> "" And pass <> "" Then
            sql = "exec ver_users '" + id + "'"
            conectar()
            com = New SqlClient.SqlCommand(sql, conexion)
            dr = com.ExecuteReader
            If dr.Read Then
                If id = dr(0) And pass = dr(3) Then
                    proyecto.lbluser.Text = dr(1)
                    proyecto.Show()


                Else
                    MsgBox("Contraseña incorrecta", MsgBoxStyle.Exclamation, "Acceso Denegado")
                End If
            Else
                MsgBox("Por favor Registrese", MsgBoxStyle.Exclamation, "Acceso Denegado")
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        registro.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
