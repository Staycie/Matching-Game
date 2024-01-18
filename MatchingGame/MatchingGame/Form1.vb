Public Class Form1
    Dim A(8) As Integer
    Dim K As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Button1.Enabled = False

        Dim pos As Integer
        Dim ele As Integer = 1
        Randomize()

        For I = 0 To 7 'set element to 0
            A(I) = 0
        Next

        For K = 1 To 4
            For ulit = 1 To 2

                While A(pos) <> 0
                    pos = Int(Rnd() * 8)
                End While

                A(pos) = K

            Next ulit

        Next K
        For O = 0 To 7
            L(O).Text = A(O)
        Next O

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Label1.Text = K
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Label2.Text = K
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Label3.Text = K
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Label4.Text = K
    End Sub
End Class
