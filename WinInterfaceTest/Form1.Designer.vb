<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InterfaceList = New System.Windows.Forms.Button()
        Me.genericList = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'InterfaceList
        '
        Me.InterfaceList.Location = New System.Drawing.Point(38, 163)
        Me.InterfaceList.Name = "InterfaceList"
        Me.InterfaceList.Size = New System.Drawing.Size(188, 23)
        Me.InterfaceList.TabIndex = 2
        Me.InterfaceList.Text = "サンプル1：既存クラスの内包クラス"
        Me.InterfaceList.UseVisualStyleBackColor = True
        '
        'genericList
        '
        Me.genericList.Location = New System.Drawing.Point(243, 163)
        Me.genericList.Name = "genericList"
        Me.genericList.Size = New System.Drawing.Size(220, 23)
        Me.genericList.TabIndex = 3
        Me.genericList.Text = "サンプル2：既存クラス用ジェネクスクラス"
        Me.genericList.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 414)
        Me.Controls.Add(Me.genericList)
        Me.Controls.Add(Me.InterfaceList)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents InterfaceList As Button
    Friend WithEvents genericList As Button
End Class
