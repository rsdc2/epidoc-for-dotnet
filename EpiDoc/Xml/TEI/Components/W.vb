﻿Imports <xmlns="http://www.tei-c.org/ns/1.0">
Imports <xmlns:xi="http://www.w3.org/2001/XInclude">

Namespace TEINS
    Public Class W
        Inherits XElement
        Implements IChildOfAb
        Implements ITextData

        Sub New(text As String)
            MyBase.New(<w><%= text %></w>)
        End Sub

    End Class
End Namespace