Public Class Form1

    Structure Clients
        Dim name As String
        Dim balance As Single
    End Structure

    Dim student(30) As Clients
    Dim count As Int16 = 0

    Private Sub Display()
        Lstbx.Items.Clear()
        Lstbx.Items.Add("List of Students and Balance")
        For i = 0 To count
            Lstbx.Items.Add(student(i).name + " : " + Convert.ToString(student(i).balance))
        Next
    End Sub

    Private Sub Array_To_File()
        FileSystem.FileOpen(1, "Canteen.txt", OpenMode.Output)
        For i = 0 To count
            FileSystem.PrintLine(1, student(i).name)
            FileSystem.WriteLine(1, student(i).balance)
        Next
        FileSystem.FileClose()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        count = 0
        FileSystem.FileOpen(1, "Canteen.txt", OpenMode.Input)
        While Not EOF(1)
            student(count).name = StrConv(FileSystem.LineInput(1), vbProperCase)
            student(count).balance = Convert.ToSingle(FileSystem.LineInput(1))
            count += 1
        End While
        FileSystem.FileClose(1)
        count -= 1
        Display()
    End Sub

    Private Sub Btn_Buy_Click(sender As Object, e As EventArgs) Handles Btn_Buy.Click

        Dim name As String = StrConv(Txt_Name_Buy.Text, vbProperCase)
        Dim amount As Single = StrConv(Convert.ToSingle(Txt_Total_Buy.Text), vbProperCase)
        Dim flag As Boolean = False

        For i = 0 To count
            If name = student(i).name Then
                If (student(i).balance - amount) < 0 Then
                    MsgBox("Cannot Afford Item")
                    flag = True
                Else
                    student(i).balance -= amount
                    Display()
                    MsgBox("Purchase sucessful!")
                    Array_To_File()
                    flag = True
                End If
                Exit For
            End If
        Next
        If flag = False Then
            MsgBox("ERROR: User not registered.")
        End If
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click

        Dim name As String = StrConv(Txt_Name_Money.Text, vbProperCase)
        Dim amount As Single = StrConv(Convert.ToSingle(Txt_Amount_Money.Text), vbProperCase)
        Dim flag As Boolean = False

        For i = 0 To count
            If name = student(i).name Then
                student(i).balance += amount
                flag = True
                Display()
                MsgBox("Amount added to account!")
                Array_To_File()
                Exit For
            End If
        Next
        If flag = False Then
            MsgBox("ERROR: User not registered.")
        End If
    End Sub

    Private Sub Btn_AddUser_Click(sender As Object, e As EventArgs) Handles Btn_AddUser.Click

        Dim name As String = StrConv(Txtbx_AddUser_Name.Text, vbProperCase)
        Dim amount As Single = StrConv(Convert.ToSingle(TxtBx_AddUser_StartBal.Text), vbProperCase)
        Dim flag As Boolean = False

        For i = 0 To count
            If name = student(i).name Then
                MsgBox("User is already added.")
                flag = True
            End If
        Next
        If flag = False Then
            count += 1
            student(count).name = name
            student(count).balance = amount
            Display()
            Array_To_File()
            MsgBox("User sucessfully added!")
        End If

    End Sub
End Class
