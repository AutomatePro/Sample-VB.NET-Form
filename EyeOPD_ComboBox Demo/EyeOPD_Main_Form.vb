Public Class EyeOPD_Form

    Dim JKP_Reg_Num As String = ""

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitFrm.Click
        Me.Close()
    End Sub

    Private Sub cmd_Load_Combo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Read.Click

        Dim myEyeOPD_Data_Connector As EyeOPDDatabase
        myEyeOPD_Data_Connector = New EyeOPDDatabase
        Dim patientsDT As New DataTable()

        patientsDT = myEyeOPD_Data_Connector.ExecuteQuery("SELECT JKCRegNum, [FirstName] as FullName FROM [EyeOPD].[dbo].[Patients];")
        If patientsDT.Rows.Count <> 0 Then

            cmb_Patients.DataSource = patientsDT
            cmb_Patients.DisplayMember = "FullName"
            cmb_Patients.ValueMember = "JKCRegNum"

        End If

    End Sub

    Private Sub btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update.Click

        Dim myEyeOPD_Data_Connector As EyeOPDDatabase
        myEyeOPD_Data_Connector = New EyeOPDDatabase


        Dim query As String = "UPDATE [dbo].[Patients] SET FirstName = @Value WHERE JKCRegNum = @JKCRegNum"
        Dim selectedRow As DataRowView = CType(cmb_Patients.SelectedItem, DataRowView)


        If JKP_Reg_Num > 0 Then
            Dim parameters As New Dictionary(Of String, Object) From {
                {"@Value", cmb_Patients.Text},
                {"@JKCRegNum", JKP_Reg_Num}
            }

            Dim rowsUpdated As Integer = myEyeOPD_Data_Connector.executeActionQuery(query, parameters)

            If rowsUpdated > 0 Then

                Dim resultOk As DialogResult = MessageBox.Show(rowsUpdated.ToString() + " record updated.", "Update Query", MessageBoxButtons.OK)

            Else
                Dim resultNotOkay As DialogResult = MessageBox.Show("No record updated.", "Update Query", MessageBoxButtons.OK)

            End If

        End If


    End Sub

    Private Sub cmb_Patients_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Patients.SelectedIndexChanged
        JKP_Reg_Num = CType(cmb_Patients.SelectedItem, DataRowView)("JKCRegNum").ToString()
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click

        Dim myEyeOPD_Data_Connector As EyeOPDDatabase
        myEyeOPD_Data_Connector = New EyeOPDDatabase


        Dim query As String = "DELETE FROM [dbo].[Patients] WHERE JKCRegNum = @JKCRegNum"
        Dim selectedRow As DataRowView = CType(cmb_Patients.SelectedItem, DataRowView)


        If JKP_Reg_Num > 0 Then
            Dim parameters As New Dictionary(Of String, Object) From {
                {"@JKCRegNum", JKP_Reg_Num}
            }

            Dim rowsUpdated As Integer = myEyeOPD_Data_Connector.executeActionQuery(query, parameters)

            If rowsUpdated > 0 Then

                Dim resultOk As DialogResult = MessageBox.Show(rowsUpdated.ToString() + " record deleted.", "Delete Query", MessageBoxButtons.OK)

            Else
                Dim resultNotOkay As DialogResult = MessageBox.Show("No record deleted.", "Delete Query", MessageBoxButtons.OK)

            End If

        End If

    End Sub

    Private Sub btn_Create_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Create.Click

        Dim myEyeOPD_Data_Connector As EyeOPDDatabase
        myEyeOPD_Data_Connector = New EyeOPDDatabase


        Dim query As String = "INSERT INTO [dbo].[Patients] (FirstName, LastName, JKCRegNum, IsOneEyed ) VALUES (@FirstName, @LastName, @JKCRegNum, @IsOneEyed)"

        JKP_Reg_Num = Me.tb_JKC_Reg_Number.Text

        If JKP_Reg_Num > 0 Then
            Dim parameters As New Dictionary(Of String, Object) From {
                {"@FirstName", cmb_Patients.Text},
                {"@LastName", "HC Last Name"},
                {"@JKCRegNum", JKP_Reg_Num},
                {"@IsOneEyed", 0}
            }

            Dim rowsUpdated As Integer = myEyeOPD_Data_Connector.executeActionQuery(query, parameters)

            If rowsUpdated > 0 Then

                Dim resultOk As DialogResult = MessageBox.Show(rowsUpdated.ToString() + " record created.", "Create Query", MessageBoxButtons.OK)

            Else
                Dim resultNotOkay As DialogResult = MessageBox.Show("No record created.", "Create Query", MessageBoxButtons.OK)

            End If

        End If

    End Sub
End Class
