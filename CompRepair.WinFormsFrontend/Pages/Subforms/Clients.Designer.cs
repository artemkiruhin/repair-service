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
            label2 = new Label();
            label1 = new Label();
            btn_search = new Button();
            tb_clientData = new TextBox();
            tb_id = new TextBox();
            groupBox2 = new GroupBox();
            btn_edit = new Button();
            btn_removeFilters = new Button();
            btn_delete = new Button();
            btn_report = new Button();
            btn_add = new Button();
            label3 = new Label();
            tb_employeeData = new TextBox();
            label4 = new Label();
            cb_status = new ComboBox();
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
            groupBox1.Controls.Add(cb_status);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tb_employeeData);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_search);
            groupBox1.Controls.Add(tb_clientData);
            groupBox1.Controls.Add(tb_id);
            groupBox1.Location = new Point(9, 438);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(798, 194);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Поиск";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(139, 23);
            label2.TabIndex = 7;
            label2.Text = "Данные клиента";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(119, 23);
            label1.TabIndex = 6;
            label1.Text = "Номер заказа";
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
            // tb_clientData
            // 
            tb_clientData.BorderStyle = BorderStyle.FixedSingle;
            tb_clientData.Font = new Font("Segoe UI", 10.2F);
            tb_clientData.Location = new Point(180, 62);
            tb_clientData.Margin = new Padding(5);
            tb_clientData.Name = "tb_clientData";
            tb_clientData.Size = new Size(228, 30);
            tb_clientData.TabIndex = 1;
            // 
            // tb_id
            // 
            tb_id.BorderStyle = BorderStyle.FixedSingle;
            tb_id.Font = new Font("Segoe UI", 10.2F);
            tb_id.Location = new Point(180, 31);
            tb_id.Margin = new Padding(5);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(397, 30);
            tb_id.TabIndex = 0;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(6, 99);
            label3.Name = "label3";
            label3.Size = new Size(166, 23);
            label3.TabIndex = 12;
            label3.Text = "Данные сотрудника";
            // 
            // tb_employeeData
            // 
            tb_employeeData.BorderStyle = BorderStyle.FixedSingle;
            tb_employeeData.Font = new Font("Segoe UI", 10.2F);
            tb_employeeData.Location = new Point(180, 97);
            tb_employeeData.Margin = new Padding(5);
            tb_employeeData.Name = "tb_employeeData";
            tb_employeeData.Size = new Size(228, 30);
            tb_employeeData.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(6, 134);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 13;
            label4.Text = "Статус";
            // 
            // cb_status
            // 
            cb_status.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cb_status.FormattingEnabled = true;
            cb_status.Location = new Point(180, 131);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(228, 31);
            cb_status.TabIndex = 14;
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
            Text = "Заказы";
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
        private TextBox tb_clientData;
        private TextBox tb_id;
        private Button btn_search;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox tb_employeeData;
        private ComboBox cb_status;
        private Label label4;
    }
}