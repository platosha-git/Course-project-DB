
namespace Tours
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TablesGrid = new System.Windows.Forms.DataGridView();
            this.AllTours = new System.Windows.Forms.Button();
            this.ToursParams = new System.Windows.Forms.GroupBox();
            this.TcomboBoxCity = new System.Windows.Forms.ComboBox();
            this.TlabelCity = new System.Windows.Forms.Label();
            this.TimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.lblDateBegin = new System.Windows.Forms.Label();
            this.TimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.tabSelect = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TgroupBoxAdd = new System.Windows.Forms.GroupBox();
            this.TbuttonChTour = new System.Windows.Forms.Button();
            this.TtextBoxDelTour = new System.Windows.Forms.TextBox();
            this.TbuttonDelTour = new System.Windows.Forms.Button();
            this.TbuttonAdd = new System.Windows.Forms.Button();
            this.TgroupBoxBook = new System.Windows.Forms.GroupBox();
            this.TbuttonDelBook = new System.Windows.Forms.Button();
            this.TtextBoxDeleteBook = new System.Windows.Forms.TextBox();
            this.TtextBoxBookTour = new System.Windows.Forms.TextBox();
            this.TbuttonBook = new System.Windows.Forms.Button();
            this.TbuttonShowBook = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.HgroupBoxManage = new System.Windows.Forms.GroupBox();
            this.HbuttonChange = new System.Windows.Forms.Button();
            this.HtextBoxDelHotel = new System.Windows.Forms.TextBox();
            this.HbuttonDelete = new System.Windows.Forms.Button();
            this.HbuttonAdd = new System.Windows.Forms.Button();
            this.HgroupBoxBook = new System.Windows.Forms.GroupBox();
            this.HbuttonShowBook = new System.Windows.Forms.Button();
            this.HotelParams = new System.Windows.Forms.GroupBox();
            this.HbuttonClearParams = new System.Windows.Forms.Button();
            this.AllHotels = new System.Windows.Forms.Button();
            this.HcheckSwimPool = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FnumericUDStars = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.HcomboBoxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HcomboBoxCity = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.FgroupBoxBook = new System.Windows.Forms.GroupBox();
            this.FbuttonShowBook = new System.Windows.Forms.Button();
            this.FoodParams = new System.Windows.Forms.GroupBox();
            this.FcheckBar = new System.Windows.Forms.CheckBox();
            this.FcheckChildMenu = new System.Windows.Forms.CheckBox();
            this.FcheckVegMenu = new System.Windows.Forms.CheckBox();
            this.FoodLbl1 = new System.Windows.Forms.Label();
            this.FcomboBoxCategory = new System.Windows.Forms.ComboBox();
            this.AllFood = new System.Windows.Forms.Button();
            this.FgroupBoxManage = new System.Windows.Forms.GroupBox();
            this.FbuttonChange = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FbuttonDelete = new System.Windows.Forms.Button();
            this.FbuttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablesGrid)).BeginInit();
            this.ToursParams.SuspendLayout();
            this.tabSelect.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TgroupBoxAdd.SuspendLayout();
            this.TgroupBoxBook.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.HgroupBoxManage.SuspendLayout();
            this.HgroupBoxBook.SuspendLayout();
            this.HotelParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FnumericUDStars)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.FgroupBoxBook.SuspendLayout();
            this.FoodParams.SuspendLayout();
            this.FgroupBoxManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablesGrid
            // 
            this.TablesGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.TablesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablesGrid.Location = new System.Drawing.Point(358, 29);
            this.TablesGrid.Name = "TablesGrid";
            this.TablesGrid.RowHeadersWidth = 51;
            this.TablesGrid.RowTemplate.Height = 29;
            this.TablesGrid.Size = new System.Drawing.Size(1112, 645);
            this.TablesGrid.TabIndex = 0;
            // 
            // AllTours
            // 
            this.AllTours.Location = new System.Drawing.Point(6, 154);
            this.AllTours.Name = "AllTours";
            this.AllTours.Size = new System.Drawing.Size(292, 29);
            this.AllTours.TabIndex = 1;
            this.AllTours.Text = "Показать туры";
            this.AllTours.UseVisualStyleBackColor = true;
            this.AllTours.Click += new System.EventHandler(this.AllTours_Click);
            // 
            // ToursParams
            // 
            this.ToursParams.BackColor = System.Drawing.Color.LightGray;
            this.ToursParams.Controls.Add(this.TcomboBoxCity);
            this.ToursParams.Controls.Add(this.TlabelCity);
            this.ToursParams.Controls.Add(this.TimePickerEnd);
            this.ToursParams.Controls.Add(this.lblDateEnd);
            this.ToursParams.Controls.Add(this.lblDateBegin);
            this.ToursParams.Controls.Add(this.TimePickerBegin);
            this.ToursParams.Controls.Add(this.AllTours);
            this.ToursParams.Location = new System.Drawing.Point(14, 15);
            this.ToursParams.Name = "ToursParams";
            this.ToursParams.Size = new System.Drawing.Size(304, 193);
            this.ToursParams.TabIndex = 3;
            this.ToursParams.TabStop = false;
            this.ToursParams.Text = "Поиск туров";
            // 
            // TcomboBoxCity
            // 
            this.TcomboBoxCity.FormattingEnabled = true;
            this.TcomboBoxCity.Items.AddRange(new object[] {
            "",
            "Москва",
            "Питер",
            "Сочи",
            "Самара",
            "Воронеж",
            "Казань",
            "Челябинск",
            "Владивосток"});
            this.TcomboBoxCity.Location = new System.Drawing.Point(106, 31);
            this.TcomboBoxCity.Name = "TcomboBoxCity";
            this.TcomboBoxCity.Size = new System.Drawing.Size(178, 28);
            this.TcomboBoxCity.TabIndex = 11;
            this.TcomboBoxCity.SelectedIndexChanged += new System.EventHandler(this.TcomboBoxCity_SelectedIndexChanged);
            // 
            // TlabelCity
            // 
            this.TlabelCity.AutoSize = true;
            this.TlabelCity.Location = new System.Drawing.Point(28, 34);
            this.TlabelCity.Name = "TlabelCity";
            this.TlabelCity.Size = new System.Drawing.Size(51, 20);
            this.TlabelCity.TabIndex = 10;
            this.TlabelCity.Text = "Город";
            // 
            // TimePickerEnd
            // 
            this.TimePickerEnd.Location = new System.Drawing.Point(106, 109);
            this.TimePickerEnd.Name = "TimePickerEnd";
            this.TimePickerEnd.Size = new System.Drawing.Size(178, 27);
            this.TimePickerEnd.TabIndex = 8;
            this.TimePickerEnd.Value = new System.DateTime(2022, 12, 1, 0, 0, 0, 0);
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblDateEnd.Location = new System.Drawing.Point(6, 114);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(95, 20);
            this.lblDateEnd.TabIndex = 7;
            this.lblDateEnd.Text = " Дата конца ";
            // 
            // lblDateBegin
            // 
            this.lblDateBegin.AutoSize = true;
            this.lblDateBegin.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblDateBegin.Location = new System.Drawing.Point(8, 81);
            this.lblDateBegin.Name = "lblDateBegin";
            this.lblDateBegin.Size = new System.Drawing.Size(94, 20);
            this.lblDateBegin.TabIndex = 6;
            this.lblDateBegin.Text = "Дата начала";
            // 
            // TimePickerBegin
            // 
            this.TimePickerBegin.Location = new System.Drawing.Point(106, 76);
            this.TimePickerBegin.Name = "TimePickerBegin";
            this.TimePickerBegin.Size = new System.Drawing.Size(178, 27);
            this.TimePickerBegin.TabIndex = 5;
            this.TimePickerBegin.Value = new System.DateTime(2019, 12, 1, 0, 0, 0, 0);
            // 
            // tabSelect
            // 
            this.tabSelect.Controls.Add(this.tabPage1);
            this.tabSelect.Controls.Add(this.tabPage3);
            this.tabSelect.Controls.Add(this.tabPage2);
            this.tabSelect.Location = new System.Drawing.Point(12, 29);
            this.tabSelect.Name = "tabSelect";
            this.tabSelect.SelectedIndex = 0;
            this.tabSelect.Size = new System.Drawing.Size(340, 649);
            this.tabSelect.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TgroupBoxAdd);
            this.tabPage1.Controls.Add(this.TgroupBoxBook);
            this.tabPage1.Controls.Add(this.ToursParams);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(332, 616);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Туры";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TgroupBoxAdd
            // 
            this.TgroupBoxAdd.BackColor = System.Drawing.Color.DarkGray;
            this.TgroupBoxAdd.Controls.Add(this.TbuttonChTour);
            this.TgroupBoxAdd.Controls.Add(this.TtextBoxDelTour);
            this.TgroupBoxAdd.Controls.Add(this.TbuttonDelTour);
            this.TgroupBoxAdd.Controls.Add(this.TbuttonAdd);
            this.TgroupBoxAdd.Location = new System.Drawing.Point(14, 435);
            this.TgroupBoxAdd.Name = "TgroupBoxAdd";
            this.TgroupBoxAdd.Size = new System.Drawing.Size(304, 133);
            this.TgroupBoxAdd.TabIndex = 5;
            this.TgroupBoxAdd.TabStop = false;
            this.TgroupBoxAdd.Text = "Изменение туров";
            // 
            // TbuttonChTour
            // 
            this.TbuttonChTour.Location = new System.Drawing.Point(8, 62);
            this.TbuttonChTour.Name = "TbuttonChTour";
            this.TbuttonChTour.Size = new System.Drawing.Size(290, 29);
            this.TbuttonChTour.TabIndex = 4;
            this.TbuttonChTour.Text = "Изменить тур";
            this.TbuttonChTour.UseVisualStyleBackColor = true;
            this.TbuttonChTour.Click += new System.EventHandler(this.TbuttonChTour_Click);
            // 
            // TtextBoxDelTour
            // 
            this.TtextBoxDelTour.Location = new System.Drawing.Point(8, 95);
            this.TtextBoxDelTour.Name = "TtextBoxDelTour";
            this.TtextBoxDelTour.Size = new System.Drawing.Size(72, 27);
            this.TtextBoxDelTour.TabIndex = 2;
            this.TtextBoxDelTour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TbuttonDelTour
            // 
            this.TbuttonDelTour.Location = new System.Drawing.Point(98, 94);
            this.TbuttonDelTour.Name = "TbuttonDelTour";
            this.TbuttonDelTour.Size = new System.Drawing.Size(200, 29);
            this.TbuttonDelTour.TabIndex = 1;
            this.TbuttonDelTour.Text = "Удалить тур";
            this.TbuttonDelTour.UseVisualStyleBackColor = true;
            this.TbuttonDelTour.Click += new System.EventHandler(this.TbuttonDelTour_Click);
            // 
            // TbuttonAdd
            // 
            this.TbuttonAdd.Location = new System.Drawing.Point(6, 27);
            this.TbuttonAdd.Name = "TbuttonAdd";
            this.TbuttonAdd.Size = new System.Drawing.Size(292, 29);
            this.TbuttonAdd.TabIndex = 0;
            this.TbuttonAdd.Text = "Добавить тур";
            this.TbuttonAdd.UseVisualStyleBackColor = true;
            this.TbuttonAdd.Click += new System.EventHandler(this.TbuttonAdd_Click);
            // 
            // TgroupBoxBook
            // 
            this.TgroupBoxBook.BackColor = System.Drawing.Color.Silver;
            this.TgroupBoxBook.Controls.Add(this.TbuttonDelBook);
            this.TgroupBoxBook.Controls.Add(this.TtextBoxDeleteBook);
            this.TgroupBoxBook.Controls.Add(this.TtextBoxBookTour);
            this.TgroupBoxBook.Controls.Add(this.TbuttonBook);
            this.TgroupBoxBook.Controls.Add(this.TbuttonShowBook);
            this.TgroupBoxBook.Location = new System.Drawing.Point(14, 249);
            this.TgroupBoxBook.Name = "TgroupBoxBook";
            this.TgroupBoxBook.Size = new System.Drawing.Size(304, 144);
            this.TgroupBoxBook.TabIndex = 4;
            this.TgroupBoxBook.TabStop = false;
            this.TgroupBoxBook.Text = "Забронированные туры";
            // 
            // TbuttonDelBook
            // 
            this.TbuttonDelBook.Location = new System.Drawing.Point(98, 105);
            this.TbuttonDelBook.Name = "TbuttonDelBook";
            this.TbuttonDelBook.Size = new System.Drawing.Size(200, 29);
            this.TbuttonDelBook.TabIndex = 4;
            this.TbuttonDelBook.Text = "Отменить бронирование";
            this.TbuttonDelBook.UseVisualStyleBackColor = true;
            this.TbuttonDelBook.Click += new System.EventHandler(this.TbuttonDelBook_Click);
            // 
            // TtextBoxDeleteBook
            // 
            this.TtextBoxDeleteBook.Location = new System.Drawing.Point(6, 108);
            this.TtextBoxDeleteBook.Name = "TtextBoxDeleteBook";
            this.TtextBoxDeleteBook.Size = new System.Drawing.Size(74, 27);
            this.TtextBoxDeleteBook.TabIndex = 3;
            this.TtextBoxDeleteBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TtextBoxBookTour
            // 
            this.TtextBoxBookTour.Location = new System.Drawing.Point(6, 75);
            this.TtextBoxBookTour.Name = "TtextBoxBookTour";
            this.TtextBoxBookTour.Size = new System.Drawing.Size(73, 27);
            this.TtextBoxBookTour.TabIndex = 2;
            this.TtextBoxBookTour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TbuttonBook
            // 
            this.TbuttonBook.Location = new System.Drawing.Point(98, 73);
            this.TbuttonBook.Name = "TbuttonBook";
            this.TbuttonBook.Size = new System.Drawing.Size(200, 29);
            this.TbuttonBook.TabIndex = 1;
            this.TbuttonBook.Text = "Забронировать тур";
            this.TbuttonBook.UseVisualStyleBackColor = true;
            this.TbuttonBook.Click += new System.EventHandler(this.TbuttonBook_Click);
            // 
            // TbuttonShowBook
            // 
            this.TbuttonShowBook.Location = new System.Drawing.Point(6, 38);
            this.TbuttonShowBook.Name = "TbuttonShowBook";
            this.TbuttonShowBook.Size = new System.Drawing.Size(292, 29);
            this.TbuttonShowBook.TabIndex = 0;
            this.TbuttonShowBook.Text = "Показать забронированные туры";
            this.TbuttonShowBook.UseVisualStyleBackColor = true;
            this.TbuttonShowBook.Click += new System.EventHandler(this.TbuttonShowBook_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.HgroupBoxManage);
            this.tabPage3.Controls.Add(this.HgroupBoxBook);
            this.tabPage3.Controls.Add(this.HotelParams);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(332, 616);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Отели";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // HgroupBoxManage
            // 
            this.HgroupBoxManage.BackColor = System.Drawing.Color.DarkGray;
            this.HgroupBoxManage.Controls.Add(this.HbuttonChange);
            this.HgroupBoxManage.Controls.Add(this.HtextBoxDelHotel);
            this.HgroupBoxManage.Controls.Add(this.HbuttonDelete);
            this.HgroupBoxManage.Controls.Add(this.HbuttonAdd);
            this.HgroupBoxManage.Location = new System.Drawing.Point(13, 402);
            this.HgroupBoxManage.Name = "HgroupBoxManage";
            this.HgroupBoxManage.Size = new System.Drawing.Size(304, 133);
            this.HgroupBoxManage.TabIndex = 6;
            this.HgroupBoxManage.TabStop = false;
            this.HgroupBoxManage.Text = "Изменение отелей";
            // 
            // HbuttonChange
            // 
            this.HbuttonChange.Location = new System.Drawing.Point(8, 62);
            this.HbuttonChange.Name = "HbuttonChange";
            this.HbuttonChange.Size = new System.Drawing.Size(290, 29);
            this.HbuttonChange.TabIndex = 4;
            this.HbuttonChange.Text = "Изменить отель";
            this.HbuttonChange.UseVisualStyleBackColor = true;
            this.HbuttonChange.Click += new System.EventHandler(this.HbuttonChange_Click);
            // 
            // HtextBoxDelHotel
            // 
            this.HtextBoxDelHotel.Location = new System.Drawing.Point(8, 95);
            this.HtextBoxDelHotel.Name = "HtextBoxDelHotel";
            this.HtextBoxDelHotel.Size = new System.Drawing.Size(72, 27);
            this.HtextBoxDelHotel.TabIndex = 2;
            this.HtextBoxDelHotel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HbuttonDelete
            // 
            this.HbuttonDelete.Location = new System.Drawing.Point(98, 94);
            this.HbuttonDelete.Name = "HbuttonDelete";
            this.HbuttonDelete.Size = new System.Drawing.Size(200, 29);
            this.HbuttonDelete.TabIndex = 1;
            this.HbuttonDelete.Text = "Удалить отель";
            this.HbuttonDelete.UseVisualStyleBackColor = true;
            this.HbuttonDelete.Click += new System.EventHandler(this.HbuttonDelete_Click);
            // 
            // HbuttonAdd
            // 
            this.HbuttonAdd.Location = new System.Drawing.Point(6, 27);
            this.HbuttonAdd.Name = "HbuttonAdd";
            this.HbuttonAdd.Size = new System.Drawing.Size(292, 29);
            this.HbuttonAdd.TabIndex = 0;
            this.HbuttonAdd.Text = "Добавить отель";
            this.HbuttonAdd.UseVisualStyleBackColor = true;
            this.HbuttonAdd.Click += new System.EventHandler(this.HbuttonAdd_Click);
            // 
            // HgroupBoxBook
            // 
            this.HgroupBoxBook.BackColor = System.Drawing.Color.Silver;
            this.HgroupBoxBook.Controls.Add(this.HbuttonShowBook);
            this.HgroupBoxBook.Location = new System.Drawing.Point(14, 276);
            this.HgroupBoxBook.Name = "HgroupBoxBook";
            this.HgroupBoxBook.Size = new System.Drawing.Size(304, 84);
            this.HgroupBoxBook.TabIndex = 5;
            this.HgroupBoxBook.TabStop = false;
            this.HgroupBoxBook.Text = "Забронированные отели";
            // 
            // HbuttonShowBook
            // 
            this.HbuttonShowBook.Location = new System.Drawing.Point(5, 36);
            this.HbuttonShowBook.Name = "HbuttonShowBook";
            this.HbuttonShowBook.Size = new System.Drawing.Size(292, 29);
            this.HbuttonShowBook.TabIndex = 0;
            this.HbuttonShowBook.Text = "Показать забронированные отели";
            this.HbuttonShowBook.UseVisualStyleBackColor = true;
            this.HbuttonShowBook.Click += new System.EventHandler(this.HbuttonShowBook_Click);
            // 
            // HotelParams
            // 
            this.HotelParams.BackColor = System.Drawing.Color.LightGray;
            this.HotelParams.Controls.Add(this.HbuttonClearParams);
            this.HotelParams.Controls.Add(this.AllHotels);
            this.HotelParams.Controls.Add(this.HcheckSwimPool);
            this.HotelParams.Controls.Add(this.label4);
            this.HotelParams.Controls.Add(this.FnumericUDStars);
            this.HotelParams.Controls.Add(this.label3);
            this.HotelParams.Controls.Add(this.HcomboBoxType);
            this.HotelParams.Controls.Add(this.label2);
            this.HotelParams.Controls.Add(this.label1);
            this.HotelParams.Controls.Add(this.HcomboBoxCity);
            this.HotelParams.Location = new System.Drawing.Point(13, 15);
            this.HotelParams.Name = "HotelParams";
            this.HotelParams.Size = new System.Drawing.Size(305, 227);
            this.HotelParams.TabIndex = 0;
            this.HotelParams.TabStop = false;
            this.HotelParams.Text = "Поиск отеля";
            // 
            // HbuttonClearParams
            // 
            this.HbuttonClearParams.BackColor = System.Drawing.Color.DarkGray;
            this.HbuttonClearParams.Location = new System.Drawing.Point(7, 160);
            this.HbuttonClearParams.Name = "HbuttonClearParams";
            this.HbuttonClearParams.Size = new System.Drawing.Size(290, 26);
            this.HbuttonClearParams.TabIndex = 11;
            this.HbuttonClearParams.Text = "Сбросить все параметры";
            this.HbuttonClearParams.UseVisualStyleBackColor = false;
            this.HbuttonClearParams.Click += new System.EventHandler(this.HbuttonClearParams_Click);
            // 
            // AllHotels
            // 
            this.AllHotels.Location = new System.Drawing.Point(6, 192);
            this.AllHotels.Name = "AllHotels";
            this.AllHotels.Size = new System.Drawing.Size(291, 29);
            this.AllHotels.TabIndex = 10;
            this.AllHotels.Text = "Показать отели";
            this.AllHotels.UseVisualStyleBackColor = true;
            this.AllHotels.Click += new System.EventHandler(this.AllHotels_Click);
            // 
            // HcheckSwimPool
            // 
            this.HcheckSwimPool.AutoSize = true;
            this.HcheckSwimPool.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HcheckSwimPool.Location = new System.Drawing.Point(7, 130);
            this.HcheckSwimPool.Name = "HcheckSwimPool";
            this.HcheckSwimPool.Size = new System.Drawing.Size(88, 24);
            this.HcheckSwimPool.TabIndex = 9;
            this.HcheckSwimPool.Text = "Бассейн";
            this.HcheckSwimPool.UseVisualStyleBackColor = true;
            this.HcheckSwimPool.CheckedChanged += new System.EventHandler(this.HcheckSwimPool_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество звезд";
            // 
            // FnumericUDStars
            // 
            this.FnumericUDStars.Location = new System.Drawing.Point(230, 96);
            this.FnumericUDStars.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.FnumericUDStars.Name = "FnumericUDStars";
            this.FnumericUDStars.Size = new System.Drawing.Size(68, 27);
            this.FnumericUDStars.TabIndex = 7;
            this.FnumericUDStars.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.FnumericUDStars.ValueChanged += new System.EventHandler(this.FnumericUDStars_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тип размещения";
            // 
            // HcomboBoxType
            // 
            this.HcomboBoxType.FormattingEnabled = true;
            this.HcomboBoxType.Items.AddRange(new object[] {
            "",
            "Отель",
            "Апартамент",
            "Хостел",
            "Гостевой дом",
            "Мотель",
            "Вила",
            "Курортный отель",
            "Кемпинг",
            "Постель и завтрак"});
            this.HcomboBoxType.Location = new System.Drawing.Point(148, 61);
            this.HcomboBoxType.Name = "HcomboBoxType";
            this.HcomboBoxType.Size = new System.Drawing.Size(151, 28);
            this.HcomboBoxType.TabIndex = 5;
            this.HcomboBoxType.SelectedIndexChanged += new System.EventHandler(this.HcomboBoxType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Город";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-248, -114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Город";
            // 
            // HcomboBoxCity
            // 
            this.HcomboBoxCity.FormattingEnabled = true;
            this.HcomboBoxCity.Items.AddRange(new object[] {
            "",
            "Москва",
            "Питер",
            "Сочи",
            "Самара",
            "Воронеж",
            "Казань",
            "Челябинск",
            "Владивосток"});
            this.HcomboBoxCity.Location = new System.Drawing.Point(148, 26);
            this.HcomboBoxCity.Name = "HcomboBoxCity";
            this.HcomboBoxCity.Size = new System.Drawing.Size(151, 28);
            this.HcomboBoxCity.TabIndex = 2;
            this.HcomboBoxCity.SelectedIndexChanged += new System.EventHandler(this.HcomboBoxCity_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.FgroupBoxManage);
            this.tabPage2.Controls.Add(this.FgroupBoxBook);
            this.tabPage2.Controls.Add(this.FoodParams);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(332, 616);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Питание";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FgroupBoxBook
            // 
            this.FgroupBoxBook.BackColor = System.Drawing.Color.Silver;
            this.FgroupBoxBook.Controls.Add(this.FbuttonShowBook);
            this.FgroupBoxBook.Location = new System.Drawing.Point(14, 266);
            this.FgroupBoxBook.Name = "FgroupBoxBook";
            this.FgroupBoxBook.Size = new System.Drawing.Size(304, 84);
            this.FgroupBoxBook.TabIndex = 6;
            this.FgroupBoxBook.TabStop = false;
            this.FgroupBoxBook.Text = "Забронированное питание";
            // 
            // FbuttonShowBook
            // 
            this.FbuttonShowBook.Location = new System.Drawing.Point(5, 36);
            this.FbuttonShowBook.Name = "FbuttonShowBook";
            this.FbuttonShowBook.Size = new System.Drawing.Size(292, 29);
            this.FbuttonShowBook.TabIndex = 0;
            this.FbuttonShowBook.Text = "Показать забронированное питание";
            this.FbuttonShowBook.UseVisualStyleBackColor = true;
            this.FbuttonShowBook.Click += new System.EventHandler(this.FbuttonShowBook_Click);
            // 
            // FoodParams
            // 
            this.FoodParams.BackColor = System.Drawing.Color.LightGray;
            this.FoodParams.Controls.Add(this.FcheckBar);
            this.FoodParams.Controls.Add(this.FcheckChildMenu);
            this.FoodParams.Controls.Add(this.FcheckVegMenu);
            this.FoodParams.Controls.Add(this.FoodLbl1);
            this.FoodParams.Controls.Add(this.FcomboBoxCategory);
            this.FoodParams.Controls.Add(this.AllFood);
            this.FoodParams.Location = new System.Drawing.Point(14, 15);
            this.FoodParams.Name = "FoodParams";
            this.FoodParams.Size = new System.Drawing.Size(304, 216);
            this.FoodParams.TabIndex = 3;
            this.FoodParams.TabStop = false;
            this.FoodParams.Text = "Поиск питания";
            // 
            // FcheckBar
            // 
            this.FcheckBar.AutoSize = true;
            this.FcheckBar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FcheckBar.Location = new System.Drawing.Point(6, 134);
            this.FcheckBar.Name = "FcheckBar";
            this.FcheckBar.Size = new System.Drawing.Size(57, 24);
            this.FcheckBar.TabIndex = 7;
            this.FcheckBar.Text = "Бар";
            this.FcheckBar.UseVisualStyleBackColor = true;
            this.FcheckBar.CheckedChanged += new System.EventHandler(this.FcheckBar_CheckedChanged);
            // 
            // FcheckChildMenu
            // 
            this.FcheckChildMenu.AutoSize = true;
            this.FcheckChildMenu.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FcheckChildMenu.Location = new System.Drawing.Point(6, 104);
            this.FcheckChildMenu.Name = "FcheckChildMenu";
            this.FcheckChildMenu.Size = new System.Drawing.Size(130, 24);
            this.FcheckChildMenu.TabIndex = 6;
            this.FcheckChildMenu.Text = "Детское меню";
            this.FcheckChildMenu.UseVisualStyleBackColor = true;
            this.FcheckChildMenu.CheckedChanged += new System.EventHandler(this.FcheckChildMenu_CheckedChanged);
            // 
            // FcheckVegMenu
            // 
            this.FcheckVegMenu.AutoSize = true;
            this.FcheckVegMenu.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FcheckVegMenu.Location = new System.Drawing.Point(6, 74);
            this.FcheckVegMenu.Name = "FcheckVegMenu";
            this.FcheckVegMenu.Size = new System.Drawing.Size(186, 24);
            this.FcheckVegMenu.TabIndex = 5;
            this.FcheckVegMenu.Text = "Вегетарианское меню";
            this.FcheckVegMenu.UseVisualStyleBackColor = true;
            this.FcheckVegMenu.CheckedChanged += new System.EventHandler(this.FcheckVegMenu_CheckedChanged);
            // 
            // FoodLbl1
            // 
            this.FoodLbl1.AutoSize = true;
            this.FoodLbl1.Location = new System.Drawing.Point(6, 34);
            this.FoodLbl1.Name = "FoodLbl1";
            this.FoodLbl1.Size = new System.Drawing.Size(97, 20);
            this.FoodLbl1.TabIndex = 4;
            this.FoodLbl1.Text = "Тип питания";
            // 
            // FcomboBoxCategory
            // 
            this.FcomboBoxCategory.FormattingEnabled = true;
            this.FcomboBoxCategory.Items.AddRange(new object[] {
            "",
            "Завтрак",
            "Полупансион",
            "Полный пансион",
            "Полный пансион+",
            "Все включено",
            "Континентальный завтрак",
            "Английский завтрак",
            "Американский завтрак"});
            this.FcomboBoxCategory.Location = new System.Drawing.Point(109, 31);
            this.FcomboBoxCategory.Name = "FcomboBoxCategory";
            this.FcomboBoxCategory.Size = new System.Drawing.Size(189, 28);
            this.FcomboBoxCategory.TabIndex = 3;
            this.FcomboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.FcomboBoxCategory_SelectedIndexChanged);
            // 
            // AllFood
            // 
            this.AllFood.Location = new System.Drawing.Point(6, 179);
            this.AllFood.Name = "AllFood";
            this.AllFood.Size = new System.Drawing.Size(292, 29);
            this.AllFood.TabIndex = 2;
            this.AllFood.Text = "Показать питание";
            this.AllFood.UseVisualStyleBackColor = true;
            this.AllFood.Click += new System.EventHandler(this.AllFood_Click);
            // 
            // FgroupBoxManage
            // 
            this.FgroupBoxManage.BackColor = System.Drawing.Color.DarkGray;
            this.FgroupBoxManage.Controls.Add(this.FbuttonChange);
            this.FgroupBoxManage.Controls.Add(this.textBox1);
            this.FgroupBoxManage.Controls.Add(this.FbuttonDelete);
            this.FgroupBoxManage.Controls.Add(this.FbuttonAdd);
            this.FgroupBoxManage.Location = new System.Drawing.Point(14, 388);
            this.FgroupBoxManage.Name = "FgroupBoxManage";
            this.FgroupBoxManage.Size = new System.Drawing.Size(304, 133);
            this.FgroupBoxManage.TabIndex = 7;
            this.FgroupBoxManage.TabStop = false;
            this.FgroupBoxManage.Text = "Изменение питания";
            // 
            // FbuttonChange
            // 
            this.FbuttonChange.Location = new System.Drawing.Point(8, 62);
            this.FbuttonChange.Name = "FbuttonChange";
            this.FbuttonChange.Size = new System.Drawing.Size(290, 29);
            this.FbuttonChange.TabIndex = 4;
            this.FbuttonChange.Text = "Изменить питание";
            this.FbuttonChange.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FbuttonDelete
            // 
            this.FbuttonDelete.Location = new System.Drawing.Point(98, 94);
            this.FbuttonDelete.Name = "FbuttonDelete";
            this.FbuttonDelete.Size = new System.Drawing.Size(200, 29);
            this.FbuttonDelete.TabIndex = 1;
            this.FbuttonDelete.Text = "Удалить питание";
            this.FbuttonDelete.UseVisualStyleBackColor = true;
            // 
            // FbuttonAdd
            // 
            this.FbuttonAdd.Location = new System.Drawing.Point(6, 27);
            this.FbuttonAdd.Name = "FbuttonAdd";
            this.FbuttonAdd.Size = new System.Drawing.Size(292, 29);
            this.FbuttonAdd.TabIndex = 0;
            this.FbuttonAdd.Text = "Добавить питание";
            this.FbuttonAdd.UseVisualStyleBackColor = true;
            this.FbuttonAdd.Click += new System.EventHandler(this.FbuttonAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 709);
            this.Controls.Add(this.tabSelect);
            this.Controls.Add(this.TablesGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TablesGrid)).EndInit();
            this.ToursParams.ResumeLayout(false);
            this.ToursParams.PerformLayout();
            this.tabSelect.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.TgroupBoxAdd.ResumeLayout(false);
            this.TgroupBoxAdd.PerformLayout();
            this.TgroupBoxBook.ResumeLayout(false);
            this.TgroupBoxBook.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.HgroupBoxManage.ResumeLayout(false);
            this.HgroupBoxManage.PerformLayout();
            this.HgroupBoxBook.ResumeLayout(false);
            this.HotelParams.ResumeLayout(false);
            this.HotelParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FnumericUDStars)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.FgroupBoxBook.ResumeLayout(false);
            this.FoodParams.ResumeLayout(false);
            this.FoodParams.PerformLayout();
            this.FgroupBoxManage.ResumeLayout(false);
            this.FgroupBoxManage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TablesGrid;
        private System.Windows.Forms.Button AllTours;
        private System.Windows.Forms.GroupBox ToursParams;
        private System.Windows.Forms.DateTimePicker TimePickerBegin;
        private System.Windows.Forms.Label lblDateBegin;
        private System.Windows.Forms.DateTimePicker TimePickerEnd;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.TabControl tabSelect;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox FoodParams;
        private System.Windows.Forms.CheckBox FcheckChildMenu;
        private System.Windows.Forms.CheckBox FcheckVegMenu;
        private System.Windows.Forms.Label FoodLbl1;
        private System.Windows.Forms.ComboBox FcomboBoxCategory;
        private System.Windows.Forms.Button AllFood;
        private System.Windows.Forms.CheckBox FcheckBar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox HotelParams;
        private System.Windows.Forms.Button AllHotels;
        private System.Windows.Forms.CheckBox HcheckSwimPool;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown FnumericUDStars;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox HcomboBoxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox HcomboBoxCity;
        private System.Windows.Forms.Button HbuttonClearParams;
        private System.Windows.Forms.Label TlabelCity;
        private System.Windows.Forms.ComboBox TcomboBoxCity;
        private System.Windows.Forms.GroupBox TgroupBoxBook;
        private System.Windows.Forms.Button TbuttonShowBook;
        private System.Windows.Forms.TextBox TtextBoxBookTour;
        private System.Windows.Forms.Button TbuttonBook;
        private System.Windows.Forms.TextBox TtextBoxDeleteBook;
        private System.Windows.Forms.Button TbuttonDelBook;
        private System.Windows.Forms.GroupBox TgroupBoxAdd;
        private System.Windows.Forms.Button TbuttonAdd;
        private System.Windows.Forms.Button TbuttonDelTour;
        private System.Windows.Forms.TextBox TtextBoxDelTour;
        private System.Windows.Forms.Button TbuttonChTour;
        private System.Windows.Forms.GroupBox HgroupBoxBook;
        private System.Windows.Forms.Button HbuttonShowBook;
        private System.Windows.Forms.GroupBox FgroupBoxBook;
        private System.Windows.Forms.Button FbuttonShowBook;
        private System.Windows.Forms.GroupBox HgroupBoxManage;
        private System.Windows.Forms.Button HbuttonChange;
        private System.Windows.Forms.TextBox HtextBoxDelHotel;
        private System.Windows.Forms.Button HbuttonDelete;
        private System.Windows.Forms.Button HbuttonAdd;
        private System.Windows.Forms.GroupBox FgroupBoxManage;
        private System.Windows.Forms.Button FbuttonChange;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button FbuttonDelete;
        private System.Windows.Forms.Button FbuttonAdd;
    }
}

