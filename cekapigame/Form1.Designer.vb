<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.IdTxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ServerTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbGame = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'IdTxt
        '
        Me.IdTxt.Location = New System.Drawing.Point(89, 250)
        Me.IdTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IdTxt.Name = "IdTxt"
        Me.IdTxt.Size = New System.Drawing.Size(463, 26)
        Me.IdTxt.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(89, 414)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(463, 58)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ServerTxt
        '
        Me.ServerTxt.Location = New System.Drawing.Point(89, 360)
        Me.ServerTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ServerTxt.Name = "ServerTxt"
        Me.ServerTxt.Size = New System.Drawing.Size(463, 26)
        Me.ServerTxt.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 335)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "SERVER"
        '
        'cmbGame
        '
        Me.cmbGame.FormattingEnabled = True
        Me.cmbGame.Items.AddRange(New Object() {"Mobile Legends", "FreeFire", "Call Of Duty Mobile"})
        Me.cmbGame.Location = New System.Drawing.Point(89, 127)
        Me.cmbGame.Name = "cmbGame"
        Me.cmbGame.Size = New System.Drawing.Size(463, 28)
        Me.cmbGame.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 692)
        Me.Controls.Add(Me.cmbGame)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ServerTxt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.IdTxt)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IdTxt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ServerTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbGame As ComboBox
End Class
