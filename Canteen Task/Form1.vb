Public Class Form1
    Structure Clients
        Dim name As String
        Dim balance As Single
    End Structure

    Dim student(30) As Clients
    Dim count As Int16 = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        count = 0
        FileSystem.FileOpen(1, "Canteen.txt", OpenMode.Input)
        While Not EOF(1)
            student(count).name = FileSystem.LineInput(1).ToLower()
            student(count).balance = Convert.ToSingle(FileSystem.LineInput(1))
            count += 1
        End While
        FileSystem.FileClose(1)
        count -= 1
        Display()
    End Sub

    Private Sub Display()
        Lstbx.Items.Clear()
        Lstbx.Items.Add("List of Students and Balance")
        For i = 0 To count
            Lstbx.Items.Add(student(i).name + " : " + Convert.ToString(student(i).balance))
        Next
    End Sub

    Private Sub Btn_Buy_Click(sender As Object, e As EventArgs) Handles Btn_Buy.Click

        Dim name As String = Txt_Name_Buy.Text.ToLower()
        Dim amount As Single = Convert.ToSingle(Txt_Total_Buy.Text)

        For i = 0 To count
            If name = student(i).name Then
                If (student(i).balance - amount) < 0 Then
                    MsgBox("Cannot Afford Item")
                Else
                    student(i).balance -= amount
                End If
                Exit For
            End If
        Next
        Display()

    End Sub
End Class
