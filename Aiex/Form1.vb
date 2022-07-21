Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form1
    Dim integ As Integer = 1

    Private Sub MenuItem7_Click(sender As Object, e As EventArgs)
        Try
            Process.Start("cd " & Settings.TextBox1.Text & " && ant extensions")
        Catch ex As Exception
            MsgBox("Unable to compile project." & vbCrLf & vbCrLf & "Make sure you have Java JDK 8 installed." & vbCrLf & "Make sure you have Apache Ant 10 configured properly." & vbCrLf & "Make sure you have MIT extension template installed and configured in the settings of this IDE.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MenuItem9_Click(sender As Object, e As EventArgs) Handles MenuItem9.Click
        About.Show()
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        ' Label3.Parent = PictureBox7
        ' Writer.FastColoredTextBox1.Font = Settings.FontDialog1.Font
        ' ToolStripLabel1.Text = Writer.FastColoredTextBox1.Font.Size
    End Sub



    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Props.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                TabControl1.SelectedTab = TabPage1
                TabControl1.TabPages.Remove(TabControl1.SelectedTab)
            Catch ex As Exception
                Exit Try
            End Try
            Dim newtab As New TabPage
            newtab.Text = OpenFileDialog1.SafeFileName
            Dim fctb As New FastColoredTextBoxNS.FastColoredTextBox
            fctb.Dock = DockStyle.Fill
            fctb.Language = FastColoredTextBoxNS.Language.CSharp
            AutocompleteMenu1.SetAutocompleteMenu(fctb, AutocompleteMenu1)
            fctb.OpenFile(OpenFileDialog1.FileName)
            newtab.Controls.Add(fctb)
            TabControl1.TabPages.Add(newtab)
            TabControl1.SelectedTab = newtab
        End If
    End Sub



    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Dim dlgsave As New SaveFileDialog
        dlgsave.Filter = "JAVA files|*.java"
        If dlgsave.ShowDialog = DialogResult.OK Then
            CType(TabControl1.SelectedTab.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).SaveToFile(dlgsave.FileName, System.Text.Encoding.UTF8)
            'Me.Text = "NEXT v1.0b2 [" & dlgsave.FileName & "]"
            'ToolStripStatusLabel1.Text = dlgsave.FileName
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Try
            Process.Start("cd " & Settings.TextBox1.Text & " && ant extensions")
            MsgBox("Compiled successfully!!", MsgBoxStyle.Information, "Message 0x49")
        Catch ex As Exception
            MsgBox("Unable to compile project (" & ex.Message & ")", MsgBoxStyle.Critical, "Error 0x33AE")
        End Try
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        Settings.Show()
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Paste()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Copy()
    End Sub



    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Undo()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Redo()
    End Sub



    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles ToolStripButton14.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Font = New Font(CType(TabControl1.SelectedTab.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Font.FontFamily, CType(TabControl1.SelectedTab.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Font.Size + 3)
        ToolStripLabel1.Text = CType(TabControl1.SelectedTab.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Font.Size
    End Sub

    Private Sub ToolStripButton15_Click(sender As Object, e As EventArgs) Handles ToolStripButton15.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Font = New Font(CType(TabControl1.SelectedTab.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Font.FontFamily, CType(TabControl1.SelectedTab.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Font.Size - 3)
        ToolStripLabel1.Text = CType(TabControl1.SelectedTab.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Font.Size
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl1.DrawItem
        e.Graphics.DrawString("✕", e.Font, Brushes.Red, e.Bounds.Right - 20, e.Bounds.Top + 4)
        e.Graphics.DrawString(Me.TabControl1.TabPages(e.Index).Text, e.Font, Brushes.Black, e.Bounds.Left + 4, e.Bounds.Top + 4)
        e.DrawFocusRectangle()
    End Sub

    Private Sub TabControl1_MouseDown(sender As Object, e As MouseEventArgs) Handles TabControl1.MouseDown
        Dim i As Integer
        For i = 0 To Me.TabControl1.TabPages.Count - 1 Step i + 1
            Dim r As Rectangle = TabControl1.GetTabRect(i)
            'Getting the position of the "x" mark.
            Dim closeButton As Rectangle = New Rectangle(r.Right - 20, r.Top + 6, 11, 8)
            If closeButton.Contains(e.Location) Then
                Me.TabControl1.TabPages.RemoveAt(i)
                Exit For
            End If
        Next
    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).ShowFindDialog()
    End Sub

    Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles ToolStripButton13.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).ShowReplaceDialog()
    End Sub

    Private Sub LinkLabel23_Click(sender As Object, e As EventArgs) Handles LinkLabel23.Click
        Process.Start("https://ayproductions.github.io/")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripLabel2.Text = System.DateTime.Now.ToString("hh:mm tt")
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Stop()
        My.Settings.Save()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Process.Start("www.mit.edu")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("www.java.com")
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Process.Start("www.apache.org")
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("www.oracle.com")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("https://ant.apache.org/")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("http://appinventor.mit.edu/")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("https://github.com/AyProductions/Aex/issues")
    End Sub

    Private Sub MenuItem3_Click(sender As Object, e As EventArgs) Handles MenuItem3.Click
        ' MenuItem3.Checked = True
        If MenuItem3.Checked = True Then
            MenuItem3.Checked = False
            GroupBox1.Text = "Recent Projects"
            LinkLabel21.Text = "New Project"
            LinkLabel22.Text = "Open Project"
        Else
            MenuItem3.Checked = True
            GroupBox1.Text = "আগের প্রোজেক্টগুলি"
            LinkLabel21.Text = "নতুন প্রোজেক্ট"
            LinkLabel22.Text = "খুলুন প্রোজেক্ট"
        End If
    End Sub

    Private Sub MenuItem21_Click(sender As Object, e As EventArgs) Handles MenuItem21.Click

    End Sub

    Private Sub MenuItem10_Click(sender As Object, e As EventArgs) Handles MenuItem10.Click

    End Sub

    Private Sub LinkLabel21_Click(sender As Object, e As EventArgs) Handles LinkLabel21.Click
        Props.Show()
    End Sub

    Private Sub LinkLabel22_Click(sender As Object, e As EventArgs) Handles LinkLabel22.Click
        ToolStripButton2_Click(Me, e)
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripButton16_Click(sender As Object, e As EventArgs) Handles ToolStripButton16.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://github.com/AyProductions-Team/NEXT/releases")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("https://community.appinventor.mit.edu/")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Try
                TabControl1.SelectedTab = TabPage1
                TabControl1.TabPages.Remove(TabControl1.SelectedTab)
            Catch ex As Exception
                Exit Try
            End Try
        Else

        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If Panel2.Width = 59 Then
            Dialog1.Show()
        Else
            My.Computer.Audio.Play(My.Resources.cloppy, AudioPlayMode.Background)
            Panel2.Width = 59
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ")
    End Sub

    Private Sub MenuItem13_Click(sender As Object, e As EventArgs) Handles MenuItem13.Click
        
    End Sub

    Private Sub MenuItem15_Click(sender As Object, e As EventArgs) Handles MenuItem15.Click
        help.Show()
    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click

    End Sub

    Private Sub MenuItem16_Click(sender As Object, e As EventArgs) Handles MenuItem16.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Undo()
    End Sub

    Private Sub MenuItem17_Click(sender As Object, e As EventArgs) Handles MenuItem17.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Redo()
    End Sub

    Private Sub MenuItem19_Click(sender As Object, e As EventArgs) Handles MenuItem19.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Copy()
    End Sub

    Private Sub MenuItem20_Click(sender As Object, e As EventArgs) Handles MenuItem20.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), FastColoredTextBoxNS.FastColoredTextBox).Paste()
    End Sub

    Private Sub MenuItem23_Click(sender As Object, e As EventArgs) Handles MenuItem23.Click
        CPM.Show()
    End Sub
End Class