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

        private static SingltonClass _singltonClass;

        public static SingltonClass GetInstance()
        {
            if (_singltonClass == null)
            {
                lock(_locker)
                {
                    if (_singltonClass == null)
                    {
                        _singltonClass = new SingltonClass();
                    }
                }
            }
            return _singltonClass;
        }

        private SingltonClass()
        {

        }
    }
}
