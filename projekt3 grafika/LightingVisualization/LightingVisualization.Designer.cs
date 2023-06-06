using System.Drawing;

namespace LightingVisualization
{
    partial class LightingVisualization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LightingVisualization));
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.GraphicIcon = new System.Windows.Forms.Label();
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.tbKa = new System.Windows.Forms.TrackBar();
            this.tbIp = new System.Windows.Forms.TrackBar();
            this.labelKa = new System.Windows.Forms.Label();
            this.labelIp = new System.Windows.Forms.Label();
            this.tbIa = new System.Windows.Forms.TrackBar();
            this.labelIa = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resPar = new System.Windows.Forms.Button();
            this.tbKd = new System.Windows.Forms.TrackBar();
            this.tbN = new System.Windows.Forms.TrackBar();
            this.tbKs = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.resPos = new System.Windows.Forms.Button();
            this.posT = new System.Windows.Forms.Label();
            this.posD = new System.Windows.Forms.Label();
            this.posU = new System.Windows.Forms.Label();
            this.posR = new System.Windows.Forms.Label();
            this.posL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Wood = new System.Windows.Forms.RadioButton();
            this.Intermediate = new System.Windows.Forms.RadioButton();
            this.Mirror = new System.Windows.Forms.RadioButton();
            this.DrawingPanel.SuspendLayout();
            this.OptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbKa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKs)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Controls.Add(this.GraphicIcon);
            this.DrawingPanel.Location = new System.Drawing.Point(112, 428);
            this.DrawingPanel.Margin = new System.Windows.Forms.Padding(10);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(917, 886);
            this.DrawingPanel.TabIndex = 0;
            // 
            // GraphicIcon
            // 
            this.GraphicIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.GraphicIcon.Location = new System.Drawing.Point(6, 0);
            this.GraphicIcon.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.GraphicIcon.Name = "GraphicIcon";
            this.GraphicIcon.Size = new System.Drawing.Size(917, 886);
            this.GraphicIcon.TabIndex = 0;
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.Controls.Add(this.tbKa);
            this.OptionsPanel.Controls.Add(this.tbIp);
            this.OptionsPanel.Controls.Add(this.labelKa);
            this.OptionsPanel.Controls.Add(this.labelIp);
            this.OptionsPanel.Controls.Add(this.tbIa);
            this.OptionsPanel.Controls.Add(this.labelIa);
            this.OptionsPanel.Controls.Add(this.label16);
            this.OptionsPanel.Controls.Add(this.label15);
            this.OptionsPanel.Controls.Add(this.label14);
            this.OptionsPanel.Controls.Add(this.label13);
            this.OptionsPanel.Controls.Add(this.label12);
            this.OptionsPanel.Controls.Add(this.label11);
            this.OptionsPanel.Controls.Add(this.label10);
            this.OptionsPanel.Controls.Add(this.label9);
            this.OptionsPanel.Controls.Add(this.label5);
            this.OptionsPanel.Controls.Add(this.label4);
            this.OptionsPanel.Controls.Add(this.label3);
            this.OptionsPanel.Controls.Add(this.label2);
            this.OptionsPanel.Controls.Add(this.resPar);
            this.OptionsPanel.Controls.Add(this.tbKd);
            this.OptionsPanel.Controls.Add(this.tbN);
            this.OptionsPanel.Controls.Add(this.tbKs);
            this.OptionsPanel.Controls.Add(this.label8);
            this.OptionsPanel.Controls.Add(this.label7);
            this.OptionsPanel.Controls.Add(this.label6);
            this.OptionsPanel.Controls.Add(this.resPos);
            this.OptionsPanel.Controls.Add(this.posT);
            this.OptionsPanel.Controls.Add(this.posD);
            this.OptionsPanel.Controls.Add(this.posU);
            this.OptionsPanel.Controls.Add(this.posR);
            this.OptionsPanel.Controls.Add(this.posL);
            this.OptionsPanel.Controls.Add(this.label1);
            this.OptionsPanel.Controls.Add(this.Wood);
            this.OptionsPanel.Controls.Add(this.Intermediate);
            this.OptionsPanel.Controls.Add(this.Mirror);
            this.OptionsPanel.Location = new System.Drawing.Point(15, 8);
            this.OptionsPanel.Margin = new System.Windows.Forms.Padding(6);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(1316, 404);
            this.OptionsPanel.TabIndex = 1;
            // 
            // tbKa
            // 
            this.tbKa.Location = new System.Drawing.Point(918, 320);
            this.tbKa.Maximum = 100;
            this.tbKa.Name = "tbKa";
            this.tbKa.Size = new System.Drawing.Size(270, 80);
            this.tbKa.TabIndex = 34;
            this.tbKa.Minimum = 0;
            this.tbKa.Maximum = 100;
            this.tbKa.TickFrequency = 1;
            this.tbKa.ValueChanged += new System.EventHandler(this.tbKa_ValueChanged);
            // 
            // tbIp
            // 
            this.tbIp.Location = new System.Drawing.Point(493, 320);
            this.tbIp.Maximum = 100;
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(270, 80);
            this.tbIp.TabIndex = 33;
            this.tbIp.Minimum = 30000;
            this.tbIp.Maximum = 150000;
            this.tbIp.TickFrequency = 1000;
            this.tbIp.ValueChanged += new System.EventHandler(this.tbIp_ValueChanged);
            // 
            // tbIa
            // 
            this.tbIa.Location = new System.Drawing.Point(10, 320);
            this.tbIa.Maximum = 100;
            this.tbIa.Name = "tbIa";
            this.tbIa.Size = new System.Drawing.Size(270, 80);
            this.tbIa.TabIndex = 30;
            this.tbIa.Minimum = 0;
            this.tbIa.Maximum = 200;
            this.tbIa.TickFrequency = 2;
            this.tbIa.ValueChanged += new System.EventHandler(this.tbIa_ValueChanged);
            // 
            // labelKa
            // 
            this.labelKa.AutoSize = true;
            this.labelKa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.14286F);
            this.labelKa.ForeColor = System.Drawing.Color.White;
            this.labelKa.Location = new System.Drawing.Point(913, 283);
            this.labelKa.Name = "labelKa";
            this.labelKa.Size = new System.Drawing.Size(293, 25);
            this.labelKa.TabIndex = 32;
            this.labelKa.Text = "Współ. odbicia światła otoczenia";
            // 
            // labelIp
            // 
            this.labelIp.AutoSize = true;
            this.labelIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.14286F);
            this.labelIp.ForeColor = System.Drawing.Color.White;
            this.labelIp.Location = new System.Drawing.Point(488, 283);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(275, 25);
            this.labelIp.TabIndex = 31;
            this.labelIp.Text = "Natężenie światła punktowego";
            // 
            // labelIa
            // 
            this.labelIa.AutoSize = true;
            this.labelIa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.14286F);
            this.labelIa.ForeColor = System.Drawing.Color.White;
            this.labelIa.Location = new System.Drawing.Point(5, 283);
            this.labelIa.Name = "labelIa";
            this.labelIa.Size = new System.Drawing.Size(340, 25);
            this.labelIa.TabIndex = 29;
            this.labelIa.Text = "Natężenie światła w otoczeniu obiektu";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.14286F);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(416, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 20);
            this.label16.TabIndex = 28;
            this.label16.Text = "(do dołu)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.14286F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(400, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "(bliżej)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.14286F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(540, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "(dalej)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.14286F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(331, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "(w lewo)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.14286F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(513, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "(w prawo)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.14286F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(442, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "(do góry)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(384, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "Z";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(512, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 29);
            this.label9.TabIndex = 21;
            this.label9.Text = "C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(488, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(431, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "S";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(375, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(415, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "W";
            // 
            // resPar
            // 
            this.resPar.Location = new System.Drawing.Point(901, 67);
            this.resPar.Name = "resPar";
            this.resPar.Size = new System.Drawing.Size(194, 39);
            this.resPar.TabIndex = 16;
            this.resPar.Text = "Resetuj parametry";
            this.resPar.UseVisualStyleBackColor = true;
            this.resPar.Click += new System.EventHandler(this.resPar_Click);
            // 
            // tbKd
            // 
            this.tbKd.Location = new System.Drawing.Point(918, 200);
            this.tbKd.Maximum = 100;
            this.tbKd.Minimum = 0;
            this.tbKd.TickFrequency = 1;
            this.tbKd.Name = "tbKd";
            this.tbKd.Size = new System.Drawing.Size(270, 80);
            this.tbKd.TabIndex = 15;
            this.tbKd.ValueChanged += new System.EventHandler(this.tbKd_ValueChanged);
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(493, 200);
            this.tbN.Maximum = 100;
            this.tbN.Minimum = 0;
            this.tbN.TickFrequency = 1;
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(270, 80);
            this.tbN.TabIndex = 14;
            this.tbN.ValueChanged += new System.EventHandler(this.tbN_ValueChanged);
            // 
            // tbKs
            // 
            this.tbKs.Location = new System.Drawing.Point(10, 200);
            this.tbKs.Minimum = 0;
            this.tbKs.Maximum = 100;
            this.tbKs.TickFrequency = 1;
            this.tbKs.Name = "tbKs";
            this.tbKs.Size = new System.Drawing.Size(270, 80);
            this.tbKs.TabIndex = 13;
            this.tbKs.ValueChanged += new System.EventHandler(this.tbKs_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.14286F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(5, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Współ. odbicia kierunkowego";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.14286F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(913, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Współ. odbicia rozproszonego";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.14286F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(488, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Współ. gładkości powierzchni";
            // 
            // resPos
            // 
            this.resPos.Enabled = false;
            this.resPos.Location = new System.Drawing.Point(901, 6);
            this.resPos.Name = "resPos";
            this.resPos.Size = new System.Drawing.Size(194, 39);
            this.resPos.TabIndex = 9;
            this.resPos.Text = "Resetuj położenie";
            this.resPos.UseVisualStyleBackColor = true;
            this.resPos.Click += new System.EventHandler(this.resPos_Click);
            // 
            // posT
            // 
            this.posT.AutoSize = true;
            this.posT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F);
            this.posT.ForeColor = System.Drawing.Color.White;
            this.posT.Location = new System.Drawing.Point(745, 49);
            this.posT.Name = "posT";
            this.posT.Size = new System.Drawing.Size(80, 29);
            this.posT.TabIndex = 8;
            this.posT.Text = "[sfera]";
            // 
            // posD
            // 
            this.posD.AutoSize = true;
            this.posD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F);
            this.posD.ForeColor = System.Drawing.Color.White;
            this.posD.Location = new System.Drawing.Point(773, 92);
            this.posD.Name = "posD";
            this.posD.Size = new System.Drawing.Size(27, 29);
            this.posD.TabIndex = 7;
            this.posD.Text = "[]";
            // 
            // posU
            // 
            this.posU.AutoSize = true;
            this.posU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F);
            this.posU.ForeColor = System.Drawing.Color.White;
            this.posU.Location = new System.Drawing.Point(773, 6);
            this.posU.Name = "posU";
            this.posU.Size = new System.Drawing.Size(27, 29);
            this.posU.TabIndex = 6;
            this.posU.Text = "[]";
            // 
            // posR
            // 
            this.posR.AutoSize = true;
            this.posR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F);
            this.posR.ForeColor = System.Drawing.Color.White;
            this.posR.Location = new System.Drawing.Point(845, 49);
            this.posR.Name = "posR";
            this.posR.Size = new System.Drawing.Size(27, 29);
            this.posR.TabIndex = 5;
            this.posR.Text = "[]";
            // 
            // posL
            // 
            this.posL.AutoSize = true;
            this.posL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F);
            this.posL.ForeColor = System.Drawing.Color.White;
            this.posL.Location = new System.Drawing.Point(689, 51);
            this.posL.Name = "posL";
            this.posL.Size = new System.Drawing.Size(27, 29);
            this.posL.TabIndex = 4;
            this.posL.Text = "[]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.14286F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(594, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Położenie kamery:";
            // 
            // Wood
            // 
            this.Wood.AutoSize = true;
            this.Wood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F);
            this.Wood.ForeColor = System.Drawing.Color.White;
            this.Wood.Location = new System.Drawing.Point(6, 88);
            this.Wood.Margin = new System.Windows.Forms.Padding(6);
            this.Wood.Name = "Wood";
            this.Wood.Size = new System.Drawing.Size(302, 33);
            this.Wood.TabIndex = 2;
            this.Wood.TabStop = true;
            this.Wood.Text = "Powierzchnia metaliczna";
            this.Wood.UseVisualStyleBackColor = true;
            this.Wood.CheckedChanged += new System.EventHandler(this.Wood_CheckedChanged);
            // 
            // Intermediate
            // 
            this.Intermediate.AutoSize = true;
            this.Intermediate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F);
            this.Intermediate.ForeColor = System.Drawing.Color.White;
            this.Intermediate.Location = new System.Drawing.Point(6, 47);
            this.Intermediate.Margin = new System.Windows.Forms.Padding(6);
            this.Intermediate.Name = "Intermediate";
            this.Intermediate.Size = new System.Drawing.Size(290, 33);
            this.Intermediate.TabIndex = 1;
            this.Intermediate.TabStop = true;
            this.Intermediate.Text = "Powierzchnia mieszana";
            this.Intermediate.UseVisualStyleBackColor = true;
            this.Intermediate.CheckedChanged += new System.EventHandler(this.Intermediate_CheckedChanged);
            // 
            // Mirror
            // 
            this.Mirror.AutoSize = true;
            this.Mirror.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14286F);
            this.Mirror.ForeColor = System.Drawing.Color.White;
            this.Mirror.Location = new System.Drawing.Point(6, 6);
            this.Mirror.Margin = new System.Windows.Forms.Padding(6);
            this.Mirror.Name = "Mirror";
            this.Mirror.Size = new System.Drawing.Size(272, 33);
            this.Mirror.TabIndex = 0;
            this.Mirror.TabStop = true;
            this.Mirror.Text = "Powierzchnia matowa";
            this.Mirror.UseVisualStyleBackColor = true;
            this.Mirror.CheckedChanged += new System.EventHandler(this.Mirror_CheckedChanged);
            // 
            // LightingVisualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1340, 1441);
            this.Controls.Add(this.OptionsPanel);
            this.Controls.Add(this.DrawingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LightingVisualization";
            this.Text = "Model oświetlenia Phonga 1975";
            this.Load += new System.EventHandler(this.LightingVisualization_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LightingVisualization_KeyUp);
            this.DrawingPanel.ResumeLayout(false);
            this.OptionsPanel.ResumeLayout(false);
            this.OptionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbKa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.RadioButton Mirror;
        private System.Windows.Forms.RadioButton Wood;
        private System.Windows.Forms.RadioButton Intermediate;
        private System.Windows.Forms.Label GraphicIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resPos;
        private System.Windows.Forms.Label posT;
        private System.Windows.Forms.Label posD;
        private System.Windows.Forms.Label posU;
        private System.Windows.Forms.Label posR;
        private System.Windows.Forms.Label posL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar tbKd;
        private System.Windows.Forms.TrackBar tbN;
        private System.Windows.Forms.TrackBar tbKs;
        private System.Windows.Forms.Button resPar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar tbIa;
        private System.Windows.Forms.Label labelIa;
        private System.Windows.Forms.TrackBar tbKa;
        private System.Windows.Forms.TrackBar tbIp;
        private System.Windows.Forms.Label labelKa;
        private System.Windows.Forms.Label labelIp;
    }
}

