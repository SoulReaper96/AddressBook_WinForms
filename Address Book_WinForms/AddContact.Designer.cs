namespace Address_Book_WinForms
{
    partial class AddContact
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
            label1 = new Label();
            FnameAdd_tb = new TextBox();
            LnameAdd_tb = new TextBox();
            label2 = new Label();
            PnumbAdd_tb = new TextBox();
            label3 = new Label();
            AddrAdd_tb = new TextBox();
            label4 = new Label();
            EmailAdd_tb = new TextBox();
            label5 = new Label();
            SaveAdd_btn = new Button();
            CancelAdd_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 16);
            label1.TabIndex = 0;
            label1.Text = "Firstname:";
            // 
            // FnameAdd_tb
            // 
            FnameAdd_tb.Location = new Point(12, 28);
            FnameAdd_tb.Name = "FnameAdd_tb";
            FnameAdd_tb.Size = new Size(200, 22);
            FnameAdd_tb.TabIndex = 1;
            // 
            // LnameAdd_tb
            // 
            LnameAdd_tb.Location = new Point(12, 72);
            LnameAdd_tb.Name = "LnameAdd_tb";
            LnameAdd_tb.Size = new Size(200, 22);
            LnameAdd_tb.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(68, 16);
            label2.TabIndex = 2;
            label2.Text = "Lastname:";
            // 
            // PnumbAdd_tb
            // 
            PnumbAdd_tb.Location = new Point(12, 116);
            PnumbAdd_tb.Name = "PnumbAdd_tb";
            PnumbAdd_tb.Size = new Size(200, 22);
            PnumbAdd_tb.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(95, 16);
            label3.TabIndex = 4;
            label3.Text = "Phone number:";
            // 
            // AddrAdd_tb
            // 
            AddrAdd_tb.Location = new Point(12, 160);
            AddrAdd_tb.Multiline = true;
            AddrAdd_tb.Name = "AddrAdd_tb";
            AddrAdd_tb.Size = new Size(200, 44);
            AddrAdd_tb.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(59, 16);
            label4.TabIndex = 6;
            label4.Text = "Address:";
            // 
            // EmailAdd_tb
            // 
            EmailAdd_tb.Location = new Point(12, 226);
            EmailAdd_tb.Name = "EmailAdd_tb";
            EmailAdd_tb.Size = new Size(200, 22);
            EmailAdd_tb.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 207);
            label5.Name = "label5";
            label5.Size = new Size(44, 16);
            label5.TabIndex = 8;
            label5.Text = "Email:";
            // 
            // SaveAdd_btn
            // 
            SaveAdd_btn.Location = new Point(12, 254);
            SaveAdd_btn.Name = "SaveAdd_btn";
            SaveAdd_btn.Size = new Size(95, 23);
            SaveAdd_btn.TabIndex = 10;
            SaveAdd_btn.Text = "Save";
            SaveAdd_btn.UseVisualStyleBackColor = true;
            SaveAdd_btn.Click += SaveAdd_btn_Click;
            // 
            // CancelAdd_btn
            // 
            CancelAdd_btn.Location = new Point(117, 254);
            CancelAdd_btn.Name = "CancelAdd_btn";
            CancelAdd_btn.Size = new Size(95, 23);
            CancelAdd_btn.TabIndex = 11;
            CancelAdd_btn.Text = "Cancel";
            CancelAdd_btn.UseVisualStyleBackColor = true;
            CancelAdd_btn.Click += CancelAdd_btn_Click;
            // 
            // AddContact
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(224, 287);
            Controls.Add(CancelAdd_btn);
            Controls.Add(SaveAdd_btn);
            Controls.Add(EmailAdd_tb);
            Controls.Add(label5);
            Controls.Add(AddrAdd_tb);
            Controls.Add(label4);
            Controls.Add(PnumbAdd_tb);
            Controls.Add(label3);
            Controls.Add(LnameAdd_tb);
            Controls.Add(label2);
            Controls.Add(FnameAdd_tb);
            Controls.Add(label1);
            Font = new Font("Arial", 9.75F);
            ForeColor = Color.Black;
            Name = "AddContact";
            Text = "AddContact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox FnameAdd_tb;
        private TextBox LnameAdd_tb;
        private Label label2;
        private TextBox PnumbAdd_tb;
        private Label label3;
        private TextBox AddrAdd_tb;
        private Label label4;
        private TextBox EmailAdd_tb;
        private Label label5;
        private Button SaveAdd_btn;
        private Button CancelAdd_btn;
    }
}