namespace LibraryApp.View.User
{
    partial class Rented
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
            this.labelOnCard = new System.Windows.Forms.Label();
            this.comboBoxOnCard = new System.Windows.Forms.ComboBox();
            this.listBoxFrom = new System.Windows.Forms.ListBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonProlong = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelOnCard
            // 
            this.labelOnCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOnCard.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelOnCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOnCard.Location = new System.Drawing.Point(53, 69);
            this.labelOnCard.Name = "labelOnCard";
            this.labelOnCard.Size = new System.Drawing.Size(229, 43);
            this.labelOnCard.TabIndex = 36;
            this.labelOnCard.Text = "On Card";
            this.labelOnCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxOnCard
            // 
            this.comboBoxOnCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxOnCard.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBoxOnCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOnCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxOnCard.FormattingEnabled = true;
            this.comboBoxOnCard.Location = new System.Drawing.Point(288, 81);
            this.comboBoxOnCard.Name = "comboBoxOnCard";
            this.comboBoxOnCard.Size = new System.Drawing.Size(500, 26);
            this.comboBoxOnCard.TabIndex = 35;
            this.comboBoxOnCard.SelectedIndexChanged += new System.EventHandler(this.comboBoxOnCard_SelectedIndexChanged);
            // 
            // listBoxFrom
            // 
            this.listBoxFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxFrom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBoxFrom.Enabled = false;
            this.listBoxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxFrom.FormattingEnabled = true;
            this.listBoxFrom.ItemHeight = 16;
            this.listBoxFrom.Location = new System.Drawing.Point(58, 134);
            this.listBoxFrom.Name = "listBoxFrom";
            this.listBoxFrom.Size = new System.Drawing.Size(284, 356);
            this.listBoxFrom.TabIndex = 37;
            this.listBoxFrom.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonQuit.Location = new System.Drawing.Point(1019, 612);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(117, 45);
            this.buttonQuit.TabIndex = 38;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonProlong
            // 
            this.buttonProlong.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonProlong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonProlong.Location = new System.Drawing.Point(960, 69);
            this.buttonProlong.Name = "buttonProlong";
            this.buttonProlong.Size = new System.Drawing.Size(155, 45);
            this.buttonProlong.TabIndex = 39;
            this.buttonProlong.Text = "Prolong";
            this.buttonProlong.UseVisualStyleBackColor = false;
            this.buttonProlong.Click += new System.EventHandler(this.buttonProlong_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReturn.Location = new System.Drawing.Point(799, 70);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(155, 45);
            this.buttonReturn.TabIndex = 40;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // listBox
            // 
            this.listBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(369, 134);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(746, 356);
            this.listBox.TabIndex = 41;
            this.listBox.DoubleClick += new System.EventHandler(this.listBox_DoubleClick);
            // 
            // Rented
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 669);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonProlong);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.listBoxFrom);
            this.Controls.Add(this.labelOnCard);
            this.Controls.Add(this.comboBoxOnCard);
            this.Name = "Rented";
            this.Text = "Rented";
            this.Load += new System.EventHandler(this.Rented_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelOnCard;
        private System.Windows.Forms.ComboBox comboBoxOnCard;
        private System.Windows.Forms.ListBox listBoxFrom;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonProlong;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.ListBox listBox;
    }
}