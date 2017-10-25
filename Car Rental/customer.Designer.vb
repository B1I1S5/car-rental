<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcustomerdetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblStreetAddress = New System.Windows.Forms.Label()
        Me.TxtStreetAddress = New System.Windows.Forms.TextBox()
        Me.LblTownCity = New System.Windows.Forms.Label()
        Me.TxtTownCity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTelephoneNumber = New System.Windows.Forms.Label()
        Me.lblLicenseNumber = New System.Windows.Forms.Label()
        Me.BtnBack1 = New System.Windows.Forms.Button()
        Me.BtnNext1 = New System.Windows.Forms.Button()
        Me.cboCounty = New System.Windows.Forms.ComboBox()
        Me.MaskedTelephoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.lblExample1 = New System.Windows.Forms.Label()
        Me.lblExample2 = New System.Windows.Forms.Label()
        Me.lblExample3 = New System.Windows.Forms.Label()
        Me.lblExample4 = New System.Windows.Forms.Label()
        Me.MaskedLicenseNumber = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(366, 85)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(398, 25)
        Me.TxtName.TabIndex = 0
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Sitka Subheading", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Lbl1.Location = New System.Drawing.Point(244, 20)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(358, 40)
        Me.Lbl1.TabIndex = 1
        Me.Lbl1.Text = "Complete Personal Details"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Sitka Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(73, 82)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(160, 26)
        Me.LblName.TabIndex = 2
        Me.LblName.Text = "Customer Name:"
        '
        'LblStreetAddress
        '
        Me.LblStreetAddress.AutoSize = True
        Me.LblStreetAddress.Font = New System.Drawing.Font("Sitka Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStreetAddress.Location = New System.Drawing.Point(73, 152)
        Me.LblStreetAddress.Name = "LblStreetAddress"
        Me.LblStreetAddress.Size = New System.Drawing.Size(239, 26)
        Me.LblStreetAddress.TabIndex = 3
        Me.LblStreetAddress.Text = "Customer Street Address:"
        '
        'TxtStreetAddress
        '
        Me.TxtStreetAddress.Location = New System.Drawing.Point(366, 155)
        Me.TxtStreetAddress.Name = "TxtStreetAddress"
        Me.TxtStreetAddress.Size = New System.Drawing.Size(469, 25)
        Me.TxtStreetAddress.TabIndex = 4
        '
        'LblTownCity
        '
        Me.LblTownCity.AutoSize = True
        Me.LblTownCity.Font = New System.Drawing.Font("Sitka Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTownCity.Location = New System.Drawing.Point(73, 222)
        Me.LblTownCity.Name = "LblTownCity"
        Me.LblTownCity.Size = New System.Drawing.Size(201, 26)
        Me.LblTownCity.TabIndex = 5
        Me.LblTownCity.Text = "Customer Town/City:"
        '
        'TxtTownCity
        '
        Me.TxtTownCity.Location = New System.Drawing.Point(366, 225)
        Me.TxtTownCity.Name = "TxtTownCity"
        Me.TxtTownCity.Size = New System.Drawing.Size(398, 25)
        Me.TxtTownCity.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Customer County:"
        '
        'lblTelephoneNumber
        '
        Me.lblTelephoneNumber.AutoSize = True
        Me.lblTelephoneNumber.Font = New System.Drawing.Font("Sitka Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelephoneNumber.Location = New System.Drawing.Point(73, 355)
        Me.lblTelephoneNumber.Name = "lblTelephoneNumber"
        Me.lblTelephoneNumber.Size = New System.Drawing.Size(260, 26)
        Me.lblTelephoneNumber.TabIndex = 9
        Me.lblTelephoneNumber.Text = "Contact Telephone Number:"
        '
        'lblLicenseNumber
        '
        Me.lblLicenseNumber.AutoSize = True
        Me.lblLicenseNumber.Font = New System.Drawing.Font("Sitka Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLicenseNumber.Location = New System.Drawing.Point(73, 425)
        Me.lblLicenseNumber.Name = "lblLicenseNumber"
        Me.lblLicenseNumber.Size = New System.Drawing.Size(234, 26)
        Me.lblLicenseNumber.TabIndex = 13
        Me.lblLicenseNumber.Text = "Driving License Number:"
        '
        'BtnBack1
        '
        Me.BtnBack1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnBack1.Font = New System.Drawing.Font("HGSSoeiKakupoptai", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnBack1.Location = New System.Drawing.Point(48, 504)
        Me.BtnBack1.Name = "BtnBack1"
        Me.BtnBack1.Size = New System.Drawing.Size(117, 49)
        Me.BtnBack1.TabIndex = 15
        Me.BtnBack1.Text = "Back"
        Me.BtnBack1.UseVisualStyleBackColor = False
        '
        'BtnNext1
        '
        Me.BtnNext1.BackColor = System.Drawing.Color.LightCoral
        Me.BtnNext1.Font = New System.Drawing.Font("HGSSoeiKakupoptai", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext1.Location = New System.Drawing.Point(718, 504)
        Me.BtnNext1.Name = "BtnNext1"
        Me.BtnNext1.Size = New System.Drawing.Size(117, 49)
        Me.BtnNext1.TabIndex = 16
        Me.BtnNext1.Text = "Next"
        Me.BtnNext1.UseVisualStyleBackColor = False
        '
        'cboCounty
        '
        Me.cboCounty.FormattingEnabled = True
        Me.cboCounty.Items.AddRange(New Object() {"Antrim", "Armagh", "Carlow", "Cavan", "Clare", "Cork", "Donegal", "Down", "Fermanagh", "Galway", "Kerry", "Kildare", "Kilkenny", "Laois", "Leitrim", "Limerick", "Londonderry", "Longford", "Louth", "Mayo", "Meath", "Monaghan", "Offaly", "Roscommon", "Sligo", "Tipperary", "Tyrone", "Waterford", "Westmeath", "Wexford", "Wicklow", "Dún Laoghaire–Rathdown", "Fingal", "South Dublin"})
        Me.cboCounty.Location = New System.Drawing.Point(366, 291)
        Me.cboCounty.Name = "cboCounty"
        Me.cboCounty.Size = New System.Drawing.Size(398, 26)
        Me.cboCounty.TabIndex = 17
        '
        'MaskedTelephoneNumber
        '
        Me.MaskedTelephoneNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTelephoneNumber.Location = New System.Drawing.Point(366, 355)
        Me.MaskedTelephoneNumber.Mask = "   (+353)00 000 0000"
        Me.MaskedTelephoneNumber.Name = "MaskedTelephoneNumber"
        Me.MaskedTelephoneNumber.Size = New System.Drawing.Size(398, 29)
        Me.MaskedTelephoneNumber.TabIndex = 18
        '
        'lblExample1
        '
        Me.lblExample1.AutoSize = True
        Me.lblExample1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblExample1.ForeColor = System.Drawing.Color.Firebrick
        Me.lblExample1.Location = New System.Drawing.Point(366, 117)
        Me.lblExample1.Name = "lblExample1"
        Me.lblExample1.Size = New System.Drawing.Size(383, 18)
        Me.lblExample1.TabIndex = 19
        Me.lblExample1.Text = "* Only accept names of up to 30 characters."
        '
        'lblExample2
        '
        Me.lblExample2.AutoSize = True
        Me.lblExample2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblExample2.ForeColor = System.Drawing.Color.Firebrick
        Me.lblExample2.Location = New System.Drawing.Point(366, 187)
        Me.lblExample2.Name = "lblExample2"
        Me.lblExample2.Size = New System.Drawing.Size(414, 18)
        Me.lblExample2.TabIndex = 20
        Me.lblExample2.Text = "* Only accept addresses of up to 50 characters."
        '
        'lblExample3
        '
        Me.lblExample3.AutoSize = True
        Me.lblExample3.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblExample3.ForeColor = System.Drawing.Color.Firebrick
        Me.lblExample3.Location = New System.Drawing.Point(366, 257)
        Me.lblExample3.Name = "lblExample3"
        Me.lblExample3.Size = New System.Drawing.Size(369, 18)
        Me.lblExample3.TabIndex = 21
        Me.lblExample3.Text = "* Only accept words of up to 20 charcters."
        '
        'lblExample4
        '
        Me.lblExample4.AutoSize = True
        Me.lblExample4.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblExample4.ForeColor = System.Drawing.Color.Firebrick
        Me.lblExample4.Location = New System.Drawing.Point(366, 460)
        Me.lblExample4.Name = "lblExample4"
        Me.lblExample4.Size = New System.Drawing.Size(440, 18)
        Me.lblExample4.TabIndex = 22
        Me.lblExample4.Text = "* Please enter correct format such as ""A1234567""."
        '
        'MaskedLicenseNumber
        '
        Me.MaskedLicenseNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedLicenseNumber.Location = New System.Drawing.Point(366, 428)
        Me.MaskedLicenseNumber.Mask = "A 0 0 0 0 0 0 0"
        Me.MaskedLicenseNumber.Name = "MaskedLicenseNumber"
        Me.MaskedLicenseNumber.Size = New System.Drawing.Size(398, 29)
        Me.MaskedLicenseNumber.TabIndex = 23
        '
        'frmcustomerdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(927, 572)
        Me.Controls.Add(Me.MaskedLicenseNumber)
        Me.Controls.Add(Me.lblExample4)
        Me.Controls.Add(Me.lblExample3)
        Me.Controls.Add(Me.lblExample2)
        Me.Controls.Add(Me.lblExample1)
        Me.Controls.Add(Me.MaskedTelephoneNumber)
        Me.Controls.Add(Me.cboCounty)
        Me.Controls.Add(Me.BtnNext1)
        Me.Controls.Add(Me.BtnBack1)
        Me.Controls.Add(Me.lblLicenseNumber)
        Me.Controls.Add(Me.lblTelephoneNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTownCity)
        Me.Controls.Add(Me.LblTownCity)
        Me.Controls.Add(Me.TxtStreetAddress)
        Me.Controls.Add(Me.LblStreetAddress)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.TxtName)
        Me.Name = "frmcustomerdetails"
        Me.Text = "customer Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtName As TextBox
    Friend WithEvents Lbl1 As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblStreetAddress As Label
    Friend WithEvents TxtStreetAddress As TextBox
    Friend WithEvents LblTownCity As Label
    Friend WithEvents TxtTownCity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTelephoneNumber As Label
    Friend WithEvents lblLicenseNumber As Label
    Friend WithEvents BtnBack1 As Button
    Friend WithEvents BtnNext1 As Button
    Friend WithEvents cboCounty As ComboBox
    Friend WithEvents MaskedTelephoneNumber As MaskedTextBox
    Friend WithEvents lblExample1 As Label
    Friend WithEvents lblExample2 As Label
    Friend WithEvents lblExample3 As Label
    Friend WithEvents lblExample4 As Label
    Friend WithEvents MaskedLicenseNumber As MaskedTextBox
End Class
