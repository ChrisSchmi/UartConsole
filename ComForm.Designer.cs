namespace UartConsole
{
    partial class ComForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tableLayoutPanel = new TableLayoutPanel();
            panelTop = new FlowLayoutPanel();
            cmbPort = new ComboBox();
            cmbBaud = new ComboBox();
            cmbDataBits = new ComboBox();
            cmbParity = new ComboBox();
            cmbStopBits = new ComboBox();
            btnConnect = new Button();
            txtLog = new TextBox();
            panelBottom = new Panel();
            txtInput = new TextBox();
            btnSend = new Button();
            tableLayoutPanel.SuspendLayout();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(panelTop, 0, 0);
            tableLayoutPanel.Controls.Add(txtLog, 0, 1);
            tableLayoutPanel.Controls.Add(panelBottom, 0, 2);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel.Size = new Size(800, 450);
            tableLayoutPanel.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(cmbPort);
            panelTop.Controls.Add(cmbBaud);
            panelTop.Controls.Add(cmbDataBits);
            panelTop.Controls.Add(cmbParity);
            panelTop.Controls.Add(cmbStopBits);
            panelTop.Controls.Add(btnConnect);
            panelTop.Dock = DockStyle.Fill;
            panelTop.Location = new Point(3, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(794, 81);
            panelTop.TabIndex = 0;
            // 
            // cmbPort
            // 
            cmbPort.Location = new Point(109, 3);
            cmbPort.Name = "cmbPort";
            cmbPort.Size = new Size(121, 23);
            cmbPort.TabIndex = 1;
            // 
            // cmbBaud
            // 
            cmbBaud.Location = new Point(342, 3);
            cmbBaud.Name = "cmbBaud";
            cmbBaud.Size = new Size(121, 23);
            cmbBaud.TabIndex = 3;
            // 
            // cmbDataBits
            // 
            cmbDataBits.Location = new Point(575, 3);
            cmbDataBits.Name = "cmbDataBits";
            cmbDataBits.Size = new Size(121, 23);
            cmbDataBits.TabIndex = 5;
            // 
            // cmbParity
            // 
            cmbParity.Location = new Point(3, 32);
            cmbParity.Name = "cmbParity";
            cmbParity.Size = new Size(121, 23);
            cmbParity.TabIndex = 6;
            // 
            // cmbStopBits
            // 
            cmbStopBits.Location = new Point(130, 32);
            cmbStopBits.Name = "cmbStopBits";
            cmbStopBits.Size = new Size(121, 23);
            cmbStopBits.TabIndex = 7;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.LightGreen;
            btnConnect.Location = new Point(257, 32);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(100, 23);
            btnConnect.TabIndex = 8;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtLog
            // 
            txtLog.Dock = DockStyle.Fill;
            txtLog.Font = new Font("Consolas", 9F);
            txtLog.Location = new Point(3, 90);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(794, 307);
            txtLog.TabIndex = 1;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(txtInput);
            panelBottom.Controls.Add(btnSend);
            panelBottom.Dock = DockStyle.Fill;
            panelBottom.Location = new Point(3, 403);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(5);
            panelBottom.Size = new Size(794, 44);
            panelBottom.TabIndex = 2;
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtInput.Location = new Point(8, 10);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(680, 23);
            txtInput.TabIndex = 0;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSend.Location = new Point(694, 9);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(92, 25);
            btnSend.TabIndex = 1;
            btnSend.Text = "Senden";
            btnSend.Click += btnSend_Click;
            // 
            // ComForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel);
            Name = "ComForm";
            Text = "Serial Port Terminal";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            panelTop.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel panelTop;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSend;
    }
}