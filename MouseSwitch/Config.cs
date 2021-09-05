using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseSwitch
{
    public partial class Config : Form
    {
        static Config me;
        Form1 parent;
        public Config(Form1 f)
        {
            if (me?.Visible==true) me.Close();
            me = this;
            parent = f;
            InitializeComponent();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            ModiKeyBox.Text = HotKeys.GetKeyName(parent.modifier);
            PrevKeyBox.Text = HotKeys.GetKeyName(parent.previous);
            NextKeyBox.Text = HotKeys.GetKeyName(parent.next);
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
                default:
                    parent.previous = e.KeyCode;
                    break;
            }
            PrevKeyBox.Text = HotKeys.GetKeyName(parent.previous);
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
                default:
                    parent.next = e.KeyCode;
                    break;
            }
            NextKeyBox.Text = HotKeys.GetKeyName(parent.next);
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
    }
}
