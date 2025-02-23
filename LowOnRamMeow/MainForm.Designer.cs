namespace LowOnRamMeow
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            trayBtn = new Button();
            stop = new Button();
            label1 = new Label();
            notifyIcon = new NotifyIcon(components);
            trayContextMenu = new ContextMenuStrip(components);
            stopFromTray = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            trayContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(trayBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(stop, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(269, 156);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // trayBtn
            // 
            trayBtn.Anchor = AnchorStyles.None;
            trayBtn.AutoSize = true;
            trayBtn.Location = new Point(94, 117);
            trayBtn.Name = "trayBtn";
            trayBtn.Size = new Size(81, 25);
            trayBtn.TabIndex = 1;
            trayBtn.Text = "Hide to Tray";
            trayBtn.UseVisualStyleBackColor = true;
            trayBtn.Click += trayBtn_Click;
            // 
            // stop
            // 
            stop.Anchor = AnchorStyles.None;
            stop.Location = new Point(97, 66);
            stop.Name = "stop";
            stop.Size = new Size(75, 23);
            stop.TabIndex = 0;
            stop.Text = "Stop";
            stop.UseVisualStyleBackColor = true;
            stop.Click += stop_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(246, 30);
            label1.TabIndex = 2;
            label1.Text = "Cats will now meow when your RAM usage is above 90%.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // notifyIcon
            // 
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "notifyIcon1";
            notifyIcon.Visible = true;
            notifyIcon.DoubleClick += notifyIcon_DoubleClick;
            notifyIcon.MouseClick += notifyIcon_MouseClick;
            // 
            // trayContextMenu
            // 
            trayContextMenu.Items.AddRange(new ToolStripItem[] { stopFromTray });
            trayContextMenu.Name = "trayContextMenu";
            trayContextMenu.Size = new Size(99, 26);
            // 
            // stopFromTray
            // 
            stopFromTray.Name = "stopFromTray";
            stopFromTray.Size = new Size(98, 22);
            stopFromTray.Text = "Stop";
            stopFromTray.Click += stopFromTray_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 156);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "LowOnRamMeow";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            trayContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button stop;
        private Button trayBtn;
        private Label label1;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip trayContextMenu;
        private ToolStripMenuItem stopFromTray;
    }
}