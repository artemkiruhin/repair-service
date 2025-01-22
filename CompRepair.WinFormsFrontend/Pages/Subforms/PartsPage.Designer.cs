namespace CompRepair.WinFormsFrontend.Pages.Subforms
{
    partial class PartsPage
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_search = new Button();
            tb_quantity = new TextBox();
            tb_price = new TextBox();
            tb_fullName = new TextBox();
            btn_edit = new Button();
            btn_removeFilters = new Button();
            btn_delete = new Button();
            btn_report = new Button();
            btn_add = new Button();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            tb_id = new TextBox();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            cb_manufacturer = new ComboBox();
            cb_category = new ComboBox();
            label6 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(6, 147);
            label4.Name = "label4";
            label4.Size = new Size(102, 23);
            label4.TabIndex = 9;
            label4.Text = "Количество";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(6, 106);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 8;
            label3.Text = "Цена";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 7;
            label2.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(27, 23);
            label1.TabIndex = 6;
            label1.Text = "ID";
            // 
            // btn_search
            // 
            btn_search.BackColor = SystemColors.AppWorkspace;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Segoe UI", 10.2F);
            btn_search.Location = new Point(666, 20);
            btn_search.Margin = new Padding(0);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(129, 41);
            btn_search.TabIndex = 5;
            btn_search.Text = "Поиск";
            btn_search.UseVisualStyleBackColor = false;
            // 
            // tb_quantity
            // 
            tb_quantity.BorderStyle = BorderStyle.FixedSingle;
            tb_quantity.Font = new Font("Segoe UI", 10.2F);
            tb_quantity.Location = new Point(151, 140);
            tb_quantity.Margin = new Padding(5);
            tb_quantity.Name = "tb_quantity";
            tb_quantity.Size = new Size(61, 30);
            tb_quantity.TabIndex = 3;
            // 
            // tb_price
            // 
            tb_price.BorderStyle = BorderStyle.FixedSingle;
            tb_price.Font = new Font("Segoe UI", 10.2F);
            tb_price.Location = new Point(151, 104);
            tb_price.Margin = new Padding(5);
            tb_price.Name = "tb_price";
            tb_price.Size = new Size(107, 30);
            tb_price.TabIndex = 2;
            // 
            // tb_fullName
            // 
            tb_fullName.BorderStyle = BorderStyle.FixedSingle;
            tb_fullName.Font = new Font("Segoe UI", 10.2F);
            tb_fullName.Location = new Point(151, 62);
            tb_fullName.Margin = new Padding(5);
            tb_fullName.Name = "tb_fullName";
            tb_fullName.Size = new Size(215, 30);
            tb_fullName.TabIndex = 1;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.Gold;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.Font = new Font("Segoe UI", 10.2F);
            btn_edit.Location = new Point(3, 64);
            btn_edit.Margin = new Padding(0);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(190, 41);
            btn_edit.TabIndex = 4;
            btn_edit.Text = "Изменить";
            btn_edit.UseVisualStyleBackColor = false;
            // 
            // btn_removeFilters
            // 
            btn_removeFilters.BackColor = SystemColors.AppWorkspace;
            btn_removeFilters.FlatStyle = FlatStyle.Flat;
            btn_removeFilters.Font = new Font("Segoe UI", 10.2F);
            btn_removeFilters.Location = new Point(297, 104);
            btn_removeFilters.Margin = new Padding(0);
            btn_removeFilters.Name = "btn_removeFilters";
            btn_removeFilters.Size = new Size(129, 82);
            btn_removeFilters.TabIndex = 3;
            btn_removeFilters.Text = "Сброс фильтров";
            btn_removeFilters.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI", 10.2F);
            btn_delete.Location = new Point(3, 106);
            btn_delete.Margin = new Padding(0);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(190, 41);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Удалить";
            btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_report
            // 
            btn_report.BackColor = Color.PaleGreen;
            btn_report.FlatStyle = FlatStyle.Flat;
            btn_report.Font = new Font("Segoe UI", 10.2F);
            btn_report.Location = new Point(3, 147);
            btn_report.Margin = new Padding(0);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(190, 41);
            btn_report.TabIndex = 1;
            btn_report.Text = "Отчет";
            btn_report.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.LimeGreen;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 10.2F);
            btn_add.Location = new Point(3, 23);
            btn_add.Margin = new Padding(0);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(190, 41);
            btn_add.TabIndex = 0;
            btn_add.Text = "Добавить";
            btn_add.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_edit);
            groupBox2.Controls.Add(btn_removeFilters);
            groupBox2.Controls.Add(btn_delete);
            groupBox2.Controls.Add(btn_report);
            groupBox2.Controls.Add(btn_add);
            groupBox2.Location = new Point(807, 438);
            groupBox2.Margin = new Padding(0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(429, 191);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Действия";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cb_category);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cb_manufacturer);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_search);
            groupBox1.Controls.Add(tb_quantity);
            groupBox1.Controls.Add(tb_price);
            groupBox1.Controls.Add(tb_fullName);
            groupBox1.Controls.Add(tb_id);
            groupBox1.Location = new Point(9, 438);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(798, 194);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Поиск";
            // 
            // tb_id
            // 
            tb_id.BorderStyle = BorderStyle.FixedSingle;
            tb_id.Font = new Font("Segoe UI", 10.2F);
            tb_id.Location = new Point(151, 31);
            tb_id.Margin = new Padding(5);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(231, 30);
            tb_id.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 9);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1230, 429);
            dataGridView1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(374, 66);
            label5.Name = "label5";
            label5.Size = new Size(132, 23);
            label5.TabIndex = 11;
            label5.Text = "Производитель";
            // 
            // cb_manufacturer
            // 
            cb_manufacturer.FormattingEnabled = true;
            cb_manufacturer.Location = new Point(512, 63);
            cb_manufacturer.Name = "cb_manufacturer";
            cb_manufacturer.Size = new Size(151, 28);
            cb_manufacturer.TabIndex = 12;
            // 
            // cb_category
            // 
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(512, 106);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(151, 28);
            cb_category.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(374, 106);
            label6.Name = "label6";
            label6.Size = new Size(91, 23);
            label6.TabIndex = 13;
            label6.Text = "Категория";
            // 
            // PartsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 641);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "PartsPage";
            Text = "Запчасти";
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_search;
        private TextBox tb_quantity;
        private TextBox tb_price;
        private TextBox tb_fullName;
        private Button btn_edit;
        private Button btn_removeFilters;
        private Button btn_delete;
        private Button btn_report;
        private Button btn_add;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox tb_id;
        private DataGridView dataGridView1;
        private ComboBox cb_category;
        private Label label6;
        private ComboBox cb_manufacturer;
        private Label label5;
    }
}