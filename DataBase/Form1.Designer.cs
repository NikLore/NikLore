namespace DataBase
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.INPUT = new System.Windows.Forms.TabControl();
            this.Кли = new System.Windows.Forms.TabPage();
            this.btn_del_t1 = new System.Windows.Forms.Button();
            this.btn_upp_t1 = new System.Windows.Forms.Button();
            this.btn_input_t1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.Расчеты = new System.Windows.Forms.TabPage();
            this.btn_del_t2 = new System.Windows.Forms.Button();
            this.btn_upp_t2 = new System.Windows.Forms.Button();
            this.btn_inp_t2 = new System.Windows.Forms.Button();
            this.btn_sel_t2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Сотрудники = new System.Windows.Forms.TabPage();
            this.btn_del_t3 = new System.Windows.Forms.Button();
            this.btn_upp_t3 = new System.Windows.Forms.Button();
            this.btn__inp_t3 = new System.Windows.Forms.Button();
            this.btn_sel_t3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Услуги = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.График = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChart2 = new LiveCharts.Wpf.CartesianChart();
            this.INPUT.SuspendLayout();
            this.Кли.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Расчеты.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Сотрудники.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.Услуги.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.График.SuspendLayout();
            this.SuspendLayout();
            // 
            // INPUT
            // 
            this.INPUT.Controls.Add(this.Кли);
            this.INPUT.Controls.Add(this.Расчеты);
            this.INPUT.Controls.Add(this.Сотрудники);
            this.INPUT.Controls.Add(this.Услуги);
            this.INPUT.Controls.Add(this.График);
            this.INPUT.Location = new System.Drawing.Point(12, 12);
            this.INPUT.Name = "INPUT";
            this.INPUT.SelectedIndex = 0;
            this.INPUT.Size = new System.Drawing.Size(776, 426);
            this.INPUT.TabIndex = 0;
            // 
            // Кли
            // 
            this.Кли.Controls.Add(this.btn_del_t1);
            this.Кли.Controls.Add(this.btn_upp_t1);
            this.Кли.Controls.Add(this.btn_input_t1);
            this.Кли.Controls.Add(this.dataGridView2);
            this.Кли.Controls.Add(this.button2);
            this.Кли.Location = new System.Drawing.Point(4, 22);
            this.Кли.Name = "Кли";
            this.Кли.Padding = new System.Windows.Forms.Padding(3);
            this.Кли.Size = new System.Drawing.Size(768, 400);
            this.Кли.TabIndex = 0;
            this.Кли.Text = "Клиенты";
            this.Кли.UseVisualStyleBackColor = true;
            // 
            // btn_del_t1
            // 
            this.btn_del_t1.Location = new System.Drawing.Point(575, 329);
            this.btn_del_t1.Name = "btn_del_t1";
            this.btn_del_t1.Size = new System.Drawing.Size(185, 65);
            this.btn_del_t1.TabIndex = 7;
            this.btn_del_t1.Text = "DELETE";
            this.btn_del_t1.UseVisualStyleBackColor = true;
            this.btn_del_t1.Click += new System.EventHandler(this.btn_del_t1_Click);
            // 
            // btn_upp_t1
            // 
            this.btn_upp_t1.Location = new System.Drawing.Point(384, 329);
            this.btn_upp_t1.Name = "btn_upp_t1";
            this.btn_upp_t1.Size = new System.Drawing.Size(185, 65);
            this.btn_upp_t1.TabIndex = 6;
            this.btn_upp_t1.Text = "UPDATE";
            this.btn_upp_t1.UseVisualStyleBackColor = true;
            this.btn_upp_t1.Click += new System.EventHandler(this.btn_upp_t1_Click);
            // 
            // btn_input_t1
            // 
            this.btn_input_t1.Location = new System.Drawing.Point(194, 329);
            this.btn_input_t1.Name = "btn_input_t1";
            this.btn_input_t1.Size = new System.Drawing.Size(185, 65);
            this.btn_input_t1.TabIndex = 5;
            this.btn_input_t1.Text = "INPUT";
            this.btn_input_t1.UseVisualStyleBackColor = true;
            this.btn_input_t1.Click += new System.EventHandler(this.btn_input_t1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(755, 315);
            this.dataGridView2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.AccessibleName = "";
            this.button2.Location = new System.Drawing.Point(3, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 65);
            this.button2.TabIndex = 3;
            this.button2.Text = "SELECT ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // Расчеты
            // 
            this.Расчеты.AutoScroll = true;
            this.Расчеты.Controls.Add(this.btn_del_t2);
            this.Расчеты.Controls.Add(this.btn_upp_t2);
            this.Расчеты.Controls.Add(this.btn_inp_t2);
            this.Расчеты.Controls.Add(this.btn_sel_t2);
            this.Расчеты.Controls.Add(this.dataGridView1);
            this.Расчеты.Location = new System.Drawing.Point(4, 22);
            this.Расчеты.Name = "Расчеты";
            this.Расчеты.Padding = new System.Windows.Forms.Padding(3);
            this.Расчеты.Size = new System.Drawing.Size(768, 400);
            this.Расчеты.TabIndex = 1;
            this.Расчеты.Text = "Расчеты с клиентами";
            this.Расчеты.UseVisualStyleBackColor = true;
            // 
            // btn_del_t2
            // 
            this.btn_del_t2.Location = new System.Drawing.Point(579, 330);
            this.btn_del_t2.Name = "btn_del_t2";
            this.btn_del_t2.Size = new System.Drawing.Size(185, 65);
            this.btn_del_t2.TabIndex = 11;
            this.btn_del_t2.Text = "DELETE";
            this.btn_del_t2.UseVisualStyleBackColor = true;
            this.btn_del_t2.Click += new System.EventHandler(this.btn_del_t2_Click);
            // 
            // btn_upp_t2
            // 
            this.btn_upp_t2.Location = new System.Drawing.Point(388, 330);
            this.btn_upp_t2.Name = "btn_upp_t2";
            this.btn_upp_t2.Size = new System.Drawing.Size(185, 65);
            this.btn_upp_t2.TabIndex = 10;
            this.btn_upp_t2.Text = "UPDATE";
            this.btn_upp_t2.UseVisualStyleBackColor = true;
            this.btn_upp_t2.Click += new System.EventHandler(this.btn_upp_t2_Click);
            // 
            // btn_inp_t2
            // 
            this.btn_inp_t2.Location = new System.Drawing.Point(198, 330);
            this.btn_inp_t2.Name = "btn_inp_t2";
            this.btn_inp_t2.Size = new System.Drawing.Size(185, 65);
            this.btn_inp_t2.TabIndex = 9;
            this.btn_inp_t2.Text = "INPUT";
            this.btn_inp_t2.UseVisualStyleBackColor = true;
            this.btn_inp_t2.Click += new System.EventHandler(this.btn_inp_t2_Click);
            // 
            // btn_sel_t2
            // 
            this.btn_sel_t2.AccessibleName = "";
            this.btn_sel_t2.Location = new System.Drawing.Point(7, 329);
            this.btn_sel_t2.Name = "btn_sel_t2";
            this.btn_sel_t2.Size = new System.Drawing.Size(185, 65);
            this.btn_sel_t2.TabIndex = 8;
            this.btn_sel_t2.Text = "SELECT ";
            this.btn_sel_t2.UseVisualStyleBackColor = true;
            this.btn_sel_t2.Click += new System.EventHandler(this.btn_sel_t2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // Сотрудники
            // 
            this.Сотрудники.Controls.Add(this.btn_del_t3);
            this.Сотрудники.Controls.Add(this.btn_upp_t3);
            this.Сотрудники.Controls.Add(this.btn__inp_t3);
            this.Сотрудники.Controls.Add(this.btn_sel_t3);
            this.Сотрудники.Controls.Add(this.dataGridView3);
            this.Сотрудники.Location = new System.Drawing.Point(4, 22);
            this.Сотрудники.Name = "Сотрудники";
            this.Сотрудники.Padding = new System.Windows.Forms.Padding(3);
            this.Сотрудники.Size = new System.Drawing.Size(768, 400);
            this.Сотрудники.TabIndex = 2;
            this.Сотрудники.Text = "Сотрудники";
            this.Сотрудники.UseVisualStyleBackColor = true;
            // 
            // btn_del_t3
            // 
            this.btn_del_t3.Location = new System.Drawing.Point(578, 329);
            this.btn_del_t3.Name = "btn_del_t3";
            this.btn_del_t3.Size = new System.Drawing.Size(185, 65);
            this.btn_del_t3.TabIndex = 11;
            this.btn_del_t3.Text = "DELETE";
            this.btn_del_t3.UseVisualStyleBackColor = true;
            this.btn_del_t3.Click += new System.EventHandler(this.btn_del_t3_Click);
            // 
            // btn_upp_t3
            // 
            this.btn_upp_t3.Location = new System.Drawing.Point(387, 329);
            this.btn_upp_t3.Name = "btn_upp_t3";
            this.btn_upp_t3.Size = new System.Drawing.Size(185, 65);
            this.btn_upp_t3.TabIndex = 10;
            this.btn_upp_t3.Text = "UPDATE";
            this.btn_upp_t3.UseVisualStyleBackColor = true;
            this.btn_upp_t3.Click += new System.EventHandler(this.btn_upp_t3_Click);
            // 
            // btn__inp_t3
            // 
            this.btn__inp_t3.Location = new System.Drawing.Point(197, 329);
            this.btn__inp_t3.Name = "btn__inp_t3";
            this.btn__inp_t3.Size = new System.Drawing.Size(185, 65);
            this.btn__inp_t3.TabIndex = 9;
            this.btn__inp_t3.Text = "INPUT";
            this.btn__inp_t3.UseVisualStyleBackColor = true;
            this.btn__inp_t3.Click += new System.EventHandler(this.btn__inp_t3_Click);
            // 
            // btn_sel_t3
            // 
            this.btn_sel_t3.AccessibleName = "";
            this.btn_sel_t3.Location = new System.Drawing.Point(6, 328);
            this.btn_sel_t3.Name = "btn_sel_t3";
            this.btn_sel_t3.Size = new System.Drawing.Size(185, 65);
            this.btn_sel_t3.TabIndex = 8;
            this.btn_sel_t3.Text = "SELECT ";
            this.btn_sel_t3.UseVisualStyleBackColor = true;
            this.btn_sel_t3.Click += new System.EventHandler(this.btn_sel_t3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(7, 7);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(755, 315);
            this.dataGridView3.TabIndex = 0;
            // 
            // Услуги
            // 
            this.Услуги.Controls.Add(this.button1);
            this.Услуги.Controls.Add(this.button4);
            this.Услуги.Controls.Add(this.button5);
            this.Услуги.Controls.Add(this.button6);
            this.Услуги.Controls.Add(this.dataGridView4);
            this.Услуги.Location = new System.Drawing.Point(4, 22);
            this.Услуги.Name = "Услуги";
            this.Услуги.Size = new System.Drawing.Size(768, 400);
            this.Услуги.TabIndex = 3;
            this.Услуги.Text = "Услуги";
            this.Услуги.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 65);
            this.button1.TabIndex = 16;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(387, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 65);
            this.button4.TabIndex = 15;
            this.button4.Text = "UPDATE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(197, 329);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 65);
            this.button5.TabIndex = 14;
            this.button5.Text = "INPUT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.AccessibleName = "";
            this.button6.Location = new System.Drawing.Point(6, 328);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(185, 65);
            this.button6.TabIndex = 13;
            this.button6.Text = "SELECT ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(7, 7);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(755, 315);
            this.dataGridView4.TabIndex = 12;
            // 
            // График
            // 
            this.График.Controls.Add(this.button3);
            this.График.Controls.Add(this.elementHost2);
            this.График.Location = new System.Drawing.Point(4, 22);
            this.График.Name = "График";
            this.График.Size = new System.Drawing.Size(768, 400);
            this.График.TabIndex = 4;
            this.График.Text = "График";
            this.График.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(760, 79);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // elementHost2
            // 
            this.elementHost2.Location = new System.Drawing.Point(4, 13);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(760, 289);
            this.elementHost2.TabIndex = 2;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost2_ChildChanged);
            this.elementHost2.Child = this.cartesianChart2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.INPUT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.INPUT.ResumeLayout(false);
            this.Кли.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Расчеты.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Сотрудники.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.Услуги.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.График.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl INPUT;
        private System.Windows.Forms.TabPage Кли;
        private System.Windows.Forms.TabPage Расчеты;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage Сотрудники;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_del_t1;
        private System.Windows.Forms.Button btn_upp_t1;
        private System.Windows.Forms.Button btn_input_t1;
        private System.Windows.Forms.Button btn_del_t2;
        private System.Windows.Forms.Button btn_upp_t2;
        private System.Windows.Forms.Button btn_inp_t2;
        private System.Windows.Forms.Button btn_sel_t2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_del_t3;
        private System.Windows.Forms.Button btn_upp_t3;
        private System.Windows.Forms.Button btn__inp_t3;
        private System.Windows.Forms.Button btn_sel_t3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage Услуги;
        private System.Windows.Forms.TabPage График;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private LiveCharts.Wpf.CartesianChart cartesianChart2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}

