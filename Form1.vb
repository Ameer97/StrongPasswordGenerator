Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Windows.Forms

Class Form1

    Public Property RealizedList As List(Of String)
    Public Property UnRealizedList As List(Of String)
    Public breakingCounter As Integer = 0

    Public Sub New()
        InitializeComponent()
        UnRealizedList = New List(Of String)()
    End Sub
    Private Sub button3_Click_1(sender As Object, e As EventArgs) Handles button3.Click
        Dim statics = New List(Of String) From {
            "Abc*e$g@",
            "GHIJKLMN",
            "12345678",
            "@!%$&*#!",
            "12345578",
            "vutsrqpo",
            "++$Re#%r",
            "12345679"
        }

        For Each password In statics
            Add(password)
        Next

        Proccess()
    End Sub

    Private Sub button1_Click_1(sender As Object, e As EventArgs) Handles button1.Click
        Add(textBox1.Text)
    End Sub

    Private Sub button2_Click_1(sender As Object, e As EventArgs) Handles button2.Click
        Proccess()
    End Sub


    Public Sub Add(ByVal NewPassword As String)
        Dim IsExist = UnRealizedList.Contains(NewPassword)

        If IsExist Then
            MessageBox.Show("Item Exist")
            Return
        End If

        If NewPassword.Length <> 8 Then
            MessageBox.Show("Item length not equel 8")
            Return
        End If

        UnRealizedList.Add(NewPassword)
        richTextBox1.Text += NewPassword & Environment.NewLine
        textBox1.Text = ""
    End Sub


    Public Sub Proccess()
        richTextBox2.Text = ""

        If UnRealizedList.Count < 2 Then
            MessageBox.Show("number of passwords array less that 2")
            Return
        End If

        RealizedList = New List(Of String)()
        ForUnRealizedItems()
        richTextBox2.Text += String.Join(Environment.NewLine, RealizedList)
        MessageBox.Show("Done with " & breakingCounter & " try")
    End Sub

    Public Sub FillRealizedPasswords()
        For Each password In UnRealizedList
            If IsRealized(password) Then RealizedList.Add(password)
        Next

        UnRealizedList = UnRealizedList.Except(RealizedList).ToList()
    End Sub

    Public Function IsRealized(ByVal Password As String) As Boolean
        Dim HaveDigit = Password.Where(Function(c) Char.IsDigit(c)).Any()
        Dim HaveLetter = Password.Where(Function(c) Char.IsLetter(c)).Any()
        Dim HaveSymbol = Password.Where(Function(c) Not Char.IsLetterOrDigit(c)).Any()
        Return HaveDigit AndAlso HaveLetter AndAlso HaveSymbol
    End Function

    Public Sub ForUnRealizedItems()
        breakingCounter += 1

        If breakingCounter > 7555 Then
            MessageBox.Show("Password Not Resolived")
            Return
        End If

        For i As Integer = 0 To 2 - 1
            CrossOver()
            FillRealizedPasswords()
            If UnRealizedList.Count < 2 Then Return
        Next

        For i As Integer = 0 To UnRealizedList.Count - 1 - 1
            UnRealizedList(i) = MutationProccess(UnRealizedList(i))
        Next

        ForUnRealizedItems()
    End Sub

    Public Sub CrossOver()
        Dim itteration As Integer = UnRealizedList.Count / 2
        Dim list = New List(Of String)()

        For i As Integer = 0 To itteration - 1 Step 2
            CrossOverProccess(i, i + 1)
        Next
    End Sub

    Public Sub CrossOverProccess(ByVal index As Integer, ByVal indexPlusOne As Integer)
        Dim password1 = UnRealizedList(index)
        Dim password2 = UnRealizedList(indexPlusOne)
        Dim temp = password1.Substring(2, 4)
        password1 = password1.Substring(0, 2) & password2.Substring(2, 4) & password1.Substring(6, 2)
        password2 = password2.Substring(0, 2) & temp & password2.Substring(6, 2)
        UnRealizedList(index) = password1
        UnRealizedList(indexPlusOne) = password2
    End Sub

    Public Function MutationProccess(ByVal Password As String) As String
        Dim HaveDigit = Password.Where(Function(c) Char.IsDigit(c)).Any()
        Dim HaveLetter = Password.Where(Function(c) Char.IsLetter(c)).Any()
        Dim HaveSymbol = Password.Where(Function(c) Not Char.IsLetterOrDigit(c)).Any()
        Dim PasswordArray = Password.ToCharArray()
        Dim random = New Random()
        Dim RandomIndex = random.Next(0, PasswordArray.Length - 1)
        Dim RandomValue As Integer = 0

        If Not HaveSymbol Then
            RandomValue = random.Next(32, 49)
        ElseIf Not HaveDigit Then
            RandomValue = random.Next(48, 57)
        ElseIf Not HaveLetter Then
            RandomValue = random.Next(65, 90)
        Else
            Return Password
        End If

        PasswordArray(RandomIndex) = Microsoft.VisualBasic.ChrW(RandomValue)
        Return String.Join("", PasswordArray)
    End Function

    
End Class
