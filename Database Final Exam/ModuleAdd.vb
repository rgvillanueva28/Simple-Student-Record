Module ModuleAdd

    Public Sub Add()

        If Len(Trim(frmMain.txtStudno.Text)) = 0 Then
            MessageBox.Show("Please don't leave any blanks")
        ElseIf frmMain.txtStudno.Text > 9999999999 Or frmMain.txtStudno.Text < 1000000000 Then
            MessageBox.Show("Enter 10 digits student number")
        ElseIf frmMain.txtfname.Text = "" Or frmMain.txtsurname.Text = "" Or frmMain.txtgender.Text = "" Then
            MessageBox.Show("Please don't leave any blanks")
        ElseIf frmMain.txtq1.Text > 100 Or frmMain.txtq1.Text < 0 Or frmMain.txtq2.Text > 100 Or frmMain.txtq2.Text < 0 Or frmMain.txtq3.Text > 100 Or frmMain.txtq3.Text < 0 Or frmMain.txtq4.Text > 100 Or frmMain.txtq4.Text < 0 Then
            MessageBox.Show("0-100 range on quizzes")
        Else
            sSQL = "select StudNo as [Student Number],fname as [First Name], surname as [Surname], gender as [Gender], q1 as [Quiz 1], q2 as [Quiz 2], q3 as [Quiz 3], q4 as [Quiz 4] from tblstudents where Studno=" & frmMain.txtStudno.Text & ""
            execSQL(sSQL, False)

            If RD.Read Then
                MsgBox("Student with student number of " + frmMain.txtStudno.Text + " already exists!", MsgBoxStyle.Critical, "Duplicated")
            Else



                sSQL = "INSERT INTO tblStudents(`StudNo`, `fname`, `surname`, `gender`, `q1`, `q2`, `q3`, `q4`) values ('" & frmMain.txtStudno.Text & "', '" & frmMain.txtfname.Text & "', '" & frmMain.txtsurname.Text & "', '" & frmMain.txtgender.Text & "', '" & frmMain.txtq1.Text & "', '" & frmMain.txtq2.Text & "', '" & frmMain.txtq3.Text & "', '" & frmMain.txtq4.Text & "') "
                execSQL(sSQL, True)

                MessageBox.Show("Record Added")

                frmMain.clear()
                frmMain.populate()



            End If
        End If
    End Sub

End Module
