Imports System.ComponentModel

<TypeConverter(GetType(MyFlagConverter))>
Public Class MyFlag
    Implements IEquatable(Of MyFlag)

    Public Property Yes As Boolean

    ''' <inheritdoc />
    Public Overloads Function Equals(other As MyFlag) As Boolean Implements IEquatable(Of MyFlag).Equals
        If other Is Nothing Then
            Return False
        End If
        Return Me.Yes = other.Yes
    End Function

    ''' <inheritdoc />
    Public Overrides Function Equals(obj As Object) As Boolean
        Dim objA = TryCast(obj, MyFlag)
        If (objA IsNot Nothing) Then
            Return Me.Equals(objA)
        End If
        Return False
    End Function

    ''' <inheritdoc />
    Public Overrides Function GetHashCode() As Integer
        Return Me.Yes.GetHashCode()
    End Function
End Class
