using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2_U3
{
    internal class extent
    {
        public int _Extent;

        public int E
        {
            get { return _Extent; }
            set { _Extent = value; }
        }

        public extent()
        {
            _Extent = 0;
        }

        public void @Extent (int extent_)
        {
            _Extent = extent_;
        }

        public int Perimeter (int _perimeter)
        {
            return _perimeter = _Extent * 12;
        }

        public int Perimeter ()
        {
            return _Extent / 12;
        }

        ~extent()
        {
            //clean
        }
    }

}
