Imports System.ComponentModel

Public Class Model
    Implements INotifyPropertyChanged

    Public Event PropertyChanged As PropertyChangedEventHandler _
        Implements INotifyPropertyChanged.PropertyChanged

    Private _name As String
    Public Property Name As String
        Get
            Return _name
        End Get
        Set
            If Not String.Equals(_name, Value) Then
                _name = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Name)))
            End If
        End Set
    End Property

    Private _flag As MyFlag
    Public Property Flag As MyFlag
        Get
            Return _flag
        End Get
        Set
            If _flag Is Nothing OrElse
               Not _flag.Equals(Value) Then
                _flag = Value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Flag)))
            End If
        End Set
    End Property

    Public Sub New()
        _name = String.Empty
        _flag = New MyFlag() With {.Yes = False}
    End Sub
End Class
