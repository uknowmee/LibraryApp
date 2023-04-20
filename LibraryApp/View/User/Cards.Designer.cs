namespace LibraryApp.View.User
{
    partial class Cards
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
            this.buttonQuit = new System.Windows.Forms.Button();
            this.comboBoxSelectedCard = new System.Windows.Forms.ComboBox();
            this.textBoxNewCardOwnerName = new System.Windows.Forms.TextBox();
            this.textBoxNewCardOwnerSurname = new System.Windows.Forms.TextBox();
            this.labelNewCardOwnerName = new System.Windows.Forms.Label();
            this.labelNewCardOwnerSurname = new System.Windows.Forms.Label();
            this.labelSelectedCard = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddNewCard = new System.Windows.Forms.Button();
            this.labelNewCard = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // buttonQuit
            // 
            this.buttonQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonQuit.Location = new System.Drawing.Point(1018, 604);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(118, 53);
            this.buttonQuit.TabIndex = 28;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // comboBoxSelectedCard
            // 
            this.comboBoxSelectedCard.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBoxSelectedCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectedCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSelectedCard.FormattingEnabled = true;
            this.comboBoxSelectedCard.Location = new System.Drawing.Point(460, 223);
            this.comboBoxSelectedCard.Name = "comboBoxSelectedCard";
            this.comboBoxSelectedCard.Size = new System.Drawing.Size(474, 26);
            this.comboBoxSelectedCard.TabIndex = 29;
            this.comboBoxSelectedCard.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectedCard_SelectedIndexChanged);
            // 
            // textBoxNewCardOwnerName
            // 
            this.textBoxNewCardOwnerName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxNewCardOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNewCardOwnerName.Location = new System.Drawing.Point(451, 285);
            this.textBoxNewCardOwnerName.Name = "textBoxNewCardOwnerName";
            this.textBoxNewCardOwnerName.Size = new System.Drawing.Size(483, 34);
            this.textBoxNewCardOwnerName.TabIndex = 30;
            // 
            // textBoxNewCardOwnerSurname
            // 
            this.textBoxNewCardOwnerSurname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxNewCardOwnerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNewCardOwnerSurname.Location = new System.Drawing.Point(451, 325);
            this.textBoxNewCardOwnerSurname.Name = "textBoxNewCardOwnerSurname";
            this.textBoxNewCardOwnerSurname.Size = new System.Drawing.Size(483, 34);
            this.textBoxNewCardOwnerSurname.TabIndex = 31;
            // 
            // labelNewCardOwnerName
            // 
            this.labelNewCardOwnerName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelNewCardOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNewCardOwnerName.Location = new System.Drawing.Point(216, 285);
            this.labelNewCardOwnerName.Name = "labelNewCardOwnerName";
            this.labelNewCardOwnerName.Size = new System.Drawing.Size(229, 34);
            this.labelNewCardOwnerName.TabIndex = 32;
            this.labelNewCardOwnerName.Text = "Owner Name";
            this.labelNewCardOwnerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNewCardOwnerSurname
            // 
            this.labelNewCardOwnerSurname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelNewCardOwnerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNewCardOwnerSurname.Location = new System.Drawing.Point(216, 325);
            this.labelNewCardOwnerSurname.Name = "labelNewCardOwnerSurname";
            this.labelNewCardOwnerSurname.Size = new System.Drawing.Size(229, 34);
            this.labelNewCardOwnerSurname.TabIndex = 33;
            this.labelNewCardOwnerSurname.Text = "Owner Surname";
            this.labelNewCardOwnerSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSelectedCard
            // 
            this.labelSelectedCard.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelSelectedCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSelectedCard.Location = new System.Drawing.Point(216, 211);
            this.labelSelectedCard.Name = "labelSelectedCard";
            this.labelSelectedCard.Size = new System.Drawing.Size(229, 43);
            this.labelSelectedCard.TabIndex = 34;
            this.labelSelectedCard.Text = "Selected Card";
            this.labelSelectedCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClear.Location = new System.Drawing.Point(451, 365);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(154, 53);
            this.buttonClear.TabIndex = 35;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(611, 365);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(152, 53);
            this.buttonDelete.TabIndex = 36;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddNewCard
            // 
            this.buttonAddNewCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddNewCard.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonAddNewCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddNewCard.Location = new System.Drawing.Point(769, 365);
            this.buttonAddNewCard.Name = "buttonAddNewCard";
            this.buttonAddNewCard.Size = new System.Drawing.Size(165, 53);
            this.buttonAddNewCard.TabIndex = 37;
            this.buttonAddNewCard.Text = "New Card";
            this.buttonAddNewCard.UseVisualStyleBackColor = false;
            this.buttonAddNewCard.Click += new System.EventHandler(this.buttonAddNewCard_Click);
            // 
            // labelNewCard
            // 
            this.labelNewCard.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelNewCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNewCard.Location = new System.Drawing.Point(216, 365);
            this.labelNewCard.Name = "labelNewCard";
            this.labelNewCard.Size = new System.Drawing.Size(229, 53);
            this.labelNewCard.TabIndex = 38;
            this.labelNewCard.Text = "New Card";
            this.labelNewCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 669);
            this.Controls.Add(this.labelNewCard);
            this.Controls.Add(this.buttonAddNewCard);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelSelectedCard);
            this.Controls.Add(this.labelNewCardOwnerSurname);
            this.Controls.Add(this.labelNewCardOwnerName);
            this.Controls.Add(this.textBoxNewCardOwnerSurname);
            this.Controls.Add(this.textBoxNewCardOwnerName);
            this.Controls.Add(this.comboBoxSelectedCard);
            this.Controls.Add(this.buttonQuit);
            this.Name = "Cards";
            this.Text = "Cards";
            this.Load += new System.EventHandler(this.Cards_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.ComboBox comboBoxSelectedCard;
        private System.Windows.Forms.TextBox textBoxNewCardOwnerName;
        private System.Windows.Forms.TextBox textBoxNewCardOwnerSurname;
        private System.Windows.Forms.Label labelNewCardOwnerName;
        private System.Windows.Forms.Label labelNewCardOwnerSurname;
        private System.Windows.Forms.Label labelSelectedCard;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddNewCard;
        private System.Windows.Forms.Label labelNewCard;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}