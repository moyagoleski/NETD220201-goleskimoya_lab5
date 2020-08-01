Option Strict On
Imports System.IO

' Moya Goleski
' 100589279
' 07/31/2020
' This is a basic text editor that is able to open, close, edit, save
' save as, and create new files. The text editor will also be able to
' copy, cut, and paste text as well as exit the program.

Public Class fileForm

    ' UNDER FILE TAB
    Private Sub New_Click(sender As Object, e As EventArgs) Handles menuFileNew.Click

        ' empties the text area
        txtTextArea.Text = String.Empty

    End Sub

    Private Sub Open_Click(sender As Object, e As EventArgs) Handles menuFileOpen.Click

        ' Handles when you open a file

        Dim inputStream As StreamReader

        If openDialog.ShowDialog() = DialogResult.OK Then
            inputStream = New StreamReader(openDialog.FileName)
            txtTextArea.Text = inputStream.ReadToEnd()
            inputStream.Close()

        End If

    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles menuFileSave.Click

        ' Handles when you save the file

        Dim outputStream As StreamWriter

        outputStream = New StreamWriter(saveDialog.FileName)
        outputStream.Write(txtTextArea.Text)
        outputStream.Close()

    End Sub

    Private Sub SaveAs_Click(sender As Object, e As EventArgs) Handles menuFileSaveAs.Click

        ' Handles when you save as the file

        Dim outputStream As StreamWriter

        If saveDialog.ShowDialog() = DialogResult.OK Then

            outputStream = New StreamWriter(saveDialog.FileName)
            outputStream.Write(txtTextArea.Text)
            outputStream.Close()

        End If

    End Sub
    ' BONUS
    Private Sub Close_Click(sender As Object, e As EventArgs) Handles menuFileClose.Click

    End Sub

    Private Sub Exit_Click(sender As Object, e As EventArgs) Handles menuFileExit.Click

        ' closes form
        Me.Close()

    End Sub

    ' UNDER EDIT TAB
    Private Sub Copy_Click(sender As Object, e As EventArgs) Handles menuEditCopy.Click

        ' checks if the user selected anything
        If txtTextArea.SelectedText <> String.Empty Then

            ' copies selected text
            My.Computer.Clipboard.SetText(txtTextArea.SelectedText)

        Else

            ' clears copy
            My.Computer.Clipboard.Clear()

        End If

    End Sub

    Private Sub Cut_Click(sender As Object, e As EventArgs) Handles menuEditCut.Click

        'checks if the user selected anything
        If txtTextArea.SelectedText <> String.Empty Then

            ' copies selected text
            My.Computer.Clipboard.SetText(txtTextArea.SelectedText)

            ' empties selected text from text area
            txtTextArea.SelectedText = String.Empty

        Else

            ' clears cut
            My.Computer.Clipboard.Clear()

        End If

    End Sub

    Private Sub Paste_Click(sender As Object, e As EventArgs) Handles menuEditPaste.Click

        ' if contains text
        If My.Computer.Clipboard.ContainsText Then

            ' pastes (gets) text into the text area
            txtTextArea.SelectedText = My.Computer.Clipboard.GetText()

        End If

    End Sub

    ' UNDER HELP TAB
    Private Sub About_Click(sender As Object, e As EventArgs) Handles menuHelpAbout.Click

        ' creates variable for aboutForm
        Dim aboutModal As New aboutForm

        ' shows aboutForm
        aboutModal.ShowDialog()

    End Sub
End Class