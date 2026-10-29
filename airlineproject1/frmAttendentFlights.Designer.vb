<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendentFlights
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
        Me.lstattendentflights = New System.Windows.Forms.ListBox()
        Me.cboattendent = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lstattendentflights
        '
        Me.lstattendentflights.FormattingEnabled = True
        Me.lstattendentflights.ItemHeight = 16
        Me.lstattendentflights.Location = New System.Drawing.Point(393, 84)
        Me.lstattendentflights.Name = "lstattendentflights"
        Me.lstattendentflights.Size = New System.Drawing.Size(304, 292)
        Me.lstattendentflights.TabIndex = 3
        '
        'cboattendent
        '
        Me.cboattendent.FormattingEnabled = True
        Me.cboattendent.Location = New System.Drawing.Point(103, 84)
        Me.cboattendent.Name = "cboattendent"
        Me.cboattendent.Size = New System.Drawing.Size(121, 24)
        Me.cboattendent.TabIndex = 2
        '
        'frmAttendentFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstattendentflights)
        Me.Controls.Add(Me.cboattendent)
        Me.Name = "frmAttendentFlights"
        Me.Text = "frmAttendentFlights"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstattendentflights As ListBox
    Friend WithEvents cboattendent As ComboBox
End Class
