using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302210059
{
    public class PosisiKarakterGame
    {
        public enum posisi
        {
            Jongkok,
            Berdiri,
            Tengkurap,
            Terbang
        }
        public enum triggered
        {
            TombolW,
            TombolS,
            TombolX
        }

        public posisi currentState = posisi.Terbang;

        public class Transisi
        {
            public posisi stateawal;
            public posisi stateakhir;
            public triggered triggered;
            public Transisi(posisi stateawal, posisi stateakhir, triggered triggered)
            {
                this.stateawal = stateawal;
                this.stateakhir = stateakhir;
                this.triggered = triggered;
            }
        }

        Transisi[] transisi2 =
        {
            new Transisi(posisi.Berdiri, posisi.Jongkok, triggered.TombolS),
            new Transisi(posisi.Jongkok, posisi.Berdiri, triggered.TombolW),
            new Transisi(posisi.Berdiri, posisi.Terbang, triggered.TombolW),
            new Transisi(posisi.Terbang, posisi.Berdiri, triggered.TombolS),
            new Transisi(posisi.Terbang, posisi.Jongkok, triggered.TombolX),
            new Transisi(posisi.Jongkok, posisi.Tengkurap, triggered.TombolS),
            new Transisi(posisi.Tengkurap, posisi.Jongkok, triggered.TombolW)
        };
        private posisi getstateberikutnya(posisi stateawal, triggered triggered)
        {
            posisi stateakhir = stateawal;
            for(int i = 0; i<transisi2.Length; i++)
            {
                Transisi perubahan = transisi2[i];
                if(stateawal == perubahan.stateawal && triggered == perubahan.triggered)
                {
                    stateakhir = perubahan.stateakhir;
                    stateakhir = perubahan.stateakhir;
                }
            }
            return stateakhir;
        }

        public void triggeredaktif(triggered triggered)
        {
            currentState = getstateberikutnya(currentState, triggered);
            Console.WriteLine("State sekarang adalah " + currentState);
            if(currentState == posisi.Jongkok)
            {
                Console.WriteLine("Posisi landing");
            }else if(posisi.Berdiri == currentState)
            {
                Console.WriteLine("Posisi take off");
            }
        }
    }
}
