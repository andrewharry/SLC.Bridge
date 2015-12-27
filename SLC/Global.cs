using Bridge;
using Bridge.Html5;
using System;

namespace SLC
{
    [Namespace(false)]

    public static class GlobalClass
    {
        [Ready]
        static void OnReady()
        {
            Global.Instance.Alert("Ready");
        }

    }
}
