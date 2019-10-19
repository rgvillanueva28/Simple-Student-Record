Module ModuleDelete

    Public Sub delete()
        If frmMain.dgv.Rows.Count > 0 Then
            If frmMain.dgv.SelectedRows.Count > 0 Then
                If MsgBox("Are you Sure?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation") = MsgBoxResult.Yes Then
                    sSQL = "DELETE from tblStudents where Studno=" & frmMain.dgv.SelectedRows(0).Cells("Student Number").Value & ""
                    MessageBox.Show("Record Deleted!")
                    execSQL(sSQL, True)

                    frmMain.clear()
                    frmMain.populate()
                End If
            Else
                MessageBox.Show("No record selected!")

            End If
        Else
            MessageBox.Show("No records!")
        End If

    End Sub


End Module
