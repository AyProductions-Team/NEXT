Public Class help
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
End Class