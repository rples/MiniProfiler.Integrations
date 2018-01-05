using System;

namespace MiniProfiler.Integrations.AspNetCore
{
    public delegate string ReviewCommandTextEventHandler<in TEventArgs>(object sender, TEventArgs args) where TEventArgs : EventArgs;
}