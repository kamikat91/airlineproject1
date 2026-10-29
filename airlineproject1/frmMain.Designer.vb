<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnpassengers = New System.Windows.Forms.Button()
        Me.btnpilotflights = New System.Windows.Forms.Button()
        Me.btnattendantflights = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnpassengers
        '
        Me.btnpassengers.Font = New System.Drawing.Font("Modern No. 20", 27.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpassengers.Location = New System.Drawing.Point(12, 31)
        Me.btnpassengers.Name = "btnpassengers"
        Me.btnpassengers.Size = New System.Drawing.Size(269, 179)
        Me.btnpassengers.TabIndex = 0
        Me.btnpassengers.Text = "Passengers"
        Me.btnpassengers.UseVisualStyleBackColor = True
        '
        'btnpilotflights
        '
        Me.btnpilotflights.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpilotflights.Location = New System.Drawing.Point(383, 31)
        Me.btnpilotflights.Name = "btnpilotflights"
        Me.btnpilotflights.Size = New System.Drawing.Size(269, 179)
        Me.btnpilotflights.TabIndex = 1
        Me.btnpilotflights.Text = "Pilot Flights"
        Me.btnpilotflights.UseVisualStyleBackColor = True
        '
        'btnattendantflights
        '
        Me.btnattendantflights.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnattendantflights.Location = New System.Drawing.Point(12, 243)
        Me.btnattendantflights.Name = "btnattendantflights"
        Me.btnattendantflights.Size = New System.Drawing.Size(269, 179)
        Me.btnattendantflights.TabIndex = 2
        Me.btnattendantflights.Text = "Attendant Flights"
        Me.btnattendantflights.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Modern No. 20", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(383, 243)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(269, 179)
        Me.btnexit.TabIndex = 3
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 450)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnattendantflights)
        Me.Controls.Add(Me.btnpilotflights)
        Me.Controls.Add(Me.btnpassengers)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnpassengers As Button
    Friend WithEvents btnpilotflights As Button
    Friend WithEvents btnattendantflights As Button
    Friend WithEvents btnexit As Button
End Class
