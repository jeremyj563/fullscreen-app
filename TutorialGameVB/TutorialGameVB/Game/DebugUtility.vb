Imports System
Imports SFML.Graphics
Imports SFML.System

Namespace TutorialGame

    Module DebugUtility

        Public Const CONSOLE_FONT_PATH As String = "./Fonts/ARIAL.TTF"

        Public consoleFont As Font

        Sub LoadContent()
            consoleFont = New Font(CONSOLE_FONT_PATH)
        End Sub

        Sub DrawPerformanceData(ByVal gameLoop As GameLoop, ByVal fontColor As Color)

            If consoleFont Is Nothing Then Return
            Dim totalTimeElapsedStr As String = gameLoop.GameTime.TotalTimeElapsed.ToString("0.000")
            Dim deltaTimeStr As String = gameLoop.GameTime.DeltaTime.ToString("0.00000")
            Dim fps As Single = 1.0F / gameLoop.GameTime.DeltaTime
            Dim fpsStr As String = fps.ToString("0.00")
            Dim textA As Text = New Text(totalTimeElapsedStr, consoleFont, 14)
            textA.Position = New Vector2f(4.0F, 8.0F)
            textA.FillColor = fontColor
            Dim textB As Text = New Text(deltaTimeStr, consoleFont, 14)
            textB.Position = New Vector2f(4.0F, 28.0F)
            textB.FillColor = fontColor
            Dim textC As Text = New Text(fpsStr, consoleFont, 14)
            textC.Position = New Vector2f(4.0F, 48.0F)
            textC.FillColor = fontColor
            gameLoop.Window.Draw(textA)
            gameLoop.Window.Draw(textB)
            gameLoop.Window.Draw(textC)

        End Sub

    End Module

End Namespace