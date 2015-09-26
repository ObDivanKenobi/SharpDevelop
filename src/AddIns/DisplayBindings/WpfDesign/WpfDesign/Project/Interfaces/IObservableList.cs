using System.Collections.Generic;
using System.Collections.Specialized;


namespace ICSharpCode.WpfDesign.Interfaces
{
    public interface IObservableList<T> : IList<T>, INotifyCollectionChanged
    {
    }
}
