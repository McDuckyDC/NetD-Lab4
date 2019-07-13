Option Strict On
Public Class car


    Private Shared carCount As Integer
    Private carIdentificationNumber As Integer = 0
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As Integer = 0
    Private carPrice As Double = 0
    Private carNewStatus As Boolean = False

    Public Sub New()

        carCount += 1
        carIdentificationNumber = carCount

    End Sub

    Public Sub New(make As String, model As String, year As Integer, price As Double, newStatus As Boolean)
        Me.New()

        carMake = make
        carModel = model
        carYear = year
        carPrice = price
        carNewStatus = newStatus

    End Sub

    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property

    Public Property NewStatus() As Boolean
        Get
            Return carNewStatus
        End Get
        Set(ByVal value As Boolean)
            carNewStatus = value
        End Set
    End Property

    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property

    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property

    Public Property Year() As Integer
        Get
            Return carYear
        End Get
        Set(ByVal value As Integer)
            carYear = value
        End Set
    End Property

    Public Property Price() As Double
        Get
            Return carPrice
        End Get
        Set(ByVal value As Double)
            carPrice = value
        End Set
    End Property

    Public Function GetSalutation() As String

        Return "The car is a " & carMake & " " & carModel & " made in " & carYear & " costing $" & carPrice & If(carNewStatus = True, ", brand new.", ", used.").ToString()

    End Function

End Class
