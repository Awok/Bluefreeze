Imports System.Threading
Imports System.Net
Imports Ionic.Zip

Public Class Form7
    Dim image As Integer = 0
    Dim textlbl As String = ""
    Dim valuebar As Integer = 0
    Dim v10letfreezey = False
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        'ProgressBar1.ForeColor.Blue.Blue
        ThreadPool.QueueUserWorkItem(AddressOf freezy)
    End Sub
    Private Sub freezy()

        textlbl = "Extracting Resources"
        Label1.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))
        Using zip1 As ZipFile = ZipFile.Read(My.Resources.main)
            zip1.ExtractAll(path, True)
            zip1.Dispose()
        End Using
        valuebar = 10
        ProgressBar1.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

        Delay(1)

        textlbl = "Extracting First IPSW"
        Label1.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))
        unzip(ipsw1, "building1")
        valuebar = 20
        ProgressBar1.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

        textlbl = "Extracting Second IPSW"
        Label1.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))
        unzip(ipsw2, "building2")
        valuebar = 30
        ProgressBar1.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

        If skip = False Then
            getKeys()
            If do_it = True Then
                textlbl = "Decompiling Ramdisk"
                Label1.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))
                If not_encrypted = False Then
                    Shell(path & "\resource\xpwntool.exe" & space & path & "\building2\" & ramdisk & space & path & "\decrypted.dmg" & " -iv " & iv & " -k " & key)
                Else
                    My.Computer.FileSystem.MoveFile(path & "\building2\" & ramdisk, path & "\decrypted.dmg")
                End If
                valuebar = 40
                ProgressBar1.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                Delay(1)

                textlbl = "Patching Ramdisk"
                'It's not really!
                Label1.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))
                Shell(path & "\resource\hfsplus.exe" & space & path & "\decrypted.dmg" & " rm /usr/share/progressui/images-1x/applelogo.png")
                Shell(path & "\resource\hfsplus.exe" & space & path & "\decrypted.dmg" & " rm /usr/share/progressui/images-2x/applelogo.png")
                Shell(path & "\resource\hfsplus.exe" & space & path & "\decrypted.dmg add " & path & "\resource\applelogox1.png" & space & "/usr/share/progressui/images-1x/applelogo.png")
                Shell(path & "\resource\hfsplus.exe" & space & path & "\decrypted.dmg add " & path & "\resource\applelogox2.png" & space & "/usr/share/progressui/images-2x/applelogo.png")
                valuebar = 50
                ProgressBar1.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

                Delay(1)
                Try
                    textlbl = "Rebuilding Ramdisk"
                    Label1.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))
                    'Shell(path & "\resource\xpwntool.exe" & space & path & "\decrypted.dmg" & space & path & "\" & ramdisk & " -t " & path & "\building2\" & ramdisk & " -iv " & iv & " -k " & key)
                    Dim process As New Process()
                    Dim FileName As String = path & "\resource\xpwntool.exe"
                    Dim Arguments As String = path & "\decrypted.dmg" & space & path & "\" & ramdisk & " -t " & path & "\building2\" & ramdisk & " -iv " & iv & " -k " & key
                    process.StartInfo.UseShellExecute = False
                    process.StartInfo.RedirectStandardOutput = True
                    process.StartInfo.RedirectStandardError = True
                    process.StartInfo.CreateNoWindow = True
                    process.StartInfo.FileName = FileName
                    process.StartInfo.Arguments = Arguments
                    process.Start()
                    Dim output As String = process.StandardOutput.ReadToEnd()
                    'MessageBox.Show(output)
                    My.Computer.FileSystem.DeleteFile(path & "\building2\" & ramdisk)
                    My.Computer.FileSystem.MoveFile(path & "\" & ramdisk, path & "\building2\" & ramdisk)
                    valuebar = 60
                    ProgressBar1.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))
                Catch e As System.Exception
                    MessageBox.Show("Error: " & e.ToString & "Please report this", "Bluefreeze")
                    Form1.Close()
                End Try
                Delay(1)
            End If
        End If
        textlbl = "Deleting corrupt img3's"
        Label1.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))
        My.Computer.FileSystem.DeleteDirectory(path & "\building2\Firmware\all_flash", Microsoft.VisualBasic.FileIO.DeleteDirectoryOption.DeleteAllContents)
        valuebar = 70
        ProgressBar1.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

        Delay(1)

        textlbl = "Moving proper img3's"
        Label1.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))
        My.Computer.FileSystem.MoveDirectory(path & "\building1\Firmware\all_flash", path & "\building2\Firmware\all_flash")
        valuebar = 75
        ProgressBar1.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

        Delay(1)

        textlbl = "Rebuilding IPSW"
        Label1.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))
        zip()
        valuebar = 90
        ProgressBar1.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

        textlbl = "Cleaning up"
        Label1.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))
        If My.Computer.FileSystem.DirectoryExists(path) = True Then
            My.Computer.FileSystem.DeleteDirectory(path, Microsoft.VisualBasic.FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
        My.Computer.FileSystem.CreateDirectory(path)
        valuebar = 95
        ProgressBar1.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

        Delay(1)

        textlbl = "Done"
        Label1.Invoke(CType(AddressOf ChangeLabelText, MethodInvoker))
        valuebar = 100
        ProgressBar1.Invoke(CType(AddressOf ChangeProgressbar, MethodInvoker))

        Timer1.Stop()
        PictureBox1.Image = My.Resources.V10letfreeze
        v10letfreezey = True
    End Sub
    Private Sub ChangeLabelText()
        Label1.Text = textlbl
        Label1.Left = (Width / 2) - (Label1.Width / 2)
    End Sub
    Private Sub ChangeProgressbar()
        ProgressBar1.Value = valuebar
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        image = image + 1
        If image = 1 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00001
        ElseIf image = 2 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00002
        ElseIf image = 3 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00003
        ElseIf image = 4 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00004
        ElseIf image = 5 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00005
        ElseIf image = 6 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00006
        ElseIf image = 7 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00007
        ElseIf image = 8 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00008
        ElseIf image = 9 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00009
        ElseIf image = 10 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00010
        ElseIf image = 11 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00011
        ElseIf image = 12 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00012
        ElseIf image = 13 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00013
        ElseIf image = 14 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00014
        ElseIf image = 15 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00015
        ElseIf image = 16 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00016
        ElseIf image = 17 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00017
        ElseIf image = 18 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00018
        ElseIf image = 19 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00019
        ElseIf image = 20 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00020
        ElseIf image = 21 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00021
        ElseIf image = 22 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00022
        ElseIf image = 23 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00023
        ElseIf image = 24 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00024
        ElseIf image = 25 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00025
        ElseIf image = 26 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00026
        ElseIf image = 27 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00027
        ElseIf image = 28 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00028
        ElseIf image = 29 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00029
        ElseIf image = 30 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00030
        ElseIf image = 31 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00031
        ElseIf image = 32 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00032
        ElseIf image = 33 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00033
        ElseIf image = 34 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00034
        ElseIf image = 35 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00035
        ElseIf image = 36 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00036
        ElseIf image = 37 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00037
        ElseIf image = 38 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00038
        ElseIf image = 39 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00039
        ElseIf image = 40 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00040
        ElseIf image = 41 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00041
        ElseIf image = 42 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00042
        ElseIf image = 43 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00043
        ElseIf image = 44 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00044
        ElseIf image = 45 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00045
        ElseIf image = 46 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00046
        ElseIf image = 47 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00047
        ElseIf image = 48 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00048
        ElseIf image = 49 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00049
        ElseIf image = 50 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00050
        ElseIf image = 51 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00051
        ElseIf image = 52 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00052
        ElseIf image = 53 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00053
        ElseIf image = 54 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00054
        ElseIf image = 55 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00055
        ElseIf image = 56 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00056
        ElseIf image = 57 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00057
        ElseIf image = 58 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00058
        ElseIf image = 59 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00059
        ElseIf image = 60 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00060
        ElseIf image = 61 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00061
        ElseIf image = 62 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00062
        ElseIf image = 63 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00063
        ElseIf image = 64 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00064
        ElseIf image = 65 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00065
        ElseIf image = 66 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00066
        ElseIf image = 67 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00067
        ElseIf image = 68 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00068
        ElseIf image = 69 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00069
        ElseIf image = 70 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00070
        ElseIf image = 71 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00071
        ElseIf image = 72 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00072
        ElseIf image = 73 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00073
        ElseIf image = 74 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00074
        ElseIf image = 75 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00075
        ElseIf image = 76 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00076
        ElseIf image = 77 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00077
        ElseIf image = 78 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00078
        ElseIf image = 79 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00079
        ElseIf image = 80 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00080
        ElseIf image = 81 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00081
        ElseIf image = 82 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00082
        ElseIf image = 83 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00083
        ElseIf image = 84 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00084
        ElseIf image = 85 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00085
        ElseIf image = 86 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00086
        ElseIf image = 87 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00087
        ElseIf image = 88 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00088
        ElseIf image = 89 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00089
        ElseIf image = 90 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00090
        ElseIf image = 91 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00091
        ElseIf image = 92 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00092
        ElseIf image = 93 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00093
        ElseIf image = 94 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00094
        ElseIf image = 95 Then
            PictureBox1.Image = My.Resources.Comp_2_1_00095
            image = 0
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If v10letfreezey = True Then
            v10letfreeze.MdiParent = Form1
            v10letfreeze.Show()
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Form1.Close()
    End Sub
End Class