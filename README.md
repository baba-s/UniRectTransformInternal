# UniRectTransformInternal

RectTransform の internal な機能にアクセスできるようにするパッケージ

## 使用例

```cs
using Kogane;
using UnityEditor;
using UnityEngine;

public static class Example
{
    [MenuItem( "Tools/Hoge" )]
    private static void Hoge()
    {
        // 「Some values driven by XXXX」の状態を取得
        var rectTransform    = ( RectTransform ) Selection.activeTransform;
        var drivenProperties = RectTransformInternal.GetDrivenProperties( rectTransform );

        Debug.Log( drivenProperties );
    }
}
```
