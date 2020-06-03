using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EmailNotifier
{
    public class OnNewEmailEventArgs: EventArgs
    {
        public AlertBox alertBox { get; set; }
    }

    public delegate void OnNewEmailEventHandler(object sender, OnNewEmailEventArgs evtargs);
    //lets define an event for emailnotifier
    class EmailNotifier
    {
        int AlertCount = 0;// maintain alert counts shown by this object
        public event OnNewEmailEventHandler OnNewEmail;

        public void RaiseOnNewEmail(OnNewEmailEventArgs evtargs)
        {
            if(OnNewEmail!=null)
            {
                OnNewEmail(this, evtargs);
            }
        }

        Thread BackgroundWorker;
        // a background thread for monitoring ibox
        // looking for new email and sending alerts to user.

        public void StartMonitoring()
        {
            BackgroundWorker = new Thread(start);
            BackgroundWorker.Start();
        }
        public void StopMonitoring()
        {
            try
            {
                BackgroundWorker.Abort();
            }
            catch (Exception ex)
            {

            }
        }


        void start()
        {
         
            while (true) 
            {
               
                Thread.Sleep(5000);

                var evtargs = new OnNewEmailEventArgs();
                evtargs.alertBox = new AlertBox(string.Format("Alert#{0}", AlertCount))
                {
                  
                    SoundFile = SoundFiles.NewEmailSound,
                    AlertMessage = "You've got a new mail"
                };
                AlertCount++;
                RaiseOnNewEmail(evtargs);
                


            }
           
        }
    


}
    
}
