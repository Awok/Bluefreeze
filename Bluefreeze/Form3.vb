Public Class Form3

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        Label1.Text = "A booting utility, helps you boot out of DFU/recovery mode"
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        Label1.Text = ""
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = ""
        Label2.Text = ""
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox8.Visible = False
        PictureBox10.Visible = False
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        Label1.Text = "Modifies your iFaith shsh blob in order to downgrade"
        Label2.Text = "Results in a DFU loop, and a sleep bug that can only be fixed using a cydia tweak known as Prevent Sleep. Very quick"
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        Label1.Text = ""
        Label2.Text = ""
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Form2.MdiParent = Form1
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If PictureBox6.Visible = True Then
            Form5.MdiParent = Form1
            Form5.Show()
            Me.Close()
        ElseIf PictureBox5.Visible = True Then
            Form4.MdiParent = Form1
            Form4.Show()
            Me.Close()
        ElseIf PictureBox8.Visible = True Then
            Form6.MdiParent = Form1
            Form6.Show()
            Me.Close()
        ElseIf PictureBox10.Visible = True Then
            v10letfreeze.MdiParent = Form1
            v10letfreeze.Show()
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        PictureBox4.Visible = True
        PictureBox5.Visible = False
        PictureBox6.Visible = True
        PictureBox8.Visible = False
        PictureBox10.Visible = False
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        PictureBox6.Visible = False
        PictureBox8.Visible = False
        PictureBox10.Visible = False
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox8.Visible = False
        PictureBox10.Visible = False
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox8.Visible = False
        PictureBox10.Visible = False
    End Sub

    Private Sub PictureBox7_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseEnter
        Label1.Text = "Modifies your iFaith shsh blob + firmware for a downgrade"
        Label2.Text = "Results in a recovery loop, sleep bug in blueJay fixed. Not quick, will take some time"
    End Sub

    Private Sub PictureBox7_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseLeave
        Label1.Text = ""
        Label2.Text = ""
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        PictureBox4.Visible = True
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox8.Visible = True
        PictureBox10.Visible = False
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox8.Visible = False
        PictureBox10.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Please email us at bluefreeze.feedback@gmail.com for any help you may need", "Bluefreeze")
    End Sub

    Private Sub PictureBox9_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseEnter
        Label1.Text = "Put's your device into pwned DFU mode"
        Label2.Text = "Helps you avoid errors in iTunes when restoring to custom firmware"
    End Sub

    Private Sub PictureBox9_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseLeave
        Label1.Text = ""
        Label2.Text = ""
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        PictureBox4.Visible = True
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox8.Visible = False
        PictureBox10.Visible = True
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox8.Visible = False
        PictureBox10.Visible = False
    End Sub
End Class