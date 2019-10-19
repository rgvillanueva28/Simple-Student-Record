Module ModuleSearch

    Public Sub search()
        If frmMain.filter.Text = "Student Number" Then
            sSQL = "select StudNo as [Student Number],fname as [First Name], surname as [Surname], gender as [Gender], q1 as [Quiz 1], q2 as [Quiz 2], q3 as [Quiz 3], q4 as [Quiz 4] from tblstudents where StudNo like '" & frmMain.txtsearch.Text & "%'"
            execSQL(sSQL, False)
            filldg(sSQL, frmMain.dgv)
            adapter.Fill(dt)
            frmMain.dgv.ClearSelection()
        ElseIf frmMain.filter.Text = "First Name" Then
            sSQL = "select StudNo as [Student Number],fname as [First Name], surname as [Surname], gender as [Gender], q1 as [Quiz 1], q2 as [Quiz 2], q3 as [Quiz 3], q4 as [Quiz 4] from tblstudents where fname like '" & frmMain.txtsearch.Text & "%'"
            execSQL(sSQL, False)
            filldg(sSQL, frmMain.dgv)
            adapter.Fill(dt)
            frmMain.dgv.ClearSelection()
        ElseIf frmMain.filter.Text = "Surname" Then
            sSQL = "select StudNo as [Student Number],fname as [First Name], surname as [Surname], gender as [Gender], q1 as [Quiz 1], q2 as [Quiz 2], q3 as [Quiz 3], q4 as [Quiz 4] from tblstudents where surname like '" & frmMain.txtsearch.Text & "%'"
            execSQL(sSQL, False)
            filldg(sSQL, frmMain.dgv)
            adapter.Fill(dt)
            frmMain.dgv.ClearSelection()
        Else
            sSQL = "select StudNo as [Student Number],fname as [First Name], surname as [Surname], gender as [Gender], q1 as [Quiz 1], q2 as [Quiz 2], q3 as [Quiz 3], q4 as [Quiz 4] from tblstudents where surname like '" & frmMain.txtsearch.Text & "%' or fname like '" & frmMain.txtsearch.Text & "%' or StudNo like '" & frmMain.txtsearch.Text & "%'"
            execSQL(sSQL, False)
            filldg(sSQL, frmMain.dgv)
            adapter.Fill(dt)
            frmMain.dgv.ClearSelection()
        End If


    End Sub

End Module
