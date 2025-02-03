Option Strict On
Imports <xmlns="http://www.tei-c.org/ns/1.0">
Imports <xmlns:xi="http://www.w3.org/2001/XInclude">


Public Module TEIXml

    Function TEIHeader() As XElement
        Return <TEIHeader/>
    End Function

    'Function TEIDoc() As XDocument
    '    Return <?xml version="1.0" encoding="UTF-8"?>
    '           <TEI>
    '               <%= TEIHeader() %>
    '               <%= Edition() %>
    '           </TEI>
    'End Function

End Module