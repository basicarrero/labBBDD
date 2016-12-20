Public Class GestorBBDD
    Public Shared Sub readData(ByRef departamentos As List(Of Departamento), ByRef conferencias As List(Of Conferencia))
        departamentos = GestorDepartamentos.readDep()
        conferencias = gestorConferencias.readConf()
        For Each conf In conferencias
            conf.Asistentes = gestorAsistentes.readAsistentes(conf.ID, departamentos)
            For Each art In conf.Articulos
                art.Autoria = gestorAutoria.readAutoria(art.ID, departamentos)
            Next
        Next
    End Sub

    Public Shared Function getRefInvest(ByVal investID As String, ByRef departamentos As List(Of Departamento)) As Investigador
        Dim match As Investigador = Nothing
        Dim more As Boolean = True
        For Each dep In departamentos
            For Each invest In dep.Investigadores
                If invest.ID = investID Then
                    match = invest
                    more = False
                    Exit For
                End If
            Next
            If Not more Then Exit For
        Next
        Return match
    End Function
End Class