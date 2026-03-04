Public Class CQuadrat

    Protected _kantenlaenge As Double

    Public Sub New()
        _kantenlaenge = 0
    End Sub

    Public Sub New(k As Double)
        Kantenlaenge = k
    End Sub

    Public Property Kantenlaenge As Double
        Get
            Return _kantenlaenge
        End Get
        Set(value As Double)
            If value > 0 Then
                _kantenlaenge = value
            Else
                _kantenlaenge = 1
            End If
        End Set
    End Property

    Public Function BerechneFlaeche(a As Double) As Double
        Return a * a
    End Function

End Class
