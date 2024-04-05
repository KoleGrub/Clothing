<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.BackBox2 = New System.Windows.Forms.PictureBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.BackroundBox = New System.Windows.Forms.PictureBox()
        Me.TshirtBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.BackBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackroundBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TshirtBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackBox2
        '
        Me.BackBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackBox2.Location = New System.Drawing.Point(988, 210)
        Me.BackBox2.Name = "BackBox2"
        Me.BackBox2.Size = New System.Drawing.Size(331, 399)
        Me.BackBox2.TabIndex = 14
        Me.BackBox2.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.RadioButton1.Location = New System.Drawing.Point(94, 300)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(72, 24)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "T-shirt"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadioButton2.Location = New System.Drawing.Point(94, 350)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(80, 24)
        Me.RadioButton2.TabIndex = 9
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Hoodie"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadioButton3.Location = New System.Drawing.Point(94, 404)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(108, 24)
        Me.RadioButton3.TabIndex = 10
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Long sleeve"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'BackroundBox
        '
        Me.BackroundBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackroundBox.Location = New System.Drawing.Point(71, 237)
        Me.BackroundBox.Name = "BackroundBox"
        Me.BackroundBox.Size = New System.Drawing.Size(154, 298)
        Me.BackroundBox.TabIndex = 13
        Me.BackroundBox.TabStop = False
        '
        'TshirtBox1
        '
        Me.TshirtBox1.Location = New System.Drawing.Point(323, 174)
        Me.TshirtBox1.Name = "TshirtBox1"
        Me.TshirtBox1.Size = New System.Drawing.Size(606, 535)
        Me.TshirtBox1.TabIndex = 12
        Me.TshirtBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Snap ITC", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(300, 69)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(639, 75)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "Long sleeve"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1365, 770)
        Me.Controls.Add(Me.BackBox2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.BackroundBox)
        Me.Controls.Add(Me.TshirtBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.BackBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackroundBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TshirtBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBox2 As PictureBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents BackroundBox As PictureBox
    Friend WithEvents TshirtBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
End Class
