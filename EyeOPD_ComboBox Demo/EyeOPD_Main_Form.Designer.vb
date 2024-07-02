<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EyeOPD_Form
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
        Me.cmb_Patients = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExitFrm = New System.Windows.Forms.Button()
        Me.btn_Read = New System.Windows.Forms.Button()
        Me.btn_Create = New System.Windows.Forms.Button()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.tb_JKC_Reg_Number = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmb_Patients
        '
        Me.cmb_Patients.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Patients.FormattingEnabled = True
        Me.cmb_Patients.Location = New System.Drawing.Point(46, 58)
        Me.cmb_Patients.Name = "cmb_Patients"
        Me.cmb_Patients.Size = New System.Drawing.Size(461, 28)
        Me.cmb_Patients.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Patient Names"
        '
        'ExitFrm
        '
        Me.ExitFrm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitFrm.Location = New System.Drawing.Point(642, 236)
        Me.ExitFrm.Name = "ExitFrm"
        Me.ExitFrm.Size = New System.Drawing.Size(141, 45)
        Me.ExitFrm.TabIndex = 2
        Me.ExitFrm.Text = "Exit EyeOPD"
        Me.ExitFrm.UseVisualStyleBackColor = True
        '
        'btn_Read
        '
        Me.btn_Read.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Read.Location = New System.Drawing.Point(150, 107)
        Me.btn_Read.Name = "btn_Read"
        Me.btn_Read.Size = New System.Drawing.Size(89, 39)
        Me.btn_Read.TabIndex = 3
        Me.btn_Read.Text = "Read"
        Me.btn_Read.UseVisualStyleBackColor = True
        '
        'btn_Create
        '
        Me.btn_Create.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Create.Location = New System.Drawing.Point(21, 107)
        Me.btn_Create.Name = "btn_Create"
        Me.btn_Create.Size = New System.Drawing.Size(111, 39)
        Me.btn_Create.TabIndex = 4
        Me.btn_Create.Text = "Create"
        Me.btn_Create.UseVisualStyleBackColor = True
        '
        'btn_Update
        '
        Me.btn_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update.Location = New System.Drawing.Point(257, 107)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(89, 39)
        Me.btn_Update.TabIndex = 5
        Me.btn_Update.Text = "Update"
        Me.btn_Update.UseVisualStyleBackColor = True
        '
        'btn_Delete
        '
        Me.btn_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete.Location = New System.Drawing.Point(364, 107)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(89, 39)
        Me.btn_Delete.TabIndex = 6
        Me.btn_Delete.Text = "Delete"
        Me.btn_Delete.UseVisualStyleBackColor = True
        '
        'tb_JKC_Reg_Number
        '
        Me.tb_JKC_Reg_Number.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_JKC_Reg_Number.Location = New System.Drawing.Point(11, 45)
        Me.tb_JKC_Reg_Number.Multiline = True
        Me.tb_JKC_Reg_Number.Name = "tb_JKC_Reg_Number"
        Me.tb_JKC_Reg_Number.Size = New System.Drawing.Size(455, 41)
        Me.tb_JKC_Reg_Number.TabIndex = 7
        Me.tb_JKC_Reg_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btn_Create)
        Me.GroupBox1.Controls.Add(Me.btn_Delete)
        Me.GroupBox1.Controls.Add(Me.tb_JKC_Reg_Number)
        Me.GroupBox1.Controls.Add(Me.btn_Update)
        Me.GroupBox1.Controls.Add(Me.btn_Read)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 161)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Create New Patient"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "JKC Reg Number"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.EyeOPD_ComboBox_Demo.My.Resources.Resources.Logo
        Me.GroupBox2.Location = New System.Drawing.Point(600, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(247, 213)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'EyeOPD_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(859, 293)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ExitFrm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_Patients)
        Me.Name = "EyeOPD_Form"
        Me.Text = "Eye OPD Demo Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmb_Patients As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ExitFrm As System.Windows.Forms.Button
    Friend WithEvents btn_Read As System.Windows.Forms.Button
    Friend WithEvents btn_Create As System.Windows.Forms.Button
    Friend WithEvents btn_Update As System.Windows.Forms.Button
    Friend WithEvents btn_Delete As System.Windows.Forms.Button
    Friend WithEvents tb_JKC_Reg_Number As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
