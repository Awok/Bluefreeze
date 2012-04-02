Imports System.Management

Public Class Bootfreeze
    Dim counter As Integer = 0
    Dim reset As Boolean = False
    Dim again As Boolean = False
    Public ipsw As String = ""

    Private Sub Bootfreeze_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button2.Visible = False
        MessageBox.Show("You will now be prompted to locate an ipsw. Choose the one that matches your firmware version.", "Bluefreeze")
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CheckBox1.Enabled = False
        BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        BackgroundWorker1.RunWorkerAsync()
        Button1.Visible = False
        Button2.Visible = True
        Label3.Text = "Hold both the home and power buttons"
        PictureBox1.Image = My.Resources._110
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._19
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._18
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._17
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._16
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._15
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        Label3.Text = "Prepare to release just the power button"
        PictureBox1.Image = My.Resources._14
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._13
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._12
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._11
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        Label3.Text = "Release the power button, but keep holding the home button"
        PictureBox1.Image = My.Resources.release
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._215
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._214
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._213
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._212
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._211
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._210
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._29
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._28
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._27
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._26
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._25
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._24
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._23
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._22
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._21
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        Label3.Text = "You failed to enter DFU, try again by clicking reset"
        PictureBox1.Image = My.Resources.fail
        Delay(1)
        If DFUConnected = True Then
            Call redsn0w()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            CheckBox1.Enabled = True
            Exit Sub
        End If
        again = True
        CheckBox1.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If again = False Then
            reset = True
        ElseIf again = True Then
            Button1.Visible = True
            Button2.Visible = False
            Label3.Text = "Get Ready to Enter DFU mode"
            CheckBox1.Enabled = False
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        ipsw = OpenFileDialog1.FileName
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MessageBox.Show("Please email us at bluefreeze.feedback@gmail.com for any help you may need", "Bluefreeze")
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        'Changes redsn0w's compatibility mode to windows xp (service pack 2)
        'Shell("REG.EXE ADD " & Quote.Text & "HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers" & Quote.Text & "  /v " & Quote.Text & path & "\redsn0w.exe" & Quote.Text & " /t REG_SZ /d " & Quote.Text & "WINXPSP2" & Quote.Text & " /f")
        Dim process As New Process()
        Dim FileName As String = "REG.EXE"
        Dim Arguments As String = "ADD " & Quote.Text & "HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers" & Quote.Text & "  /v " & Quote.Text & path & "\redsn0w.exe" & Quote.Text & " /t REG_SZ /d " & Quote.Text & "WINXPSP2" & Quote.Text & " /f"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.RedirectStandardError = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        MessageBox.Show(output)
        CheckBox1.Enabled = False
    End Sub
End Class
