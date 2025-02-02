Namespace TEI
    Public Class Name
        Inherits XElement
        Implements IChildOfAb
        Sub New(w As W)
            MyBase.New(<name><%= w %></name>)
        End Sub
    End Class
End Namespace

