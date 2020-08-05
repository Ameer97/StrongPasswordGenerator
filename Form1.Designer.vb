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
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.richTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(12, 12)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(326, 37)
        Me.button3.TabIndex = 18
        Me.button3.Text = "Static Passwords"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(263, 55)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 17
        Me.button2.Text = "Proccess"
        Me.button2.UseVisualStyleBackColor = True
        '
        'richTextBox2
        '
        Me.richTextBox2.Location = New System.Drawing.Point(182, 93)
        Me.richTextBox2.Name = "richTextBox2"
        Me.richTextBox2.Size = New System.Drawing.Size(156, 202)
        Me.richTextBox2.TabIndex = 16
        Me.richTextBox2.Text = ""
        '
        'richTextBox1
        '
        Me.richTextBox1.Location = New System.Drawing.Point(12, 93)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(154, 202)
        Me.richTextBox1.TabIndex = 15
        Me.richTextBox1.Text = ""
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(93, 55)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(164, 20)
        Me.textBox1.TabIndex = 14
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(12, 55)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 13
        Me.button1.Text = "Add New"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 326)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.richTextBox2)
        Me.Controls.Add(Me.richTextBox1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents richTextBox2 As System.Windows.Forms.RichTextBox
    Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents button1 As System.Windows.Forms.Button

End Class
