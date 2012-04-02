Public Class Form6

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MessageBox.Show("If you are downgrading to ios 5.0, you must select a properly signed ios 5.0.1 ipsw (made in iFaith), if you are downgrading to ios 4.X.X then you need to select a firmware that is higher (so if your downgrading to ios 4.3 then you must select anything above that so 4.3.1 and above). HOWEVER if you are downgrading to ios 4.X.X you cannot select an ios 5 ipsw here. Reguardless of what firmware you are downgrading to, you must browse for an iFaith ipsw that is properly signed (cannot select a Bluefreeze pwned ipsw from iFaith, must be a legitimate ipsw from iFaith).", "Bluefreeze")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MessageBox.Show("Please email us at bluefreeze.feedback@gmail.com for any help you may need", "Bluefreeze")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MessageBox.Show("This will be the Bluefreeze Pwned ipsw (made in iFaith, the one you plan to restore to to get your downgrade)", "Bluefreeze")
    End Sub

    Private Sub OpenFileDialog2_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk
        ipsw2 = OpenFileDialog2.FileName
        Button4.Enabled = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        MessageBox.Show("If you don't know what this is you need to immediately throw your iDevice out the window and forget about it because it is way to advanced for you", "Bluefreeze")
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        ipsw1 = OpenFileDialog1.FileName
        Button1.Enabled = False
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        ipswsave = SaveFileDialog1.FileName
        Button6.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        OpenFileDialog2.ShowDialog()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Form3.MdiParent = Form1
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        PictureBox2.Visible = False
        MessageBox.Show("Warning: If you want Bluefreeze to work properly then I will ask that you do not mess with the interior of the ipsw files.", "Bluefreeze")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Button1.Enabled = False And Button4.Enabled = False And Button6.Enabled = False Then
            PictureBox2.Visible = True
            Timer1.Stop()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Form7.MdiParent = Form1
        Form7.Show()
        Me.Close()
    End Sub
End Class