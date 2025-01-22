namespace CompRepair.WinFormsFrontend.Pages.Subforms
{
    partial class Clients
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btn_add = new Button();
            btn_report = new Button();
            btn_delete = new Button();
            btn_removeFilters = new Button();
            btn_edit = new Button();
            tb_id = new TextBox();
            tb_fullName = new TextBox();
            tb_mail = new TextBox();
            tb_phone = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btn_search = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 9);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1230, 429);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_search);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(tb_phone);
            groupBox1.Controls.Add(tb_mail);
            groupBox1.Controls.Add(tb_fullName);
            groupBox1.Controls.Add(tb_id);
            groupBox1.Location = new Point(9, 438);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(798, 194);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Поиск";
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
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Действия";
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
            // tb_id
            // 
            tb_id.BorderStyle = BorderStyle.FixedSingle;
            tb_id.Font = new Font("Segoe UI", 10.2F);
            tb_id.Location = new Point(151, 31);
            tb_id.Margin = new Padding(5);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(397, 30);
            tb_id.TabIndex = 0;
            // 
            // tb_fullName
            // 
            tb_fullName.BorderStyle = BorderStyle.FixedSingle;
            tb_fullName.Font = new Font("Segoe UI", 10.2F);
            tb_fullName.Location = new Point(151, 62);
            tb_fullName.Margin = new Padding(5);
            tb_fullName.Name = "tb_fullName";
            tb_fullName.Size = new Size(397, 30);
            tb_fullName.TabIndex = 1;
            // 
            // tb_mail
            // 
            tb_mail.BorderStyle = BorderStyle.FixedSingle;
            tb_mail.Font = new Font("Segoe UI", 10.2F);
            tb_mail.Location = new Point(151, 104);
            tb_mail.Margin = new Padding(5);
            tb_mail.Name = "tb_mail";
            tb_mail.Size = new Size(215, 30);
            tb_mail.TabIndex = 2;
            // 
            // tb_phone
            // 
            tb_phone.BorderStyle = BorderStyle.FixedSingle;
            tb_phone.Font = new Font("Segoe UI", 10.2F);
            tb_phone.Location = new Point(151, 140);
            tb_phone.Margin = new Padding(5);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(215, 30);
            tb_phone.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10.2F);
            dateTimePicker1.Location = new Point(376, 141);
            dateTimePicker1.Margin = new Padding(5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 30);
            dateTimePicker1.TabIndex = 4;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(48, 23);
            label2.TabIndex = 7;
            label2.Text = "ФИО";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(6, 106);
            label3.Name = "label3";
            label3.Size = new Size(58, 23);
            label3.TabIndex = 8;
            label3.Text = "Почта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(6, 147);
            label4.Name = "label4";
            label4.Size = new Size(143, 23);
            label4.TabIndex = 9;
            label4.Text = "Номер телефона";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(374, 106);
            label5.Name = "label5";
            label5.Size = new Size(132, 23);
            label5.TabIndex = 10;
            label5.Text = "Дата рождения";
            // 
            // Clients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 641);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Clients";
            Text = "Клиенты";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_edit;
        private Button btn_removeFilters;
        private Button btn_delete;
        private Button btn_report;
        private Button btn_add;
        private TextBox tb_fullName;
        private TextBox tb_id;
        private TextBox tb_mail;
        private TextBox tb_phone;
        private Button btn_search;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}