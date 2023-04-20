namespace LibraryApp.View
{
    partial class InitPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelTitleAuthor = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.textBoxTitleAuthor = new System.Windows.Forms.TextBox();
            this.trackBarMaxPrice = new System.Windows.Forms.TrackBar();
            this.trackBarMinPrice = new System.Windows.Forms.TrackBar();
            this.checkBoxMaxPrice = new System.Windows.Forms.CheckBox();
            this.checkBoxMinPrice = new System.Windows.Forms.CheckBox();
            this.checkBoxMinPages = new System.Windows.Forms.CheckBox();
            this.checkBoxMaxPages = new System.Windows.Forms.CheckBox();
            this.trackBarMinPages = new System.Windows.Forms.TrackBar();
            this.trackBarMaxPages = new System.Windows.Forms.TrackBar();
            this.comboBoxGenreFl = new System.Windows.Forms.ComboBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectedGenres = new System.Windows.Forms.ComboBox();
            this.labelSelectedGenres = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonEditBook = new System.Windows.Forms.Button();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.buttonRentHistory = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonRentedBooks = new System.Windows.Forms.Button();
            this.buttonNotifications = new System.Windows.Forms.Button();
            this.buttonBorrowBook = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.labelCurrencyType = new System.Windows.Forms.Label();
            this.comboBoxCurrencyType = new System.Windows.Forms.ComboBox();
            this.buttonCards = new System.Windows.Forms.Button();
            this.buttonSubscriptions = new System.Windows.Forms.Button();
            this.buttonClearFilters = new System.Windows.Forms.Button();
            this.buttonShowBooks = new System.Windows.Forms.Button();
            this.labelLoggedIn = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.labelMaxPrice = new System.Windows.Forms.Label();
            this.labelMinPrice = new System.Windows.Forms.Label();
            this.labelMaxPages = new System.Windows.Forms.Label();
            this.labelMinPages = new System.Windows.Forms.Label();
            this.labelPending = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxPages)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRegister.Location = new System.Drawing.Point(12, 13);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(154, 45);
            this.buttonRegister.TabIndex = 0;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelTitleAuthor
            // 
            this.labelTitleAuthor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelTitleAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitleAuthor.Location = new System.Drawing.Point(9, 73);
            this.labelTitleAuthor.Name = "labelTitleAuthor";
            this.labelTitleAuthor.Size = new System.Drawing.Size(157, 25);
            this.labelTitleAuthor.TabIndex = 1;
            this.labelTitleAuthor.Text = "Title/Author";
            this.labelTitleAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogin.Location = new System.Drawing.Point(172, 13);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(158, 45);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogout.Location = new System.Drawing.Point(336, 13);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(140, 45);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonQuit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonQuit.Location = new System.Drawing.Point(12, 768);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(118, 53);
            this.buttonQuit.TabIndex = 4;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // textBoxTitleAuthor
            // 
            this.textBoxTitleAuthor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxTitleAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTitleAuthor.Location = new System.Drawing.Point(172, 73);
            this.textBoxTitleAuthor.Name = "textBoxTitleAuthor";
            this.textBoxTitleAuthor.Size = new System.Drawing.Size(304, 24);
            this.textBoxTitleAuthor.TabIndex = 5;
            this.textBoxTitleAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trackBarMaxPrice
            // 
            this.trackBarMaxPrice.AutoSize = false;
            this.trackBarMaxPrice.LargeChange = 0;
            this.trackBarMaxPrice.Location = new System.Drawing.Point(172, 103);
            this.trackBarMaxPrice.Maximum = 1000;
            this.trackBarMaxPrice.Name = "trackBarMaxPrice";
            this.trackBarMaxPrice.Size = new System.Drawing.Size(304, 25);
            this.trackBarMaxPrice.TabIndex = 6;
            this.trackBarMaxPrice.TickFrequency = 0;
            this.trackBarMaxPrice.Scroll += new System.EventHandler(this.trackBarMaxPrice_Scroll);
            // 
            // trackBarMinPrice
            // 
            this.trackBarMinPrice.AutoSize = false;
            this.trackBarMinPrice.LargeChange = 0;
            this.trackBarMinPrice.Location = new System.Drawing.Point(172, 137);
            this.trackBarMinPrice.Maximum = 1000;
            this.trackBarMinPrice.Name = "trackBarMinPrice";
            this.trackBarMinPrice.Size = new System.Drawing.Size(304, 25);
            this.trackBarMinPrice.TabIndex = 7;
            this.trackBarMinPrice.TickFrequency = 0;
            this.trackBarMinPrice.Scroll += new System.EventHandler(this.trackBarMinPrice_Scroll);
            // 
            // checkBoxMaxPrice
            // 
            this.checkBoxMaxPrice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.checkBoxMaxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxMaxPrice.Location = new System.Drawing.Point(9, 101);
            this.checkBoxMaxPrice.Name = "checkBoxMaxPrice";
            this.checkBoxMaxPrice.Size = new System.Drawing.Size(157, 25);
            this.checkBoxMaxPrice.TabIndex = 10;
            this.checkBoxMaxPrice.Text = "Max Price";
            this.checkBoxMaxPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxMaxPrice.UseVisualStyleBackColor = false;
            this.checkBoxMaxPrice.Click += new System.EventHandler(this.checkBoxMaxPrice_Click);
            // 
            // checkBoxMinPrice
            // 
            this.checkBoxMinPrice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.checkBoxMinPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxMinPrice.Location = new System.Drawing.Point(9, 132);
            this.checkBoxMinPrice.Name = "checkBoxMinPrice";
            this.checkBoxMinPrice.Size = new System.Drawing.Size(157, 25);
            this.checkBoxMinPrice.TabIndex = 11;
            this.checkBoxMinPrice.Text = "Min Price";
            this.checkBoxMinPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxMinPrice.UseVisualStyleBackColor = false;
            this.checkBoxMinPrice.Click += new System.EventHandler(this.checkBoxMinPrice_Click);
            // 
            // checkBoxMinPages
            // 
            this.checkBoxMinPages.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.checkBoxMinPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxMinPages.Location = new System.Drawing.Point(9, 193);
            this.checkBoxMinPages.Name = "checkBoxMinPages";
            this.checkBoxMinPages.Size = new System.Drawing.Size(157, 25);
            this.checkBoxMinPages.TabIndex = 15;
            this.checkBoxMinPages.Text = "Min Pages";
            this.checkBoxMinPages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxMinPages.UseVisualStyleBackColor = false;
            this.checkBoxMinPages.Click += new System.EventHandler(this.checkBoxMinPages_Click);
            // 
            // checkBoxMaxPages
            // 
            this.checkBoxMaxPages.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.checkBoxMaxPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxMaxPages.Location = new System.Drawing.Point(9, 162);
            this.checkBoxMaxPages.Name = "checkBoxMaxPages";
            this.checkBoxMaxPages.Size = new System.Drawing.Size(157, 25);
            this.checkBoxMaxPages.TabIndex = 14;
            this.checkBoxMaxPages.Text = "Max Pages";
            this.checkBoxMaxPages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxMaxPages.UseVisualStyleBackColor = false;
            this.checkBoxMaxPages.Click += new System.EventHandler(this.checkBoxMaxPages_Click);
            // 
            // trackBarMinPages
            // 
            this.trackBarMinPages.AutoSize = false;
            this.trackBarMinPages.LargeChange = 0;
            this.trackBarMinPages.Location = new System.Drawing.Point(172, 193);
            this.trackBarMinPages.Maximum = 15000;
            this.trackBarMinPages.Name = "trackBarMinPages";
            this.trackBarMinPages.Size = new System.Drawing.Size(304, 25);
            this.trackBarMinPages.TabIndex = 13;
            this.trackBarMinPages.TickFrequency = 0;
            this.trackBarMinPages.Scroll += new System.EventHandler(this.trackBarMinPages_Scroll);
            // 
            // trackBarMaxPages
            // 
            this.trackBarMaxPages.AutoSize = false;
            this.trackBarMaxPages.LargeChange = 0;
            this.trackBarMaxPages.Location = new System.Drawing.Point(172, 168);
            this.trackBarMaxPages.Maximum = 15000;
            this.trackBarMaxPages.Name = "trackBarMaxPages";
            this.trackBarMaxPages.Size = new System.Drawing.Size(304, 25);
            this.trackBarMaxPages.TabIndex = 12;
            this.trackBarMaxPages.TickFrequency = 0;
            this.trackBarMaxPages.Scroll += new System.EventHandler(this.trackBarMaxPages_Scroll);
            // 
            // comboBoxGenreFl
            // 
            this.comboBoxGenreFl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBoxGenreFl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenreFl.FormattingEnabled = true;
            this.comboBoxGenreFl.Location = new System.Drawing.Point(170, 223);
            this.comboBoxGenreFl.Name = "comboBoxGenreFl";
            this.comboBoxGenreFl.Size = new System.Drawing.Size(83, 24);
            this.comboBoxGenreFl.TabIndex = 16;
            this.comboBoxGenreFl.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenreFl_SelectedIndexChanged);
            // 
            // labelGenre
            // 
            this.labelGenre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGenre.Location = new System.Drawing.Point(9, 223);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(157, 25);
            this.labelGenre.TabIndex = 17;
            this.labelGenre.Text = "Genre";
            this.labelGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(259, 223);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(217, 24);
            this.comboBoxGenre.TabIndex = 18;
            this.comboBoxGenre.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenre_SelectedIndexChanged);
            // 
            // comboBoxSelectedGenres
            // 
            this.comboBoxSelectedGenres.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBoxSelectedGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectedGenres.FormattingEnabled = true;
            this.comboBoxSelectedGenres.Location = new System.Drawing.Point(172, 259);
            this.comboBoxSelectedGenres.Name = "comboBoxSelectedGenres";
            this.comboBoxSelectedGenres.Size = new System.Drawing.Size(304, 24);
            this.comboBoxSelectedGenres.TabIndex = 19;
            this.comboBoxSelectedGenres.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectedGenres_SelectedIndexChanged);
            // 
            // labelSelectedGenres
            // 
            this.labelSelectedGenres.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelSelectedGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSelectedGenres.Location = new System.Drawing.Point(9, 259);
            this.labelSelectedGenres.Name = "labelSelectedGenres";
            this.labelSelectedGenres.Size = new System.Drawing.Size(157, 25);
            this.labelSelectedGenres.TabIndex = 20;
            this.labelSelectedGenres.Text = "Selected Genres";
            this.labelSelectedGenres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLanguage
            // 
            this.labelLanguage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLanguage.Location = new System.Drawing.Point(9, 332);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(157, 25);
            this.labelLanguage.TabIndex = 22;
            this.labelLanguage.Text = "Language";
            this.labelLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(172, 334);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(304, 24);
            this.comboBoxLanguage.TabIndex = 21;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddBook.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddBook.Location = new System.Drawing.Point(1142, 9);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(187, 44);
            this.buttonAddBook.TabIndex = 23;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = false;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonEditBook
            // 
            this.buttonEditBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditBook.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonEditBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEditBook.Location = new System.Drawing.Point(1335, 9);
            this.buttonEditBook.Name = "buttonEditBook";
            this.buttonEditBook.Size = new System.Drawing.Size(187, 44);
            this.buttonEditBook.TabIndex = 24;
            this.buttonEditBook.Text = "Edit Book";
            this.buttonEditBook.UseVisualStyleBackColor = false;
            this.buttonEditBook.Click += new System.EventHandler(this.buttonEditBook_Click);
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteBook.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteBook.Location = new System.Drawing.Point(1142, 59);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(187, 44);
            this.buttonDeleteBook.TabIndex = 25;
            this.buttonDeleteBook.Text = "Delete / Restore Book";
            this.buttonDeleteBook.UseVisualStyleBackColor = false;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // buttonRentHistory
            // 
            this.buttonRentHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRentHistory.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonRentHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRentHistory.Location = new System.Drawing.Point(1335, 59);
            this.buttonRentHistory.Name = "buttonRentHistory";
            this.buttonRentHistory.Size = new System.Drawing.Size(187, 44);
            this.buttonRentHistory.TabIndex = 26;
            this.buttonRentHistory.Text = "Rent History";
            this.buttonRentHistory.UseVisualStyleBackColor = false;
            this.buttonRentHistory.Click += new System.EventHandler(this.buttonRentHistory_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHistory.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHistory.Location = new System.Drawing.Point(1142, 113);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(187, 44);
            this.buttonHistory.TabIndex = 30;
            this.buttonHistory.Text = "History";
            this.buttonHistory.UseVisualStyleBackColor = false;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // buttonRentedBooks
            // 
            this.buttonRentedBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRentedBooks.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonRentedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRentedBooks.Location = new System.Drawing.Point(1142, 218);
            this.buttonRentedBooks.Name = "buttonRentedBooks";
            this.buttonRentedBooks.Size = new System.Drawing.Size(187, 44);
            this.buttonRentedBooks.TabIndex = 29;
            this.buttonRentedBooks.Text = "Rented Books";
            this.buttonRentedBooks.UseVisualStyleBackColor = false;
            this.buttonRentedBooks.Click += new System.EventHandler(this.buttonRentedBooks_Click);
            // 
            // buttonNotifications
            // 
            this.buttonNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNotifications.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNotifications.Location = new System.Drawing.Point(1142, 168);
            this.buttonNotifications.Name = "buttonNotifications";
            this.buttonNotifications.Size = new System.Drawing.Size(187, 44);
            this.buttonNotifications.TabIndex = 28;
            this.buttonNotifications.Text = "Notifications";
            this.buttonNotifications.UseVisualStyleBackColor = false;
            this.buttonNotifications.Click += new System.EventHandler(this.buttonNotifications_Click);
            // 
            // buttonBorrowBook
            // 
            this.buttonBorrowBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBorrowBook.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBorrowBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBorrowBook.Location = new System.Drawing.Point(1335, 216);
            this.buttonBorrowBook.Name = "buttonBorrowBook";
            this.buttonBorrowBook.Size = new System.Drawing.Size(187, 44);
            this.buttonBorrowBook.TabIndex = 27;
            this.buttonBorrowBook.Text = "Borrow Book";
            this.buttonBorrowBook.UseVisualStyleBackColor = false;
            this.buttonBorrowBook.Click += new System.EventHandler(this.buttonBorrowBook_Click);
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(613, 266);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(909, 532);
            this.listBox.TabIndex = 31;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            // 
            // labelCurrencyType
            // 
            this.labelCurrencyType.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelCurrencyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrencyType.Location = new System.Drawing.Point(9, 296);
            this.labelCurrencyType.Name = "labelCurrencyType";
            this.labelCurrencyType.Size = new System.Drawing.Size(157, 25);
            this.labelCurrencyType.TabIndex = 33;
            this.labelCurrencyType.Text = "Currency Type";
            this.labelCurrencyType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCurrencyType
            // 
            this.comboBoxCurrencyType.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBoxCurrencyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurrencyType.FormattingEnabled = true;
            this.comboBoxCurrencyType.Location = new System.Drawing.Point(172, 298);
            this.comboBoxCurrencyType.Name = "comboBoxCurrencyType";
            this.comboBoxCurrencyType.Size = new System.Drawing.Size(304, 24);
            this.comboBoxCurrencyType.TabIndex = 32;
            // 
            // buttonCards
            // 
            this.buttonCards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCards.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCards.Location = new System.Drawing.Point(1335, 166);
            this.buttonCards.Name = "buttonCards";
            this.buttonCards.Size = new System.Drawing.Size(187, 44);
            this.buttonCards.TabIndex = 35;
            this.buttonCards.Text = "Cards";
            this.buttonCards.UseVisualStyleBackColor = false;
            this.buttonCards.Click += new System.EventHandler(this.buttonCards_Click);
            // 
            // buttonSubscriptions
            // 
            this.buttonSubscriptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubscriptions.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSubscriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSubscriptions.Location = new System.Drawing.Point(1335, 114);
            this.buttonSubscriptions.Name = "buttonSubscriptions";
            this.buttonSubscriptions.Size = new System.Drawing.Size(187, 44);
            this.buttonSubscriptions.TabIndex = 34;
            this.buttonSubscriptions.Text = "Subscriptions";
            this.buttonSubscriptions.UseVisualStyleBackColor = false;
            this.buttonSubscriptions.Click += new System.EventHandler(this.buttonSubscriptions_Click);
            // 
            // buttonClearFilters
            // 
            this.buttonClearFilters.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonClearFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClearFilters.Location = new System.Drawing.Point(9, 364);
            this.buttonClearFilters.Name = "buttonClearFilters";
            this.buttonClearFilters.Size = new System.Drawing.Size(230, 44);
            this.buttonClearFilters.TabIndex = 38;
            this.buttonClearFilters.Text = "Clear Filters";
            this.buttonClearFilters.UseVisualStyleBackColor = false;
            this.buttonClearFilters.Click += new System.EventHandler(this.buttonClearFilters_Click);
            // 
            // buttonShowBooks
            // 
            this.buttonShowBooks.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonShowBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowBooks.Location = new System.Drawing.Point(245, 364);
            this.buttonShowBooks.Name = "buttonShowBooks";
            this.buttonShowBooks.Size = new System.Drawing.Size(231, 44);
            this.buttonShowBooks.TabIndex = 37;
            this.buttonShowBooks.Text = "Show Books";
            this.buttonShowBooks.UseVisualStyleBackColor = false;
            this.buttonShowBooks.Click += new System.EventHandler(this.buttonShowBooks_Click);
            // 
            // labelLoggedIn
            // 
            this.labelLoggedIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoggedIn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelLoggedIn.Location = new System.Drawing.Point(549, 12);
            this.labelLoggedIn.Name = "labelLoggedIn";
            this.labelLoggedIn.Size = new System.Drawing.Size(587, 42);
            this.labelLoggedIn.TabIndex = 39;
            this.labelLoggedIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel.Controls.Add(this.labelMaxPrice);
            this.panel.Controls.Add(this.labelMinPrice);
            this.panel.Controls.Add(this.labelMaxPages);
            this.panel.Controls.Add(this.labelMinPages);
            this.panel.Controls.Add(this.buttonLogout);
            this.panel.Controls.Add(this.buttonRegister);
            this.panel.Controls.Add(this.buttonClearFilters);
            this.panel.Controls.Add(this.labelTitleAuthor);
            this.panel.Controls.Add(this.buttonShowBooks);
            this.panel.Controls.Add(this.buttonLogin);
            this.panel.Controls.Add(this.textBoxTitleAuthor);
            this.panel.Controls.Add(this.trackBarMaxPrice);
            this.panel.Controls.Add(this.labelCurrencyType);
            this.panel.Controls.Add(this.trackBarMinPrice);
            this.panel.Controls.Add(this.comboBoxCurrencyType);
            this.panel.Controls.Add(this.checkBoxMaxPrice);
            this.panel.Controls.Add(this.checkBoxMinPrice);
            this.panel.Controls.Add(this.trackBarMaxPages);
            this.panel.Controls.Add(this.trackBarMinPages);
            this.panel.Controls.Add(this.checkBoxMaxPages);
            this.panel.Controls.Add(this.checkBoxMinPages);
            this.panel.Controls.Add(this.comboBoxGenreFl);
            this.panel.Controls.Add(this.labelGenre);
            this.panel.Controls.Add(this.comboBoxGenre);
            this.panel.Controls.Add(this.comboBoxSelectedGenres);
            this.panel.Controls.Add(this.labelLanguage);
            this.panel.Controls.Add(this.labelSelectedGenres);
            this.panel.Controls.Add(this.comboBoxLanguage);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(531, 418);
            this.panel.TabIndex = 40;
            // 
            // labelMaxPrice
            // 
            this.labelMaxPrice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelMaxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMaxPrice.Location = new System.Drawing.Point(482, 103);
            this.labelMaxPrice.Name = "labelMaxPrice";
            this.labelMaxPrice.Size = new System.Drawing.Size(46, 25);
            this.labelMaxPrice.TabIndex = 42;
            this.labelMaxPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinPrice
            // 
            this.labelMinPrice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelMinPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMinPrice.Location = new System.Drawing.Point(482, 137);
            this.labelMinPrice.Name = "labelMinPrice";
            this.labelMinPrice.Size = new System.Drawing.Size(46, 25);
            this.labelMinPrice.TabIndex = 42;
            this.labelMinPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxPages
            // 
            this.labelMaxPages.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelMaxPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMaxPages.Location = new System.Drawing.Point(482, 168);
            this.labelMaxPages.Name = "labelMaxPages";
            this.labelMaxPages.Size = new System.Drawing.Size(46, 25);
            this.labelMaxPages.TabIndex = 42;
            this.labelMaxPages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinPages
            // 
            this.labelMinPages.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelMinPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMinPages.Location = new System.Drawing.Point(482, 193);
            this.labelMinPages.Name = "labelMinPages";
            this.labelMinPages.Size = new System.Drawing.Size(46, 25);
            this.labelMinPages.TabIndex = 41;
            this.labelMinPages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPending
            // 
            this.labelPending.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPending.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPending.Location = new System.Drawing.Point(343, 555);
            this.labelPending.Name = "labelPending";
            this.labelPending.Size = new System.Drawing.Size(215, 61);
            this.labelPending.TabIndex = 43;
            this.labelPending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InitPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 833);
            this.Controls.Add(this.labelPending);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.labelLoggedIn);
            this.Controls.Add(this.buttonCards);
            this.Controls.Add(this.buttonSubscriptions);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonRentedBooks);
            this.Controls.Add(this.buttonNotifications);
            this.Controls.Add(this.buttonBorrowBook);
            this.Controls.Add(this.buttonRentHistory);
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.buttonEditBook);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.buttonQuit);
            this.Name = "InitPanel";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.InitPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxPages)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelTitleAuthor;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.TextBox textBoxTitleAuthor;
        private System.Windows.Forms.TrackBar trackBarMaxPrice;
        private System.Windows.Forms.TrackBar trackBarMinPrice;
        private System.Windows.Forms.CheckBox checkBoxMaxPrice;
        private System.Windows.Forms.CheckBox checkBoxMinPrice;
        private System.Windows.Forms.CheckBox checkBoxMinPages;
        private System.Windows.Forms.CheckBox checkBoxMaxPages;
        private System.Windows.Forms.TrackBar trackBarMinPages;
        private System.Windows.Forms.TrackBar trackBarMaxPages;
        private System.Windows.Forms.ComboBox comboBoxGenreFl;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.ComboBox comboBoxSelectedGenres;
        private System.Windows.Forms.Label labelSelectedGenres;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonEditBook;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Button buttonRentHistory;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonRentedBooks;
        private System.Windows.Forms.Button buttonNotifications;
        private System.Windows.Forms.Button buttonBorrowBook;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label labelCurrencyType;
        private System.Windows.Forms.ComboBox comboBoxCurrencyType;
        private System.Windows.Forms.Button buttonCards;
        private System.Windows.Forms.Button buttonSubscriptions;
        private System.Windows.Forms.Button buttonClearFilters;
        private System.Windows.Forms.Button buttonShowBooks;
        private System.Windows.Forms.Label labelLoggedIn;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelMaxPrice;
        private System.Windows.Forms.Label labelMinPrice;
        private System.Windows.Forms.Label labelMaxPages;
        private System.Windows.Forms.Label labelMinPages;
        private System.Windows.Forms.Label labelPending;
    }
}

