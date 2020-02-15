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
        Me.NameInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AgeInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddressInput = New System.Windows.Forms.TextBox()
        Me.SaveTxt = New System.Windows.Forms.Button()
        Me.SaveXml = New System.Windows.Forms.Button()
        Me.SaveJson = New System.Windows.Forms.Button()
        Me.Status = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NameInput
        '
        Me.NameInput.Location = New System.Drawing.Point(107, 65)
        Me.NameInput.Name = "NameInput"
        Me.NameInput.Size = New System.Drawing.Size(203, 20)
        Me.NameInput.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(35, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(35, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Age:"
        '
        'AgeInput
        '
        Me.AgeInput.Location = New System.Drawing.Point(107, 102)
        Me.AgeInput.Name = "AgeInput"
        Me.AgeInput.Size = New System.Drawing.Size(58, 20)
        Me.AgeInput.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(35, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Address:"
        '
        'AddressInput
        '
        Me.AddressInput.Location = New System.Drawing.Point(107, 143)
        Me.AddressInput.Name = "AddressInput"
        Me.AddressInput.Size = New System.Drawing.Size(230, 20)
        Me.AddressInput.TabIndex = 4
        '
        'SaveTxt
        '
        Me.SaveTxt.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.SaveTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.SaveTxt.Location = New System.Drawing.Point(38, 192)
        Me.SaveTxt.Name = "SaveTxt"
        Me.SaveTxt.Size = New System.Drawing.Size(75, 32)
        Me.SaveTxt.TabIndex = 6
        Me.SaveTxt.Text = ".txt"
        Me.SaveTxt.UseVisualStyleBackColor = False
        '
        'SaveXml
        '
        Me.SaveXml.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.SaveXml.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.SaveXml.Location = New System.Drawing.Point(151, 192)
        Me.SaveXml.Name = "SaveXml"
        Me.SaveXml.Size = New System.Drawing.Size(75, 32)
        Me.SaveXml.TabIndex = 7
        Me.SaveXml.Text = ".xml"
        Me.SaveXml.UseVisualStyleBackColor = False
        '
        'SaveJson
        '
        Me.SaveJson.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.SaveJson.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.SaveJson.Location = New System.Drawing.Point(262, 192)
        Me.SaveJson.Name = "SaveJson"
        Me.SaveJson.Size = New System.Drawing.Size(75, 32)
        Me.SaveJson.TabIndex = 8
        Me.SaveJson.Text = ".json"
        Me.SaveJson.UseVisualStyleBackColor = False
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Location = New System.Drawing.Point(91, 28)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(0, 13)
        Me.Status.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 243)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.SaveJson)
        Me.Controls.Add(Me.SaveXml)
        Me.Controls.Add(Me.SaveTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AddressInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AgeInput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NameInput)
        Me.Name = "Form1"
        Me.Text = "Save Form Format"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AgeInput As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AddressInput As TextBox
    Friend WithEvents SaveTxt As Button
    Friend WithEvents SaveXml As Button
    Friend WithEvents SaveJson As Button
    Friend WithEvents Status As Label
End Class
