using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Transfer_Objects
{
    public class Notification
    {
        public static PictureBox pbNoti;
        public static Label lbNoti;
        private static string lastMess;
        public static void Show(string _message, Status _status)
        {
            Thread th = new Thread(() => ShowNoti(_message));
            th.IsBackground = true;
            th.Start();
        }
        public static void Show(string _message)
        {
            Thread th = new Thread(() => ShowNoti(_message));
            th.IsBackground = true;
            th.Start();
        }
        public static void ShowNoti(string _message)
        {
            if (lbNoti != null)
            {
                lbNoti.Text = _message;
                lastMess = _message;
            }
            Thread.Sleep(10000);
            if (lastMess == _message) lbNoti.Text = "Ready";
        }
    }
    public enum Status
    {
        ACCESS,
        WARNING
    }
}
