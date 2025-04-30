<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeForm
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
        Me.btnLoadEmployees = New System.Windows.Forms.Button()
        Me.dgvEmployees = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoadEmployees
        '
        Me.btnLoadEmployees.Location = New System.Drawing.Point(42, 42)
        Me.btnLoadEmployees.Name = "btnLoadEmployees"
        Me.btnLoadEmployees.Size = New System.Drawing.Size(111, 23)
        Me.btnLoadEmployees.TabIndex = 0
        Me.btnLoadEmployees.Text = "LoadEmployees"
        Me.btnLoadEmployees.UseVisualStyleBackColor = True
        '
        'dgvEmployees
        '
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Location = New System.Drawing.Point(12, 83)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.Size = New System.Drawing.Size(520, 250)
        Me.dgvEmployees.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(637, 351)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.dgvEmployees)
        Me.Controls.Add(Me.btnLoadEmployees)
        Me.Name = "EmployeeForm"
        Me.Text = "EmployeeForm"
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLoadEmployees As Button
    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents btnExit As Button
End Class
