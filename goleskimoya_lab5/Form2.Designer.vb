<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aboutForm
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
        Me.courselbl = New System.Windows.Forms.Label()
        Me.lablbl = New System.Windows.Forms.Label()
        Me.namelbl = New System.Windows.Forms.Label()
        Me.OKbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'courselbl
        '
        Me.courselbl.AutoSize = True
        Me.courselbl.Location = New System.Drawing.Point(75, 50)
        Me.courselbl.Name = "courselbl"
        Me.courselbl.Size = New System.Drawing.Size(93, 20)
        Me.courselbl.TabIndex = 0
        Me.courselbl.Text = "NETD-2202"
        '
        'lablbl
        '
        Me.lablbl.AutoSize = True
        Me.lablbl.Location = New System.Drawing.Point(97, 144)
        Me.lablbl.Name = "lablbl"
        Me.lablbl.Size = New System.Drawing.Size(49, 20)
        Me.lablbl.TabIndex = 1
        Me.lablbl.Text = "Lab 5"
        '
        'namelbl
        '
        Me.namelbl.AutoSize = True
        Me.namelbl.Location = New System.Drawing.Point(69, 97)
        Me.namelbl.Name = "namelbl"
        Me.namelbl.Size = New System.Drawing.Size(104, 20)
        Me.namelbl.TabIndex = 2
        Me.namelbl.Text = "Moya Goleski"
        '
        'OKbtn
        '
        Me.OKbtn.AutoSize = True
        Me.OKbtn.Location = New System.Drawing.Point(58, 206)
        Me.OKbtn.Name = "OKbtn"
        Me.OKbtn.Size = New System.Drawing.Size(134, 42)
        Me.OKbtn.TabIndex = 3
        Me.OKbtn.Text = "OK"
        Me.OKbtn.UseVisualStyleBackColor = True
        '
        'aboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 288)
        Me.Controls.Add(Me.OKbtn)
        Me.Controls.Add(Me.namelbl)
        Me.Controls.Add(Me.lablbl)
        Me.Controls.Add(Me.courselbl)
        Me.Name = "aboutForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents courselbl As Label
    Friend WithEvents lablbl As Label
    Friend WithEvents namelbl As Label
    Friend WithEvents OKbtn As Button

    Private Sub OKbtn_Click(sender As Object, e As EventArgs) Handles OKbtn.Click

        ' closes form
        Me.Close()

    End Sub
End Class
