Imports System.Xml
Imports System.Xml.Linq

Public Module Xml

    Function FromFilePath(path As String) As XDocument
        Return XDocument.Load(path)
    End Function

    Function ToFilePath(doc As XDocument, path As String) As XDocument
        doc.Save(path)
        Return XDocument.Load(path)
    End Function

    Function W(ByVal text As String) As XElement
        Return <w><%= text %></w>
    End Function



End Module