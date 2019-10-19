Module ModuleAve
    Public average As Single
    Public sum As Single

    Public Sub ave()

        If frmMain.dgv.Rows.Count > 0 Then
            If frmMain.dgv.SelectedRows.Count > 0 Then
                sum = frmMain.dgv.CurrentRow.Cells("Quiz 1").Value + frmMain.dgv.CurrentRow.Cells("Quiz 2").Value + frmMain.dgv.CurrentRow.Cells("Quiz 3").Value + frmMain.dgv.CurrentRow.Cells("Quiz 4").Value
                'frmMain.txtq1 + frmMain.txtq2 + frmMain.txtq3 + frmMain.txtq3
                average = sum / 4

                MsgBox("The average of Student Number " + frmMain.dgv.CurrentRow.Cells("Student Number").Value.ToString + " is " + average.ToString + "%", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Quiz Average")


                frmMain.clear()
                frmMain.populate()
                frmMain.dgv.ClearSelection()
            Else
                MessageBox.Show("No record selected!")

            End If
        Else
            MessageBox.Show("No records!")
        End If




    End Sub


End Module
