Imports <xmlns="http://www.tei-c.org/ns/1.0">
Imports <xmlns:xi="http://www.w3.org/2001/XInclude">

Namespace TEINS
    Public Class Name
        Inherits XElement
        Implements IChildOfAb
        Implements ITextData
        Sub New(w As W)
            MyBase.New(<name><%= w %></name>)
        End Sub

        Sub New(text As String)
            MyBase.New(<name><w><%= text %></w></name>)
        End Sub
    End Class
End Namespace

