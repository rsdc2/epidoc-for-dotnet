Imports System
Imports EpiDoc.TEINS


Module Program
    Sub Main(args As String())

        Dim header = New Header()
        Dim name = New Name("Lucius")

        Dim children = New List(Of IChildOfAb) From {name}
        Dim edition = New Edition(children)

        Dim doc = New TEI(New List(Of IChildOfTEI) From {header, edition})

        Console.WriteLine(doc)
    End Sub
End Module
