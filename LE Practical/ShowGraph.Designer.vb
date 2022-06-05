<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShowGraph
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
        Me.components = New System.ComponentModel.Container()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnPlot = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAmplitude = New System.Windows.Forms.TextBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picDraw = New System.Windows.Forms.PictureBox()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picDraw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.btnPlot)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 334)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(634, 127)
        Me.Panel1.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(506, 74)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 33)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(393, 74)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(94, 33)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnPlot
        '
        Me.btnPlot.Location = New System.Drawing.Point(393, 29)
        Me.btnPlot.Name = "btnPlot"
        Me.btnPlot.Size = New System.Drawing.Size(94, 33)
        Me.btnPlot.TabIndex = 1
        Me.btnPlot.Text = "&Plot"
        Me.btnPlot.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtAmplitude)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 106)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Amplitude"
        '
        'txtAmplitude
        '
        Me.txtAmplitude.Location = New System.Drawing.Point(38, 52)
        Me.txtAmplitude.Name = "txtAmplitude"
        Me.txtAmplitude.Size = New System.Drawing.Size(128, 29)
        Me.txtAmplitude.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.picDraw)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(634, 334)
        Me.Panel2.TabIndex = 1
        '
        'picDraw
        '
        Me.picDraw.BackColor = System.Drawing.Color.White
        Me.picDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picDraw.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picDraw.Location = New System.Drawing.Point(0, 0)
        Me.picDraw.Name = "picDraw"
        Me.picDraw.Size = New System.Drawing.Size(634, 334)
        Me.picDraw.TabIndex = 0
        Me.picDraw.TabStop = False
        '
        'ShowGraph
        '
        Me.AcceptButton = Me.btnPlot
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(634, 461)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(650, 500)
        Me.Name = "ShowGraph"
        Me.Text = "Form1"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.picDraw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnPlot As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAmplitude As TextBox
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents picDraw As PictureBox
End Class
