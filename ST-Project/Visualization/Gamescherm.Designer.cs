﻿namespace ST_Project
{
    partial class Gamescherm
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
            this.potions_lbl = new System.Windows.Forms.Label();
            this.scrolls_lbl = new System.Windows.Forms.Label();
            this.crystal_lbl = new System.Windows.Forms.Label();
            this.NRpotions = new System.Windows.Forms.Label();
            this.NRcrystals = new System.Windows.Forms.Label();
            this.NRscrolls = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // potions_lbl
            // 
            this.potions_lbl.AutoSize = true;
            this.potions_lbl.Font = new System.Drawing.Font("Lucida Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potions_lbl.Location = new System.Drawing.Point(172, 474);
            this.potions_lbl.Name = "potions_lbl";
            this.potions_lbl.Size = new System.Drawing.Size(152, 22);
            this.potions_lbl.TabIndex = 0;
            this.potions_lbl.Text = "Health Potions";
            // 
            // scrolls_lbl
            // 
            this.scrolls_lbl.AutoSize = true;
            this.scrolls_lbl.Font = new System.Drawing.Font("Lucida Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrolls_lbl.Location = new System.Drawing.Point(549, 474);
            this.scrolls_lbl.Name = "scrolls_lbl";
            this.scrolls_lbl.Size = new System.Drawing.Size(138, 22);
            this.scrolls_lbl.TabIndex = 1;
            this.scrolls_lbl.Text = "Magic Scrolls";
            // 
            // crystal_lbl
            // 
            this.crystal_lbl.AutoSize = true;
            this.crystal_lbl.Font = new System.Drawing.Font("Lucida Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crystal_lbl.Location = new System.Drawing.Point(363, 474);
            this.crystal_lbl.Name = "crystal_lbl";
            this.crystal_lbl.Size = new System.Drawing.Size(146, 22);
            this.crystal_lbl.TabIndex = 2;
            this.crystal_lbl.Text = "Time Crystals";
            // 
            // NRpotions
            // 
            this.NRpotions.Font = new System.Drawing.Font("Lucida Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NRpotions.Location = new System.Drawing.Point(172, 537);
            this.NRpotions.Name = "NRpotions";
            this.NRpotions.Size = new System.Drawing.Size(152, 22);
            this.NRpotions.TabIndex = 3;
            this.NRpotions.Text = "0";
            this.NRpotions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NRcrystals
            // 
            this.NRcrystals.Font = new System.Drawing.Font("Lucida Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NRcrystals.Location = new System.Drawing.Point(363, 537);
            this.NRcrystals.Name = "NRcrystals";
            this.NRcrystals.Size = new System.Drawing.Size(152, 22);
            this.NRcrystals.TabIndex = 4;
            this.NRcrystals.Text = "0";
            this.NRcrystals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NRscrolls
            // 
            this.NRscrolls.Font = new System.Drawing.Font("Lucida Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NRscrolls.Location = new System.Drawing.Point(549, 537);
            this.NRscrolls.Name = "NRscrolls";
            this.NRscrolls.Size = new System.Drawing.Size(152, 22);
            this.NRscrolls.TabIndex = 5;
            this.NRscrolls.Text = "0";
            this.NRscrolls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gamescherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.NRscrolls);
            this.Controls.Add(this.NRcrystals);
            this.Controls.Add(this.NRpotions);
            this.Controls.Add(this.crystal_lbl);
            this.Controls.Add(this.scrolls_lbl);
            this.Controls.Add(this.potions_lbl);
            this.Name = "Gamescherm";
            this.Text = "Gamescherm";
            this.Load += new System.EventHandler(this.Gamescherm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label potions_lbl;
        private System.Windows.Forms.Label scrolls_lbl;
        private System.Windows.Forms.Label crystal_lbl;
        private System.Windows.Forms.Label NRpotions;
        private System.Windows.Forms.Label NRcrystals;
        private System.Windows.Forms.Label NRscrolls;

    }
}