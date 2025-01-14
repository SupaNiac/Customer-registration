namespace Business.UI.Windows
{
    partial class ClientIncludeForm
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
            this.emailTextBox2 = new System.Windows.Forms.TextBox();
            this.idTextBox3 = new System.Windows.Forms.TextBox();
            this.telTextBox4 = new System.Windows.Forms.TextBox();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.telLabel2 = new System.Windows.Forms.Label();
            this.nameLabel3 = new System.Windows.Forms.Label();
            this.emailLabel4 = new System.Windows.Forms.Label();
            this.addButton1 = new System.Windows.Forms.Button();
            this.backButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailTextBox2
            // 
            this.emailTextBox2.Location = new System.Drawing.Point(66, 124);
            this.emailTextBox2.Name = "emailTextBox2";
            this.emailTextBox2.Size = new System.Drawing.Size(325, 26);
            this.emailTextBox2.TabIndex = 2;
            // 
            // idTextBox3
            // 
            this.idTextBox3.Location = new System.Drawing.Point(66, 78);
            this.idTextBox3.Name = "idTextBox3";
            this.idTextBox3.Size = new System.Drawing.Size(325, 26);
            this.idTextBox3.TabIndex = 3;
            // 
            // telTextBox4
            // 
            this.telTextBox4.Location = new System.Drawing.Point(66, 179);
            this.telTextBox4.Name = "telTextBox4";
            this.telTextBox4.Size = new System.Drawing.Size(325, 26);
            this.telTextBox4.TabIndex = 4;
            // 
            // idLabel1
            // 
            this.idLabel1.AutoSize = true;
            this.idLabel1.Location = new System.Drawing.Point(12, 81);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(26, 20);
            this.idLabel1.TabIndex = 5;
            this.idLabel1.Text = "ID";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Location = new System.Drawing.Point(66, 25);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(325, 26);
            this.nameTextBox1.TabIndex = 6;
            // 
            // telLabel2
            // 
            this.telLabel2.AutoSize = true;
            this.telLabel2.Location = new System.Drawing.Point(12, 182);
            this.telLabel2.Name = "telLabel2";
            this.telLabel2.Size = new System.Drawing.Size(34, 20);
            this.telLabel2.TabIndex = 7;
            this.telLabel2.Text = "Tel:";
            // 
            // nameLabel3
            // 
            this.nameLabel3.AutoSize = true;
            this.nameLabel3.Location = new System.Drawing.Point(5, 31);
            this.nameLabel3.Name = "nameLabel3";
            this.nameLabel3.Size = new System.Drawing.Size(55, 20);
            this.nameLabel3.TabIndex = 8;
            this.nameLabel3.Text = "Name:";
            // 
            // emailLabel4
            // 
            this.emailLabel4.AutoSize = true;
            this.emailLabel4.Location = new System.Drawing.Point(8, 130);
            this.emailLabel4.Name = "emailLabel4";
            this.emailLabel4.Size = new System.Drawing.Size(52, 20);
            this.emailLabel4.TabIndex = 9;
            this.emailLabel4.Text = "Email:";
            // 
            // addButton1
            // 
            this.addButton1.Location = new System.Drawing.Point(66, 234);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(92, 31);
            this.addButton1.TabIndex = 10;
            this.addButton1.Text = "Add";
            this.addButton1.UseVisualStyleBackColor = true;
            // 
            // backButton2
            // 
            this.backButton2.Location = new System.Drawing.Point(303, 234);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(88, 31);
            this.backButton2.TabIndex = 11;
            this.backButton2.Text = "Back";
            this.backButton2.UseVisualStyleBackColor = true;
            // 
            // ClientIncludeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 275);
            this.Controls.Add(this.backButton2);
            this.Controls.Add(this.addButton1);
            this.Controls.Add(this.emailLabel4);
            this.Controls.Add(this.nameLabel3);
            this.Controls.Add(this.telLabel2);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(this.telTextBox4);
            this.Controls.Add(this.idTextBox3);
            this.Controls.Add(this.emailTextBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientIncludeForm";
            this.Text = "Client Inclusion";
            this.Load += new System.EventHandler(this.ClientIncludeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox emailTextBox2;
        private System.Windows.Forms.TextBox idTextBox3;
        private System.Windows.Forms.TextBox telTextBox4;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.Label telLabel2;
        private System.Windows.Forms.Label nameLabel3;
        private System.Windows.Forms.Label emailLabel4;
        private System.Windows.Forms.Button addButton1;
        private System.Windows.Forms.Button backButton2;
    }
}