Module ModuleUpdate

    Public Sub edit()
        If frmMain.txtfname.Text = "" Or frmMain.txtsurname.Text = "" Or frmMain.txtgender.Text = "" Then
            MessageBox.Show("Please don't leave any blanks")
        ElseIf frmMain.txtq1.Text > 100 Or frmMain.txtq1.Text < 0 Or frmMain.txtq2.Text > 100 Or frmMain.txtq2.Text < 0 Or frmMain.txtq3.Text > 100 Or frmMain.txtq3.Text < 0 Or frmMain.txtq4.Text > 100 Or frmMain.txtq4.Text < 0 Then
            MessageBox.Show("0-100 range on quizzes")
        Else
            sSQL = "UPDATE tblStudents SET fname='" & frmMain.txtfname.Text & "', surname='" & frmMain.txtsurname.Text & "', gender='" & frmMain.txtgender.Text & "', q1='" & frmMain.txtq1.Text & "', q2='" & frmMain.txtq2.Text & "', q3='" & frmMain.txtq3.Text & "', q4='" & frmMain.txtq4.Text & "' where Studno=" & frmMain.txtStudno.Text & ""
            execSQL(sSQL, True)

            MessageBox.Show("Record Updated")

            frmMain.clear()
            frmMain.ena()
            frmMain.populate()

        End If
    End Sub

End Module
