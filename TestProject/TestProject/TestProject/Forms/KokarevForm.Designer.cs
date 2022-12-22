
namespace TestProject.Forms
{
    partial class KokarevForm
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
            this.KokarevFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KokarevTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.KokarevFlowLayoutPanel.SuspendLayout();
            this.KokarevTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // KokarevFlowLayoutPanel
            // 
            this.KokarevFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.KokarevFlowLayoutPanel.Controls.Add(this.OKButton);
            this.KokarevFlowLayoutPanel.Controls.Add(this.CancelButton);
            this.KokarevFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.KokarevFlowLayoutPanel.Location = new System.Drawing.Point(-190, 264);
            this.KokarevFlowLayoutPanel.Name = "KokarevFlowLayoutPanel";
            this.KokarevFlowLayoutPanel.Size = new System.Drawing.Size(638, 32);
            this.KokarevFlowLayoutPanel.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(560, 3);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "ОК";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(479, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Location = new System.Drawing.Point(68, 55);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(147, 20);
            this.PatronymicTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(68, 29);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(147, 20);
            this.FirstNameTextBox.TabIndex = 3;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(68, 3);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(147, 20);
            this.SurnameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KokarevTableLayoutPanel
            // 
            this.KokarevTableLayoutPanel.ColumnCount = 2;
            this.KokarevTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.KokarevTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.KokarevTableLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.KokarevTableLayoutPanel.Controls.Add(this.SurnameTextBox, 1, 0);
            this.KokarevTableLayoutPanel.Controls.Add(this.FirstNameTextBox, 1, 1);
            this.KokarevTableLayoutPanel.Controls.Add(this.label3, 0, 2);
            this.KokarevTableLayoutPanel.Controls.Add(this.PatronymicTextBox, 1, 2);
            this.KokarevTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.KokarevTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.KokarevTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.KokarevTableLayoutPanel.Name = "KokarevTableLayoutPanel";
            this.KokarevTableLayoutPanel.RowCount = 4;
            this.KokarevTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.KokarevTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.KokarevTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.KokarevTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.KokarevTableLayoutPanel.Size = new System.Drawing.Size(448, 265);
            this.KokarevTableLayoutPanel.TabIndex = 1;
            // 
            // KokarevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 296);
            this.Controls.Add(this.KokarevTableLayoutPanel);
            this.Controls.Add(this.KokarevFlowLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(175, 335);
            this.Name = "KokarevForm";
            this.Text = "Кокарев";
            this.KokarevFlowLayoutPanel.ResumeLayout(false);
            this.KokarevTableLayoutPanel.ResumeLayout(false);
            this.KokarevTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel KokarevFlowLayoutPanel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel KokarevTableLayoutPanel;
    }
}