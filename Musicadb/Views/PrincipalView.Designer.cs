namespace Musicadb
{
    partial class PrincipalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            contextMenuStrip3 = new ContextMenuStrip(components);
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            contextMenuStrip4 = new ContextMenuStrip(components);
            toolStrip1 = new ToolStrip();
            salidaBoton = new FontAwesome.Sharp.IconToolStripButton();
            acercaDeBoton = new FontAwesome.Sharp.IconToolStripButton();
            contextMenuStrip3.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { iconMenuItem1 });
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(159, 26);
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(158, 22);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // contextMenuStrip4
            // 
            contextMenuStrip4.Name = "contextMenuStrip4";
            contextMenuStrip4.Size = new Size(61, 4);
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { salidaBoton, acercaDeBoton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // salidaBoton
            // 
            salidaBoton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            salidaBoton.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            salidaBoton.IconColor = Color.Black;
            salidaBoton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            salidaBoton.ImageTransparentColor = Color.Magenta;
            salidaBoton.Name = "salidaBoton";
            salidaBoton.Size = new Size(23, 22);
            salidaBoton.Text = "iconToolStripButton1";
            salidaBoton.Click += salidaBoton_Click;
            // 
            // acercaDeBoton
            // 
            acercaDeBoton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            acercaDeBoton.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            acercaDeBoton.IconColor = Color.Black;
            acercaDeBoton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            acercaDeBoton.ImageTransparentColor = Color.Magenta;
            acercaDeBoton.Name = "acercaDeBoton";
            acercaDeBoton.Size = new Size(23, 22);
            acercaDeBoton.Text = "iconToolStripButton1";
            acercaDeBoton.Click += this.acercaDeBoton_Click;
            // 
            // principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Name = "principal";
            Text = "Form1";
            contextMenuStrip3.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ContextMenuStrip contextMenuStrip3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private ContextMenuStrip contextMenuStrip4;
        private ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconToolStripButton salidaBoton;
        private FontAwesome.Sharp.IconToolStripButton acercaDeBoton;
    }
}
