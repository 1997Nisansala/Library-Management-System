namespace Library_Management_System_New
{
    partial class Managestud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Managestud));
            this.lblStatus = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.lbltelno = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.lbldob = new System.Windows.Forms.Label();
            this.btnaddnew = new System.Windows.Forms.Button();
            this.lbladdress = new System.Windows.Forms.Label();
            this.btnfind = new System.Windows.Forms.Button();
            this.lblstname = new System.Windows.Forms.Label();
            this.lblstId = new System.Windows.Forms.Label();
            this.dtm = new System.Windows.Forms.DateTimePicker();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtstname = new System.Windows.Forms.TextBox();
            this.txtstId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.Lavender;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(7, 417);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(763, 30);
            this.lblStatus.TabIndex = 210;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSalmon;
            this.button4.Font = new System.Drawing.Font("Minion Pro", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(552, 335);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 36);
            this.button4.TabIndex = 209;
            this.button4.Text = "<<<Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(625, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 208;
            this.pictureBox1.TabStop = false;
            // 
            // txtmail
            // 
            this.txtmail.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmail.Location = new System.Drawing.Point(218, 319);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(318, 23);
            this.txtmail.TabIndex = 207;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblemail.Location = new System.Drawing.Point(83, 319);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(53, 18);
            this.lblemail.TabIndex = 206;
            this.lblemail.Text = "Email";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnclear.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(552, 258);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(135, 34);
            this.btnclear.TabIndex = 195;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.MediumOrchid;
            this.btndelete.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(552, 201);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(135, 34);
            this.btndelete.TabIndex = 194;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // lbltelno
            // 
            this.lbltelno.AutoSize = true;
            this.lbltelno.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelno.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbltelno.Location = new System.Drawing.Point(83, 218);
            this.lbltelno.Name = "lbltelno";
            this.lbltelno.Size = new System.Drawing.Size(60, 18);
            this.lbltelno.TabIndex = 205;
            this.lbltelno.Text = "Tel No";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(552, 146);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(135, 32);
            this.btnsave.TabIndex = 193;
            this.btnsave.Text = "Update";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbldob.Location = new System.Drawing.Point(83, 266);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(135, 18);
            this.lbldob.TabIndex = 204;
            this.lbldob.Text = "Registered Date";
            // 
            // btnaddnew
            // 
            this.btnaddnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnaddnew.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddnew.Location = new System.Drawing.Point(552, 87);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(135, 32);
            this.btnaddnew.TabIndex = 192;
            this.btnaddnew.Text = "New";
            this.btnaddnew.UseVisualStyleBackColor = false;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbladdress.Location = new System.Drawing.Point(83, 121);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(73, 18);
            this.lbladdress.TabIndex = 203;
            this.lbladdress.Text = "Address";
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.Coral;
            this.btnfind.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfind.Location = new System.Drawing.Point(552, 32);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(135, 35);
            this.btnfind.TabIndex = 191;
            this.btnfind.Text = "Search";
            this.btnfind.UseVisualStyleBackColor = false;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // lblstname
            // 
            this.lblstname.AutoSize = true;
            this.lblstname.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstname.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblstname.Location = new System.Drawing.Point(83, 75);
            this.lblstname.Name = "lblstname";
            this.lblstname.Size = new System.Drawing.Size(120, 18);
            this.lblstname.TabIndex = 202;
            this.lblstname.Text = "Student Name";
            // 
            // lblstId
            // 
            this.lblstId.AutoSize = true;
            this.lblstId.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblstId.Location = new System.Drawing.Point(83, 32);
            this.lblstId.Name = "lblstId";
            this.lblstId.Size = new System.Drawing.Size(91, 18);
            this.lblstId.TabIndex = 201;
            this.lblstId.Text = "Student ID";
            // 
            // dtm
            // 
            this.dtm.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtm.Location = new System.Drawing.Point(218, 264);
            this.dtm.Name = "dtm";
            this.dtm.Size = new System.Drawing.Size(318, 23);
            this.dtm.TabIndex = 200;
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel.Location = new System.Drawing.Point(218, 216);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(200, 23);
            this.txttel.TabIndex = 199;
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(218, 122);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(265, 74);
            this.txtaddress.TabIndex = 198;
            // 
            // txtstname
            // 
            this.txtstname.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstname.Location = new System.Drawing.Point(218, 76);
            this.txtstname.Name = "txtstname";
            this.txtstname.Size = new System.Drawing.Size(318, 23);
            this.txtstname.TabIndex = 197;
            // 
            // txtstId
            // 
            this.txtstId.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstId.Location = new System.Drawing.Point(218, 33);
            this.txtstId.Name = "txtstId";
            this.txtstId.Size = new System.Drawing.Size(265, 23);
            this.txtstId.TabIndex = 196;
            // 
            // Managestud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 452);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.lbltelno);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.btnaddnew);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.lblstname);
            this.Controls.Add(this.lblstId);
            this.Controls.Add(this.dtm);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtstname);
            this.Controls.Add(this.txtstId);
            this.Name = "Managestud";
            this.Text = "Manage Students";
            this.Load += new System.EventHandler(this.Managestud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label lbltelno;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Button btnaddnew;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Label lblstname;
        private System.Windows.Forms.Label lblstId;
        private System.Windows.Forms.DateTimePicker dtm;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtstname;
        private System.Windows.Forms.TextBox txtstId;
    }
}