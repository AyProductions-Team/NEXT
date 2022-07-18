Public Class About
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel21_Click(sender As Object, e As EventArgs) Handles LinkLabel21.Click
        Process.Start("https://gitee.com/Zhangzqs/AIX-Compiler")
    End Sub

    Private Sub LinkLabel22_Click(sender As Object, e As EventArgs) Handles LinkLabel22.Click
        Process.Start("https://wyday.com/linklabel2/")
    End Sub

    Private Sub LinkLabel23_Click(sender As Object, e As EventArgs) Handles LinkLabel23.Click
        Process.Start("https://wyday.com/vistamenu/")
    End Sub

    Private Sub LinkLabel24_Click(sender As Object, e As EventArgs) Handles LinkLabel24.Click
        Process.Start("https://www.codeproject.com/Articles/161871/Fast-Colored-TextBox-for-syntax-highlighting-2")
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel25_Click(sender As Object, e As EventArgs) Handles LinkLabel25.Click
        help.Show()
    End Sub
End Class