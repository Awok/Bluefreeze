
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'It has come to my attention that I should set up temp path's
        Shell("taskkill /IM:redsn0w.exe")
        path = System.IO.Path.GetTempPath() & "Bluefreeze"
        If My.Computer.FileSystem.DirectoryExists(path) = False Then
            My.Computer.FileSystem.CreateDirectory(path)
        Else
            My.Computer.FileSystem.DeleteDirectory(path, FileIO.DeleteDirectoryOption.DeleteAllContents)
            My.Computer.FileSystem.CreateDirectory(path)
        End If
        Form2.MdiParent = Me
        Form2.Show()
    End Sub

    Private Sub CustomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomToolStripMenuItem.Click
        Form8.Show()
    End Sub

    Private Sub SkipRamdiskToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkipRamdiskToolStripMenuItem.Click
        skip = True
        MessageBox.Show("Ramdisk modification will be skipped", "Bluefreeze")
    End Sub
End Class