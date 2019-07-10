using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace oop_Polymorphism
{
    class Nokia:BasePhone
    {
        public override void CallSound()
        {
            SoundPlayer player = new SoundPlayer(oop_Polymorphism.Properties.Resources.Nokia_ORIGINAL_Ringtone__online_audio_converter_com_);
            player.PlaySync();
        }
    }
}
