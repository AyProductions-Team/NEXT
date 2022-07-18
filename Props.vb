Imports System.Windows.Forms

Public Class Props

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
        Try
            Form1.TabControl1.SelectedTab = Form1.TabPage1
            Form1.TabControl1.TabPages.Remove(Form1.TabControl1.SelectedTab)
        Catch ex As Exception
            Exit Try
        End Try

        If InStr(TextBox1.Text, ".java") Then
            Dim newtab As New TabPage
            newtab.Text = TextBox1.Text
            Dim fctb As New FastColoredTextBoxNS.FastColoredTextBox
            fctb.Dock = DockStyle.Fill
            Form1.AutocompleteMenu1.SetAutocompleteMenu(fctb, Form1.AutocompleteMenu1)
            fctb.Language = FastColoredTextBoxNS.Language.JS
            newtab.Controls.Add(fctb)
            Form1.TabControl1.TabPages.Add(newtab)
            Form1.TabControl1.SelectedTab = newtab
        Else
            Dim newtab As New TabPage
            newtab.Text = TextBox1.Text & ".java"
            Dim fctb As New FastColoredTextBoxNS.FastColoredTextBox
            fctb.Dock = DockStyle.Fill
            Form1.AutocompleteMenu1.SetAutocompleteMenu(fctb, Form1.AutocompleteMenu1)
            fctb.Language = FastColoredTextBoxNS.Language.JS
            newtab.Controls.Add(fctb)
            Form1.TabControl1.TabPages.Add(newtab)
            Form1.TabControl1.SelectedTab = newtab
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Props_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
