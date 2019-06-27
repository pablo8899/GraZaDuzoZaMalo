namespace GraZaDuzoZaMalo
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TBTo = new System.Windows.Forms.TextBox();
            this.TBFrom = new System.Windows.Forms.TextBox();
            this.LRand = new System.Windows.Forms.Label();
            this.LOd = new System.Windows.Forms.Label();
            this.LTo = new System.Windows.Forms.Label();
            this.BTNRand = new System.Windows.Forms.Button();
            this.LGame = new System.Windows.Forms.Label();
            this.TBGame = new System.Windows.Forms.TextBox();
            this.BTNGame = new System.Windows.Forms.Button();
            this.LWinNumber = new System.Windows.Forms.Label();
            this.LDecide = new System.Windows.Forms.Label();
            this.GBGame = new System.Windows.Forms.GroupBox();
            this.LPointsRes = new System.Windows.Forms.Label();
            this.LPoints = new System.Windows.Forms.Label();
            this.LCountRes = new System.Windows.Forms.Label();
            this.LTimeRes = new System.Windows.Forms.Label();
            this.LCount = new System.Windows.Forms.Label();
            this.LTime = new System.Windows.Forms.Label();
            this.BTNStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BTNHistory = new System.Windows.Forms.Button();
            this.PBGame = new System.Windows.Forms.PictureBox();
            this.PBLoading = new System.Windows.Forms.PictureBox();
            this.PBWinner = new System.Windows.Forms.PictureBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GBGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBWinner)).BeginInit();
            this.SuspendLayout();
            // 
            // TBTo
            // 
            this.TBTo.Location = new System.Drawing.Point(72, 84);
            this.TBTo.Name = "TBTo";
            this.TBTo.Size = new System.Drawing.Size(65, 20);
            this.TBTo.TabIndex = 1;
            this.TBTo.Text = "100";
            this.TBTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBTo_KeyDown);
            this.TBTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBTo_KeyPress);
            // 
            // TBFrom
            // 
            this.TBFrom.Location = new System.Drawing.Point(72, 41);
            this.TBFrom.Name = "TBFrom";
            this.TBFrom.Size = new System.Drawing.Size(65, 20);
            this.TBFrom.TabIndex = 0;
            this.TBFrom.Text = "0";
            this.TBFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBFrom_KeyDown);
            this.TBFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFrom_KeyPress);
            // 
            // LRand
            // 
            this.LRand.AutoSize = true;
            this.LRand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LRand.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LRand.Location = new System.Drawing.Point(12, 9);
            this.LRand.Name = "LRand";
            this.LRand.Size = new System.Drawing.Size(228, 17);
            this.LRand.TabIndex = 2;
            this.LRand.Text = "Wybierz przedział losowania : ";
            // 
            // LOd
            // 
            this.LOd.AutoSize = true;
            this.LOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LOd.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LOd.Location = new System.Drawing.Point(12, 42);
            this.LOd.Name = "LOd";
            this.LOd.Size = new System.Drawing.Size(44, 17);
            this.LOd.TabIndex = 3;
            this.LOd.Text = "Od : ";
            // 
            // LTo
            // 
            this.LTo.AutoSize = true;
            this.LTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LTo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LTo.Location = new System.Drawing.Point(12, 85);
            this.LTo.Name = "LTo";
            this.LTo.Size = new System.Drawing.Size(43, 17);
            this.LTo.TabIndex = 4;
            this.LTo.Text = "Do : ";
            // 
            // BTNRand
            // 
            this.BTNRand.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTNRand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTNRand.ForeColor = System.Drawing.Color.Green;
            this.BTNRand.Location = new System.Drawing.Point(15, 125);
            this.BTNRand.Name = "BTNRand";
            this.BTNRand.Size = new System.Drawing.Size(122, 36);
            this.BTNRand.TabIndex = 5;
            this.BTNRand.Text = "Losuj";
            this.BTNRand.UseVisualStyleBackColor = false;
            this.BTNRand.Click += new System.EventHandler(this.BTNRand_Click);
            // 
            // LGame
            // 
            this.LGame.AutoSize = true;
            this.LGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LGame.ForeColor = System.Drawing.Color.Crimson;
            this.LGame.Location = new System.Drawing.Point(12, 264);
            this.LGame.Name = "LGame";
            this.LGame.Size = new System.Drawing.Size(173, 17);
            this.LGame.TabIndex = 8;
            this.LGame.Text = "Wylosowana liczba to :";
            // 
            // TBGame
            // 
            this.TBGame.Enabled = false;
            this.TBGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TBGame.Location = new System.Drawing.Point(15, 298);
            this.TBGame.Name = "TBGame";
            this.TBGame.Size = new System.Drawing.Size(110, 23);
            this.TBGame.TabIndex = 9;
            this.TBGame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBGame.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBGame_KeyDown);
            this.TBGame.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBGame_KeyPress);
            // 
            // BTNGame
            // 
            this.BTNGame.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTNGame.Enabled = false;
            this.BTNGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTNGame.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BTNGame.Location = new System.Drawing.Point(15, 336);
            this.BTNGame.Name = "BTNGame";
            this.BTNGame.Size = new System.Drawing.Size(110, 36);
            this.BTNGame.TabIndex = 10;
            this.BTNGame.Text = "Trafiam !";
            this.BTNGame.UseVisualStyleBackColor = false;
            this.BTNGame.Click += new System.EventHandler(this.BTNGame_Click);
            // 
            // LWinNumber
            // 
            this.LWinNumber.BackColor = System.Drawing.SystemColors.ControlText;
            this.LWinNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LWinNumber.ForeColor = System.Drawing.Color.GhostWhite;
            this.LWinNumber.Location = new System.Drawing.Point(61, 186);
            this.LWinNumber.Name = "LWinNumber";
            this.LWinNumber.Size = new System.Drawing.Size(200, 50);
            this.LWinNumber.TabIndex = 12;
            this.LWinNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LWinNumber.Visible = false;
            // 
            // LDecide
            // 
            this.LDecide.BackColor = System.Drawing.SystemColors.Control;
            this.LDecide.Cursor = System.Windows.Forms.Cursors.Default;
            this.LDecide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LDecide.ForeColor = System.Drawing.Color.DarkOrange;
            this.LDecide.Location = new System.Drawing.Point(134, 286);
            this.LDecide.Name = "LDecide";
            this.LDecide.Size = new System.Drawing.Size(114, 44);
            this.LDecide.TabIndex = 13;
            this.LDecide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GBGame
            // 
            this.GBGame.Controls.Add(this.LPointsRes);
            this.GBGame.Controls.Add(this.LPoints);
            this.GBGame.Controls.Add(this.LCountRes);
            this.GBGame.Controls.Add(this.LTimeRes);
            this.GBGame.Controls.Add(this.LCount);
            this.GBGame.Controls.Add(this.LTime);
            this.GBGame.Font = new System.Drawing.Font("Marlett", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GBGame.Location = new System.Drawing.Point(15, 394);
            this.GBGame.Name = "GBGame";
            this.GBGame.Size = new System.Drawing.Size(225, 121);
            this.GBGame.TabIndex = 14;
            this.GBGame.TabStop = false;
            this.GBGame.Text = "Twój wynik";
            // 
            // LPointsRes
            // 
            this.LPointsRes.AutoSize = true;
            this.LPointsRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LPointsRes.ForeColor = System.Drawing.Color.Firebrick;
            this.LPointsRes.Location = new System.Drawing.Point(120, 91);
            this.LPointsRes.Name = "LPointsRes";
            this.LPointsRes.Size = new System.Drawing.Size(17, 17);
            this.LPointsRes.TabIndex = 10;
            this.LPointsRes.Text = "0";
            // 
            // LPoints
            // 
            this.LPoints.AutoSize = true;
            this.LPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LPoints.ForeColor = System.Drawing.Color.ForestGreen;
            this.LPoints.Location = new System.Drawing.Point(6, 91);
            this.LPoints.Name = "LPoints";
            this.LPoints.Size = new System.Drawing.Size(72, 17);
            this.LPoints.TabIndex = 9;
            this.LPoints.Text = "Punkty : ";
            // 
            // LCountRes
            // 
            this.LCountRes.AutoSize = true;
            this.LCountRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LCountRes.ForeColor = System.Drawing.Color.Firebrick;
            this.LCountRes.Location = new System.Drawing.Point(120, 60);
            this.LCountRes.Name = "LCountRes";
            this.LCountRes.Size = new System.Drawing.Size(17, 17);
            this.LCountRes.TabIndex = 8;
            this.LCountRes.Text = "0";
            // 
            // LTimeRes
            // 
            this.LTimeRes.AutoSize = true;
            this.LTimeRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LTimeRes.ForeColor = System.Drawing.Color.Firebrick;
            this.LTimeRes.Location = new System.Drawing.Point(120, 28);
            this.LTimeRes.Name = "LTimeRes";
            this.LTimeRes.Size = new System.Drawing.Size(30, 17);
            this.LTimeRes.TabIndex = 7;
            this.LTimeRes.Text = "0 s";
            // 
            // LCount
            // 
            this.LCount.AutoSize = true;
            this.LCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LCount.ForeColor = System.Drawing.Color.ForestGreen;
            this.LCount.Location = new System.Drawing.Point(6, 60);
            this.LCount.Name = "LCount";
            this.LCount.Size = new System.Drawing.Size(108, 17);
            this.LCount.TabIndex = 6;
            this.LCount.Text = "Ilość trafień : ";
            // 
            // LTime
            // 
            this.LTime.AutoSize = true;
            this.LTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LTime.ForeColor = System.Drawing.Color.ForestGreen;
            this.LTime.Location = new System.Drawing.Point(6, 28);
            this.LTime.Name = "LTime";
            this.LTime.Size = new System.Drawing.Size(58, 17);
            this.LTime.TabIndex = 5;
            this.LTime.Text = "Czas : ";
            // 
            // BTNStop
            // 
            this.BTNStop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTNStop.Enabled = false;
            this.BTNStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTNStop.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BTNStop.Location = new System.Drawing.Point(130, 336);
            this.BTNStop.Name = "BTNStop";
            this.BTNStop.Size = new System.Drawing.Size(110, 36);
            this.BTNStop.TabIndex = 15;
            this.BTNStop.Text = "STOP";
            this.BTNStop.UseVisualStyleBackColor = false;
            this.BTNStop.Click += new System.EventHandler(this.BTNStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BTNHistory
            // 
            this.BTNHistory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTNHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTNHistory.ForeColor = System.Drawing.Color.Maroon;
            this.BTNHistory.Location = new System.Drawing.Point(15, 530);
            this.BTNHistory.Name = "BTNHistory";
            this.BTNHistory.Size = new System.Drawing.Size(176, 36);
            this.BTNHistory.TabIndex = 16;
            this.BTNHistory.Text = "Wyświetl Historię";
            this.BTNHistory.UseVisualStyleBackColor = false;
            this.BTNHistory.Click += new System.EventHandler(this.BTNHistory_Click);
            // 
            // PBGame
            // 
            this.PBGame.Image = global::GraZaDuzoZaMalo.Properties.Resources.random_numbers;
            this.PBGame.InitialImage = null;
            this.PBGame.Location = new System.Drawing.Point(52, 181);
            this.PBGame.Name = "PBGame";
            this.PBGame.Size = new System.Drawing.Size(220, 60);
            this.PBGame.TabIndex = 7;
            this.PBGame.TabStop = false;
            // 
            // PBLoading
            // 
            this.PBLoading.Image = global::GraZaDuzoZaMalo.Properties.Resources.wait;
            this.PBLoading.InitialImage = null;
            this.PBLoading.Location = new System.Drawing.Point(167, 41);
            this.PBLoading.Name = "PBLoading";
            this.PBLoading.Size = new System.Drawing.Size(140, 120);
            this.PBLoading.TabIndex = 6;
            this.PBLoading.TabStop = false;
            // 
            // PBWinner
            // 
            this.PBWinner.Image = global::GraZaDuzoZaMalo.Properties.Resources.win;
            this.PBWinner.Location = new System.Drawing.Point(261, 395);
            this.PBWinner.Name = "PBWinner";
            this.PBWinner.Size = new System.Drawing.Size(126, 120);
            this.PBWinner.TabIndex = 17;
            this.PBWinner.TabStop = false;
            this.PBWinner.Visible = false;
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(207, 540);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 20);
            this.TBName.TabIndex = 18;
            this.TBName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "(Kliknij ENTER )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Imię";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 578);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.PBWinner);
            this.Controls.Add(this.BTNHistory);
            this.Controls.Add(this.BTNStop);
            this.Controls.Add(this.GBGame);
            this.Controls.Add(this.LDecide);
            this.Controls.Add(this.LWinNumber);
            this.Controls.Add(this.BTNGame);
            this.Controls.Add(this.TBGame);
            this.Controls.Add(this.LGame);
            this.Controls.Add(this.PBGame);
            this.Controls.Add(this.PBLoading);
            this.Controls.Add(this.BTNRand);
            this.Controls.Add(this.LTo);
            this.Controls.Add(this.LOd);
            this.Controls.Add(this.LRand);
            this.Controls.Add(this.TBFrom);
            this.Controls.Add(this.TBTo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Za dużo za mało";
            this.GBGame.ResumeLayout(false);
            this.GBGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBWinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBTo;
        private System.Windows.Forms.TextBox TBFrom;
        private System.Windows.Forms.Label LRand;
        private System.Windows.Forms.Label LOd;
        private System.Windows.Forms.Label LTo;
        private System.Windows.Forms.Button BTNRand;
        private System.Windows.Forms.PictureBox PBLoading;
        private System.Windows.Forms.PictureBox PBGame;
        private System.Windows.Forms.Label LGame;
        private System.Windows.Forms.TextBox TBGame;
        private System.Windows.Forms.Button BTNGame;
        private System.Windows.Forms.Label LWinNumber;
        private System.Windows.Forms.Label LDecide;
        private System.Windows.Forms.GroupBox GBGame;
        private System.Windows.Forms.Label LCountRes;
        private System.Windows.Forms.Label LTimeRes;
        private System.Windows.Forms.Label LCount;
        private System.Windows.Forms.Label LTime;
        private System.Windows.Forms.Button BTNStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BTNHistory;
        private System.Windows.Forms.Label LPointsRes;
        private System.Windows.Forms.Label LPoints;
        private System.Windows.Forms.PictureBox PBWinner;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

