Public Class EyeOPD_Form

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitFrm.Click
        Me.Close()
    End Sub

    Private Sub cmd_Load_Combo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Load_Combo.Click

        Dim myEyeOPD_Data_Connector As EyeOPDDatabase
        myEyeOPD_Data_Connector = New EyeOPDDatabase
        Dim patientsDT As New DataTable()

        patientsDT = myEyeOPD_Data_Connector.ExecuteQuery("SELECT TOP 1000 JKCRegNum ,[FirstName] + ' ' +  [LastName] as FullName FROM [EyeOPD].[dbo].[Patients];")
        If patientsDT.Rows.Count <> 0 Then

            cmb_Patients.DataSource = patientsDT
            cmb_Patients.DisplayMember = "FullName"
            cmb_Patients.ValueMember = "JKCRegNum"

        End If

    End Sub

End Class
