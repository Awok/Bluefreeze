Public Class Form8
    Public b1 As Boolean = False
    Public b2 As Boolean = False
    Public b3 As Boolean = False
    Public b4 As Boolean = False
    Public b5 As Boolean = False
    Public b6 As Boolean = False

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        'Yes I know textbox 1 isn't needed :)
        If TextBox1.Text = "" Then
            b1 = False
        Else
            b1 = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then
            b2 = False
        Else
            b2 = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "" Then
            b3 = False
        Else
            b3 = True
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then
            b4 = False
        Else
            b4 = True
        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = "" Then
            b5 = False
        Else
            b5 = True
        End If
    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Visible = False
        Timer1.Start()
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        If TextBox6.Text = "" Then
            b6 = False
        Else
            b6 = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'I'm pretty sure this can be written as one statement... but I couldn't get it to work...
        If b1 = True Then
            If b2 = True Then
                If b3 = True Then
                    If b4 = True Then
                        If b5 = True Then
                            If b6 = True Then
                                Button1.Visible = True
                            Else
                                Button1.Visible = False
                            End If
                        Else
                            Button1.Visible = False
                        End If
                    Else
                        Button1.Visible = False
                    End If
                Else
                    Button1.Visible = False
                End If
            Else
                Button1.Visible = False
            End If
        Else
            Button1.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox2.Text = Form4.ios
        TextBox3.Text = ramdisk
        If TextBox4.Text = "none" Then
            not_encrypted = True
        Else
            TextBox4.Text = iv
            TextBox5.Text = key
        End If
        TextBox6.Text = Form4.md5
        custom = True
        Me.Close()
    End Sub
End Class