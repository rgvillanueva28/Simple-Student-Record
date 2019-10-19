Public Class frmMain
    Sub read()
        If conn.State = ConnectionState.Open Then conn.Close()
        Dim dt As New DataTable
        adapter.Fill(dt)


        txtStudno.Text = dt.Rows(0).Item("Student Number")
        txtfname.Text = dt.Rows(0).Item("First Name")
        txtsurname.Text = dt.Rows(0).Item("Surname")
        txtgender.Text = dt.Rows(0).Item("Gender")
        txtq1.Text = dt.Rows(0).Item("Quiz 1")
        txtq2.Text = dt.Rows(0).Item("Quiz 2")
        txtq3.Text = dt.Rows(0).Item("Quiz 3")
        txtq4.Text = dt.Rows(0).Item("Quiz 4")
        dgv.ClearSelection()
    End Sub

    Sub dis()
        cmdUpdate.Enabled = True
        cmdCancel.Enabled = True
        cmdAdd.Enabled = False
        cmdDelete.Enabled = False
        cmdEdit.Enabled = False
        txtsearch.Enabled = False
        cmdsearch.Enabled = False
        txtStudno.Enabled = False
        filter.Enabled = False
        dgv.ClearSelection()

    End Sub

    Sub ena()
        cmdUpdate.Enabled = False
        cmdCancel.Enabled = False
        cmdAdd.Enabled = True
        cmdEdit.Enabled = True
        txtsearch.Enabled = True
        cmdsearch.Enabled = True
        txtStudno.Enabled = True
        filter.Enabled = True
        cmdDelete.Enabled = True

        cmdAdd.Enabled = True
        dgv.ClearSelection()

    End Sub
    Sub clear()
        txtStudno.Text = ""
        txtfname.Text = ""
        txtsurname.Text = ""
        txtgender.Text = ""
        txtq1.Text = ""
        txtq2.Text = ""
        txtq3.Text = ""
        txtq4.Text = ""
        txtgender.SelectedIndex = -1
        dgv.ClearSelection()

    End Sub
    Sub populate()

        sSQL = "select StudNo as [Student Number],fname as [First Name], surname as [Surname], gender as [Gender], q1 as [Quiz 1], q2 as [Quiz 2], q3 as [Quiz 3], q4 as [Quiz 4] from tblstudents order by StudNo"
        execSQL(sSQL, False)
        filldg(sSQL, dgv)
        adapter.Fill(dt)

        dgv.ClearSelection()

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ena()
        populate()
        dgv.ClearSelection()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click

        Add()

    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If dgv.Rows.Count > 0 Then
            If dgv.SelectedRows.Count > 0 Then
                dis()
                sSQL = "SELECT StudNo as [Student Number],fname as [First Name], surname as [Surname], gender as [Gender], q1 as [Quiz 1], q2 as [Quiz 2], q3 as [Quiz 3], q4 as [Quiz 4] from tblstudents where StudNo=" & dgv.CurrentRow.Cells("Student Number").Value & ""
                execSQL(sSQL, False)
                read()
            Else
                    MessageBox.Show("No record selected!")

            End If
        Else
            MessageBox.Show("No records!")
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        ena()
        clear()
        populate()
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        edit()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        delete()
    End Sub


    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        search()
    End Sub


    Private Sub cmdquiz_Click(sender As Object, e As EventArgs) Handles cmdquiz.Click
        ave()
    End Sub

    Private Sub filter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filter.SelectedIndexChanged
        txtsearch.Text = ""
    End Sub
End Class
