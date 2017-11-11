Imports System.Reflection

Public Class ClassEx(Of T)
    Implements ICommonClass

    Private Const PropertyName As String = "Name"

    ''' <summary>
    ''' 対象オブジェクト
    ''' </summary>
    Protected target As T

    ''' <summary>
    ''' プロパティリスト
    ''' </summary>
    Protected properties As New Dictionary(Of String, PropertyInfo)

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <param name="target">対象クラス</param>
    Public Sub New(ByRef target As T)
        Me.target = target

        ' 必須プロパティ名リスト
        Dim propertyNames = New List(Of String)({PropertyName})

        ' プロパティを取得
        Dim propertiesInfos = target.GetType().GetProperties()
        For Each propertyInfo In propertiesInfos
            If propertyNames.Contains(propertyInfo.Name) Then
                properties.Add(propertyInfo.Name, propertyInfo)
                propertyNames.Remove(propertyInfo.Name)
            End If
        Next
    End Sub

    ''' <summary>
    ''' 名称
    ''' </summary>
    Public Property Name As String Implements ICommonClass.Name
        Get
            If properties.ContainsKey(PropertyName) Then
                Return properties(PropertyName).GetValue(target).ToString()
            End If

            Return String.Empty
        End Get
        Set(value As String)
            If properties.ContainsKey(PropertyName) Then
                properties(PropertyName).SetValue(target, value)
            End If
        End Set
    End Property

End Class
