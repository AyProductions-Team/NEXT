Public Class help
    Dim sec As Integer
    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = WebBrowser1.DocumentTitle
        If WebBrowser1.DocumentTitle = Nothing Then
            ToolStripStatusLabel1.Text = "No Page Available"
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        ToolStripStatusLabel1.Text = WebBrowser1.DocumentTitle
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox2.Visible = True
        My.Computer.Audio.Play(My.Resources.FF7_Battle_Theme, AudioPlayMode.Background)
        ToolStripStatusLabel1.Text = "Loading help map..."
        Button3.Visible = True
        sec = 0
        Timer1.Start()
    End Sub

    Private Sub help_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sec = sec + 1
        If sec >= 11 Then
            Timer1.Stop() 'Timer stops functioning
            PictureBox2.Visible = False
            Button3.Visible = False
            ToolStripStatusLabel1.Text = "hello"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
        WebBrowser1.Navigate(Application.StartupPath & "\Help\errors\Document1.html")
        If TextBox1.Text = "Who knows who built this tool?" Then
            credits.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Stop()
        My.Computer.Audio.Stop()
        PictureBox2.Visible = False
        Button3.Visible = False
        WebBrowser1.GoBack()
    End Sub

    Private Sub LinkLabel21_Click(sender As Object, e As EventArgs) Handles LinkLabel21.Click
        Dim pth As String = Environment.GetEnvironmentVariable("ProgramW6432") & "\Internet Explorer\iexplore.exe"
        If System.IO.File.Exists(pth) Then
            MsgBox("No need to install. You already have it installed.", MsgBoxStyle.Information, "Message 0x50")
        Else
            Process.Start("link")
        End If

    End Sub
End Class