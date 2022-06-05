Public Class ShowGraph
    'these are noted as field variables
    Dim intXOrigin, intYOrigin As Integer
    Dim sngAmp As Single
    Dim blnPlot As Boolean = False
    Dim plotchoice As Integer = 0
    Private Sub drawAxes(ByVal g As Graphics)
        intXOrigin = picDraw.Width \ 2 'calculate the x-origin, hlaf of PicDraw width
        intYOrigin = picDraw.Height \ 2 'calculate the y-origin, hlaf of PicDraw height
        Dim myfont As New Font("Arial", 8, FontStyle.Regular)
        g.Clear(Color.Black)
        g.DrawLine(Pens.Gray, 0, intYOrigin, picDraw.Width, intYOrigin) 'draw x-axis
        g.DrawLine(Pens.Gray, intXOrigin, 0, intXOrigin, picDraw.Height) 'draw y-axis
        g.DrawString("(0,0)", myfont, Brushes.Green, intXOrigin, intYOrigin) 'add label to origin

        If plotchoice = 6 Then
            'displays program info and general instruction
            g.DrawString("This program plots the general function:" & vbNewLine & "y = Asin(ø x π / 180)" & vbNewLine & "y = Acos(ø x π / 180)" &
                vbNewLine & "y = Atan(ø x π / 180)" &
                vbNewLine & "Please input value for the Amplitude" & vbNewLine & "to the respective textbox", myfont, Brushes.Green, 0, 0)
        Else
            If plotchoice = 1 Then
                g.DrawString("graph of the function" & vbNewLine & "y = " & sngAmp & "sin(ø x π / 180)",
                        myfont, Brushes.Coral, 0, 0)
            End If
            If plotchoice = 2 Then
                g.DrawString("graph of the function" & vbNewLine & "y = " & sngAmp & "cos(ø x π / 180)",
                        myfont, Brushes.DodgerBlue, 0, 0)
            End If
            If plotchoice = 3 Then
                g.DrawString("graph of the function" & vbNewLine & "y = " & sngAmp & "tan(ø x π / 180)",
                        myfont, Brushes.ForestGreen, 0, 0)
            End If
            If plotchoice = 4 Then
                g.DrawString("graph of the functions" & vbNewLine & "y = " & sngAmp & "sin(ø x π / 180)",
                        myfont, Brushes.Coral, 0, 0)
                g.DrawString(vbNewLine & vbNewLine & "y = " & sngAmp & "cos(ø x π / 180)",
                        myfont, Brushes.DodgerBlue, 0, 0)
                g.DrawString(vbNewLine & vbNewLine & vbNewLine & "y = " & sngAmp & "tan(ø x π / 180)",
                        myfont, Brushes.ForestGreen, 0, 0)
            End If
        End If

    End Sub

    Private Sub btnPlot_Click(sender As Object, e As EventArgs) Handles btnPlot.Click
        Try
            plotchoice = ChooseGraph.ShowDialog()
            sngAmp = txtAmplitude.Text
            blnPlot = True
            picDraw.Refresh()
        Catch ex As Exception 'Something went horribly wrong
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'resets everything
        blnPlot = False
        picDraw.Refresh()
        txtAmplitude.Clear()
        txtAmplitude.Focus()
    End Sub

    Private Sub picDraw_Paint(sender As Object, e As PaintEventArgs) Handles picDraw.Paint
        Dim gPaint As Graphics = e.Graphics 'creates graphic object
        Call drawAxes(gPaint) 'draw Axes
        Dim sngStep As Single = 0.2
        Dim sngY As Single
        If plotchoice = 1 Or plotchoice = 4 Then
                    For sngX As Single = 0 To (picDraw.Width / 2) Step sngStep
                        sngY = (sngAmp) * Math.Sin(sngX * (Math.PI / 180))
                        gPaint.DrawRectangle(Pens.Coral, intXOrigin + sngX, intYOrigin - sngY, 1, 1)
                        gPaint.DrawRectangle(Pens.Coral, intXOrigin - sngX, intYOrigin + sngY, 1, 1)
                    Next
                End If
        If plotchoice = 2 Or plotchoice = 4 Then
            For sngX As Single = 0 To (picDraw.Width / 2) Step sngStep
                sngY = (sngAmp) * Math.Cos(sngX * (Math.PI / 180))
                gPaint.DrawRectangle(Pens.DodgerBlue, intXOrigin + sngX, intYOrigin - sngY, 1, 1)
                gPaint.DrawRectangle(Pens.DodgerBlue, intXOrigin - sngX, intYOrigin - sngY, 1, 1)
            Next
        End If
        If plotchoice = 3 Or plotchoice = 4 Then
            For sngX As Single = 0 To (picDraw.Width / 2) Step sngStep
                sngY = (sngAmp) * Math.Tan(sngX * (Math.PI / 180))
                gPaint.DrawRectangle(Pens.ForestGreen, intXOrigin + sngX, intYOrigin + sngY, 1, 1)
                gPaint.DrawRectangle(Pens.ForestGreen, intXOrigin - sngX, intYOrigin - sngY, 1, 1)
            Next
        End If
        If plotchoice = 6 Then
                    gPaint.Clear(Color.FromArgb(247, 247, 210)) 'clearing of all graphics
                End If
                Call drawAxes(gPaint) 'This enables the axis to be drawn at all times

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End 'ends the program
    End Sub


    Private Sub ShowGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picDraw.BackColor = Color.FromArgb(247, 247, 210)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        picDraw.Refresh() 'for resizing
    End Sub


End Class
