
namespace XWormRCE
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
            this.components = new System.ComponentModel.Container();
            this.windowHelper = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.portInput = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.hostInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.exploitButton = new Guna.UI2.WinForms.Guna2Button();
            this.keyInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.commandInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.logBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.portInput)).BeginInit();
            this.SuspendLayout();
            // 
            // windowHelper
            // 
            this.windowHelper.ContainerControl = this;
            this.windowHelper.DockForm = false;
            this.windowHelper.DockIndicatorTransparencyValue = 0.6D;
            this.windowHelper.ResizeForm = false;
            this.windowHelper.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(394, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(348, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // portInput
            // 
            this.portInput.BackColor = System.Drawing.Color.Transparent;
            this.portInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.portInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.portInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.portInput.ForeColor = System.Drawing.Color.White;
            this.portInput.Location = new System.Drawing.Point(333, 75);
            this.portInput.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.portInput.Name = "portInput";
            this.portInput.Size = new System.Drawing.Size(95, 30);
            this.portInput.TabIndex = 2;
            this.portInput.UpDownButtonFillColor = System.Drawing.Color.DarkOrange;
            this.portInput.UpDownButtonForeColor = System.Drawing.Color.White;
            this.portInput.Value = new decimal(new int[] {
            7000,
            0,
            0,
            0});
            // 
            // hostInput
            // 
            this.hostInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hostInput.DefaultText = "";
            this.hostInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hostInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.hostInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hostInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hostInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.hostInput.FocusedState.BorderColor = System.Drawing.Color.DarkOrange;
            this.hostInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hostInput.ForeColor = System.Drawing.Color.White;
            this.hostInput.HoverState.BorderColor = System.Drawing.Color.DarkGray;
            this.hostInput.Location = new System.Drawing.Point(12, 39);
            this.hostInput.Name = "hostInput";
            this.hostInput.PasswordChar = '\0';
            this.hostInput.PlaceholderText = "Enter Hostname/IP Address";
            this.hostInput.SelectedText = "";
            this.hostInput.Size = new System.Drawing.Size(416, 30);
            this.hostInput.TabIndex = 3;
            // 
            // exploitButton
            // 
            this.exploitButton.Animated = true;
            this.exploitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exploitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exploitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exploitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exploitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exploitButton.FillColor = System.Drawing.Color.DarkOrange;
            this.exploitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exploitButton.ForeColor = System.Drawing.Color.White;
            this.exploitButton.Location = new System.Drawing.Point(12, 147);
            this.exploitButton.Name = "exploitButton";
            this.exploitButton.Size = new System.Drawing.Size(416, 30);
            this.exploitButton.TabIndex = 4;
            this.exploitButton.Text = "EXPLOIT";
            this.exploitButton.Click += new System.EventHandler(this.exploitButton_Click);
            // 
            // keyInput
            // 
            this.keyInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyInput.DefaultText = "<123456789>";
            this.keyInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.keyInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.keyInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.keyInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.keyInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.keyInput.FocusedState.BorderColor = System.Drawing.Color.DarkOrange;
            this.keyInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.keyInput.ForeColor = System.Drawing.Color.White;
            this.keyInput.HoverState.BorderColor = System.Drawing.Color.DarkGray;
            this.keyInput.Location = new System.Drawing.Point(12, 75);
            this.keyInput.Name = "keyInput";
            this.keyInput.PasswordChar = '\0';
            this.keyInput.PlaceholderText = "Enter XWorm Encryption Key";
            this.keyInput.SelectedText = "";
            this.keyInput.Size = new System.Drawing.Size(315, 30);
            this.keyInput.TabIndex = 3;
            // 
            // commandInput
            // 
            this.commandInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.commandInput.DefaultText = "start cmd.exe /c taskkill /f /im mstsc.exe & start calc.exe";
            this.commandInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.commandInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.commandInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.commandInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.commandInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.commandInput.FocusedState.BorderColor = System.Drawing.Color.DarkOrange;
            this.commandInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.commandInput.ForeColor = System.Drawing.Color.White;
            this.commandInput.HoverState.BorderColor = System.Drawing.Color.DarkGray;
            this.commandInput.Location = new System.Drawing.Point(12, 111);
            this.commandInput.Name = "commandInput";
            this.commandInput.PasswordChar = '\0';
            this.commandInput.PlaceholderText = "Enter command to execute";
            this.commandInput.SelectedText = "";
            this.commandInput.Size = new System.Drawing.Size(416, 30);
            this.commandInput.TabIndex = 5;
            // 
            // logBox
            // 
            this.logBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logBox.DefaultText = "";
            this.logBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.logBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.logBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.logBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.logBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.logBox.FocusedState.BorderColor = System.Drawing.Color.DarkOrange;
            this.logBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logBox.ForeColor = System.Drawing.Color.White;
            this.logBox.HoverState.BorderColor = System.Drawing.Color.DarkGray;
            this.logBox.Location = new System.Drawing.Point(12, 183);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.PasswordChar = '\0';
            this.logBox.PlaceholderText = "";
            this.logBox.ReadOnly = true;
            this.logBox.SelectedText = "";
            this.logBox.Size = new System.Drawing.Size(416, 135);
            this.logBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "XWorm RCE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(440, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.commandInput);
            this.Controls.Add(this.exploitButton);
            this.Controls.Add(this.keyInput);
            this.Controls.Add(this.hostInput);
            this.Controls.Add(this.portInput);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XWormRCE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.portInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm windowHelper;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox hostInput;
        private Guna.UI2.WinForms.Guna2NumericUpDown portInput;
        private Guna.UI2.WinForms.Guna2Button exploitButton;
        private Guna.UI2.WinForms.Guna2TextBox keyInput;
        private Guna.UI2.WinForms.Guna2TextBox commandInput;
        private Guna.UI2.WinForms.Guna2TextBox logBox;
        private System.Windows.Forms.Label label1;
    }
}

