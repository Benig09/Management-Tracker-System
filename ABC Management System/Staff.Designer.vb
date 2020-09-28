<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff))
        Me.lvStaff = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtpath = New System.Windows.Forms.TextBox()
        Me.btnbrowse = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.cbposition = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.cbdepartment = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtstate = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.txtposcode = New System.Windows.Forms.TextBox()
        Me.txtnumber = New System.Windows.Forms.TextBox()
        Me.txtic = New System.Windows.Forms.TextBox()
        Me.txtlast = New System.Windows.Forms.TextBox()
        Me.txtfirst = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.cbsearch = New System.Windows.Forms.ComboBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pbimage = New System.Windows.Forms.PictureBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvStaff
        '
        Me.lvStaff.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.lvStaff.FullRowSelect = True
        Me.lvStaff.GridLines = True
        Me.lvStaff.Location = New System.Drawing.Point(49, 328)
        Me.lvStaff.Margin = New System.Windows.Forms.Padding(4)
        Me.lvStaff.Name = "lvStaff"
        Me.lvStaff.Size = New System.Drawing.Size(827, 211)
        Me.lvStaff.TabIndex = 163
        Me.lvStaff.UseCompatibleStateImageBehavior = False
        Me.lvStaff.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Staff  ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "First Name"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Last Name"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "IC"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Contact Number"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Position"
        Me.ColumnHeader6.Width = 25
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Department"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Address"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Email"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "City"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Poscode"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "State"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Staff Pic"
        '
        'txtpath
        '
        Me.txtpath.Location = New System.Drawing.Point(369, 146)
        Me.txtpath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpath.Name = "txtpath"
        Me.txtpath.Size = New System.Drawing.Size(209, 22)
        Me.txtpath.TabIndex = 162
        '
        'btnbrowse
        '
        Me.btnbrowse.Location = New System.Drawing.Point(588, 146)
        Me.btnbrowse.Margin = New System.Windows.Forms.Padding(4)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(81, 28)
        Me.btnbrowse.TabIndex = 161
        Me.btnbrowse.Text = "Browse"
        Me.btnbrowse.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(758, 547)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 159
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(712, 86)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 17)
        Me.Label13.TabIndex = 158
        Me.Label13.Text = "Type here :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(712, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "Search by:"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(716, 107)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(160, 22)
        Me.txtsearch.TabIndex = 156
        '
        'cbposition
        '
        Me.cbposition.FormattingEnabled = True
        Me.cbposition.Items.AddRange(New Object() {"Supervisor", "Technician", "Manager"})
        Me.cbposition.Location = New System.Drawing.Point(444, 254)
        Me.cbposition.Margin = New System.Windows.Forms.Padding(4)
        Me.cbposition.Name = "cbposition"
        Me.cbposition.Size = New System.Drawing.Size(177, 24)
        Me.cbposition.TabIndex = 155
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(725, 247)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 28)
        Me.btnClear.TabIndex = 154
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(725, 176)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 28)
        Me.btnEdit.TabIndex = 153
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'cbdepartment
        '
        Me.cbdepartment.FormattingEnabled = True
        Me.cbdepartment.Items.AddRange(New Object() {"Finance", "IT", "Marketing", "Engineering"})
        Me.cbdepartment.Location = New System.Drawing.Point(444, 294)
        Me.cbdepartment.Margin = New System.Windows.Forms.Padding(4)
        Me.cbdepartment.Name = "cbdepartment"
        Me.cbdepartment.Size = New System.Drawing.Size(177, 24)
        Me.cbdepartment.TabIndex = 152
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(337, 296)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 17)
        Me.Label14.TabIndex = 151
        Me.Label14.Text = "Department :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(361, 254)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 17)
        Me.Label15.TabIndex = 150
        Me.Label15.Text = "Position :"
        '
        'txtstate
        '
        Me.txtstate.Location = New System.Drawing.Point(446, 219)
        Me.txtstate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtstate.Name = "txtstate"
        Me.txtstate.Size = New System.Drawing.Size(132, 22)
        Me.txtstate.TabIndex = 149
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(377, 219)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 17)
        Me.Label12.TabIndex = 148
        Me.Label12.Text = "State :"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(172, 208)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(157, 22)
        Me.txtemail.TabIndex = 147
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(172, 243)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(157, 45)
        Me.txtaddress.TabIndex = 146
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(172, 296)
        Me.txtcity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(157, 22)
        Me.txtcity.TabIndex = 145
        '
        'txtposcode
        '
        Me.txtposcode.Location = New System.Drawing.Point(446, 181)
        Me.txtposcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtposcode.Name = "txtposcode"
        Me.txtposcode.Size = New System.Drawing.Size(132, 22)
        Me.txtposcode.TabIndex = 144
        '
        'txtnumber
        '
        Me.txtnumber.Location = New System.Drawing.Point(173, 176)
        Me.txtnumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnumber.Name = "txtnumber"
        Me.txtnumber.Size = New System.Drawing.Size(156, 22)
        Me.txtnumber.TabIndex = 143
        '
        'txtic
        '
        Me.txtic.Location = New System.Drawing.Point(173, 144)
        Me.txtic.Margin = New System.Windows.Forms.Padding(4)
        Me.txtic.Name = "txtic"
        Me.txtic.Size = New System.Drawing.Size(156, 22)
        Me.txtic.TabIndex = 142
        '
        'txtlast
        '
        Me.txtlast.Location = New System.Drawing.Point(173, 112)
        Me.txtlast.Margin = New System.Windows.Forms.Padding(4)
        Me.txtlast.Name = "txtlast"
        Me.txtlast.Size = New System.Drawing.Size(156, 22)
        Me.txtlast.TabIndex = 141
        '
        'txtfirst
        '
        Me.txtfirst.Location = New System.Drawing.Point(173, 74)
        Me.txtfirst.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfirst.Name = "txtfirst"
        Me.txtfirst.Size = New System.Drawing.Size(156, 22)
        Me.txtfirst.TabIndex = 140
        '
        'txtid
        '
        Me.txtid.Enabled = False
        Me.txtid.Location = New System.Drawing.Point(173, 37)
        Me.txtid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(156, 22)
        Me.txtid.TabIndex = 139
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(118, 144)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 17)
        Me.Label11.TabIndex = 138
        Me.Label11.Text = "IC :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(64, 112)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 17)
        Me.Label10.TabIndex = 137
        Me.Label10.Text = "Last Name :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(108, 296)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 17)
        Me.Label9.TabIndex = 136
        Me.Label9.Text = "City :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(84, 240)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 17)
        Me.Label8.TabIndex = 135
        Me.Label8.Text = "Address :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(97, 208)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 17)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "Email :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(354, 183)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "Poscode :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(29, 176)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 17)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "Contact Number :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(65, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 17)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "First Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(80, 42)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "Staff ID : "
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(725, 140)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 28)
        Me.btnAdd.TabIndex = 129
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(725, 211)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 28)
        Me.btnDelete.TabIndex = 128
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'cbsearch
        '
        Me.cbsearch.FormattingEnabled = True
        Me.cbsearch.Items.AddRange(New Object() {"First Name", "IC", "Department"})
        Me.cbsearch.Location = New System.Drawing.Point(716, 58)
        Me.cbsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.cbsearch.Name = "cbsearch"
        Me.cbsearch.Size = New System.Drawing.Size(160, 24)
        Me.cbsearch.TabIndex = 127
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(629, 547)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 28)
        Me.btnBack.TabIndex = 126
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'ErrorProvider4
        '
        Me.ErrorProvider4.ContainerControl = Me
        '
        'pbimage
        '
        Me.pbimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbimage.Location = New System.Drawing.Point(412, 16)
        Me.pbimage.Margin = New System.Windows.Forms.Padding(4)
        Me.pbimage.Name = "pbimage"
        Me.pbimage.Size = New System.Drawing.Size(150, 123)
        Me.pbimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbimage.TabIndex = 160
        Me.pbimage.TabStop = False
        '
        'Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.background2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(942, 602)
        Me.ControlBox = False
        Me.Controls.Add(Me.lvStaff)
        Me.Controls.Add(Me.txtpath)
        Me.Controls.Add(Me.btnbrowse)
        Me.Controls.Add(Me.pbimage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.cbposition)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.cbdepartment)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtstate)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtcity)
        Me.Controls.Add(Me.txtposcode)
        Me.Controls.Add(Me.txtnumber)
        Me.Controls.Add(Me.txtic)
        Me.Controls.Add(Me.txtlast)
        Me.Controls.Add(Me.txtfirst)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.cbsearch)
        Me.Controls.Add(Me.btnBack)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Staff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Management"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvStaff As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents txtpath As TextBox
    Friend WithEvents btnbrowse As Button
    Friend WithEvents pbimage As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents cbposition As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents cbdepartment As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtstate As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtcity As TextBox
    Friend WithEvents txtposcode As TextBox
    Friend WithEvents txtnumber As TextBox
    Friend WithEvents txtic As TextBox
    Friend WithEvents txtlast As TextBox
    Friend WithEvents txtfirst As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents cbsearch As ComboBox
    Friend WithEvents btnBack As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents ErrorProvider4 As ErrorProvider
End Class
