<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class livros
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.requisitar = New System.Windows.Forms.TabPage()
        Me.entregar = New System.Windows.Forms.TabPage()
        Me.closeBtn = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SlateGray
        Me.Label1.Location = New System.Drawing.Point(82, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "> Livros"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.requisitar)
        Me.TabControl1.Controls.Add(Me.entregar)
        Me.TabControl1.Location = New System.Drawing.Point(0, 106)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 514)
        Me.TabControl1.TabIndex = 3
        '
        'requisitar
        '
        Me.requisitar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.requisitar.Location = New System.Drawing.Point(4, 22)
        Me.requisitar.Name = "requisitar"
        Me.requisitar.Padding = New System.Windows.Forms.Padding(3)
        Me.requisitar.Size = New System.Drawing.Size(792, 488)
        Me.requisitar.TabIndex = 0
        Me.requisitar.Text = "Requisitar"
        '
        'entregar
        '
        Me.entregar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.entregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.entregar.Location = New System.Drawing.Point(4, 22)
        Me.entregar.Name = "entregar"
        Me.entregar.Padding = New System.Windows.Forms.Padding(3)
        Me.entregar.Size = New System.Drawing.Size(792, 488)
        Me.entregar.TabIndex = 1
        Me.entregar.Text = "Entregar"
        '
        'closeBtn
        '
        Me.closeBtn.Image = Global.CRE.My.Resources.Resources.closeBtn
        Me.closeBtn.Location = New System.Drawing.Point(763, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(25, 30)
        Me.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.closeBtn.TabIndex = 6
        Me.closeBtn.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Calibri Light", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 33)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Menu"
        '
        'livros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 730)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "livros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Livros"
        Me.TabControl1.ResumeLayout(False)
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents requisitar As System.Windows.Forms.TabPage
    Friend WithEvents entregar As System.Windows.Forms.TabPage
    Friend WithEvents closeBtn As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
