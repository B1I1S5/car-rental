<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTypesofVehicles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTypesofVehicles))
        Me.lblVehicleType = New System.Windows.Forms.Label()
        Me.rdbCar = New System.Windows.Forms.RadioButton()
        Me.rdbVan = New System.Windows.Forms.RadioButton()
        Me.btnBack2 = New System.Windows.Forms.Button()
        Me.BtnNext2 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVehicleType
        '
        Me.lblVehicleType.AutoSize = True
        Me.lblVehicleType.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehicleType.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lblVehicleType.Location = New System.Drawing.Point(26, 26)
        Me.lblVehicleType.Name = "lblVehicleType"
        Me.lblVehicleType.Size = New System.Drawing.Size(382, 44)
        Me.lblVehicleType.TabIndex = 0
        Me.lblVehicleType.Text = "Choices of Vehicle Type :"
        '
        'rdbCar
        '
        Me.rdbCar.AutoSize = True
        Me.rdbCar.Font = New System.Drawing.Font("Impact", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCar.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.rdbCar.Location = New System.Drawing.Point(526, 189)
        Me.rdbCar.Name = "rdbCar"
        Me.rdbCar.Size = New System.Drawing.Size(93, 43)
        Me.rdbCar.TabIndex = 1
        Me.rdbCar.TabStop = True
        Me.rdbCar.Text = " Car"
        Me.rdbCar.UseVisualStyleBackColor = True
        '
        'rdbVan
        '
        Me.rdbVan.AutoSize = True
        Me.rdbVan.Font = New System.Drawing.Font("Impact", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbVan.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.rdbVan.Location = New System.Drawing.Point(769, 189)
        Me.rdbVan.Name = "rdbVan"
        Me.rdbVan.Size = New System.Drawing.Size(97, 43)
        Me.rdbVan.TabIndex = 2
        Me.rdbVan.TabStop = True
        Me.rdbVan.Text = " Van"
        Me.rdbVan.UseVisualStyleBackColor = True
        '
        'btnBack2
        '
        Me.btnBack2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnBack2.Font = New System.Drawing.Font("HGSSoeiKakupoptai", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnBack2.Location = New System.Drawing.Point(34, 595)
        Me.btnBack2.Name = "btnBack2"
        Me.btnBack2.Size = New System.Drawing.Size(98, 53)
        Me.btnBack2.TabIndex = 4
        Me.btnBack2.Text = "Back"
        Me.btnBack2.UseVisualStyleBackColor = False
        '
        'BtnNext2
        '
        Me.BtnNext2.BackColor = System.Drawing.Color.LightCoral
        Me.BtnNext2.Font = New System.Drawing.Font("HGSSoeiKakupoptai", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BtnNext2.Location = New System.Drawing.Point(845, 595)
        Me.BtnNext2.Name = "BtnNext2"
        Me.BtnNext2.Size = New System.Drawing.Size(98, 53)
        Me.BtnNext2.TabIndex = 5
        Me.BtnNext2.Text = "Next"
        Me.BtnNext2.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Sitka Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RichTextBox1.Location = New System.Drawing.Point(34, 238)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(909, 272)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(474, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(720, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(201, 157)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Sitka Text", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.Firebrick
        Me.lblPrice.Location = New System.Drawing.Point(29, 529)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(935, 52)
        Me.lblPrice.TabIndex = 10
        Me.lblPrice.Text = "*All prices are quoted excluding VAT(20%) but include delivery(Location Service C" &
    "harge) to pickup point " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  e.g.airport,train station ect."
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Font = New System.Drawing.Font("Sitka Text", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(34, 238)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(909, 288)
        Me.RichTextBox2.TabIndex = 7
        Me.RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        '
        'frmTypesofVehicles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 660)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.BtnNext2)
        Me.Controls.Add(Me.btnBack2)
        Me.Controls.Add(Me.rdbVan)
        Me.Controls.Add(Me.rdbCar)
        Me.Controls.Add(Me.lblVehicleType)
        Me.Name = "frmTypesofVehicles"
        Me.Text = "Types_of_Vehicles"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVehicleType As Label
    Friend WithEvents rdbCar As RadioButton
    Friend WithEvents rdbVan As RadioButton
    Friend WithEvents btnBack2 As Button
    Friend WithEvents BtnNext2 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents RichTextBox2 As RichTextBox
End Class
