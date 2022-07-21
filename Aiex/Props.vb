Imports System.Windows.Forms

Public Class Props

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

        If InStr(TextBoxp.Text, ".java") Then
            Dim newtab As New TabPage
            newtab.Text = TextBoxp.Text
            Dim fctb As New FastColoredTextBoxNS.FastColoredTextBox
            fctb.Dock = DockStyle.Fill
            Form1.AutocompleteMenu1.SetAutocompleteMenu(fctb, Form1.AutocompleteMenu1)
            fctb.Language = FastColoredTextBoxNS.Language.JS
            newtab.Controls.Add(fctb)
            fctb.ContextMenu = Form1.ContextMenu1
            Form1.TabControl1.TabPages.Add(newtab)
            Form1.TabControl1.SelectedTab = newtab
        Else
            Dim newtab As New TabPage
            newtab.Text = TextBoxp.Text & ".java"
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
        TextBoxp.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
End Class
