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
			this.rbBuildMissileSilo = new System.Windows.Forms.RadioButton();
			this.rbBuildPowerPlant = new System.Windows.Forms.RadioButton();
			this.rbBuildShieldGenerator = new System.Windows.Forms.RadioButton();
			this.rbBuildAirField = new System.Windows.Forms.RadioButton();
			this.rbBuildLaboratory = new System.Windows.Forms.RadioButton();
			this.rbBuildFactory = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lblBuildInfo = new System.Windows.Forms.Label();
			this.panelAttack = new System.Windows.Forms.Panel();
			this.rbAttackMissile = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.rbAttackAirStrike = new System.Windows.Forms.RadioButton();
			this.rbAttackArtillery = new System.Windows.Forms.RadioButton();
			this.rbAttackSpySatelite = new System.Windows.Forms.RadioButton();
			this.rbAttackNuke = new System.Windows.Forms.RadioButton();
			this.rbAttackShield = new System.Windows.Forms.RadioButton();
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
			this.panelBuild.Location = new System.Drawing.Point(649, 12);
			this.panelBuild.Name = "panelBuild";
			this.panelBuild.Size = new System.Drawing.Size(122, 173);
			this.panelBuild.TabIndex = 5;
			// 
			// rbBuildMissileSilo
			// 
			this.rbBuildMissileSilo.BackColor = System.Drawing.SystemColors.Control;
			this.rbBuildMissileSilo.Location = new System.Drawing.Point(3, 35);
			this.rbBuildMissileSilo.Name = "rbBuildMissileSilo";
			this.rbBuildMissileSilo.Size = new System.Drawing.Size(54, 40);
			this.rbBuildMissileSilo.TabIndex = 0;
			this.rbBuildMissileSilo.TabStop = true;
			this.rbBuildMissileSilo.Tag = "Missile Silo";
			this.rbBuildMissileSilo.UseVisualStyleBackColor = false;
			this.rbBuildMissileSilo.MouseEnter += new System.EventHandler(this.rbBuildMissileSilo_MouseEnter);
			this.rbBuildMissileSilo.MouseLeave += new System.EventHandler(this.rbBuildMissileSilo_MouseLeave);
			// 
			// rbBuildPowerPlant
			// 
			this.rbBuildPowerPlant.Location = new System.Drawing.Point(3, 123);
			this.rbBuildPowerPlant.Name = "rbBuildPowerPlant";
			this.rbBuildPowerPlant.Size = new System.Drawing.Size(54, 40);
			this.rbBuildPowerPlant.TabIndex = 0;
			this.rbBuildPowerPlant.TabStop = true;
			this.rbBuildPowerPlant.Tag = "Power Plant";
			this.rbBuildPowerPlant.UseVisualStyleBackColor = true;
			this.rbBuildPowerPlant.MouseEnter += new System.EventHandler(this.rbBuildMissileSilo_MouseEnter);
			this.rbBuildPowerPlant.MouseLeave += new System.EventHandler(this.rbBuildMissileSilo_MouseLeave);
			// 
			// rbBuildShieldGenerator
			// 
			this.rbBuildShieldGenerator.Location = new System.Drawing.Point(3, 79);
			this.rbBuildShieldGenerator.Name = "rbBuildShieldGenerator";
			this.rbBuildShieldGenerator.Size = new System.Drawing.Size(54, 40);
			this.rbBuildShieldGenerator.TabIndex = 0;
			this.rbBuildShieldGenerator.TabStop = true;
			this.rbBuildShieldGenerator.Tag = "Shield Generator";
			this.rbBuildShieldGenerator.UseVisualStyleBackColor = true;
			this.rbBuildShieldGenerator.MouseEnter += new System.EventHandler(this.rbBuildMissileSilo_MouseEnter);
			this.rbBuildShieldGenerator.MouseLeave += new System.EventHandler(this.rbBuildMissileSilo_MouseLeave);
			// 
			// rbBuildAirField
			// 
			this.rbBuildAirField.Location = new System.Drawing.Point(61, 35);
			this.rbBuildAirField.Name = "rbBuildAirField";
			this.rbBuildAirField.Size = new System.Drawing.Size(54, 40);
			this.rbBuildAirField.TabIndex = 0;
			this.rbBuildAirField.TabStop = true;
			this.rbBuildAirField.Tag = "Air Field";
			this.rbBuildAirField.UseVisualStyleBackColor = true;
			this.rbBuildAirField.MouseEnter += new System.EventHandler(this.rbBuildMissileSilo_MouseEnter);
			this.rbBuildAirField.MouseLeave += new System.EventHandler(this.rbBuildMissileSilo_MouseLeave);
			// 
			// rbBuildLaboratory
			// 
			this.rbBuildLaboratory.Location = new System.Drawing.Point(61, 79);
			this.rbBuildLaboratory.Name = "rbBuildLaboratory";
			this.rbBuildLaboratory.Size = new System.Drawing.Size(54, 40);
			this.rbBuildLaboratory.TabIndex = 0;
			this.rbBuildLaboratory.TabStop = true;
			this.rbBuildLaboratory.Tag = "Laboratory";
			this.rbBuildLaboratory.UseVisualStyleBackColor = true;
			this.rbBuildLaboratory.MouseEnter += new System.EventHandler(this.rbBuildMissileSilo_MouseEnter);
			this.rbBuildLaboratory.MouseLeave += new System.EventHandler(this.rbBuildMissileSilo_MouseLeave);
			// 
			// rbBuildFactory
			// 
			this.rbBuildFactory.Location = new System.Drawing.Point(61, 123);
			this.rbBuildFactory.Name = "rbBuildFactory";
			this.rbBuildFactory.Size = new System.Drawing.Size(54, 40);
			this.rbBuildFactory.TabIndex = 0;
			this.rbBuildFactory.TabStop = true;
			this.rbBuildFactory.Tag = "Factory";
			this.rbBuildFactory.UseVisualStyleBackColor = true;
			this.rbBuildFactory.MouseEnter += new System.EventHandler(this.rbBuildMissileSilo_MouseEnter);
			this.rbBuildFactory.MouseLeave += new System.EventHandler(this.rbBuildMissileSilo_MouseLeave);
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
			// lblBuildInfo
			// 
			this.lblBuildInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblBuildInfo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblBuildInfo.Location = new System.Drawing.Point(3, -1);
			this.lblBuildInfo.Name = "lblBuildInfo";
			this.lblBuildInfo.Size = new System.Drawing.Size(104, 32);
			this.lblBuildInfo.TabIndex = 1;
			this.lblBuildInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelAttack
			// 
			this.panelAttack.BackColor = System.Drawing.SystemColors.Control;
			this.panelAttack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelAttack.Controls.Add(this.label1);
			this.panelAttack.Controls.Add(this.rbAttackShield);
			this.panelAttack.Controls.Add(this.rbAttackArtillery);
			this.panelAttack.Controls.Add(this.rbAttackNuke);
			this.panelAttack.Controls.Add(this.rbAttackAirStrike);
			this.panelAttack.Controls.Add(this.rbAttackSpySatelite);
			this.panelAttack.Controls.Add(this.rbAttackMissile);
			this.panelAttack.Location = new System.Drawing.Point(649, 228);
			this.panelAttack.Name = "panelAttack";
			this.panelAttack.Size = new System.Drawing.Size(122, 173);
			this.panelAttack.TabIndex = 7;
			// 
			// rbAttackMissile
			// 
			this.rbAttackMissile.Location = new System.Drawing.Point(3, 35);
			this.rbAttackMissile.Name = "rbAttackMissile";
			this.rbAttackMissile.Size = new System.Drawing.Size(54, 40);
			this.rbAttackMissile.TabIndex = 1;
			this.rbAttackMissile.TabStop = true;
			this.rbAttackMissile.Tag = "Missile Silo";
			this.rbAttackMissile.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 32);
			this.label1.TabIndex = 2;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rbAttackAirStrike
			// 
			this.rbAttackAirStrike.Location = new System.Drawing.Point(3, 81);
			this.rbAttackAirStrike.Name = "rbAttackAirStrike";
			this.rbAttackAirStrike.Size = new System.Drawing.Size(54, 40);
			this.rbAttackAirStrike.TabIndex = 1;
			this.rbAttackAirStrike.TabStop = true;
			this.rbAttackAirStrike.Tag = "Missile Silo";
			this.rbAttackAirStrike.UseVisualStyleBackColor = true;
			// 
			// rbAttackArtillery
			// 
			this.rbAttackArtillery.Location = new System.Drawing.Point(3, 127);
			this.rbAttackArtillery.Name = "rbAttackArtillery";
			this.rbAttackArtillery.Size = new System.Drawing.Size(54, 40);
			this.rbAttackArtillery.TabIndex = 1;
			this.rbAttackArtillery.TabStop = true;
			this.rbAttackArtillery.Tag = "Missile Silo";
			this.rbAttackArtillery.UseVisualStyleBackColor = true;
			// 
			// rbAttackSpySatelite
			// 
			this.rbAttackSpySatelite.Location = new System.Drawing.Point(61, 35);
			this.rbAttackSpySatelite.Name = "rbAttackSpySatelite";
			this.rbAttackSpySatelite.Size = new System.Drawing.Size(54, 40);
			this.rbAttackSpySatelite.TabIndex = 1;
			this.rbAttackSpySatelite.TabStop = true;
			this.rbAttackSpySatelite.Tag = "Missile Silo";
			this.rbAttackSpySatelite.UseVisualStyleBackColor = true;
			// 
			// rbAttackNuke
			// 
			this.rbAttackNuke.Location = new System.Drawing.Point(61, 81);
			this.rbAttackNuke.Name = "rbAttackNuke";
			this.rbAttackNuke.Size = new System.Drawing.Size(54, 40);
			this.rbAttackNuke.TabIndex = 1;
			this.rbAttackNuke.TabStop = true;
			this.rbAttackNuke.Tag = "Missile Silo";
			this.rbAttackNuke.UseVisualStyleBackColor = true;
			// 
			// rbAttackShield
			// 
			this.rbAttackShield.Location = new System.Drawing.Point(61, 127);
			this.rbAttackShield.Name = "rbAttackShield";
			this.rbAttackShield.Size = new System.Drawing.Size(54, 40);
			this.rbAttackShield.TabIndex = 1;
			this.rbAttackShield.TabStop = true;
			this.rbAttackShield.Tag = "Missile Silo";
			this.rbAttackShield.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(787, 506);
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbAttackShield;
		private System.Windows.Forms.RadioButton rbAttackArtillery;
		private System.Windows.Forms.RadioButton rbAttackNuke;
		private System.Windows.Forms.RadioButton rbAttackAirStrike;
		private System.Windows.Forms.RadioButton rbAttackSpySatelite;
		private System.Windows.Forms.RadioButton rbAttackMissile;
	}
}

