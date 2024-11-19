using System.ComponentModel;

namespace TradingCards
{
    partial class PlayerCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lbCardType = new System.Windows.Forms.Label();
            this.pbCardImage = new System.Windows.Forms.PictureBox();
            this.lbPlayerName = new System.Windows.Forms.Label();
            this.lbTeamName = new System.Windows.Forms.Label();
            this.lbNotableStat = new System.Windows.Forms.Label();
            this.lbCardPrice = new System.Windows.Forms.Label();
            this.pbCardValue = new TradingCards.CardValueBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCardType
            // 
            this.lbCardType.AutoSize = true;
            this.lbCardType.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCardType.Location = new System.Drawing.Point(12, 9);
            this.lbCardType.Name = "lbCardType";
            this.lbCardType.Size = new System.Drawing.Size(140, 38);
            this.lbCardType.TabIndex = 0;
            this.lbCardType.Text = "Card Type";
            this.lbCardType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbCardImage
            // 
            this.pbCardImage.Location = new System.Drawing.Point(93, 69);
            this.pbCardImage.Name = "pbCardImage";
            this.pbCardImage.Size = new System.Drawing.Size(130, 130);
            this.pbCardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCardImage.TabIndex = 1;
            this.pbCardImage.TabStop = false;
            // 
            // lbPlayerName
            // 
            this.lbPlayerName.AutoSize = true;
            this.lbPlayerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerName.Location = new System.Drawing.Point(93, 221);
            this.lbPlayerName.Name = "lbPlayerName";
            this.lbPlayerName.Size = new System.Drawing.Size(122, 28);
            this.lbPlayerName.TabIndex = 2;
            this.lbPlayerName.Text = "Player Name";
            this.lbPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTeamName
            // 
            this.lbTeamName.AutoSize = true;
            this.lbTeamName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeamName.Location = new System.Drawing.Point(93, 249);
            this.lbTeamName.Name = "lbTeamName";
            this.lbTeamName.Size = new System.Drawing.Size(114, 28);
            this.lbTeamName.TabIndex = 3;
            this.lbTeamName.Text = "Team Name";
            this.lbTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNotableStat
            // 
            this.lbNotableStat.AutoSize = true;
            this.lbNotableStat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotableStat.Location = new System.Drawing.Point(93, 296);
            this.lbNotableStat.Name = "lbNotableStat";
            this.lbNotableStat.Size = new System.Drawing.Size(122, 28);
            this.lbNotableStat.TabIndex = 4;
            this.lbNotableStat.Text = "Notable Stat";
            this.lbNotableStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCardPrice
            // 
            this.lbCardPrice.AutoSize = true;
            this.lbCardPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCardPrice.Location = new System.Drawing.Point(93, 324);
            this.lbCardPrice.Name = "lbCardPrice";
            this.lbCardPrice.Size = new System.Drawing.Size(100, 28);
            this.lbCardPrice.TabIndex = 5;
            this.lbCardPrice.Text = "Card Price";
            this.lbCardPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbCardValue
            // 
            this.pbCardValue.Location = new System.Drawing.Point(62, 387);
            this.pbCardValue.Name = "pbCardValue";
            this.pbCardValue.ProgressBarColor = System.Drawing.Color.LawnGreen;
            this.pbCardValue.Size = new System.Drawing.Size(188, 30);
            this.pbCardValue.TabIndex = 6;
            // 
            // PlayerCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(315, 450);
            this.Controls.Add(this.pbCardValue);
            this.Controls.Add(this.lbCardPrice);
            this.Controls.Add(this.lbNotableStat);
            this.Controls.Add(this.lbTeamName);
            this.Controls.Add(this.lbPlayerName);
            this.Controls.Add(this.pbCardImage);
            this.Controls.Add(this.lbCardType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "PlayerCard";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Player Card";
            ((System.ComponentModel.ISupportInitialize)(this.pbCardImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private CardValueBar pbCardValue;

        private System.Windows.Forms.Label lbCardPrice;

        private System.Windows.Forms.Label lbNotableStat;

        private System.Windows.Forms.Label lbTeamName;

        private System.Windows.Forms.Label lbPlayerName;

        private System.Windows.Forms.PictureBox pbCardImage;

        private System.Windows.Forms.Label lbCardType;

        #endregion
    }
}