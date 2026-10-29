<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPilotFlights
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
        Me.cbopilots = New System.Windows.Forms.ComboBox()
        Me.lstpilotflights = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cbopilots
        '
        Me.cbopilots.FormattingEnabled = True
        Me.cbopilots.Location = New System.Drawing.Point(99, 131)
        Me.cbopilots.Name = "cbopilots"
        Me.cbopilots.Size = New System.Drawing.Size(121, 24)
        Me.cbopilots.TabIndex = 0
        '
        'lstpilotflights
        '
        Me.lstpilotflights.FormattingEnabled = True
        Me.lstpilotflights.ItemHeight = 16
        Me.lstpilotflights.Location = New System.Drawing.Point(389, 131)
        Me.lstpilotflights.Name = "lstpilotflights"
        Me.lstpilotflights.Size = New System.Drawing.Size(304, 292)
        Me.lstpilotflights.TabIndex = 1
        '
        'frmPilotFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstpilotflights)
        Me.Controls.Add(Me.cbopilots)
        Me.Name = "frmPilotFlights"
        Me.Text = "frmPilotFlights"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbopilots As ComboBox
    Friend WithEvents lstpilotflights As ListBox
End Class
