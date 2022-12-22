namespace Lab03
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
            this.pointButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lineButton = new System.Windows.Forms.Button();
            this.polygonButton = new System.Windows.Forms.Button();
            this.drawPolygonButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.dxdyButton = new System.Windows.Forms.Button();
            this.scaleButton = new System.Windows.Forms.Button();
            this.rotateButton = new System.Windows.Forms.Button();
            this.dxTextBox = new System.Windows.Forms.TextBox();
            this.dyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scaleKXTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rotatePhiTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.finishFunctionButton = new System.Windows.Forms.Button();
            this.hint = new System.Windows.Forms.Label();
            this.scaleKYTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.centerRB = new System.Windows.Forms.RadioButton();
            this.clickRB = new System.Windows.Forms.RadioButton();
            this.rotateLineButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.checkSideButton = new System.Windows.Forms.Button();
            this.checkSideTextBox = new System.Windows.Forms.Label();
            this.convexButton = new System.Windows.Forms.Button();
            this.nonConvexButton = new System.Windows.Forms.Button();
            this.convexLabel = new System.Windows.Forms.Label();
            this.nonConvexLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pointXTextBox = new System.Windows.Forms.TextBox();
            this.pointYTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pointButton
            // 
            this.pointButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pointButton.Location = new System.Drawing.Point(8, 3);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(80, 23);
            this.pointButton.TabIndex = 0;
            this.pointButton.Text = "Точка";
            this.pointButton.UseVisualStyleBackColor = true;
            this.pointButton.Click += new System.EventHandler(this.pointButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(218, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(754, 743);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // lineButton
            // 
            this.lineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineButton.Location = new System.Drawing.Point(8, 32);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(80, 23);
            this.lineButton.TabIndex = 2;
            this.lineButton.Text = "Ребро";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // polygonButton
            // 
            this.polygonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.polygonButton.Location = new System.Drawing.Point(8, 61);
            this.polygonButton.Name = "polygonButton";
            this.polygonButton.Size = new System.Drawing.Size(80, 23);
            this.polygonButton.TabIndex = 3;
            this.polygonButton.Text = "Полигон";
            this.polygonButton.UseVisualStyleBackColor = true;
            this.polygonButton.Click += new System.EventHandler(this.polygonButton_Click);
            // 
            // drawPolygonButton
            // 
            this.drawPolygonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.drawPolygonButton.Location = new System.Drawing.Point(7, 4);
            this.drawPolygonButton.Name = "drawPolygonButton";
            this.drawPolygonButton.Size = new System.Drawing.Size(95, 49);
            this.drawPolygonButton.TabIndex = 4;
            this.drawPolygonButton.Text = "Построить многоугольник";
            this.drawPolygonButton.UseVisualStyleBackColor = true;
            this.drawPolygonButton.Visible = false;
            this.drawPolygonButton.Click += new System.EventHandler(this.drawPolygonButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Location = new System.Drawing.Point(5, 62);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(95, 23);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Очистить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // dxdyButton
            // 
            this.dxdyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dxdyButton.Location = new System.Drawing.Point(23, 16);
            this.dxdyButton.Name = "dxdyButton";
            this.dxdyButton.Size = new System.Drawing.Size(75, 23);
            this.dxdyButton.TabIndex = 6;
            this.dxdyButton.Text = "Смещение";
            this.dxdyButton.UseVisualStyleBackColor = true;
            this.dxdyButton.Click += new System.EventHandler(this.dxdyButton_Click);
            // 
            // scaleButton
            // 
            this.scaleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scaleButton.Location = new System.Drawing.Point(23, 63);
            this.scaleButton.Name = "scaleButton";
            this.scaleButton.Size = new System.Drawing.Size(75, 23);
            this.scaleButton.TabIndex = 7;
            this.scaleButton.Text = "Масштаб";
            this.scaleButton.UseVisualStyleBackColor = true;
            this.scaleButton.Click += new System.EventHandler(this.scaleButton_Click);
            // 
            // rotateButton
            // 
            this.rotateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rotateButton.Location = new System.Drawing.Point(23, 113);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(75, 23);
            this.rotateButton.TabIndex = 8;
            this.rotateButton.Text = "Поворот";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // dxTextBox
            // 
            this.dxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dxTextBox.Location = new System.Drawing.Point(110, 18);
            this.dxTextBox.Name = "dxTextBox";
            this.dxTextBox.Size = new System.Drawing.Size(24, 20);
            this.dxTextBox.TabIndex = 9;
            this.dxTextBox.Text = "0";
            this.dxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dyTextBox
            // 
            this.dyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dyTextBox.Location = new System.Drawing.Point(146, 19);
            this.dyTextBox.Name = "dyTextBox";
            this.dyTextBox.Size = new System.Drawing.Size(24, 20);
            this.dyTextBox.TabIndex = 10;
            this.dyTextBox.Text = "0";
            this.dyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "dx";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "dy";
            // 
            // scaleKXTextBox
            // 
            this.scaleKXTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scaleKXTextBox.Location = new System.Drawing.Point(110, 66);
            this.scaleKXTextBox.Name = "scaleKXTextBox";
            this.scaleKXTextBox.Size = new System.Drawing.Size(24, 20);
            this.scaleKXTextBox.TabIndex = 16;
            this.scaleKXTextBox.Text = "1";
            this.scaleKXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "kX";
            // 
            // rotatePhiTextBox
            // 
            this.rotatePhiTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rotatePhiTextBox.Location = new System.Drawing.Point(110, 113);
            this.rotatePhiTextBox.Name = "rotatePhiTextBox";
            this.rotatePhiTextBox.Size = new System.Drawing.Size(24, 20);
            this.rotatePhiTextBox.TabIndex = 21;
            this.rotatePhiTextBox.Text = "0";
            this.rotatePhiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Phi";
            // 
            // finishFunctionButton
            // 
            this.finishFunctionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.finishFunctionButton.Location = new System.Drawing.Point(15, 11);
            this.finishFunctionButton.Name = "finishFunctionButton";
            this.finishFunctionButton.Size = new System.Drawing.Size(75, 35);
            this.finishFunctionButton.TabIndex = 25;
            this.finishFunctionButton.Text = "Redraw";
            this.finishFunctionButton.UseVisualStyleBackColor = true;
            this.finishFunctionButton.Visible = false;
            // 
            // hint
            // 
            this.hint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.hint.AutoSize = true;
            this.hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hint.Location = new System.Drawing.Point(815, 713);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(147, 31);
            this.hint.TabIndex = 26;
            this.hint.Text = "Just click it";
            this.hint.Visible = false;
            // 
            // scaleKYTextBox
            // 
            this.scaleKYTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scaleKYTextBox.Location = new System.Drawing.Point(146, 66);
            this.scaleKYTextBox.Name = "scaleKYTextBox";
            this.scaleKYTextBox.Size = new System.Drawing.Size(24, 20);
            this.scaleKYTextBox.TabIndex = 27;
            this.scaleKYTextBox.Text = "1";
            this.scaleKYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "kY";
            // 
            // centerRB
            // 
            this.centerRB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.centerRB.AutoSize = true;
            this.centerRB.Location = new System.Drawing.Point(2, 32);
            this.centerRB.Name = "centerRB";
            this.centerRB.Size = new System.Drawing.Size(56, 17);
            this.centerRB.TabIndex = 29;
            this.centerRB.Text = "Центр";
            this.centerRB.UseVisualStyleBackColor = true;
            this.centerRB.Click += new System.EventHandler(this.centerRB_Click);
            // 
            // clickRB
            // 
            this.clickRB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clickRB.AutoSize = true;
            this.clickRB.Checked = true;
            this.clickRB.Location = new System.Drawing.Point(3, 6);
            this.clickRB.Name = "clickRB";
            this.clickRB.Size = new System.Drawing.Size(55, 17);
            this.clickRB.TabIndex = 30;
            this.clickRB.TabStop = true;
            this.clickRB.Text = "Точка";
            this.clickRB.UseVisualStyleBackColor = true;
            this.clickRB.Click += new System.EventHandler(this.clickRB_Click);
            // 
            // rotateLineButton
            // 
            this.rotateLineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rotateLineButton.Location = new System.Drawing.Point(95, 12);
            this.rotateLineButton.Name = "rotateLineButton";
            this.rotateLineButton.Size = new System.Drawing.Size(94, 54);
            this.rotateLineButton.TabIndex = 31;
            this.rotateLineButton.Text = "Поворот ребра";
            this.rotateLineButton.UseVisualStyleBackColor = true;
            this.rotateLineButton.Click += new System.EventHandler(this.rotateLineButton_Click);
            // 
            // findButton
            // 
            this.findButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.findButton.Location = new System.Drawing.Point(2, 12);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(93, 54);
            this.findButton.TabIndex = 32;
            this.findButton.Text = "Точка пересечения";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // checkSideButton
            // 
            this.checkSideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkSideButton.Location = new System.Drawing.Point(5, 15);
            this.checkSideButton.Name = "checkSideButton";
            this.checkSideButton.Size = new System.Drawing.Size(76, 41);
            this.checkSideButton.TabIndex = 33;
            this.checkSideButton.Text = "Положение точки";
            this.checkSideButton.UseVisualStyleBackColor = true;
            this.checkSideButton.Click += new System.EventHandler(this.checkSideButton_Click);
            // 
            // checkSideTextBox
            // 
            this.checkSideTextBox.AutoSize = true;
            this.checkSideTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkSideTextBox.Location = new System.Drawing.Point(90, 27);
            this.checkSideTextBox.Name = "checkSideTextBox";
            this.checkSideTextBox.Size = new System.Drawing.Size(96, 16);
            this.checkSideTextBox.TabIndex = 34;
            this.checkSideTextBox.Text = "Нажмите LMB";
            this.checkSideTextBox.Visible = false;
            this.checkSideTextBox.Click += new System.EventHandler(this.checkSideTextBox_Click);
            // 
            // convexButton
            // 
            this.convexButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.convexButton.Location = new System.Drawing.Point(5, 62);
            this.convexButton.Name = "convexButton";
            this.convexButton.Size = new System.Drawing.Size(76, 52);
            this.convexButton.TabIndex = 35;
            this.convexButton.Text = "Выпуклость";
            this.convexButton.UseVisualStyleBackColor = true;
            this.convexButton.Click += new System.EventHandler(this.convexButton_Click);
            // 
            // nonConvexButton
            // 
            this.nonConvexButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nonConvexButton.Location = new System.Drawing.Point(3, 120);
            this.nonConvexButton.Name = "nonConvexButton";
            this.nonConvexButton.Size = new System.Drawing.Size(92, 52);
            this.nonConvexButton.TabIndex = 36;
            this.nonConvexButton.Text = "Невыпуклость";
            this.nonConvexButton.UseVisualStyleBackColor = true;
            this.nonConvexButton.Click += new System.EventHandler(this.nonConvexButton_Click);
            // 
            // convexLabel
            // 
            this.convexLabel.AutoSize = true;
            this.convexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.convexLabel.Location = new System.Drawing.Point(88, 80);
            this.convexLabel.Name = "convexLabel";
            this.convexLabel.Size = new System.Drawing.Size(96, 16);
            this.convexLabel.TabIndex = 37;
            this.convexLabel.Text = "Нажмите LBM";
            // 
            // nonConvexLabel
            // 
            this.nonConvexLabel.AutoSize = true;
            this.nonConvexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nonConvexLabel.Location = new System.Drawing.Point(96, 138);
            this.nonConvexLabel.Name = "nonConvexLabel";
            this.nonConvexLabel.Size = new System.Drawing.Size(96, 16);
            this.nonConvexLabel.TabIndex = 38;
            this.nonConvexLabel.Text = "Нажмите LBM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pointYTextBox);
            this.panel1.Controls.Add(this.pointXTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 943);
            this.panel1.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(160, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Y";
            this.label4.Visible = false;
            // 
            // pointXTextBox
            // 
            this.pointXTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pointXTextBox.Location = new System.Drawing.Point(122, 92);
            this.pointXTextBox.Name = "pointXTextBox";
            this.pointXTextBox.Size = new System.Drawing.Size(19, 20);
            this.pointXTextBox.TabIndex = 13;
            this.pointXTextBox.Text = "0";
            this.pointXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pointXTextBox.Visible = false;
            // 
            // pointYTextBox
            // 
            this.pointYTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pointYTextBox.Location = new System.Drawing.Point(160, 92);
            this.pointYTextBox.Name = "pointYTextBox";
            this.pointYTextBox.Size = new System.Drawing.Size(20, 20);
            this.pointYTextBox.TabIndex = 14;
            this.pointYTextBox.Text = "0";
            this.pointYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pointYTextBox.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(121, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "X";
            this.label3.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.checkSideTextBox);
            this.panel2.Controls.Add(this.checkSideButton);
            this.panel2.Controls.Add(this.convexButton);
            this.panel2.Controls.Add(this.convexLabel);
            this.panel2.Controls.Add(this.nonConvexLabel);
            this.panel2.Controls.Add(this.nonConvexButton);
            this.panel2.Location = new System.Drawing.Point(5, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 189);
            this.panel2.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.rotateLineButton);
            this.panel3.Controls.Add(this.findButton);
            this.panel3.Location = new System.Drawing.Point(5, 309);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 78);
            this.panel3.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Controls.Add(this.dxdyButton);
            this.panel4.Controls.Add(this.rotateButton);
            this.panel4.Controls.Add(this.rotatePhiTextBox);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.scaleKYTextBox);
            this.panel4.Controls.Add(this.scaleKXTextBox);
            this.panel4.Controls.Add(this.scaleButton);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dyTextBox);
            this.panel4.Controls.Add(this.dxTextBox);
            this.panel4.Location = new System.Drawing.Point(3, 133);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 145);
            this.panel4.TabIndex = 40;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Controls.Add(this.pointButton);
            this.panel5.Controls.Add(this.polygonButton);
            this.panel5.Controls.Add(this.lineButton);
            this.panel5.Location = new System.Drawing.Point(6, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(96, 89);
            this.panel5.TabIndex = 40;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel6.Controls.Add(this.clickRB);
            this.panel6.Controls.Add(this.centerRB);
            this.panel6.Location = new System.Drawing.Point(122, 8);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(66, 57);
            this.panel6.TabIndex = 40;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel7.Controls.Add(this.drawPolygonButton);
            this.panel7.Controls.Add(this.refreshButton);
            this.panel7.Controls.Add(this.finishFunctionButton);
            this.panel7.Location = new System.Drawing.Point(45, 632);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(105, 100);
            this.panel7.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 763);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hint);
            this.Location = new System.Drawing.Point(12, 12);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pointButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button polygonButton;
        private System.Windows.Forms.Button drawPolygonButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button dxdyButton;
        private System.Windows.Forms.Button scaleButton;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.TextBox dxTextBox;
        private System.Windows.Forms.TextBox dyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox scaleKXTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rotatePhiTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button finishFunctionButton;
        private System.Windows.Forms.Label hint;
        private System.Windows.Forms.TextBox scaleKYTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton centerRB;
        private System.Windows.Forms.RadioButton clickRB;
        private System.Windows.Forms.Button rotateLineButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button checkSideButton;
        private System.Windows.Forms.Label checkSideTextBox;
        private System.Windows.Forms.Button convexButton;
        private System.Windows.Forms.Button nonConvexButton;
        private System.Windows.Forms.Label convexLabel;
        private System.Windows.Forms.Label nonConvexLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pointYTextBox;
        private System.Windows.Forms.TextBox pointXTextBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
    }
}

