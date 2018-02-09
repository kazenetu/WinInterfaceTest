Imports System.Text

Public Class Form1

    ''' <summary>
    ''' 処理前データ：ClassAリスト
    ''' </summary>
    Private srClasscAList As New List(Of ClassA)

    ''' <summary>
    ''' 処理前データ：ClassBリスト
    ''' </summary>
    Private srClasscBList As New List(Of ClassB)

    ''' <summary>
    ''' ロードイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' 処理前データの設定
        srClasscAList.Add(New ClassA())
        srClasscAList.Add(New ClassA("new A"))
        srClasscBList.Add(New ClassB())
        srClasscBList.Add(New ClassB("new B"))

        ' 処理前データの表示
        Dim sb = New StringBuilder()
        For Each classA In srClasscAList
            sb.AppendFormat("{0}  [{1}]{2}", classA.GetType().Name, classA.Name, Environment.NewLine)
        Next
        For Each classB In srClasscBList
            sb.AppendFormat("{0}  [{1}]{2}", classB.GetType().Name, classB.Name, Environment.NewLine)
        Next

        Label1.Text = sb.ToString()

    End Sub

    ''' <summary>
    ''' サンプル1：既存クラスの内包クラス
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub InterfaceList_Click(sender As Object, e As EventArgs) Handles InterfaceList.Click

        ' 処理前データからInterfaceListを作成
        Dim intarfaceList As New List(Of ICommonClass)
        For Each classA In srClasscAList
            intarfaceList.Add(ClassUtility.Create(classA))
        Next
        For Each classB In srClasscBList
            intarfaceList.Add(ClassUtility.Create(classB))
        Next

        ' インターフェースのリストの内容を表示
        Dim sb = New StringBuilder()
        For Each classEx In intarfaceList
            sb.AppendFormat("{0}  [{1}]{2}", classEx.GetType().Name, classEx.Name, Environment.NewLine)
        Next
        MessageBox.Show(sb.ToString())

    End Sub

    ''' <summary>
    ''' サンプル2：既存クラス用ジェネクスクラス
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub genericList_Click(sender As Object, e As EventArgs) Handles genericList.Click

        ' 処理前データからInterfaceListを作成
        Dim intarfaceList As New List(Of ICommonClass)
        For Each classA In srClasscAList
            intarfaceList.Add(ClassEXFactory.Create(classA))
        Next
        For Each classB In srClasscBList
            intarfaceList.Add(ClassEXFactory.Create(classB))
        Next

        ' インターフェースのリストの内容を表示
        Dim sb = New StringBuilder()
        For Each genericInstance In intarfaceList
            sb.AppendFormat("{0}  [{1}]{2}", genericInstance.GetType().GenericTypeArguments(0).Name, genericInstance.Name, Environment.NewLine)
        Next
        MessageBox.Show(sb.ToString())

    End Sub

End Class
