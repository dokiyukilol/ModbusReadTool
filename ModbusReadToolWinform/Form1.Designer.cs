namespace ModbusReadToolWinform
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.flowParams = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlIp = new System.Windows.Forms.Panel();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.pnlPort = new System.Windows.Forms.Panel();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.pnlSlaveId = new System.Windows.Forms.Panel();
            this.txtSlaveId = new System.Windows.Forms.TextBox();
            this.lblSlaveId = new System.Windows.Forms.Label();
            this.pnlFunctionCode = new System.Windows.Forms.Panel();
            this.cboFunctionCode = new System.Windows.Forms.ComboBox();
            this.lblFunctionCode = new System.Windows.Forms.Label();
            this.pnlStartAddress = new System.Windows.Forms.Panel();
            this.txtStartAddress = new System.Windows.Forms.TextBox();
            this.lblStartAddress = new System.Windows.Forms.Label();
            this.pnlQuantity = new System.Windows.Forms.Panel();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.flowParams.SuspendLayout();
            this.pnlIp.SuspendLayout();
            this.pnlPort.SuspendLayout();
            this.pnlSlaveId.SuspendLayout();
            this.pnlFunctionCode.SuspendLayout();
            this.pnlStartAddress.SuspendLayout();
            this.pnlQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            //
            // splitMain
            //
            this.splitMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitMain.Location = new System.Drawing.Point(2, 1);
            this.splitMain.Name = "splitMain";
            //
            // splitMain.Panel1
            //
            this.splitMain.Panel1.Controls.Add(this.flowParams);
            //
            // splitMain.Panel2
            //
            this.splitMain.Panel2.Controls.Add(this.txtOutput);
            this.splitMain.Size = new System.Drawing.Size(664, 451);
            this.splitMain.SplitterDistance = 221;
            this.splitMain.TabIndex = 0;
            //
            // txtOutput
            //
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(3, 3);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(433, 445);
            this.txtOutput.TabIndex = 0;
            //
            // flowParams
            //
            this.flowParams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowParams.Controls.Add(this.pnlIp);
            this.flowParams.Controls.Add(this.pnlPort);
            this.flowParams.Controls.Add(this.pnlSlaveId);
            this.flowParams.Controls.Add(this.pnlFunctionCode);
            this.flowParams.Controls.Add(this.pnlStartAddress);
            this.flowParams.Controls.Add(this.pnlQuantity);
            this.flowParams.Controls.Add(this.btnTestConnection);
            this.flowParams.Controls.Add(this.btnRead);
            this.flowParams.Controls.Add(this.btnClear);
            this.flowParams.Location = new System.Drawing.Point(0, 3);
            this.flowParams.Name = "flowParams";
            this.flowParams.Size = new System.Drawing.Size(218, 445);
            this.flowParams.TabIndex = 0;
            //
            // pnlIp
            //
            this.pnlIp.Controls.Add(this.txtIp);
            this.pnlIp.Controls.Add(this.lblIp);
            this.pnlIp.Location = new System.Drawing.Point(3, 3);
            this.pnlIp.MinimumSize = new System.Drawing.Size(200, 50);
            this.pnlIp.Name = "pnlIp";
            this.pnlIp.Size = new System.Drawing.Size(200, 50);
            this.pnlIp.TabIndex = 0;
            //
            // txtIp
            //
            this.txtIp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIp.Location = new System.Drawing.Point(97, 13);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(100, 21);
            this.txtIp.TabIndex = 1;
            //
            // lblIp
            //
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(7, 16);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(23, 12);
            this.lblIp.TabIndex = 0;
            this.lblIp.Text = "IP:";
            //
            // pnlPort
            //
            this.pnlPort.Controls.Add(this.txtPort);
            this.pnlPort.Controls.Add(this.lblPort);
            this.pnlPort.Location = new System.Drawing.Point(3, 59);
            this.pnlPort.MinimumSize = new System.Drawing.Size(200, 50);
            this.pnlPort.Name = "pnlPort";
            this.pnlPort.Size = new System.Drawing.Size(200, 50);
            this.pnlPort.TabIndex = 1;
            //
            // txtPort
            //
            this.txtPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPort.Location = new System.Drawing.Point(97, 13);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 21);
            this.txtPort.TabIndex = 1;
            //
            // lblPort
            //
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(7, 16);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(35, 12);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "端口:";
            //
            // pnlSlaveId
            //
            this.pnlSlaveId.Controls.Add(this.txtSlaveId);
            this.pnlSlaveId.Controls.Add(this.lblSlaveId);
            this.pnlSlaveId.Location = new System.Drawing.Point(3, 115);
            this.pnlSlaveId.MinimumSize = new System.Drawing.Size(200, 50);
            this.pnlSlaveId.Name = "pnlSlaveId";
            this.pnlSlaveId.Size = new System.Drawing.Size(200, 50);
            this.pnlSlaveId.TabIndex = 2;
            //
            // txtSlaveId
            //
            this.txtSlaveId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSlaveId.Location = new System.Drawing.Point(97, 13);
            this.txtSlaveId.Name = "txtSlaveId";
            this.txtSlaveId.Size = new System.Drawing.Size(100, 21);
            this.txtSlaveId.TabIndex = 1;
            //
            // lblSlaveId
            //
            this.lblSlaveId.AutoSize = true;
            this.lblSlaveId.Location = new System.Drawing.Point(7, 16);
            this.lblSlaveId.Name = "lblSlaveId";
            this.lblSlaveId.Size = new System.Drawing.Size(53, 12);
            this.lblSlaveId.TabIndex = 0;
            this.lblSlaveId.Text = "从站 ID:";
            //
            // pnlFunctionCode
            //
            this.pnlFunctionCode.Controls.Add(this.cboFunctionCode);
            this.pnlFunctionCode.Controls.Add(this.lblFunctionCode);
            this.pnlFunctionCode.Location = new System.Drawing.Point(3, 171);
            this.pnlFunctionCode.MinimumSize = new System.Drawing.Size(200, 50);
            this.pnlFunctionCode.Name = "pnlFunctionCode";
            this.pnlFunctionCode.Size = new System.Drawing.Size(200, 50);
            this.pnlFunctionCode.TabIndex = 3;
            //
            // cboFunctionCode
            //
            this.cboFunctionCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFunctionCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFunctionCode.Items.AddRange(new object[] {
            "读线圈 (01)",
            "读离散输入 (02)",
            "读保持寄存器 (03)",
            "读输入寄存器 (04)"});
            this.cboFunctionCode.Location = new System.Drawing.Point(97, 13);
            this.cboFunctionCode.Name = "cboFunctionCode";
            this.cboFunctionCode.Size = new System.Drawing.Size(100, 20);
            this.cboFunctionCode.TabIndex = 1;
            //
            // lblFunctionCode
            //
            this.lblFunctionCode.AutoSize = true;
            this.lblFunctionCode.Location = new System.Drawing.Point(7, 16);
            this.lblFunctionCode.Name = "lblFunctionCode";
            this.lblFunctionCode.Size = new System.Drawing.Size(47, 12);
            this.lblFunctionCode.TabIndex = 0;
            this.lblFunctionCode.Text = "功能码:";
            //
            // pnlStartAddress
            //
            this.pnlStartAddress.Controls.Add(this.txtStartAddress);
            this.pnlStartAddress.Controls.Add(this.lblStartAddress);
            this.pnlStartAddress.Location = new System.Drawing.Point(3, 227);
            this.pnlStartAddress.MinimumSize = new System.Drawing.Size(200, 50);
            this.pnlStartAddress.Name = "pnlStartAddress";
            this.pnlStartAddress.Size = new System.Drawing.Size(200, 50);
            this.pnlStartAddress.TabIndex = 4;
            //
            // txtStartAddress
            //
            this.txtStartAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartAddress.Location = new System.Drawing.Point(97, 13);
            this.txtStartAddress.Name = "txtStartAddress";
            this.txtStartAddress.Size = new System.Drawing.Size(100, 21);
            this.txtStartAddress.TabIndex = 1;
            //
            // lblStartAddress
            //
            this.lblStartAddress.AutoSize = true;
            this.lblStartAddress.Location = new System.Drawing.Point(7, 16);
            this.lblStartAddress.Name = "lblStartAddress";
            this.lblStartAddress.Size = new System.Drawing.Size(83, 12);
            this.lblStartAddress.TabIndex = 0;
            this.lblStartAddress.Text = "起始地址(0基):";
            //
            // pnlQuantity
            //
            this.pnlQuantity.Controls.Add(this.numQuantity);
            this.pnlQuantity.Controls.Add(this.lblQuantity);
            this.pnlQuantity.Location = new System.Drawing.Point(3, 283);
            this.pnlQuantity.MinimumSize = new System.Drawing.Size(200, 50);
            this.pnlQuantity.Name = "pnlQuantity";
            this.pnlQuantity.Size = new System.Drawing.Size(200, 50);
            this.pnlQuantity.TabIndex = 5;
            //
            // numQuantity
            //
            this.numQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numQuantity.Location = new System.Drawing.Point(97, 13);
            this.numQuantity.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(100, 21);
            this.numQuantity.TabIndex = 1;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            //
            // lblQuantity
            //
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(7, 16);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(35, 12);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "数量:";
            //
            // btnTestConnection
            //
            this.btnTestConnection.Location = new System.Drawing.Point(3, 339);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(60, 95);
            this.btnTestConnection.TabIndex = 6;
            this.btnTestConnection.Text = "测试连接";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            //
            // btnRead
            //
            this.btnRead.Location = new System.Drawing.Point(69, 339);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(60, 95);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "读取";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            //
            // btnClear
            //
            this.btnClear.Location = new System.Drawing.Point(135, 339);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 95);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清空结果";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.splitMain);
            this.Name = "Form1";
            this.Text = "ModbusReadTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            this.splitMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.flowParams.ResumeLayout(false);
            this.pnlIp.ResumeLayout(false);
            this.pnlIp.PerformLayout();
            this.pnlPort.ResumeLayout(false);
            this.pnlPort.PerformLayout();
            this.pnlSlaveId.ResumeLayout(false);
            this.pnlSlaveId.PerformLayout();
            this.pnlFunctionCode.ResumeLayout(false);
            this.pnlFunctionCode.PerformLayout();
            this.pnlStartAddress.ResumeLayout(false);
            this.pnlStartAddress.PerformLayout();
            this.pnlQuantity.ResumeLayout(false);
            this.pnlQuantity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.FlowLayoutPanel flowParams;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Panel pnlIp;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Panel pnlPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Panel pnlSlaveId;
        private System.Windows.Forms.TextBox txtSlaveId;
        private System.Windows.Forms.Label lblSlaveId;
        private System.Windows.Forms.Panel pnlFunctionCode;
        private System.Windows.Forms.ComboBox cboFunctionCode;
        private System.Windows.Forms.Label lblFunctionCode;
        private System.Windows.Forms.Panel pnlStartAddress;
        private System.Windows.Forms.TextBox txtStartAddress;
        private System.Windows.Forms.Label lblStartAddress;
        private System.Windows.Forms.Panel pnlQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnClear;
    }
}
