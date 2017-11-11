Public Class ClassAEX
    Implements ICommonClass

    Private target As ClassA = Nothing

    Public Sub New(ByRef target As ClassA)
        Me.target = target
    End Sub

    Public Property Name As String Implements ICommonClass.Name
        Get
            Return target.Name
        End Get
        Set(value As String)
            target.Name = value
        End Set
    End Property
End Class
