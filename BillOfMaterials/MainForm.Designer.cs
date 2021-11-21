
namespace BillOfMaterials
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.номенклатураНаМатериалиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списъкСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номенклатураНаИзделияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.създаванеНаСпецификацияНаИзделиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.номенклатураНаМатериалиToolStripMenuItem,
            this.списъкСToolStripMenuItem,
            this.номенклатураНаИзделияToolStripMenuItem,
            this.създаванеНаСпецификацияНаИзделиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // номенклатураНаМатериалиToolStripMenuItem
            // 
            this.номенклатураНаМатериалиToolStripMenuItem.Name = "номенклатураНаМатериалиToolStripMenuItem";
            this.номенклатураНаМатериалиToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.номенклатураНаМатериалиToolStripMenuItem.Text = "Nomenclature";
            // 
            // списъкСToolStripMenuItem
            // 
            this.списъкСToolStripMenuItem.Name = "списъкСToolStripMenuItem";
            this.списъкСToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.списъкСToolStripMenuItem.Text = "Списък разходи";
            // 
            // номенклатураНаИзделияToolStripMenuItem
            // 
            this.номенклатураНаИзделияToolStripMenuItem.Name = "номенклатураНаИзделияToolStripMenuItem";
            this.номенклатураНаИзделияToolStripMenuItem.Size = new System.Drawing.Size(161, 20);
            this.номенклатураНаИзделияToolStripMenuItem.Text = "номенклатура на изделия";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // създаванеНаСпецификацияНаИзделиеToolStripMenuItem
            // 
            this.създаванеНаСпецификацияНаИзделиеToolStripMenuItem.Name = "създаванеНаСпецификацияНаИзделиеToolStripMenuItem";
            this.създаванеНаСпецификацияНаИзделиеToolStripMenuItem.Size = new System.Drawing.Size(239, 20);
            this.създаванеНаСпецификацияНаИзделиеToolStripMenuItem.Text = "Създаване на спецификация на изделие";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem номенклатураНаМатериалиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списъкСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem номенклатураНаИзделияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem създаванеНаСпецификацияНаИзделиеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

