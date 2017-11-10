Public Class ClassBEX
    Implements ICommonClass

    Private target As ClassB = Nothing

    Public Sub New(ByRef target As ClassB)
        Me.target = target
    End Sub

    Public Property Name Implements ICommonClass.Name
        Get
            Return target.Name
        End Get
        Set(value)
            target.Name = value
        End Set
    End Property
End Class
