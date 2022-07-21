Imports System.Windows.Forms

Public Class CPM

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CPM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim col As New Generic.List(Of Type)
        Dim list() As System.Reflection.Assembly = AppDomain.CurrentDomain.GetAssemblies()

        For Each asm As Reflection.Assembly In list
            Dim types() As Type = asm.GetTypes()
            For Each t As Type In types
                If t.BaseType Is GetType(System.Windows.Forms.Form) Then
                    ComboBox1.Items.Add(t.Name)
                End If
            Next
        Next
        Dim cont As String = ComboBox1.SelectedText
        Label3.Text = cont
        Dim ctr As String = Label3.Text

        For Each ctrl As Control In Form1.Controls
            ComboBox2.Items.Add(ctrl.Name)
        Next

        For Each ctrl2 As Control In Form1.Panel1.Controls
            ComboBox2.Items.Add(ctrl2.Name)
        Next

        For Each ctrl3 As Control In Form1.ToolStrip1.Controls
            ComboBox2.Items.Add(ctrl3.Name)
        Next
    End Sub
End Class
