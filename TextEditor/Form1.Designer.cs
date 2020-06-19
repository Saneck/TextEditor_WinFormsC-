namespace TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.выделениеТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделатьТекстЖирнымToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьТекстКурсивомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подчеркнутьТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.красныйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синийТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стандартныйЦветТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.center = new System.Windows.Forms.Button();
            this.стандартныйШрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.цветФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.черныйФонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серыйФонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.белыйФонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.BurlyWood;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 72);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выйтиToolStripMenuItem,
            this.просмотретьФайлToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(269, 34);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(269, 34);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(269, 34);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // просмотретьФайлToolStripMenuItem
            // 
            this.просмотретьФайлToolStripMenuItem.Name = "просмотретьФайлToolStripMenuItem";
            this.просмотретьФайлToolStripMenuItem.Size = new System.Drawing.Size(269, 34);
            this.просмотретьФайлToolStripMenuItem.Text = "Просмотреть файл";
            this.просмотретьФайлToolStripMenuItem.Click += new System.EventHandler(this.просмотретьФайлToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.Location = new System.Drawing.Point(37, 109);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(830, 447);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = " ";
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(192, 33);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(234, 33);
            this.left.TabIndex = 5;
            this.left.Text = "Выравнить по левому краю";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(660, 33);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(234, 33);
            this.right.TabIndex = 6;
            this.right.Text = "Выравнить по правому краю";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.BurlyWood;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выделениеТекстаToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 36);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(901, 36);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // выделениеТекстаToolStripMenuItem
            // 
            this.выделениеТекстаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сделатьТекстЖирнымToolStripMenuItem,
            this.выделитьТекстКурсивомToolStripMenuItem,
            this.подчеркнутьТекстToolStripMenuItem,
            this.стандартныйШрифтToolStripMenuItem,
            this.красныйТекстToolStripMenuItem,
            this.зеленыйТекстToolStripMenuItem,
            this.синийТекстToolStripMenuItem,
            this.стандартныйЦветТекстаToolStripMenuItem});
            this.выделениеТекстаToolStripMenuItem.Name = "выделениеТекстаToolStripMenuItem";
            this.выделениеТекстаToolStripMenuItem.Size = new System.Drawing.Size(171, 29);
            this.выделениеТекстаToolStripMenuItem.Text = "Выделение текста";
            // 
            // сделатьТекстЖирнымToolStripMenuItem
            // 
            this.сделатьТекстЖирнымToolStripMenuItem.Name = "сделатьТекстЖирнымToolStripMenuItem";
            this.сделатьТекстЖирнымToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
            this.сделатьТекстЖирнымToolStripMenuItem.Text = "Сделать текст жирным";
            this.сделатьТекстЖирнымToolStripMenuItem.Click += new System.EventHandler(this.сделатьТекстЖирнымToolStripMenuItem_Click);
            // 
            // выделитьТекстКурсивомToolStripMenuItem
            // 
            this.выделитьТекстКурсивомToolStripMenuItem.Name = "выделитьТекстКурсивомToolStripMenuItem";
            this.выделитьТекстКурсивомToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
            this.выделитьТекстКурсивомToolStripMenuItem.Text = "Выделить текст курсивом";
            this.выделитьТекстКурсивомToolStripMenuItem.Click += new System.EventHandler(this.выделитьТекстКурсивомToolStripMenuItem_Click);
            // 
            // подчеркнутьТекстToolStripMenuItem
            // 
            this.подчеркнутьТекстToolStripMenuItem.Name = "подчеркнутьТекстToolStripMenuItem";
            this.подчеркнутьТекстToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
            this.подчеркнутьТекстToolStripMenuItem.Text = "Подчеркнуть текст";
            this.подчеркнутьТекстToolStripMenuItem.Click += new System.EventHandler(this.подчеркнутьТекстToolStripMenuItem_Click);
            // 
            // красныйТекстToolStripMenuItem
            // 
            this.красныйТекстToolStripMenuItem.Name = "красныйТекстToolStripMenuItem";
            this.красныйТекстToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
            this.красныйТекстToolStripMenuItem.Text = "Красный текст";
            this.красныйТекстToolStripMenuItem.Click += new System.EventHandler(this.красныйТекстToolStripMenuItem_Click);
            // 
            // зеленыйТекстToolStripMenuItem
            // 
            this.зеленыйТекстToolStripMenuItem.Name = "зеленыйТекстToolStripMenuItem";
            this.зеленыйТекстToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
            this.зеленыйТекстToolStripMenuItem.Text = "Зеленый текст";
            this.зеленыйТекстToolStripMenuItem.Click += new System.EventHandler(this.зеленыйТекстToolStripMenuItem_Click);
            // 
            // синийТекстToolStripMenuItem
            // 
            this.синийТекстToolStripMenuItem.Name = "синийТекстToolStripMenuItem";
            this.синийТекстToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
            this.синийТекстToolStripMenuItem.Text = "Синий текст";
            this.синийТекстToolStripMenuItem.Click += new System.EventHandler(this.синийТекстToolStripMenuItem_Click);
            // 
            // стандартныйЦветТекстаToolStripMenuItem
            // 
            this.стандартныйЦветТекстаToolStripMenuItem.Name = "стандартныйЦветТекстаToolStripMenuItem";
            this.стандартныйЦветТекстаToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
            this.стандартныйЦветТекстаToolStripMenuItem.Text = "Стандартный цвет текста";
            this.стандартныйЦветТекстаToolStripMenuItem.Click += new System.EventHandler(this.стандартныйЦветТекстаToolStripMenuItem_Click);
            // 
            // center
            // 
            this.center.Location = new System.Drawing.Point(444, 33);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(210, 33);
            this.center.TabIndex = 9;
            this.center.Text = "Выравнить по ширине";
            this.center.UseVisualStyleBackColor = true;
            this.center.Click += new System.EventHandler(this.center_Click);
            // 
            // стандартныйШрифтToolStripMenuItem
            // 
            this.стандартныйШрифтToolStripMenuItem.Name = "стандартныйШрифтToolStripMenuItem";
            this.стандартныйШрифтToolStripMenuItem.Size = new System.Drawing.Size(322, 34);
            this.стандартныйШрифтToolStripMenuItem.Text = "Стандартный шрифт";
            this.стандартныйШрифтToolStripMenuItem.Click += new System.EventHandler(this.стандартныйШрифтToolStripMenuItem_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.Color.BurlyWood;
            this.menuStrip3.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветФонаToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(901, 36);
            this.menuStrip3.TabIndex = 10;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // цветФонаToolStripMenuItem
            // 
            this.цветФонаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.черныйФонToolStripMenuItem,
            this.серыйФонToolStripMenuItem,
            this.белыйФонToolStripMenuItem});
            this.цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            this.цветФонаToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.цветФонаToolStripMenuItem.Text = "Цвет фона";
            // 
            // черныйФонToolStripMenuItem
            // 
            this.черныйФонToolStripMenuItem.Name = "черныйФонToolStripMenuItem";
            this.черныйФонToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.черныйФонToolStripMenuItem.Text = "Черный фон";
            this.черныйФонToolStripMenuItem.Click += new System.EventHandler(this.черныйФонToolStripMenuItem_Click);
            // 
            // серыйФонToolStripMenuItem
            // 
            this.серыйФонToolStripMenuItem.Name = "серыйФонToolStripMenuItem";
            this.серыйФонToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.серыйФонToolStripMenuItem.Text = "Серый фон";
            this.серыйФонToolStripMenuItem.Click += new System.EventHandler(this.серыйФонToolStripMenuItem_Click);
            // 
            // белыйФонToolStripMenuItem
            // 
            this.белыйФонToolStripMenuItem.Name = "белыйФонToolStripMenuItem";
            this.белыйФонToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.белыйФонToolStripMenuItem.Text = "Белый фон";
            this.белыйФонToolStripMenuItem.Click += new System.EventHandler(this.белыйФонToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(901, 568);
            this.Controls.Add(this.center);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.Text = "Text editor from Sanek228";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьФайлToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem выделениеТекстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сделатьТекстЖирнымToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьТекстКурсивомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подчеркнутьТекстToolStripMenuItem;
        private System.Windows.Forms.Button center;
        private System.Windows.Forms.ToolStripMenuItem красныйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зеленыйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синийТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стандартныйЦветТекстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стандартныйШрифтToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem цветФонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem черныйФонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem серыйФонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem белыйФонToolStripMenuItem;
    }
}

