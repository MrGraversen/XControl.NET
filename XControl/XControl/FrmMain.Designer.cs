namespace XControl
{
    partial class FrmMain
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblDebug = new System.Windows.Forms.Label();
            this.xloop = new System.Windows.Forms.Timer(this.components);
            this.lblNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(474, 55);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "XControl";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDebug
            // 
            this.lblDebug.Location = new System.Drawing.Point(12, 74);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(474, 164);
            this.lblDebug.TabIndex = 1;
            this.lblDebug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xloop
            // 
            this.xloop.Interval = 10;
            this.xloop.Tick += new System.EventHandler(this.xloop_Tick);
            // 
            // lblNote
            // 
            this.lblNote.BackColor = System.Drawing.SystemColors.Info;
            this.lblNote.Font = new System.Drawing.Font("Calibri Light", 9F);
            this.lblNote.Location = new System.Drawing.Point(12, 238);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(474, 37);
            this.lblNote.TabIndex = 2;
            this.lblNote.Text = "Please note that regular mouse operation doesn\'t work properly while this utility" +
    " runs";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 289);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XControl";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.Timer xloop;
        private System.Windows.Forms.Label lblNote;
    }
}

