Public Class ClassUtility

    Public Shared Function Create(ByRef target As ClassA) As ICommonClass
        Return New ClassAEX(target)
    End Function

    Public Shared Function Create(ByRef target As ClassB) As ICommonClass
        Return New ClassBEX(target)
    End Function

    Public Shared Function CreateEx(ByRef target As ClassA) As ICommonClass
        Return New ClassEx(Of ClassA)(target)
    End Function
    Public Shared Function CreateEx(ByRef target As ClassB) As ICommonClass
        Return New ClassEx(Of ClassB)(target)
    End Function

End Class
