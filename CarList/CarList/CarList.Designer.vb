<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tbModel = New System.Windows.Forms.TextBox()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.lvwCustomers = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CustomerToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbResult = New System.Windows.Forms.Label()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.lbPrice = New System.Windows.Forms.Label()
        Me.lbYear = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(119, 454)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 11
        Me.btnEnter.Text = "&Enter"
        Me.CustomerToolTip.SetToolTip(Me.btnEnter, "Click to add a customer.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(200, 454)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "&Reset"
        Me.CustomerToolTip.SetToolTip(Me.btnReset, "Click to reset the screen.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(281, 454)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.CustomerToolTip.SetToolTip(Me.btnExit, "Click to exit the application.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tbModel
        '
        Me.tbModel.Location = New System.Drawing.Point(84, 34)
        Me.tbModel.Name = "tbModel"
        Me.tbModel.Size = New System.Drawing.Size(121, 20)
        Me.tbModel.TabIndex = 3
        Me.CustomerToolTip.SetToolTip(Me.tbModel, "Type the car's model")
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Ford", "Toyota", "Mazda", "Volkswagen", "Jeep", "Mini", "Chrysler", "Audi", "BMW", "Tesla", "Kia", "Infiniti"})
        Me.cmbMake.Location = New System.Drawing.Point(84, 7)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(121, 21)
        Me.cmbMake.TabIndex = 1
        Me.CustomerToolTip.SetToolTip(Me.cmbMake, "Type the car's manufacturer")
        '
        'lbTitle
        '
        Me.lbTitle.Location = New System.Drawing.Point(12, 10)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(66, 13)
        Me.lbTitle.TabIndex = 0
        Me.lbTitle.Text = "&Make:"
        Me.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(12, 37)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(66, 13)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "&Model:"
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFirstName.UseWaitCursor = True
        '
        'chkNew
        '
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(44, 112)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(53, 24)
        Me.chkNew.TabIndex = 8
        Me.chkNew.Text = "&New:"
        Me.chkNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CustomerToolTip.SetToolTip(Me.chkNew, "Check to make the car model new")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'lvwCustomers
        '
        Me.lvwCustomers.CheckBoxes = True
        Me.lvwCustomers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwCustomers.FullRowSelect = True
        Me.lvwCustomers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCustomers.Location = New System.Drawing.Point(2, 142)
        Me.lvwCustomers.MultiSelect = False
        Me.lvwCustomers.Name = "lvwCustomers"
        Me.lvwCustomers.Size = New System.Drawing.Size(363, 246)
        Me.lvwCustomers.TabIndex = 9
        Me.CustomerToolTip.SetToolTip(Me.lvwCustomers, "Select a customer to modify.")
        Me.lvwCustomers.UseCompatibleStateImageBehavior = False
        Me.lvwCustomers.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        '
        'lbResult
        '
        Me.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbResult.Location = New System.Drawing.Point(2, 391)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(363, 60)
        Me.lbResult.TabIndex = 10
        Me.CustomerToolTip.SetToolTip(Me.lbResult, "Success or Error message will appear here.")
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(84, 86)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(121, 20)
        Me.tbPrice.TabIndex = 7
        Me.CustomerToolTip.SetToolTip(Me.tbPrice, "Type in the price of the car")
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(84, 60)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 21)
        Me.cmbYear.TabIndex = 5
        Me.CustomerToolTip.SetToolTip(Me.cmbYear, "Select the car's year model")
        '
        'lbPrice
        '
        Me.lbPrice.Location = New System.Drawing.Point(12, 89)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(66, 13)
        Me.lbPrice.TabIndex = 6
        Me.lbPrice.Text = "&Price:"
        Me.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbYear
        '
        Me.lbYear.Location = New System.Drawing.Point(12, 63)
        Me.lbYear.Name = "lbYear"
        Me.lbYear.Size = New System.Drawing.Size(66, 13)
        Me.lbYear.TabIndex = 4
        Me.lbYear.Text = "&Year:"
        Me.lbYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmCustomerList
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(368, 482)
        Me.Controls.Add(Me.lbYear)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.lbPrice)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.lbResult)
        Me.Controls.Add(Me.lvwCustomers)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lbTitle)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.tbModel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomerList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tbModel As TextBox
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents lbTitle As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents lvwCustomers As ListView
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents CustomerToolTip As ToolTip
    Friend WithEvents lbResult As Label
    Friend WithEvents lbPrice As Label
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents lbYear As Label
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents colPrice As ColumnHeader
End Class
