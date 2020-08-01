<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fileForm
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
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.menuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtTextArea = New System.Windows.Forms.TextBox()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.openDialog = New System.Windows.Forms.OpenFileDialog()
        Me.saveAsDialog = New System.Windows.Forms.SaveFileDialog()
        Me.saveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.menuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFile, Me.menuEdit, Me.menuHelp})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(800, 33)
        Me.menuStrip.TabIndex = 0
        Me.menuStrip.Text = "MenuStrip1"
        '
        'menuFile
        '
        Me.menuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFileNew, Me.menuFileOpen, Me.menuFileSave, Me.menuFileSaveAs, Me.menuFileClose, Me.menuFileExit})
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Size = New System.Drawing.Size(54, 29)
        Me.menuFile.Text = "File"
        Me.menuFile.ToolTipText = "File"
        '
        'menuFileNew
        '
        Me.menuFileNew.Name = "menuFileNew"
        Me.menuFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.menuFileNew.Size = New System.Drawing.Size(223, 34)
        Me.menuFileNew.Text = "New"
        Me.menuFileNew.ToolTipText = "File New"
        '
        'menuFileOpen
        '
        Me.menuFileOpen.Name = "menuFileOpen"
        Me.menuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.menuFileOpen.Size = New System.Drawing.Size(223, 34)
        Me.menuFileOpen.Text = "Open"
        Me.menuFileOpen.ToolTipText = "File Open"
        '
        'menuFileSave
        '
        Me.menuFileSave.Name = "menuFileSave"
        Me.menuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.menuFileSave.Size = New System.Drawing.Size(223, 34)
        Me.menuFileSave.Text = "Save"
        Me.menuFileSave.ToolTipText = "File Save"
        '
        'menuFileSaveAs
        '
        Me.menuFileSaveAs.Name = "menuFileSaveAs"
        Me.menuFileSaveAs.Size = New System.Drawing.Size(223, 34)
        Me.menuFileSaveAs.Text = "Save as"
        Me.menuFileSaveAs.ToolTipText = "File Save As"
        '
        'menuFileClose
        '
        Me.menuFileClose.Name = "menuFileClose"
        Me.menuFileClose.Size = New System.Drawing.Size(223, 34)
        Me.menuFileClose.Text = "Close"
        Me.menuFileClose.ToolTipText = "File Close"
        '
        'menuFileExit
        '
        Me.menuFileExit.Name = "menuFileExit"
        Me.menuFileExit.Size = New System.Drawing.Size(223, 34)
        Me.menuFileExit.Text = "Exit"
        Me.menuFileExit.ToolTipText = "File Exit"
        '
        'menuEdit
        '
        Me.menuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuEditCopy, Me.menuEditCut, Me.menuEditPaste})
        Me.menuEdit.Name = "menuEdit"
        Me.menuEdit.Size = New System.Drawing.Size(58, 29)
        Me.menuEdit.Text = "Edit"
        Me.menuEdit.ToolTipText = "Edit"
        '
        'menuEditCopy
        '
        Me.menuEditCopy.Name = "menuEditCopy"
        Me.menuEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.menuEditCopy.Size = New System.Drawing.Size(218, 34)
        Me.menuEditCopy.Text = "Copy"
        Me.menuEditCopy.ToolTipText = "Edit Copy"
        '
        'menuEditCut
        '
        Me.menuEditCut.Name = "menuEditCut"
        Me.menuEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.menuEditCut.Size = New System.Drawing.Size(218, 34)
        Me.menuEditCut.Text = "Cut"
        Me.menuEditCut.ToolTipText = "Edit Cut"
        '
        'menuEditPaste
        '
        Me.menuEditPaste.Name = "menuEditPaste"
        Me.menuEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.menuEditPaste.Size = New System.Drawing.Size(218, 34)
        Me.menuEditPaste.Text = "Paste"
        Me.menuEditPaste.ToolTipText = "Edit Paste"
        '
        'menuHelp
        '
        Me.menuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuHelpAbout})
        Me.menuHelp.Name = "menuHelp"
        Me.menuHelp.Size = New System.Drawing.Size(65, 29)
        Me.menuHelp.Text = "Help"
        Me.menuHelp.ToolTipText = "Help"
        '
        'menuHelpAbout
        '
        Me.menuHelpAbout.Name = "menuHelpAbout"
        Me.menuHelpAbout.Size = New System.Drawing.Size(270, 34)
        Me.menuHelpAbout.Text = "About"
        Me.menuHelpAbout.ToolTipText = "Help About"
        '
        'txtTextArea
        '
        Me.txtTextArea.Location = New System.Drawing.Point(12, 62)
        Me.txtTextArea.Multiline = True
        Me.txtTextArea.Name = "txtTextArea"
        Me.txtTextArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTextArea.Size = New System.Drawing.Size(776, 327)
        Me.txtTextArea.TabIndex = 4
        '
        'openDialog
        '
        Me.openDialog.FileName = "OpenFileDialog1"
        '
        'fileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtTextArea)
        Me.Controls.Add(Me.menuStrip)
        Me.MainMenuStrip = Me.menuStrip
        Me.Name = "fileForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Editor Select a File to Open"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents menuFile As ToolStripMenuItem
    Friend WithEvents menuFileNew As ToolStripMenuItem
    Friend WithEvents menuFileOpen As ToolStripMenuItem
    Friend WithEvents menuFileSave As ToolStripMenuItem
    Friend WithEvents menuFileSaveAs As ToolStripMenuItem
    Friend WithEvents menuFileClose As ToolStripMenuItem
    Friend WithEvents menuFileExit As ToolStripMenuItem
    Friend WithEvents menuEdit As ToolStripMenuItem
    Friend WithEvents menuEditCopy As ToolStripMenuItem
    Friend WithEvents menuEditCut As ToolStripMenuItem
    Friend WithEvents menuEditPaste As ToolStripMenuItem
    Friend WithEvents menuHelp As ToolStripMenuItem
    Friend WithEvents menuHelpAbout As ToolStripMenuItem
    Friend WithEvents txtTextArea As TextBox
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents openDialog As OpenFileDialog
    Friend WithEvents saveAsDialog As SaveFileDialog
    Friend WithEvents saveDialog As SaveFileDialog
End Class
