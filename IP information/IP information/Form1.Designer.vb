<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Me.GettingIPButton = New System.Windows.Forms.Button
        Me.GettingInformationButton = New System.Windows.Forms.Button
        Me.GettingExternalIPButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.AboutButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'GettingIPButton
        '
        Me.GettingIPButton.Location = New System.Drawing.Point(44, 66)
        Me.GettingIPButton.Name = "GettingIPButton"
        Me.GettingIPButton.Size = New System.Drawing.Size(75, 23)
        Me.GettingIPButton.TabIndex = 1
        Me.GettingIPButton.Text = "Get I&P"
        Me.GettingIPButton.UseVisualStyleBackColor = True
        '
        'GettingInformationButton
        '
        Me.GettingInformationButton.Location = New System.Drawing.Point(237, 78)
        Me.GettingInformationButton.Name = "GettingInformationButton"
        Me.GettingInformationButton.Size = New System.Drawing.Size(75, 23)
        Me.GettingInformationButton.TabIndex = 2
        Me.GettingInformationButton.Text = "Get &IP information"
        Me.GettingInformationButton.UseVisualStyleBackColor = True
        '
        'GettingExternalIPButton
        '
        Me.GettingExternalIPButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.GettingExternalIPButton.Location = New System.Drawing.Point(31, 158)
        Me.GettingExternalIPButton.Name = "GettingExternalIPButton"
        Me.GettingExternalIPButton.Size = New System.Drawing.Size(75, 23)
        Me.GettingExternalIPButton.TabIndex = 3
        Me.GettingExternalIPButton.Text = "Get &external IP information"
        Me.GettingExternalIPButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(237, 158)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'AboutButton
        '
        Me.AboutButton.Location = New System.Drawing.Point(128, 113)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(75, 23)
        Me.AboutButton.TabIndex = 4
        Me.AboutButton.Text = "About"
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(348, 220)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.GettingExternalIPButton)
        Me.Controls.Add(Me.GettingInformationButton)
        Me.Controls.Add(Me.GettingIPButton)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IP information"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GettingIPButton As System.Windows.Forms.Button
    Friend WithEvents GettingInformationButton As System.Windows.Forms.Button
    Friend WithEvents GettingExternalIPButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents AboutButton As System.Windows.Forms.Button

End Class
