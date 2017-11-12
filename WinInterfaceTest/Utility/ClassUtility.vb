Public Class ClassUtility

    ''' <summary>
    ''' ClassA作成メソッド
    ''' </summary>
    ''' <param name="target">対象インスタンス</param>
    ''' <returns>ICommonClassインスタンス</returns>
    ''' <remarks>専用EXクラスを生成</remarks>
    Public Shared Function Create(ByRef target As ClassA) As ICommonClass
        Return New ClassAEX(target)
    End Function

    ''' <summary>
    ''' ClassB作成メソッド
    ''' </summary>
    ''' <param name="target">対象インスタンス</param>
    ''' <returns>ICommonClassインスタンス</returns>
    ''' <remarks>専用EXクラスを生成</remarks>
    Public Shared Function Create(ByRef target As ClassB) As ICommonClass
        Return New ClassBEX(target)
    End Function

    ''' <summary>
    ''' ClassA作成メソッド
    ''' </summary>
    ''' <param name="target">対象インスタンス</param>
    ''' <returns>ICommonClassインスタンス</returns>
    ''' <remarks>共通EXクラスを生成</remarks>
    Public Shared Function CreateEx(ByRef target As ClassA) As ICommonClass
        Return New ClassEx(Of ClassA)(target)
    End Function

    ''' <summary>
    ''' ClassB作成メソッド
    ''' </summary>
    ''' <param name="target">対象インスタンス</param>
    ''' <returns>ICommonClassインスタンス</returns>
    ''' <remarks>共通EXクラスを生成</remarks>
    Public Shared Function CreateEx(ByRef target As ClassB) As ICommonClass
        Return New ClassEx(Of ClassB)(target)
    End Function

End Class
