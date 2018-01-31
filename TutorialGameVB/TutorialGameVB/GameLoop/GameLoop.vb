Imports System
Imports SFML.Graphics
Imports SFML.Window
Imports SFML.System

Namespace TutorialGame

    Public MustInherit Class GameLoop

        Public Const TARGET_FPS As Integer = 60

        Public Const TIME_UNTIL_UPDATE As Single = 1.0F / TARGET_FPS

        Public Property Window As RenderWindow

        Public Property GameTime As GameTime

        Public Property WindowClearColor As Color

        Protected Sub New(windowWidth As UInteger, windowHeight As UInteger, windowTitle As String, windowClearColor As Color, windowStyle As Styles)
            Me.WindowClearColor = windowClearColor
            Me.Window = New RenderWindow(New VideoMode(windowWidth, windowHeight), windowTitle, windowStyle)
            Me.GameTime = New GameTime()
            AddHandler Window.Closed, AddressOf WindowClosed
        End Sub

        Public Sub Run()
            LoadContent()
            Initialize()
            Dim totalTimeBeforeUpdate As Single = 0F
            Dim previousTimeElapsed As Single = 0F
            Dim deltaTime As Single = 0F
            Dim totalTimeElapsed As Single = 0F
            Dim clock As Clock = New Clock()
            While Window.IsOpen

                Window.DispatchEvents()
                totalTimeElapsed = clock.ElapsedTime.AsSeconds()
                deltaTime = totalTimeElapsed - previousTimeElapsed
                previousTimeElapsed = totalTimeElapsed
                totalTimeBeforeUpdate += deltaTime

                If totalTimeBeforeUpdate >= TIME_UNTIL_UPDATE Then
                    GameTime.Update(totalTimeBeforeUpdate, totalTimeElapsed)
                    totalTimeBeforeUpdate = 0F
                    Update(GameTime)
                    Window.Clear(WindowClearColor)
                    Draw(GameTime)
                    Window.Display()
                End If

            End While
        End Sub

        Public MustOverride Sub LoadContent()

        Public MustOverride Sub Initialize()

        Public MustOverride Sub Update(ByVal gameTime As GameTime)

        Public MustOverride Sub Draw(ByVal gameTime As GameTime)

        Private Sub WindowClosed(ByVal sender As Object, ByVal e As EventArgs)
            Window.Close()
        End Sub

    End Class

End Namespace