''' <summary>
''' 既存クラスB
''' </summary>
Public Class ClassB

    ''' <summary>
    ''' 名称
    ''' </summary>
    ''' <returns></returns>
    Public Property Name As String

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <param name="name">名称</param>
    Public Sub New(Optional ByVal name As String = "AAA")
        Me.Name = name
    End Sub

End Class
