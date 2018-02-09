# WinInterfaceTest
異なるクラスのリストをインターフェースのリストに統一できるかテスト

## はじめに
「メソッドはほぼ同じなのにスーパークラスやインターフェースで共通化されていない」なんてことありますよね？  
おまけに「既存クラスは変更不可」なんてこともありますよね？  

今回は既存クラスを修正することなく何とか共通化してみます。

## 実現方法
既存クラスはClassA、ClassBの二種類

### サンプル1：既存クラスの内包クラス
* 実装概要
  1. 既存クラスを内包するクラス(ClassAEX、ClassBEX)をそれぞれ作成  
共通インターフェース(ICommonClass)を継承する  
コンストラクタは既存クラスをパラメータとする  
共通プロパティ(Name)を実装
  1. 内包クラス生成ユーティリティ(ClassUtility)を作成する  
内包クラスのインスタンスを生成し  
共通インターフェース(ICommonClass)のインスタンスとして返す
* メリット
  * 既存クラスのプロパティやメソッドの名前が異なる場合でも既存クラス単位の内包クラスと共通インターフェースで吸収することができる
* デメリット
  * 既存クラス単位で内包クラスを作成する必要がある
  * 内包クラスが今後増加する場合、内包クラス生成ユーティリティのメソッドも対応させる必要がある。

### サンプル2：既存クラス用ジェネクスクラス
* 実装概要
  1. インターフェース(ICommonClass)を継承する既存クラス用ジェネクスクラス(ClassEx)を作成  
Reflectionを使って既存クラスの対象プロパティを値を取得するメソッドを実装
  1. ClassEx作成ファクトリクラス(ClassEXFactory)を作成  
既存クラスをパラメータとしてジェネクスクラスのインスタンスを生成  
共通インターフェース(ICommonClass)のインスタンスとして返す
* メリット
  * 既存クラスが今後増加する場合でもファクトリクラスのメソッドを増やすことで対応できる
  * 利用するだけならシンプル
* デメリット
  * 既存クラスのプロパティやメソッドの名前が一致していない場合、利用しづらい  
  もしくはファクトリクラスのメリットがない
  * Reflectionを使っているためファクトリクラスが多少わかりづらい

