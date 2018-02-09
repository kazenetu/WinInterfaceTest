''' <summary>
''' 内包クラス生成ユーティリティ
''' </summary>
''' <remarks>サンプル1：既存クラスの内包クラス用</remarks>
Public Class ClassUtility

    ''' <summary>
    ''' ClassA内包クラス作成メソッド
    ''' </summary>
    ''' <param name="target">対象インスタンス</param>
    ''' <returns>ICommonClassインスタンス</returns>
    ''' <remarks>専用EXクラスを生成</remarks>
    Public Shared Function Create(ByRef target As ClassA) As ICommonClass
        Return New ClassAEX(target)
    End Function

    ''' <summary>
    ''' ClassB内包クラス作成メソッド
    ''' </summary>
    ''' <param name="target">対象インスタンス</param>
    ''' <returns>ICommonClassインスタンス</returns>
    ''' <remarks>専用EXクラスを生成</remarks>
    Public Shared Function Create(ByRef target As ClassB) As ICommonClass
        Return New ClassBEX(target)
    End Function

End Class
