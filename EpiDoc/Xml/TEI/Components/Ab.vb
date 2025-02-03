Imports <xmlns="http://www.tei-c.org/ns/1.0">
Imports <xmlns:xi="http://www.w3.org/2001/XInclude">

Namespace TEINS
    Public Class Ab
        Inherits XElement
        Implements IChildOfEdition
        Implements ITextData


        Sub New(elems As IEnumerable(Of IChildOfAb))
            MyBase.New(<ab><%= elems %></ab>)
        End Sub
    End Class

End Namespace
