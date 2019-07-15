namespace ImGraph
{
    partial class NodeView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Header = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.Body = new System.Windows.Forms.Panel();
            this.pins2 = new ImGraph.Pins();
            this.pins1 = new ImGraph.Pins();
            this.HeaderPanel.SuspendLayout();
            this.Body.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(78, 16);
            this.Header.TabIndex = 0;
            this.Header.Text = "Заголовок";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HeaderPanel.Controls.Add(this.Header);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(152, 22);
            this.HeaderPanel.TabIndex = 1;
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Body.Controls.Add(this.pins2);
            this.Body.Controls.Add(this.pins1);
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(0, 22);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(152, 198);
            this.Body.TabIndex = 2;
            // 
            // pins2
            // 
            this.pins2.Location = new System.Drawing.Point(3, 31);
            this.pins2.Name = "pins2";
            this.pins2.Size = new System.Drawing.Size(22, 22);
            this.pins2.TabIndex = 1;
            // 
            // pins1
            // 
            this.pins1.Location = new System.Drawing.Point(3, 5);
            this.pins1.Name = "pins1";
            this.pins1.Size = new System.Drawing.Size(22, 20);
            this.pins1.TabIndex = 0;
            // 
            // NodeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Body);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "NodeView";
            this.Size = new System.Drawing.Size(152, 220);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.Body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel Body;
        private Pins pins1;
        private Pins pins2;
    }
}
