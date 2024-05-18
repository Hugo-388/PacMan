
namespace PacMan
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.L200Pts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.L800Pts = new System.Windows.Forms.Label();
            this.L400Pts = new System.Windows.Forms.Label();
            this.L1600Pts = new System.Windows.Forms.Label();
            this.LScore = new System.Windows.Forms.Label();
            this.TTimer = new System.Windows.Forms.Timer(this.components);
            this.LNomFantome1 = new System.Windows.Forms.Label();
            this.LNomFantome2 = new System.Windows.Forms.Label();
            this.LNomFantome3 = new System.Windows.Forms.Label();
            this.LNomFantome4 = new System.Windows.Forms.Label();
            this.T200Pts = new System.Windows.Forms.Timer(this.components);
            this.T400Pts = new System.Windows.Forms.Timer(this.components);
            this.T800Pts = new System.Windows.Forms.Timer(this.components);
            this.T1600Pts = new System.Windows.Forms.Timer(this.components);
            this.TAttaque = new System.Windows.Forms.Timer(this.components);
            this.PbQuitter = new System.Windows.Forms.PictureBox();
            this.PbJouer = new System.Windows.Forms.PictureBox();
            this.PbForce4 = new System.Windows.Forms.PictureBox();
            this.PbForce3 = new System.Windows.Forms.PictureBox();
            this.PbForce2 = new System.Windows.Forms.PictureBox();
            this.PbForce1 = new System.Windows.Forms.PictureBox();
            this.PbGrille = new System.Windows.Forms.PictureBox();
            this.LRecord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbJouer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbForce4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbForce3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbForce2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbForce1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbGrille)).BeginInit();
            this.SuspendLayout();
            // 
            // L200Pts
            // 
            this.L200Pts.AutoSize = true;
            this.L200Pts.BackColor = System.Drawing.Color.Transparent;
            this.L200Pts.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L200Pts.ForeColor = System.Drawing.Color.White;
            this.L200Pts.Location = new System.Drawing.Point(194, 279);
            this.L200Pts.Name = "L200Pts";
            this.L200Pts.Size = new System.Drawing.Size(49, 22);
            this.L200Pts.TabIndex = 5;
            this.L200Pts.Text = "200";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // L800Pts
            // 
            this.L800Pts.AutoSize = true;
            this.L800Pts.BackColor = System.Drawing.Color.Transparent;
            this.L800Pts.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L800Pts.ForeColor = System.Drawing.Color.White;
            this.L800Pts.Location = new System.Drawing.Point(194, 327);
            this.L800Pts.Name = "L800Pts";
            this.L800Pts.Size = new System.Drawing.Size(49, 22);
            this.L800Pts.TabIndex = 7;
            this.L800Pts.Text = "800";
            // 
            // L400Pts
            // 
            this.L400Pts.AutoSize = true;
            this.L400Pts.BackColor = System.Drawing.Color.Transparent;
            this.L400Pts.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L400Pts.ForeColor = System.Drawing.Color.White;
            this.L400Pts.Location = new System.Drawing.Point(249, 279);
            this.L400Pts.Name = "L400Pts";
            this.L400Pts.Size = new System.Drawing.Size(50, 22);
            this.L400Pts.TabIndex = 8;
            this.L400Pts.Text = "400";
            // 
            // L1600Pts
            // 
            this.L1600Pts.AutoSize = true;
            this.L1600Pts.BackColor = System.Drawing.Color.Transparent;
            this.L1600Pts.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1600Pts.ForeColor = System.Drawing.Color.White;
            this.L1600Pts.Location = new System.Drawing.Point(249, 327);
            this.L1600Pts.Name = "L1600Pts";
            this.L1600Pts.Size = new System.Drawing.Size(57, 22);
            this.L1600Pts.TabIndex = 9;
            this.L1600Pts.Text = "1600";
            // 
            // LScore
            // 
            this.LScore.AutoSize = true;
            this.LScore.BackColor = System.Drawing.Color.Transparent;
            this.LScore.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LScore.ForeColor = System.Drawing.Color.White;
            this.LScore.Location = new System.Drawing.Point(168, 509);
            this.LScore.Name = "LScore";
            this.LScore.Size = new System.Drawing.Size(94, 22);
            this.LScore.TabIndex = 12;
            this.LScore.Text = "Score : 0";
            // 
            // TTimer
            // 
            this.TTimer.Enabled = true;
            this.TTimer.Interval = 20;
            this.TTimer.Tick += new System.EventHandler(this.TTimer_Tick);
            // 
            // LNomFantome1
            // 
            this.LNomFantome1.AutoSize = true;
            this.LNomFantome1.BackColor = System.Drawing.Color.Transparent;
            this.LNomFantome1.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNomFantome1.ForeColor = System.Drawing.Color.White;
            this.LNomFantome1.Location = new System.Drawing.Point(178, 149);
            this.LNomFantome1.Name = "LNomFantome1";
            this.LNomFantome1.Size = new System.Drawing.Size(60, 22);
            this.LNomFantome1.TabIndex = 13;
            this.LNomFantome1.Text = "label1";
            // 
            // LNomFantome2
            // 
            this.LNomFantome2.AutoSize = true;
            this.LNomFantome2.BackColor = System.Drawing.Color.Transparent;
            this.LNomFantome2.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNomFantome2.ForeColor = System.Drawing.Color.White;
            this.LNomFantome2.Location = new System.Drawing.Point(250, 192);
            this.LNomFantome2.Name = "LNomFantome2";
            this.LNomFantome2.Size = new System.Drawing.Size(65, 22);
            this.LNomFantome2.TabIndex = 14;
            this.LNomFantome2.Text = "label2";
            // 
            // LNomFantome3
            // 
            this.LNomFantome3.AutoSize = true;
            this.LNomFantome3.BackColor = System.Drawing.Color.Transparent;
            this.LNomFantome3.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNomFantome3.ForeColor = System.Drawing.Color.White;
            this.LNomFantome3.Location = new System.Drawing.Point(178, 192);
            this.LNomFantome3.Name = "LNomFantome3";
            this.LNomFantome3.Size = new System.Drawing.Size(65, 22);
            this.LNomFantome3.TabIndex = 15;
            this.LNomFantome3.Text = "label3";
            // 
            // LNomFantome4
            // 
            this.LNomFantome4.AutoSize = true;
            this.LNomFantome4.BackColor = System.Drawing.Color.Transparent;
            this.LNomFantome4.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNomFantome4.ForeColor = System.Drawing.Color.White;
            this.LNomFantome4.Location = new System.Drawing.Point(250, 149);
            this.LNomFantome4.Name = "LNomFantome4";
            this.LNomFantome4.Size = new System.Drawing.Size(66, 22);
            this.LNomFantome4.TabIndex = 16;
            this.LNomFantome4.Text = "label4";
            // 
            // T200Pts
            // 
            this.T200Pts.Interval = 3500;
            this.T200Pts.Tick += new System.EventHandler(this.T200Pts_Tick);
            // 
            // T400Pts
            // 
            this.T400Pts.Interval = 3500;
            this.T400Pts.Tick += new System.EventHandler(this.T400Pts_Tick);
            // 
            // T800Pts
            // 
            this.T800Pts.Interval = 3500;
            this.T800Pts.Tick += new System.EventHandler(this.T800Pts_Tick);
            // 
            // T1600Pts
            // 
            this.T1600Pts.Interval = 3500;
            this.T1600Pts.Tick += new System.EventHandler(this.T1600Pts_Tick);
            // 
            // TAttaque
            // 
            this.TAttaque.Enabled = true;
            this.TAttaque.Interval = 5000;
            this.TAttaque.Tick += new System.EventHandler(this.TAttaque_Tick);
            // 
            // PbQuitter
            // 
            this.PbQuitter.BackColor = System.Drawing.Color.Transparent;
            this.PbQuitter.Image = global::PacMan.Properties.Resources.Quitter;
            this.PbQuitter.Location = new System.Drawing.Point(320, 521);
            this.PbQuitter.Name = "PbQuitter";
            this.PbQuitter.Size = new System.Drawing.Size(150, 35);
            this.PbQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbQuitter.TabIndex = 11;
            this.PbQuitter.TabStop = false;
            this.PbQuitter.Click += new System.EventHandler(this.PbQuitter_Click);
            this.PbQuitter.MouseLeave += new System.EventHandler(this.PbQuitter_MouseLeave);
            this.PbQuitter.MouseHover += new System.EventHandler(this.PbQuitter_MouseHover);
            // 
            // PbJouer
            // 
            this.PbJouer.BackColor = System.Drawing.Color.Transparent;
            this.PbJouer.Image = global::PacMan.Properties.Resources.Jouer;
            this.PbJouer.Location = new System.Drawing.Point(12, 521);
            this.PbJouer.Name = "PbJouer";
            this.PbJouer.Size = new System.Drawing.Size(105, 35);
            this.PbJouer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbJouer.TabIndex = 10;
            this.PbJouer.TabStop = false;
            this.PbJouer.Click += new System.EventHandler(this.PbJouer_Click);
            this.PbJouer.MouseLeave += new System.EventHandler(this.PbJouer_MouseLeave);
            this.PbJouer.MouseHover += new System.EventHandler(this.PbJouer_MouseHover);
            // 
            // PbForce4
            // 
            this.PbForce4.BackColor = System.Drawing.Color.Transparent;
            this.PbForce4.Image = global::PacMan.Properties.Resources.Force;
            this.PbForce4.Location = new System.Drawing.Point(397, 429);
            this.PbForce4.Name = "PbForce4";
            this.PbForce4.Size = new System.Drawing.Size(10, 10);
            this.PbForce4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbForce4.TabIndex = 4;
            this.PbForce4.TabStop = false;
            // 
            // PbForce3
            // 
            this.PbForce3.BackColor = System.Drawing.Color.Transparent;
            this.PbForce3.Image = global::PacMan.Properties.Resources.Force;
            this.PbForce3.Location = new System.Drawing.Point(397, 93);
            this.PbForce3.Name = "PbForce3";
            this.PbForce3.Size = new System.Drawing.Size(10, 10);
            this.PbForce3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbForce3.TabIndex = 3;
            this.PbForce3.TabStop = false;
            // 
            // PbForce2
            // 
            this.PbForce2.BackColor = System.Drawing.Color.Transparent;
            this.PbForce2.Image = global::PacMan.Properties.Resources.Force;
            this.PbForce2.Location = new System.Drawing.Point(75, 93);
            this.PbForce2.Name = "PbForce2";
            this.PbForce2.Size = new System.Drawing.Size(10, 10);
            this.PbForce2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbForce2.TabIndex = 2;
            this.PbForce2.TabStop = false;
            // 
            // PbForce1
            // 
            this.PbForce1.BackColor = System.Drawing.Color.Transparent;
            this.PbForce1.Image = global::PacMan.Properties.Resources.Force;
            this.PbForce1.Location = new System.Drawing.Point(75, 429);
            this.PbForce1.Name = "PbForce1";
            this.PbForce1.Size = new System.Drawing.Size(10, 10);
            this.PbForce1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbForce1.TabIndex = 1;
            this.PbForce1.TabStop = false;
            // 
            // PbGrille
            // 
            this.PbGrille.BackColor = System.Drawing.Color.Transparent;
            this.PbGrille.Image = global::PacMan.Properties.Resources.Grille;
            this.PbGrille.Location = new System.Drawing.Point(12, 12);
            this.PbGrille.Name = "PbGrille";
            this.PbGrille.Size = new System.Drawing.Size(458, 494);
            this.PbGrille.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbGrille.TabIndex = 0;
            this.PbGrille.TabStop = false;
            // 
            // LRecord
            // 
            this.LRecord.AutoSize = true;
            this.LRecord.BackColor = System.Drawing.Color.Transparent;
            this.LRecord.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRecord.ForeColor = System.Drawing.Color.White;
            this.LRecord.Location = new System.Drawing.Point(168, 534);
            this.LRecord.Name = "LRecord";
            this.LRecord.Size = new System.Drawing.Size(104, 22);
            this.LRecord.TabIndex = 17;
            this.LRecord.Text = "Record : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.LRecord);
            this.Controls.Add(this.LNomFantome4);
            this.Controls.Add(this.LNomFantome3);
            this.Controls.Add(this.LNomFantome2);
            this.Controls.Add(this.LNomFantome1);
            this.Controls.Add(this.PbQuitter);
            this.Controls.Add(this.LScore);
            this.Controls.Add(this.PbJouer);
            this.Controls.Add(this.L1600Pts);
            this.Controls.Add(this.L400Pts);
            this.Controls.Add(this.L800Pts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L200Pts);
            this.Controls.Add(this.PbForce4);
            this.Controls.Add(this.PbForce3);
            this.Controls.Add(this.PbForce2);
            this.Controls.Add(this.PbForce1);
            this.Controls.Add(this.PbGrille);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PacMan";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PbQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbJouer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbForce4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbForce3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbForce2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbForce1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbGrille)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbGrille;
        private System.Windows.Forms.Label L200Pts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L800Pts;
        private System.Windows.Forms.Label L400Pts;
        private System.Windows.Forms.Label L1600Pts;
        private System.Windows.Forms.PictureBox PbJouer;
        private System.Windows.Forms.PictureBox PbQuitter;
        private System.Windows.Forms.Label LScore;
        private System.Windows.Forms.Timer TTimer;
        private System.Windows.Forms.Label LNomFantome1;
        private System.Windows.Forms.Label LNomFantome2;
        private System.Windows.Forms.Label LNomFantome3;
        private System.Windows.Forms.Label LNomFantome4;
        private System.Windows.Forms.Timer T200Pts;
        private System.Windows.Forms.Timer T400Pts;
        private System.Windows.Forms.Timer T800Pts;
        private System.Windows.Forms.Timer T1600Pts;
        public System.Windows.Forms.PictureBox PbForce1;
        public System.Windows.Forms.PictureBox PbForce2;
        public System.Windows.Forms.PictureBox PbForce3;
        public System.Windows.Forms.PictureBox PbForce4;
        private System.Windows.Forms.Timer TAttaque;
        private System.Windows.Forms.Label LRecord;
    }
}

