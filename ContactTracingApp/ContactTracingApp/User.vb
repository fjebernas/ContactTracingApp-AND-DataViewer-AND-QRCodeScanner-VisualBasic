Imports System.IO

Public Class User
    Private Const PATH As String = "C:\Users\franc\Documents\School\ELECTIVE 3\repos\ContactTracingApp-folder\ContactTracingApp\ContactTracingAppEntries\"
#Region "Private backing fields"
    Private _userType As String
    Private _firstName As String
    Private _middleName As String
    Private _lastName As String
    Private _age As Byte
    Private _address As String
    Private _cpNum As String
    Private _gender As String
    Private _firstQuestionAnswer As String
    Private _secondQuestionAnswer As String
    Private _fever As String
    Private _cough As String
    Private _dB As String
#End Region
#Region "Properties"
    Public Property UserType As String
        Get
            Return _userType
        End Get
        Set(value As String)
            _userType = value
        End Set
    End Property
    Public Property FirstName As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property
    Public Property MiddleName As String
        Get
            Return _middleName
        End Get
        Set(value As String)
            _middleName = value
        End Set
    End Property
    Public Property LastName As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property
    Public Property Age As Byte
        Get
            Return _age
        End Get
        Set(value As Byte)
            _age = value
        End Set
    End Property
    Public Property Address As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
        End Set
    End Property
    Public Property CpNum As String
        Get
            Return _cpNum
        End Get
        Set(value As String)
            _cpNum = value
        End Set
    End Property
    Public Property Gender As String
        Get
            Return _gender
        End Get
        Set(value As String)
            _gender = value
        End Set
    End Property
    Public Property FirstQuestionAnswer As String
        Get
            Return _firstQuestionAnswer
        End Get
        Set(value As String)
            _firstQuestionAnswer = value
        End Set
    End Property
    Public Property SecondQuestionAnswer As String
        Get
            Return _secondQuestionAnswer
        End Get
        Set(value As String)
            _secondQuestionAnswer = value
        End Set
    End Property
    Public WriteOnly Property Fever As Boolean
        Set(value As Boolean)
            If value Then
                _fever = "Yes"
            Else
                _fever = "No"
            End If
        End Set
    End Property
    Public WriteOnly Property Cough As Boolean
        Set(value As Boolean)
            If value Then
                _cough = "Yes"
            Else
                _cough = "No"
            End If
        End Set
    End Property
    Public WriteOnly Property DifficultyBreathing As Boolean
        Set(value As Boolean)
            If value Then
                _dB = "Yes"
            Else
                _dB = "No"
            End If
        End Set
    End Property
#End Region
    Public Sub New()

    End Sub

    Public Sub CreateTxtFile()
        Dim txtFile As StreamWriter
        Try
            txtFile = File.CreateText(PATH & _lastName & "," & _firstName & " " & _middleName & ".txt")
            txtFile.WriteLine("Selected type: " & _userType & vbCrLf & vbCrLf &
                                "First name: " & _firstName & vbCrLf &
                                "Middle name: " & _middleName & vbCrLf &
                                "Last name: " & _lastName & vbCrLf &
                                "Age: " & _age.ToString() & vbCrLf &
                                "Phone number: " & _cpNum & vbCrLf &
                                "Address: " & _address & vbCrLf &
                                "Gender: " & _gender & vbCrLf & vbCrLf &
                                "USER'S ANSWERS:" & vbCrLf & vbCrLf &
                                "1. Have you traveled outside the country anytime from last month until now?" & vbCrLf &
                                _firstQuestionAnswer & vbCrLf &
                                "2. Have you come into contact with anyone who has traveled outside your country between the period of last month until now?" & vbCrLf &
                                _secondQuestionAnswer & vbCrLf & vbCrLf &
                                "USER'S SYMPTOMS CHECKLIST:" & vbCrLf & vbCrLf &
                                "Fever: " &
                                _fever & vbCrLf &
                                "Cough: " &
                                _cough & vbCrLf &
                                "Difficulty breathing: " & _dB & vbCrLf
                                )
            txtFile.Close()
            MessageBox.Show("Submitted successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
