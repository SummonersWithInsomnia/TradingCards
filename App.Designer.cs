using System.Drawing;
using System.Windows.Forms;

namespace TradingCards
{
    partial class App
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
            this.pTitle = new System.Windows.Forms.Panel();
            this.btnMyCardCollection = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pCopyright = new System.Windows.Forms.Panel();
            this.lbCopyright = new System.Windows.Forms.Label();
            this.pCardList = new System.Windows.Forms.Panel();
            this.btnShowCard9 = new System.Windows.Forms.Button();
            this.btnShowCard8 = new System.Windows.Forms.Button();
            this.btnShowCard7 = new System.Windows.Forms.Button();
            this.btnShowCard6 = new System.Windows.Forms.Button();
            this.btnShowCard5 = new System.Windows.Forms.Button();
            this.btnShowCard4 = new System.Windows.Forms.Button();
            this.btnShowCard3 = new System.Windows.Forms.Button();
            this.btnShowCard2 = new System.Windows.Forms.Button();
            this.btnShowCard1 = new System.Windows.Forms.Button();
            this.btnShowCard0 = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.lbCardOwnership = new System.Windows.Forms.Label();
            this.lbInstruction = new System.Windows.Forms.Label();
            this.pCard = new System.Windows.Forms.Panel();
            this.pTitle.SuspendLayout();
            this.pCardList.SuspendLayout();
            this.pCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pTitle.Controls.Add(this.btnMyCardCollection);
            this.pTitle.Location = new System.Drawing.Point(0, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(966, 60);
            this.pTitle.TabIndex = 0;
            // 
            // btnMyCardCollection
            // 
            this.btnMyCardCollection.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMyCardCollection.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMyCardCollection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMyCardCollection.Location = new System.Drawing.Point(805, 9);
            this.btnMyCardCollection.Name = "btnMyCardCollection";
            this.btnMyCardCollection.Size = new System.Drawing.Size(149, 42);
            this.btnMyCardCollection.TabIndex = 0;
            this.btnMyCardCollection.Text = "My Card Collection";
            this.btnMyCardCollection.UseVisualStyleBackColor = false;
            this.btnMyCardCollection.Click += new System.EventHandler(this.btnMyCardCollection_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(360, 10);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(249, 41);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Trading Cards";
            // 
            // pCopyright
            // 
            this.pCopyright.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pCopyright.Location = new System.Drawing.Point(0, 581);
            this.pCopyright.Name = "pCopyright";
            this.pCopyright.Size = new System.Drawing.Size(966, 35);
            this.pCopyright.TabIndex = 2;
            // 
            // lbCopyright
            // 
            this.lbCopyright.AutoSize = true;
            this.lbCopyright.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbCopyright.ForeColor = System.Drawing.Color.White;
            this.lbCopyright.Location = new System.Drawing.Point(400, 590);
            this.lbCopyright.Name = "lbCopyright";
            this.lbCopyright.Size = new System.Drawing.Size(163, 15);
            this.lbCopyright.TabIndex = 3;
            this.lbCopyright.Text = "© Summoners with Insomnia";
            // 
            // pCardList
            // 
            this.pCardList.BackColor = System.Drawing.Color.Gainsboro;
            this.pCardList.Controls.Add(this.btnShowCard9);
            this.pCardList.Controls.Add(this.btnShowCard8);
            this.pCardList.Controls.Add(this.btnShowCard7);
            this.pCardList.Controls.Add(this.btnShowCard6);
            this.pCardList.Controls.Add(this.btnShowCard5);
            this.pCardList.Controls.Add(this.btnShowCard4);
            this.pCardList.Controls.Add(this.btnShowCard3);
            this.pCardList.Controls.Add(this.btnShowCard2);
            this.pCardList.Controls.Add(this.btnShowCard1);
            this.pCardList.Controls.Add(this.btnShowCard0);
            this.pCardList.Location = new System.Drawing.Point(0, 61);
            this.pCardList.Name = "pCardList";
            this.pCardList.Size = new System.Drawing.Size(263, 519);
            this.pCardList.TabIndex = 4;
            // 
            // btnShowCard9
            // 
            this.btnShowCard9.BackColor = System.Drawing.Color.Moccasin;
            this.btnShowCard9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowCard9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowCard9.Location = new System.Drawing.Point(10, 457);
            this.btnShowCard9.Name = "btnShowCard9";
            this.btnShowCard9.Size = new System.Drawing.Size(242, 42);
            this.btnShowCard9.TabIndex = 9;
            this.btnShowCard9.Text = "Zion Williamson";
            this.btnShowCard9.UseVisualStyleBackColor = false;
            // 
            // btnShowCard8
            // 
            this.btnShowCard8.BackColor = System.Drawing.Color.Moccasin;
            this.btnShowCard8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowCard8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowCard8.Location = new System.Drawing.Point(10, 409);
            this.btnShowCard8.Name = "btnShowCard8";
            this.btnShowCard8.Size = new System.Drawing.Size(242, 42);
            this.btnShowCard8.TabIndex = 8;
            this.btnShowCard8.Text = "Kevin Durant";
            this.btnShowCard8.UseVisualStyleBackColor = false;
            // 
            // btnShowCard7
            // 
            this.btnShowCard7.BackColor = System.Drawing.Color.Moccasin;
            this.btnShowCard7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowCard7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowCard7.Location = new System.Drawing.Point(10, 361);
            this.btnShowCard7.Name = "btnShowCard7";
            this.btnShowCard7.Size = new System.Drawing.Size(242, 42);
            this.btnShowCard7.TabIndex = 7;
            this.btnShowCard7.Text = "Nikola Jokić";
            this.btnShowCard7.UseVisualStyleBackColor = false;
            // 
            // btnShowCard6
            // 
            this.btnShowCard6.BackColor = System.Drawing.Color.Moccasin;
            this.btnShowCard6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowCard6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowCard6.Location = new System.Drawing.Point(10, 313);
            this.btnShowCard6.Name = "btnShowCard6";
            this.btnShowCard6.Size = new System.Drawing.Size(242, 42);
            this.btnShowCard6.TabIndex = 6;
            this.btnShowCard6.Text = "Kawhi Leonard";
            this.btnShowCard6.UseVisualStyleBackColor = false;
            // 
            // btnShowCard5
            // 
            this.btnShowCard5.BackColor = System.Drawing.Color.Moccasin;
            this.btnShowCard5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowCard5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowCard5.Location = new System.Drawing.Point(10, 265);
            this.btnShowCard5.Name = "btnShowCard5";
            this.btnShowCard5.Size = new System.Drawing.Size(242, 42);
            this.btnShowCard5.TabIndex = 5;
            this.btnShowCard5.Text = "Giannis Antetokounmpo";
            this.btnShowCard5.UseVisualStyleBackColor = false;
            // 
            // btnShowCard4
            // 
            this.btnShowCard4.BackColor = System.Drawing.Color.Moccasin;
            this.btnShowCard4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowCard4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowCard4.Location = new System.Drawing.Point(10, 217);
            this.btnShowCard4.Name = "btnShowCard4";
            this.btnShowCard4.Size = new System.Drawing.Size(242, 42);
            this.btnShowCard4.TabIndex = 4;
            this.btnShowCard4.Text = "Michael Jordan";
            this.btnShowCard4.UseVisualStyleBackColor = false;
            // 
            // btnShowCard3
            // 
            this.btnShowCard3.BackColor = System.Drawing.Color.Moccasin;
            this.btnShowCard3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowCard3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowCard3.Location = new System.Drawing.Point(10, 169);
            this.btnShowCard3.Name = "btnShowCard3";
            this.btnShowCard3.Size = new System.Drawing.Size(242, 42);
            this.btnShowCard3.TabIndex = 3;
            this.btnShowCard3.Text = "Stephen Curry";
            this.btnShowCard3.UseVisualStyleBackColor = false;
            // 
            // btnShowCard2
            // 
            this.btnShowCard2.BackColor = System.Drawing.Color.Moccasin;
            this.btnShowCard2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowCard2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowCard2.Location = new System.Drawing.Point(10, 121);
            this.btnShowCard2.Name = "btnShowCard2";
            this.btnShowCard2.Size = new System.Drawing.Size(242, 42);
            this.btnShowCard2.TabIndex = 2;
            this.btnShowCard2.Text = "Luka Dončić";
            this.btnShowCard2.UseVisualStyleBackColor = false;
            // 
            // btnShowCard1
            // 
            this.btnShowCard1.BackColor = System.Drawing.Color.Moccasin;
            this.btnShowCard1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowCard1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowCard1.Location = new System.Drawing.Point(10, 73);
            this.btnShowCard1.Name = "btnShowCard1";
            this.btnShowCard1.Size = new System.Drawing.Size(242, 42);
            this.btnShowCard1.TabIndex = 1;
            this.btnShowCard1.Text = "LeBron James";
            this.btnShowCard1.UseVisualStyleBackColor = false;
            // 
            // btnShowCard0
            // 
            this.btnShowCard0.BackColor = System.Drawing.Color.Moccasin;
            this.btnShowCard0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowCard0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowCard0.Location = new System.Drawing.Point(10, 25);
            this.btnShowCard0.Name = "btnShowCard0";
            this.btnShowCard0.Size = new System.Drawing.Size(242, 42);
            this.btnShowCard0.TabIndex = 0;
            this.btnShowCard0.Text = "Kobe Bryant";
            this.btnShowCard0.UseVisualStyleBackColor = false;
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.Color.Moccasin;
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAction.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAction.Location = new System.Drawing.Point(526, 42);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(164, 42);
            this.btnAction.TabIndex = 0;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = false;
            // 
            // lbCardOwnership
            // 
            this.lbCardOwnership.AutoSize = true;
            this.lbCardOwnership.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbCardOwnership.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCardOwnership.Location = new System.Drawing.Point(527, 87);
            this.lbCardOwnership.Name = "lbCardOwnership";
            this.lbCardOwnership.Size = new System.Drawing.Size(163, 28);
            this.lbCardOwnership.TabIndex = 1;
            this.lbCardOwnership.Text = "lbCardOwnership";
            this.lbCardOwnership.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbInstruction
            // 
            this.lbInstruction.AutoSize = true;
            this.lbInstruction.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbInstruction.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstruction.Location = new System.Drawing.Point(165, 227);
            this.lbInstruction.Name = "lbInstruction";
            this.lbInstruction.Size = new System.Drawing.Size(370, 25);
            this.lbInstruction.TabIndex = 0;
            this.lbInstruction.Text = "<- Please choose a card from the left bar";
            this.lbInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pCard
            // 
            this.pCard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pCard.Controls.Add(this.lbInstruction);
            this.pCard.Location = new System.Drawing.Point(264, 61);
            this.pCard.Name = "pCard";
            this.pCard.Size = new System.Drawing.Size(702, 519);
            this.pCard.TabIndex = 5;
            // 
            // App
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(966, 616);
            this.Controls.Add(this.pCard);
            this.Controls.Add(this.pCardList);
            this.Controls.Add(this.lbCopyright);
            this.Controls.Add(this.pCopyright);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "App";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trading Cards";
            this.pTitle.ResumeLayout(false);
            this.pCardList.ResumeLayout(false);
            this.pCard.ResumeLayout(false);
            this.pCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel pCard;

        private System.Windows.Forms.Button btnShowCard9;

        private System.Windows.Forms.Button btnShowCard8;

        private System.Windows.Forms.Button btnShowCard7;

        private System.Windows.Forms.Button btnShowCard6;

        private System.Windows.Forms.Button btnShowCard4;

        private System.Windows.Forms.Button btnShowCard5;

        private System.Windows.Forms.Button btnShowCard3;

        private System.Windows.Forms.Button btnShowCard2;

        private System.Windows.Forms.Button btnShowCard1;

        private System.Windows.Forms.Button btnShowCard0;

        private System.Windows.Forms.Button btnMyCardCollection;

        private System.Windows.Forms.Button btnAction;

        private System.Windows.Forms.Label lbCardOwnership;

        private System.Windows.Forms.Label lbInstruction;

        private System.Windows.Forms.Panel pCardList;

        private System.Windows.Forms.Label lbCopyright;

        private System.Windows.Forms.Panel pCopyright;

        private System.Windows.Forms.Label lbTitle;

        private System.Windows.Forms.Panel pTitle;

        #endregion
    }
}