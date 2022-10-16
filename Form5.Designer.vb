<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ts_Home = New System.Windows.Forms.ToolStripButton()
        Me.ts_AssetReg = New System.Windows.Forms.ToolStripButton()
        Me.ts_Maintanance = New System.Windows.Forms.ToolStripButton()
        Me.ts_Query = New System.Windows.Forms.ToolStripButton()
        Me.ts_Analysis = New System.Windows.Forms.ToolStripButton()
        Me.ts_Inventory = New System.Windows.Forms.ToolStripButton()
        Me.ts_Library = New System.Windows.Forms.ToolStripButton()
        Me.ts_Register = New System.Windows.Forms.ToolStripButton()
        Me.ts_Login = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.BurlyWood
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(880, 93)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Equipment Management System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(0, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(880, 322)
        Me.Label3.TabIndex = 2
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.BurlyWood
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(-4, 443)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(880, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kudakwashe W. Rukuni 2022"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(394, 211)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(358, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 23)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Search By Serial Number"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.Location = New System.Drawing.Point(0, 240)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(880, 200)
        Me.DataGridView1.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Tan
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Emoji", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(0, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 26)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Search Results"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(284, 172)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(330, 23)
        Me.TextBox1.TabIndex = 26
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_Home, Me.ts_AssetReg, Me.ts_Maintanance, Me.ts_Query, Me.ts_Analysis, Me.ts_Inventory, Me.ts_Library, Me.ts_Register, Me.ts_Login})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 93)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(880, 28)
        Me.ToolStrip2.TabIndex = 27
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ts_Home
        '
        Me.ts_Home.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ts_Home.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Home.Name = "ts_Home"
        Me.ts_Home.Size = New System.Drawing.Size(60, 25)
        Me.ts_Home.Text = "Home"
        Me.ts_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ts_AssetReg
        '
        Me.ts_AssetReg.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ts_AssetReg.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_AssetReg.Name = "ts_AssetReg"
        Me.ts_AssetReg.Size = New System.Drawing.Size(120, 25)
        Me.ts_AssetReg.Text = "Asset Register"
        Me.ts_AssetReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ts_Maintanance
        '
        Me.ts_Maintanance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ts_Maintanance.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Maintanance.Name = "ts_Maintanance"
        Me.ts_Maintanance.Size = New System.Drawing.Size(114, 25)
        Me.ts_Maintanance.Text = "Maintanance"
        Me.ts_Maintanance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ts_Query
        '
        Me.ts_Query.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ts_Query.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Query.Name = "ts_Query"
        Me.ts_Query.Size = New System.Drawing.Size(116, 25)
        Me.ts_Query.Text = "Search Query"
        Me.ts_Query.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ts_Analysis
        '
        Me.ts_Analysis.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ts_Analysis.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Analysis.Name = "ts_Analysis"
        Me.ts_Analysis.Size = New System.Drawing.Size(77, 25)
        Me.ts_Analysis.Text = "Analysis"
        Me.ts_Analysis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ts_Inventory
        '
        Me.ts_Inventory.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ts_Inventory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Inventory.Name = "ts_Inventory"
        Me.ts_Inventory.Size = New System.Drawing.Size(89, 25)
        Me.ts_Inventory.Text = "Inventory"
        Me.ts_Inventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ts_Inventory.ToolTipText = "REPORTS"
        '
        'ts_Library
        '
        Me.ts_Library.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ts_Library.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Library.Name = "ts_Library"
        Me.ts_Library.Size = New System.Drawing.Size(68, 25)
        Me.ts_Library.Text = "Library"
        Me.ts_Library.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ts_Register
        '
        Me.ts_Register.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ts_Register.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ts_Register.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Register.Name = "ts_Register"
        Me.ts_Register.Size = New System.Drawing.Size(77, 25)
        Me.ts_Register.Text = "New User"
        Me.ts_Register.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ts_Register.ToolTipText = "REGISTER"
        '
        'ts_Login
        '
        Me.ts_Login.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ts_Login.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ts_Login.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_Login.Name = "ts_Login"
        Me.ts_Login.Size = New System.Drawing.Size(66, 25)
        Me.ts_Login.Text = "Log Out"
        Me.ts_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(880, 463)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EMS - Search Query"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ts_Home As ToolStripButton
    Friend WithEvents ts_AssetReg As ToolStripButton
    Friend WithEvents ts_Maintanance As ToolStripButton
    Friend WithEvents ts_Query As ToolStripButton
    Friend WithEvents ts_Analysis As ToolStripButton
    Friend WithEvents ts_Inventory As ToolStripButton
    Friend WithEvents ts_Library As ToolStripButton
    Friend WithEvents ts_Register As ToolStripButton
    Friend WithEvents ts_Login As ToolStripButton
End Class
