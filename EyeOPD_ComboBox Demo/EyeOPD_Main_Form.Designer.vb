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
        Me.cmd_Load_Combo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmb_Patients
        '
        Me.cmb_Patients.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Patients.FormattingEnabled = True
        Me.cmb_Patients.Location = New System.Drawing.Point(194, 101)
        Me.cmb_Patients.Name = "cmb_Patients"
        Me.cmb_Patients.Size = New System.Drawing.Size(372, 28)
        Me.cmb_Patients.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Patient Names"
        '
        'ExitFrm
        '
        Me.ExitFrm.Location = New System.Drawing.Point(661, 519)
        Me.ExitFrm.Name = "ExitFrm"
        Me.ExitFrm.Size = New System.Drawing.Size(130, 45)
        Me.ExitFrm.TabIndex = 2
        Me.ExitFrm.Text = "Exit EyeOPD"
        Me.ExitFrm.UseVisualStyleBackColor = True
        '
        'cmd_Load_Combo
        '
        Me.cmd_Load_Combo.Location = New System.Drawing.Point(194, 146)
        Me.cmd_Load_Combo.Name = "cmd_Load_Combo"
        Me.cmd_Load_Combo.Size = New System.Drawing.Size(130, 39)
        Me.cmd_Load_Combo.TabIndex = 3
        Me.cmd_Load_Combo.Text = "Load ComboBox"
        Me.cmd_Load_Combo.UseVisualStyleBackColor = True
        '
        'EyeOPD_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 590)
        Me.Controls.Add(Me.cmd_Load_Combo)
        Me.Controls.Add(Me.ExitFrm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_Patients)
        Me.Name = "EyeOPD_Form"
        Me.Text = "Eye OPD Demo Form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmb_Patients As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ExitFrm As System.Windows.Forms.Button
    Friend WithEvents cmd_Load_Combo As System.Windows.Forms.Button

End Class
