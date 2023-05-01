
namespace task_3_geom_v2
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.checkBoxTransfer = new System.Windows.Forms.CheckBox();
            this.checkBoxStretching = new System.Windows.Forms.CheckBox();
            this.checkBoxReflectionY = new System.Windows.Forms.CheckBox();
            this.checkBoxReflectionX = new System.Windows.Forms.CheckBox();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.checkBoxTurn = new System.Windows.Forms.CheckBox();
            this.numericUpDownTurn = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTransferX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTransferY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStretchingX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownStretchingY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransferX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransferY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStretchingX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStretchingY)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(37, 528);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // checkBoxTransfer
            // 
            this.checkBoxTransfer.AutoSize = true;
            this.checkBoxTransfer.Location = new System.Drawing.Point(37, 28);
            this.checkBoxTransfer.Name = "checkBoxTransfer";
            this.checkBoxTransfer.Size = new System.Drawing.Size(70, 17);
            this.checkBoxTransfer.TabIndex = 1;
            this.checkBoxTransfer.Text = "Перенос";
            this.checkBoxTransfer.UseVisualStyleBackColor = true;
            // 
            // checkBoxStretching
            // 
            this.checkBoxStretching.AutoSize = true;
            this.checkBoxStretching.Location = new System.Drawing.Point(37, 63);
            this.checkBoxStretching.Name = "checkBoxStretching";
            this.checkBoxStretching.Size = new System.Drawing.Size(88, 17);
            this.checkBoxStretching.TabIndex = 2;
            this.checkBoxStretching.Text = "Растяжение";
            this.checkBoxStretching.UseVisualStyleBackColor = true;
            // 
            // checkBoxReflectionY
            // 
            this.checkBoxReflectionY.AutoSize = true;
            this.checkBoxReflectionY.Location = new System.Drawing.Point(37, 99);
            this.checkBoxReflectionY.Name = "checkBoxReflectionY";
            this.checkBoxReflectionY.Size = new System.Drawing.Size(98, 17);
            this.checkBoxReflectionY.TabIndex = 3;
            this.checkBoxReflectionY.Text = "ОтражениеOY";
            this.checkBoxReflectionY.UseVisualStyleBackColor = true;
            // 
            // checkBoxReflectionX
            // 
            this.checkBoxReflectionX.AutoSize = true;
            this.checkBoxReflectionX.Location = new System.Drawing.Point(37, 134);
            this.checkBoxReflectionX.Name = "checkBoxReflectionX";
            this.checkBoxReflectionX.Size = new System.Drawing.Size(98, 17);
            this.checkBoxReflectionX.TabIndex = 4;
            this.checkBoxReflectionX.Text = "ОтражениеOX";
            this.checkBoxReflectionX.UseVisualStyleBackColor = true;
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(37, 582);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(75, 23);
            this.buttonRestart.TabIndex = 5;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // checkBoxTurn
            // 
            this.checkBoxTurn.AutoSize = true;
            this.checkBoxTurn.Location = new System.Drawing.Point(37, 170);
            this.checkBoxTurn.Name = "checkBoxTurn";
            this.checkBoxTurn.Size = new System.Drawing.Size(69, 17);
            this.checkBoxTurn.TabIndex = 6;
            this.checkBoxTurn.Text = "Поворот";
            this.checkBoxTurn.UseVisualStyleBackColor = true;
            // 
            // numericUpDownTurn
            // 
            this.numericUpDownTurn.DecimalPlaces = 1;
            this.numericUpDownTurn.Location = new System.Drawing.Point(15, 260);
            this.numericUpDownTurn.Name = "numericUpDownTurn";
            this.numericUpDownTurn.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTurn.TabIndex = 7;
            // 
            // numericUpDownTransferX
            // 
            this.numericUpDownTransferX.DecimalPlaces = 1;
            this.numericUpDownTransferX.Location = new System.Drawing.Point(15, 318);
            this.numericUpDownTransferX.Name = "numericUpDownTransferX";
            this.numericUpDownTransferX.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTransferX.TabIndex = 8;
            // 
            // numericUpDownTransferY
            // 
            this.numericUpDownTransferY.DecimalPlaces = 1;
            this.numericUpDownTransferY.Location = new System.Drawing.Point(15, 373);
            this.numericUpDownTransferY.Name = "numericUpDownTransferY";
            this.numericUpDownTransferY.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTransferY.TabIndex = 9;
            // 
            // numericUpDownStretchingX
            // 
            this.numericUpDownStretchingX.DecimalPlaces = 1;
            this.numericUpDownStretchingX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownStretchingX.Location = new System.Drawing.Point(15, 429);
            this.numericUpDownStretchingX.Name = "numericUpDownStretchingX";
            this.numericUpDownStretchingX.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownStretchingX.TabIndex = 10;
            this.numericUpDownStretchingX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Угол";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Сдвиг X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Сдвиг Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Массштабирование X";
            // 
            // numericUpDownStretchingY
            // 
            this.numericUpDownStretchingY.DecimalPlaces = 1;
            this.numericUpDownStretchingY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownStretchingY.Location = new System.Drawing.Point(15, 476);
            this.numericUpDownStretchingY.Name = "numericUpDownStretchingY";
            this.numericUpDownStretchingY.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownStretchingY.TabIndex = 15;
            this.numericUpDownStretchingY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Массштабирование Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownStretchingY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownStretchingX);
            this.Controls.Add(this.numericUpDownTransferY);
            this.Controls.Add(this.numericUpDownTransferX);
            this.Controls.Add(this.numericUpDownTurn);
            this.Controls.Add(this.checkBoxTurn);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.checkBoxReflectionX);
            this.Controls.Add(this.checkBoxReflectionY);
            this.Controls.Add(this.checkBoxStretching);
            this.Controls.Add(this.checkBoxTransfer);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransferX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransferY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStretchingX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStretchingY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.CheckBox checkBoxTransfer;
        private System.Windows.Forms.CheckBox checkBoxStretching;
        private System.Windows.Forms.CheckBox checkBoxReflectionY;
        private System.Windows.Forms.CheckBox checkBoxReflectionX;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.CheckBox checkBoxTurn;
        private System.Windows.Forms.NumericUpDown numericUpDownTurn;
        private System.Windows.Forms.NumericUpDown numericUpDownTransferX;
        private System.Windows.Forms.NumericUpDown numericUpDownTransferY;
        private System.Windows.Forms.NumericUpDown numericUpDownStretchingX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownStretchingY;
        private System.Windows.Forms.Label label5;
    }
}

