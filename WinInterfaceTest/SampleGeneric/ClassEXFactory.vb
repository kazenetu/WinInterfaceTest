''' <summary>
''' ClassEx作成ファクトリクラス
''' </summary>
''' <remarks>サンプル2：既存クラス用ジェネクスクラス用</remarks>
Public Class ClassEXFactory

    ''' <summary>
    ''' ClassA作成メソッド
    ''' </summary>
    ''' <param name="target">対象インスタンス</param>
    ''' <returns>ICommonClassインスタンス</returns>
    ''' <remarks>共通EXクラスを生成</remarks>
    Public Shared Function Create(ByRef target As ClassA) As ICommonClass
        Return New ClassEx(Of ClassA)(target)
    End Function

    ''' <summary>
    ''' ClassB作成メソッド
    ''' </summary>
    ''' <param name="target">対象インスタンス</param>
    ''' <returns>ICommonClassインスタンス</returns>
    ''' <remarks>共通EXクラスを生成</remarks>
    Public Shared Function Create(ByRef target As ClassB) As ICommonClass
        Return New ClassEx(Of ClassB)(target)
    End Function

End Class
