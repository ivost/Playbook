using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Sample.AppLayer
{
    public class Service
    {
        private const int FAKE_WORK_MS = 2000;

        public void LoadUsers()
        {
            System.Threading.Thread.Sleep(FAKE_WORK_MS);
        }

        public void LoadHistory()
        {
            System.Threading.Thread.Sleep(FAKE_WORK_MS);
        }
    }
}
