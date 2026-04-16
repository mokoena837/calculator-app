Imports System.CodeDom.Compiler

Public Class Form1

    Dim firstNum As Decimal
    Dim secondNum As Decimal
    Dim operations As Integer
    Dim operator_selector As Boolean = False
    Dim memory As Decimal = 0 ' 
    Const PERCENTAGE As Integer = 5
    Const MODULUS As Integer = 6
    Const M_PLUS As Integer = 7
    Const M_MINUS As Integer = 8 ' = M-



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNumber_Click(sender As Object, e As EventArgs) Handles btnOne.Click, btnTwo.Click, btnTr.Click, btnFour.Click, btnfive.Click, btnsix.Click, btnseven.Click, btn8.Click, btn9.Click, btnzero.Click
        Dim button As Button = CType(sender, Button)

        If txtinput.Text <> "0" Then
            txtinput.Text += button.Text
        Else
            txtinput.Text = button.Text
        End If
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtinput.Text = "0"
    End Sub

    Private Sub btndecimal_Click(sender As Object, e As EventArgs) Handles btndecimal.Click
        If Not (txtinput.Text.Contains(".")) Then
            txtinput.Text += "."
        End If
    End Sub

    Private Sub btnplus_Click(sender As Object, e As EventArgs) Handles btnplus.Click
        firstNum = txtinput.Text
        txtinput.Text = "0"
        operator_selector = True
        operations = 1 ' = +
    End Sub

    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        firstNum = txtinput.Text
        txtinput.Text = "0"
        operator_selector = True
        operations = 2 ' = -


    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        firstNum = txtinput.Text
        txtinput.Text = "0"
        operator_selector = True
        operations = 3 ' = *
    End Sub

    Private Sub btndevi_Click(sender As Object, e As EventArgs) Handles btndevi.Click
        firstNum = txtinput.Text
        txtinput.Text = "0"
        operator_selector = True
        operations = 4 ' = /
    End Sub


    Private Sub btnequal_Click(sender As Object, e As EventArgs) Handles btnequal.Click
        If operator_selector = True Then
            secondNum = txtinput.Text
            If operations = 1 Then
                txtinput.Text = firstNum + secondNum
            ElseIf operations = 2 Then
                txtinput.Text = firstNum - secondNum
            ElseIf operations = 3 Then
                txtinput.Text = firstNum * secondNum
            ElseIf operations = 7 Then
            ElseIf operations = 8 Then

            Else
                If secondNum = 0 Then
                    txtinput.Text = "error!"
                Else
                    txtinput.Text = firstNum / secondNum

                End If


                For k = 1 To 100
                    If operations = PERCENTAGE Then
                        txtinput.Text = (firstNum / secondNum) * k
                    End If
                Next

                If operations = MODULUS Then
                    txtinput.Text = firstNum Mod secondNum
                End If

                If operations = M_PLUS Then
                    memory += firstNum
                    txtinput.Text = memory.ToString()
                ElseIf operations = M_MINUS Then
                    memory -= firstNum
                txtinput.Text = memory.ToString()
            End If

            operator_selector = False
            End If
        End If
        operator_selector = False

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        firstNum = txtinput.Text
        txtinput.Text = "0"
        operator_selector = True
        operations = PERCENTAGE ' = %
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        firstNum = txtinput.Text
        txtinput.Text = "0"
        operator_selector = True
        operations = MODULUS ' = 
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        memory += Decimal.Parse(txtinput.Text)

        firstNum += txtinput.Text
        txtinput.Text = "0"
        operator_selector = True

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        memory -= Decimal.Parse(txtinput.Text)
        firstNum = txtinput.Text
        txtinput.Text = "0"
        operator_selector = True

    End Sub
End Class