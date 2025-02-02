Namespace TEI
    Public Class Edition
        Inherits XElement

        Sub New(children As IEnumerable(Of IChildOfEdition))
            MyBase.New(<div type="edition"><%= children %></div>)
        End Sub
    End Class
End Namespace