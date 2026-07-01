/*問題4（List）

次のリストがあります。

List<string> names = new List<string>
{
    "田中",
    "佐藤",
    "鈴木"
};

以下を実装してください。

「高橋」を追加
「佐藤」を削除
全件表示

最終結果

田中
鈴木
高橋*/

using System;
using System.Collections.Generic;

class program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>
{
    "田中",
    "佐藤",
    "鈴木"
};
        Console.WriteLine("初期リスト:");
        DisplayNames(names);
        AddName(names, "高橋");
        RemoveName(names, "佐藤");
        Console.WriteLine("\n最終リスト:");
        DisplayNames(names);
    }


    static void AddName(List<string> names, string name)
    {
        names.Add(name);
    }
    static void RemoveName(List<string> names, string name)
    {
        names.Remove(name);
    }

    static void DisplayNames(List<string> names)
    {
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}