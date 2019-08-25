Imports System.Windows.Forms

Public Class Form1
    Dim where = 0
    Dim where1 = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Private act As Boolean, mydom As New Random
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim Rect As Drawing.Rectangle = Screen.PrimaryScreen.WorkingArea
        If act Then
            Dim f1 As New Form1
            f1.Show()
            f1.Location = New Drawing.Point(mydom.Next(Rect.X, Rect.Width), mydom.Next(Rect.Y, Rect.Height))
        Else
            act = True
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Rect As Drawing.Rectangle = Screen.PrimaryScreen.WorkingArea
        If (Me.Location + Me.Size).X > Rect.Width Then
            'Me.Left = 0
            where = 1
        ElseIf (Me.Location + Me.Size).Y > Rect.Height Then
            'Me.Top = 0
            where1 = 1
        ElseIf Me.Location.X < Rect.X Then
            'Me.Left = Rect.Width
            where = 0
        ElseIf Me.Location.Y < Rect.Y Then
            'Me.Top = Rect.Height
            where1 = 0
            'Else
            'Me.Left += mydom.Next(1, 10)
            'Me.Top += mydom.Next(1, 10)
            'Me.Top += 10
        End If
        If where = 1 Then
            Me.Left -= 10
        Else
            Me.Left += 10
        End If
        If where1 = 1 Then
            Me.Top -= 10
        Else
            Me.Top += 10
        End If
    End Sub
End Class