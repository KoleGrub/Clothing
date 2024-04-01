<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TshirtBox1 = New System.Windows.Forms.PictureBox()
        Me.Hoodie = New System.Windows.Forms.TextBox()
        CType(Me.BackBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TshirtBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackBox2
        '
        Me.BackBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackBox2.Location = New System.Drawing.Point(1139, 268)
        Me.BackBox2.Name = "BackBox2"
        Me.BackBox2.Size = New System.Drawing.Size(331, 399)
        Me.BackBox2.TabIndex = 17
        Me.BackBox2.TabStop = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.RadioButton4.Location = New System.Drawing.Point(270, 319)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(72, 24)
        Me.RadioButton4.TabIndex = 11
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "T-shirt"
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadioButton5.Location = New System.Drawing.Point(270, 369)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(80, 24)
        Me.RadioButton5.TabIndex = 12
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Hoodie"
        Me.RadioButton5.UseVisualStyleBackColor = False
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RadioButton6.Location = New System.Drawing.Point(270, 423)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(108, 24)
        Me.RadioButton6.TabIndex = 13
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Long sleeve"
        Me.RadioButton6.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PictureBox1.Location = New System.Drawing.Point(237, 243)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 298)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'TshirtBox1
        '
        Me.TshirtBox1.Location = New System.Drawing.Point(499, 185)
        Me.TshirtBox1.Name = "TshirtBox1"
        Me.TshirtBox1.Size = New System.Drawing.Size(606, 535)
        Me.TshirtBox1.TabIndex = 15
        Me.TshirtBox1.TabStop = False
        '
        'Hoodie
        '
        Me.Hoodie.Font = New System.Drawing.Font("Snap ITC", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Hoodie.Location = New System.Drawing.Point(488, 89)
        Me.Hoodie.Multiline = True
        Me.Hoodie.Name = "Hoodie"
        Me.Hoodie.Size = New System.Drawing.Size(629, 75)
        Me.Hoodie.TabIndex = 14
        Me.Hoodie.Text = "Hoodie"
        Me.Hoodie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Hoodie.UseSystemPasswordChar = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1716, 808)
        Me.Controls.Add(Me.BackBox2)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.RadioButton6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TshirtBox1)
        Me.Controls.Add(Me.Hoodie)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.BackBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TshirtBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBox2 As PictureBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TshirtBox1 As PictureBox
    Friend WithEvents Hoodie As TextBox
End Class
