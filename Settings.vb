Public Class Settings
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Save()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' FontDialog1.Font = Writer.FastColoredTextBox1.Font
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.idefont = FontDialog1.Font
        My.Settings.Save()
        ' Writer.FastColoredTextBox1.Font = FontDialog1.Font
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' If FontDialog1.ShowDialog = DialogResult.OK Then Writer.FastColoredTextBox1.Font = FontDialog1.Font
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Form1.MenuItem21.Checked Then
            CheckBox1.Checked = False
            Form1.MenuItem21.Checked = False
            Form1.ToolStrip1.BackColor = Color.White
            Form1.ToolStrip1.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
            ' Writer.FastColoredTextBox1.BackColor = Color.White
            ' Writer.FastColoredTextBox1.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
            ' Writer.FastColoredTextBox1.CaretColor = Color.Black
            ' Writer.FastColoredTextBox1.LineNumberColor = Color.Teal
            ' Writer.FastColoredTextBox1.IndentBackColor = Color.WhiteSmoke
            Form1.BackColor = Color.Black
            Form1.ForeColor = Color.White
            Form1.StatusStrip1.BackColor = Color.FromKnownColor(KnownColor.Control)
            Form1.StatusStrip1.ForeColor = Color.Black
            Form1.ToolStripButton11.Text = "Dark Mode (Disabled)"
            Form1.ToolStripButton11.Image = My.Resources.ezgif1
        Else
            CheckBox1.Checked = True
            Form1.MenuItem21.Checked = False
            Form1.MenuItem21.Checked = True
            Form1.ToolStrip1.BackColor = Color.FromKnownColor(KnownColor.ControlDarkDark)
            Form1.ToolStrip1.ForeColor = Color.White
            ' Writer.FastColoredTextBox1.BackColor = Color.Black
            ' Writer.FastColoredTextBox1.ForeColor = Color.White
            ' Writer.FastColoredTextBox1.CaretColor = Color.White
            ' Writer.FastColoredTextBox1.LineNumberColor = Color.White
            ' Writer.FastColoredTextBox1.IndentBackColor = Color.FromKnownColor(KnownColor.ControlDarkDark)
            Form1.BackColor = Color.FromKnownColor(KnownColor.Control)
            Form1.ForeColor = Color.Black
            Form1.StatusStrip1.BackColor = Color.Gray
            Form1.StatusStrip1.ForeColor = Color.White
            Form1.ToolStripButton11.Text = "Dark Mode (Enabled)"
            Form1.ToolStripButton11.Image = My.Resources.icons8_sun_50
        End If
    End Sub
End Class