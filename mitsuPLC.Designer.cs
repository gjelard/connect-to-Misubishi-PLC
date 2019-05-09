namespace PLCConn
{
    partial class mitsuPLC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mitsuPLC));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPortNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxCPUType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textBoxIPAddress = new System.Windows.Forms.TextBox();
            this.btnWriteSingle = new System.Windows.Forms.Button();
            this.btnReadSingle = new System.Windows.Forms.Button();
            this.textBoxReadFrom = new System.Windows.Forms.TextBox();
            this.textBoxWriteTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxLogs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxReadBlock = new System.Windows.Forms.TextBox();
            this.btnWriteBlock = new System.Windows.Forms.Button();
            this.btnReadBlock = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxWriteInc = new System.Windows.Forms.TextBox();
            this.textBoxWriteBlockSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxWriteValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.textBoxPortNo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBoxCPUType);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.textBoxIPAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // textBoxPortNo
            // 
            this.textBoxPortNo.Location = new System.Drawing.Point(92, 86);
            this.textBoxPortNo.Name = "textBoxPortNo";
            this.textBoxPortNo.Size = new System.Drawing.Size(74, 20);
            this.textBoxPortNo.TabIndex = 10;
            this.textBoxPortNo.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Port #:";
            // 
            // comboBoxCPUType
            // 
            this.comboBoxCPUType.AllowDrop = true;
            this.comboBoxCPUType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCPUType.FormattingEnabled = true;
            this.comboBoxCPUType.Location = new System.Drawing.Point(92, 57);
            this.comboBoxCPUType.Name = "comboBoxCPUType";
            this.comboBoxCPUType.Size = new System.Drawing.Size(160, 21);
            this.comboBoxCPUType.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "CPU Type:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(265, 31);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(72, 33);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // textBoxIPAddress
            // 
            this.textBoxIPAddress.Location = new System.Drawing.Point(92, 31);
            this.textBoxIPAddress.Name = "textBoxIPAddress";
            this.textBoxIPAddress.Size = new System.Drawing.Size(160, 20);
            this.textBoxIPAddress.TabIndex = 3;
            this.textBoxIPAddress.Text = "10.10.35.22";
            // 
            // btnWriteSingle
            // 
            this.btnWriteSingle.Location = new System.Drawing.Point(146, 78);
            this.btnWriteSingle.Name = "btnWriteSingle";
            this.btnWriteSingle.Size = new System.Drawing.Size(79, 22);
            this.btnWriteSingle.TabIndex = 8;
            this.btnWriteSingle.Text = "set single";
            this.btnWriteSingle.UseVisualStyleBackColor = true;
            this.btnWriteSingle.Click += new System.EventHandler(this.BtnWriteSingle_Click);
            // 
            // btnReadSingle
            // 
            this.btnReadSingle.Location = new System.Drawing.Point(138, 77);
            this.btnReadSingle.Name = "btnReadSingle";
            this.btnReadSingle.Size = new System.Drawing.Size(79, 23);
            this.btnReadSingle.TabIndex = 7;
            this.btnReadSingle.Text = "get single";
            this.btnReadSingle.UseVisualStyleBackColor = true;
            this.btnReadSingle.Click += new System.EventHandler(this.BtnReadSingle_Click);
            // 
            // textBoxReadFrom
            // 
            this.textBoxReadFrom.Location = new System.Drawing.Point(84, 31);
            this.textBoxReadFrom.Name = "textBoxReadFrom";
            this.textBoxReadFrom.Size = new System.Drawing.Size(48, 20);
            this.textBoxReadFrom.TabIndex = 5;
            this.textBoxReadFrom.Text = "D10";
            // 
            // textBoxWriteTo
            // 
            this.textBoxWriteTo.Location = new System.Drawing.Point(92, 31);
            this.textBoxWriteTo.Name = "textBoxWriteTo";
            this.textBoxWriteTo.Size = new System.Drawing.Size(48, 20);
            this.textBoxWriteTo.TabIndex = 4;
            this.textBoxWriteTo.Text = "D10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "device";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxLogs);
            this.groupBox2.Location = new System.Drawing.Point(552, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 302);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Log";
            // 
            // textBoxLogs
            // 
            this.textBoxLogs.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxLogs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxLogs.Location = new System.Drawing.Point(6, 19);
            this.textBoxLogs.Multiline = true;
            this.textBoxLogs.Name = "textBoxLogs";
            this.textBoxLogs.ReadOnly = true;
            this.textBoxLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLogs.Size = new System.Drawing.Size(202, 277);
            this.textBoxLogs.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "device";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "block size";
            // 
            // textBoxReadBlock
            // 
            this.textBoxReadBlock.Location = new System.Drawing.Point(84, 109);
            this.textBoxReadBlock.Name = "textBoxReadBlock";
            this.textBoxReadBlock.Size = new System.Drawing.Size(48, 20);
            this.textBoxReadBlock.TabIndex = 15;
            // 
            // btnWriteBlock
            // 
            this.btnWriteBlock.Location = new System.Drawing.Point(146, 109);
            this.btnWriteBlock.Name = "btnWriteBlock";
            this.btnWriteBlock.Size = new System.Drawing.Size(79, 23);
            this.btnWriteBlock.TabIndex = 17;
            this.btnWriteBlock.Text = "set block";
            this.btnWriteBlock.UseVisualStyleBackColor = true;
            this.btnWriteBlock.Click += new System.EventHandler(this.BtnWriteBlock_Click);
            // 
            // btnReadBlock
            // 
            this.btnReadBlock.Location = new System.Drawing.Point(138, 106);
            this.btnReadBlock.Name = "btnReadBlock";
            this.btnReadBlock.Size = new System.Drawing.Size(79, 23);
            this.btnReadBlock.TabIndex = 18;
            this.btnReadBlock.Text = "get block";
            this.btnReadBlock.UseVisualStyleBackColor = true;
            this.btnReadBlock.Click += new System.EventHandler(this.BtnReadBlock_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxWriteInc);
            this.groupBox3.Controls.Add(this.btnWriteBlock);
            this.groupBox3.Controls.Add(this.textBoxWriteBlockSize);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnWriteSingle);
            this.groupBox3.Controls.Add(this.textBoxWriteValue);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxWriteTo);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(23, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 177);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Write";
            // 
            // textBoxWriteInc
            // 
            this.textBoxWriteInc.Location = new System.Drawing.Point(92, 135);
            this.textBoxWriteInc.Name = "textBoxWriteInc";
            this.textBoxWriteInc.Size = new System.Drawing.Size(48, 20);
            this.textBoxWriteInc.TabIndex = 13;
            this.textBoxWriteInc.Text = "0";
            // 
            // textBoxWriteBlockSize
            // 
            this.textBoxWriteBlockSize.Location = new System.Drawing.Point(92, 109);
            this.textBoxWriteBlockSize.Name = "textBoxWriteBlockSize";
            this.textBoxWriteBlockSize.Size = new System.Drawing.Size(48, 20);
            this.textBoxWriteBlockSize.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "increment by";
            // 
            // textBoxWriteValue
            // 
            this.textBoxWriteValue.Location = new System.Drawing.Point(92, 80);
            this.textBoxWriteValue.Name = "textBoxWriteValue";
            this.textBoxWriteValue.Size = new System.Drawing.Size(48, 20);
            this.textBoxWriteValue.TabIndex = 9;
            this.textBoxWriteValue.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "block size";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnReadBlock);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBoxReadBlock);
            this.groupBox4.Controls.Add(this.btnReadSingle);
            this.groupBox4.Controls.Add(this.textBoxReadFrom);
            this.groupBox4.Location = new System.Drawing.Point(288, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(234, 177);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Read";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 71);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(555, 334);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(47, 13);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "clear log";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(265, 73);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(72, 33);
            this.buttonDisconnect.TabIndex = 11;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click);
            // 
            // mitsuPLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 356);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "mitsuPLC";
            this.Text = "PLC conn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWriteSingle;
        private System.Windows.Forms.Button btnReadSingle;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox textBoxReadFrom;
        private System.Windows.Forms.TextBox textBoxWriteTo;
        private System.Windows.Forms.TextBox textBoxIPAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxLogs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxReadBlock;
        private System.Windows.Forms.Button btnWriteBlock;
        private System.Windows.Forms.Button btnReadBlock;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxWriteInc;
        private System.Windows.Forms.TextBox textBoxWriteBlockSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxWriteValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxCPUType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBoxPortNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonDisconnect;
    }
}

