Imports System.IO
Imports System.Diagnostics
Imports System.Windows.Forms

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Zugferd Merger"
        txtPdfPath.ReadOnly = True
        txtXmlPath.ReadOnly = True
        txtOutputPath.ReadOnly = False ' Nutzer kann OutputPath anpassen
    End Sub

    Private Sub btnSelectPdf_Click(sender As Object, e As EventArgs) Handles btnSelectPdf.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
            openFileDialog.FilterIndex = 1

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                txtPdfPath.Text = openFileDialog.FileName
                ' Output-Pfad automatisch generieren
                txtOutputPath.Text = GenerateOutputPath(openFileDialog.FileName)
            End If
        End Using
    End Sub

    Private Sub btnSelectXml_Click(sender As Object, e As EventArgs) Handles btnSelectXml.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
            openFileDialog.FilterIndex = 1

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                txtXmlPath.Text = openFileDialog.FileName
            End If
        End Using
    End Sub

    Private Sub btnSelectOutput_Click(sender As Object, e As EventArgs) Handles btnSelectOutput.Click
        Using saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
            saveFileDialog.FileName = txtOutputPath.Text
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                txtOutputPath.Text = saveFileDialog.FileName
            End If
        End Using
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtPdfPath.Text = ""
        txtXmlPath.Text = ""
        txtOutputPath.Text = ""
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        If String.IsNullOrEmpty(txtPdfPath.Text) OrElse String.IsNullOrEmpty(txtXmlPath.Text) OrElse String.IsNullOrEmpty(txtOutputPath.Text) Then
            MessageBox.Show("Bitte wählen Sie PDF, XML und Ziel-Datei aus.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not File.Exists(txtPdfPath.Text) Then
            MessageBox.Show("Die ausgewählte PDF-Datei existiert nicht.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not File.Exists(txtXmlPath.Text) Then
            MessageBox.Show("Die ausgewählte XML-Datei existiert nicht.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ProcessFiles(txtPdfPath.Text, txtXmlPath.Text, txtOutputPath.Text)
            MessageBox.Show("Dateien wurden erfolgreich verarbeitet!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Fehler beim Verarbeiten der Dateien: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GenerateOutputPath(pdfPath As String) As String
        Dim dir As String = Path.GetDirectoryName(pdfPath)
        Dim baseName As String = Path.GetFileNameWithoutExtension(pdfPath)
        Dim timestamp As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
        Return Path.Combine(dir, $"{baseName}_zugferd_{timestamp}.pdf")
    End Function

    Private Function ProcessFiles(pdfPath As String, xmlPath As String, outputPath As String) As Boolean
        Try
            Dim pdf24Command As String = $"pdf24-Toolbox.exe -createInvoice ""{xmlPath}"" ""{outputPath}"" -pdfaFile ""{pdfPath}"" -outputType zugferd:xrechnung -passthrough"

            Using process As New Process()
                process.StartInfo.FileName = "cmd.exe"
                process.StartInfo.Arguments = $"/c {pdf24Command}"
                process.StartInfo.UseShellExecute = False
                process.StartInfo.RedirectStandardOutput = True
                process.StartInfo.RedirectStandardError = True
                process.StartInfo.CreateNoWindow = True

                process.Start()
                process.WaitForExit()
                Dim output = process.StandardOutput.ReadToEnd()
                Dim errorOutput = process.StandardError.ReadToEnd()

                If (Not "".Equals(errorOutput.Trim())) Then
                    MessageBox.Show("Fehler beim Ausführen des Befehls: " & errorOutput, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
                '  MessageBox.Show("Ausgabe:" & vbCrLf & output & vbCrLf & "Fehler:" & vbCrLf & errorOutput)

                Return process.ExitCode = 0
            End Using
        Catch ex As Exception
            Throw New Exception("Fehler beim Verarbeiten mit PDF24", ex)
        End Try
    End Function
End Class
