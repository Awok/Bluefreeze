Imports System.Net
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports Ionic.Zip

Public Class Form5
    Dim image As Integer = 0
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        If My.Computer.FileSystem.FileExists(path & "\redsn0w.exe") Then
            My.Computer.FileSystem.DeleteFile(path & "\redsn0w.exe")
        End If
        System.IO.File.WriteAllBytes(path & "\redsn0w.exe", My.Resources.redsn0w)
        If My.Computer.FileSystem.FileExists(path & "\bootlogo.png") Then
            My.Computer.FileSystem.DeleteFile(path & "\bootlogo.png")
        End If
        Using zip1 As ZipFile = ZipFile.Read(My.Resources.pic)
            zip1.ExtractAll(path, True)
            zip1.Dispose()
        End Using
        Bootfreeze.MdiParent = Form1
        Bootfreeze.Show()
        Me.Close()
        ProgressBar1.Value = 100
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
End Class