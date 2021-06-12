
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
            this.AllFood = new System.Windows.Forms.Button();
            this.ToursParams = new System.Windows.Forms.GroupBox();
            this.TimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.lblDateBegin = new System.Windows.Forms.Label();
            this.TimePickerBegin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.TablesGrid)).BeginInit();
            this.ToursParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablesGrid
            // 
            this.TablesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablesGrid.Location = new System.Drawing.Point(323, 29);
            this.TablesGrid.Name = "TablesGrid";
            this.TablesGrid.RowHeadersWidth = 51;
            this.TablesGrid.RowTemplate.Height = 29;
            this.TablesGrid.Size = new System.Drawing.Size(1147, 649);
            this.TablesGrid.TabIndex = 0;
            // 
            // AllTours
            // 
            this.AllTours.Location = new System.Drawing.Point(6, 183);
            this.AllTours.Name = "AllTours";
            this.AllTours.Size = new System.Drawing.Size(278, 29);
            this.AllTours.TabIndex = 1;
            this.AllTours.Text = "Показать туры";
            this.AllTours.UseVisualStyleBackColor = true;
            this.AllTours.Click += new System.EventHandler(this.AllTours_Click);
            // 
            // AllFood
            // 
            this.AllFood.Location = new System.Drawing.Point(45, 328);
            this.AllFood.Name = "AllFood";
            this.AllFood.Size = new System.Drawing.Size(191, 29);
            this.AllFood.TabIndex = 2;
            this.AllFood.Text = "Вся еда";
            this.AllFood.UseVisualStyleBackColor = true;
            this.AllFood.Click += new System.EventHandler(this.AllFood_Click);
            // 
            // ToursParams
            // 
            this.ToursParams.Controls.Add(this.TimePickerEnd);
            this.ToursParams.Controls.Add(this.lblDateEnd);
            this.ToursParams.Controls.Add(this.lblDateBegin);
            this.ToursParams.Controls.Add(this.TimePickerBegin);
            this.ToursParams.Controls.Add(this.AllTours);
            this.ToursParams.Location = new System.Drawing.Point(12, 29);
            this.ToursParams.Name = "ToursParams";
            this.ToursParams.Size = new System.Drawing.Size(292, 218);
            this.ToursParams.TabIndex = 3;
            this.ToursParams.TabStop = false;
            this.ToursParams.Text = "Поиск туров";
            // 
            // TimePickerEnd
            // 
            this.TimePickerEnd.Location = new System.Drawing.Point(106, 123);
            this.TimePickerEnd.Name = "TimePickerEnd";
            this.TimePickerEnd.Size = new System.Drawing.Size(178, 27);
            this.TimePickerEnd.TabIndex = 8;
            this.TimePickerEnd.ValueChanged += new System.EventHandler(this.TimePickerEnd_ValueChanged);
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblDateEnd.Location = new System.Drawing.Point(5, 128);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(95, 20);
            this.lblDateEnd.TabIndex = 7;
            this.lblDateEnd.Text = " Дата конца ";
            // 
            // lblDateBegin
            // 
            this.lblDateBegin.AutoSize = true;
            this.lblDateBegin.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblDateBegin.Location = new System.Drawing.Point(6, 93);
            this.lblDateBegin.Name = "lblDateBegin";
            this.lblDateBegin.Size = new System.Drawing.Size(94, 20);
            this.lblDateBegin.TabIndex = 6;
            this.lblDateBegin.Text = "Дата начала";
            // 
            // TimePickerBegin
            // 
            this.TimePickerBegin.Location = new System.Drawing.Point(106, 88);
            this.TimePickerBegin.Name = "TimePickerBegin";
            this.TimePickerBegin.Size = new System.Drawing.Size(178, 27);
            this.TimePickerBegin.TabIndex = 5;
            this.TimePickerBegin.ValueChanged += new System.EventHandler(this.TimePickerBegin_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 709);
            this.Controls.Add(this.ToursParams);
            this.Controls.Add(this.AllFood);
            this.Controls.Add(this.TablesGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TablesGrid)).EndInit();
            this.ToursParams.ResumeLayout(false);
            this.ToursParams.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TablesGrid;
        private System.Windows.Forms.Button AllTours;
        private System.Windows.Forms.Button AllFood;
        private System.Windows.Forms.GroupBox ToursParams;
        private System.Windows.Forms.DateTimePicker TimePickerBegin;
        private System.Windows.Forms.Label lblDateBegin;
        private System.Windows.Forms.DateTimePicker TimePickerEnd;
        private System.Windows.Forms.Label lblDateEnd;
    }
}

