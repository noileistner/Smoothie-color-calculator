<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.btnSelectFruit1 = New System.Windows.Forms.Button()
        Me.btnSelectFruit2 = New System.Windows.Forms.Button()
        Me.btnCalculateSmoothieColor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(16, 15)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(118, 132)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(196, 15)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(119, 132)
        Me.ListBox2.TabIndex = 1
        '
        'btnSelectFruit1
        '
        Me.btnSelectFruit1.Location = New System.Drawing.Point(13, 169)
        Me.btnSelectFruit1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSelectFruit1.Name = "btnSelectFruit1"
        Me.btnSelectFruit1.Size = New System.Drawing.Size(119, 48)
        Me.btnSelectFruit1.TabIndex = 2
        Me.btnSelectFruit1.Text = "Fruit 1"
        Me.btnSelectFruit1.UseVisualStyleBackColor = True
        '
        'btnSelectFruit2
        '
        Me.btnSelectFruit2.Location = New System.Drawing.Point(196, 169)
        Me.btnSelectFruit2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSelectFruit2.Name = "btnSelectFruit2"
        Me.btnSelectFruit2.Size = New System.Drawing.Size(119, 48)
        Me.btnSelectFruit2.TabIndex = 3
        Me.btnSelectFruit2.Text = "Fruit 2"
        Me.btnSelectFruit2.UseVisualStyleBackColor = True
        '
        'btnCalculateSmoothieColor
        '
        Me.btnCalculateSmoothieColor.Location = New System.Drawing.Point(107, 239)
        Me.btnCalculateSmoothieColor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalculateSmoothieColor.Name = "btnCalculateSmoothieColor"
        Me.btnCalculateSmoothieColor.Size = New System.Drawing.Size(115, 49)
        Me.btnCalculateSmoothieColor.TabIndex = 4
        Me.btnCalculateSmoothieColor.Text = "Calculate color"
        Me.btnCalculateSmoothieColor.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 319)
        Me.Controls.Add(Me.btnCalculateSmoothieColor)
        Me.Controls.Add(Me.btnSelectFruit2)
        Me.Controls.Add(Me.btnSelectFruit1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Smoothie color calculator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents btnSelectFruit1 As Button
    Friend WithEvents btnSelectFruit2 As Button
    Friend WithEvents btnCalculateSmoothieColor As Button
End Class
