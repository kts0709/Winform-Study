## C# WinForm Study04 - Control Method

#### Control Method

> 
>
> - ***<u>Contains(Control)</u>***
>
> 지정된 컨트롤이 특정 컨트롤의 자식이면 `true`이고, 그렇지 않으면 `false`입니다.
>
> ```
> if(panel1.Contains(label1))
> {
>    label1.BringToFront();
> }
> ```
>
> 
>
> - ***<u>BringToFront()</u>***
>
> 컨트롤을 Z 순서의 맨 앞으로 가져옵니다.  >  해당 Control의 표시 순서를 가장 앞으로 지정
>
> ```
> Control obj = sender as Control;
> obj.BringToFront();
> ```
>
> 
>
> - ***<u>SendToBack()</u>***
>
> DesignerForm에서 해당 Control의 표시 순서를 가장 뒤로 지정
>
> ```
> Control obj = sender as Control;
> obj.SendToBack();
> ```
>
> 
>
> - ***<u>Contains(Control)</u>***
>
> 지정된 컨트롤이 특정 컨트롤의 자식이면 `true`이고, 그렇지 않으면 `false`입니다.
>
> ```
> if(panel1.Contains(label1))
> {
>    label1.BringToFront();
> }
> ```
>
> 
>
> #### Control 메서드 참고 사이트
>
> https://docs.microsoft.com/ko-kr/dotnet/api/system.windows.forms.control.accessibilitynotifyclients?view=net-5.0
>
> 
>
> 