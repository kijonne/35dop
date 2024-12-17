namespace _35pr
{
    partial class OurForm
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
            buttonOpenForm = new Button();
            buttonOpenDialog = new Button();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            OpenOurFormTwoToolStripMenuItem = new ToolStripMenuItem();
            OpenOurFormThreeToolStripMenuItem = new ToolStripMenuItem();
            buttonCloseALl = new Button();
            buttonOpenMDI = new Button();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpenForm
            // 
            buttonOpenForm.Location = new Point(322, 198);
            buttonOpenForm.Name = "buttonOpenForm";
            buttonOpenForm.Size = new Size(156, 54);
            buttonOpenForm.TabIndex = 1;
            buttonOpenForm.Text = "Открыть форму";
            buttonOpenForm.UseVisualStyleBackColor = true;
            buttonOpenForm.Click += buttonOpenForm_Click;
            // 
            // buttonOpenDialog
            // 
            buttonOpenDialog.Location = new Point(322, 288);
            buttonOpenDialog.Name = "buttonOpenDialog";
            buttonOpenDialog.Size = new Size(169, 88);
            buttonOpenDialog.TabIndex = 2;
            buttonOpenDialog.Text = "Открыть форму в диалоговом режиме";
            buttonOpenDialog.UseVisualStyleBackColor = true;
            buttonOpenDialog.Click += buttonOpenDialog_Click;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 4;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenOurFormTwoToolStripMenuItem, OpenOurFormThreeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // OpenOurFormTwoToolStripMenuItem
            // 
            OpenOurFormTwoToolStripMenuItem.Name = "OpenOurFormTwoToolStripMenuItem";
            OpenOurFormTwoToolStripMenuItem.Size = new Size(201, 22);
            OpenOurFormTwoToolStripMenuItem.Text = "Открыть OurFormTwo";
            OpenOurFormTwoToolStripMenuItem.Click += OpenOurFormTwoToolStripMenuItem_Click;
            // 
            // OpenOurFormThreeToolStripMenuItem
            // 
            OpenOurFormThreeToolStripMenuItem.Name = "OpenOurFormThreeToolStripMenuItem";
            OpenOurFormThreeToolStripMenuItem.Size = new Size(201, 22);
            OpenOurFormThreeToolStripMenuItem.Text = "Открыть OurFormThree";
            OpenOurFormThreeToolStripMenuItem.Click += OpenOurFormThreeToolStripMenuItem_Click;
            // 
            // buttonCloseALl
            // 
            buttonCloseALl.Location = new Point(629, 299);
            buttonCloseALl.Name = "buttonCloseALl";
            buttonCloseALl.Size = new Size(126, 84);
            buttonCloseALl.TabIndex = 6;
            buttonCloseALl.Text = "Закрыть все формы";
            buttonCloseALl.UseVisualStyleBackColor = true;
            buttonCloseALl.Click += buttonCloseALl_Click;
            // 
            // buttonOpenMDI
            // 
            buttonOpenMDI.Location = new Point(515, 111);
            buttonOpenMDI.Name = "buttonOpenMDI";
            buttonOpenMDI.Size = new Size(177, 107);
            buttonOpenMDI.TabIndex = 8;
            buttonOpenMDI.Text = "Открыть mdi-форму";
            buttonOpenMDI.UseVisualStyleBackColor = true;
            buttonOpenMDI.Click += buttonOpenMDI_Click;
            // 
            // OurForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOpenMDI);
            Controls.Add(buttonCloseALl);
            Controls.Add(buttonOpenDialog);
            Controls.Add(buttonOpenForm);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "OurForm";
            Text = "OurForm";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOpenForm;
        private Button buttonOpenDialog;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem OpenOurFormTwoToolStripMenuItem;
        private ToolStripMenuItem OpenOurFormThreeToolStripMenuItem;
        private Button buttonCloseALl;
        private Button buttonOpenMDI;
    }
}