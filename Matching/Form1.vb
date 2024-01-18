Public Class Form1

    Dim cleck As Integer = 1
    Dim pos1 As Integer, pos2 As Integer
    Dim tama As Integer = 0
    Dim pos As Integer
    Dim T = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Reset_Arrays()
    End Sub

    Private Sub Reset_Arrays()

        For I = 0 To 7
            Loob(I).Image = PictureBox5.Image
            Labas(I).Image = PictureBox5.Image
        Next I
        pos = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        T = 0
        Timer1.Enabled = True
        PictureBox6.Enabled = True
        PictureBox7.Enabled = True
        PictureBox8.Enabled = True
        PictureBox9.Enabled = True
        PictureBox10.Enabled = True
        PictureBox11.Enabled = True
        PictureBox12.Enabled = True
        PictureBox13.Enabled = True

        Button1.Enabled = False

        Dim Ok_Na As Integer = 0
        Randomize()
        While Ok_Na < 8
            pos = Rnd() * 7
            If Loob(pos).Image Is PictureBox5.Image Then
                Ok_Na = Ok_Na + 1
                Select Case Ok_Na
                    Case 1, 2
                        Loob(pos).Image = PictureBox1.Image
                    Case 3, 4
                        Loob(pos).Image = PictureBox2.Image
                    Case 5, 6
                        Loob(pos).Image = PictureBox3.Image
                    Case 7, 8
                        Loob(pos).Image = PictureBox4.Image
                End Select
            End If
        End While

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ans = MsgBox("Are You Sure?", vbYesNo, "Quit")
        If ans = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub chick()
        Select Case cleck
            Case 1

                pos1 = pos
                cleck = 2
            Case 2
                pos2 = pos
                cleck = 3
            Case 3

                If Loob(pos1).Image IsNot (Loob(pos2).Image) Then
                    Labas(pos1).Image = PictureBox5.Image
                    Labas(pos2).Image = PictureBox5.Image

                Else
                    Labas(pos1).Enabled = False
                    Labas(pos2).Enabled = False

                    tama = tama + 1
                    If tama = 4 And cleck = 3 Then tama = 5

                End If

                pos1 = pos
                cleck = 2

        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label7.Text = tama
        Label6.Text = cleck
        Label4.Text = pos1
        Label2.Text = pos2
        T = T + 1

        Label10.Text = "Timer :" + Str(T)
        If tama = 3 And cleck = 3 Then
            Timer1.Enabled = False
            PictureBox23.Visible = True
            PictureBox24.Visible = True
            Label13.Visible = True
            Button3.Visible = True
            Label12.Visible = True


        End If
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        PictureBox6.Image = PictureBox14.Image
        pos = 0
        Call chick()

    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        PictureBox7.Image = PictureBox15.Image
        pos = 1
        Call chick()

    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        PictureBox8.Image = PictureBox16.Image
        pos = 2
        Call chick()

    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        PictureBox9.Image = PictureBox17.Image
        pos = 3

        Call chick()

    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        PictureBox10.Image = PictureBox18.Image
        pos = 4

        Call chick()

    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        PictureBox11.Image = PictureBox19.Image
        pos = 5

        Call chick()

    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        PictureBox12.Image = PictureBox20.Image
        pos = 6

        Call chick()

    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        PictureBox13.Image = PictureBox21.Image
        pos = 7

        Call chick()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Reset_Arrays()
        PictureBox6.Enabled = False
        PictureBox7.Enabled = False
        PictureBox8.Enabled = False
        PictureBox9.Enabled = False
        PictureBox10.Enabled = False
        PictureBox11.Enabled = False
        PictureBox12.Enabled = False
        PictureBox13.Enabled = False
        tama = 0

        
        
        Label10.Text = "Timer :"
        Button1.Enabled = True
        Button3.Visible = False
        PictureBox23.Visible = False
        PictureBox24.Visible = False
        Label13.Visible = False
        Label12.Visible = False
    End Sub
End Class
