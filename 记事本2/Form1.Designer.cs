namespace 记事本2
{
    partial class frmnotepad
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmnotepad));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStatusStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsNotepad = new System.Windows.Forms.ToolStrip();
            this.新建NToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.打开OToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.保存SToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.打印PToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.剪切UToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.复制CToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.粘贴PToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.帮助LToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rtxtNotepad = new System.Windows.Forms.RichTextBox();
            this.stsNotepad = new System.Windows.Forms.StatusStrip();
            this.tssLbl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLbl2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.odlgNotepad = new System.Windows.Forms.OpenFileDialog();
            this.sdlgNotepad = new System.Windows.Forms.SaveFileDialog();
            this.fdlgNotepad = new System.Windows.Forms.FontDialog();
            this.tmrNotepad = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tlsNotepad.SuspendLayout();
            this.stsNotepad.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiFormat,
            this.tsmiView,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiSaveAs,
            this.toolStripMenuItem2,
            this.tsmiClose});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(74, 21);
            this.tsmiFile.Text = "文件（&F）";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiNew.Size = new System.Drawing.Size(181, 22);
            this.tsmiNew.Text = "新建（&N）";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpen.Size = new System.Drawing.Size(181, 22);
            this.tsmiOpen.Text = "打开（&O）";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(181, 22);
            this.tsmiSave.Text = "保存（&S）";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.Size = new System.Drawing.Size(181, 22);
            this.tsmiSaveAs.Text = "另存为（&A）";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem2.Text = "-------------------";
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(181, 22);
            this.tsmiClose.Text = "退出（&X）";
            this.tsmiClose.Click += new System.EventHandler(this.tsmiClose_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUndo,
            this.toolStripMenuItem3,
            this.tsmiCopy,
            this.tsmiCut,
            this.tsmiPaste,
            this.toolStripMenuItem4,
            this.tsmiSelectAll,
            this.tsmiDate});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(75, 21);
            this.tsmiEdit.Text = "编辑（&E）";
            // 
            // tsmiUndo
            // 
            this.tsmiUndo.Name = "tsmiUndo";
            this.tsmiUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmiUndo.Size = new System.Drawing.Size(196, 22);
            this.tsmiUndo.Text = "撤销（&U）";
            this.tsmiUndo.Click += new System.EventHandler(this.tsmiUndo_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuItem3.Text = "------------------------";
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiCopy.Size = new System.Drawing.Size(196, 22);
            this.tsmiCopy.Text = "复制（&C）";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiCut.Size = new System.Drawing.Size(196, 22);
            this.tsmiCut.Text = "剪切（&T）";
            this.tsmiCut.Click += new System.EventHandler(this.tsmiCut_Click);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiPaste.Size = new System.Drawing.Size(196, 22);
            this.tsmiPaste.Text = "粘贴（&P）";
            this.tsmiPaste.Click += new System.EventHandler(this.tsmiPaste_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuItem4.Text = "------------------------";
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmiSelectAll.Size = new System.Drawing.Size(196, 22);
            this.tsmiSelectAll.Text = "全选（&A）";
            this.tsmiSelectAll.Click += new System.EventHandler(this.tsmiSelectAll_Click);
            // 
            // tsmiDate
            // 
            this.tsmiDate.Name = "tsmiDate";
            this.tsmiDate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmiDate.Size = new System.Drawing.Size(196, 22);
            this.tsmiDate.Text = "日期（&D）";
            this.tsmiDate.Click += new System.EventHandler(this.tsmiDate_Click);
            // 
            // tsmiFormat
            // 
            this.tsmiFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAuto,
            this.tsmiFont});
            this.tsmiFormat.Name = "tsmiFormat";
            this.tsmiFormat.Size = new System.Drawing.Size(78, 21);
            this.tsmiFormat.Text = "格式（&O）";
            // 
            // tsmiAuto
            // 
            this.tsmiAuto.Checked = true;
            this.tsmiAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiAuto.Name = "tsmiAuto";
            this.tsmiAuto.Size = new System.Drawing.Size(160, 22);
            this.tsmiAuto.Text = "自动换行（&W）";
            this.tsmiAuto.Click += new System.EventHandler(this.tsmiAuto_Click);
            // 
            // tsmiFont
            // 
            this.tsmiFont.Name = "tsmiFont";
            this.tsmiFont.Size = new System.Drawing.Size(160, 22);
            this.tsmiFont.Text = "字体（&F）";
            this.tsmiFont.Click += new System.EventHandler(this.tsmiFont_Click);
            // 
            // tsmiView
            // 
            this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiToolStrip,
            this.tsmiStatusStrip});
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(76, 21);
            this.tsmiView.Text = "查看（V）";
            // 
            // tsmiToolStrip
            // 
            this.tsmiToolStrip.Checked = true;
            this.tsmiToolStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiToolStrip.Name = "tsmiToolStrip";
            this.tsmiToolStrip.Size = new System.Drawing.Size(143, 22);
            this.tsmiToolStrip.Text = "工具栏（&T）";
            this.tsmiToolStrip.Click += new System.EventHandler(this.tsmiToolStrip_Click);
            // 
            // tsmiStatusStrip
            // 
            this.tsmiStatusStrip.Checked = true;
            this.tsmiStatusStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiStatusStrip.Name = "tsmiStatusStrip";
            this.tsmiStatusStrip.Size = new System.Drawing.Size(143, 22);
            this.tsmiStatusStrip.Text = "状态栏（&S）";
            this.tsmiStatusStrip.Click += new System.EventHandler(this.tsmiStatusStrip_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(77, 21);
            this.tsmiHelp.Text = "帮助（&H）";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(168, 22);
            this.tsmiAbout.Text = "关于记事本（&A）";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tlsNotepad
            // 
            this.tlsNotepad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripButton,
            this.打开OToolStripButton,
            this.保存SToolStripButton,
            this.打印PToolStripButton,
            this.toolStripSeparator,
            this.剪切UToolStripButton,
            this.复制CToolStripButton,
            this.粘贴PToolStripButton,
            this.toolStripSeparator1,
            this.帮助LToolStripButton});
            this.tlsNotepad.Location = new System.Drawing.Point(0, 25);
            this.tlsNotepad.Name = "tlsNotepad";
            this.tlsNotepad.Size = new System.Drawing.Size(584, 25);
            this.tlsNotepad.TabIndex = 1;
            this.tlsNotepad.Text = "toolStrip1";
            this.tlsNotepad.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tlsNotepad_ItemClicked);
            // 
            // 新建NToolStripButton
            // 
            this.新建NToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.新建NToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("新建NToolStripButton.Image")));
            this.新建NToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新建NToolStripButton.Name = "新建NToolStripButton";
            this.新建NToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.新建NToolStripButton.Text = "新建(&N)";
            // 
            // 打开OToolStripButton
            // 
            this.打开OToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.打开OToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("打开OToolStripButton.Image")));
            this.打开OToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打开OToolStripButton.Name = "打开OToolStripButton";
            this.打开OToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.打开OToolStripButton.Text = "打开(&O)";
            // 
            // 保存SToolStripButton
            // 
            this.保存SToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.保存SToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("保存SToolStripButton.Image")));
            this.保存SToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.保存SToolStripButton.Name = "保存SToolStripButton";
            this.保存SToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.保存SToolStripButton.Text = "保存(&S)";
            // 
            // 打印PToolStripButton
            // 
            this.打印PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.打印PToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("打印PToolStripButton.Image")));
            this.打印PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打印PToolStripButton.Name = "打印PToolStripButton";
            this.打印PToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.打印PToolStripButton.Text = "打印(&P)";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // 剪切UToolStripButton
            // 
            this.剪切UToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.剪切UToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("剪切UToolStripButton.Image")));
            this.剪切UToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪切UToolStripButton.Name = "剪切UToolStripButton";
            this.剪切UToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.剪切UToolStripButton.Text = "剪切(&U)";
            // 
            // 复制CToolStripButton
            // 
            this.复制CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.复制CToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("复制CToolStripButton.Image")));
            this.复制CToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.复制CToolStripButton.Name = "复制CToolStripButton";
            this.复制CToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.复制CToolStripButton.Text = "复制(&C)";
            // 
            // 粘贴PToolStripButton
            // 
            this.粘贴PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.粘贴PToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("粘贴PToolStripButton.Image")));
            this.粘贴PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.粘贴PToolStripButton.Name = "粘贴PToolStripButton";
            this.粘贴PToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.粘贴PToolStripButton.Text = "粘贴(&P)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // 帮助LToolStripButton
            // 
            this.帮助LToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.帮助LToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("帮助LToolStripButton.Image")));
            this.帮助LToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.帮助LToolStripButton.Name = "帮助LToolStripButton";
            this.帮助LToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.帮助LToolStripButton.Text = "帮助(&L)";
            // 
            // rtxtNotepad
            // 
            this.rtxtNotepad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtNotepad.Location = new System.Drawing.Point(0, 53);
            this.rtxtNotepad.Name = "rtxtNotepad";
            this.rtxtNotepad.Size = new System.Drawing.Size(584, 302);
            this.rtxtNotepad.TabIndex = 2;
            this.rtxtNotepad.Text = "";
            this.rtxtNotepad.TextChanged += new System.EventHandler(this.rtxtNotepad_TextChanged);
            // 
            // stsNotepad
            // 
            this.stsNotepad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stsNotepad.Dock = System.Windows.Forms.DockStyle.None;
            this.stsNotepad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLbl1,
            this.tssLbl2});
            this.stsNotepad.Location = new System.Drawing.Point(82, 380);
            this.stsNotepad.Name = "stsNotepad";
            this.stsNotepad.Size = new System.Drawing.Size(171, 22);
            this.stsNotepad.TabIndex = 3;
            this.stsNotepad.Text = "statusStrip1";
            // 
            // tssLbl1
            // 
            this.tssLbl1.Name = "tssLbl1";
            this.tssLbl1.Size = new System.Drawing.Size(32, 17);
            this.tssLbl1.Text = "就绪";
            // 
            // tssLbl2
            // 
            this.tssLbl2.Name = "tssLbl2";
            this.tssLbl2.Size = new System.Drawing.Size(92, 17);
            this.tssLbl2.Text = "显示日期、时间";
            // 
            // odlgNotepad
            // 
            this.odlgNotepad.FileName = "openFileDialog1";
            this.odlgNotepad.Filter = "RTF 文件|*.rtf|所有文件|*.*";
            // 
            // sdlgNotepad
            // 
            this.sdlgNotepad.FileName = "无标题";
            this.sdlgNotepad.Filter = "RTF 文件|*.rtf";
            // 
            // tmrNotepad
            // 
            this.tmrNotepad.Enabled = true;
            this.tmrNotepad.Interval = 1000;
            this.tmrNotepad.Tick += new System.EventHandler(this.tmrNotepad_Tick);
            // 
            // frmnotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.stsNotepad);
            this.Controls.Add(this.rtxtNotepad);
            this.Controls.Add(this.tlsNotepad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmnotepad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "记事本";
            this.Load += new System.EventHandler(this.frmnotepad_Load);
            this.SizeChanged += new System.EventHandler(this.frmnotepad_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tlsNotepad.ResumeLayout(false);
            this.tlsNotepad.PerformLayout();
            this.stsNotepad.ResumeLayout(false);
            this.stsNotepad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiFile;
        private ToolStripMenuItem tsmiNew;
        private ToolStripMenuItem tsmiOpen;
        private ToolStripMenuItem tsmiSave;
        private ToolStripMenuItem tsmiSaveAs;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem tsmiClose;
        private ToolStripMenuItem tsmiEdit;
        private ToolStripMenuItem tsmiUndo;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem tsmiCopy;
        private ToolStripMenuItem tsmiCut;
        private ToolStripMenuItem tsmiPaste;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem tsmiSelectAll;
        private ToolStripMenuItem tsmiDate;
        private ToolStripMenuItem tsmiFormat;
        private ToolStripMenuItem tsmiAuto;
        private ToolStripMenuItem tsmiFont;
        private ToolStripMenuItem tsmiView;
        private ToolStripMenuItem tsmiToolStrip;
        private ToolStripMenuItem tsmiStatusStrip;
        private ToolStripMenuItem tsmiHelp;
        private ToolStripMenuItem tsmiAbout;
        private ToolStrip tlsNotepad;
        private ToolStripButton 新建NToolStripButton;
        private ToolStripButton 打开OToolStripButton;
        private ToolStripButton 保存SToolStripButton;
        private ToolStripButton 打印PToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton 剪切UToolStripButton;
        private ToolStripButton 复制CToolStripButton;
        private ToolStripButton 粘贴PToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton 帮助LToolStripButton;
        private RichTextBox rtxtNotepad;
        private StatusStrip stsNotepad;
        private ToolStripStatusLabel tssLbl1;
        private ToolStripStatusLabel tssLbl2;
        private OpenFileDialog odlgNotepad;
        private SaveFileDialog sdlgNotepad;
        private FontDialog fdlgNotepad;
        private System.Windows.Forms.Timer tmrNotepad;
    }
}