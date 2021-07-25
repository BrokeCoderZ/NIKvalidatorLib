Public Class aboutapp
    Private Sub aboutapp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text = My.Resources.infoApp
        txtAplikasiVersi.Text = Aplikasiversi()
    End Sub
    Private Function Aplikasiversi()
        Return "Aplikasi versi : " & My.Application.Info.Version.ToString()
    End Function

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        visit(My.Resources.youtube)
    End Sub


    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        visit(My.Resources.facebookpage)
    End Sub
    Private Sub visit(link)
        If MessageBox.Show("Visit : " & vbNewLine & link, "Visit link?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                Process.Start(link)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class