Imports System.Text.RegularExpressions
Imports Newtonsoft.Json

Public Class Form1
    Dim PATH As String = "C:/Users/ENRIQUEZ/Desktop/Samples"

    Class formInput
        Public name As String
        Public age As Int32
        Public address As String
    End Class

    Private Sub TextAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AgeInput.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextAge_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AgeInput.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        AgeInput.Text = digitsOnly.Replace(AgeInput.Text, "")
    End Sub

    Private Sub SaveTxt_Click(sender As Object, e As EventArgs) Handles SaveTxt.Click
        If isBlank() Then
            My.Computer.FileSystem.WriteAllText(PATH & ".txt", "", True)
            Dim objWriter As New System.IO.StreamWriter(PATH & ".txt")

            objWriter.WriteLine("Name:" & ControlChars.Tab & ControlChars.Tab & NameInput.Text)
            objWriter.WriteLine("Age:" & ControlChars.Tab & ControlChars.Tab & AgeInput.Text)
            objWriter.WriteLine("Address:" & ControlChars.Tab & AddressInput.Text)

            objWriter.Close()

            Status.ForeColor = Color.Green
            Status.Text = "Successfully saved as TXT format."
        Else
            Status.ForeColor = Color.Red
            Status.Text = "Please fill up all inputs."
        End If
    End Sub

    Private Sub SaveXml_Click(sender As Object, e As EventArgs) Handles SaveXml.Click
        If isBlank() Then
            Dim xmlDeclaration As New XDeclaration("1.0", "UTF-8", "yes")
            Dim doc As XDocument =
                New XDocument(xmlDeclaration,
                              New XElement("Form",
                                           New XElement("name", "" & NameInput.Text),
                                           New XElement("age", "" & AgeInput.Text),
                                           New XElement("address", "" & AddressInput.Text)
                                          )
                              )

            doc.Save(PATH & ".xml")

            Status.ForeColor = Color.Green
            Status.Text = "Successfully saved as XML format."
        Else
            Status.ForeColor = Color.Red
            Status.Text = "Please fill up all inputs."
        End If
    End Sub

    Private Sub SaveJson_Click(sender As Object, e As EventArgs) Handles SaveJson.Click
        If isBlank() Then
            Dim inp As formInput = New formInput()
            inp.name = NameInput.Text
            inp.age = Convert.ToInt32(AgeInput.Text)
            inp.address = AddressInput.Text

            My.Computer.FileSystem.WriteAllText(PATH & "JSON.txt", JsonConvert.SerializeObject(inp, Newtonsoft.Json.Formatting.Indented), False)

            Status.ForeColor = Color.Green
            Status.Text = "Successfully saved as JSON format."
        Else
            Status.ForeColor = Color.Red
            Status.Text = "Please fill up all inputs."
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Status.ForeColor = Color.DarkOrange
        Status.Text = "Please Fill up the Form"
    End Sub

    Function isBlank() As Boolean
        If NameInput.Text = "" Or AgeInput.Text = "" Or AddressInput.Text = "" Then
            isBlank = False
        Else
            isBlank = True
        End If
    End Function
End Class
