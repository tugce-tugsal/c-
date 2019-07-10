using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace oop_Polymorphism
{
    class Samsung:BasePhone
    {
        public override void CallSound()
        {
            SoundPlayer player = new SoundPlayer(oop_Polymorphism.Properties.Resources.Samsung_Galaxy___Over_The_Horizon_Ringtone_2018__online_audio_converter_com_);
            player.PlaySync();
        }
    }
}
