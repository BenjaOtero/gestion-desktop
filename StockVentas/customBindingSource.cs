using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;

namespace StockVentas
{

    public class customBindingSource : BindingSource
    {
        private SynchronizationContext syncContext;
        public customBindingSource()
        {
            syncContext = SynchronizationContext.Current;
        }
        protected override void OnListChanged(ListChangedEventArgs e)
        {
            if (syncContext != null)
                syncContext.Send(_ => base.OnListChanged(e), null);
            else
                base.OnListChanged(e);
        }

    }

}
