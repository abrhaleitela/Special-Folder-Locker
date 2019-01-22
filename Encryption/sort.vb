
Public Class sort
    Implements System.Collections.IComparer
    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare

        Return String.Compare(x, y)

    End Function

End Class
