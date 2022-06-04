// Sharipov Kamil 220 Figures-4 30.05
namespace Figures.Winforms
{
    partial class DrawForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawForm));
            this.drawingTools = new System.Windows.Forms.ToolStrip();
            this.btnRectangle = new System.Windows.Forms.ToolStripButton();
            this.btnCircle = new System.Windows.Forms.ToolStripButton();
            this.btnTriangle = new System.Windows.Forms.ToolStripButton();
            this.btnLine = new System.Windows.Forms.ToolStripButton();
            this.textBox_ChangeWidth = new System.Windows.Forms.ToolStripTextBox();
            this.btn_ChangeColor = new System.Windows.Forms.ToolStripButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workplace = new System.Windows.Forms.Panel();
            this.statusLine = new System.Windows.Forms.Label();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadDialog = new System.Windows.Forms.OpenFileDialog();
            this.changeColorDialog = new System.Windows.Forms.ColorDialog();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawingTools.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingTools
            // 
            this.drawingTools.AllowItemReorder = true;
            this.drawingTools.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.drawingTools.Dock = System.Windows.Forms.DockStyle.Left;
            this.drawingTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRectangle,
            this.btnCircle,
            this.btnTriangle,
            this.btnLine,
            this.textBox_ChangeWidth,
            this.btn_ChangeColor});
            this.drawingTools.Location = new System.Drawing.Point(0, 24);
            this.drawingTools.Name = "drawingTools";
            this.drawingTools.Size = new System.Drawing.Size(30, 445);
            this.drawingTools.TabIndex = 0;
            this.drawingTools.Text = "toolStrip1";
            // 
            // btnRectangle
            // 
            this.btnRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(29, 19);
            this.btnRectangle.Text = "R";
            this.btnRectangle.ToolTipText = "Rectangle";
            this.btnRectangle.Click += new System.EventHandler(this.DrawingTool_btn_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(29, 19);
            this.btnCircle.Text = "C";
            this.btnCircle.ToolTipText = "Circle";
            this.btnCircle.Click += new System.EventHandler(this.DrawingTool_btn_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTriangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(29, 19);
            this.btnTriangle.Text = "T";
            this.btnTriangle.ToolTipText = "Triangle";
            this.btnTriangle.Click += new System.EventHandler(this.DrawingTool_btn_Click);
            // 
            // btnLine
            // 
            this.btnLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(29, 19);
            this.btnLine.Text = "L";
            this.btnLine.ToolTipText = "Line";
            this.btnLine.Click += new System.EventHandler(this.DrawingTool_btn_Click);
            // 
            // textBox_ChangeWidth
            // 
            this.textBox_ChangeWidth.Name = "textBox_ChangeWidth";
            this.textBox_ChangeWidth.Size = new System.Drawing.Size(27, 23);
            this.textBox_ChangeWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ChangeWidth_KeyPress);
            // 
            // btn_ChangeColor
            // 
            this.btn_ChangeColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ChangeColor.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChangeColor.Image")));
            this.btn_ChangeColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ChangeColor.Name = "btn_ChangeColor";
            this.btn_ChangeColor.Size = new System.Drawing.Size(27, 20);
            this.btn_ChangeColor.Text = "toolStripButton1";
            this.btn_ChangeColor.Click += new System.EventHandler(this.btn_ChangeColor_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(673, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + N";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + S";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + L";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // workplace
            // 
            this.workplace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workplace.Location = new System.Drawing.Point(30, 24);
            this.workplace.Margin = new System.Windows.Forms.Padding(10);
            this.workplace.Name = "workplace";
            this.workplace.Padding = new System.Windows.Forms.Padding(30);
            this.workplace.Size = new System.Drawing.Size(643, 445);
            this.workplace.TabIndex = 2;
            this.workplace.Paint += new System.Windows.Forms.PaintEventHandler(this.workplace_Paint);
            this.workplace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.workplace_MouseDown);
            this.workplace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.workplace_MouseMove);
            this.workplace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.workplace_MouseUp);
            // 
            // statusLine
            // 
            this.statusLine.AutoSize = true;
            this.statusLine.Location = new System.Drawing.Point(86, 8);
            this.statusLine.Name = "statusLine";
            this.statusLine.Size = new System.Drawing.Size(0, 15);
            this.statusLine.TabIndex = 3;
            // 
            // DrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 469);
            this.Controls.Add(this.statusLine);
            this.Controls.Add(this.workplace);
            this.Controls.Add(this.drawingTools);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "DrawForm";
            this.Text = "DrawForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DrawForm_KeyDown);
            this.drawingTools.ResumeLayout(false);
            this.drawingTools.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip drawingTools;
        private System.Windows.Forms.ToolStripButton btnRectangle;
        private System.Windows.Forms.ToolStripButton btnCircle;
        private System.Windows.Forms.ToolStripButton btnTriangle;
        private System.Windows.Forms.ToolStripButton btnLine;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Panel workplace;
        private System.Windows.Forms.Label statusLine;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.OpenFileDialog loadDialog;
        private System.Windows.Forms.ToolStripTextBox textBox_ChangeWidth;
        private System.Windows.Forms.ToolStripButton btn_ChangeColor;
        private System.Windows.Forms.ColorDialog changeColorDialog;
    }
}