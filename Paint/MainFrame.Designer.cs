namespace Paint
{
    partial class MainFrame
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
            this.InstrumentPanel = new System.Windows.Forms.Panel();
            this.ColorChooser = new System.Windows.Forms.Button();
            this.InstrumentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InstrumentPanel
            // 
            this.InstrumentPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.InstrumentPanel.Controls.Add(this.ColorChooser);
            this.InstrumentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InstrumentPanel.Location = new System.Drawing.Point(0, 0);
            this.InstrumentPanel.Name = "InstrumentPanel";
            this.InstrumentPanel.Size = new System.Drawing.Size(1134, 33);
            this.InstrumentPanel.TabIndex = 0;
            this.InstrumentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // ColorChooser
            // 
            this.ColorChooser.Location = new System.Drawing.Point(12, 3);
            this.ColorChooser.Name = "ColorChooser";
            this.ColorChooser.Size = new System.Drawing.Size(75, 27);
            this.ColorChooser.TabIndex = 0;
            this.ColorChooser.Text = "Color";
            this.ColorChooser.UseVisualStyleBackColor = true;
            this.ColorChooser.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 612);
            this.Controls.Add(this.InstrumentPanel);
            this.Name = "MainFrame";
            this.Text = "Paint";
            this.InstrumentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InstrumentPanel;
        private System.Windows.Forms.Button ColorChooser;
    }
}

