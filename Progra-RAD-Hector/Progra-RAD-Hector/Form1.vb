Imports System.Data.SqlClient
Public Class Login
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Application.Exit()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        txtusuario.Clear()
        txtcontra.Clear()
        txtusuario.Focus()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim con As New SqlClient.SqlConnection(My.Settings.ProRad)
        con.Open()
        Dim reader As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("select * from Usuarios where idusuario = '" & txtusuario.Text & "' and contrasena =  '" & txtcontra.Text & "' ", con)
        reader = cmd.ExecuteReader

        If reader.Read() Then
            MessageBox.Show("Registered user!")
        End If
    End Sub
End Class
