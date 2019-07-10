using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace oop_Polymorphism
{
    class Iphone:BasePhone
    {
        public override void CallSound()
        {
            SoundPlayer player = new SoundPlayer(oop_Polymorphism.Properties.Resources._5cccae3fa6c4d6f20673a5d8f6f5853c__online_audio_converter_com_);
            player.PlaySync();
        }
    }
}
