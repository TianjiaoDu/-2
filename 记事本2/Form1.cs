namespace 记事本2
{
    public partial class frmnotepad : Form
    {
        bool b=false;
        bool s = true;
        public frmnotepad()
        {
            InitializeComponent();
        }

        private void frmnotepad_Load(object sender, EventArgs e)
        {

        }

        private void rtxtNotepad_TextChanged(object sender, EventArgs e)
        {
            s=false;
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            if(b==true||rtxtNotepad.Text.Trim()!="")
            {
                if(s==false)
                {
                    string result;
                    result=MessageBox.Show("文件尚未保存，是否保存？",
                        "保存文件",MessageBoxButtons.YesNoCancel).ToString();
                    switch(result)
                    {
                        case "Yes":
                            if(b==true)
                            {
                                rtxtNotepad.SaveFile(odlgNotepad.FileName);
                            }
                            else if(sdlgNotepad.ShowDialog() == DialogResult.OK)
                            {
                                rtxtNotepad.SaveFile(sdlgNotepad.FileName);
                            }
                            s = true;
                            rtxtNotepad.Text = "";
                            break;
                        case "No":
                            b = false;
                            rtxtNotepad.Text = "";
                            break;
                    }
                }
            }
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            if(b==true||rtxtNotepad.Text.Trim()!="")
            {
                if(s==false)
                {
                    string result;
                    result=MessageBox.Show("文件尚未保存，是否保存？",
                        "保存文件",MessageBoxButtons.YesNoCancel).ToString();
                    switch(result)
                    {
                        case "Yes":
                            if(b==true)
                            {
                                rtxtNotepad.SaveFile(odlgNotepad.FileName);
                            }
                            else if(sdlgNotepad.ShowDialog()==DialogResult.OK)
                            {
                                rtxtNotepad.SaveFile(sdlgNotepad.FileName) ;
                            }
                            s = true;
                            break;
                        case "No":
                            b=false;
                            rtxtNotepad.Text = "";
                            break;
                    }
                }
            }
            odlgNotepad.RestoreDirectory=true;
            if((odlgNotepad.ShowDialog()==DialogResult.OK)&&odlgNotepad.FileName!="")
            {
                rtxtNotepad.LoadFile(odlgNotepad.FileName);
                b=true;
            }
            s = true;
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            if(b==true&&rtxtNotepad.Modified==true)
            {
                rtxtNotepad.SaveFile(odlgNotepad.FileName);
                s= true;
            }
            else if(b==false&&rtxtNotepad.Text.Trim()!=""&&
                sdlgNotepad.ShowDialog()==DialogResult.OK)
            {
                rtxtNotepad.SaveFile(sdlgNotepad.FileName);
                s = true;
                b = true;
                odlgNotepad.FileName = sdlgNotepad.FileName;
            }
        }

        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            if(sdlgNotepad.ShowDialog()!=DialogResult.OK)
            {
                rtxtNotepad.SaveFile(sdlgNotepad.FileName);
                s = true;
            }
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiUndo_Click(object sender, EventArgs e)
        {
            rtxtNotepad.Undo();
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            rtxtNotepad.Copy();
        }

        private void tsmiCut_Click(object sender, EventArgs e)
        {
            rtxtNotepad.Cut();
        }

        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            rtxtNotepad.Paste();
        }

        private void tsmiSelectAll_Click(object sender, EventArgs e)
        {
            rtxtNotepad.SelectAll();
        }

        private void tsmiDate_Click(object sender, EventArgs e)
        {
            rtxtNotepad.AppendText(System.DateTime.Now.ToString());
        }

        private void tsmiAuto_Click(object sender, EventArgs e)
        {
            if(tsmiAuto.Checked==false) 
            {
                tsmiAuto.Checked=true;
                rtxtNotepad.WordWrap= true;
            }
            else
            {
                tsmiAuto.Checked=false;
                rtxtNotepad.WordWrap= false;
            }
        }

        private void tsmiFont_Click(object sender, EventArgs e)
        {
            fdlgNotepad.ShowColor=true;
            if(fdlgNotepad.ShowDialog()==DialogResult.OK)
            {
                rtxtNotepad.SelectionColor=fdlgNotepad.Color;
                rtxtNotepad.SelectionFont=fdlgNotepad.Font;
            }
        }

        private void tsmiToolStrip_Click(object sender, EventArgs e)
        {
            Point point;
            if(tsmiToolStrip.Checked==true)
            {
                point = new Point(0, 24);
                tsmiToolStrip.Checked=false;
                tlsNotepad.Visible=false;
                rtxtNotepad.Location=point;
                rtxtNotepad.Height += tlsNotepad.Height;
            }
            else
            {
                point= new Point(0, 49);
                tsmiToolStrip.Checked=true;
                tlsNotepad.Visible = true;
                rtxtNotepad.Location = point;
                rtxtNotepad.Height -= tlsNotepad.Height;
            }
        }

        private void tsmiStatusStrip_Click(object sender, EventArgs e)
        {
            if(tsmiStatusStrip.Checked==true)
            {
                tsmiStatusStrip.Checked=false;
                stsNotepad.Visible=false;
                rtxtNotepad.Height += stsNotepad.Height;
            }
            else
            {
                tsmiStatusStrip.Checked=true;
                stsNotepad.Visible=true;
                rtxtNotepad.Height-= stsNotepad.Height;
            }
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            frmAbout ob_FrmAbout = new frmAbout();
            ob_FrmAbout.Show();
        }

        private void tlsNotepad_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int n;
            n=tlsNotepad.Items.IndexOf(e.ClickedItem);
            switch(n)
            {
                case 0:
                    tsmiNew_Click(sender, e);
                    break;
                case 1:
                    tsmiOpen_Click(sender, e);
                    break;
                case 2:
                    tsmiSave_Click(sender, e);
                    break;
                /*case 3:
                    tsmiCopy_Click(sender, e);
                    break;*/
                case 4:
                    tsmiCut_Click(sender, e);
                    break;
                case 5:
                    tsmiPaste_Click(sender, e);
                    break;
                /*case 6:
                    tsmiPaste_Click(sender, e);
                                        break;*/
                case 7:
                    tsmiAbout_Click(sender, e);
                    break;
            }
        }

        private void tmrNotepad_Tick(object sender, EventArgs e)
        {
            tssLbl2.Text = System.DateTime.Now.ToString();
        }

        private void frmnotepad_SizeChanged(object sender, EventArgs e)
        {
            frmnotepad ob_frmNotepad=new frmnotepad();
            tssLbl1.Width = this.Width / 2 - 12;
            tssLbl2.Width=tssLbl1.Width;
        }
    }
}