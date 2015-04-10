<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadLogs
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
        Me.OpenFD = New System.Windows.Forms.OpenFileDialog
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'OpenFD
        '
        Me.OpenFD.FileName = "OpenFileDialog1"
        '
        'ListView1
        '
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 48)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(725, 334)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(534, 388)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 25)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Load"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(598, 388)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 25)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Post to DB"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(674, 388)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(63, 25)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Log Verification View"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(468, 388)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(63, 25)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'LoadLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 418)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "LoadLogs"
        Me.Text = "Biometric AGL Text File Uploader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
