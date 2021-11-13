
namespace WindowsFormsApp1
{
    partial class TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаШрифтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаЦветаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветВыделенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыделениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выравниваниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЦентруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЛевомуКраюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поПравомуКраюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставкаИзображенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выделитьВсеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьШрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЦветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветВыделенияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыделениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.шрифтToolStripMenuItem,
            this.выравниваниеToolStripMenuItem,
            this.вставкаИзображенияToolStripMenuItem,
            this.фонToolStripMenuItem,
            this.обАвтореToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.сохранитьКакToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem2.Text = "Открыть";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выделитьВсеToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.найтиToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // выделитьВсеToolStripMenuItem
            // 
            this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            this.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.выделитьВсеToolStripMenuItem.Text = "Выделить все (Ctrl+A)";
            this.выделитьВсеToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать (Ctrl+C)";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить (Ctrl+V)";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать (Ctrl+X)";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.найтиToolStripMenuItem.Text = "Найти";
            this.найтиToolStripMenuItem.Click += new System.EventHandler(this.найтиToolStripMenuItem_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкаШрифтаToolStripMenuItem,
            this.настройкаЦветаToolStripMenuItem,
            this.цветВыделенияToolStripMenuItem,
            this.удалитьВыделениеToolStripMenuItem1});
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.шрифтToolStripMenuItem.Text = "Редактирование";
            // 
            // настройкаШрифтаToolStripMenuItem
            // 
            this.настройкаШрифтаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("настройкаШрифтаToolStripMenuItem.Image")));
            this.настройкаШрифтаToolStripMenuItem.Name = "настройкаШрифтаToolStripMenuItem";
            this.настройкаШрифтаToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.настройкаШрифтаToolStripMenuItem.Text = "Настройка шрифта";
            this.настройкаШрифтаToolStripMenuItem.Click += new System.EventHandler(this.настройкаШрифтаToolStripMenuItem_Click);
            // 
            // настройкаЦветаToolStripMenuItem
            // 
            this.настройкаЦветаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("настройкаЦветаToolStripMenuItem.Image")));
            this.настройкаЦветаToolStripMenuItem.Name = "настройкаЦветаToolStripMenuItem";
            this.настройкаЦветаToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.настройкаЦветаToolStripMenuItem.Text = "Настройка цвета";
            this.настройкаЦветаToolStripMenuItem.Click += new System.EventHandler(this.настройкаЦветаToolStripMenuItem_Click);
            // 
            // цветВыделенияToolStripMenuItem
            // 
            this.цветВыделенияToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("цветВыделенияToolStripMenuItem.Image")));
            this.цветВыделенияToolStripMenuItem.Name = "цветВыделенияToolStripMenuItem";
            this.цветВыделенияToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.цветВыделенияToolStripMenuItem.Text = "Цвет выделения";
            this.цветВыделенияToolStripMenuItem.Click += new System.EventHandler(this.цветВыделенияToolStripMenuItem_Click);
            // 
            // удалитьВыделениеToolStripMenuItem1
            // 
            this.удалитьВыделениеToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("удалитьВыделениеToolStripMenuItem1.Image")));
            this.удалитьВыделениеToolStripMenuItem1.Name = "удалитьВыделениеToolStripMenuItem1";
            this.удалитьВыделениеToolStripMenuItem1.Size = new System.Drawing.Size(185, 26);
            this.удалитьВыделениеToolStripMenuItem1.Text = "Удалить выделение";
            this.удалитьВыделениеToolStripMenuItem1.Click += new System.EventHandler(this.удалитьВыделениеToolStripMenuItem1_Click);
            // 
            // выравниваниеToolStripMenuItem
            // 
            this.выравниваниеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поЦентруToolStripMenuItem,
            this.поЛевомуКраюToolStripMenuItem,
            this.поПравомуКраюToolStripMenuItem});
            this.выравниваниеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выравниваниеToolStripMenuItem.Image")));
            this.выравниваниеToolStripMenuItem.Name = "выравниваниеToolStripMenuItem";
            this.выравниваниеToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.выравниваниеToolStripMenuItem.Text = "Выравнивание";
            // 
            // поЦентруToolStripMenuItem
            // 
            this.поЦентруToolStripMenuItem.Name = "поЦентруToolStripMenuItem";
            this.поЦентруToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поЦентруToolStripMenuItem.Text = "По центру";
            this.поЦентруToolStripMenuItem.Click += new System.EventHandler(this.поЦентруToolStripMenuItem_Click);
            // 
            // поЛевомуКраюToolStripMenuItem
            // 
            this.поЛевомуКраюToolStripMenuItem.Name = "поЛевомуКраюToolStripMenuItem";
            this.поЛевомуКраюToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поЛевомуКраюToolStripMenuItem.Text = "По левому краю";
            this.поЛевомуКраюToolStripMenuItem.Click += new System.EventHandler(this.поЛевомуКраюToolStripMenuItem_Click);
            // 
            // поПравомуКраюToolStripMenuItem
            // 
            this.поПравомуКраюToolStripMenuItem.Name = "поПравомуКраюToolStripMenuItem";
            this.поПравомуКраюToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поПравомуКраюToolStripMenuItem.Text = "По правому краю";
            this.поПравомуКраюToolStripMenuItem.Click += new System.EventHandler(this.поПравомуКраюToolStripMenuItem_Click);
            // 
            // вставкаИзображенияToolStripMenuItem
            // 
            this.вставкаИзображенияToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вставкаИзображенияToolStripMenuItem.Image")));
            this.вставкаИзображенияToolStripMenuItem.Name = "вставкаИзображенияToolStripMenuItem";
            this.вставкаИзображенияToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.вставкаИзображенияToolStripMenuItem.Text = "Вставка изображения";
            this.вставкаИзображенияToolStripMenuItem.Click += new System.EventHandler(this.вставкаИзображенияToolStripMenuItem_Click);
            // 
            // фонToolStripMenuItem
            // 
            this.фонToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиФонаToolStripMenuItem});
            this.фонToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("фонToolStripMenuItem.Image")));
            this.фонToolStripMenuItem.Name = "фонToolStripMenuItem";
            this.фонToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.фонToolStripMenuItem.Text = "Фон";
            // 
            // настройкиФонаToolStripMenuItem
            // 
            this.настройкиФонаToolStripMenuItem.Name = "настройкиФонаToolStripMenuItem";
            this.настройкиФонаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.настройкиФонаToolStripMenuItem.Text = "Изменение цвета";
            this.настройкиФонаToolStripMenuItem.Click += new System.EventHandler(this.настройкиФонаToolStripMenuItem_Click);
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.обАвтореToolStripMenuItem.Text = "Об Авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Location = new System.Drawing.Point(0, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 422);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выделитьВсеToolStripMenuItem1,
            this.копироватьToolStripMenuItem1,
            this.вставитьToolStripMenuItem1,
            this.вырезатьToolStripMenuItem1,
            this.найтиToolStripMenuItem1,
            this.изменитьШрифтToolStripMenuItem,
            this.изменитьЦветToolStripMenuItem,
            this.цветВыделенияToolStripMenuItem1,
            this.удалитьВыделениеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 238);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // выделитьВсеToolStripMenuItem1
            // 
            this.выделитьВсеToolStripMenuItem1.Name = "выделитьВсеToolStripMenuItem1";
            this.выделитьВсеToolStripMenuItem1.Size = new System.Drawing.Size(198, 26);
            this.выделитьВсеToolStripMenuItem1.Text = "Выделить все (Ctrl+A)";
            this.выделитьВсеToolStripMenuItem1.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem1_Click);
            // 
            // копироватьToolStripMenuItem1
            // 
            this.копироватьToolStripMenuItem1.Name = "копироватьToolStripMenuItem1";
            this.копироватьToolStripMenuItem1.Size = new System.Drawing.Size(198, 26);
            this.копироватьToolStripMenuItem1.Text = "Копировать (Ctrl+C)";
            this.копироватьToolStripMenuItem1.Click += new System.EventHandler(this.копироватьToolStripMenuItem1_Click);
            // 
            // вставитьToolStripMenuItem1
            // 
            this.вставитьToolStripMenuItem1.Name = "вставитьToolStripMenuItem1";
            this.вставитьToolStripMenuItem1.Size = new System.Drawing.Size(198, 26);
            this.вставитьToolStripMenuItem1.Text = "Вставить (Ctrl+V)";
            this.вставитьToolStripMenuItem1.Click += new System.EventHandler(this.вставитьToolStripMenuItem1_Click);
            // 
            // вырезатьToolStripMenuItem1
            // 
            this.вырезатьToolStripMenuItem1.Name = "вырезатьToolStripMenuItem1";
            this.вырезатьToolStripMenuItem1.Size = new System.Drawing.Size(198, 26);
            this.вырезатьToolStripMenuItem1.Text = "Вырезать (Ctrl+X)";
            this.вырезатьToolStripMenuItem1.Click += new System.EventHandler(this.вырезатьToolStripMenuItem1_Click);
            // 
            // найтиToolStripMenuItem1
            // 
            this.найтиToolStripMenuItem1.Name = "найтиToolStripMenuItem1";
            this.найтиToolStripMenuItem1.Size = new System.Drawing.Size(198, 26);
            this.найтиToolStripMenuItem1.Text = "Найти";
            this.найтиToolStripMenuItem1.Click += new System.EventHandler(this.найтиToolStripMenuItem1_Click);
            // 
            // изменитьШрифтToolStripMenuItem
            // 
            this.изменитьШрифтToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("изменитьШрифтToolStripMenuItem.Image")));
            this.изменитьШрифтToolStripMenuItem.Name = "изменитьШрифтToolStripMenuItem";
            this.изменитьШрифтToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.изменитьШрифтToolStripMenuItem.Text = "Изменить шрифт";
            this.изменитьШрифтToolStripMenuItem.Click += new System.EventHandler(this.изменитьШрифтToolStripMenuItem_Click);
            // 
            // изменитьЦветToolStripMenuItem
            // 
            this.изменитьЦветToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("изменитьЦветToolStripMenuItem.Image")));
            this.изменитьЦветToolStripMenuItem.Name = "изменитьЦветToolStripMenuItem";
            this.изменитьЦветToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.изменитьЦветToolStripMenuItem.Text = "Изменить цвет";
            this.изменитьЦветToolStripMenuItem.Click += new System.EventHandler(this.изменитьЦветToolStripMenuItem_Click);
            // 
            // цветВыделенияToolStripMenuItem1
            // 
            this.цветВыделенияToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("цветВыделенияToolStripMenuItem1.Image")));
            this.цветВыделенияToolStripMenuItem1.Name = "цветВыделенияToolStripMenuItem1";
            this.цветВыделенияToolStripMenuItem1.Size = new System.Drawing.Size(198, 26);
            this.цветВыделенияToolStripMenuItem1.Text = "Цвет выделения";
            this.цветВыделенияToolStripMenuItem1.Click += new System.EventHandler(this.цветВыделенияToolStripMenuItem1_Click);
            // 
            // удалитьВыделениеToolStripMenuItem
            // 
            this.удалитьВыделениеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("удалитьВыделениеToolStripMenuItem.Image")));
            this.удалитьВыделениеToolStripMenuItem.Name = "удалитьВыделениеToolStripMenuItem";
            this.удалитьВыделениеToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.удалитьВыделениеToolStripMenuItem.Text = "Удалить выделение";
            this.удалитьВыделениеToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыделениеToolStripMenuItem_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextEditor";
            this.Text = "Текстовый редактор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаШрифтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиФонаToolStripMenuItem;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изменитьШрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЦветToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ToolStripMenuItem настройкаЦветаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выравниваниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЦентруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЛевомуКраюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поПравомуКраюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветВыделенияToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.ToolStripMenuItem цветВыделенияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вставкаИзображенияToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыделениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыделениеToolStripMenuItem1;
    }
}

