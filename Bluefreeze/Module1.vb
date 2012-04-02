Imports System.Reflection
Imports System.IO
Imports ICSharpCode.SharpZipLib.Zip
Imports ICSharpCode
Imports System.Management
Imports System.Net
Imports System.Text
Imports System.Security.Cryptography

'Copyright (C) <2012>  <The Private Dev Team>
'    This program is free software: you can redistribute it and/or modify
'    it under the terms of the GNU General Public License as published by
'    the Free Software Foundation, either version 3 of the License, or
'    (at your option) any later version.
'
'    This program is distributed in the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty of
'    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License for more details.
'
'    You should have received a copy of the GNU General Public License
'    along with this program.  If not, see <http://www.gnu.org/licenses/>
Module Module1
    Public path As String = ""
    Public ipsw1 As String = ""
    Public ipsw2 As String = ""
    Public ipswsave As String = ""
    Public ramdisk As String = ""
    Public space As String = " "
    Public iv As String = ""
    Public key As String = ""
    Public do_it As Boolean = True
    Public not_encrypted As Boolean = False
    Public DFUConnected As Boolean = False
    Public WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Public sameRedsn0w As Boolean = False
    Public sameBootLogo As Boolean = False
    Public custom As Boolean = False
    Public skip As Boolean = True
    Public Sub editbeginning()
        Form4.RichTextBox1.Text = ""
        Form4.RichTextBox1.AppendText(Environment.NewLine & "<?xml version=""""1.0"""" encoding=""""utf-8""""?>")
        Form4.RichTextBox1.AppendText(Environment.NewLine & "<iFaith>")
        Form4.RichTextBox1.AppendText(Environment.NewLine & "<name start=""""here"""">")
        Form4.RichTextBox1.AppendText(Environment.NewLine & "<revision>1.4.2</revision>")
        Form4.RichTextBox1.AppendText(Environment.NewLine & "<ios>" + Form4.ios + "</ios>")
    End Sub
    Public Sub redsn0w()
        Bootfreeze.Label3.Text = "Booting..."
        Bootfreeze.Button2.Visible = False
        Dim str1 As String = path & "\bootlogo.png"
        If Bootfreeze.ipsw = "" Then
            MessageBox.Show("You didn't select an ipsw", "Bluefreeze")
            Form1.Close()
        Else
            Shell(path & "\redsn0w.exe -j -i " & Bootfreeze.ipsw & " -b " & str1, AppWinStyle.Hide)
            MessageBox.Show("When your device boots up, you may close this application", "Bluefreeze")
        End If
    End Sub
    Public Sub unzip(ByVal file As String, ByVal name As String)
        Using unzip1 As Ionic.Zip.ZipFile = Ionic.Zip.ZipFile.Read(file)
            unzip1.ExtractAll(path & "\" & name)
            unzip1.Dispose()
        End Using
    End Sub
    Public Sub zip()
        Using zip1 As Ionic.Zip.ZipFile = New Ionic.Zip.ZipFile
            zip1.AddDirectory(path & "\building2")
            zip1.Save(ipswsave)
        End Using
    End Sub
    Public Sub Delay(ByVal dblSecs As Double)
        'iH8sn0w's delay code...
        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents() ' Allow windows messages to be processed
        Loop
    End Sub
    Public Sub decompile_ramdisk()
        Shell(path & "\resource\xpwntool.exe" & space & path & "\building2\" & ramdisk & space & path & "\decrypted.dmg" & " -iv " & iv & " -k " & key)
    End Sub
    Public Sub getKeys()
        'There's got to be a better way of doing this...
        'All of the key's below came from the iPhone wiki, thanks so much for the help!
        If My.Computer.FileSystem.FileExists(path & "\building2\018-7923-347.dmg") = True And My.Computer.FileSystem.FileExists(path & "\building2\018-9768-361.dmg") = True Then
            'iPhone 4 Verison---5.0
            iv = "dcf83cf3aa56954eafca7e3b562a137e"
            key = "b8ca7792a46a881099d4220617d6abbcc5548caf4e956649962d8964c3f825da"
            ramdisk = "018-7923-347.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\018-7923-347.dmg") = True And My.Computer.FileSystem.FileExists(path & "\building2\018-7879-364.dmg") = True Then
            'iPhone 4 AT&T---5.0
            iv = "370db2a05be567e5ff81363bbb69b89e"
            key = "774998512d4042a9da350aa07c7cd2f0e2b7c30730e88f3923e9bf029c556798"
            ramdisk = "018-7923-347.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\038-2265-002.dmg") = True Then
            'iPhone 4 AT&T---4.3.5
            not_encrypted = True
            ramdisk = "038-2265-002.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\038-0715-006.dmg") = True Then
            'iPhone 4 AT&T---4.3
            iv = "d11772b6a3bdd4f0b4cd8795b9f10ad9"
            key = "9873392c91743857cf5b35c9017c6683d5659c9358f35c742be27bfb03dee77c"
            ramdisk = "038-0715-006.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\038-0032-002.dmg") = True Then
            'iPhone 4 AT&T---4.2.1
            iv = "9b20ae16bebf4cf1b9101374c3ab0095"
            key = "06849aead2e9a6ca8a82c3929bad5c2368942e3681a3d5751720d2aacf0694c0"
            ramdisk = "038-0032-002.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\018-7082-092.dmg") = True Then
            'iPhone 4 AT&T---4.1
            iv = "103ae8786d55bebdea996a56706641c9"
            key = "a80b3c27041f09d4554bbf4af59dd5bcea38bd4fe2faf82d8d6f62853ec6b337"
            ramdisk = "018-7082-092.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\018-7919-343.dmg") = True Then
            'iPhone 3GS---5.0
            iv = "57da5d3b645d4accee13806b7f46a3b3"
            key = "38231b8e8c4348a375288884ae230a52ceaf9b8fd05f57d6812d6b9d9c5357cb"
            ramdisk = "018-7919-343.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\038-2257-002.dmg") = True Then
            'iPhone 3GS---4.3.5
            not_encrypted = True
            ramdisk = "038-2257-002.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\038-0713-006.dmg") = True Then
            'iPhone 3GS---4.3
            iv = "9f4ca36fb6b30edaebdfbec3c67ce128"
            key = "8bb1fd99c264f46e9b5219cf4817d6e8c0d5915a893a037f31f82bd43f97ce60"
            ramdisk = "038-0713-006.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\038-0082-001.dmg") = True Then
            'iPhone 3GS---4.2.1
            iv = "50932f5bd4dbd51fc0073851fe8b073c"
            key = "15a37ae180c0f51d119c9709f244211fc27334b8c7367dd80147f5e5952d0327"
            ramdisk = "038-0082-001.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\018-7080-079.dmg") = True Then
            'iPhone 3GS---4.1
            iv = "214388b7e0589464bf59966524ae2ea4"
            key = "581f739963fc3fdbf70dfc695b35d43662a0069b501cb715264c32428e759cba"
            ramdisk = "018-7080-079.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\018-7923-347.dmg") = True Then
            'iPod Touch 4---5.0
            iv = "6aa6791d75e07b6866e42b04f80b90d6"
            key = "203ff7f82ff601232c7f8d3b53d3005d3218a5121ccf7eca4c9bf8a6870b7bf3"
            ramdisk = "018-7923-347.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\038-2268-002.dmg") = True Then
            'iPod Touch 4---4.3.5
            not_encrypted = True
            ramdisk = "038-2268-002.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\038-0715-006.dmg") = True Then
            'iPod Touch 4---4.3
            iv = "d11772b6a3bdd4f0b4cd8795b9f10ad9"
            key = "9873392c91743857cf5b35c9017c6683d5659c9358f35c742be27bfb03dee77c"
            ramdisk = "038-0715-006.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\038-0032-002.dmg") = True Then
            'iPod Touch 4---4.2.1
            iv = "9b20ae16bebf4cf1b9101374c3ab0095"
            key = "06849aead2e9a6ca8a82c3929bad5c2368942e3681a3d5751720d2aacf0694c0"
            ramdisk = "038-0032-002.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\018-7082-092.dmg") = True Then
            'iPod Touch 4---4.1
            iv = "103ae8786d55bebdea996a56706641c9"
            key = "a80b3c27041f09d4554bbf4af59dd5bcea38bd4fe2faf82d8d6f62853ec6b337"
            ramdisk = "018-7082-092.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\018-7921-345.dmg") = True Then
            'iPod Touch 3G---5.0
            iv = "5630ab5a75440c57f80f42a41f2a86a1"
            key = "3ea246f2b53066f329b5f4b10c973c7b62d6736e2b8706cf396caf5e7ba364ca"
            ramdisk = "018-7921-345.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\038-2261-002.dmg") = True Then
            'iPod Touch 3G---4.3.5
            not_encrypted = True
            ramdisk = "038-2261-002.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\018-7940-131.dmg") = True Then
            'iPod Touch 3G---4.3
            iv = "c4ddd3ed329d243488a99aa50f693d2e"
            key = "26082729ed2afb965b396cccc8f16dc44e0372a9b02095ebf523956edca40a4f"
            ramdisk = "018-7940-131.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\038-0031-002.dmg") = True Then
            'iPod Touch 3G---4.2.1
            iv = "9064ae28aef1db52cde6f7568c188766"
            key = "1229ee227f260b8746021d4a46366ec42f987c36d4910a4925e6ca0ce369f69f"
            ramdisk = "038-0031-002.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\018-7081-078.dmg") = True Then
            'iPod Touch 3G---4.1
            iv = "1edc4378f31ce728a2412ff93c78b8dd"
            key = "425f8a7bdac80a9678c78317a0ddbb91abb52a2fd1ff45f46c3e6db392155db9"
            ramdisk = "018-7081-078.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\018-7923-347.dmg") = True Then
            'iPad 1G---5.0
            iv = "277d39cbbf681df205db5808396baa44"
            key = "e70dfb6d3b6cf2e05366afcf328385425500e67b212e59a6d08b52bb35732da6"
            ramdisk = "018-7923-347.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\038-2265-002.dmg") = True Then
            'iPad 1G---4.3.5
            not_encrypted = True
            ramdisk = "038-2265-002.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\038-0715-006.dmg") = True Then
            'iPad 1G---4.3
            iv = "d11772b6a3bdd4f0b4cd8795b9f10ad9"
            key = "9873392c91743857cf5b35c9017c6683d5659c9358f35c742be27bfb03dee77c"
            ramdisk = "038-0715-006.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\038-0032-002.dmg") = True Then
            'iPad 1G---4.2.1
            iv = "9b20ae16bebf4cf1b9101374c3ab0095"
            key = "06849aead2e9a6ca8a82c3929bad5c2368942e3681a3d5751720d2aacf0694c0"
            ramdisk = "038-0032-002.dmg"
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\038-0791-023.dmg") = True Then
            'Apple TV 2G---4.4.3
            do_it = False
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\038-0791-023.dmg") = True Then
            'Apple TV 2G---4.3 (8F191M)
            do_it = False
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\018-8613-062.dmg") = True Then
            'Apple TV 2G---4.1 (8M89)
            do_it = False
        ElseIf My.Computer.FileSystem.FileExists(path & "\building2\018-7103-078.dmg") = True Then
            'iPod Touch 2G---4.1
            iv = "58df0d0655bbdda2a0f1c09333940701"
            key = "fbf443110eb11d8d1aacdbe39167de09"
            ramdisk = "018-7103-078.dmg"
        Else
            MessageBox.Show("Unsupported device, or you tampered with the interior of the firmware, try again.", "Bluefreeze")
            Form1.Close()
        End If
    End Sub
    Public Sub Search_DFU(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'iH8sn0w's DFU detector
        DFUConnected = False
        Do Until DFUConnected = True
            Bootfreeze.console.Text = " "
            Dim searcher As New ManagementObjectSearcher( _
                      "root\CIMV2", _
                      "SELECT * FROM Win32_PnPEntity WHERE Description = 'Apple Recovery (DFU) USB Driver'")
            For Each queryObj As ManagementObject In searcher.Get()

                Bootfreeze.console.Text += (queryObj("Description"))
            Next
            If Bootfreeze.console.Text.Contains("DFU") Then
                DFUConnected = True
            End If
        Loop
    End Sub
    Public Sub irecovery()
        v10letfreeze.Label3.Text = "Entering PWNED DFU..."
        System.IO.File.WriteAllBytes(path & "\s-irecovery.exe", My.Resources.s_irecovery)
        Shell(path & "\s-irecovery.exe" & " -e")
        v10letfreeze.Label3.Text = "Done!"
        v10letfreeze.PictureBox2.Visible = True
    End Sub
End Module