Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Net

Public Class Form2

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Form1.Close()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Form3.MdiParent = Form1
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("blueJay exploit: J. Code :j0ker. By The Private Dev Team inc. This tool modifies iH8sn0w's iFaith shsh bundles, so he deserve's some credit as well. iPhone Dev team for redsn0w (used for booting tethered)", "Bluefreeze")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MessageBox.Show("Please email us at bluefreeze.feedback@gmail.com for any help you may need", "Bluefreeze")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.FileSystem.DeleteFile(path & "\redsn0w.exe")
    End Sub
End Class