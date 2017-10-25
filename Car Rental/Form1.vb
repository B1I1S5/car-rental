Public Class FrmCarRental
    Private Sub Btnsignin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        'assign values to our variables
        gstrusername = "username"
        gstrpassword = "password"

        'if statement to check our users credentials

        If txtusername.Text = gstrusername And txtpassword.Text = gstrpassword Then
            frmcustomerdetails.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username or Password are not recognized.Please try it again.", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
