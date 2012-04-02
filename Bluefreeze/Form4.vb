Public Class Form4
    Dim iFaithpath As String = ""
    Public ios As String = ""
    Public md5 As String = ""
    Dim renamefile As Boolean = False
    Dim ios5 As Boolean = True
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Form3.MdiParent = Form1
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        Button1.Enabled = False
        If custom = False Then
            ComboBox2.Visible = True
            Label3.Visible = True
        Else
            PictureBox2.Visible = True
            ProgressBar1.Visible = True
        End If
        Dim answer As DialogResult
        answer = MessageBox.Show("Was the iFaith blob from a device on ios 5.X.X?", "Bluefreeze", _
           MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = 7 Then
            ios5 = False
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        iFaithpath = OpenFileDialog1.FileName
        'for some reason this loop doesn't either... java is so much better for this kind of stuff
        Do While iFaithpath = ""
            OpenFileDialog1.ShowDialog()
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ios = "5.0 (9A433)" Then
            If ComboBox1.Text = "iPod Touch 3G" Then
                md5 = "989b8327acab76e7632443a0e179250c"
            ElseIf ComboBox1.Text = "iPad 1G" Then
                md5 = "729c72a9880B82b37aef5997173d9578"
            ElseIf ComboBox1.Text = "iPod Touch 4" Then
                md5 = "29EAD00D2726F688D393A5FDD0DE4A97"
            ElseIf ComboBox1.Text = "iPhone 4 GSM" Then
                md5 = "8ac7ae6a7f6fadbd34ba9abacd15e2dc"
            ElseIf ComboBox1.Text = "iPhone 4 CDMA" Then
                md5 = "ac3985f710f3a0fe373881c98d322667"
            ElseIf ComboBox1.Text = "iPhone 3GS" Then
                md5 = "54aa71d20263580653eafd06064c557c"
            End If
            'from here is all untested stuff...
        ElseIf ios = "4.3.5 (8L1)" Then
            If ComboBox1.Text = "iPod Touch 3G" Then
                md5 = "c5c45b58618b38fb4d2fba242eb0ba1e"
            ElseIf ComboBox1.Text = "iPad 1G" Then
                md5 = "d80101eb0b1b460e319f9124f252813c"
            ElseIf ComboBox1.Text = "iPod Touch 4" Then
                md5 = "c750f69c14d5fa8295edafd7212aac7d"
            ElseIf ComboBox1.Text = "iPhone 4 GSM" Then
                md5 = "7219c43eea7362c7a402861f71b4496e"
            ElseIf ComboBox1.Text = "iPhone 3GS" Then
                md5 = "a7586eaf9cce93db06c2114f23e8ed90"
            End If
        ElseIf ios = "4.4.3 (9A405l)" Then
            If ComboBox1.Text = "Apple TV 2G" Then
                md5 = "9227a33a560ea4dcaff3dabb33424df2"
            End If
        ElseIf ios = "4.3 (8F190)" Then
            If ComboBox1.Text = "iPod Touch 3G" Then
                md5 = "43383f2d5cd181f2af1e01ec62A3f1d6"
            ElseIf ComboBox1.Text = "iPad 1G" Then
                md5 = "9a889ba48bc2715292f199f50c70ed60"
            ElseIf ComboBox1.Text = "iPod Touch 4" Then
                md5 = "0c8cdbbb729508811fa5bd29d8e1143b"
            ElseIf ComboBox1.Text = "iPhone 4 GSM" Then
                md5 = "e0a463bded8f5b1e076b466535b18c75"
            ElseIf ComboBox1.Text = "iPhone 3GS" Then
                md5 = "87ebb9b2c025fb5f87a4cab0631b1547"
            ElseIf ComboBox1.Text = "Apple TV 2G" Then
                md5 = "85647af7e281cfca4f4e0d1c412f668f"
                ios = "4.3 (8F191M)"
            End If
        ElseIf ios = "4.2.1 (8C148)" Then
            If ComboBox1.Text = "iPod Touch 3G" Then
                md5 = "25dbf5b3e5ca39edd0aab8fcab888503"
            ElseIf ComboBox1.Text = "iPad 1G" Then
                md5 = "9402d5f05348fd68c87f885ff4cb4717"
            ElseIf ComboBox1.Text = "iPod Touch 4" Then
                md5 = "14d1508954532e91172f8704fd941a93"
            ElseIf ComboBox1.Text = "iPhone 4 GSM" Then
                md5 = "93957e7bd21f0549b60a60485c13206a"
            ElseIf ComboBox1.Text = "iPhone 3GS" Then
                md5 = "d688d2d48c8b054367adef8e7ab4f5ea"
                ios = "4.3 (8C148a)"
            End If
        ElseIf ios = "4.1 (8B117)" Then
            If ComboBox1.Text = "iPod Touch 3G" Then
                md5 = "f3877c6f309730ee31297a06c7a9e82c"
            ElseIf ComboBox1.Text = "iPod Touch 4" Then
                md5 = "2e634d16d0e01ef70070c9a289e488ca"
                'skipping 4.1 (8B118)
            ElseIf ComboBox1.Text = "iPhone 4 GSM" Then
                md5 = "ac3031a7b5c013d6a09952b691985878"
            ElseIf ComboBox1.Text = "iPhone 3GS" Then
                md5 = "e07bee3c03e7a18e5d75fcaa23db17b5"
            ElseIf ComboBox1.Text = "Apple TV 2G" Then
                md5 = "35c8ab4b7e70ab0e47e2f5981e52ba55"
                ios = "4.1 (8M89)"
            ElseIf ComboBox1.Text = "iPod Touch 2G" Then
                md5 = "9f8a1978f053ec96926e535bb57ac171"
            End If
        Else
            MessageBox.Show("You have selected either a non-existant device, or an unsupported device, try again", "Bluefreeze")
            Form1.Close()
        End If
        ComboBox1.Enabled = False
        PictureBox2.Visible = True
        ProgressBar1.Visible = True
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Form1.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Label2.Text = "Moving..."
        ProgressBar1.Value = 10
        Delay(2)
        My.Computer.FileSystem.MoveFile(iFaithpath, path & "\workingon.txt")
        Dim FILE_NAME As String = path & "\workingon.txt"
        Dim ff As String = "g"
        Label2.Text = "Printing..."
        ProgressBar1.Value = 25
        Delay(2)
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim iofile As New System.IO.StreamReader(FILE_NAME)
            Dim ioLine As String
            Dim ioLines As String
            Dim counter2 As Integer = 0
            ioLine = iofile.ReadLine
            ioLines = ioLine
            While Not ioLine = ff
                ioLine = iofile.ReadLine
                ioLines = ioLines & vbCrLf & ioLine
                counter2 = counter2 + 1
                RichTextBox1.AppendText(Environment.NewLine & ioLine)
                If counter2 = 5 Then
                    Call editbeginning()
                End If
                ff = ""
            End While
            iofile.Dispose()
        Else
            'Shouldn't happen
            MsgBox("File Does Not Exist", "BlueFreeze")
        End If
        Label2.Text = "Pwning SHSH Blob..."
        ProgressBar1.Value = 65
        Delay(2)
        Dim lines(RichTextBox1.Lines.Length - 2) As String
        If (ios5 = True) Then
            Array.Copy(RichTextBox1.Lines, lines, RichTextBox1.Lines.Length - 4)
            RichTextBox1.Lines = lines
            RichTextBox1.AppendText(Environment.NewLine & "<ipsw_md5>" & md5 & "</ipsw_md5>")
            RichTextBox1.AppendText(Environment.NewLine & "</name>")
            RichTextBox1.AppendText(Environment.NewLine & "</iFaith>")
            RichTextBox1.AppendText(Environment.NewLine & "")
            RichTextBox1.AppendText(Environment.NewLine & "//Pwned with Bluefreeze ---- The Private Dev Team")
        Else
            Array.Copy(RichTextBox1.Lines, lines, RichTextBox1.Lines.Length - 5)
            RichTextBox1.Lines = lines
            RichTextBox1.AppendText(Environment.NewLine & "<ipsw_md5>" & md5 & "</ipsw_md5>")
            RichTextBox1.AppendText(Environment.NewLine & "</name>")
            RichTextBox1.AppendText(Environment.NewLine & "</iFaith>")
            RichTextBox1.AppendText(Environment.NewLine & "")
            RichTextBox1.AppendText(Environment.NewLine & "//Pwned with Bluefreeze ---- The Private Dev Team")
        End If
        Label2.Text = "Rebuilding Blob..."
        ProgressBar1.Value = 80
        Delay(2)
        RichTextBox1.SaveFile(FILE_NAME, RichTextBoxStreamType.PlainText)
        My.Computer.FileSystem.MoveFile(FILE_NAME, iFaithpath)
        Try
            My.Computer.FileSystem.RenameFile(iFaithpath, "Pwned_iFaith_blob_Bluefreeze.ifaith")
        Catch ed As Exception
            Try
                My.Computer.FileSystem.RenameFile(iFaithpath, "Pwned_blob_Bluefreeze.ifaith")
            Catch f As Exception
                'Too many tries... couldn't get the do loop to work, so this should be fine...
            End Try
        End Try
        Label2.Text = "Done"
        ProgressBar1.Value = 100
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Visible = False
        PictureBox2.Visible = False
        ProgressBar1.Visible = False
        Label1.Visible = False
        Label2.Text = ""
        Label3.Visible = False
        ComboBox2.Visible = False
        MessageBox.Show("Remember this only works with iFaith v1.4.2", "Bluefreeze")
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "5.0" Then
            ios = "5.0 (9A433)"
        ElseIf ComboBox2.Text = "4.4.3" Then
            ios = "4.4.3 (9A405l)"
        ElseIf ComboBox2.Text = "4.3.5" Then
            ios = "4.3.5 (8L1)"
        ElseIf ComboBox2.Text = "4.3" Then
            ios = "4.3 (8F190)"
        ElseIf ComboBox2.Text = "4.2.1" Then
            ios = "4.2.1 (8C148)"
        ElseIf ComboBox2.Text = "4.1" Then
            ios = "4.1 (8B117)"
        End If
        ComboBox2.Enabled = False
        ComboBox1.Visible = True
        Label1.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MessageBox.Show("Please email us at bluefreeze.feedback@gmail.com for any help you may need", "Bluefreeze")
    End Sub
End Class