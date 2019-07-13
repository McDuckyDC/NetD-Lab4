
Option Strict On

''' <summary>
''' Author Name:    Alfred Massardo & March Roldan
''' Project Name:   CustomerList
''' Date:           05-Jan-2018 (Updated 12-July-2019)
''' Description     Application to keep a list of customers and a little information that describes their importance.
''' </summary>

Public Class frmCustomerList

    Private carList As New SortedList
    Private currentCarIdentificationNumber As String = String.Empty
    Private editMode As Boolean = False

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim car As Car
        Dim carItem As ListViewItem

        ' validate the data in the form
        If IsValidInput() = True Then

            editMode = True

            lbResult.Text = "It worked!"

            If currentCarIdentificationNumber.Trim.Length = 0 Then

                ' create a new customer object using the parameterized constructor
                car = New Car(cmbMake.Text, tbModel.Text, Convert.ToInt32(cmbYear.Text), Convert.ToDecimal(tbPrice.Text), chkNew.Checked)

                carList.Add(car.IdentificationNumber.ToString(), car)

            Else

                car = CType(carList.Item(currentCarIdentificationNumber), Car)

                car.Make = cmbMake.Text
                car.Model = tbModel.Text
                car.Year = Convert.ToInt32(cmbYear.Text)
                car.Price = Convert.ToDouble(tbPrice.Text)
                car.NewStatus = chkNew.Checked
            End If

            ' clear the items from the listview control
            lvwCustomers.Items.Clear()

            ' loop through the customerList collection
            ' and populate the list view
            For Each carEntry As DictionaryEntry In carList

                ' instantiate a new ListViewItem
                carItem = New ListViewItem()

                ' get the customer from the list
                car = CType(carEntry.Value, Car)

                ' assign the values to the ckecked control
                ' and the subitems
                carItem.Checked = car.NewStatus
                carItem.SubItems.Add(car.IdentificationNumber.ToString())
                carItem.SubItems.Add(car.Make)
                carItem.SubItems.Add(car.Model)
                carItem.SubItems.Add(Convert.ToString(car.Year))
                carItem.SubItems.Add(FormatCurrency(Convert.ToString(car.Price), 2))

                ' add the new instantiated and populated ListViewItem
                ' to the listview control
                lvwCustomers.Items.Add(carItem)

            Next carEntry

            'Next index

            ' clear the controls
            Reset()

            ' set the edit flag to false
            editMode = False

        End If

    End Sub

    ''' <summary>
    ''' Reset - set the controls back to their default state.
    ''' </summary>
    Private Sub Reset()

        tbModel.Text = String.Empty
        tbPrice.Text = String.Empty
        chkNew.Checked = False
        cmbMake.SelectedIndex = -1
        cmbYear.SelectedIndex = -1

        currentCarIdentificationNumber = String.Empty

    End Sub

    ''' <summary>
    ''' IsValidInput - validates the data in each control to ensure that the user has entered apprpriate values
    ''' </summary>
    ''' <returns>Boolean</returns>
    Private Function IsValidInput() As Boolean

        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty

        ' check if the title has been selected
        If cmbMake.SelectedIndex = -1 Then

            ' If not set the error message
            outputMessage += "Please select a car manufacturer" & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the first name has been entered
        If tbModel.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the car model name." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the title has been selected
        If cmbYear.SelectedIndex = -1 Then

            ' If not set the error message
            outputMessage += "Please select a car manufacturer date" & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the first name has been entered
        If Not Double.TryParse(tbPrice.Text, vbNull) Then

            ' If not set the error message
            outputMessage += "Please enter a valid price" & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check to see if any value
        ' did not validate
        If returnValue = False Then

            ' show the message(s) to the user
            lbResult.Text = "ERRORS" & vbCrLf & outputMessage

        End If

        ' return the boolean value
        ' true if it passed validation
        ' false if it did not pass validation
        Return returnValue

    End Function

    ''' <summary>
    ''' Event is declared as private because it is only accessible within the form
    ''' The code in the btnReset_Click EventHandler will clear the form and set
    ''' focus back to the input text box. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ' call the rest sub routine
        Reset()

    End Sub
    ''' <summary>
    ''' Event is declared as private because it is only accessible within the form
    ''' The code in the btnExit_Click EventHandler will close the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' This will close the form
        Me.Close()

    End Sub

    ''' <summary>
    ''' lvwCustomers_ItemCheck - used to prevent the user from checking the check box in the list view
    '''                        - if it is not in edit mode
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwCustomers_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCustomers.ItemCheck

        ' if it is not in edit mode
        If editMode = False Then

            ' the new value to the current value
            ' so it cannot be set in the listview by the user
            e.NewValue = e.CurrentValue

        End If

    End Sub

    ''' <summary>
    ''' lvwCustomers_SelectedIndexChanged - when the user selected a row in the list it will populate the fields for editing
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCustomers.SelectedIndexChanged

        ' constant that represents the index of the subitem in the list that
        ' holds the customer identification number 
        Const identificationSubItemIndex As Integer = 1

        ' Get the customer identification number 
        currentCarIdentificationNumber = lvwCustomers.Items(lvwCustomers.FocusedItem.Index).SubItems(identificationSubItemIndex).Text

        ' Use the customer identification number to get the customer from the collection object
        Dim car As car = CType(carList.Item(currentCarIdentificationNumber), car)

        ' set the controls on the form
        cmbMake.Text = car.Make
        tbModel.Text = car.Model
        cmbYear.Text = Convert.ToString(car.Year)
        tbPrice.Text = Convert.ToString(car.Price)
        chkNew.Checked = car.NewStatus

        lbResult.Text = Car.GetSalutation()

    End Sub

    Private Sub frmCustomerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1990 To Date.Today.Year
            cmbYear.Items.Add(i)
        Next i
    End Sub

End Class

