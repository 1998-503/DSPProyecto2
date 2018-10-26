Public Class registro
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Me.verificar()

    End Sub
    Private Sub verificar()
        If tid.Text = "" Then
            m1.Visible = True
        Else
            m1.Visible = False
        End If
        If tnom.Text = "" Then
            m2.Visible = True
        Else
            m2.Visible = False
        End If
        If tmail.Text = "" Then
            m3.Visible = True
        Else
            m3.Visible = False
        End If
        If tcon.Text = "" Then
            m4.Visible = True
        Else
            m4.Visible = False
        End If
        If tid.Text <> "" And tnom.Text <> "" And tmail.Text <> "" And tcon.Text <> "" Then
            Call Me.register()
            Me.Hide()

            login.Show()
        End If
    End Sub
    Private Sub register()
        id = tid.Text
        nom = tnom.Text
        email = tmail.Text
        pass = tcon.Text
        sql = "exec ver_users  '" + id + "'"
        conectar()
        com = New SqlClient.SqlCommand(sql, conexion)
        dr = com.ExecuteReader
        If dr.Read Then
            MessageBox.Show("El ID ya esta Registrado", "users", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dr.Close()
            conexion.Close()
        Else
            sql = "exec alta_users" + "'" + id + "','" + nom + "','" + email + "','" + pass + "'"
            conectar()
            com = New SqlClient.SqlCommand(sql, conexion)
            res = com.ExecuteNonQuery
            conexion.Close()

            MsgBox("Felicidades ya puede Logearse", MsgBoxStyle.Information, "Datos Guardados Exitosamente")

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class