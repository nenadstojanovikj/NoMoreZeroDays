﻿using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Controls;

namespace Rehabitation.Helpers
{
    public class BackHistoryStack
    {
        public static Stack<IStackable> History = new Stack<IStackable>();
    }
}
