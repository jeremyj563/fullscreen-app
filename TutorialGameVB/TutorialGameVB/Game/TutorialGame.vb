Imports System
Imports SFML.Audio
Imports SFML.Graphics
Imports SFML.Window
Imports SFML.System

Namespace TutorialGame

    Public Class TutorialGame
        Inherits GameLoop

        Public Const WINDOW_WIDTH As UInteger = 640

        Public Const WINDOW_HEIGHT As UInteger = 480

        Public Const WINDOW_TITLE As String = "Tutorial Game"

        Public Shared WINDOW_COLOR As Color = Color.Black

        Public Shared WINDOW_STYLE As Styles = Styles.Default

        Public Sub New()
            MyBase.New(WINDOW_WIDTH, WINDOW_HEIGHT, WINDOW_TITLE, WINDOW_COLOR, WINDOW_STYLE)
        End Sub

        Public Overrides Sub LoadContent()
            DebugUtility.LoadContent()
        End Sub

        Public Overrides Sub Initialize()
        End Sub

        Public Overrides Sub Update(ByVal gameTime As GameTime)
        End Sub

        Public Overrides Sub Draw(ByVal gameTime As GameTime)
            DebugUtility.DrawPerformanceData(Me, Color.White)
        End Sub
    End Class

End Namespace