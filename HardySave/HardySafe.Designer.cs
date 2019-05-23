using System.Windows.Forms;

namespace HardySave
{
    partial class HardySafe
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.localbox = new System.Windows.Forms.CheckedListBox();
            this.roamingbox = new System.Windows.Forms.CheckedListBox();
            this.locallowbox = new System.Windows.Forms.CheckedListBox();
            this.localtxt = new System.Windows.Forms.Label();
            this.locallowtxt = new System.Windows.Forms.Label();
            this.roamingtxt = new System.Windows.Forms.Label();
            this.SaveTest = new System.Windows.Forms.Button();
            this.speicherORT = new System.Windows.Forms.Button();
            this.speicherORT_URL = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.internetbox = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Internet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // localbox
            // 
            this.localbox.CheckOnClick = true;
            this.localbox.HorizontalScrollbar = true;
            this.localbox.Location = new System.Drawing.Point(12, 47);
            this.localbox.Name = "localbox";
            this.localbox.Size = new System.Drawing.Size(250, 169);
            this.localbox.TabIndex = 0;
            this.localbox.SelectedIndexChanged += new System.EventHandler(this.test1_SelectedIndexChanged);
            this.localbox.MouseEnter += new System.EventHandler(this.localbox_MouseEnter);
            // 
            // roamingbox
            // 
            this.roamingbox.CheckOnClick = true;
            this.roamingbox.HorizontalScrollbar = true;
            this.roamingbox.Location = new System.Drawing.Point(12, 508);
            this.roamingbox.Name = "roamingbox";
            this.roamingbox.Size = new System.Drawing.Size(250, 169);
            this.roamingbox.TabIndex = 1;
            this.roamingbox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            this.roamingbox.MouseEnter += new System.EventHandler(this.roamingbox_MouseEnter);
            // 
            // locallowbox
            // 
            this.locallowbox.CheckOnClick = true;
            this.locallowbox.HorizontalScrollbar = true;
            this.locallowbox.Location = new System.Drawing.Point(12, 276);
            this.locallowbox.Name = "locallowbox";
            this.locallowbox.Size = new System.Drawing.Size(250, 169);
            this.locallowbox.TabIndex = 2;
            this.locallowbox.SelectedIndexChanged += new System.EventHandler(this.locallowbox_SelectedIndexChanged);
            this.locallowbox.MouseEnter += new System.EventHandler(this.locallowbox_MouseEnter);
            // 
            // localtxt
            // 
            this.localtxt.AutoSize = true;
            this.localtxt.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localtxt.Location = new System.Drawing.Point(12, 9);
            this.localtxt.Name = "localtxt";
            this.localtxt.Size = new System.Drawing.Size(59, 25);
            this.localtxt.TabIndex = 3;
            this.localtxt.Text = "Local";
            this.localtxt.Click += new System.EventHandler(this.local_Click);
            // 
            // locallowtxt
            // 
            this.locallowtxt.AutoSize = true;
            this.locallowtxt.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.locallowtxt.Location = new System.Drawing.Point(12, 233);
            this.locallowtxt.Name = "locallowtxt";
            this.locallowtxt.Size = new System.Drawing.Size(94, 25);
            this.locallowtxt.TabIndex = 4;
            this.locallowtxt.Text = "LocalLow";
            this.locallowtxt.Click += new System.EventHandler(this.locallowtxt_Click);
            // 
            // roamingtxt
            // 
            this.roamingtxt.AutoSize = true;
            this.roamingtxt.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.roamingtxt.Location = new System.Drawing.Point(12, 463);
            this.roamingtxt.Name = "roamingtxt";
            this.roamingtxt.Size = new System.Drawing.Size(87, 25);
            this.roamingtxt.TabIndex = 5;
            this.roamingtxt.Text = "Roaming";
            this.roamingtxt.Click += new System.EventHandler(this.roamingtxt_Click);
            // 
            // SaveTest
            // 
            this.SaveTest.Enabled = false;
            this.SaveTest.Location = new System.Drawing.Point(501, 47);
            this.SaveTest.Name = "SaveTest";
            this.SaveTest.Size = new System.Drawing.Size(140, 55);
            this.SaveTest.TabIndex = 6;
            this.SaveTest.Text = "SaveTest";
            this.SaveTest.UseVisualStyleBackColor = true;
            this.SaveTest.Click += new System.EventHandler(this.SaveTest_Click);
            this.SaveTest.MouseEnter += new System.EventHandler(this.SaveTest_MouseEnter);
            this.SaveTest.MouseLeave += new System.EventHandler(this.SaveTest_MouseLeave);
            this.SaveTest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SaveTest_MouseMove);
            // 
            // speicherORT
            // 
            this.speicherORT.Location = new System.Drawing.Point(501, 136);
            this.speicherORT.Name = "speicherORT";
            this.speicherORT.Size = new System.Drawing.Size(140, 50);
            this.speicherORT.TabIndex = 7;
            this.speicherORT.Text = "Speicher Ort Wählen";
            this.speicherORT.UseVisualStyleBackColor = true;
            this.speicherORT.Click += new System.EventHandler(this.speicherORT_Click);
            // 
            // speicherORT_URL
            // 
            this.speicherORT_URL.Location = new System.Drawing.Point(292, 196);
            this.speicherORT_URL.Name = "speicherORT_URL";
            this.speicherORT_URL.ReadOnly = true;
            this.speicherORT_URL.Size = new System.Drawing.Size(349, 20);
            this.speicherORT_URL.TabIndex = 9;
            this.speicherORT_URL.TextChanged += new System.EventHandler(this.speicherORT_URI_TextChanged);
            // 
            // internetbox
            // 
            this.internetbox.FormattingEnabled = true;
            this.internetbox.Items.AddRange(new object[] {
            "Chrome",
            "FireFox"});
            this.internetbox.Location = new System.Drawing.Point(292, 47);
            this.internetbox.Name = "internetbox";
            this.internetbox.Size = new System.Drawing.Size(203, 139);
            this.internetbox.TabIndex = 10;
            this.internetbox.SelectedIndexChanged += new System.EventHandler(this.internetbox_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Internet
            // 
            this.Internet.AutoSize = true;
            this.Internet.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.Internet.Location = new System.Drawing.Point(292, 9);
            this.Internet.Name = "Internet";
            this.Internet.Size = new System.Drawing.Size(78, 25);
            this.Internet.TabIndex = 12;
            this.Internet.Text = "Internet";
            this.Internet.Click += new System.EventHandler(this.internet_Click);
            // 
            // HardySafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 695);
            this.Controls.Add(this.Internet);
            this.Controls.Add(this.internetbox);
            this.Controls.Add(this.speicherORT_URL);
            this.Controls.Add(this.speicherORT);
            this.Controls.Add(this.SaveTest);
            this.Controls.Add(this.roamingtxt);
            this.Controls.Add(this.locallowtxt);
            this.Controls.Add(this.localtxt);
            this.Controls.Add(this.locallowbox);
            this.Controls.Add(this.roamingbox);
            this.Controls.Add(this.localbox);
            this.Name = "HardySafe";
            this.Text = "HardySAFE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox roamingbox;
        private System.Windows.Forms.CheckedListBox locallowbox;
        private System.Windows.Forms.Label localtxt;
        private System.Windows.Forms.Label locallowtxt;
        private System.Windows.Forms.Label roamingtxt;
        private Button SaveTest;
        private Button speicherORT;
        private TextBox speicherORT_URL;
        private CheckedListBox localbox;
        private FolderBrowserDialog folderBrowserDialog1;
        private CheckedListBox internetbox;
        private ContextMenuStrip contextMenuStrip1;
        private Label Internet;
    }
}

