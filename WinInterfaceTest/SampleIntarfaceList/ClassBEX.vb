''' <summary>
''' ClassB内包クラス
''' </summary>
Public Class ClassBEX
    Implements ICommonClass

    Private target As ClassB = Nothing

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <param name="target">既存クラス</param>
    Public Sub New(ByRef target As ClassB)
        Me.target = target
    End Sub

    ''' <summary>
    ''' 名前プロパティ
    ''' </summary>
    ''' <returns>名前</returns>
    Public Property Name As String Implements ICommonClass.Name
        Get
            Return target.Name
        End Get
        Set(value As String)
            target.Name = value
        End Set
    End Property
End Class
