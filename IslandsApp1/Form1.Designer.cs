namespace IslandsApp1
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.pic = new System.Windows.Forms.PictureBox();
			this.lstMap = new System.Windows.Forms.ListBox();
			this.lstIsland = new System.Windows.Forms.ListBox();
			this.picFlames = new System.Windows.Forms.PictureBox();
			this.tmrFlames = new System.Windows.Forms.Timer(this.components);
			this.tmrMain = new System.Windows.Forms.Timer(this.components);
			this.btnClearFire = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFlames)).BeginInit();
			this.SuspendLayout();
			// 
			// pic
			// 
			this.pic.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pic.Location = new System.Drawing.Point(93, 12);
			this.pic.Name = "pic";
			this.pic.Size = new System.Drawing.Size(550, 480);
			this.pic.TabIndex = 0;
			this.pic.TabStop = false;
			this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
			this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
			// 
			// lstMap
			// 
			this.lstMap.FormattingEnabled = true;
			this.lstMap.Location = new System.Drawing.Point(12, 12);
			this.lstMap.Name = "lstMap";
			this.lstMap.Size = new System.Drawing.Size(75, 69);
			this.lstMap.TabIndex = 1;
			this.lstMap.SelectedIndexChanged += new System.EventHandler(this.lstMap_SelectedIndexChanged);
			// 
			// lstIsland
			// 
			this.lstIsland.FormattingEnabled = true;
			this.lstIsland.Location = new System.Drawing.Point(12, 87);
			this.lstIsland.Name = "lstIsland";
			this.lstIsland.Size = new System.Drawing.Size(75, 69);
			this.lstIsland.TabIndex = 2;
			this.lstIsland.SelectedIndexChanged += new System.EventHandler(this.lstIsland_SelectedIndexChanged);
			// 
			// picFlames
			// 
			this.picFlames.Location = new System.Drawing.Point(12, 440);
			this.picFlames.Name = "picFlames";
			this.picFlames.Size = new System.Drawing.Size(34, 50);
			this.picFlames.TabIndex = 3;
			this.picFlames.TabStop = false;
			// 
			// tmrFlames
			// 
			this.tmrFlames.Tick += new System.EventHandler(this.tmrFlames_Tick);
			// 
			// tmrMain
			// 
			this.tmrMain.Interval = 500;
			this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
			// 
			// btnClearFire
			// 
			this.btnClearFire.Location = new System.Drawing.Point(12, 162);
			this.btnClearFire.Name = "btnClearFire";
			this.btnClearFire.Size = new System.Drawing.Size(75, 23);
			this.btnClearFire.TabIndex = 4;
			this.btnClearFire.Text = "button1";
			this.btnClearFire.UseVisualStyleBackColor = true;
			this.btnClearFire.Click += new System.EventHandler(this.btnClearFire_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(664, 507);
			this.Controls.Add(this.btnClearFire);
			this.Controls.Add(this.picFlames);
			this.Controls.Add(this.lstIsland);
			this.Controls.Add(this.lstMap);
			this.Controls.Add(this.pic);
			this.Name = "Form1";
			this.Text = "Islands Missile Invasion";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFlames)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.ListBox lstMap;
        private System.Windows.Forms.ListBox lstIsland;
        private System.Windows.Forms.PictureBox picFlames;
        private System.Windows.Forms.Timer tmrFlames;
        private System.Windows.Forms.Timer tmrMain;
		private System.Windows.Forms.Button btnClearFire;
	}
}

