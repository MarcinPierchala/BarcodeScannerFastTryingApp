namespace ScannerFastTryingApp
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_01 = new System.Windows.Forms.TextBox();
            this.comboBox_COM_PORT_SELECTOR = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_BAUD_RATE = new System.Windows.Forms.Label();
            this.label_PARITY = new System.Windows.Forms.Label();
            this.label_DATA_BITS = new System.Windows.Forms.Label();
            this.label_STOP_BITS = new System.Windows.Forms.Label();
            this.textBox_BAUD_RATE = new System.Windows.Forms.TextBox();
            this.textBox_PARITY = new System.Windows.Forms.TextBox();
            this.textBox_DATA_BITS = new System.Windows.Forms.TextBox();
            this.textBox_STOP_BITS = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 129);
            this.button1.TabIndex = 0;
            this.button1.Text = "OPEN_COM_PORT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(529, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 129);
            this.button2.TabIndex = 1;
            this.button2.Text = "CLOSE_COM_PORT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // tb_01
            // 
            this.tb_01.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_01.Location = new System.Drawing.Point(57, 36);
            this.tb_01.Multiline = true;
            this.tb_01.Name = "tb_01";
            this.tb_01.Size = new System.Drawing.Size(649, 223);
            this.tb_01.TabIndex = 10;
            // 
            // comboBox_COM_PORT_SELECTOR
            // 
            this.comboBox_COM_PORT_SELECTOR.FormattingEnabled = true;
            this.comboBox_COM_PORT_SELECTOR.Location = new System.Drawing.Point(388, 267);
            this.comboBox_COM_PORT_SELECTOR.Name = "comboBox_COM_PORT_SELECTOR";
            this.comboBox_COM_PORT_SELECTOR.Size = new System.Drawing.Size(135, 21);
            this.comboBox_COM_PORT_SELECTOR.TabIndex = 11;
            this.comboBox_COM_PORT_SELECTOR.SelectedIndexChanged += new System.EventHandler(this.comboBox_COM_PORT_SELECTOR_index_changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "COM_PORT_SELECTOR";
            // 
            // label_BAUD_RATE
            // 
            this.label_BAUD_RATE.AutoSize = true;
            this.label_BAUD_RATE.Location = new System.Drawing.Point(310, 297);
            this.label_BAUD_RATE.Name = "label_BAUD_RATE";
            this.label_BAUD_RATE.Size = new System.Drawing.Size(72, 13);
            this.label_BAUD_RATE.TabIndex = 13;
            this.label_BAUD_RATE.Text = "BAUD_RATE";
            // 
            // label_PARITY
            // 
            this.label_PARITY.AutoSize = true;
            this.label_PARITY.Location = new System.Drawing.Point(336, 324);
            this.label_PARITY.Name = "label_PARITY";
            this.label_PARITY.Size = new System.Drawing.Size(46, 13);
            this.label_PARITY.TabIndex = 14;
            this.label_PARITY.Text = "PARITY";
            // 
            // label_DATA_BITS
            // 
            this.label_DATA_BITS.AutoSize = true;
            this.label_DATA_BITS.Location = new System.Drawing.Point(316, 350);
            this.label_DATA_BITS.Name = "label_DATA_BITS";
            this.label_DATA_BITS.Size = new System.Drawing.Size(66, 13);
            this.label_DATA_BITS.TabIndex = 15;
            this.label_DATA_BITS.Text = "DATA_BITS";
            // 
            // label_STOP_BITS
            // 
            this.label_STOP_BITS.AutoSize = true;
            this.label_STOP_BITS.Location = new System.Drawing.Point(316, 377);
            this.label_STOP_BITS.Name = "label_STOP_BITS";
            this.label_STOP_BITS.Size = new System.Drawing.Size(66, 13);
            this.label_STOP_BITS.TabIndex = 16;
            this.label_STOP_BITS.Text = "STOP_BITS";
            // 
            // textBox_BAUD_RATE
            // 
            this.textBox_BAUD_RATE.Location = new System.Drawing.Point(388, 294);
            this.textBox_BAUD_RATE.Name = "textBox_BAUD_RATE";
            this.textBox_BAUD_RATE.Size = new System.Drawing.Size(135, 20);
            this.textBox_BAUD_RATE.TabIndex = 17;
            this.textBox_BAUD_RATE.Text = "9600";
            // 
            // textBox_PARITY
            // 
            this.textBox_PARITY.Location = new System.Drawing.Point(388, 321);
            this.textBox_PARITY.Name = "textBox_PARITY";
            this.textBox_PARITY.Size = new System.Drawing.Size(135, 20);
            this.textBox_PARITY.TabIndex = 18;
            this.textBox_PARITY.Text = "None";
            // 
            // textBox_DATA_BITS
            // 
            this.textBox_DATA_BITS.Location = new System.Drawing.Point(388, 347);
            this.textBox_DATA_BITS.Name = "textBox_DATA_BITS";
            this.textBox_DATA_BITS.Size = new System.Drawing.Size(135, 20);
            this.textBox_DATA_BITS.TabIndex = 19;
            this.textBox_DATA_BITS.Text = "8";
            // 
            // textBox_STOP_BITS
            // 
            this.textBox_STOP_BITS.Location = new System.Drawing.Point(388, 374);
            this.textBox_STOP_BITS.Name = "textBox_STOP_BITS";
            this.textBox_STOP_BITS.Size = new System.Drawing.Size(135, 20);
            this.textBox_STOP_BITS.TabIndex = 20;
            this.textBox_STOP_BITS.Text = "One";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.manualToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.About_click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.Manual_click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.textBox_STOP_BITS);
            this.Controls.Add(this.textBox_DATA_BITS);
            this.Controls.Add(this.textBox_PARITY);
            this.Controls.Add(this.textBox_BAUD_RATE);
            this.Controls.Add(this.label_STOP_BITS);
            this.Controls.Add(this.label_DATA_BITS);
            this.Controls.Add(this.label_PARITY);
            this.Controls.Add(this.label_BAUD_RATE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_COM_PORT_SELECTOR);
            this.Controls.Add(this.tb_01);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScannerFastTryingApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource portSetBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_01;
        private System.Windows.Forms.ComboBox comboBox_COM_PORT_SELECTOR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_BAUD_RATE;
        private System.Windows.Forms.Label label_PARITY;
        private System.Windows.Forms.Label label_DATA_BITS;
        private System.Windows.Forms.Label label_STOP_BITS;
        private System.Windows.Forms.TextBox textBox_BAUD_RATE;
        private System.Windows.Forms.TextBox textBox_PARITY;
        private System.Windows.Forms.TextBox textBox_DATA_BITS;
        private System.Windows.Forms.TextBox textBox_STOP_BITS;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

