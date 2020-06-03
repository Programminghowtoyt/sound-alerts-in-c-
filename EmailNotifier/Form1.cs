using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmailNotifier
{
    public partial class Form1 : Form
    {
        //https://www.youtube.com/channel/UCZ7imtVsCON3H8kcg9CMGTA
        public Form1()
        {
            InitializeComponent();
        }
        EmailNotifier oEmailNotifier;
        private void button1_Click(object sender, EventArgs e)
        {
            oEmailNotifier = new EmailNotifier();
            oEmailNotifier.OnNewEmail += OEmailNotifier_OnNewEmail;
            oEmailNotifier.StartMonitoring();
        }

        private void OEmailNotifier_OnNewEmail(object sender, OnNewEmailEventArgs evtargs)
        {
            this.CrossThreadUpdate(() =>
            {
                evtargs.alertBox.Show(this);
            });
        }
        

    }
}
