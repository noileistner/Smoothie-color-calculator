Imports System.Runtime.Remoting.Messaging

Public Class Form1

    Enum FruitColor
        Blue
        Orange
        Red
        Green
        Yellow
    End Enum

    Structure Fruit
        Dim name As String
        Dim color As FruitColor
    End Structure

    Dim lsFruits As List(Of Fruit) = New List(Of Fruit)

    Dim Fruit1 As Fruit
    Dim Fruit2 As Fruit

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox2.Visible = False
        btnSelectFruit2.Visible = False
        btnCalculateSmoothieColor.Visible = False

        lsFruits.Add(New Fruit With {.name = "Apple", .color = FruitColor.Green})
        lsFruits.Add(New Fruit With {.name = "Strawberry", .color = FruitColor.Red})
        lsFruits.Add(New Fruit With {.name = "Kiwi", .color = FruitColor.Green})
        lsFruits.Add(New Fruit With {.name = "Mango", .color = FruitColor.Orange})
        lsFruits.Add(New Fruit With {.name = "Orange", .color = FruitColor.Orange})

        For Each fruit In lsFruits
            ListBox1.Items.Add(fruit.name)
        Next
    End Sub

    Private Function FindFruit(name As String) As Fruit
        Dim predicate As Predicate(Of Fruit)
        predicate = Function(fruit As Fruit)
                        Return fruit.name = name
                    End Function

        Return lsFruits.Find(predicate)
    End Function


    Private Sub btnSelectFruit1_Click(sender As Object, e As EventArgs) Handles btnSelectFruit1.Click
        Fruit1 = FindFruit(ListBox1.SelectedItem)

        MsgBox("You like " & Fruit1.name)
        ListBox2.Visible = True
        btnSelectFruit2.Visible = True

        ListBox2.Items.Clear()

        For Each fruit In lsFruits
            If Not Fruit1.Equals(fruit) Then
                ListBox2.Items.Add(fruit.name)
            End If
        Next
    End Sub

    Private Sub btnSelectFruit2_Click(sender As Object, e As EventArgs) Handles btnSelectFruit2.Click
        Fruit2 = FindFruit(ListBox2.SelectedItem)

        MsgBox("You also like " & Fruit2.name)
        btnCalculateSmoothieColor.Visible = True

    End Sub

    Private Sub btnCalculateSmoothieColor_Click(sender As Object, e As EventArgs) Handles btnCalculateSmoothieColor.Click
        Dim Expresion As String
        Expresion = "Your 2 fruits' smoothie would be the color "

        If Fruit1.color = FruitColor.Orange And Fruit2.color = FruitColor.Green Then
            MsgBox(Expresion & "light brown")
        ElseIf Fruit1.color = FruitColor.Orange And Fruit2.color = FruitColor.Orange Then
            MsgBox(Expresion & "Orange")
        ElseIf Fruit1.color = FruitColor.Green And Fruit2.color = FruitColor.Orange Then
            MsgBox(Expresion & "light brown")
        ElseIf Fruit1.color = FruitColor.Green And Fruit2.color = FruitColor.Orange Then
            MsgBox(Expresion & "light brown")
        ElseIf Fruit1.color = FruitColor.Orange And Fruit2.color = FruitColor.Orange Then
            MsgBox(Expresion & "Orange")
        ElseIf Fruit1.color = FruitColor.Orange And Fruit2.color = FruitColor.Green Then
            MsgBox(Expresion & "light brown")
        ElseIf Fruit1.color = FruitColor.Orange And Fruit2.color = FruitColor.Red Then
            MsgBox(Expresion & "Fire color")
        ElseIf Fruit1.color = FruitColor.Green And Fruit2.color = FruitColor.Red Then
            MsgBox(Expresion & "brown")
        ElseIf Fruit1.color = FruitColor.Red And Fruit2.color = FruitColor.Green Then
            MsgBox(Expresion & "brown")
        ElseIf Fruit1.color = FruitColor.Red And Fruit2.color = FruitColor.Orange Then
            MsgBox(Expresion & "Fire color")
        ElseIf Fruit1.color = FruitColor.Green And Fruit2.color = FruitColor.Green Then
            MsgBox(Expresion & "green")

        End If
    End Sub
End Class
