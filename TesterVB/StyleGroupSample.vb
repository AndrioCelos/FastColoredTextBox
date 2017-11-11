Public Class StyleGroupSample
	Private shortCutStyle As New ShortcutStyle(Pens.Maroon)
	Private underlineStyle As New WavyLineStyle(255, Color.Black)
	Private styles(127) As TextStyle
	' This takes 8 bits to represent because a zero value (for no style) Is needed along with a value for each style in the group.

	Private Sub fctb_Load(sender As Object, e As EventArgs) Handles fctb.Load
		fctb.AddStyle(shortCutStyle)

		For i = 0 To 127
			styles(i) = New TextStyle(New SolidBrush(Color.FromArgb((127 - i) * 2, i * 2, 0)), Nothing, FontStyle.Regular)
		Next

		fctb.AddStyleGroup(New StyleGroup(styles))

		For i = 0 To 127
			fctb.AppendText(i.ToString("000") + " ", styles(i))
		Next
	End Sub

	Private Sub fctb_SelectionChangedDelayed(sender As Object, e As EventArgs) Handles fctb.SelectionChangedDelayed
		' here we draw shortcut for selection area
		Dim selection = fctb.Selection
		' clear previous shortcuts
		fctb.VisibleRange.ClearStyle(shortCutStyle)
		' create shortcuts
		If Not selection.IsEmpty Then  ' user selected one or more chars?
			' find last char
			Dim r = selection.Clone()
			r.Normalize()
			r.Start = r.End  ' go to last char
			r.GoLeft(True)  ' select last char
			' apply ShortCutStyle
			r.SetStyle(shortCutStyle)
		End If
	End Sub

	Private Sub fctb_VisualMarkerClick(sender As Object, e As VisualMarkerEventArgs) Handles fctb.VisualMarkerClick
		' is it our style ?
		If e.Style Is shortCutStyle Then
			' show popup menu
			cmMark.Show(fctb.PointToScreen(e.Location))
		End If
	End Sub

	Private Sub setUnderlineStyleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles setUnderlineStyleToolStripMenuItem.Click
		fctb.Selection.SetStyle(underlineStyle)
		' This style is independent of the text color styles.
	End Sub

	Private Sub setBrownStyleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles setBrownStyleToolStripMenuItem.Click
		fctb.Selection.SetStyle(styles(64))
		' This style is mutually exclusive with the text color styles. Setting it will erase any other one of them from the range.
	End Sub
End Class