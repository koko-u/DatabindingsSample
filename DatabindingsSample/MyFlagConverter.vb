Imports System.ComponentModel
Imports System.Globalization

Public Class MyFlagConverter
    Inherits TypeConverter

    ''' 文字列から MyFlag への変換が可能である
    Public Overrides Function CanConvertFrom(context As ITypeDescriptorContext, sourceType As Type) As Boolean
        If sourceType = GetType(String) Then
            Return True
        End If
        Return MyBase.CanConvertFrom(context, sourceType)
    End Function

    ''' MyFlag が文字列へと変換可能である
    Public Overrides Function CanConvertTo(context As ITypeDescriptorContext, destinationType As Type) As Boolean
        If destinationType = GetType(String) Then
            Return True
        End If
        Return MyBase.CanConvertTo(context, destinationType)
    End Function

    ''' 文字列を変換して、 MyFlag を得る
    Public Overrides Function ConvertFrom(context As ITypeDescriptorContext, culture As CultureInfo, value As Object) As Object
        Dim str As String = DirectCast(value, String)
        If str IsNot Nothing Then
            If str.Equals("〇") Then
                Return New MyFlag() With {.Yes = True}
            End If
            If str.Trim().Equals(String.Empty) Then
                Return New MyFlag() With {.Yes = False}
            End If
        End If
        Return MyBase.ConvertFrom(context, culture, value)
    End Function

    ''' MyFlag を文字列へと変換する
    Public Overrides Function ConvertTo(context As ITypeDescriptorContext, culture As CultureInfo, value As Object, destinationType As Type) As Object
        Dim myFlag = DirectCast(value, MyFlag)
        If myFlag IsNot Nothing AndAlso
           destinationType = GetType(String) Then
            If myFlag.Yes Then
                Return "〇"
            Else
                Return String.Empty
            End If
        End If
        Return MyBase.ConvertTo(context, culture, value, destinationType)
    End Function
End Class
