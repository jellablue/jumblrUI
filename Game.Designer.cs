namespace jumblrUI2
{
    partial class Game
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
            this.rndPanel2 = new rndPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.rndPanel1 = new rndPanel();
            this.ButtonE = new jumblrUI2.rndButton();
            this.buttonH = new System.Windows.Forms.Button();
            this.rndPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rndPanel2
            // 
            this.rndPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(209)))));
            this.rndPanel2.Controls.Add(this.label1);
            this.rndPanel2.Location = new System.Drawing.Point(17, 15);
            this.rndPanel2.Name = "rndPanel2";
            this.rndPanel2.Size = new System.Drawing.Size(103, 46);
            this.rndPanel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(209)))));
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(89)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "EASY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rndPanel1
            // 
            this.rndPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.rndPanel1.Location = new System.Drawing.Point(334, 130);
            this.rndPanel1.Name = "rndPanel1";
            this.rndPanel1.Size = new System.Drawing.Size(600, 343);
            this.rndPanel1.TabIndex = 3;
            // 
            // ButtonE
            // 
            this.ButtonE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(228)))), ((int)(((byte)(156)))));
            this.ButtonE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(228)))), ((int)(((byte)(156)))));
            this.ButtonE.BorderColor = System.Drawing.Color.LightBlue;
            this.ButtonE.BorderRadius = 40;
            this.ButtonE.BorderSize = 0;
            this.ButtonE.FlatAppearance.BorderSize = 0;
            this.ButtonE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(235)))), ((int)(((byte)(209)))));
            this.ButtonE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(228)))), ((int)(((byte)(156)))));
            this.ButtonE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonE.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(89)))), ((int)(((byte)(169)))));
            this.ButtonE.Location = new System.Drawing.Point(500, 550);
            this.ButtonE.Name = "ButtonE";
            this.ButtonE.Size = new System.Drawing.Size(272, 62);
            this.ButtonE.TabIndex = 1;
            this.ButtonE.Text = "ENTER";
            this.ButtonE.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(89)))), ((int)(((byte)(169)))));
            this.ButtonE.UseVisualStyleBackColor = false;
            this.ButtonE.Click += new System.EventHandler(this.ButtonE_Click);
            // 
            // buttonH
            // 
            this.buttonH.BackgroundImage = global::jumblrUI2.Properties.Resources.f3e7e5a0_2021_47b3_a086_0ccf7551bcf1;
            this.buttonH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonH.FlatAppearance.BorderSize = 0;
            this.buttonH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonH.Location = new System.Drawing.Point(1200, 20);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(43, 40);
            this.buttonH.TabIndex = 0;
            this.buttonH.UseVisualStyleBackColor = true;
            this.buttonH.Click += new System.EventHandler(this.buttonH_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(183)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1275, 700);
            this.Controls.Add(this.rndPanel2);
            this.Controls.Add(this.rndPanel1);
            this.Controls.Add(this.ButtonE);
            this.Controls.Add(this.buttonH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.rndPanel2.ResumeLayout(false);
            this.rndPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonH;
        private rndButton ButtonE;
        private System.Windows.Forms.Label label1;
        private rndPanel rndPanel1;
        private rndPanel rndPanel2;
    }
}