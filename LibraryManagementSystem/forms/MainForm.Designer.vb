<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PanelTabs = New MaterialSkin.Controls.MaterialTabControl()
        Me.DashboardTab = New System.Windows.Forms.TabPage()
        Me.MaintenanceTab = New System.Windows.Forms.TabPage()
        Me.Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.BooksTab = New System.Windows.Forms.TabPage()
        Me.TLBook = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnAddBook = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GenreTab = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnAddGenre = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.AuthorTab = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2TextBox3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnAddAuthor = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PublisherTab = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2TextBox4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnAddPublisher = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.DonatorTab = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel9 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2TextBox5 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel10 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BookCopiesTab = New System.Windows.Forms.TabPage()
        Me.ReportsTab = New System.Windows.Forms.TabPage()
        Me.SettingsTab = New System.Windows.Forms.TabPage()
        Me.LogsTab = New System.Windows.Forms.TabPage()
        Me.MenuIconList = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelTabs.SuspendLayout()
        Me.MaintenanceTab.SuspendLayout()
        Me.Guna2TabControl1.SuspendLayout()
        Me.BooksTab.SuspendLayout()
        Me.TLBook.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.GenreTab.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.AuthorTab.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.PublisherTab.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Guna2Panel7.SuspendLayout()
        Me.DonatorTab.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Guna2Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTabs
        '
        Me.PanelTabs.Controls.Add(Me.DashboardTab)
        Me.PanelTabs.Controls.Add(Me.MaintenanceTab)
        Me.PanelTabs.Controls.Add(Me.BookCopiesTab)
        Me.PanelTabs.Controls.Add(Me.ReportsTab)
        Me.PanelTabs.Controls.Add(Me.SettingsTab)
        Me.PanelTabs.Controls.Add(Me.LogsTab)
        Me.PanelTabs.Depth = 0
        Me.PanelTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTabs.ImageList = Me.MenuIconList
        Me.PanelTabs.ItemSize = New System.Drawing.Size(94, 30)
        Me.PanelTabs.Location = New System.Drawing.Point(0, 64)
        Me.PanelTabs.MouseState = MaterialSkin.MouseState.HOVER
        Me.PanelTabs.Multiline = True
        Me.PanelTabs.Name = "PanelTabs"
        Me.PanelTabs.SelectedIndex = 0
        Me.PanelTabs.Size = New System.Drawing.Size(1249, 580)
        Me.PanelTabs.TabIndex = 0
        '
        'DashboardTab
        '
        Me.DashboardTab.ImageKey = "dashboard.png"
        Me.DashboardTab.Location = New System.Drawing.Point(4, 34)
        Me.DashboardTab.Margin = New System.Windows.Forms.Padding(0)
        Me.DashboardTab.Name = "DashboardTab"
        Me.DashboardTab.Size = New System.Drawing.Size(1241, 542)
        Me.DashboardTab.TabIndex = 0
        Me.DashboardTab.Text = "Dashboard"
        Me.DashboardTab.UseVisualStyleBackColor = True
        '
        'MaintenanceTab
        '
        Me.MaintenanceTab.Controls.Add(Me.Guna2TabControl1)
        Me.MaintenanceTab.ImageKey = "maintenance.png"
        Me.MaintenanceTab.Location = New System.Drawing.Point(4, 34)
        Me.MaintenanceTab.Margin = New System.Windows.Forms.Padding(0)
        Me.MaintenanceTab.Name = "MaintenanceTab"
        Me.MaintenanceTab.Size = New System.Drawing.Size(1241, 542)
        Me.MaintenanceTab.TabIndex = 1
        Me.MaintenanceTab.Text = "Maintenance"
        Me.MaintenanceTab.UseVisualStyleBackColor = True
        '
        'Guna2TabControl1
        '
        Me.Guna2TabControl1.Controls.Add(Me.BooksTab)
        Me.Guna2TabControl1.Controls.Add(Me.GenreTab)
        Me.Guna2TabControl1.Controls.Add(Me.AuthorTab)
        Me.Guna2TabControl1.Controls.Add(Me.PublisherTab)
        Me.Guna2TabControl1.Controls.Add(Me.DonatorTab)
        Me.Guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2TabControl1.Name = "Guna2TabControl1"
        Me.Guna2TabControl1.SelectedIndex = 0
        Me.Guna2TabControl1.Size = New System.Drawing.Size(1241, 542)
        Me.Guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.TabIndex = 0
        Me.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'BooksTab
        '
        Me.BooksTab.Controls.Add(Me.TLBook)
        Me.BooksTab.Location = New System.Drawing.Point(4, 44)
        Me.BooksTab.Margin = New System.Windows.Forms.Padding(0)
        Me.BooksTab.Name = "BooksTab"
        Me.BooksTab.Size = New System.Drawing.Size(1233, 494)
        Me.BooksTab.TabIndex = 0
        Me.BooksTab.Text = "Books"
        Me.BooksTab.UseVisualStyleBackColor = True
        '
        'TLBook
        '
        Me.TLBook.ColumnCount = 1
        Me.TLBook.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLBook.Controls.Add(Me.Guna2Panel1, 0, 0)
        Me.TLBook.Controls.Add(Me.Guna2Panel2, 0, 1)
        Me.TLBook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLBook.Location = New System.Drawing.Point(0, 0)
        Me.TLBook.Margin = New System.Windows.Forms.Padding(0)
        Me.TLBook.Name = "TLBook"
        Me.TLBook.RowCount = 2
        Me.TLBook.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TLBook.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLBook.Size = New System.Drawing.Size(1233, 494)
        Me.TLBook.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2Panel1.Controls.Add(Me.BtnAddBook)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1233, 50)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.IconRight = Global.LibraryManagementSystem.My.Resources.Resources.search
        Me.Guna2TextBox1.Location = New System.Drawing.Point(947, 9)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = "Search Book"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(271, 32)
        Me.Guna2TextBox1.TabIndex = 1
        '
        'BtnAddBook
        '
        Me.BtnAddBook.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAddBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAddBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAddBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAddBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAddBook.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnAddBook.ForeColor = System.Drawing.Color.White
        Me.BtnAddBook.Location = New System.Drawing.Point(11, 9)
        Me.BtnAddBook.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnAddBook.Name = "BtnAddBook"
        Me.BtnAddBook.Size = New System.Drawing.Size(127, 32)
        Me.BtnAddBook.TabIndex = 0
        Me.BtnAddBook.Text = "Add Book"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1233, 444)
        Me.Guna2Panel2.TabIndex = 1
        '
        'GenreTab
        '
        Me.GenreTab.Controls.Add(Me.TableLayoutPanel1)
        Me.GenreTab.Location = New System.Drawing.Point(4, 44)
        Me.GenreTab.Margin = New System.Windows.Forms.Padding(0)
        Me.GenreTab.Name = "GenreTab"
        Me.GenreTab.Size = New System.Drawing.Size(1233, 494)
        Me.GenreTab.TabIndex = 1
        Me.GenreTab.Text = "Genres"
        Me.GenreTab.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel4, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1233, 494)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.Guna2TextBox2)
        Me.Guna2Panel3.Controls.Add(Me.BtnAddGenre)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(1233, 50)
        Me.Guna2Panel3.TabIndex = 0
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.IconRight = Global.LibraryManagementSystem.My.Resources.Resources.search
        Me.Guna2TextBox2.Location = New System.Drawing.Point(947, 9)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderText = "Search Genre"
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(271, 32)
        Me.Guna2TextBox2.TabIndex = 1
        '
        'BtnAddGenre
        '
        Me.BtnAddGenre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAddGenre.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAddGenre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAddGenre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAddGenre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAddGenre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnAddGenre.ForeColor = System.Drawing.Color.White
        Me.BtnAddGenre.Location = New System.Drawing.Point(11, 9)
        Me.BtnAddGenre.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnAddGenre.Name = "BtnAddGenre"
        Me.BtnAddGenre.Size = New System.Drawing.Size(127, 32)
        Me.BtnAddGenre.TabIndex = 0
        Me.BtnAddGenre.Text = "Add Genre"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 50)
        Me.Guna2Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(1233, 444)
        Me.Guna2Panel4.TabIndex = 1
        '
        'AuthorTab
        '
        Me.AuthorTab.Controls.Add(Me.TableLayoutPanel2)
        Me.AuthorTab.Location = New System.Drawing.Point(4, 44)
        Me.AuthorTab.Name = "AuthorTab"
        Me.AuthorTab.Size = New System.Drawing.Size(1233, 494)
        Me.AuthorTab.TabIndex = 2
        Me.AuthorTab.Text = "Authors"
        Me.AuthorTab.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel5, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2Panel6, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1233, 494)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Controls.Add(Me.Guna2TextBox3)
        Me.Guna2Panel5.Controls.Add(Me.BtnAddAuthor)
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(1233, 50)
        Me.Guna2Panel5.TabIndex = 0
        '
        'Guna2TextBox3
        '
        Me.Guna2TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox3.DefaultText = ""
        Me.Guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.IconRight = Global.LibraryManagementSystem.My.Resources.Resources.search
        Me.Guna2TextBox3.Location = New System.Drawing.Point(947, 9)
        Me.Guna2TextBox3.Name = "Guna2TextBox3"
        Me.Guna2TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox3.PlaceholderText = "Search Author"
        Me.Guna2TextBox3.SelectedText = ""
        Me.Guna2TextBox3.Size = New System.Drawing.Size(271, 32)
        Me.Guna2TextBox3.TabIndex = 1
        '
        'BtnAddAuthor
        '
        Me.BtnAddAuthor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAddAuthor.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAddAuthor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAddAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAddAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAddAuthor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnAddAuthor.ForeColor = System.Drawing.Color.White
        Me.BtnAddAuthor.Location = New System.Drawing.Point(11, 9)
        Me.BtnAddAuthor.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnAddAuthor.Name = "BtnAddAuthor"
        Me.BtnAddAuthor.Size = New System.Drawing.Size(127, 32)
        Me.BtnAddAuthor.TabIndex = 0
        Me.BtnAddAuthor.Text = "Add Author"
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel6.Location = New System.Drawing.Point(0, 50)
        Me.Guna2Panel6.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(1233, 444)
        Me.Guna2Panel6.TabIndex = 1
        '
        'PublisherTab
        '
        Me.PublisherTab.Controls.Add(Me.TableLayoutPanel3)
        Me.PublisherTab.Location = New System.Drawing.Point(4, 44)
        Me.PublisherTab.Name = "PublisherTab"
        Me.PublisherTab.Size = New System.Drawing.Size(1233, 494)
        Me.PublisherTab.TabIndex = 3
        Me.PublisherTab.Text = "Publishers"
        Me.PublisherTab.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Guna2Panel7, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Guna2Panel8, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1233, 494)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.Controls.Add(Me.Guna2TextBox4)
        Me.Guna2Panel7.Controls.Add(Me.BtnAddPublisher)
        Me.Guna2Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel7.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.Size = New System.Drawing.Size(1233, 50)
        Me.Guna2Panel7.TabIndex = 0
        '
        'Guna2TextBox4
        '
        Me.Guna2TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox4.DefaultText = ""
        Me.Guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.IconRight = Global.LibraryManagementSystem.My.Resources.Resources.search
        Me.Guna2TextBox4.Location = New System.Drawing.Point(947, 9)
        Me.Guna2TextBox4.Name = "Guna2TextBox4"
        Me.Guna2TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox4.PlaceholderText = "Search Publisher"
        Me.Guna2TextBox4.SelectedText = ""
        Me.Guna2TextBox4.Size = New System.Drawing.Size(271, 32)
        Me.Guna2TextBox4.TabIndex = 1
        '
        'BtnAddPublisher
        '
        Me.BtnAddPublisher.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAddPublisher.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAddPublisher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAddPublisher.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAddPublisher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAddPublisher.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnAddPublisher.ForeColor = System.Drawing.Color.White
        Me.BtnAddPublisher.Location = New System.Drawing.Point(11, 9)
        Me.BtnAddPublisher.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnAddPublisher.Name = "BtnAddPublisher"
        Me.BtnAddPublisher.Size = New System.Drawing.Size(127, 32)
        Me.BtnAddPublisher.TabIndex = 0
        Me.BtnAddPublisher.Text = "Add Publisher"
        '
        'Guna2Panel8
        '
        Me.Guna2Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel8.Location = New System.Drawing.Point(0, 50)
        Me.Guna2Panel8.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.Size = New System.Drawing.Size(1233, 444)
        Me.Guna2Panel8.TabIndex = 1
        '
        'DonatorTab
        '
        Me.DonatorTab.Controls.Add(Me.TableLayoutPanel4)
        Me.DonatorTab.Location = New System.Drawing.Point(4, 44)
        Me.DonatorTab.Name = "DonatorTab"
        Me.DonatorTab.Size = New System.Drawing.Size(1233, 494)
        Me.DonatorTab.TabIndex = 4
        Me.DonatorTab.Text = "Donators"
        Me.DonatorTab.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Guna2Panel9, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Guna2Panel10, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1233, 494)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'Guna2Panel9
        '
        Me.Guna2Panel9.Controls.Add(Me.Guna2TextBox5)
        Me.Guna2Panel9.Controls.Add(Me.Guna2Button4)
        Me.Guna2Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel9.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel9.Name = "Guna2Panel9"
        Me.Guna2Panel9.Size = New System.Drawing.Size(1233, 50)
        Me.Guna2Panel9.TabIndex = 0
        '
        'Guna2TextBox5
        '
        Me.Guna2TextBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox5.DefaultText = ""
        Me.Guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox5.IconRight = Global.LibraryManagementSystem.My.Resources.Resources.search
        Me.Guna2TextBox5.Location = New System.Drawing.Point(947, 9)
        Me.Guna2TextBox5.Name = "Guna2TextBox5"
        Me.Guna2TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox5.PlaceholderText = "Search Donator"
        Me.Guna2TextBox5.SelectedText = ""
        Me.Guna2TextBox5.Size = New System.Drawing.Size(271, 32)
        Me.Guna2TextBox5.TabIndex = 1
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Location = New System.Drawing.Point(11, 9)
        Me.Guna2Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(127, 32)
        Me.Guna2Button4.TabIndex = 0
        Me.Guna2Button4.Text = "Add Donator"
        '
        'Guna2Panel10
        '
        Me.Guna2Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel10.Location = New System.Drawing.Point(0, 50)
        Me.Guna2Panel10.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel10.Name = "Guna2Panel10"
        Me.Guna2Panel10.Size = New System.Drawing.Size(1233, 444)
        Me.Guna2Panel10.TabIndex = 1
        '
        'BookCopiesTab
        '
        Me.BookCopiesTab.ImageKey = "books.png"
        Me.BookCopiesTab.Location = New System.Drawing.Point(4, 34)
        Me.BookCopiesTab.Name = "BookCopiesTab"
        Me.BookCopiesTab.Size = New System.Drawing.Size(1241, 542)
        Me.BookCopiesTab.TabIndex = 5
        Me.BookCopiesTab.Text = "Book Copies"
        Me.BookCopiesTab.UseVisualStyleBackColor = True
        '
        'ReportsTab
        '
        Me.ReportsTab.ImageKey = "reports.png"
        Me.ReportsTab.Location = New System.Drawing.Point(4, 34)
        Me.ReportsTab.Name = "ReportsTab"
        Me.ReportsTab.Size = New System.Drawing.Size(1241, 542)
        Me.ReportsTab.TabIndex = 6
        Me.ReportsTab.Text = "Reports"
        Me.ReportsTab.UseVisualStyleBackColor = True
        '
        'SettingsTab
        '
        Me.SettingsTab.ImageKey = "settings.png"
        Me.SettingsTab.Location = New System.Drawing.Point(4, 34)
        Me.SettingsTab.Name = "SettingsTab"
        Me.SettingsTab.Size = New System.Drawing.Size(1241, 542)
        Me.SettingsTab.TabIndex = 3
        Me.SettingsTab.Text = "Settings"
        Me.SettingsTab.UseVisualStyleBackColor = True
        '
        'LogsTab
        '
        Me.LogsTab.ImageKey = "audit_trail.png"
        Me.LogsTab.Location = New System.Drawing.Point(4, 34)
        Me.LogsTab.Name = "LogsTab"
        Me.LogsTab.Size = New System.Drawing.Size(1241, 542)
        Me.LogsTab.TabIndex = 2
        Me.LogsTab.Text = "Audit Trail"
        Me.LogsTab.UseVisualStyleBackColor = True
        '
        'MenuIconList
        '
        Me.MenuIconList.ImageStream = CType(resources.GetObject("MenuIconList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.MenuIconList.TransparentColor = System.Drawing.Color.Transparent
        Me.MenuIconList.Images.SetKeyName(0, "dashboard.png")
        Me.MenuIconList.Images.SetKeyName(1, "maintenance.png")
        Me.MenuIconList.Images.SetKeyName(2, "settings.png")
        Me.MenuIconList.Images.SetKeyName(3, "audit_trail.png")
        Me.MenuIconList.Images.SetKeyName(4, "books.png")
        Me.MenuIconList.Images.SetKeyName(5, "reports.png")
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 647)
        Me.Controls.Add(Me.PanelTabs)
        Me.DrawerAutoHide = False
        Me.DrawerShowIconsWhenHidden = True
        Me.DrawerTabControl = Me.PanelTabs
        Me.DrawerWidth = 250
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Padding = New System.Windows.Forms.Padding(0, 64, 0, 3)
        Me.Sizable = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LMS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelTabs.ResumeLayout(False)
        Me.MaintenanceTab.ResumeLayout(False)
        Me.Guna2TabControl1.ResumeLayout(False)
        Me.BooksTab.ResumeLayout(False)
        Me.TLBook.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.GenreTab.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.AuthorTab.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Guna2Panel5.ResumeLayout(False)
        Me.PublisherTab.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Guna2Panel7.ResumeLayout(False)
        Me.DonatorTab.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Guna2Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTabs As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents DashboardTab As TabPage
    Friend WithEvents MaintenanceTab As TabPage
    Friend WithEvents MenuIconList As ImageList
    Friend WithEvents LogsTab As TabPage
    Friend WithEvents BookCopiesTab As TabPage
    Friend WithEvents SettingsTab As TabPage
    Friend WithEvents ReportsTab As TabPage
    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents BooksTab As TabPage
    Friend WithEvents GenreTab As TabPage
    Friend WithEvents AuthorTab As TabPage
    Friend WithEvents PublisherTab As TabPage
    Friend WithEvents DonatorTab As TabPage
    Friend WithEvents TLBook As TableLayoutPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnAddBook As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnAddGenre As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnAddAuthor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2TextBox4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnAddPublisher As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Guna2Panel9 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2TextBox5 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel10 As Guna.UI2.WinForms.Guna2Panel
End Class
