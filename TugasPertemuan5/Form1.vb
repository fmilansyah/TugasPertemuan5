Public Class Form1
    Dim a, b As String

    Public Sub ointment_data()
        ointment_list.Items.Add("A")
        ointment_list.Items.Add("2500")
        ointment_list.Items.Add("B")
        ointment_list.Items.Add("3500")
        ointment_list.Items.Add("C")
        ointment_list.Items.Add("4500")
        ointment_list.Items.Add("D")
        ointment_list.Items.Add("5500")
        ointment_list.Items.Add("E")
        ointment_list.Items.Add("6500")
        ointment_list.Items.Add("F")
        ointment_list.Items.Add("7500")
    End Sub

    Public Sub syrup_data()
        syrup_list.Items.Add("G")
        syrup_list.Items.Add("2500")
        syrup_list.Items.Add("H")
        syrup_list.Items.Add("3500")
        syrup_list.Items.Add("I")
        syrup_list.Items.Add("4500")
        syrup_list.Items.Add("J")
        syrup_list.Items.Add("5500")
        syrup_list.Items.Add("K")
        syrup_list.Items.Add("6500")
        syrup_list.Items.Add("L")
        syrup_list.Items.Add("7500")
    End Sub

    Public Sub tablet_data()
        tablet_list.Items.Add("M")
        tablet_list.Items.Add("2500")
        tablet_list.Items.Add("N")
        tablet_list.Items.Add("3500")
        tablet_list.Items.Add("O")
        tablet_list.Items.Add("4500")
        tablet_list.Items.Add("P")
        tablet_list.Items.Add("5500")
        tablet_list.Items.Add("Q")
        tablet_list.Items.Add("6500")
        tablet_list.Items.Add("R")
        tablet_list.Items.Add("7500")
    End Sub

    Public Sub item_verification()
        If ointment_list.SelectedIndex = 0 Then
            a = ointment_list.Items.Item(0)
            b = ointment_list.Items.Item(1)
        ElseIf ointment_list.SelectedIndex = 2 Then
            a = ointment_list.Items.Item(2)
            b = ointment_list.Items.Item(3)
        ElseIf ointment_list.SelectedIndex = 4 Then
            a = ointment_list.Items.Item(4)
            b = ointment_list.Items.Item(5)
        ElseIf ointment_list.SelectedIndex = 6 Then
            a = ointment_list.Items.Item(6)
            b = ointment_list.Items.Item(7)
        ElseIf ointment_list.SelectedIndex = 8 Then
            a = ointment_list.Items.Item(8)
            b = ointment_list.Items.Item(9)
        ElseIf ointment_list.SelectedIndex = 10 Then
            a = ointment_list.Items.Item(10)
            b = ointment_list.Items.Item(11)
        End If
    End Sub

    Public Sub syrup_verification()
        If syrup_list.SelectedIndex = 0 Then
            a = syrup_list.Items.Item(0)
            b = syrup_list.Items.Item(1)
        ElseIf syrup_list.SelectedIndex = 2 Then
            a = syrup_list.Items.Item(2)
            b = syrup_list.Items.Item(3)
        ElseIf syrup_list.SelectedIndex = 4 Then
            a = syrup_list.Items.Item(4)
            b = syrup_list.Items.Item(5)
        ElseIf syrup_list.SelectedIndex = 6 Then
            a = syrup_list.Items.Item(6)
            b = syrup_list.Items.Item(7)
        ElseIf syrup_list.SelectedIndex = 8 Then
            a = syrup_list.Items.Item(8)
            b = syrup_list.Items.Item(9)
        ElseIf syrup_list.SelectedIndex = 10 Then
            a = syrup_list.Items.Item(10)
            b = syrup_list.Items.Item(11)
        End If
    End Sub

    Public Sub tablet_verification()
        If tablet_list.SelectedIndex = 0 Then
            a = tablet_list.Items.Item(0)
            b = tablet_list.Items.Item(1)
        ElseIf tablet_list.SelectedIndex = 2 Then
            a = tablet_list.Items.Item(2)
            b = tablet_list.Items.Item(3)
        ElseIf tablet_list.SelectedIndex = 4 Then
            a = tablet_list.Items.Item(4)
            b = tablet_list.Items.Item(5)
        ElseIf tablet_list.SelectedIndex = 6 Then
            a = tablet_list.Items.Item(6)
            b = tablet_list.Items.Item(7)
        ElseIf tablet_list.SelectedIndex = 8 Then
            a = tablet_list.Items.Item(8)
            b = tablet_list.Items.Item(9)
        ElseIf tablet_list.SelectedIndex = 10 Then
            a = tablet_list.Items.Item(10)
            b = tablet_list.Items.Item(11)
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ointment_data()
        syrup_data()
        tablet_data()
    End Sub

    Private Sub ointment_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ointment_list.SelectedIndexChanged
        item_verification()
        If first_ointment_name.Text = "" Then
            Me.first_ointment_name.Text = a
            Me.first_ointment_price.Text = b
        ElseIf second_ointment_name.Text = "" Then
            Me.second_ointment_name.Text = a
            Me.second_ointment_price.Text = b
        ElseIf third_ointment_name.Text = "" Then
            Me.third_ointment_name.Text = a
            Me.third_ointment_price.Text = b
        Else
            MsgBox("Data Sudah Penuh")
        End If
        ointment_total.Text = Val(first_ointment_price.Text) + Val(second_ointment_price.Text) + Val(third_ointment_price.Text)
    End Sub

    Private Sub syrup_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles syrup_list.SelectedIndexChanged
        syrup_verification()
        If first_syrup_name.Text = "" Then
            Me.first_syrup_name.Text = a
            Me.first_syrup_price.Text = b
        ElseIf second_syrup_name.Text = "" Then
            Me.second_syrup_name.Text = a
            Me.second_syrup_price.Text = b
        ElseIf third_syrup_name.Text = "" Then
            Me.third_syrup_name.Text = a
            Me.third_syrup_price.Text = b
        Else
            MsgBox("Data Sudah Penuh")
        End If
        syrup_total.Text = Val(first_syrup_price.Text) + Val(second_syrup_price.Text) + Val(third_syrup_price.Text)
    End Sub

    Private Sub tablet_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tablet_list.SelectedIndexChanged
        tablet_verification()
        If first_tablet_name.Text = "" Then
            Me.first_tablet_name.Text = a
            Me.first_tablet_price.Text = b
        ElseIf second_tablet_name.Text = "" Then
            Me.second_tablet_name.Text = a
            Me.second_tablet_price.Text = b
        ElseIf third_tablet_name.Text = "" Then
            Me.third_tablet_name.Text = a
            Me.third_tablet_price.Text = b
        Else
            MsgBox("Data Sudah Penuh")
        End If
        tablet_total.Text = Val(first_tablet_price.Text) + Val(second_tablet_price.Text) + Val(third_tablet_price.Text)
        total.Text = Val(ointment_total.Text) + Val(syrup_total.Text) + Val(tablet_total.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Data Sudah Tersimpan")
    End Sub

End Class
