Imports System.Windows.Forms

Public Class Dialog1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        If TextBox1.Text = "ILOVENEXT" Or TextBox1.Text = "ilovenext" Or TextBox1.Text = "Ilovenext" Then
            My.Computer.Audio.Play(My.Resources.y2mate_com___Minecraft_Door_Open_and_Close__Sound_Effect_HD, AudioPlayMode.Background)
            Form1.Panel2.Width = 22
        Else
            MsgBox("Invalid code!!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub
End Class
