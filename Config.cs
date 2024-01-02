using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseSwitcher
{
    public partial class Config : Form
    {
        static Config me;
        Form1 parent;
        public Config(Form1 f)
        {
            if (me?.Visible == true) me.Close();
            me = this;
            parent = f;
            InitializeComponent();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            ModiKeyBox.Text = HotKeys.GetKeyName(parent.modifier);
            PrevKeyBox.Text = parent.previous == Keys.Escape ? "禁用" : HotKeys.GetKeyName(parent.previous);
            NextKeyBox.Text = parent.next == Keys.Escape ? "禁用" : HotKeys.GetKeyName(parent.next);
            shownotify.Checked = parent.shownotifi;
            checkBox1.CheckState = parent.doclipcursor ?
                (parent.enhancedclip ? CheckState.Checked : CheckState.Indeterminate)
                :
                CheckState.Unchecked;
        }

        private void PrevKeyBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Control:
                case Keys.LControlKey:
                case Keys.RControlKey:
                case Keys.Alt:
                case Keys.Shift:
                case Keys.LShiftKey:
                case Keys.RShiftKey:
                case Keys.LWin:
                case Keys.RWin:
                    break;
                case Keys.Escape:
                    parent.previous = e.KeyCode;
                    PrevKeyBox.Text = "禁用";
                    break;
                default:
                    parent.previous = e.KeyCode;
                    PrevKeyBox.Text = HotKeys.GetKeyName(parent.previous);
                    break;
            }
            parent.SaveConfig();
        }

        private void NextKeyBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Control:
                case Keys.LControlKey:
                case Keys.RControlKey:
                case Keys.Alt:
                case Keys.Shift:
                case Keys.LShiftKey:
                case Keys.RShiftKey:
                case Keys.LWin:
                case Keys.RWin:
                    break;
                case Keys.Escape:
                    parent.next = e.KeyCode;
                    NextKeyBox.Text = "禁用";
                    break;
                default:
                    parent.next = e.KeyCode;
                    NextKeyBox.Text = HotKeys.GetKeyName(parent.previous);
                    break;
            }
            parent.SaveConfig();
        }

        private void ModiKeyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ModiKeyBox.Text)
            {
                case "Ctrl":
                    parent.modifier = HotKeys.HotkeyModifiers.Control;
                    break;
                case "Alt":
                    parent.modifier = HotKeys.HotkeyModifiers.Alt;
                    break;
                case "Shift":
                    parent.modifier = HotKeys.HotkeyModifiers.Shift;
                    break;
                case "Win":
                    parent.modifier = HotKeys.HotkeyModifiers.Win;
                    break;
            }
            parent.SaveConfig();
        }

        private void shownotify_CheckedChanged(object sender, EventArgs e)
        {
            parent.shownotifi = shownotify.Checked;
            parent.SaveConfig();
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            parent.enhancedclip = checkBox1.CheckState == CheckState.Checked;
            parent.doclipcursor = parent.enhancedclip || checkBox1.CheckState == CheckState.Indeterminate;
            parent.SaveConfig();
        }
    }
}
