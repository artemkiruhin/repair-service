using System.ComponentModel;

namespace CompRepair.WinFormsFrontend.Pages;

partial class LoginForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        panel1 = new Panel();
        panel2 = new Panel();
        btn_login = new Button();
        tb_password = new TextBox();
        label2 = new Label();
        tb_login = new TextBox();
        label1 = new Label();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.White;
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Margin = new Padding(0);
        panel1.Name = "panel1";
        panel1.Size = new Size(850, 169);
        panel1.TabIndex = 0;
        // 
        // panel2
        // 
        panel2.BackColor = Color.White;
        panel2.Controls.Add(btn_login);
        panel2.Controls.Add(tb_password);
        panel2.Controls.Add(label2);
        panel2.Controls.Add(tb_login);
        panel2.Controls.Add(label1);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(0, 169);
        panel2.Margin = new Padding(0);
        panel2.Name = "panel2";
        panel2.Size = new Size(850, 454);
        panel2.TabIndex = 1;
        // 
        // btn_login
        // 
        btn_login.BackColor = Color.FromArgb(0, 123, 255);
        btn_login.FlatStyle = FlatStyle.Flat;
        btn_login.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
        btn_login.ForeColor = Color.White;
        btn_login.Location = new Point(109, 348);
        btn_login.Name = "btn_login";
        btn_login.Size = new Size(632, 94);
        btn_login.TabIndex = 4;
        btn_login.Text = "Войти";
        btn_login.UseVisualStyleBackColor = false;
        btn_login.Click += btn_login_Click;
        // 
        // tb_password
        // 
        tb_password.BorderStyle = BorderStyle.FixedSingle;
        tb_password.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
        tb_password.ForeColor = Color.FromArgb(51, 51, 51);
        tb_password.Location = new Point(109, 257);
        tb_password.Margin = new Padding(100, 0, 100, 0);
        tb_password.Name = "tb_password";
        tb_password.Size = new Size(632, 47);
        tb_password.TabIndex = 3;
        tb_password.UseSystemPasswordChar = true;
        // 
        // label2
        // 
        label2.FlatStyle = FlatStyle.Flat;
        label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label2.ForeColor = Color.FromArgb(51, 51, 51);
        label2.Location = new Point(0, 172);
        label2.Margin = new Padding(20, 40, 20, 20);
        label2.Name = "label2";
        label2.Size = new Size(850, 65);
        label2.TabIndex = 2;
        label2.Text = "Пароль";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tb_login
        // 
        tb_login.BorderStyle = BorderStyle.FixedSingle;
        tb_login.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
        tb_login.ForeColor = Color.FromArgb(51, 51, 51);
        tb_login.Location = new Point(109, 85);
        tb_login.Margin = new Padding(100, 0, 100, 0);
        tb_login.Name = "tb_login";
        tb_login.Size = new Size(632, 47);
        tb_login.TabIndex = 1;
        // 
        // label1
        // 
        label1.FlatStyle = FlatStyle.Flat;
        label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label1.ForeColor = Color.FromArgb(51, 51, 51);
        label1.Location = new Point(0, 0);
        label1.Margin = new Padding(20, 40, 20, 20);
        label1.Name = "label1";
        label1.Size = new Size(850, 65);
        label1.TabIndex = 0;
        label1.Text = "Логин";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(850, 623);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Name = "LoginForm";
        Text = "LoginForm";
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private Label label1;
    private TextBox tb_login;
    private Button btn_login;
    private TextBox tb_password;
    private Label label2;
}