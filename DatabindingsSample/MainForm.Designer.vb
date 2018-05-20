<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.ClickButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.YesNoLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(19, 19)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(10)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(46, 16)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Name"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(78, 16)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(302, 23)
        Me.NameTextBox.TabIndex = 1
        '
        'ClickButton
        '
        Me.ClickButton.Location = New System.Drawing.Point(160, 52)
        Me.ClickButton.Margin = New System.Windows.Forms.Padding(10)
        Me.ClickButton.Name = "ClickButton"
        Me.ClickButton.Size = New System.Drawing.Size(100, 23)
        Me.ClickButton.TabIndex = 2
        Me.ClickButton.Text = "Click"
        Me.ClickButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(280, 52)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(10)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(100, 23)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'YesNoLabel
        '
        Me.YesNoLabel.BackColor = System.Drawing.SystemColors.Control
        Me.YesNoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.YesNoLabel.Location = New System.Drawing.Point(22, 55)
        Me.YesNoLabel.Margin = New System.Windows.Forms.Padding(10)
        Me.YesNoLabel.Name = "YesNoLabel"
        Me.YesNoLabel.Size = New System.Drawing.Size(24, 24)
        Me.YesNoLabel.TabIndex = 4
        Me.YesNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 94)
        Me.Controls.Add(Me.YesNoLabel)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ClickButton)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.NameLabel)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.Text = "Main Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents ClickButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents YesNoLabel As Label
End Class
