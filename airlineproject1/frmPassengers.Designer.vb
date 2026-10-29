<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassengers
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
        Me.lstpassengers = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstpassengers
        '
        Me.lstpassengers.FormattingEnabled = True
        Me.lstpassengers.ItemHeight = 16
        Me.lstpassengers.Location = New System.Drawing.Point(258, 61)
        Me.lstpassengers.Name = "lstpassengers"
        Me.lstpassengers.Size = New System.Drawing.Size(290, 308)
        Me.lstpassengers.TabIndex = 0
        '
        'frmPassengers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstpassengers)
        Me.Name = "frmPassengers"
        Me.Text = "frmPassengers"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstpassengers As ListBox
End Class
