Imports <xmlns="http://www.tei-c.org/ns/1.0">
Imports <xmlns:xi="http://www.w3.org/2001/XInclude">

Namespace TEINS
    Public Class Edition
        Inherits XElement
        Implements ITextData
        Implements IChildOfTEI

        Sub New(children As IEnumerable(Of IChildOfEdition))
            MyBase.New(<div type="edition"><%= children %></div>)
        End Sub

        Sub New(children As IEnumerable(Of IChildOfAb))
            MyBase.New(<div type="edition"><ab><%= children %></ab></div>)
        End Sub

    End Class
End Namespace