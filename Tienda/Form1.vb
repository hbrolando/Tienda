Imports System.Data.SqlClient

Public Class Form1

    Private Sub CLIENTESBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLIENTESBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CLIENTESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TIENDADataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CODIGO_CITextBox.Enabled = 0
        CLIENTESBindingNavigator.BackColor = Color.LightSkyBlue
        'TODO: esta línea de código carga datos en la tabla 'TIENDADataSet.CLIENTES' Puede moverla o quitarla según sea necesario.
        Me.CLIENTESTableAdapter.Fill(Me.TIENDADataSet.CLIENTES)

        Dim con As New SqlConnection(My.Settings.Conexion)
        Dim sql As String = "SELECT NOMBRE_COMPLETO,APELLIDO_PATERNO,APELLIDO_MATERNO,FECHA_NACIMIENTO,CELULAR,CORREO FROM CLIENTES"
        Dim cnd As New SqlCommand(sql, con)
        Try
            Dim da As New SqlDataAdapter(cnd)
            Dim ds As New DataSet
            da.Fill(ds, "CLIENTES")
            Me.DataGridView1.DataSource = ds.Tables("CLIENTES")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class
