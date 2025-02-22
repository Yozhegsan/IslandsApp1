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
			this.panelBuild = new System.Windows.Forms.Panel();
			this.lblBuildInfo = new System.Windows.Forms.Label();
			this.rbBuildFactory = new System.Windows.Forms.RadioButton();
			this.rbBuildShieldGenerator = new System.Windows.Forms.RadioButton();
			this.rbBuildLaboratory = new System.Windows.Forms.RadioButton();
			this.rbBuildPowerPlant = new System.Windows.Forms.RadioButton();
			this.rbBuildAirField = new System.Windows.Forms.RadioButton();
			this.rbBuildMissileSilo = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panelAttack = new System.Windows.Forms.Panel();
			this.lblAtackInfo = new System.Windows.Forms.Label();
			this.rbAttackShield = new System.Windows.Forms.RadioButton();
			this.rbAttackArtillery = new System.Windows.Forms.RadioButton();
			this.rbAttackNuke = new System.Windows.Forms.RadioButton();
			this.rbAttackAirStrike = new System.Windows.Forms.RadioButton();
			this.rbAttackSpySatelite = new System.Windows.Forms.RadioButton();
			this.rbAttackMissile = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFlames)).BeginInit();
			this.panelBuild.SuspendLayout();
			this.panelAttack.SuspendLayout();
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
			// panelBuild
			// 
			this.panelBuild.BackColor = System.Drawing.SystemColors.Control;
			this.panelBuild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelBuild.Controls.Add(this.lblBuildInfo);
			this.panelBuild.Controls.Add(this.rbBuildFactory);
			this.panelBuild.Controls.Add(this.rbBuildShieldGenerator);
			this.panelBuild.Controls.Add(this.rbBuildLaboratory);
			this.panelBuild.Controls.Add(this.rbBuildPowerPlant);
			this.panelBuild.Controls.Add(this.rbBuildAirField);
			this.panelBuild.Controls.Add(this.rbBuildMissileSilo);
			this.panelBuild.Location = new System.Drawing.Point(649, 13);
			this.panelBuild.Name = "panelBuild";
			this.panelBuild.Size = new System.Drawing.Size(93, 271);
			this.panelBuild.TabIndex = 5;
			// 
			// lblBuildInfo
			// 
			this.lblBuildInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblBuildInfo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblBuildInfo.Location = new System.Drawing.Point(3, -1);
			this.lblBuildInfo.Name = "lblBuildInfo";
			this.lblBuildInfo.Size = new System.Drawing.Size(85, 32);
			this.lblBuildInfo.TabIndex = 1;
			this.lblBuildInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rbBuildFactory
			// 
			this.rbBuildFactory.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbBuildFactory.BackColor = System.Drawing.SystemColors.Control;
			this.rbBuildFactory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbBuildFactory.Location = new System.Drawing.Point(3, 225);
			this.rbBuildFactory.Name = "rbBuildFactory";
			this.rbBuildFactory.Size = new System.Drawing.Size(85, 38);
			this.rbBuildFactory.TabIndex = 0;
			this.rbBuildFactory.TabStop = true;
			this.rbBuildFactory.Tag = "Фабрика";
			this.rbBuildFactory.Text = "999";
			this.rbBuildFactory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rbBuildFactory.UseVisualStyleBackColor = false;
			this.rbBuildFactory.MouseEnter += new System.EventHandler(this.rbBuildMissileSilo_MouseEnter);
			this.rbBuildFactory.MouseLeave += new System.EventHandler(this.rbBuildMissileSilo_MouseLeave);
			// 
			// rbBuildShieldGenerator
			// 
			this.rbBuildShieldGenerator.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbBuildShieldGenerator.BackColor = System.Drawing.SystemColors.Control;
			this.rbBuildShieldGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbBuildShieldGenerator.Location = new System.Drawing.Point(3, 73);
			this.rbBuildShieldGenerator.Name = "rbBuildShieldGenerator";
			this.rbBuildShieldGenerator.Size = new System.Drawing.Size(85, 38);
			this.rbBuildShieldGenerator.TabIndex = 0;
			this.rbBuildShieldGenerator.TabStop = true;
			this.rbBuildShieldGenerator.Tag = "Генератор щита";
			this.rbBuildShieldGenerator.Text = "999";
			this.rbBuildShieldGenerator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rbBuildShieldGenerator.UseVisualStyleBackColor = false;
			this.rbBuildShieldGenerator.MouseEnter += new System.EventHandler(this.rbBuildMissileSilo_MouseEnter);
			this.rbBuildShieldGenerator.MouseLeave += new System.EventHandler(this.rbBuildMissileSilo_MouseLeave);
			// 
			// rbBuildLaboratory
			// 
			this.rbBuildLaboratory.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbBuildLaboratory.BackColor = System.Drawing.SystemColors.Control;
			this.rbBuildLaboratory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbBuildLaboratory.Location = new System.Drawing.Point(3, 187);
			this.rbBuildLaboratory.Name = "rbBuildLaboratory";
			this.rbBuildLaboratory.Size = new System.Drawing.Size(85, 38);
			this.rbBuildLaboratory.TabIndex = 0;
			this.rbBuildLaboratory.TabStop = true;
			this.rbBuildLaboratory.Tag = "Лабораторія";
			this.rbBuildLaboratory.Text = "999";
			this.rbBuildLaboratory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rbBuildLaboratory.UseVisualStyleBackColor = false;
			this.rbBuildLaboratory.MouseEnter += new System.EventHandler(this.rbBuildMissileSilo_MouseEnter);
			this.rbBuildLaboratory.MouseLeave += new System.EventHandler(this.rbBuildMissileSilo_MouseLeave);
			// 
			// rbBuildPowerPlant
			// 
			this.rbBuildPowerPlant.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbBuildPowerPlant.BackColor = System.Drawing.SystemColors.Control;
			this.rbBuildPowerPlant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbBuildPowerPlant.Location = new System.Drawing.Point(3, 111);
			this.rbBuildPowerPlant.Name = "rbBuildPowerPlant";
			this.rbBuildPowerPlant.Size = new System.Drawing.Size(85, 38);
			this.rbBuildPowerPlant.TabIndex = 0;
			this.rbBuildPowerPlant.TabStop = true;
			this.rbBuildPowerPlant.Tag = "Генератор";
			this.rbBuildPowerPlant.Text = "999";
			this.rbBuildPowerPlant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rbBuildPowerPlant.UseVisualStyleBackColor = false;
			this.rbBuildPowerPlant.MouseEnter += new System.EventHandler(this.rbBuildMissileSilo_MouseEnter);
			this.rbBuildPowerPlant.MouseLeave += new System.EventHandler(this.rbBuildMissileSilo_MouseLeave);
			// 
			// rbBuildAirField
			// 
			this.rbBuildAirField.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbBuildAirField.BackColor = System.Drawing.SystemColors.Control;
			this.rbBuildAirField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbBuildAirField.Location = new System.Drawing.Point(3, 149);
			this.rbBuildAirField.Name = "rbBuildAirField";
			this.rbBuildAirField.Size = new System.Drawing.Size(85, 38);
			this.rbBuildAirField.TabIndex = 0;
			this.rbBuildAirField.TabStop = true;
			this.rbBuildAirField.Tag = "Злітна смуга";
			this.rbBuildAirField.Text = "999";
			this.rbBuildAirField.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rbBuildAirField.UseVisualStyleBackColor = false;
			this.rbBuildAirField.MouseEnter += new System.EventHandler(this.rbBuildMissileSilo_MouseEnter);
			this.rbBuildAirField.MouseLeave += new System.EventHandler(this.rbBuildMissileSilo_MouseLeave);
			// 
			// rbBuildMissileSilo
			// 
			this.rbBuildMissileSilo.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbBuildMissileSilo.BackColor = System.Drawing.SystemColors.Control;
			this.rbBuildMissileSilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbBuildMissileSilo.Location = new System.Drawing.Point(3, 35);
			this.rbBuildMissileSilo.Name = "rbBuildMissileSilo";
			this.rbBuildMissileSilo.Size = new System.Drawing.Size(85, 38);
			this.rbBuildMissileSilo.TabIndex = 0;
			this.rbBuildMissileSilo.TabStop = true;
			this.rbBuildMissileSilo.Tag = "Ракетна шахта";
			this.rbBuildMissileSilo.Text = "999";
			this.rbBuildMissileSilo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rbBuildMissileSilo.UseVisualStyleBackColor = false;
			this.rbBuildMissileSilo.MouseEnter += new System.EventHandler(this.rbBuildMissileSilo_MouseEnter);
			this.rbBuildMissileSilo.MouseLeave += new System.EventHandler(this.rbBuildMissileSilo_MouseLeave);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(499, 29);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(125, 179);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "Missile Silo\r\nShield Generator\r\nPower Plant\r\nAir Field\r\nLaboratory\r\nFactory\r\n====" +
    "============\r\nMissile\r\nAir Strike\r\nArtillery\r\nSpy Satellite\r\nNuke\r\nShield";
			this.textBox1.Visible = false;
			// 
			// panelAttack
			// 
			this.panelAttack.BackColor = System.Drawing.SystemColors.Control;
			this.panelAttack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelAttack.Controls.Add(this.lblAtackInfo);
			this.panelAttack.Controls.Add(this.rbAttackShield);
			this.panelAttack.Controls.Add(this.rbAttackArtillery);
			this.panelAttack.Controls.Add(this.rbAttackNuke);
			this.panelAttack.Controls.Add(this.rbAttackAirStrike);
			this.panelAttack.Controls.Add(this.rbAttackSpySatelite);
			this.panelAttack.Controls.Add(this.rbAttackMissile);
			this.panelAttack.Location = new System.Drawing.Point(748, 13);
			this.panelAttack.Name = "panelAttack";
			this.panelAttack.Size = new System.Drawing.Size(93, 271);
			this.panelAttack.TabIndex = 7;
			// 
			// lblAtackInfo
			// 
			this.lblAtackInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblAtackInfo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblAtackInfo.Location = new System.Drawing.Point(3, 0);
			this.lblAtackInfo.Name = "lblAtackInfo";
			this.lblAtackInfo.Size = new System.Drawing.Size(88, 32);
			this.lblAtackInfo.TabIndex = 2;
			this.lblAtackInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rbAttackShield
			// 
			this.rbAttackShield.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbAttackShield.BackColor = System.Drawing.SystemColors.Control;
			this.rbAttackShield.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbAttackShield.Location = new System.Drawing.Point(3, 225);
			this.rbAttackShield.Name = "rbAttackShield";
			this.rbAttackShield.Size = new System.Drawing.Size(85, 38);
			this.rbAttackShield.TabIndex = 1;
			this.rbAttackShield.TabStop = true;
			this.rbAttackShield.Tag = "Щит";
			this.rbAttackShield.Text = "999";
			this.rbAttackShield.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rbAttackShield.UseVisualStyleBackColor = false;
			this.rbAttackShield.MouseEnter += new System.EventHandler(this.rbAttackMissile_MouseEnter);
			this.rbAttackShield.MouseLeave += new System.EventHandler(this.rbAttackMissile_MouseLeave);
			// 
			// rbAttackArtillery
			// 
			this.rbAttackArtillery.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbAttackArtillery.BackColor = System.Drawing.SystemColors.Control;
			this.rbAttackArtillery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbAttackArtillery.Location = new System.Drawing.Point(3, 111);
			this.rbAttackArtillery.Name = "rbAttackArtillery";
			this.rbAttackArtillery.Size = new System.Drawing.Size(85, 38);
			this.rbAttackArtillery.TabIndex = 1;
			this.rbAttackArtillery.TabStop = true;
			this.rbAttackArtillery.Tag = "Артилерія";
			this.rbAttackArtillery.Text = "999";
			this.rbAttackArtillery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rbAttackArtillery.UseVisualStyleBackColor = false;
			this.rbAttackArtillery.MouseEnter += new System.EventHandler(this.rbAttackMissile_MouseEnter);
			this.rbAttackArtillery.MouseLeave += new System.EventHandler(this.rbAttackMissile_MouseLeave);
			// 
			// rbAttackNuke
			// 
			this.rbAttackNuke.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbAttackNuke.BackColor = System.Drawing.SystemColors.Control;
			this.rbAttackNuke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbAttackNuke.Location = new System.Drawing.Point(3, 187);
			this.rbAttackNuke.Name = "rbAttackNuke";
			this.rbAttackNuke.Size = new System.Drawing.Size(85, 38);
			this.rbAttackNuke.TabIndex = 1;
			this.rbAttackNuke.TabStop = true;
			this.rbAttackNuke.Tag = "Ядерна бомба";
			this.rbAttackNuke.Text = "999";
			this.rbAttackNuke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rbAttackNuke.UseVisualStyleBackColor = false;
			this.rbAttackNuke.MouseEnter += new System.EventHandler(this.rbAttackMissile_MouseEnter);
			this.rbAttackNuke.MouseLeave += new System.EventHandler(this.rbAttackMissile_MouseLeave);
			// 
			// rbAttackAirStrike
			// 
			this.rbAttackAirStrike.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbAttackAirStrike.BackColor = System.Drawing.SystemColors.Control;
			this.rbAttackAirStrike.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbAttackAirStrike.Location = new System.Drawing.Point(3, 73);
			this.rbAttackAirStrike.Name = "rbAttackAirStrike";
			this.rbAttackAirStrike.Size = new System.Drawing.Size(85, 38);
			this.rbAttackAirStrike.TabIndex = 1;
			this.rbAttackAirStrike.TabStop = true;
			this.rbAttackAirStrike.Tag = "Літак";
			this.rbAttackAirStrike.Text = "999";
			this.rbAttackAirStrike.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rbAttackAirStrike.UseVisualStyleBackColor = false;
			this.rbAttackAirStrike.MouseEnter += new System.EventHandler(this.rbAttackMissile_MouseEnter);
			this.rbAttackAirStrike.MouseLeave += new System.EventHandler(this.rbAttackMissile_MouseLeave);
			// 
			// rbAttackSpySatelite
			// 
			this.rbAttackSpySatelite.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbAttackSpySatelite.BackColor = System.Drawing.SystemColors.Control;
			this.rbAttackSpySatelite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbAttackSpySatelite.Location = new System.Drawing.Point(3, 149);
			this.rbAttackSpySatelite.Name = "rbAttackSpySatelite";
			this.rbAttackSpySatelite.Size = new System.Drawing.Size(85, 38);
			this.rbAttackSpySatelite.TabIndex = 1;
			this.rbAttackSpySatelite.TabStop = true;
			this.rbAttackSpySatelite.Tag = "Супутник шпигуп";
			this.rbAttackSpySatelite.Text = "999";
			this.rbAttackSpySatelite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rbAttackSpySatelite.UseVisualStyleBackColor = false;
			this.rbAttackSpySatelite.MouseEnter += new System.EventHandler(this.rbAttackMissile_MouseEnter);
			this.rbAttackSpySatelite.MouseLeave += new System.EventHandler(this.rbAttackMissile_MouseLeave);
			// 
			// rbAttackMissile
			// 
			this.rbAttackMissile.Appearance = System.Windows.Forms.Appearance.Button;
			this.rbAttackMissile.BackColor = System.Drawing.SystemColors.Control;
			this.rbAttackMissile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbAttackMissile.Location = new System.Drawing.Point(3, 35);
			this.rbAttackMissile.Name = "rbAttackMissile";
			this.rbAttackMissile.Size = new System.Drawing.Size(85, 38);
			this.rbAttackMissile.TabIndex = 1;
			this.rbAttackMissile.TabStop = true;
			this.rbAttackMissile.Tag = "Ракета";
			this.rbAttackMissile.Text = "999";
			this.rbAttackMissile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rbAttackMissile.UseVisualStyleBackColor = false;
			this.rbAttackMissile.MouseEnter += new System.EventHandler(this.rbAttackMissile_MouseEnter);
			this.rbAttackMissile.MouseLeave += new System.EventHandler(this.rbAttackMissile_MouseLeave);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(857, 508);
			this.Controls.Add(this.panelAttack);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.panelBuild);
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
			this.panelBuild.ResumeLayout(false);
			this.panelAttack.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.ListBox lstMap;
        private System.Windows.Forms.ListBox lstIsland;
        private System.Windows.Forms.PictureBox picFlames;
        private System.Windows.Forms.Timer tmrFlames;
        private System.Windows.Forms.Timer tmrMain;
		private System.Windows.Forms.Button btnClearFire;
		private System.Windows.Forms.Panel panelBuild;
		private System.Windows.Forms.RadioButton rbBuildFactory;
		private System.Windows.Forms.RadioButton rbBuildShieldGenerator;
		private System.Windows.Forms.RadioButton rbBuildLaboratory;
		private System.Windows.Forms.RadioButton rbBuildPowerPlant;
		private System.Windows.Forms.RadioButton rbBuildAirField;
		private System.Windows.Forms.RadioButton rbBuildMissileSilo;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lblBuildInfo;
		private System.Windows.Forms.Panel panelAttack;
		private System.Windows.Forms.Label lblAtackInfo;
		private System.Windows.Forms.RadioButton rbAttackShield;
		private System.Windows.Forms.RadioButton rbAttackArtillery;
		private System.Windows.Forms.RadioButton rbAttackNuke;
		private System.Windows.Forms.RadioButton rbAttackAirStrike;
		private System.Windows.Forms.RadioButton rbAttackSpySatelite;
		private System.Windows.Forms.RadioButton rbAttackMissile;
	}
}

