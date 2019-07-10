using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace oop_Polymorphism
{
    public class BasePhone
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual void CallSound()
        {
            //SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory+@"\..\..\Resources\default.wav)

            //task(görev-1):Herbiri için internetten soundlarını bulun call sound metodu çağırıldığında hangi marka çağırıldıysa onun müziği çalsın.
            SoundPlayer player = new SoundPlayer(oop_Polymorphism.Properties.Resources.Nokia_ORIGINAL_Ringtone__online_audio_converter_com_);
            player.PlaySync();




        }
    }
}
