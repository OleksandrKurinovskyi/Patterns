using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton
{
    class SingltonClass
    {
        private static Object _locker = new object();

        public static int Counter { get; private set; }

        private static SingltonClass _singltonClass;

        public static SingltonClass GetInstance()
        {
            if (_singltonClass == null)
            {
                lock(_locker)
                {
                    if (_singltonClass == null)
                    {
                        _singltonClass = CreateInstance();
                    }
                }
            }
            return _singltonClass;
        }

        private SingltonClass()
        {

        }

        private static SingltonClass CreateInstance()
        {
            Counter++;
            return new SingltonClass();
        }
    }
}
