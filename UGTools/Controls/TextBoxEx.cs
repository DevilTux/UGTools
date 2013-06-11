using System;
using System.Windows.Forms;

namespace UGTools.Controls
{
    public class TextBoxEx:TextBox
    {
        //private bool _alreadyFocused;
        //public TextBoxEx()
        //{
        //    GotFocus += GotFocusEx;
        //    MouseUp += MouseUpEx;
        //    Leave += LeaveEx;
        //}
        //public virtual void GotFocusEx(object sender, EventArgs e)
        //{
        //    if (MouseButtons == MouseButtons.None)
        //    {
        //        SelectAll();
        //        _alreadyFocused = true;
        //    }
        //}
        //public virtual void LeaveEx(object sender, EventArgs e)
        //{
        //    _alreadyFocused = false;
        //}
        //public virtual void MouseUpEx(object sender, MouseEventArgs e)
        //{
        //    // Web browsers like Google Chrome select the text on mouse up.
        //    // They only do it if the textbox isn't already focused,
        //    // and if the user hasn't selected all text.
        //    if (!_alreadyFocused && SelectionLength == 0)
        //    {
        //        _alreadyFocused = true;
        //        SelectAll();
        //    }
        //}

        private bool _focused;

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (MouseButtons == MouseButtons.None)
            {
                SelectAll();
                _focused = true;
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            _focused = false;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            if (!_focused)
            {
                if (SelectionLength == 0)
                    SelectAll();
                _focused = true;
            }
        }
    }
}
