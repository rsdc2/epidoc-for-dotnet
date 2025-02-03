Imports <xmlns="http://www.tei-c.org/ns/1.0">
Imports <xmlns:xi="http://www.w3.org/2001/XInclude">

Namespace TEINS

    Public Class TEI
        Inherits XDocument

        Sub New(header As Header, edition As Edition)
            MyBase.New(<?xml version="1.0" encoding="UTF-8"?>
                       <TEI>
                           <%= header %>
                           <%= edition %>
                       </TEI>)
        End Sub

        Sub New(children As IEnumerable(Of IChildOfTEI))
            MyBase.New(<?xml version="1.0" encoding="UTF-8"?><TEI>
                       <%= children %>
                       </TEI>)
        End Sub

    End Class
End Namespace

