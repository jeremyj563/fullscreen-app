Imports System

Namespace TutorialGame

    Public Class GameTime

        Private _deltaTime As Single = 0F

        Private _timeScale As Single = 1.0F

        Public Property TimeScale As Single
            Get
                Return _timeScale
            End Get

            Set(ByVal value As Single)
                _timeScale = value
            End Set
        End Property

        Public Property DeltaTime As Single
            Get
                Return _deltaTime * _timeScale
            End Get

            Private Set(ByVal value As Single)
                _deltaTime = value
            End Set
        End Property

        Public ReadOnly Property DeltaTimeUnscaled As Single
            Get
                Return _deltaTime
            End Get
        End Property

        Public Property TotalTimeElapsed As Single

        Public Sub New()
        End Sub

        Public Sub Update(ByVal deltaTime As Single, ByVal totalTimeElapsed As Single)
            _deltaTime = deltaTime
            totalTimeElapsed = totalTimeElapsed
        End Sub
    End Class

End Namespace