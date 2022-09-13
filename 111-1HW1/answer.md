# 第1次作業-作業-HW1
>
>學號：109111103
><br/>
>姓名：曾昱翔
><br/>
>作業撰寫時間：90 (mins，包含程式撰寫時間)
><br/>
>最後撰寫文件日期：2022/9/13
>

本份文件包含以下主題：(至少需下面兩項，若是有多者可以自行新增)
- [x]說明內容
- [x]個人認為完成作業須具備觀念

## 說明程式與內容

開始寫說明，該說明需說明想法，
並於之後再對上述想法的每一部分將程式進一步進行展現，
若需引用程式區則使用下面方法，
若為.cs檔內程式除了於敘述中需註明檔案名稱外，
還需使用語法` ```csharp 程式碼 ``` `，
下段程式碼則為使用後結果：

首先在Page_Load內輸出"Hallo App"，然後再把button拉進body裡面，之後在把button的ID改成btn_Show，再拉一個label進來body裡面，之後清空label裡的文字
，最後把button的事件改成按下去把label文字變成"Hallo Button"就好了。
```csharp
protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hallo App");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Hallo Button";
        }
```

若要於內文中標示部分.aspx檔，則使用以下標籤` ```html 程式碼 ``` `，
下段程式碼則為使用後結果：

```html
<%@ Page Language="C#" AutoEventWireup="true" ...>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" ...>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
```


## 個人認為完成作業須具備觀念

開始寫說明，需要說明本次作業個人覺得需學會那些觀念 (需寫成文章，需最少50字，
並且文內不得有你、我、他三種文字)

這次的作業應該要先學會VS如何複製git hub的存放庫，否則後面都不用做了，
再來就是要知道C#中輸出文字的語法，只要知道怎麼輸出文字，大概就完成這次作業的8成了。