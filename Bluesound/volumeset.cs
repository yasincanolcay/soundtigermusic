using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Bluesound
{

    class volumeset
    {

        
        [DllImport("winmm.dll")]
        private static extern long mciSendString(String strCommand, StringBuilder strReturn, int iReturnLength, int olmazsaolmaz);

        //sag hoparlor ses ayarı
        public int Sagses
        {
            get
            {
                return 0;
            }
            set
            {
                
                mciSendString(string.Concat("setaudio MediaFile right volume to",value), null, 0, 0);
                
            }
        }
        //sol hoparlor ses ayarı
        public int Solses
        {
            get
            {
                return 0;
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile left volume to", value), null, 0, 0);

            }
        }

        //hoparlor bass ayarı
        public int Bass
        {
            get
            {
                return 0;
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile bass to", value),null, 0, 0);

            }
        }

        //hoparlor tiz ayarı
        public int Tiz
        {
            get
            {
                return 0;
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile treble to", value), null, 0, 0);

            }
        }
    }
}
