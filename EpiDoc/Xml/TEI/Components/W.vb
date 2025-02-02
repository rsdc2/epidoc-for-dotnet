Namespace TEI
    Public Class W
        Inherits XElement
        Implements IChildOfAb

        Sub New(text As String)
            MyBase.New(<w><%= text %></w>)
        End Sub

    End Class
End Namespace