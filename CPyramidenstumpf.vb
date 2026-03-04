Public Class CPyramidenstumpf
    Inherits CQuadrat

    Private _obereKante As Double
    Private _hoehe As Double

    Public Sub New(unten As Double, oben As Double, h As Double)
        MyBase.New(unten)
        ObereKante = oben
        Hoehe = h
    End Sub

    Public Property ObereKante As Double
        Get
            Return _obereKante
        End Get
        Set(value As Double)
            If value > 0 Then
                _obereKante = value
            Else
                _obereKante = 1
            End If
        End Set
    End Property

    Public Property Hoehe As Double
        Get
            Return _hoehe
        End Get
        Set(value As Double)
            If value > 0 Then
                _hoehe = value
            Else
                _hoehe = 1
            End If
        End Set
    End Property

    Public Function BerechneVolumen() As Double
        Dim ergebnis As Double
        ergebnis = (Hoehe / 3) * (_kantenlaenge * _kantenlaenge + _obereKante * _obereKante + _kantenlaenge * _obereKante)
        Return ergebnis
    End Function

End Class
