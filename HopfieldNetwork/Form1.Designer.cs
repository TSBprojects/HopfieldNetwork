namespace HopfieldNetwork
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClearField = new System.Windows.Forms.Button();
            this.AddImage = new System.Windows.Forms.Button();
            this.ClearImages = new System.Windows.Forms.Button();
            this.RecognizeImage = new System.Windows.Forms.Button();
            this.ShowImage = new System.Windows.Forms.Button();
            this.CellSizeBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ImageSizeBox = new System.Windows.Forms.NumericUpDown();
            this.Recalculate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellSizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSizeBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(219, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 337);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // ClearField
            // 
            this.ClearField.Location = new System.Drawing.Point(21, 27);
            this.ClearField.Name = "ClearField";
            this.ClearField.Size = new System.Drawing.Size(123, 23);
            this.ClearField.TabIndex = 0;
            this.ClearField.Text = "Очистить поле";
            this.ClearField.UseVisualStyleBackColor = true;
            this.ClearField.Click += new System.EventHandler(this.ClearField_Click);
            // 
            // AddImage
            // 
            this.AddImage.Location = new System.Drawing.Point(21, 56);
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(123, 23);
            this.AddImage.TabIndex = 2;
            this.AddImage.Text = "Добавить образ";
            this.AddImage.UseVisualStyleBackColor = true;
            this.AddImage.Click += new System.EventHandler(this.AddImage_Click);
            // 
            // ClearImages
            // 
            this.ClearImages.Location = new System.Drawing.Point(21, 114);
            this.ClearImages.Name = "ClearImages";
            this.ClearImages.Size = new System.Drawing.Size(123, 23);
            this.ClearImages.TabIndex = 3;
            this.ClearImages.Text = "Очистить образы";
            this.ClearImages.UseVisualStyleBackColor = true;
            this.ClearImages.Click += new System.EventHandler(this.ClearImages_Click);
            // 
            // RecognizeImage
            // 
            this.RecognizeImage.Location = new System.Drawing.Point(21, 143);
            this.RecognizeImage.Name = "RecognizeImage";
            this.RecognizeImage.Size = new System.Drawing.Size(123, 23);
            this.RecognizeImage.TabIndex = 4;
            this.RecognizeImage.Text = "Распознать образ";
            this.RecognizeImage.UseVisualStyleBackColor = true;
            this.RecognizeImage.Click += new System.EventHandler(this.RecognizeImage_Click);
            // 
            // ShowImage
            // 
            this.ShowImage.Location = new System.Drawing.Point(21, 85);
            this.ShowImage.Name = "ShowImage";
            this.ShowImage.Size = new System.Drawing.Size(123, 23);
            this.ShowImage.TabIndex = 5;
            this.ShowImage.Text = "Показать образ";
            this.ShowImage.UseVisualStyleBackColor = true;
            this.ShowImage.Click += new System.EventHandler(this.ShowImage_Click);
            // 
            // CellSizeBox
            // 
            this.CellSizeBox.Location = new System.Drawing.Point(109, 181);
            this.CellSizeBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.CellSizeBox.Name = "CellSizeBox";
            this.CellSizeBox.Size = new System.Drawing.Size(35, 20);
            this.CellSizeBox.TabIndex = 6;
            this.CellSizeBox.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.CellSizeBox.ValueChanged += new System.EventHandler(this.CellSizeBox_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Размер ячейки";
            // 
            // ImageSizeBox
            // 
            this.ImageSizeBox.Location = new System.Drawing.Point(21, 32);
            this.ImageSizeBox.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ImageSizeBox.Name = "ImageSizeBox";
            this.ImageSizeBox.Size = new System.Drawing.Size(123, 20);
            this.ImageSizeBox.TabIndex = 9;
            this.ImageSizeBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Recalculate
            // 
            this.Recalculate.Location = new System.Drawing.Point(21, 59);
            this.Recalculate.Name = "Recalculate";
            this.Recalculate.Size = new System.Drawing.Size(123, 23);
            this.Recalculate.TabIndex = 10;
            this.Recalculate.Text = "Пересчитать";
            this.Recalculate.UseVisualStyleBackColor = true;
            this.Recalculate.Click += new System.EventHandler(this.Recalculate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ImageSizeBox);
            this.groupBox2.Controls.Add(this.Recalculate);
            this.groupBox2.Location = new System.Drawing.Point(12, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 106);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Размер образа";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearField);
            this.groupBox1.Controls.Add(this.AddImage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ClearImages);
            this.groupBox1.Controls.Add(this.CellSizeBox);
            this.groupBox1.Controls.Add(this.RecognizeImage);
            this.groupBox1.Controls.Add(this.ShowImage);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 216);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Работа с образами";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Cеть Хопфилда";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellSizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSizeBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ClearField;
        private System.Windows.Forms.Button AddImage;
        private System.Windows.Forms.Button ClearImages;
        private System.Windows.Forms.Button RecognizeImage;
        private System.Windows.Forms.Button ShowImage;
        private System.Windows.Forms.NumericUpDown CellSizeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ImageSizeBox;
        private System.Windows.Forms.Button Recalculate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}

