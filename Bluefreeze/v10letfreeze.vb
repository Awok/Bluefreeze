Public Class v10letfreeze
    Dim reset As Boolean = False
    Dim again As Boolean = False
    Private Sub v10letfreeze_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button2.Visible = False
        Label1.Text = ""
        PictureBox2.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False
        Button2.Visible = True
        BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        BackgroundWorker1.RunWorkerAsync()
        Label3.Text = "Hold both the home and power buttons"
        PictureBox1.Image = My.Resources._110
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._19
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._18
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._17
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._16
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._15
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        Label3.Text = "Prepare to release just the power button"
        PictureBox1.Image = My.Resources._14
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._13
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._12
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._11
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        Label3.Text = "Release the power button, but keep holding the home button"
        PictureBox1.Image = My.Resources.release
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._215
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._214
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._213
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._212
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._211
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._210
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._29
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._28
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._27
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._26
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._25
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._24
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._23
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._22
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        PictureBox1.Image = My.Resources._21
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        Label3.Text = "You failed to enter DFU, try again by clicking reset"
        PictureBox1.Image = My.Resources.fail
        Delay(1)
        If DFUConnected = True Then
            Call irecovery()
            PictureBox1.Image = My.Resources.dfu
            Label2.Text = "Found DFU device"
            Exit Sub
        End If
        If reset = True Then
            PictureBox1.Image = My.Resources.normal
            Button1.Visible = True
            reset = False
            Button2.Visible = False
            Exit Sub
        End If
        again = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If again = False Then
            reset = True
            Button2.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MessageBox.Show("Please email us at bluefreeze.feedback@gmail.com for any help you may need", "Bluefreeze")
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Form1.Close()
    End Sub
End Class