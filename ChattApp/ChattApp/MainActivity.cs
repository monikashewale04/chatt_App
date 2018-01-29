using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Telephony;

namespace ChattApp
{
    [Activity(Label = "ChattApp", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        private object txtPhoneNo;
        private object txtSMS;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.buttonSend);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count); 

            // TODO Auto-generated method stub
          // String phoneNo = txtPhoneNo.getText().toString();
          //  String SMS = txtSMS.getText().toString();

            try
            {
               // SmsManager smsManager = SmsManager.getDefault();
                //smsManager.SendTextMessage(phoneNo, null, SMS, null, null);
                Toast.MakeText(this, "SMS Sent!...", ToastLength.Long).Show();

            }
            catch (Exception e)
            {
                Toast.MakeText(this, "SMS faild, please try again later!", ToastLength.Long).Show();
                // e.printStackTrace();
            }
            };
        }

    }

}

