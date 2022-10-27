Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LVNama.View = View.Details
        LVNama.GridLines = True
        LVNama.Columns.Add("Nama", 120)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Nama.Click

    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dim jawab =
            MsgBox("Yakin mau keluar?", vbYesNo, "Konfirmasi")
        If jawab = vbYes Then
            End
        End If
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim nama(0) As String
        Dim list As New ListViewItem

        If TxtNama.Text <> "" Then
            nama(0) = TxtNama.Text
            list = LVNama.Items.Add(nama(0))
        Else
            MsgBox("Nama tidak boleh kosong!")
        End If
        TxtNama.Text = ""
        TxtNama.Focus()
    End Sub
End Class
