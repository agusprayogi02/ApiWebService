Imports System.Net
Imports System.Web.Http
Imports System.Web.Http.Description

Namespace Controllers
    Public Class UserController
        Inherits ApiController
        Private db As New userEntities1

        ' GET: api/User
        Public Function GetValues() As IQueryable(Of login)
            Return db.logins
        End Function

        ' GET: api/User/5
        <ResponseType(GetType(login))>
        Public Function GetValue(ByVal id As Integer) As IHttpActionResult
            Dim login As login = db.logins.Find(id)
            If IsNothing(login) Then
                Return NotFound()
            End If
            Return Ok(login)
        End Function

        ' POST: api/User
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/User/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/User/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace