Imports System.Xml
Imports System.Xml.Linq

Public Module Xml

    Function FromFile(path As String) As XDocument
        Return XDocument.Load(path)
    End Function

    ''' <summary>
    ''' Save an XML to file and return the file reloaded from disk
    ''' </summary>
    ''' <param name="doc"></param>
    ''' <param name="path"></param>
    ''' <returns></returns>
    Function ToFile(doc As XDocument, path As String) As XDocument
        doc.Save(path)
        Return XDocument.Load(path)
    End Function

End Module