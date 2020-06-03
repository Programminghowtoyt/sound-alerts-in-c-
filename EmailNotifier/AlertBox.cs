using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace EmailNotifier
{
    public partial class AlertBox : Form
    {
        string identifier;
        MySoundPlayer player;
        public string SoundFile { get; set; }
        public string AlertMessage { get; set;}
        System.Timers.Timer timer;
        
        public AlertBox()
        {
            InitializeComponent();
        }
        public AlertBox(string Identifier)
        {
            InitializeComponent();
            identifier = Identifier;
            player = new MySoundPlayer(identifier);
            this.StartPosition = FormStartPosition.CenterScreen;
            timer = new System.Timers.Timer(3000);
           
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.CrossThreadUpdate(() => {
                timer.Stop();
                this.closeForm();
            });
          // throw new NotImplementedException();
        }

        private void AlertBox_Load(object sender, EventArgs e)
        {
            lblAlertNumber.Text = identifier;
            lblAlertMessage.Text = AlertMessage;
            player.PlaySound(SoundFile);
          

        }

        private void closeForm()
        {
            
           
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
      
    }
}
