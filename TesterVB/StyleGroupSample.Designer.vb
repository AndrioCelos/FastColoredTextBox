<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StyleGroupSample
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StyleGroupSample))
		Me.fctb = New FastColoredTextBoxNS.FastColoredTextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.cmMark = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.setUnderlineStyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.setBrownStyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		CType(Me.fctb, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.cmMark.SuspendLayout()
		Me.SuspendLayout()
		'
		'fctb
		'
		Me.fctb.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
		Me.fctb.AutoScrollMinSize = New System.Drawing.Size(0, 19)
		Me.fctb.BackBrush = Nothing
		Me.fctb.CharHeight = 19
		Me.fctb.CharWidth = 9
		Me.fctb.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.fctb.DescriptionFile = ""
		Me.fctb.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
		Me.fctb.Dock = System.Windows.Forms.DockStyle.Fill
		Me.fctb.Font = New System.Drawing.Font("Consolas", 9.75!)
		Me.fctb.IsReplaceMode = False
		Me.fctb.Location = New System.Drawing.Point(0, 86)
		Me.fctb.Margin = New System.Windows.Forms.Padding(4)
		Me.fctb.Name = "fctb"
		Me.fctb.Paddings = New System.Windows.Forms.Padding(0)
		Me.fctb.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.fctb.ServiceColors = CType(resources.GetObject("fctb.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
		Me.fctb.ShowLineNumbers = False
		Me.fctb.Size = New System.Drawing.Size(664, 235)
		Me.fctb.TabIndex = 2
		Me.fctb.WordWrap = True
		Me.fctb.Zoom = 100
		'
		'label1
		'
		Me.label1.Dock = System.Windows.Forms.DockStyle.Top
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.label1.Location = New System.Drawing.Point(0, 0)
		Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(664, 86)
		Me.label1.TabIndex = 3
		Me.label1.Text = resources.GetString("label1.Text")
		'
		'cmMark
		'
		Me.cmMark.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.cmMark.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.setUnderlineStyleToolStripMenuItem, Me.setBrownStyleToolStripMenuItem})
		Me.cmMark.Name = "contextMenuStrip1"
		Me.cmMark.Size = New System.Drawing.Size(200, 52)
		'
		'setUnderlineStyleToolStripMenuItem
		'
		Me.setUnderlineStyleToolStripMenuItem.Name = "setUnderlineStyleToolStripMenuItem"
		Me.setUnderlineStyleToolStripMenuItem.Size = New System.Drawing.Size(199, 24)
		Me.setUnderlineStyleToolStripMenuItem.Text = "Set &underline style"
		'
		'setBrownStyleToolStripMenuItem
		'
		Me.setBrownStyleToolStripMenuItem.Name = "setBrownStyleToolStripMenuItem"
		Me.setBrownStyleToolStripMenuItem.Size = New System.Drawing.Size(199, 24)
		Me.setBrownStyleToolStripMenuItem.Text = "Set b&rown style"
		'
		'StyleGroupSample
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(664, 321)
		Me.Controls.Add(Me.fctb)
		Me.Controls.Add(Me.label1)
		Me.Name = "StyleGroupSample"
		Me.Text = "StyleGroupSample"
		CType(Me.fctb, System.ComponentModel.ISupportInitialize).EndInit()
		Me.cmMark.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Private WithEvents fctb As FastColoredTextBox
	Private WithEvents label1 As Label
	Private WithEvents cmMark As ContextMenuStrip
	Private WithEvents setUnderlineStyleToolStripMenuItem As ToolStripMenuItem
	Private WithEvents setBrownStyleToolStripMenuItem As ToolStripMenuItem
End Class
