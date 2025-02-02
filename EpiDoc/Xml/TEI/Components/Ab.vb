Namespace TEI
    Public Class Ab
        Inherits XElement
        Implements IChildOfEdition
        Sub New(elems As IEnumerable(Of IChildOfAb))
            MyBase.New(<ab><%= elems %></ab>)
        End Sub
    End Class

End Namespace
