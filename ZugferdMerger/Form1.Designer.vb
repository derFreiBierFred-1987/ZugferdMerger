<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtPdfPath = New TextBox()
        txtXmlPath = New TextBox()
        txtOutputPath = New TextBox()
        btnSelectPdf = New Button()
        btnSelectXml = New Button()
        btnSelectOutput = New Button()
        btnProcess = New Button()
        btnReset = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' txtPdfPath
        ' 
        txtPdfPath.Location = New Point(12, 29)
        txtPdfPath.Name = "txtPdfPath"
        txtPdfPath.ReadOnly = True
        txtPdfPath.Size = New Size(379, 23)
        txtPdfPath.TabIndex = 0
        ' 
        ' txtXmlPath
        ' 
        txtXmlPath.Location = New Point(12, 82)
        txtXmlPath.Name = "txtXmlPath"
        txtXmlPath.ReadOnly = True
        txtXmlPath.Size = New Size(379, 23)
        txtXmlPath.TabIndex = 1
        ' 
        ' txtOutputPath
        ' 
        txtOutputPath.Location = New Point(12, 135)
        txtOutputPath.Name = "txtOutputPath"
        txtOutputPath.Size = New Size(379, 23)
        txtOutputPath.TabIndex = 7
        ' 
        ' btnSelectPdf
        ' 
        btnSelectPdf.Location = New Point(397, 28)
        btnSelectPdf.Name = "btnSelectPdf"
        btnSelectPdf.Size = New Size(75, 23)
        btnSelectPdf.TabIndex = 2
        btnSelectPdf.Text = "Durchsuchen..."
        btnSelectPdf.UseVisualStyleBackColor = True
        ' 
        ' btnSelectXml
        ' 
        btnSelectXml.Location = New Point(397, 81)
        btnSelectXml.Name = "btnSelectXml"
        btnSelectXml.Size = New Size(75, 23)
        btnSelectXml.TabIndex = 3
        btnSelectXml.Text = "Durchsuchen..."
        btnSelectXml.UseVisualStyleBackColor = True
        ' 
        ' btnSelectOutput
        ' 
        btnSelectOutput.Location = New Point(397, 134)
        btnSelectOutput.Name = "btnSelectOutput"
        btnSelectOutput.Size = New Size(75, 23)
        btnSelectOutput.TabIndex = 8
        btnSelectOutput.Text = "Durchsuchen..."
        btnSelectOutput.UseVisualStyleBackColor = True
        ' 
        ' btnProcess
        ' 
        btnProcess.Location = New Point(12, 174)
        btnProcess.Name = "btnProcess"
        btnProcess.Size = New Size(220, 33)
        btnProcess.TabIndex = 4
        btnProcess.Text = "Dateien verarbeiten"
        btnProcess.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Image = CType(resources.GetObject("btnReset.Image"), Image)
        btnReset.ImageAlign = ContentAlignment.MiddleLeft
        btnReset.Location = New Point(252, 174)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(220, 33)
        btnReset.TabIndex = 10
        btnReset.Text = "Zurücksetzen"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 5
        Label1.Text = "PDF-Datei:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 6
        Label2.Text = "XML-Datei:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 15)
        Label3.TabIndex = 9
        Label3.Text = "Ziel-Datei:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(484, 221)
        Controls.Add(Label3)
        Controls.Add(txtOutputPath)
        Controls.Add(btnSelectOutput)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnProcess)
        Controls.Add(btnReset)
        Controls.Add(btnSelectXml)
        Controls.Add(btnSelectPdf)
        Controls.Add(txtXmlPath)
        Controls.Add(txtPdfPath)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Zugferd Merger"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtPdfPath As TextBox
    Friend WithEvents txtXmlPath As TextBox
    Friend WithEvents txtOutputPath As TextBox
    Friend WithEvents btnSelectPdf As Button
    Friend WithEvents btnSelectXml As Button
    Friend WithEvents btnSelectOutput As Button
    Friend WithEvents btnProcess As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
