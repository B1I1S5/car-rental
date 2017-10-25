Public Class frmcustomerdetails
    'declare our variabes
    Dim strname As String
    Dim straddress As String
    Dim strtown As String
    Dim strcounty As String
    Dim strtelephonenumber As String
    Dim strlicensenumber As String

    Private Sub BtnNext1_Click(sender As Object, e As EventArgs) Handles BtnNext1.Click
        'assign values to our variables
        strname = TxtName.Text
        straddress = TxtStreetAddress.Text
        strtown = TxtTownCity.Text
        strcounty = cboCounty.Text
        strtelephonenumber = MaskedTelephoneNumber.Text
        strlicensenumber = MaskedLicenseNumber.Text

        'if the wrong format was inputed, message box will appear
        If strname.Length >= 30 Then
            MessageBox.Show("You must enter less than 30 characters.", "Wrong Name",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If straddress.Length >= 50 Then
            MessageBox.Show("You must enter less than 50 characters.", "Wrong Address",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If strtown.Length >= 20 Then
            MessageBox.Show("You must enter less than 20 characters.", "Wrong Town/City",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If strcounty = " " Then
            MessageBox.Show("You must select one of them.", "Wrong County",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class